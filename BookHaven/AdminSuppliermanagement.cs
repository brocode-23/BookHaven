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
    public partial class AdminSuppliermanagement : Form
    {
        public AdminSuppliermanagement()
        {
            InitializeComponent();
            loadData();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form2 formadmin = new Form2();
            formadmin.Show();
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        private void ClearText()
        {
            lblsupid.Text = "";
            txtsuppliername.Clear();
            txtemail.Clear();
            txtpnum.Clear();
            txtaddress.Clear();
            txtcontactperson.Clear();
            txtsuppliername.Focus();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            var name = txtsuppliername.Text;
            var contactperson = txtcontactperson.Text;
            var email = txtemail.Text;
            var phone = txtpnum.Text;
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
            if (contactperson == "")
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
                    string query = "INSERT INTO suppliers (supplier_id,name, contact_person, phone, email, address, created_at, updated_at) " +
                           "VALUES (@SupplierID,@Name, @ContactPerson, @Phone, @Email, @Address, GETDATE(), GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@ContactPerson", contactperson);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@SupplierID", Guid.NewGuid());


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
                    string query = "SELECT * FROM suppliers";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    suppliergrid.DataSource = dataTable;

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

        private void suppliergrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                {
                    if (e.RowIndex >= 0)
                    {
                        //Get Selected row
                        DataGridViewRow selectedRow = suppliergrid.Rows[e.RowIndex];

                        //Display data in Textbox
                        lblsupid.Text = selectedRow.Cells["supplier_id"].Value.ToString();
                        txtsuppliername.Text = selectedRow.Cells["name"].Value.ToString();
                        txtcontactperson.Text = selectedRow.Cells["contact_person"].Value.ToString();
                        txtpnum.Text = selectedRow.Cells["phone"].Value.ToString();
                        txtemail.Text = selectedRow.Cells["email"].Value.ToString();
                        txtaddress.Text = selectedRow.Cells["phone"].Value.ToString();
                    }
                }

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string Connectionstring = "Server=LAPTOP-8KCSDFHL;Database=BookHeaven;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                var query = "Update suppliers SET name = @Name, contact_person = @ContactPerson, phone = @Phone, email = @Email, address = @Address  WHERE supplier_id = @id";
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(lblsupid.Text));
                            cmd.Parameters.AddWithValue("@Name", txtsuppliername.Text);
                            cmd.Parameters.AddWithValue("@ContactPerson", txtcontactperson.Text);
                            cmd.Parameters.AddWithValue("@Phone", txtpnum.Text);
                            cmd.Parameters.AddWithValue("@email", txtemail.Text);
                            cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Supplier Edited Successfully");
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

                var id = lblsupid.Text;
                string Connectionstring = "Server=LAPTOP-8KCSDFHL;Database=BookHeaven;Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection conn = new SqlConnection(Connectionstring))
                {
                    try
                    {
                        conn.Open();
                        string query = "delete from suppliers where supplier_id = @id";
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
