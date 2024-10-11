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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            btnCarDetails.Click += btnCarDetails_Click;

        }

        private void btnCarDetails_Click(object sender, EventArgs e)
        {
            // Create an instance of CarDetailsForm
            CarDetailsForm carDetailsForm = new CarDetailsForm();

            // Show the CarDetailsForm
            carDetailsForm.Show();

            // Optionally, hide or close the current Customer form
            this.Hide(); // This will hide the Customer form but not close it
        }

        private void btnCarParts_Click(object sender, EventArgs e)
        {
            // Create an instance of CarDetailsForm
            CarPartsDetailsForm carPartsDetailsForm = new CarPartsDetailsForm();

            // Show the CarDetailsForm
            carPartsDetailsForm.Show();

            // Optionally, hide or close the current Customer form
            this.Hide(); // This will hide the Customer form but not close it
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Show a confirmation message box before logging out
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the current form and navigate back to the login form
                this.Hide(); // Or you can use `this.Close();` if you don't need to reopen this form later

                // Assuming LoginForm is the form name for the login screen
                Form1 Form1 = new Form1();
                Form1.Show();
            }
        }

        private void btnCarOrders_Click(object sender, EventArgs e)
        {
            ViewOrderForm viewOrderForm = new ViewOrderForm();
            viewOrderForm.Show();
        }
    }
}
