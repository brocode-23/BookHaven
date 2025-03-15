using System.Diagnostics;
using Microsoft.Data.SqlClient;
using BCrypt.Net;
namespace BookHaven
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SeedInitialUser();
            txtusername.Focus();
        }
        private static void SeedInitialUser()
        {
            string connectionString = "Server=LAPTOP-8KCSDFHL;Database=BookHeaven;Integrated Security=True;TrustServerCertificate=True;";
            string username = "admin";
            string password = "123"; // Initial password for the admin user
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if any users exist
                string checkUserQuery = "SELECT COUNT(*) FROM UserLogin";
                SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, connection);
                int userCount = (int)checkUserCommand.ExecuteScalar();

                if (userCount == 0)
                {
                    // No users exist, insert the initial user
                    string insertUserQuery = @"
                    INSERT INTO UserLogin (Username, Password)
                    VALUES (@Username, @PasswordHash)";

                    SqlCommand insertUserCommand = new SqlCommand(insertUserQuery, connection);
                    insertUserCommand.Parameters.AddWithValue("@Username", username);
                    insertUserCommand.Parameters.AddWithValue("@PasswordHash", hashedPassword);

                    insertUserCommand.ExecuteNonQuery();

                    Console.WriteLine("Initial user created successfully.");
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();
        }
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        private bool VerifyPassword(string enteredPassword, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHash);
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you really want to exit?", "exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string Connectionstring = "Server=LAPTOP-8KCSDFHL;Database=BookHeaven;Integrated Security=True;TrustServerCertificate=True;";
            using (SqlConnection conn = new SqlConnection(Connectionstring))
            {
                var userName = txtusername.Text;
                var Password = txtpassword.Text;
                {
                    try
                    {
                        conn.Open();
                        string query = "select Role,Password from UserLogin where username=@Username";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserName", userName);


                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.HasRows)
                            {
                                // Read the user data from the database
                                reader.Read();
                                string role = reader.GetString(0);
                                string storedHash = reader.GetString(1);
                                if (VerifyPassword(Password, storedHash))
                                {
                                    if (role.ToLowerInvariant() == "admin")
                                    {
                                        Form2 adminDashboard = new Form2();
                                        adminDashboard.Show();
                                    }
                                    else
                                    {
                                        SalesClerk memberDashboard = new SalesClerk();
                                        memberDashboard.Show();
                                    }
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect UserName or password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtpassword.Text = string.Empty;
                                    txtusername.Text = string.Empty;
                                    txtusername.Focus();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Incorrect UserName or password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtpassword.Text = string.Empty;
                                txtusername.Text = string.Empty;
                                txtusername.Focus();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            txtusername.Focus();
        }
    }
}
