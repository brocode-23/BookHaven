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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using BCrypt.Net;
using System.Diagnostics;

namespace BookHaven
{
    public partial class clearkcreatemanagement : Form
    {
        public clearkcreatemanagement()
        {
            InitializeComponent();
            loadData();
        }
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        private bool VerifyPassword(string enteredPassword, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHash);
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            Form2 Admin = new Form2();
            Admin.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            var username = txtclearkusername.Text;
            var password = txtpassword.Text;
            if (username == "")
            {
                MessageBox.Show("Fields are empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password == "")
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
                    string query = "INSERT INTO UserLogin (Username,Password) " +
                           "VALUES (@username, @password)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", HashPassword(password));

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
                    string query = "SELECT Username, Userid FROM UserLogin WHERE Role = 'clark'";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    clearkgrid.DataSource = dataTable;

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
            txtclearkusername.Clear();
            txtpassword.Clear();
            txtclearkusername.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            var id = txtuserid.Text;
            if (id != "")
            {
                DialogResult messageBoxResponse = MessageBox.Show("Are you sure you want to delete this", "",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (messageBoxResponse == DialogResult.Yes)
                {
                    string Connectionstring = "Server=LAPTOP-8KCSDFHL;Database=BookHeaven;Integrated Security=True;TrustServerCertificate=True;";
                    using (SqlConnection conn = new SqlConnection(Connectionstring))
                    {
                        try
                        {
                            conn.Open();
                            string query = "delete from UserLogin where Userid = @Id";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {

                                cmd.Parameters.AddWithValue("@Id", id);

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
            else
            {
                MessageBox.Show("you have to select a clerk before deleting...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearkgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clearkgrid.CurrentRow != null)
            {
                //DataRowView dataRowView = (DataRowView)dataRowView.CurrentRow.DataBoundItem;
                //Get Selected row
                DataGridViewRow selectedRow = clearkgrid.Rows[e.RowIndex];
                //Display data in Textbox
                txtclearkusername.Text = selectedRow.Cells["Username"].Value.ToString();
                txtuserid.Text = selectedRow.Cells["Userid"].Value.ToString();
                //txtpassword.Text = selectedRow.Cells["Password"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Fields cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text!= "" && txtclearkusername.Text!= "")
            {
                string Connectionstring = "Server=LAPTOP-8KCSDFHL;Database=BookHeaven;Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection conn = new SqlConnection(Connectionstring))
                {
                    var query = "Update UserLogin SET Username = @Username, Password = @Password WHERE Userid = @UserId";
                    {
                        try
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Username", txtclearkusername.Text);
                                cmd.Parameters.AddWithValue("@Password", HashPassword(txtpassword.Text));
                                cmd.Parameters.AddWithValue("@UserId", txtuserid.Text);
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
            
        }
    }
}
