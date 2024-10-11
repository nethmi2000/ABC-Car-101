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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ABC_Car
{
    public partial class ManageCarDetailsForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-NHEOJHS;Initial Catalog=""ABC Car"";Integrated Security=True;TrustServerCertificate=True");
       // string connectionString = @"Data Source=DESKTOP-NHEOJHS;Initial Catalog=""ABC Car"";Integrated Security=True;TrustServerCertificate=True";

        public ManageCarDetailsForm()
        {
            InitializeComponent();
            CardataGridView.CellClick += new DataGridViewCellEventHandler(CardataGridView_CellContentClick);

            LoadCarData(); // Load car data when the form loads



        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
           //under
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (pictureBoxCarImage.Image != null)
            {
                try
                {
                    // Open SQL Connection
                    Con.Open();

                    // SQL Insert Command
                    using (SqlCommand command = new SqlCommand("INSERT INTO CarDetails (CarName, CarModel, Quantity, Price, CarImage) VALUES (@CarName, @CarModel, @Quantity, @Price, @CarImage)", Con))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@CarName", txtBoxCarName.Text); // Assuming txtBoxCarName is the TextBox for CarName
                        command.Parameters.AddWithValue("@CarModel", txtBoxCarModel.Text); // Assuming txtBoxCarModel is the TextBox for CarModel
                        command.Parameters.AddWithValue("@Quantity", int.Parse(txtBoxQuantity.Text)); // Assuming txtBoxQuantity is a TextBox or NumericUpDown control
                        command.Parameters.AddWithValue("@Price", decimal.Parse(txtBoxPrice.Text)); // Assuming txtBoxPrice is a TextBox or NumericUpDown control

                        // Convert the image in pictureBoxCarImage to byte array
                        MemoryStream ms = new MemoryStream();
                        pictureBoxCarImage.Image.Save(ms, pictureBoxCarImage.Image.RawFormat);
                        command.Parameters.AddWithValue("@CarImage", ms.ToArray());

                        // Execute the query
                        command.ExecuteNonQuery();
                        MessageBox.Show("Car Added Successfully");

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
                MessageBox.Show("Please load an image.");
            }

        }

        private void btnLoadImage_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|.jpg;.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxCarImage.Image = Image.FromFile(openFileDialog.FileName); // pictureBoxCarImage is your PictureBox control
                }
            }
        }

        private void LoadCarData()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT CarID, CarName, CarModel, Quantity, Price, CarImage FROM CarDetails", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Bind the data to the DataGridView
                CardataGridView.DataSource = dt;

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

        private void CardataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CardataGridView.Rows[e.RowIndex];
                txtBoxCarID.Text = row.Cells["CarID"].Value.ToString();
                txtBoxCarName.Text = row.Cells["CarName"].Value.ToString();
                txtBoxCarModel.Text = row.Cells["CarModel"].Value.ToString();
                txtBoxQuantity.Text = row.Cells["Quantity"].Value.ToString();
                //txtBoxPrice.Value = Convert.ToDecimal(row.Cells["Price"].Value);
                txtBoxPrice.Text = row.Cells["Price"].Value.ToString();

                if (row.Cells["CarImage"].Value != DBNull.Value)
                {
                    byte[] imageData = (byte[])row.Cells["CarImage"].Value;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBoxCarImage.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBoxCarImage.Image = null;
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtBoxCarName.Text.Trim(); // Assuming txtBoxSearch is the TextBox for search input

            if (!string.IsNullOrEmpty(searchText))
            {
                try
                {
                    // Open SQL Connection
                    Con.Open();

                    // SQL Query to search for cars by CarName or CarModel (you can adjust this as needed)
                    string query = "SELECT CarID, CarName, CarModel, Quantity, Price,CarImage FROM CarDetails WHERE CarName LIKE @SearchText OR CarModel LIKE @SearchText";

                    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                    sda.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    // Bind the result to the DataGridView
                    CardataGridView.DataSource = dt;

                    // Close the SQL connection
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
            else
            {
                // If the search box is empty, reload all car data
                LoadCarData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Ensure the CarID field is not empty (as it is used to identify the car to update)
            if (!string.IsNullOrEmpty(txtBoxCarID.Text) && pictureBoxCarImage.Image != null)
            {
                try
                {
                    // Open SQL Connection
                    Con.Open();

                    // SQL Update Command
                    using (SqlCommand command = new SqlCommand("UPDATE CarDetails SET CarName = @CarName, CarModel = @CarModel, Quantity = @Quantity, Price = @Price, CarImage = @CarImage WHERE CarID = @CarID", Con))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@CarID", txtBoxCarID.Text); // CarID from the hidden field or selected row
                        command.Parameters.AddWithValue("@CarName", txtBoxCarName.Text);
                        command.Parameters.AddWithValue("@CarModel", txtBoxCarModel.Text);
                        command.Parameters.AddWithValue("@Quantity", int.Parse(txtBoxQuantity.Text));
                        command.Parameters.AddWithValue("@Price", decimal.Parse(txtBoxPrice.Text));

                        // Convert the image in pictureBoxCarImage to byte array
                        MemoryStream ms = new MemoryStream();
                        pictureBoxCarImage.Image.Save(ms, pictureBoxCarImage.Image.RawFormat);
                        command.Parameters.AddWithValue("@CarImage", ms.ToArray());

                        // Execute the query to update the record
                        command.ExecuteNonQuery();
                        MessageBox.Show("Car Updated Successfully");

                        // Close the SQL connection
                        Con.Close();

                        // Clear form fields and reload the data grid view
                       
                        LoadCarData(); // Refresh the DataGridView to reflect updated data
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
                MessageBox.Show("Please select a car to update and ensure all fields are filled.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Ensure a car is selected by checking if txtBoxCarID is not empty
            if (!string.IsNullOrEmpty(txtBoxCarID.Text))
            {
                try
                {
                    // Confirm the deletion action
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this car?", "Delete Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Open the SQL connection
                        Con.Open();

                        // SQL Delete command
                        using (SqlCommand command = new SqlCommand("DELETE FROM CarDetails WHERE CarID = @CarID", Con))
                        {
                            // Add CarID as a parameter to identify the correct car to delete
                            command.Parameters.AddWithValue("@CarID", txtBoxCarID.Text);

                            // Execute the delete query
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Car deleted successfully!");

                                

                                // Refresh the DataGridView to remove the deleted car from the list
                                LoadCarData();
                            }
                            else
                            {
                                MessageBox.Show("No car found with the given CarID.");
                            }
                        }
                    }

                    // Close the connection
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    if (Con.State == ConnectionState.Open)
                    {
                        Con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a car to delete.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all the text fields
            txtBoxCarID.Clear();
            txtBoxCarName.Clear();
            txtBoxCarModel.Clear();
            txtBoxQuantity.Clear();
            txtBoxPrice.Clear();
            

            // Clear the picture box
             pictureBoxCarImage.Image = null;

            // Optionally set the focus back to the first field
            txtBoxCarName.Focus();
        }
    }
    }


