namespace ABC_Car
{
    partial class ManageCustomerDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCBack = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnCUpdate = new System.Windows.Forms.Button();
            this.btnCDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCNIC = new System.Windows.Forms.Label();
            this.lblCEmail = new System.Windows.Forms.Label();
            this.lblCContactNumber = new System.Windows.Forms.Label();
            this.lblCAddress = new System.Windows.Forms.Label();
            this.lblCPassword = new System.Windows.Forms.Label();
            this.lblCConfirmPasword = new System.Windows.Forms.Label();
            this.txtBoxCName = new System.Windows.Forms.TextBox();
            this.txtBoxCNIC = new System.Windows.Forms.TextBox();
            this.txtBoxCEmail = new System.Windows.Forms.TextBox();
            this.txtBoxCContactNumber = new System.Windows.Forms.TextBox();
            this.txtBoxCAddress = new System.Windows.Forms.TextBox();
            this.txtBoxCPassword = new System.Windows.Forms.TextBox();
            this.lblCName = new System.Windows.Forms.Label();
            this.txtBoxCConfirmPassword = new System.Windows.Forms.TextBox();
            this.CustomerdataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.btnCBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Customer Details";
            // 
            // btnCBack
            // 
            this.btnCBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCBack.ForeColor = System.Drawing.Color.Gold;
            this.btnCBack.Location = new System.Drawing.Point(31, 24);
            this.btnCBack.Name = "btnCBack";
            this.btnCBack.Size = new System.Drawing.Size(75, 23);
            this.btnCBack.TabIndex = 1;
            this.btnCBack.Text = "Back";
            this.btnCBack.UseVisualStyleBackColor = false;
            this.btnCBack.Click += new System.EventHandler(this.btnCBack_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Gold;
            this.btnAddCustomer.Location = new System.Drawing.Point(27, 108);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(83, 23);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnCUpdate
            // 
            this.btnCUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnCUpdate.Location = new System.Drawing.Point(27, 169);
            this.btnCUpdate.Name = "btnCUpdate";
            this.btnCUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCUpdate.TabIndex = 2;
            this.btnCUpdate.Text = "Update";
            this.btnCUpdate.UseVisualStyleBackColor = false;
            this.btnCUpdate.Click += new System.EventHandler(this.btnCUpdate_Click);
            // 
            // btnCDelete
            // 
            this.btnCDelete.BackColor = System.Drawing.Color.Gold;
            this.btnCDelete.Location = new System.Drawing.Point(27, 225);
            this.btnCDelete.Name = "btnCDelete";
            this.btnCDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCDelete.TabIndex = 3;
            this.btnCDelete.Text = "Delete";
            this.btnCDelete.UseVisualStyleBackColor = false;
            this.btnCDelete.Click += new System.EventHandler(this.btnCDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gold;
            this.btnClear.Location = new System.Drawing.Point(27, 283);
            this.btnClear.Name = "btnClear";
            this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCNIC
            // 
            this.lblCNIC.AutoSize = true;
            this.lblCNIC.ForeColor = System.Drawing.Color.Gold;
            this.lblCNIC.Location = new System.Drawing.Point(139, 116);
            this.lblCNIC.Name = "lblCNIC";
            this.lblCNIC.Size = new System.Drawing.Size(25, 13);
            this.lblCNIC.TabIndex = 6;
            this.lblCNIC.Text = "NIC";
            // 
            // lblCEmail
            // 
            this.lblCEmail.AutoSize = true;
            this.lblCEmail.ForeColor = System.Drawing.Color.Gold;
            this.lblCEmail.Location = new System.Drawing.Point(139, 159);
            this.lblCEmail.Name = "lblCEmail";
            this.lblCEmail.Size = new System.Drawing.Size(32, 13);
            this.lblCEmail.TabIndex = 7;
            this.lblCEmail.Text = "Email";
            // 
            // lblCContactNumber
            // 
            this.lblCContactNumber.AutoSize = true;
            this.lblCContactNumber.ForeColor = System.Drawing.Color.Gold;
            this.lblCContactNumber.Location = new System.Drawing.Point(139, 197);
            this.lblCContactNumber.Name = "lblCContactNumber";
            this.lblCContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblCContactNumber.TabIndex = 8;
            this.lblCContactNumber.Text = "Contact Number";
            // 
            // lblCAddress
            // 
            this.lblCAddress.AutoSize = true;
            this.lblCAddress.ForeColor = System.Drawing.Color.Gold;
            this.lblCAddress.Location = new System.Drawing.Point(471, 82);
            this.lblCAddress.Name = "lblCAddress";
            this.lblCAddress.Size = new System.Drawing.Size(45, 13);
            this.lblCAddress.TabIndex = 9;
            this.lblCAddress.Text = "Address";
            // 
            // lblCPassword
            // 
            this.lblCPassword.AutoSize = true;
            this.lblCPassword.ForeColor = System.Drawing.Color.Gold;
            this.lblCPassword.Location = new System.Drawing.Point(471, 123);
            this.lblCPassword.Name = "lblCPassword";
            this.lblCPassword.Size = new System.Drawing.Size(53, 13);
            this.lblCPassword.TabIndex = 10;
            this.lblCPassword.Text = "Password";
            // 
            // lblCConfirmPasword
            // 
            this.lblCConfirmPasword.AutoSize = true;
            this.lblCConfirmPasword.ForeColor = System.Drawing.Color.Gold;
            this.lblCConfirmPasword.Location = new System.Drawing.Point(471, 169);
            this.lblCConfirmPasword.Name = "lblCConfirmPasword";
            this.lblCConfirmPasword.Size = new System.Drawing.Size(86, 13);
            this.lblCConfirmPasword.TabIndex = 11;
            this.lblCConfirmPasword.Text = "Confirm Pasword";
            // 
            // txtBoxCName
            // 
            this.txtBoxCName.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtBoxCName.ForeColor = System.Drawing.Color.Gold;
            this.txtBoxCName.Location = new System.Drawing.Point(205, 75);
            this.txtBoxCName.Name = "txtBoxCName";
            this.txtBoxCName.Size = new System.Drawing.Size(200, 20);
            this.txtBoxCName.TabIndex = 13;
            // 
            // txtBoxCNIC
            // 
            this.txtBoxCNIC.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtBoxCNIC.ForeColor = System.Drawing.Color.Gold;
            this.txtBoxCNIC.Location = new System.Drawing.Point(205, 116);
            this.txtBoxCNIC.Name = "txtBoxCNIC";
            this.txtBoxCNIC.Size = new System.Drawing.Size(200, 20);
            this.txtBoxCNIC.TabIndex = 14;
            // 
            // txtBoxCEmail
            // 
            this.txtBoxCEmail.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtBoxCEmail.ForeColor = System.Drawing.Color.Gold;
            this.txtBoxCEmail.Location = new System.Drawing.Point(205, 156);
            this.txtBoxCEmail.Name = "txtBoxCEmail";
            this.txtBoxCEmail.Size = new System.Drawing.Size(200, 20);
            this.txtBoxCEmail.TabIndex = 15;
            // 
            // txtBoxCContactNumber
            // 
            this.txtBoxCContactNumber.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtBoxCContactNumber.ForeColor = System.Drawing.Color.Gold;
            this.txtBoxCContactNumber.Location = new System.Drawing.Point(229, 197);
            this.txtBoxCContactNumber.Name = "txtBoxCContactNumber";
            this.txtBoxCContactNumber.Size = new System.Drawing.Size(176, 20);
            this.txtBoxCContactNumber.TabIndex = 16;
            // 
            // txtBoxCAddress
            // 
            this.txtBoxCAddress.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtBoxCAddress.ForeColor = System.Drawing.Color.Gold;
            this.txtBoxCAddress.Location = new System.Drawing.Point(535, 79);
            this.txtBoxCAddress.Name = "txtBoxCAddress";
            this.txtBoxCAddress.Size = new System.Drawing.Size(253, 20);
            this.txtBoxCAddress.TabIndex = 17;
            // 
            // txtBoxCPassword
            // 
            this.txtBoxCPassword.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtBoxCPassword.ForeColor = System.Drawing.Color.Gold;
            this.txtBoxCPassword.Location = new System.Drawing.Point(535, 123);
            this.txtBoxCPassword.Name = "txtBoxCPassword";
            this.txtBoxCPassword.Size = new System.Drawing.Size(253, 20);
            this.txtBoxCPassword.TabIndex = 18;
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.ForeColor = System.Drawing.Color.Gold;
            this.lblCName.Location = new System.Drawing.Point(139, 75);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(35, 13);
            this.lblCName.TabIndex = 19;
            this.lblCName.Text = "Name";
            // 
            // txtBoxCConfirmPassword
            // 
            this.txtBoxCConfirmPassword.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtBoxCConfirmPassword.ForeColor = System.Drawing.Color.Gold;
            this.txtBoxCConfirmPassword.Location = new System.Drawing.Point(563, 172);
            this.txtBoxCConfirmPassword.Name = "txtBoxCConfirmPassword";
            this.txtBoxCConfirmPassword.Size = new System.Drawing.Size(225, 20);
            this.txtBoxCConfirmPassword.TabIndex = 20;
            // 
            // CustomerdataGridView
            // 
            this.CustomerdataGridView.BackgroundColor = System.Drawing.Color.Gold;
            this.CustomerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerdataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CustomerdataGridView.Location = new System.Drawing.Point(142, 225);
            this.CustomerdataGridView.Name = "CustomerdataGridView";
            this.CustomerdataGridView.Size = new System.Drawing.Size(646, 211);
            this.CustomerdataGridView.TabIndex = 21;
            this.CustomerdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerdataGridView_CellContentClick);
            // 
            // ManageCustomerDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerdataGridView);
            this.Controls.Add(this.txtBoxCConfirmPassword);
            this.Controls.Add(this.lblCName);
            this.Controls.Add(this.txtBoxCPassword);
            this.Controls.Add(this.txtBoxCAddress);
            this.Controls.Add(this.txtBoxCContactNumber);
            this.Controls.Add(this.txtBoxCEmail);
            this.Controls.Add(this.txtBoxCNIC);
            this.Controls.Add(this.txtBoxCName);
            this.Controls.Add(this.lblCConfirmPasword);
            this.Controls.Add(this.lblCPassword);
            this.Controls.Add(this.lblCAddress);
            this.Controls.Add(this.lblCContactNumber);
            this.Controls.Add(this.lblCEmail);
            this.Controls.Add(this.lblCNIC);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCDelete);
            this.Controls.Add(this.btnCUpdate);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCustomerDetailsForm";
            this.Text = "ManageCustomerDetailsForm";
            this.Load += new System.EventHandler(this.ManageCustomerDetailsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCBack;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnCUpdate;
        private System.Windows.Forms.Button btnCDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCNIC;
        private System.Windows.Forms.Label lblCEmail;
        private System.Windows.Forms.Label lblCContactNumber;
        private System.Windows.Forms.Label lblCAddress;
        private System.Windows.Forms.Label lblCPassword;
        private System.Windows.Forms.Label lblCConfirmPasword;
        private System.Windows.Forms.TextBox txtBoxCName;
        private System.Windows.Forms.TextBox txtBoxCNIC;
        private System.Windows.Forms.TextBox txtBoxCEmail;
        private System.Windows.Forms.TextBox txtBoxCContactNumber;
        private System.Windows.Forms.TextBox txtBoxCAddress;
        private System.Windows.Forms.TextBox txtBoxCPassword;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.TextBox txtBoxCConfirmPassword;
        private System.Windows.Forms.DataGridView CustomerdataGridView;
    }
}