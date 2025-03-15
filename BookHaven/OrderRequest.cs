using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BookHaven
{
    public partial class OrderRequest : Form
    {
        private decimal totalAmount = 0;

        public OrderRequest()
        {
            InitializeComponent();
            LoadBook();
            LoadBookTitles();
        }

        private void cmbcus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadBookTitles()
        {
            string Connectionstring = "Server=LAPTOP-8KCSDFHL;Database=BookHeaven;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM customers";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    cmbcus.DataSource = dataTable;
                    cmbcus.DisplayMember = "full_name";
                    cmbcus.ValueMember = "customer_id"; ;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    conn.Close();
                }
            }
        }
        private void LoadBook()
        {
            string Connectionstring = "Server=LAPTOP-8KCSDFHL;Database=BookHeaven;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(Connectionstring))
                try
                {
                    {
                        conn.Open();
                        string query = "SELECT book_id, title, author, price, stock_quantity FROM books";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            cmbbook.DataSource = dt;
                            cmbbook.DisplayMember = "title";
                            cmbbook.ValueMember = "book_id";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void cmbbook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbook.SelectedValue != null)
            {
                DataRowView drv = (DataRowView)cmbbook.SelectedItem;
                lblAuthor.Text = drv["author"].ToString();
                lblunitprice.Text = drv["price"].ToString();
                lblqty.Text = drv["stock_quantity"].ToString();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (cmbbook.SelectedValue == null || string.IsNullOrWhiteSpace(txtqty.Text))
            {
                MessageBox.Show("Please select a book and enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtqty.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Enter a valid quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int stock = int.Parse(lblqty.Text);
            if (quantity > stock)
            {
                MessageBox.Show("Not enough stock available!", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal price = decimal.Parse(lblunitprice.Text);
            decimal totalPrice = price * quantity;
            totalAmount += totalPrice;

            // ✅ Ensure dgvCart has a "BookID" column
            dgvCart.Rows.Add(cmbbook.SelectedValue, cmbcus.Text, cmbbook.Text, txtqty.Text, lblAuthor.Text, lblunitprice.Text, lblqty.Text, totalAmount);
            dgvCart.Refresh();

            txttotal.Text = totalAmount.ToString("F2");

            txtqty.Clear();
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            decimal discount = 0;
            if (!string.IsNullOrWhiteSpace(txtdiscount.Text) && decimal.TryParse(txtdiscount.Text, out discount))
            {
                if (discount < 0 || discount > totalAmount)
                {
                    MessageBox.Show("Invalid discount amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtdiscount.Clear();
                    return;
                }
            }

            decimal subtotal = totalAmount - discount;
            txtsubtotal.Text = subtotal.ToString("F2");
        }

        private void btnplaceorder_Click(object sender, EventArgs e)
        {
            if (cmbcus.SelectedValue == null || dgvCart.Rows.Count == 0 || cmbDelivery.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer, add books, and choose a delivery type to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal discount = string.IsNullOrWhiteSpace(txtdiscount.Text) ? 0 : decimal.Parse(txtdiscount.Text);
            decimal subtotal = totalAmount - discount;
            string deliveryType = cmbDelivery.SelectedItem.ToString(); // Get Delivery Type

            try
            {
                string Connectionstring = "Server=LAPTOP-8KCSDFHL;Database=BookHeaven;Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection conn = new SqlConnection(Connectionstring))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction(); // ✅ Start Transaction

                    try
                    {
                        // 1️⃣ Insert into Sales Table with DeliveryType
                        string querySale = @"
        INSERT INTO Sales (CustomerID, TotalAmount, Discount, SubTotal, SaleDate, DeliveryType) 
        VALUES (@CustomerID, @TotalAmount, @Discount, @SubTotal, GETDATE(), @DeliveryType); 
        SELECT SCOPE_IDENTITY();";

                        SqlCommand cmdSale = new SqlCommand(querySale, conn, transaction);
                        cmdSale.Parameters.AddWithValue("@CustomerID", cmbcus.SelectedValue);
                        cmdSale.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        cmdSale.Parameters.AddWithValue("@Discount", discount);
                        cmdSale.Parameters.AddWithValue("@SubTotal", subtotal);
                        cmdSale.Parameters.AddWithValue("@DeliveryType", deliveryType);

                        int saleID = Convert.ToInt32(cmdSale.ExecuteScalar()); // Get SaleID

                        // 2️⃣ Insert SaleDetails & Update Stock
                        foreach (DataGridViewRow row in dgvCart.Rows)
                        {
                            if (row.IsNewRow || row.Cells["ID"].Value == null || row.Cells["ID"].Value == DBNull.Value)
                            {
                                continue; // Skip empty rows
                            }
                            Guid bookID = (Guid)row.Cells["ID"].Value;
                            int quantity = Convert.ToInt32(row.Cells["Qty"].Value);

                            // Insert into SaleDetails
                            string querySaleDetails = "INSERT INTO SaleDetails (SaleID, BookID, Quantity) VALUES (@SaleID, @BookID, @Quantity)";
                            using (SqlCommand cmdSaleDetails = new SqlCommand(querySaleDetails, conn, transaction))
                            {
                                cmdSaleDetails.Parameters.AddWithValue("@SaleID", saleID);
                                cmdSaleDetails.Parameters.AddWithValue("@BookID", bookID);
                                cmdSaleDetails.Parameters.AddWithValue("@Quantity", quantity);
                                cmdSaleDetails.ExecuteNonQuery();
                            }

                            // Update Book Stock
                            string queryUpdateStock = "UPDATE books SET stock_quantity = stock_quantity - @Quantity WHERE book_id = @BookID";
                            using (SqlCommand cmdUpdateStock = new SqlCommand(queryUpdateStock, conn, transaction))
                            {
                                cmdUpdateStock.Parameters.AddWithValue("@Quantity", quantity);
                                cmdUpdateStock.Parameters.AddWithValue("@BookID", bookID);
                                cmdUpdateStock.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit(); // ✅ Commit Transaction
                        MessageBox.Show("Sale completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 3️⃣ Reset Form
                        dgvCart.Rows.Clear();
                        totalAmount = 0;
                        txttotal.Text = "0.00";
                        txtdiscount.Clear();
                        txtsubtotal.Text = "0.00";
                        cmbDelivery.SelectedIndex = -1; // Reset delivery type selection
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // ❌ Rollback in case of error
                        MessageBox.Show("Error saving sale: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            ordermanagement order = new ordermanagement("clark");
            order.Show();
            this.Hide();
        }
    }
}
