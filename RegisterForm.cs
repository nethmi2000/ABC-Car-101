using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
namespace ABC_Car
{
    public partial class RegisterForm : Form
    {
      
        public RegisterForm()
        {
            InitializeComponent();

        }
        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-NHEOJHS;Initial Catalog=""ABC Car"";Integrated Security=True;TrustServerCertificate=True";

           // string connectionString = (@"Data Source=DESKTOP-NHEOJHS;Initial Catalog=ABC_Car;Integrated Security=True;Encrypt=False"); // Update with your SQL Server connection string
            string name = txtBoxName.Text;
            string nic = txtBoxNIC.Text;
            string email = txtBoxEmail.Text;
            string contactNumber = txtBoxContactNumber.Text;
            string address = txtBoxAddress.Text;
            string password = txtBoxPassword.Text;
            string confirmPassword = txtBoxConfirmPassword.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Register (Name, NIC, Email, ContactNumber, Address, Password) " +
                                   "VALUES (@Name, @NIC, @Email, @ContactNumber, @Address, @Password)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@NIC", nic);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Optionally, clear the form after registration
                           
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
             // Clear all the input fields
            txtBoxName.Clear();
            txtBoxNIC.Clear();
            txtBoxEmail.Clear();
            txtBoxContactNumber.Clear();
            txtBoxAddress.Clear();
            txtBoxPassword.Clear();
            txtBoxConfirmPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void linkLabelLOGIN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to the Login form
            this.Hide(); // Hide the current form
            Form1 loginForm = new Form1(); // Assuming you have a LoginForm class
            loginForm.Show(); // Show the Login form
        }

        

    }
    }

