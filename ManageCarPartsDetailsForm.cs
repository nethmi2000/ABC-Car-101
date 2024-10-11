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
    public partial class ManageCarPartsDetailsForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-NHEOJHS;Initial Catalog=""ABC Car"";Integrated Security=True;TrustServerCertificate=True");
        public ManageCarPartsDetailsForm()
        {
            InitializeComponent();
            CarPartdataGridView.CellClick += new DataGridViewCellEventHandler(CarPartdataGridView_CellContentClick);
            LoadCarPartData(); // Load car data when the form loads
        }

        private void btnAddCarPart_Click(object sender, EventArgs e)
        {
            if (pictureBoxCarPartImage.Image != null)
            {
                try
                {
                    // Open SQL Connection
                    Con.Open();

                    // SQL Insert Command
                    using (SqlCommand command = new SqlCommand("INSERT INTO CarPartDetails (CarPartName, CarPartModel, CarPartQuantity, CarPartPrice, CarPartImage) VALUES (@CarPartName, @CarPartModel, @CarPartQuantity, @CarPartPrice, @CarPartImage)", Con))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@CarPartName", txtBoxCarPartName.Text); // Assuming txtBoxCarPartName is the TextBox for CarPartName
                        command.Parameters.AddWithValue("@CarPartModel", txtBoxCarPartModel.Text); // Assuming txtBoxCarPartModel is the TextBox for CarPartModel
                        command.Parameters.AddWithValue("@CarPartQuantity", int.Parse(txtBoxCarPartQuantity.Text)); // Assuming txtBoxCarPartQuantity is a TextBox or NumericUpDown control
                        command.Parameters.AddWithValue("@CarPartPrice", decimal.Parse(txtBoxCarPartPrice.Text)); // Assuming txtBoxCarPartPrice is a TextBox or NumericUpDown control

                        // Convert the image in pictureBoxCarPartImage to byte array
                        MemoryStream ms = new MemoryStream();
                        pictureBoxCarPartImage.Image.Save(ms, pictureBoxCarPartImage.Image.RawFormat);
                        command.Parameters.AddWithValue("@CarPartImage", ms.ToArray());

                        // Execute the query
                        command.ExecuteNonQuery();
                        MessageBox.Show("Car Part Added Successfully");

                        // Close the SQL connection
                        Con.Close();

                        
                    }
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
            else
            {
                MessageBox.Show("Please load an image for the car part.");
            }
        }

        private void btnLoadImageCarPart_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set filter for image files
                openFileDialog.Filter = "Image Files|.jpg;.jpeg;*.png";

                // Open file dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the selected image into the PictureBox
                    pictureBoxCarPartImage.Image = Image.FromFile(openFileDialog.FileName);

                    // Optionally, store the file path or any other required operations
                    // carPartImagePath = openFileDialog.FileName; // If you need the file path later
                }
            }
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
                CarPartdataGridView.DataSource = dt;

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



        private void CarPartdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CarPartdataGridView.Rows[e.RowIndex];
                txtBoxCarPartID.Text = row.Cells["CarPartID"].Value.ToString();
                txtBoxCarPartName.Text = row.Cells["CarPartName"].Value.ToString();
                txtBoxCarPartModel.Text = row.Cells["CarPartModel"].Value.ToString();
                txtBoxCarPartQuantity.Text = row.Cells["CarPartQuantity"].Value.ToString();
                //txtBoxPrice.Value = Convert.ToDecimal(row.Cells["Price"].Value);
                txtBoxCarPartPrice.Text = row.Cells["CarPartPrice"].Value.ToString();

                if (row.Cells["CarPartImage"].Value != DBNull.Value)
                {
                    byte[] imageData = (byte[])row.Cells["CarPartImage"].Value;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBoxCarPartImage.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBoxCarPartImage.Image = null;
                }
            }
        }

        private void btnCarPartSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the SQL connection
                Con.Open();

                // SQL search query with optional filtering by CarPartName or CarPartID
                string query = "SELECT CarPartID, CarPartName, CarPartModel, CarPartQuantity, CarPartPrice FROM CarPartDetails WHERE CarPartName LIKE '%' + @CarPartName + '%' OR CarPartID = @CarPartID";

                using (SqlCommand command = new SqlCommand(query, Con))
                {
                    // Parameters for search criteria
                    command.Parameters.AddWithValue("@CarPartName", txtBoxCarPartName.Text); // Searching by CarPartName

                    // Handle CarPartID parameter
                    if (Guid.TryParse(txtBoxCarPartID.Text, out Guid carPartID))
                    {
                        command.Parameters.AddWithValue("@CarPartID", carPartID); // Searching by CarPartID (if specified and valid)
                    }
                    else
                    {
                        // Handle cases where CarPartID is not valid or not provided
                        command.Parameters.AddWithValue("@CarPartID", DBNull.Value); // Or adjust based on your needs
                    }

                    // Execute the query and fill the DataGridView
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Bind the search results to the DataGridView
                    CarPartdataGridView.DataSource = dataTable; // Assuming carPartDataGridView is the DataGridView control
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

        private void btnCarPartUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxCarPartID.Text)) // Ensure that CarPartID is not empty
            {
                try
                {
                    // Open SQL connection
                    Con.Open();

                    // SQL Update query
                    string query = "UPDATE CarPartDetails SET CarPartName = @CarPartName, CarPartModel = @CarPartModel, CarPartQuantity = @CarPartQuantity, CarPartPrice = @CarPartPrice, CarPartImage = @CarPartImage WHERE CarPartID = @CarPartID";

                    using (SqlCommand command = new SqlCommand(query, Con))
                    {
                        // Add parameters for the update query
                        command.Parameters.AddWithValue("@CarPartName", txtBoxCarPartName.Text);
                        command.Parameters.AddWithValue("@CarPartModel", txtBoxCarPartModel.Text);
                        command.Parameters.AddWithValue("@CarPartQuantity", int.Parse(txtBoxCarPartQuantity.Text));
                        command.Parameters.AddWithValue("@CarPartPrice", decimal.Parse(txtBoxCarPartPrice.Text));

                        // Convert the image in pictureBoxCarPartImage to byte array
                        if (pictureBoxCarPartImage.Image != null)
                        {
                            MemoryStream ms = new MemoryStream();
                            pictureBoxCarPartImage.Image.Save(ms, pictureBoxCarPartImage.Image.RawFormat);
                            command.Parameters.AddWithValue("@CarPartImage", ms.ToArray());
                        }
                        else
                        {
                            // Handle if no image is selected
                            command.Parameters.AddWithValue("@CarPartImage", DBNull.Value);
                        }

                        // Add the CarPartID parameter
                        command.Parameters.AddWithValue("@CarPartID", txtBoxCarPartID.Text);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        // Provide feedback to the user
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Car Part Updated Successfully");

                           

                            // Reload the data grid view
                            LoadCarPartData();
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified Car Part ID");
                        }
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
                MessageBox.Show("Please select a car part to update.");
            }
        }

        private void btnCarPartDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxCarPartID.Text)) // Ensure that CarPartID is provided
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this car part?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes) // Confirm before deletion
                {
                    try
                    {
                        // Open SQL connection
                        Con.Open();

                        // SQL Delete query
                        string query = "DELETE FROM CarPartDetails WHERE CarPartID = @CarPartID";

                        using (SqlCommand command = new SqlCommand(query, Con))
                        {
                            // Add CarPartID parameter to identify which record to delete
                            command.Parameters.AddWithValue("@CarPartID", txtBoxCarPartID.Text);

                            // Execute the query
                            int rowsAffected = command.ExecuteNonQuery();

                            // Provide feedback to the user
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Car Part Deleted Successfully");

                                // Reload the data grid view to reflect the deletion
                                LoadCarPartData();
                            }
                            else
                            {
                                MessageBox.Show("No record found with the specified Car Part ID");
                            }
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
            }
            else
            {
                MessageBox.Show("Please select a car part to delete.");
            }
        }

        private void btnCarPartClear_Click(object sender, EventArgs e)
        {
            // Clear all the TextBox and PictureBox fields in the form
            txtBoxCarPartID.Clear();
            txtBoxCarPartName.Clear();
            txtBoxCarPartModel.Clear();
            txtBoxCarPartQuantity.Clear();
            txtBoxCarPartPrice.Clear();

            // Clear the PictureBox
            pictureBoxCarPartImage.Image = null;

            // Optionally set focus to the first field
            txtBoxCarPartName.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Create an instance of the Admin_Dashboard form
            Admin_Dashboard adminDashboard = new Admin_Dashboard();

            // Show the Admin_Dashboard form
            adminDashboard.Show();

            // Close the current form
            this.Close();
        }
    }
}
