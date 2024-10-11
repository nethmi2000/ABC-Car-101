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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMangeCarDetails_Click(object sender, EventArgs e)
        {
            ManageCarDetailsForm manageCarDetailsForm = new ManageCarDetailsForm();
            manageCarDetailsForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnManageCarPartDetails_Click(object sender, EventArgs e)
        {
            ManageCarPartsDetailsForm manageCarPartsDetailsForm = new ManageCarPartsDetailsForm();
            manageCarPartsDetailsForm.Show();
        }

        private void btnManageCoustomerDetails_Click(object sender, EventArgs e)
        {
            ManageCustomerDetailsForm manageCustomerDetailsForm = new ManageCustomerDetailsForm();
            manageCustomerDetailsForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Create an instance of the Admin_Dashboard form
            Form1 form1 = new Form1();

            // Show the Admin_Dashboard form
            form1.Show();

            // Close the current form
            this.Close();
        }
    }
}
