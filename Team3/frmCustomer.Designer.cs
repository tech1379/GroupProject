
namespace Team3
{
    partial class frmCustomer
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
            this.tbMenu = new System.Windows.Forms.TabControl();
            this.tbMenuItems = new System.Windows.Forms.TabPage();
            this.tbDesserts = new System.Windows.Forms.TabPage();
            this.tbDrinks = new System.Windows.Forms.TabPage();
            this.tbOrder = new System.Windows.Forms.TabPage();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCust = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbMenu.SuspendLayout();
            this.tbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMenu
            // 
            this.tbMenu.Controls.Add(this.tbMenuItems);
            this.tbMenu.Controls.Add(this.tbDesserts);
            this.tbMenu.Controls.Add(this.tbDrinks);
            this.tbMenu.Controls.Add(this.tbOrder);
            this.tbMenu.Location = new System.Drawing.Point(24, 86);
            this.tbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.SelectedIndex = 0;
            this.tbMenu.Size = new System.Drawing.Size(884, 595);
            this.tbMenu.TabIndex = 0;
            // 
            // tbMenuItems
            // 
            this.tbMenuItems.AutoScroll = true;
            this.tbMenuItems.Location = new System.Drawing.Point(4, 26);
            this.tbMenuItems.Margin = new System.Windows.Forms.Padding(4);
            this.tbMenuItems.Name = "tbMenuItems";
            this.tbMenuItems.Padding = new System.Windows.Forms.Padding(4);
            this.tbMenuItems.Size = new System.Drawing.Size(876, 565);
            this.tbMenuItems.TabIndex = 0;
            this.tbMenuItems.Text = "Entrees";
            this.tbMenuItems.UseVisualStyleBackColor = true;
            // 
            // tbDesserts
            // 
            this.tbDesserts.Location = new System.Drawing.Point(4, 26);
            this.tbDesserts.Margin = new System.Windows.Forms.Padding(4);
            this.tbDesserts.Name = "tbDesserts";
            this.tbDesserts.Padding = new System.Windows.Forms.Padding(4);
            this.tbDesserts.Size = new System.Drawing.Size(873, 562);
            this.tbDesserts.TabIndex = 1;
            this.tbDesserts.Text = "Desserts";
            this.tbDesserts.UseVisualStyleBackColor = true;
            // 
            // tbDrinks
            // 
            this.tbDrinks.Location = new System.Drawing.Point(4, 26);
            this.tbDrinks.Name = "tbDrinks";
            this.tbDrinks.Padding = new System.Windows.Forms.Padding(3);
            this.tbDrinks.Size = new System.Drawing.Size(873, 562);
            this.tbDrinks.TabIndex = 2;
            this.tbDrinks.Text = "Drinks";
            this.tbDrinks.UseVisualStyleBackColor = true;
            // 
            // tbOrder
            // 
            this.tbOrder.Controls.Add(this.dgvResults);
            this.tbOrder.Controls.Add(this.lblCustomerName);
            this.tbOrder.Controls.Add(this.lblCust);
            this.tbOrder.Location = new System.Drawing.Point(4, 26);
            this.tbOrder.Name = "tbOrder";
            this.tbOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbOrder.Size = new System.Drawing.Size(873, 562);
            this.tbOrder.TabIndex = 3;
            this.tbOrder.Text = "View Order";
            this.tbOrder.UseVisualStyleBackColor = true;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(343, 74);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.Size = new System.Drawing.Size(496, 254);
            this.dgvResults.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerName.Location = new System.Drawing.Point(18, 80);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(219, 41);
            this.lblCustomerName.TabIndex = 1;
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.ForeColor = System.Drawing.Color.White;
            this.lblCust.Location = new System.Drawing.Point(15, 33);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(126, 17);
            this.lblCust.TabIndex = 0;
            this.lblCust.Text = "Customer Name:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(12, 12);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(382, 34);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Please click Menu image for description and price.\r\nThen you can select your quan" +
    "tity and Add To Order.";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(445, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 54);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add to Order";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 694);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tbMenu);
            this.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.tbMenu.ResumeLayout(false);
            this.tbOrder.ResumeLayout(false);
            this.tbOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbMenu;
        private System.Windows.Forms.TabPage tbMenuItems;
        private System.Windows.Forms.TabPage tbDesserts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tbDrinks;
        private System.Windows.Forms.TabPage tbOrder;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.DataGridView dgvResults;
    }
}