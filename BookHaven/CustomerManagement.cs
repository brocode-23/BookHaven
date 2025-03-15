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
using System.Xml.Linq;

namespace BookHaven
{
    public partial class CustomerManagement : Form
    {
        private readonly string _userroles;
        public CustomerManagement(string userroles)
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        private void ClearText()
        {
            lblcusid.Text = "";
            txtcustname.Clear();
            txtemail.Clear();
            txtphonenum.Clear();
            txtaddress.Clear();
            txtcustname.Focus();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            var name = txtcustname.Text;
            var email = txtemail.Text;
            var phone = txtphonenum.Text;
            var address = txtaddress.Text;
            if (name == "")
            {
                MessageBox.Show("Fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (email == "")
            {
                MessageBox.Show("Fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (phone == "")
            {
                MessageBox.Show("Fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (address == "")
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
                    string query = "INSERT INTO customers (customer_id,full_name, email, phone, address, created_at, updated_at) " +
                           "VALUES (@CustomerID, @FullName, @Email, @Phone, @Address, GETDATE(), GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@CustomerID", Guid.NewGuid());

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
        private void customergrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customergrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void custgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    //Get Selected row
                    DataGridViewRow selectedRow = custgrid.Rows[e.RowIndex];

                    //Display data in Textbox
                    lblcusid.Text = selectedRow.Cells["customer_id"].Value.ToString();
                    txtcustname.Text = selectedRow.Cells["full_name"].Value.ToString();
                    txtemail.Text = selectedRow.Cells["email"].Value.ToString();
                    txtphonenum.Text = selectedRow.Cells["phone"].Value.ToString();
                    txtaddress.Text = selectedRow.Cells["address"].Value.ToString();
                }
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string Connectionstring = "Server=LAPTOP-8KCSDFHL;Database=BookHeaven;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                var query = "Update customers SET full_name = @Name, email = @Email, phone = @Phone, address = @Address  WHERE customer_id = @id";
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(lblcusid.Text));
                            cmd.Parameters.AddWithValue("@Name", txtcustname.Text);
                            cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                            cmd.Parameters.AddWithValue("@Phone", txtphonenum.Text);
                            cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Customer Edited Successfully");
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

                var id = lblcusid.Text;
                string Connectionstring = "Server=LAPTOP-8KCSDFHL;Database=BookHeaven;Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection conn = new SqlConnection(Connectionstring))
                {
                    try
                    {
                        conn.Open();
                        string query = "delete from customers where customer_id = @id";
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
    
    
