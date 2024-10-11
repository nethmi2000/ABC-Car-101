namespace ABC_Car
{
    partial class CarPartsDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarPartsDetailsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxCarPartsDetails = new System.Windows.Forms.TextBox();
            this.lblCarPartsName = new System.Windows.Forms.Label();
            this.lblCarPartsModel = new System.Windows.Forms.Label();
            this.lblCarPartsQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBoxDetailsCarPartName = new System.Windows.Forms.TextBox();
            this.txtBoxDetailsCarPartModel = new System.Windows.Forms.TextBox();
            this.txtBoxDetailsCarPartQuantity = new System.Windows.Forms.TextBox();
            this.txtBoxDetailsCarPartPrice = new System.Windows.Forms.TextBox();
            this.btnCarPartDetails = new System.Windows.Forms.Button();
            this.pictureBoxCarPartDetails = new System.Windows.Forms.PictureBox();
            this.dataGridViewCarPartsDetails = new System.Windows.Forms.DataGridView();
            this.lblCarPartsId = new System.Windows.Forms.Label();
            this.txtBoxCarPartId = new System.Windows.Forms.TextBox();
            this.btnORDER = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarPartDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarPartsDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.txtBoxCarPartsDetails);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(292, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Parts Details";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.ForeColor = System.Drawing.Color.Gold;
            this.btnBack.Location = new System.Drawing.Point(39, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(573, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxCarPartsDetails
            // 
            this.txtBoxCarPartsDetails.Location = new System.Drawing.Point(654, 25);
            this.txtBoxCarPartsDetails.Name = "txtBoxCarPartsDetails";
            this.txtBoxCarPartsDetails.Size = new System.Drawing.Size(137, 20);
            this.txtBoxCarPartsDetails.TabIndex = 3;
            // 
            // lblCarPartsName
            // 
            this.lblCarPartsName.AutoSize = true;
            this.lblCarPartsName.Location = new System.Drawing.Point(60, 91);
            this.lblCarPartsName.Name = "lblCarPartsName";
            this.lblCarPartsName.Size = new System.Drawing.Size(81, 13);
            this.lblCarPartsName.TabIndex = 1;
            this.lblCarPartsName.Text = "Car Parts Name";
            // 
            // lblCarPartsModel
            // 
            this.lblCarPartsModel.AutoSize = true;
            this.lblCarPartsModel.Location = new System.Drawing.Point(60, 130);
            this.lblCarPartsModel.Name = "lblCarPartsModel";
            this.lblCarPartsModel.Size = new System.Drawing.Size(82, 13);
            this.lblCarPartsModel.TabIndex = 2;
            this.lblCarPartsModel.Text = "Car Parts Model";
            // 
            // lblCarPartsQuantity
            // 
            this.lblCarPartsQuantity.AutoSize = true;
            this.lblCarPartsQuantity.Location = new System.Drawing.Point(355, 93);
            this.lblCarPartsQuantity.Name = "lblCarPartsQuantity";
            this.lblCarPartsQuantity.Size = new System.Drawing.Size(92, 13);
            this.lblCarPartsQuantity.TabIndex = 3;
            this.lblCarPartsQuantity.Text = "Car Parts Quantity";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(360, 129);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // txtBoxDetailsCarPartName
            // 
            this.txtBoxDetailsCarPartName.Location = new System.Drawing.Point(160, 88);
            this.txtBoxDetailsCarPartName.Name = "txtBoxDetailsCarPartName";
            this.txtBoxDetailsCarPartName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDetailsCarPartName.TabIndex = 5;
            // 
            // txtBoxDetailsCarPartModel
            // 
            this.txtBoxDetailsCarPartModel.Location = new System.Drawing.Point(160, 131);
            this.txtBoxDetailsCarPartModel.Name = "txtBoxDetailsCarPartModel";
            this.txtBoxDetailsCarPartModel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDetailsCarPartModel.TabIndex = 6;
            // 
            // txtBoxDetailsCarPartQuantity
            // 
            this.txtBoxDetailsCarPartQuantity.Location = new System.Drawing.Point(473, 93);
            this.txtBoxDetailsCarPartQuantity.Name = "txtBoxDetailsCarPartQuantity";
            this.txtBoxDetailsCarPartQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDetailsCarPartQuantity.TabIndex = 7;
            // 
            // txtBoxDetailsCarPartPrice
            // 
            this.txtBoxDetailsCarPartPrice.Location = new System.Drawing.Point(473, 134);
            this.txtBoxDetailsCarPartPrice.Name = "txtBoxDetailsCarPartPrice";
            this.txtBoxDetailsCarPartPrice.Size = new System.Drawing.Size(103, 20);
            this.txtBoxDetailsCarPartPrice.TabIndex = 8;
            // 
            // btnCarPartDetails
            // 
            this.btnCarPartDetails.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCarPartDetails.ForeColor = System.Drawing.Color.Gold;
            this.btnCarPartDetails.Location = new System.Drawing.Point(687, 149);
            this.btnCarPartDetails.Name = "btnCarPartDetails";
            this.btnCarPartDetails.Size = new System.Drawing.Size(26, 23);
            this.btnCarPartDetails.TabIndex = 10;
            this.btnCarPartDetails.Text = "+";
            this.btnCarPartDetails.UseVisualStyleBackColor = false;
            this.btnCarPartDetails.Click += new System.EventHandler(this.btnCarPartDetails_Click);
            // 
            // pictureBoxCarPartDetails
            // 
            this.pictureBoxCarPartDetails.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarPartDetails.Image")));
            this.pictureBoxCarPartDetails.Location = new System.Drawing.Point(651, 91);
            this.pictureBoxCarPartDetails.Name = "pictureBoxCarPartDetails";
            this.pictureBoxCarPartDetails.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxCarPartDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCarPartDetails.TabIndex = 9;
            this.pictureBoxCarPartDetails.TabStop = false;
            // 
            // dataGridViewCarPartsDetails
            // 
            this.dataGridViewCarPartsDetails.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewCarPartsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarPartsDetails.Location = new System.Drawing.Point(63, 188);
            this.dataGridViewCarPartsDetails.Name = "dataGridViewCarPartsDetails";
            this.dataGridViewCarPartsDetails.Size = new System.Drawing.Size(688, 230);
            this.dataGridViewCarPartsDetails.TabIndex = 11;
            this.dataGridViewCarPartsDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarPartsDetails_CellContentClick);
            // 
            // lblCarPartsId
            // 
            this.lblCarPartsId.AutoSize = true;
            this.lblCarPartsId.Location = new System.Drawing.Point(68, 163);
            this.lblCarPartsId.Name = "lblCarPartsId";
            this.lblCarPartsId.Size = new System.Drawing.Size(62, 13);
            this.lblCarPartsId.TabIndex = 12;
            this.lblCarPartsId.Text = "Car Parts Id";
            // 
            // txtBoxCarPartId
            // 
            this.txtBoxCarPartId.Location = new System.Drawing.Point(163, 165);
            this.txtBoxCarPartId.Name = "txtBoxCarPartId";
            this.txtBoxCarPartId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCarPartId.TabIndex = 13;
            // 
            // btnORDER
            // 
            this.btnORDER.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnORDER.ForeColor = System.Drawing.Color.Gold;
            this.btnORDER.Location = new System.Drawing.Point(486, 160);
            this.btnORDER.Name = "btnORDER";
            this.btnORDER.Size = new System.Drawing.Size(75, 23);
            this.btnORDER.TabIndex = 14;
            this.btnORDER.Text = "ORDER";
            this.btnORDER.UseVisualStyleBackColor = false;
            this.btnORDER.Click += new System.EventHandler(this.btnORDER_Click);
            // 
            // CarPartsDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnORDER);
            this.Controls.Add(this.txtBoxCarPartId);
            this.Controls.Add(this.lblCarPartsId);
            this.Controls.Add(this.dataGridViewCarPartsDetails);
            this.Controls.Add(this.btnCarPartDetails);
            this.Controls.Add(this.pictureBoxCarPartDetails);
            this.Controls.Add(this.txtBoxDetailsCarPartPrice);
            this.Controls.Add(this.txtBoxDetailsCarPartQuantity);
            this.Controls.Add(this.txtBoxDetailsCarPartModel);
            this.Controls.Add(this.txtBoxDetailsCarPartName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCarPartsQuantity);
            this.Controls.Add(this.lblCarPartsModel);
            this.Controls.Add(this.lblCarPartsName);
            this.Controls.Add(this.panel1);
            this.Name = "CarPartsDetailsForm";
            this.Text = "CarPartsDetailsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarPartDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarPartsDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxCarPartsDetails;
        private System.Windows.Forms.Label lblCarPartsName;
        private System.Windows.Forms.Label lblCarPartsModel;
        private System.Windows.Forms.Label lblCarPartsQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtBoxDetailsCarPartName;
        private System.Windows.Forms.TextBox txtBoxDetailsCarPartModel;
        private System.Windows.Forms.TextBox txtBoxDetailsCarPartQuantity;
        private System.Windows.Forms.TextBox txtBoxDetailsCarPartPrice;
        private System.Windows.Forms.PictureBox pictureBoxCarPartDetails;
        private System.Windows.Forms.Button btnCarPartDetails;
        private System.Windows.Forms.DataGridView dataGridViewCarPartsDetails;
        private System.Windows.Forms.Label lblCarPartsId;
        private System.Windows.Forms.TextBox txtBoxCarPartId;
        private System.Windows.Forms.Button btnORDER;
    }
}