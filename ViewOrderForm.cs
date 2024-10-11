using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car
{
    public partial class ViewOrderForm : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NHEOJHS;Initial Catalog=""ABC Car"";Integrated Security=True;TrustServerCertificate=True");

        public ViewOrderForm()
        {
            InitializeComponent();
            LoadOrderData();
        }

        private void LoadOrderData()
        {
            try
            {
                // Open the connection to the database
                conn.Open();

                // SQL query to fetch order details from the Orders table
                string query = "SELECT OrderID, CustomerID, CarPartID, CarID, CustomerName, ContactNumber, Address, Price, OrderDate, Status FROM [ABC Car].[dbo].[Orders]";

                // SqlDataAdapter to execute the query and fill the DataTable
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                // Fill the DataTable with the result of the query
                sda.Fill(dt);

                // Bind the DataTable to the DataGridView
                dataGridViewCustomerOrderStatus.DataSource = dt;

                // Close the connection after the operation
                conn.Close();
            }
            catch (Exception ex)
            {
                // Display error message if there’s any issue during data load
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void dataGridViewCustomerOrderStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
