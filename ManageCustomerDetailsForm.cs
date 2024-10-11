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
    public partial class ManageCustomerDetailsForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-NHEOJHS;Initial Catalog=""ABC Car"";Integrated Security=True;TrustServerCertificate=True");

        public ManageCustomerDetailsForm()
        {
            InitializeComponent();
            LoadCustomerData();
            CustomerdataGridView.CellClick += CustomerdataGridView_CellContentClick;
            btnCUpdate.Click += btnCUpdate_Click;


        }

        private void ManageCustomerDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (ValidateCustomerFields()) // Optional: Validate form fields before proceeding
            {
                try
                {
                    // Open the SQL connection
                    Con.Open();

                    // SQL Insert Command
                    string query = "INSERT INTO Register (Name, NIC, Email, ContactNumber, Address, Password, ConfirmPassword) " +
                                   "VALUES (@Name, @NIC, @Email, @ContactNumber, @Address, @Password, @ConfirmPassword)";

                    using (SqlCommand command = new SqlCommand(query, Con))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@Name", txtBoxCName.Text);
                        command.Parameters.AddWithValue("@NIC", txtBoxCNIC.Text);
                        command.Parameters.AddWithValue("@Email", txtBoxCEmail.Text);
                        command.Parameters.AddWithValue("@ContactNumber", txtBoxCContactNumber.Text);
                        command.Parameters.AddWithValue("@Address", txtBoxCAddress.Text);
                        command.Parameters.AddWithValue("@Password", txtBoxCPassword.Text);
                        command.Parameters.AddWithValue("@ConfirmPassword", txtBoxCConfirmPassword.Text);

                        // Execute the insert query
                        command.ExecuteNonQuery();
                        MessageBox.Show("Customer Added Successfully");

                        

                        // Reload the data grid view to reflect the newly added customer
                        LoadCustomerData();
                    }

                    // Close the SQL connection
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (Con.State == ConnectionState.Open)
                    {
                        Con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields correctly.");
            }


        }

        private bool ValidateCustomerFields()
        {
            // Basic validation for required fields
            if (string.IsNullOrEmpty(txtBoxCName.Text) ||
                string.IsNullOrEmpty(txtBoxCNIC.Text) ||
                string.IsNullOrEmpty(txtBoxCEmail.Text) ||
                string.IsNullOrEmpty(txtBoxCContactNumber.Text) ||
                string.IsNullOrEmpty(txtBoxCAddress.Text) ||
                string.IsNullOrEmpty(txtBoxCPassword.Text) ||
                string.IsNullOrEmpty(txtBoxCConfirmPassword.Text) ||
                txtBoxCPassword.Text != txtBoxCConfirmPassword.Text)
            {
                return false;
            }
            return true;
        }

        private void LoadCustomerData()
        {
            try
            {
                // Open the SQL connection
                Con.Open();

                // SQL query to get data from the Register table
                string query = "SELECT Name, NIC, Email, ContactNumber, Address, Password, ConfirmPassword FROM [Register]";

                // SQL Data Adapter to execute the query and fill the DataTable
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Bind the data to the DataGridView
                CustomerdataGridView.DataSource = dt;

                // Close the SQL connection
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void btnCBack_Click(object sender, EventArgs e)
        {
            // Create an instance of the Admin_Dashboard form
            Admin_Dashboard adminDashboard = new Admin_Dashboard();

            // Show the Admin_Dashboard form
            adminDashboard.Show();

            // Close the current form
            this.Close();
        }

        private void btnCUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxCNIC.Text)) // Ensure NIC (or any unique key) is provided for the update
            {
                try
                {
                    // Open SQL connection
                    Con.Open();

                    // SQL Update Command to update customer details based on the NIC
                    string query = @"UPDATE Register 
                             SET Name = @Name, 
                                 Email = @Email, 
                                 ContactNumber = @ContactNumber, 
                                 Address = @Address, 
                                 Password = @Password, 
                                 ConfirmPassword = @ConfirmPassword
                             WHERE NIC = @NIC";

                    using (SqlCommand command = new SqlCommand(query, Con))
                    {
                        // Add the parameters
                        command.Parameters.AddWithValue("@Name", txtBoxCName.Text);
                        command.Parameters.AddWithValue("@Email", txtBoxCEmail.Text);
                        command.Parameters.AddWithValue("@ContactNumber", txtBoxCContactNumber.Text);
                        command.Parameters.AddWithValue("@Address", txtBoxCAddress.Text);
                        command.Parameters.AddWithValue("@Password", txtBoxCPassword.Text);
                        command.Parameters.AddWithValue("@ConfirmPassword", txtBoxCConfirmPassword.Text);
                        command.Parameters.AddWithValue("@NIC", txtBoxCNIC.Text);

                        // Execute the update command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer updated successfully");

                            

                            // Reload the DataGridView to reflect the updated details
                            LoadCustomerData();
                        }
                        else
                        {
                            MessageBox.Show("Customer not found.");
                        }
                    }

                    // Close the connection
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    if (Con.State == ConnectionState.Open)
                    {
                        Con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer or enter the NIC to update.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all the text boxes
            txtBoxCName.Clear();
            txtBoxCNIC.Clear();
            txtBoxCEmail.Clear();
            txtBoxCContactNumber.Clear();
            txtBoxCAddress.Clear();
            txtBoxCPassword.Clear();
            txtBoxCConfirmPassword.Clear();

        }

        private void CustomerdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicked a valid row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = CustomerdataGridView.Rows[e.RowIndex];

                // Populate the form fields with the selected customer's data
                txtBoxCName.Text = row.Cells["Name"].Value.ToString();
                txtBoxCNIC.Text = row.Cells["NIC"].Value.ToString();
                txtBoxCEmail.Text = row.Cells["Email"].Value.ToString();
                txtBoxCContactNumber.Text = row.Cells["ContactNumber"].Value.ToString();
                txtBoxCAddress.Text = row.Cells["Address"].Value.ToString();
                txtBoxCPassword.Text = row.Cells["Password"].Value.ToString();
                txtBoxCConfirmPassword.Text = row.Cells["ConfirmPassword"].Value.ToString();

                // If you have a PictureBox for customer image, load the image as well (if stored in the database as byte array)
                // Assuming image is stored in the DataGridView or fetched separately
            }
        }

        private void btnCDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxCNIC.Text)) // Ensure NIC (or any unique key) is provided
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Open SQL connection
                        Con.Open();

                        // SQL Delete Command to remove the customer based on the NIC
                        string query = "DELETE FROM Register WHERE NIC = @NIC";
                        using (SqlCommand command = new SqlCommand(query, Con))
                        {
                            // Add the NIC parameter
                            command.Parameters.AddWithValue("@NIC", txtBoxCNIC.Text);

                            // Execute the delete command
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer deleted successfully");

                                

                                // Reload the DataGridView to reflect the changes
                                LoadCustomerData();
                            }
                            else
                            {
                                MessageBox.Show("Customer not found.");
                            }
                        }

                        // Close the connection
                        Con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                        if (Con.State == ConnectionState.Open)
                        {
                            Con.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer or enter the NIC.");
            }

        }
    }
}
