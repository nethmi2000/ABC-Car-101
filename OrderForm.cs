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
    public partial class OrderForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NHEOJHS;Initial Catalog=""ABC Car"";Integrated Security=True;TrustServerCertificate=True");

        public OrderForm()
        {
            InitializeComponent();
        }

        public OrderForm(string carPartID, string carPartName, string carPartModel, string carPartPrice, string customerID)
        {
            InitializeComponent();

            // Set the car part details into textboxes
            txtBoxOrderCarPartID.Text = carPartID;
            txtBoxCarOrderPartName.Text = carPartName;
            txtBoxCarOrderPartModel.Text = carPartModel;
            txtBoxCarOrderPartPrice.Text = carPartPrice;

            // Fetch and set customer details
            LoadCustomerDetails(customerID);
        }

        private void LoadCustomerDetails(string customerID)
        {
            try
            {
                con.Open();
                string query = "SELECT Name, Email, Address, ContactNumber FROM [ABC Car].[dbo].[Register] WHERE CustomerID = @CustomerID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtBoxCarOrderPartCustomerName.Text = reader["Name"].ToString();
                    txtBoxCarOrderPartCustomerEmail.Text = reader["Email"].ToString();
                    txtBoxCarOrderPartCustomerAddress.Text = reader["Address"].ToString();
                    txtBoxCarOrderPartCustomerContactNumber.Text = reader["ContactNumber"].ToString();
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Step 1: Get CustomerID from Register table using Email
                string customerEmail = txtBoxCarOrderPartCustomerEmail.Text;
                string getCustomerIDQuery = "SELECT CustomerID FROM [ABC Car].[dbo].[Register] WHERE Email = @Email";
                SqlCommand getCustomerIDCmd = new SqlCommand(getCustomerIDQuery, con);
                getCustomerIDCmd.Parameters.AddWithValue("@Email", customerEmail);
                object customerIdObj = getCustomerIDCmd.ExecuteScalar();

                if (customerIdObj == null)
                {
                    MessageBox.Show("Customer not found.");
                    return;
                }

                Guid customerId = (Guid)customerIdObj;

                // Step 2: Insert new order into Orders table
                string insertOrderQuery = @"
                    INSERT INTO [ABC Car].[dbo].[Orders] 
                    (OrderID, CustomerID, CarPartID, CustomerName, ContactNumber, Address, Price, OrderDate)
                    VALUES 
                    (@OrderID, @CustomerID, @CarPartID, @CustomerName, @ContactNumber, @Address, @Price, GETDATE())";

                SqlCommand insertOrderCmd = new SqlCommand(insertOrderQuery, con);

                // Generate a new GUID for OrderID
                Guid orderId = Guid.NewGuid();
                insertOrderCmd.Parameters.AddWithValue("@OrderID", orderId);
                insertOrderCmd.Parameters.AddWithValue("@CustomerID", customerId);
                insertOrderCmd.Parameters.AddWithValue("@CarPartID", txtBoxOrderCarPartID.Text);
                insertOrderCmd.Parameters.AddWithValue("@CustomerName", txtBoxCarOrderPartCustomerName.Text);
                insertOrderCmd.Parameters.AddWithValue("@ContactNumber", txtBoxCarOrderPartCustomerContactNumber.Text); // Assuming you have a textbox for contact number
                insertOrderCmd.Parameters.AddWithValue("@Address", txtBoxCarOrderPartCustomerAddress.Text); // Assuming you have a textbox for address
                insertOrderCmd.Parameters.AddWithValue("@Price", txtBoxCarOrderPartPrice.Text);

                int rowsAffected = insertOrderCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order submitted successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to submit order.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
