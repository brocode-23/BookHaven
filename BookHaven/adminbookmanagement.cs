using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BookHaven
{
    public partial class adminbookmanagement : Form
    {
        private readonly string _userroles;
        public adminbookmanagement(string userroles)
        {
            InitializeComponent();
            loadSupplier();
            loadData();
            _userroles = userroles;
        }

        private void loadSupplier()
        {
            string Connectionstring = "Server=LAPTOP-8KCSDFHL;Database=BookHeaven;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM suppliers";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    cmbsupid.DataSource = dataTable;
                    cmbsupid.DisplayMember = "Name";
                    cmbsupid.ValueMember = "supplier_id";

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

        private void btnback_Click(object sender, EventArgs e)
        {
            if (_userroles == "admin")
            {
                Form2 formadmin = new Form2();
                formadmin.Show();
                this.Hide();
            }
            else
            {
                SalesClerk formadmin = new SalesClerk();
                formadmin.Show();
                this.Hide();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            var title = txttitle.Text;
            var author = txtauthor.Text;
            var genre = txtgenre.Text;
            var isbn = txtisbn.Text;
            var price = txtprice.Text;
            var stockquantity = txtstockquantity.Text;
            var supid = cmbsupid.SelectedValue;

            if (title == "")
            {
                MessageBox.Show("Fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (author == "")
            {
                MessageBox.Show("Fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (genre == "")
            {
                MessageBox.Show("Fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isbn == "")
            {
                MessageBox.Show("Fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (price == "")
            {
                MessageBox.Show("Fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (stockquantity == "")
            {
                MessageBox.Show("Fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ConnectionString = "Server=LAPTOP-8KCSDFHL;Database=BookHeaven;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO books (title, author, genre, isbn, price, stock_quantity,supplier_id, created_at, updated_at) " +
                           "VALUES (@Title, @Author, @Genre, @Isbn, @Price, @Stock_quantity,@Sup_id, GETDATE(), GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Author", author);
                        cmd.Parameters.AddWithValue("@Genre", genre);
                        cmd.Parameters.AddWithValue("@Isbn", isbn);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Stock_quantity", stockquantity);
                        cmd.Parameters.AddWithValue("@Sup_id", supid);


                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();
                            ClearText();

                        }
                        else
                        {
                            MessageBox.Show("Failed to save data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
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
        private void loadData()
        {
            string Connectionstring = "Server=LAPTOP-8KCSDFHL;Database=BookHeaven;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT b.book_id, b.Title, b.Author, b.Genre, b.ISBN, b.Price, b.stock_quantity, s.supplier_id,s.name FROM books b INNER JOIN suppliers s ON b.supplier_id = s.supplier_id";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    bookmanagementgrid.DataSource = dataTable;
                    bookmanagementgrid.Columns["supplier_id"].Visible = false;
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        private void ClearText()
        {
            lblbookid.Text = "";
            txttitle.Clear();
            txtauthor.Clear();
            txtgenre.Clear();
            txtisbn.Clear();
            txtprice.Clear();
            txtstockquantity.Clear();
            cmbsupid.Text = "";
            txttitle.Focus();
        }

        private void bookmanagementgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                {
                    if (e.RowIndex >= 0)
                    {
                        //Get Selected row
                        DataGridViewRow selectedRow = bookmanagementgrid.Rows[e.RowIndex];

                        //Display data in Textbox
                        lblbookid.Text = selectedRow.Cells["book_id"].Value.ToString();
                        txttitle.Text = selectedRow.Cells["title"].Value.ToString();
                        txtauthor.Text = selectedRow.Cells["author"].Value.ToString();
                        txtgenre.Text = selectedRow.Cells["genre"].Value.ToString();
                        txtisbn.Text = selectedRow.Cells["isbn"].Value.ToString();
                        txtprice.Text = selectedRow.Cells["price"].Value.ToString();
                        txtstockquantity.Text = selectedRow.Cells["stock_quantity"].Value.ToString();
                        cmbsupid.SelectedValue = selectedRow.Cells["supplier_id"].Value.ToString();
                    }
                }

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string Connectionstring = "Server=LAPTOP-8KCSDFHL;Database=BookHeaven;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                var query = "Update books SET title = @Title, author = @Author, genre = @Genre, isbn = @Isbn, price = @Price, stock_quantity = @Stock_quantity, supplier_id = @Sup_id WHERE book_id = @id";
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", lblbookid.Text);
                            cmd.Parameters.AddWithValue("@Title", txttitle.Text);
                            cmd.Parameters.AddWithValue("@Author", txtauthor.Text);
                            cmd.Parameters.AddWithValue("@Genre", txtgenre.Text);
                            cmd.Parameters.AddWithValue("@Isbn", txtisbn.Text);
                            cmd.Parameters.AddWithValue("@Price", txtprice.Text);
                            cmd.Parameters.AddWithValue("@Stock_quantity", txtstockquantity.Text);
                            cmd.Parameters.AddWithValue("@Sup_id", cmbsupid.SelectedValue);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Book Edited Successfully");
                            loadData();
                            ClearText();
                        }
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
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult messageBoxResponse = MessageBox.Show("Are you sure you want to delete this", "",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (messageBoxResponse == DialogResult.Yes)
            {

                var id = lblbookid.Text;
                string Connectionstring = "Server=LAPTOP-8KCSDFHL;Database=BookHeaven;Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection conn = new SqlConnection(Connectionstring))
                {
                    try
                    {
                        conn.Open();
                        string query = "delete from books where book_id = @id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {

                            cmd.Parameters.AddWithValue("@id", id);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadData();
                                ClearText();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
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
        }

        private void adminbookmanagement_Load(object sender, EventArgs e)
        {

        }

        private void cmbsupid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}