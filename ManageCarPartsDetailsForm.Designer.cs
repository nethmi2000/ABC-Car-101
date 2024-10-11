namespace ABC_Car
{
    partial class ManageCarPartsDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCarPartsDetailsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxCarPartID = new System.Windows.Forms.TextBox();
            this.txtBoxCarPartName = new System.Windows.Forms.TextBox();
            this.txtBoxCarPartModel = new System.Windows.Forms.TextBox();
            this.txtBoxCarPartQuantity = new System.Windows.Forms.TextBox();
            this.txtBoxCarPartPrice = new System.Windows.Forms.TextBox();
            this.btnAddCarPart = new System.Windows.Forms.Button();
            this.btnCarPartSearch = new System.Windows.Forms.Button();
            this.btnCarPartUpdate = new System.Windows.Forms.Button();
            this.btnCarPartDelete = new System.Windows.Forms.Button();
            this.btnCarPartClear = new System.Windows.Forms.Button();
            this.btnLoadImageCarPart = new System.Windows.Forms.Button();
            this.pictureBoxCarPartImage = new System.Windows.Forms.PictureBox();
            this.CarPartdataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarPartImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPartdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 75);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Car Parts Details";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.ForeColor = System.Drawing.Color.Gold;
            this.btnBack.Location = new System.Drawing.Point(24, 32);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(158, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car Part ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(158, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Car Part Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(158, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Car Part Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(430, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Car Part Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(430, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price";
            // 
            // txtBoxCarPartID
            // 
            this.txtBoxCarPartID.Location = new System.Drawing.Point(259, 98);
            this.txtBoxCarPartID.Name = "txtBoxCarPartID";
            this.txtBoxCarPartID.Size = new System.Drawing.Size(107, 20);
            this.txtBoxCarPartID.TabIndex = 6;
            // 
            // txtBoxCarPartName
            // 
            this.txtBoxCarPartName.Location = new System.Drawing.Point(259, 143);
            this.txtBoxCarPartName.Name = "txtBoxCarPartName";
            this.txtBoxCarPartName.Size = new System.Drawing.Size(107, 20);
            this.txtBoxCarPartName.TabIndex = 7;
            // 
            // txtBoxCarPartModel
            // 
            this.txtBoxCarPartModel.Location = new System.Drawing.Point(259, 191);
            this.txtBoxCarPartModel.Name = "txtBoxCarPartModel";
            this.txtBoxCarPartModel.Size = new System.Drawing.Size(107, 20);
            this.txtBoxCarPartModel.TabIndex = 8;
            // 
            // txtBoxCarPartQuantity
            // 
            this.txtBoxCarPartQuantity.Location = new System.Drawing.Point(533, 95);
            this.txtBoxCarPartQuantity.Name = "txtBoxCarPartQuantity";
            this.txtBoxCarPartQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCarPartQuantity.TabIndex = 9;
            // 
            // txtBoxCarPartPrice
            // 
            this.txtBoxCarPartPrice.Location = new System.Drawing.Point(533, 147);
            this.txtBoxCarPartPrice.Name = "txtBoxCarPartPrice";
            this.txtBoxCarPartPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCarPartPrice.TabIndex = 10;
            // 
            // btnAddCarPart
            // 
            this.btnAddCarPart.BackColor = System.Drawing.Color.Gold;
            this.btnAddCarPart.Location = new System.Drawing.Point(22, 137);
            this.btnAddCarPart.Name = "btnAddCarPart";
            this.btnAddCarPart.Size = new System.Drawing.Size(75, 23);
            this.btnAddCarPart.TabIndex = 11;
            this.btnAddCarPart.Text = "Add Car Part";
            this.btnAddCarPart.UseVisualStyleBackColor = false;
            this.btnAddCarPart.Click += new System.EventHandler(this.btnAddCarPart_Click);
            // 
            // btnCarPartSearch
            // 
            this.btnCarPartSearch.BackColor = System.Drawing.Color.Gold;
            this.btnCarPartSearch.Location = new System.Drawing.Point(22, 188);
            this.btnCarPartSearch.Name = "btnCarPartSearch";
            this.btnCarPartSearch.Size = new System.Drawing.Size(75, 23);
            this.btnCarPartSearch.TabIndex = 12;
            this.btnCarPartSearch.Text = "Search";
            this.btnCarPartSearch.UseVisualStyleBackColor = false;
            this.btnCarPartSearch.Click += new System.EventHandler(this.btnCarPartSearch_Click);
            // 
            // btnCarPartUpdate
            // 
            this.btnCarPartUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnCarPartUpdate.Location = new System.Drawing.Point(22, 239);
            this.btnCarPartUpdate.Name = "btnCarPartUpdate";
            this.btnCarPartUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCarPartUpdate.TabIndex = 13;
            this.btnCarPartUpdate.Text = "Update";
            this.btnCarPartUpdate.UseVisualStyleBackColor = false;
            this.btnCarPartUpdate.Click += new System.EventHandler(this.btnCarPartUpdate_Click);
            // 
            // btnCarPartDelete
            // 
            this.btnCarPartDelete.BackColor = System.Drawing.Color.Gold;
            this.btnCarPartDelete.Location = new System.Drawing.Point(22, 295);
            this.btnCarPartDelete.Name = "btnCarPartDelete";
            this.btnCarPartDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCarPartDelete.TabIndex = 14;
            this.btnCarPartDelete.Text = "Delete";
            this.btnCarPartDelete.UseVisualStyleBackColor = false;
            this.btnCarPartDelete.Click += new System.EventHandler(this.btnCarPartDelete_Click);
            // 
            // btnCarPartClear
            // 
            this.btnCarPartClear.BackColor = System.Drawing.Color.Gold;
            this.btnCarPartClear.Location = new System.Drawing.Point(22, 345);
            this.btnCarPartClear.Name = "btnCarPartClear";
            this.btnCarPartClear.Size = new System.Drawing.Size(75, 23);
            this.btnCarPartClear.TabIndex = 15;
            this.btnCarPartClear.Text = "Clear";
            this.btnCarPartClear.UseVisualStyleBackColor = false;
            this.btnCarPartClear.Click += new System.EventHandler(this.btnCarPartClear_Click);
            // 
            // btnLoadImageCarPart
            // 
            this.btnLoadImageCarPart.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnLoadImageCarPart.ForeColor = System.Drawing.Color.Gold;
            this.btnLoadImageCarPart.Location = new System.Drawing.Point(715, 147);
            this.btnLoadImageCarPart.Name = "btnLoadImageCarPart";
            this.btnLoadImageCarPart.Size = new System.Drawing.Size(31, 23);
            this.btnLoadImageCarPart.TabIndex = 16;
            this.btnLoadImageCarPart.Text = "+";
            this.btnLoadImageCarPart.UseVisualStyleBackColor = false;
            this.btnLoadImageCarPart.Click += new System.EventHandler(this.btnLoadImageCarPart_Click);
            // 
            // pictureBoxCarPartImage
            // 
            this.pictureBoxCarPartImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCarPartImage.Image")));
            this.pictureBoxCarPartImage.Location = new System.Drawing.Point(676, 91);
            this.pictureBoxCarPartImage.Name = "pictureBoxCarPartImage";
            this.pictureBoxCarPartImage.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxCarPartImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCarPartImage.TabIndex = 17;
            this.pictureBoxCarPartImage.TabStop = false;
            // 
            // CarPartdataGridView
            // 
            this.CarPartdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarPartdataGridView.Location = new System.Drawing.Point(161, 217);
            this.CarPartdataGridView.Name = "CarPartdataGridView";
            this.CarPartdataGridView.Size = new System.Drawing.Size(615, 221);
            this.CarPartdataGridView.TabIndex = 18;
            this.CarPartdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarPartdataGridView_CellContentClick);
            // 
            // ManageCarPartsDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CarPartdataGridView);
            this.Controls.Add(this.pictureBoxCarPartImage);
            this.Controls.Add(this.btnLoadImageCarPart);
            this.Controls.Add(this.btnCarPartClear);
            this.Controls.Add(this.btnCarPartDelete);
            this.Controls.Add(this.btnCarPartUpdate);
            this.Controls.Add(this.btnCarPartSearch);
            this.Controls.Add(this.btnAddCarPart);
            this.Controls.Add(this.txtBoxCarPartPrice);
            this.Controls.Add(this.txtBoxCarPartQuantity);
            this.Controls.Add(this.txtBoxCarPartModel);
            this.Controls.Add(this.txtBoxCarPartName);
            this.Controls.Add(this.txtBoxCarPartID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCarPartsDetailsForm";
            this.Text = "ManageCarPartsDetailsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarPartImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPartdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxCarPartID;
        private System.Windows.Forms.TextBox txtBoxCarPartName;
        private System.Windows.Forms.TextBox txtBoxCarPartModel;
        private System.Windows.Forms.TextBox txtBoxCarPartQuantity;
        private System.Windows.Forms.TextBox txtBoxCarPartPrice;
        private System.Windows.Forms.Button btnAddCarPart;
        private System.Windows.Forms.Button btnCarPartSearch;
        private System.Windows.Forms.Button btnCarPartUpdate;
        private System.Windows.Forms.Button btnCarPartDelete;
        private System.Windows.Forms.Button btnCarPartClear;
        private System.Windows.Forms.Button btnLoadImageCarPart;
        private System.Windows.Forms.PictureBox pictureBoxCarPartImage;
        private System.Windows.Forms.DataGridView CarPartdataGridView;
    }
}