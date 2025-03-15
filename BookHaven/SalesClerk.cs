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
    public partial class SalesClerk : Form
    {
        public SalesClerk()
        {
            InitializeComponent();
            loadData();
            BookLoadData();
            OrderloadData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you really want to Logout?", "exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
        }

        private void btncustomermanagement_Click(object sender, EventArgs e)
        {

            CustomerManagement customer = new CustomerManagement("clark");
            customer.Show();
            this.Hide();
        }

        private void btnbookmanagement_Click(object sender, EventArgs e)
        {
            adminbookmanagement adminbookM = new adminbookmanagement("clark");
            adminbookM.Show();
            this.Hide();
        }

        private void btnsalestranscation_Click(object sender, EventArgs e)
        {
            salestransaction sales = new salestransaction("clark");
            sales.Show();
            this.Hide();
        }

        private void btnordermanagement_Click(object sender, EventArgs e)
        {
            ordermanagement order = new ordermanagement("clark");
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
                    string query = "SELECT * FROM customers";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    custgrid.DataSource = dataTable;

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
        private void BookLoadData()
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
        private void OrderloadData()
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
    }
}
