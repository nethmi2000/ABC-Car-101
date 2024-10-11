using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NHEOJHS;Initial Catalog=""ABC Car"";Integrated Security=True;TrustServerCertificate=True");

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            // Retrieve input from text boxes
            string username = txtboxUsername.Text;
            string password = txtboxPassword.Text;

            try
            {
                conn.Open();

                // Check Admin Login
                string adminQuery = "SELECT COUNT(1) FROM [ABC Car].[dbo].[admin_login] WHERE [username]=@username AND [password]=@password";
                using (SqlCommand cmd = new SqlCommand(adminQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int adminCount = Convert.ToInt32(cmd.ExecuteScalar());
                    if (adminCount == 1)
                    {
                        // Redirect to Admin Dashboard
                        Admin_Dashboard adminDashboard = new Admin_Dashboard();
                        this.Hide();
                        adminDashboard.Show();
                        return;
                    }
                }

                // Check Customer Login
                string customerQuery = @"SELECT CustomerID, Name, Email, Address, ContactNumber 
                                         FROM [ABC Car].[dbo].[Register] 
                                         WHERE [Email]=@Email AND [Password]=@Password";

                using (SqlCommand cmd = new SqlCommand(customerQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve customer details
                            string customerID = reader["CustomerID"].ToString();
                            string customerName = reader["Name"].ToString();
                            string customerEmail = reader["Email"].ToString();
                            string customerAddress = reader["Address"].ToString();
                            string customerContactNumber = reader["ContactNumber"].ToString();

                            // Set the customer session with all retrieved data
                            SessionManager.SetCustomerSession(customerID, customerName, customerEmail, customerAddress, customerContactNumber);

                            // Redirect to Customer Dashboard
                            Customer customer = new Customer();
                            this.Hide();
                            customer.Show();
                            return;
                        }
                    }
                }

                // If no match, show error
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create and show the RegisterForm
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();

            // Optionally hide the LoginForm to make it less cluttered
            this.Hide();
        }
    }
}
