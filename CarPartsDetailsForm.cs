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
    public partial class CarPartsDetailsForm : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-NHEOJHS;Initial Catalog=""ABC Car"";Integrated Security=True;TrustServerCertificate=True");

        public CarPartsDetailsForm()
        {
            InitializeComponent();
            dataGridViewCarPartsDetails.CellClick += new DataGridViewCellEventHandler(dataGridViewCarPartsDetails_CellContentClick);
            LoadCarPartData(); // Load car data when the form loads

        }

        private void btnCarPartDetails_Click(object sender, EventArgs e)
        {

        }

        private void LoadCarPartData()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT CarPartID, CarPartName, CarPartModel, CarPartQuantity, CarPartPrice, CarPartImage FROM CarPartDetails", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Bind the data to the DataGridView
                dataGridViewCarPartsDetails.DataSource = dt;

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (Con.State == System.Data.ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchPartByName(txtBoxCarPartsDetails.Text);
        }
        private void SearchPartByName(string carPartName)
        {
            if (!string.IsNullOrEmpty(carPartName))
            {
                try
                {
                    Con.Open();
                    using (SqlCommand command = new SqlCommand("SELECT CarPartID, CarPartName, CarPartModel, CarPartQuantity, CarPartPrice , CarPartImage FROM CarPartDetails WHERE CarPartName = @CarPartName", Con))
                    {
                        command.Parameters.AddWithValue("@CarPartName", carPartName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Assuming txtBoxDetailsCarName, txtBoxDetailsCarModel are TextBox controls
                                txtBoxCarPartId.Text = reader["CarPartID"].ToString();

                                txtBoxDetailsCarPartName.Text = reader["CarPartName"].ToString();
                                txtBoxDetailsCarPartModel.Text = reader["CarPartModel"].ToString();

                                // For numeric fields like Quantity and Price, convert from string
                                txtBoxDetailsCarPartQuantity.Text = reader["CarPartQuantity"].ToString(); // Assuming this is a TextBox
                                txtBoxDetailsCarPartPrice.Text = reader["CarPartPrice"].ToString(); // Assuming this is a TextBox

                                if (reader["CarPartImage"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader["CarPartImage"];
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        pictureBoxCarPartDetails.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    pictureBoxCarPartDetails.Image = null;
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

            private void btnBack_Click(object sender, EventArgs e)
        {
            // Create an instance of the Admin_Dashboard form
            Customer customer = new Customer();

            // Show the Admin_Dashboard form
            customer.Show();

            // Close the current form
            this.Close();
        }

        private void dataGridViewCarPartsDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCarPartsDetails.Rows[e.RowIndex];
                //txtBoxCarPartID.Text = row.Cells["CarPartID"].Value.ToString();
                txtBoxDetailsCarPartName.Text = row.Cells["CarPartName"].Value.ToString();
                txtBoxDetailsCarPartModel.Text = row.Cells["CarPartModel"].Value.ToString();
                txtBoxDetailsCarPartQuantity.Text = row.Cells["CarPartQuantity"].Value.ToString();
                //txtBoxPrice.Value = Convert.ToDecimal(row.Cells["Price"].Value);
                txtBoxDetailsCarPartPrice.Text = row.Cells["CarPartPrice"].Value.ToString();

                if (row.Cells["CarPartImage"].Value != DBNull.Value)
                {
                    byte[] imageData = (byte[])row.Cells["CarPartImage"].Value;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBoxCarPartDetails.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBoxCarPartDetails.Image = null;
                }
            }
        }

        private void btnORDER_Click(object sender, EventArgs e)
        {
            if (dataGridViewCarPartsDetails.SelectedRows.Count > 0)
            {
                // Get the selected car part details
                DataGridViewRow row = dataGridViewCarPartsDetails.SelectedRows[0];
                string carPartID = row.Cells["CarPartID"].Value.ToString();
                string carPartName = row.Cells["CarPartName"].Value.ToString();
                string carPartModel = row.Cells["CarPartModel"].Value.ToString();
                string carPartPrice = row.Cells["CarPartPrice"].Value.ToString();

                // Get logged-in customer info
                string customerID = GetLoggedInCustomerID(); 
                string customerName = GetLoggedInCustomerName();

                // Create an instance of OrderForm, passing the car part details and customer ID
                OrderForm orderForm = new OrderForm(carPartID, carPartName, carPartModel, carPartPrice, customerID);
                orderForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a car part first.");
            }


        }

        private string GetLoggedInCustomerID()
        {
            // Assuming you have a session management class, return the logged-in user's ID.
            return SessionManager.LoggedInCustomerID;
        }
        private string GetLoggedInCustomerName()
        {
            // Assuming you have a session management class, return the logged-in user's name.
            return SessionManager.LoggedInCustomerName;
        }

        private string GetLoggedInCustomerEmail()
        {
            // Assuming you have a session management class, return the logged-in user's email.
            return SessionManager.LoggedInCustomerEmail;
        }

        private string GetLoggedInCustomerAddress()
        {
            return SessionManager.LoggedInCustomerAddress;
        }

        private string GetLoggedInCustomerContactNumber()
        {
            return SessionManager.LoggedInCustomerContactNumber;
        }
    }
}
