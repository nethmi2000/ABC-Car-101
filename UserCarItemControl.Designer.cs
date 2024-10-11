namespace ABC_Car
{
    partial class UserCarItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCarItemControl));
            this.lblItemCarID = new System.Windows.Forms.Label();
            this.lblItemCarName = new System.Windows.Forms.Label();
            this.lblItemCarModel = new System.Windows.Forms.Label();
            this.lblItemQuantity = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCarItemCarName = new System.Windows.Forms.Label();
            this.lblCarItemCarModel = new System.Windows.Forms.Label();
            this.lblCarItemQuantity = new System.Windows.Forms.Label();
            this.lblCarItemPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemCarID
            // 
            this.lblItemCarID.AutoSize = true;
            this.lblItemCarID.Location = new System.Drawing.Point(3, 82);
            this.lblItemCarID.Name = "lblItemCarID";
            this.lblItemCarID.Size = new System.Drawing.Size(37, 13);
            this.lblItemCarID.TabIndex = 1;
            this.lblItemCarID.Text = "Car ID";
            // 
            // lblItemCarName
            // 
            this.lblItemCarName.AutoSize = true;
            this.lblItemCarName.Location = new System.Drawing.Point(3, 105);
            this.lblItemCarName.Name = "lblItemCarName";
            this.lblItemCarName.Size = new System.Drawing.Size(54, 13);
            this.lblItemCarName.TabIndex = 2;
            this.lblItemCarName.Text = "Car Name";
            // 
            // lblItemCarModel
            // 
            this.lblItemCarModel.AutoSize = true;
            this.lblItemCarModel.Location = new System.Drawing.Point(3, 131);
            this.lblItemCarModel.Name = "lblItemCarModel";
            this.lblItemCarModel.Size = new System.Drawing.Size(55, 13);
            this.lblItemCarModel.TabIndex = 3;
            this.lblItemCarModel.Text = "Car Model";
            this.lblItemCarModel.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblItemQuantity
            // 
            this.lblItemQuantity.AutoSize = true;
            this.lblItemQuantity.Location = new System.Drawing.Point(3, 155);
            this.lblItemQuantity.Name = "lblItemQuantity";
            this.lblItemQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblItemQuantity.TabIndex = 4;
            this.lblItemQuantity.Text = "Quantity";
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Location = new System.Drawing.Point(3, 179);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(31, 13);
            this.lblItemPrice.TabIndex = 5;
            this.lblItemPrice.Text = "Price";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(76, 82);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 6;
            // 
            // lblCarItemCarName
            // 
            this.lblCarItemCarName.AutoSize = true;
            this.lblCarItemCarName.Location = new System.Drawing.Point(76, 105);
            this.lblCarItemCarName.Name = "lblCarItemCarName";
            this.lblCarItemCarName.Size = new System.Drawing.Size(0, 13);
            this.lblCarItemCarName.TabIndex = 7;
            // 
            // lblCarItemCarModel
            // 
            this.lblCarItemCarModel.AutoSize = true;
            this.lblCarItemCarModel.Location = new System.Drawing.Point(76, 131);
            this.lblCarItemCarModel.Name = "lblCarItemCarModel";
            this.lblCarItemCarModel.Size = new System.Drawing.Size(0, 13);
            this.lblCarItemCarModel.TabIndex = 8;
            // 
            // lblCarItemQuantity
            // 
            this.lblCarItemQuantity.AutoSize = true;
            this.lblCarItemQuantity.Location = new System.Drawing.Point(69, 155);
            this.lblCarItemQuantity.Name = "lblCarItemQuantity";
            this.lblCarItemQuantity.Size = new System.Drawing.Size(0, 13);
            this.lblCarItemQuantity.TabIndex = 9;
            // 
            // lblCarItemPrice
            // 
            this.lblCarItemPrice.AutoSize = true;
            this.lblCarItemPrice.Location = new System.Drawing.Point(69, 179);
            this.lblCarItemPrice.Name = "lblCarItemPrice";
            this.lblCarItemPrice.Size = new System.Drawing.Size(0, 13);
            this.lblCarItemPrice.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserCarItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCarItemPrice);
            this.Controls.Add(this.lblCarItemQuantity);
            this.Controls.Add(this.lblCarItemCarModel);
            this.Controls.Add(this.lblCarItemCarName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.lblItemQuantity);
            this.Controls.Add(this.lblItemCarModel);
            this.Controls.Add(this.lblItemCarName);
            this.Controls.Add(this.lblItemCarID);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserCarItemControl";
            this.Size = new System.Drawing.Size(147, 201);
            this.Load += new System.EventHandler(this.UserCarItemControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblItemCarID;
        private System.Windows.Forms.Label lblItemCarName;
        private System.Windows.Forms.Label lblItemCarModel;
        private System.Windows.Forms.Label lblItemQuantity;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCarItemCarName;
        private System.Windows.Forms.Label lblCarItemCarModel;
        private System.Windows.Forms.Label lblCarItemQuantity;
        private System.Windows.Forms.Label lblCarItemPrice;
    }
}
