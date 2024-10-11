using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car
{
    public partial class CarDetailsForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-NHEOJHS;Initial Catalog=""ABC Car"";Integrated Security=True;TrustServerCertificate=True");

        public CarDetailsForm()
        {
            InitializeComponent();
        }

        private void CarDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDetailsSerach_Click(object sender, EventArgs e)
        {
            SearchCarByName(txtBoxDetailsCarName.Text);
        }

        private void SearchCarByName(string carName)
        {
            if (!string.IsNullOrEmpty(carName))
            {
                try
                {
                    Con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT CarID, CarName, CarModel, Quantity, Price, CarImage FROM CarDetails WHERE CarName = @CarName", Con))
                    {
                        command.Parameters.AddWithValue("@CarName", carName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Assuming txtBoxDetailsCarName, txtBoxDetailsCarModel are TextBox controls
                                txtBoxDetailsCarName.Text = reader["CarName"].ToString();
                                txtBoxDetailsCarModel.Text = reader["CarModel"].ToString();

                                // For numeric fields like Quantity and Price, convert from string
                                txtBoxDetailsCarQuantity.Text = reader["Quantity"].ToString(); // Assuming this is a TextBox
                                txtBoxDetailsPrice.Text = reader["Price"].ToString(); // Assuming this is a TextBox

                                if (reader["CarImage"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader["CarImage"];
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        pictureBoxCarImage1.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    pictureBoxCarImage1.Image = null;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No car found with the provided name.");
                                // Clear fields or perform additional actions if needed
                            }
                        }
                    }
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
                MessageBox.Show("Please enter a car name to search.");
            }
        }

        private void btnCarDetailsBack_Click(object sender, EventArgs e)
        {
            // Create an instance of the Admin_Dashboard form
            Customer customer = new Customer();

            // Show the Admin_Dashboard form
            customer.Show();

            // Close the current form
            this.Close();
        }
    }
}
