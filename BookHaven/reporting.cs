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
    public partial class reporting : Form
    {
        private string ConnectionString = "Server=LAPTOP-8KCSDFHL;Database=BookHeaven;Integrated Security=True;TrustServerCertificate=True;";

        public reporting()
        {
            InitializeComponent();
            LoadData("Daily"); // Load daily sales by default
            InitializeComboBox();

        }
        private void InitializeComboBox()
        {
            comboBoxFilter.Items.Add("Daily");
            comboBoxFilter.Items.Add("Weekly");
            comboBoxFilter.Items.Add("Monthly");
            comboBoxFilter.SelectedIndex = 0; // Default selection
           // comboBoxFilter.SelectedIndexChanged += ComboBoxFilter_SelectedIndexChanged;
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            Form2 adminform = new Form2();
            adminform.Show();
            this.Hide();
        }
        private void LoadData(string filter)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Sales WHERE SaleDate >= @StartDate AND SaleDate <= @EndDate";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        DateTime today = DateTime.Today;
                        DateTime startDate = today;
                        DateTime endDate = today;

                        switch (filter)
                        {
                            case "Daily":
                                startDate = today;
                                endDate = today;
                                break;
                            case "Weekly":
                                startDate = today.AddDays(-(int)today.DayOfWeek);
                                endDate = startDate.AddDays(6);
                                break;
                            case "Monthly":
                                startDate = new DateTime(today.Year, today.Month, 1);
                                endDate = startDate.AddMonths(1).AddDays(-1);
                                break;
                        }

                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);

                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);

                        reportingGrid.DataSource = dataTable;
                        reportingGrid.Columns["SaleID"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cmbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(comboBoxFilter.SelectedItem.ToString());

        }
    }
}
