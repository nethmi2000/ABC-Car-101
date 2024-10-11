namespace ABC_Car
{
    partial class ViewOrderForm
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
            this.dataGridViewCustomerOrderStatus = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerOrderStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 63);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewCustomerOrderStatus
            // 
            this.dataGridViewCustomerOrderStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerOrderStatus.Location = new System.Drawing.Point(31, 110);
            this.dataGridViewCustomerOrderStatus.Name = "dataGridViewCustomerOrderStatus";
            this.dataGridViewCustomerOrderStatus.Size = new System.Drawing.Size(745, 282);
            this.dataGridViewCustomerOrderStatus.TabIndex = 1;
            this.dataGridViewCustomerOrderStatus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomerOrderStatus_CellContentClick);
            // 
            // ViewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCustomerOrderStatus);
            this.Controls.Add(this.panel1);
            this.Name = "ViewOrderForm";
            this.Text = "ViewOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerOrderStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewCustomerOrderStatus;
    }
}