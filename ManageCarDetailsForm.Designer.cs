namespace ABC_Car
{
    partial class ManageCarDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCarDetailsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CardataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBoxCarImage = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.txtBoxQuantity = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.txtBoxCarModel = new System.Windows.Forms.TextBox();
            this.txtBoxCarName = new System.Windows.Forms.TextBox();
            this.txtBoxCarID = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblCarName = new System.Windows.Forms.Label();
            this.lblCarID = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.CardataGridView);
            this.panel1.Controls.Add(this.pictureBoxCarImage);
            this.panel1.Controls.Add(this.btnLoadImage);
            this.panel1.Controls.Add(this.txtBoxQuantity);
            this.panel1.Controls.Add(this.txtBoxPrice);
            this.panel1.Controls.Add(this.txtBoxCarModel);
            this.panel1.Controls.Add(this.txtBoxCarName);
            this.panel1.Controls.Add(this.txtBoxCarID);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblCarModel);
            this.panel1.Controls.Add(this.lblCarName);
            this.panel1.Controls.Add(this.lblCarID);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnAddCar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 453);
            this.panel1.TabIndex = 0;
            // 
            // CardataGridView
            // 
            this.CardataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CardataGridView.Location = new System.Drawing.Point(142, 195);
            this.CardataGridView.Name = "CardataGridView";
            this.CardataGridView.Size = new System.Drawing.Size(600, 243);
            this.CardataGridView.TabIndex = 18;
            this.CardataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CardataGridView_CellContentClick);
            // 
            // pictureBoxCarImage
            // 
            this.pictureBoxCarImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarImage.Image")));
            this.pictureBoxCarImage.Location = new System.Drawing.Point(610, 86);
            this.pictureBoxCarImage.Name = "pictureBoxCarImage";
            this.pictureBoxCarImage.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCarImage.TabIndex = 17;
            this.pictureBoxCarImage.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.BackColor = System.Drawing.Color.Black;
            this.btnLoadImage.ForeColor = System.Drawing.Color.Gold;
            this.btnLoadImage.Location = new System.Drawing.Point(716, 113);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(26, 23);
            this.btnLoadImage.TabIndex = 16;
            this.btnLoadImage.Text = "+";
            this.btnLoadImage.UseVisualStyleBackColor = false;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click_1);
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtBoxQuantity.ForeColor = System.Drawing.Color.Gold;
            this.txtBoxQuantity.Location = new System.Drawing.Point(457, 77);
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtBoxQuantity.TabIndex = 15;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtBoxPrice.ForeColor = System.Drawing.Color.Gold;
            this.txtBoxPrice.Location = new System.Drawing.Point(457, 120);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrice.TabIndex = 14;
            // 
            // txtBoxCarModel
            // 
            this.txtBoxCarModel.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtBoxCarModel.ForeColor = System.Drawing.Color.Gold;
            this.txtBoxCarModel.Location = new System.Drawing.Point(215, 161);
            this.txtBoxCarModel.Name = "txtBoxCarModel";
            this.txtBoxCarModel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCarModel.TabIndex = 13;
            // 
            // txtBoxCarName
            // 
            this.txtBoxCarName.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtBoxCarName.ForeColor = System.Drawing.Color.Gold;
            this.txtBoxCarName.Location = new System.Drawing.Point(215, 120);
            this.txtBoxCarName.Name = "txtBoxCarName";
            this.txtBoxCarName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCarName.TabIndex = 12;
            // 
            // txtBoxCarID
            // 
            this.txtBoxCarID.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtBoxCarID.ForeColor = System.Drawing.Color.Gold;
            this.txtBoxCarID.Location = new System.Drawing.Point(215, 77);
            this.txtBoxCarID.Name = "txtBoxCarID";
            this.txtBoxCarID.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCarID.TabIndex = 11;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantity.ForeColor = System.Drawing.Color.Gold;
            this.lblQuantity.Location = new System.Drawing.Point(386, 84);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrice.ForeColor = System.Drawing.Color.Gold;
            this.lblPrice.Location = new System.Drawing.Point(386, 127);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCarModel.ForeColor = System.Drawing.Color.Gold;
            this.lblCarModel.Location = new System.Drawing.Point(139, 164);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(55, 13);
            this.lblCarModel.TabIndex = 8;
            this.lblCarModel.Text = "Car Model";
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCarName.ForeColor = System.Drawing.Color.Gold;
            this.lblCarName.Location = new System.Drawing.Point(139, 123);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(54, 13);
            this.lblCarName.TabIndex = 7;
            this.lblCarName.Text = "Car Name";
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCarID.ForeColor = System.Drawing.Color.Gold;
            this.lblCarID.Location = new System.Drawing.Point(139, 84);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.Size = new System.Drawing.Size(37, 13);
            this.lblCarID.TabIndex = 6;
            this.lblCarID.Text = "Car ID";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gold;
            this.btnClear.Location = new System.Drawing.Point(24, 343);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gold;
            this.btnDelete.Location = new System.Drawing.Point(24, 290);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnUpdate.Location = new System.Drawing.Point(24, 237);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSearch.Location = new System.Drawing.Point(24, 177);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.Color.Gold;
            this.btnAddCar.Location = new System.Drawing.Point(24, 126);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(75, 23);
            this.btnAddCar.TabIndex = 1;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 62);
            this.panel2.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.ForeColor = System.Drawing.Color.Gold;
            this.btnBack.Location = new System.Drawing.Point(24, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Car Details";
            // 
            // ManageCarDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCarDetailsForm";
            this.Text = "ManageCarDetailsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.Label lblCarID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.TextBox txtBoxCarID;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.TextBox txtBoxQuantity;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.TextBox txtBoxCarModel;
        private System.Windows.Forms.TextBox txtBoxCarName;
        private System.Windows.Forms.PictureBox pictureBoxCarImage;
        private System.Windows.Forms.DataGridView CardataGridView;
    }
}