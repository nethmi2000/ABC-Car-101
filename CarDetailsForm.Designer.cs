namespace ABC_Car
{
    partial class CarDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarDetailsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetailsSerach = new System.Windows.Forms.Button();
            this.textBoxDetailsSerach = new System.Windows.Forms.TextBox();
            this.btnCarDetailsBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDetailsCarName = new System.Windows.Forms.Label();
            this.lblDetailsCarModel = new System.Windows.Forms.Label();
            this.lblDetailsCarQuantity = new System.Windows.Forms.Label();
            this.lblDetailsPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDetailsCarName = new System.Windows.Forms.TextBox();
            this.txtBoxDetailsCarModel = new System.Windows.Forms.TextBox();
            this.txtBoxDetailsCarQuantity = new System.Windows.Forms.TextBox();
            this.txtBoxDetailsPrice = new System.Windows.Forms.TextBox();
            this.pictureBoxCarImage1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnDetailsSerach);
            this.panel1.Controls.Add(this.textBoxDetailsSerach);
            this.panel1.Controls.Add(this.btnCarDetailsBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 69);
            this.panel1.TabIndex = 0;
            // 
            // btnDetailsSerach
            // 
            this.btnDetailsSerach.Image = global::ABC_Car.Properties.Resources.icons8_search_100_2;
            this.btnDetailsSerach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetailsSerach.Location = new System.Drawing.Point(533, 18);
            this.btnDetailsSerach.Name = "btnDetailsSerach";
            this.btnDetailsSerach.Size = new System.Drawing.Size(75, 37);
            this.btnDetailsSerach.TabIndex = 3;
            this.btnDetailsSerach.Text = "Search";
            this.btnDetailsSerach.UseVisualStyleBackColor = true;
            this.btnDetailsSerach.Click += new System.EventHandler(this.btnDetailsSerach_Click);
            // 
            // textBoxDetailsSerach
            // 
            this.textBoxDetailsSerach.Location = new System.Drawing.Point(623, 30);
            this.textBoxDetailsSerach.Name = "textBoxDetailsSerach";
            this.textBoxDetailsSerach.Size = new System.Drawing.Size(168, 20);
            this.textBoxDetailsSerach.TabIndex = 2;
            // 
            // btnCarDetailsBack
            // 
            this.btnCarDetailsBack.BackColor = System.Drawing.Color.Black;
            this.btnCarDetailsBack.ForeColor = System.Drawing.Color.Gold;
            this.btnCarDetailsBack.Location = new System.Drawing.Point(36, 23);
            this.btnCarDetailsBack.Name = "btnCarDetailsBack";
            this.btnCarDetailsBack.Size = new System.Drawing.Size(75, 23);
            this.btnCarDetailsBack.TabIndex = 1;
            this.btnCarDetailsBack.Text = "Back";
            this.btnCarDetailsBack.UseVisualStyleBackColor = false;
            this.btnCarDetailsBack.Click += new System.EventHandler(this.btnCarDetailsBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(323, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Details";
            // 
            // lblDetailsCarName
            // 
            this.lblDetailsCarName.AutoSize = true;
            this.lblDetailsCarName.Location = new System.Drawing.Point(30, 85);
            this.lblDetailsCarName.Name = "lblDetailsCarName";
            this.lblDetailsCarName.Size = new System.Drawing.Size(54, 13);
            this.lblDetailsCarName.TabIndex = 1;
            this.lblDetailsCarName.Text = "Car Name";
            // 
            // lblDetailsCarModel
            // 
            this.lblDetailsCarModel.AutoSize = true;
            this.lblDetailsCarModel.Location = new System.Drawing.Point(30, 123);
            this.lblDetailsCarModel.Name = "lblDetailsCarModel";
            this.lblDetailsCarModel.Size = new System.Drawing.Size(55, 13);
            this.lblDetailsCarModel.TabIndex = 2;
            this.lblDetailsCarModel.Text = "Car Model";
            // 
            // lblDetailsCarQuantity
            // 
            this.lblDetailsCarQuantity.AutoSize = true;
            this.lblDetailsCarQuantity.Location = new System.Drawing.Point(300, 85);
            this.lblDetailsCarQuantity.Name = "lblDetailsCarQuantity";
            this.lblDetailsCarQuantity.Size = new System.Drawing.Size(65, 13);
            this.lblDetailsCarQuantity.TabIndex = 3;
            this.lblDetailsCarQuantity.Text = "Car Quantity";
            // 
            // lblDetailsPrice
            // 
            this.lblDetailsPrice.AutoSize = true;
            this.lblDetailsPrice.Location = new System.Drawing.Point(300, 123);
            this.lblDetailsPrice.Name = "lblDetailsPrice";
            this.lblDetailsPrice.Size = new System.Drawing.Size(31, 13);
            this.lblDetailsPrice.TabIndex = 4;
            this.lblDetailsPrice.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // txtBoxDetailsCarName
            // 
            this.txtBoxDetailsCarName.Location = new System.Drawing.Point(118, 85);
            this.txtBoxDetailsCarName.Name = "txtBoxDetailsCarName";
            this.txtBoxDetailsCarName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDetailsCarName.TabIndex = 6;
            // 
            // txtBoxDetailsCarModel
            // 
            this.txtBoxDetailsCarModel.Location = new System.Drawing.Point(118, 123);
            this.txtBoxDetailsCarModel.Name = "txtBoxDetailsCarModel";
            this.txtBoxDetailsCarModel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDetailsCarModel.TabIndex = 7;
            // 
            // txtBoxDetailsCarQuantity
            // 
            this.txtBoxDetailsCarQuantity.Location = new System.Drawing.Point(371, 82);
            this.txtBoxDetailsCarQuantity.Name = "txtBoxDetailsCarQuantity";
            this.txtBoxDetailsCarQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDetailsCarQuantity.TabIndex = 8;
            // 
            // txtBoxDetailsPrice
            // 
            this.txtBoxDetailsPrice.Location = new System.Drawing.Point(371, 123);
            this.txtBoxDetailsPrice.Name = "txtBoxDetailsPrice";
            this.txtBoxDetailsPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDetailsPrice.TabIndex = 9;
            // 
            // pictureBoxCarImage1
            // 
            this.pictureBoxCarImage1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarImage1.Image")));
            this.pictureBoxCarImage1.Location = new System.Drawing.Point(543, 105);
            this.pictureBoxCarImage1.Name = "pictureBoxCarImage1";
            this.pictureBoxCarImage1.Size = new System.Drawing.Size(100, 58);
            this.pictureBoxCarImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCarImage1.TabIndex = 10;
            this.pictureBoxCarImage1.TabStop = false;
            // 
            // CarDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxCarImage1);
            this.Controls.Add(this.txtBoxDetailsPrice);
            this.Controls.Add(this.txtBoxDetailsCarQuantity);
            this.Controls.Add(this.txtBoxDetailsCarModel);
            this.Controls.Add(this.txtBoxDetailsCarName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDetailsPrice);
            this.Controls.Add(this.lblDetailsCarQuantity);
            this.Controls.Add(this.lblDetailsCarModel);
            this.Controls.Add(this.lblDetailsCarName);
            this.Controls.Add(this.panel1);
            this.Name = "CarDetailsForm";
            this.Text = "CarDetailsForm";
            this.Load += new System.EventHandler(this.CarDetailsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarImage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCarDetailsBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetailsSerach;
        private System.Windows.Forms.TextBox textBoxDetailsSerach;
        private System.Windows.Forms.Label lblDetailsCarName;
        private System.Windows.Forms.Label lblDetailsCarModel;
        private System.Windows.Forms.Label lblDetailsCarQuantity;
        private System.Windows.Forms.Label lblDetailsPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxDetailsCarName;
        private System.Windows.Forms.TextBox txtBoxDetailsCarModel;
        private System.Windows.Forms.TextBox txtBoxDetailsCarQuantity;
        private System.Windows.Forms.TextBox txtBoxDetailsPrice;
        private System.Windows.Forms.PictureBox pictureBoxCarImage1;
    }
}