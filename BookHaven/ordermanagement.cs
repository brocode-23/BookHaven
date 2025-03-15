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
    public partial class ordermanagement : Form
    {
        private readonly string _userroles;
        public ordermanagement(string userroles)
        {
            InitializeComponent();
            loadData();
            _userroles = userroles;
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
            OrderRequest order = new OrderRequest();
            order.Show();
            this.Hide();
        }
        private void loadData()
        {
            string Connectionstring = "Server=LAPTOP-8KCSDFHL;Database=BookHeaven;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Sales.SaleID, customers.full_name, Sales.TotalAmount, Sales.Discount, Sales.SubTotal, Sales.SaleDate, Sales.DeliveryType FROM Sales INNER JOIN customers ON Sales.CustomerID = customers.customer_id";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    ordergatagrid.DataSource = dataTable;
                    ordergatagrid.Columns["SaleID"].Visible = false;
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

        private void ordergatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Connectionstring = "Server=LAPTOP-8KCSDFHL;Database=BookHeaven;Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection conn = new SqlConnection(Connectionstring))
                {
                    conn.Open();
                    string query = @"SELECT Sales.SaleID, customers.full_name, Sales.TotalAmount, Sales.Discount, Sales.SubTotal, Sales.SaleDate, Sales.DeliveryType FROM Sales INNER JOIN customers ON Sales.CustomerID = customers.customer_id WHERE customers.full_name LIKE @SearchText";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + txtsearch.Text + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    ordergatagrid.DataSource = dt;  // Update DataGridView
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching sales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}

