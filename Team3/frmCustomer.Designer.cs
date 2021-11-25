
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
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.tbxExpirationDate = new System.Windows.Forms.TextBox();
            this.tbxCreditCard = new System.Windows.Forms.TextBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTt = new System.Windows.Forms.Label();
            this.lblTx = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCust = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.hlpMain = new System.Windows.Forms.HelpProvider();
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
            this.tbMenuItems.Location = new System.Drawing.Point(4, 29);
            this.tbMenuItems.Margin = new System.Windows.Forms.Padding(4);
            this.tbMenuItems.Name = "tbMenuItems";
            this.tbMenuItems.Padding = new System.Windows.Forms.Padding(4);
            this.tbMenuItems.Size = new System.Drawing.Size(876, 562);
            this.tbMenuItems.TabIndex = 0;
            this.tbMenuItems.Text = "Entrees";
            this.tbMenuItems.UseVisualStyleBackColor = true;
            // 
            // tbDesserts
            // 
            this.tbDesserts.Location = new System.Drawing.Point(4, 29);
            this.tbDesserts.Margin = new System.Windows.Forms.Padding(4);
            this.tbDesserts.Name = "tbDesserts";
            this.tbDesserts.Padding = new System.Windows.Forms.Padding(4);
            this.tbDesserts.Size = new System.Drawing.Size(876, 562);
            this.tbDesserts.TabIndex = 1;
            this.tbDesserts.Text = "Desserts";
            this.tbDesserts.UseVisualStyleBackColor = true;
            // 
            // tbDrinks
            // 
            this.tbDrinks.Location = new System.Drawing.Point(4, 29);
            this.tbDrinks.Name = "tbDrinks";
            this.tbDrinks.Padding = new System.Windows.Forms.Padding(3);
            this.tbDrinks.Size = new System.Drawing.Size(876, 562);
            this.tbDrinks.TabIndex = 2;
            this.tbDrinks.Text = "Drinks";
            this.tbDrinks.UseVisualStyleBackColor = true;
            // 
            // tbOrder
            // 
            this.tbOrder.Controls.Add(this.btnReceipt);
            this.tbOrder.Controls.Add(this.btnOrder);
            this.tbOrder.Controls.Add(this.tbxExpirationDate);
            this.tbOrder.Controls.Add(this.tbxCreditCard);
            this.tbOrder.Controls.Add(this.lblExpirationDate);
            this.tbOrder.Controls.Add(this.lblCreditCard);
            this.tbOrder.Controls.Add(this.btnRemoveItem);
            this.tbOrder.Controls.Add(this.btnRemoveAll);
            this.tbOrder.Controls.Add(this.lblTotal);
            this.tbOrder.Controls.Add(this.lblTaxes);
            this.tbOrder.Controls.Add(this.lblSubTotal);
            this.tbOrder.Controls.Add(this.lblTt);
            this.tbOrder.Controls.Add(this.lblTx);
            this.tbOrder.Controls.Add(this.lblSub);
            this.tbOrder.Controls.Add(this.dgvResults);
            this.tbOrder.Controls.Add(this.lblCustomerName);
            this.tbOrder.Controls.Add(this.lblCust);
            this.tbOrder.Location = new System.Drawing.Point(4, 29);
            this.tbOrder.Name = "tbOrder";
            this.tbOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbOrder.Size = new System.Drawing.Size(876, 562);
            this.tbOrder.TabIndex = 3;
            this.tbOrder.Text = "View Order";
            this.tbOrder.UseVisualStyleBackColor = true;
            // 
            // btnReceipt
            // 
            this.btnReceipt.Location = new System.Drawing.Point(560, 472);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(90, 54);
            this.btnReceipt.TabIndex = 15;
            this.btnReceipt.Text = "&View Receipt";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(449, 472);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(90, 54);
            this.btnOrder.TabIndex = 14;
            this.btnOrder.Text = "&Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // tbxExpirationDate
            // 
            this.tbxExpirationDate.Location = new System.Drawing.Point(18, 352);
            this.tbxExpirationDate.MaxLength = 5;
            this.tbxExpirationDate.Name = "tbxExpirationDate";
            this.tbxExpirationDate.Size = new System.Drawing.Size(100, 26);
            this.tbxExpirationDate.TabIndex = 13;
            // 
            // tbxCreditCard
            // 
            this.tbxCreditCard.Location = new System.Drawing.Point(18, 259);
            this.tbxCreditCard.MaxLength = 19;
            this.tbxCreditCard.Name = "tbxCreditCard";
            this.tbxCreditCard.Size = new System.Drawing.Size(219, 26);
            this.tbxCreditCard.TabIndex = 12;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.ForeColor = System.Drawing.Color.White;
            this.lblExpirationDate.Location = new System.Drawing.Point(15, 311);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(122, 20);
            this.lblExpirationDate.TabIndex = 11;
            this.lblExpirationDate.Text = "Expiration Date:";
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.ForeColor = System.Drawing.Color.White;
            this.lblCreditCard.Location = new System.Drawing.Point(15, 228);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(93, 20);
            this.lblCreditCard.TabIndex = 10;
            this.lblCreditCard.Text = "Credit Card:";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(338, 472);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(90, 54);
            this.btnRemoveItem.TabIndex = 9;
            this.btnRemoveItem.Text = "Remove &Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(227, 474);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(90, 54);
            this.btnRemoveAll.TabIndex = 2;
            this.btnRemoveAll.Text = "&Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(715, 490);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(134, 23);
            this.lblTotal.TabIndex = 8;
            // 
            // lblTaxes
            // 
            this.lblTaxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTaxes.ForeColor = System.Drawing.Color.White;
            this.lblTaxes.Location = new System.Drawing.Point(715, 432);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(134, 23);
            this.lblTaxes.TabIndex = 7;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotal.ForeColor = System.Drawing.Color.White;
            this.lblSubTotal.Location = new System.Drawing.Point(715, 380);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(134, 23);
            this.lblSubTotal.TabIndex = 6;
            // 
            // lblTt
            // 
            this.lblTt.AutoSize = true;
            this.lblTt.ForeColor = System.Drawing.Color.White;
            this.lblTt.Location = new System.Drawing.Point(644, 496);
            this.lblTt.Name = "lblTt";
            this.lblTt.Size = new System.Drawing.Size(48, 20);
            this.lblTt.TabIndex = 5;
            this.lblTt.Text = "Total:";
            // 
            // lblTx
            // 
            this.lblTx.AutoSize = true;
            this.lblTx.ForeColor = System.Drawing.Color.White;
            this.lblTx.Location = new System.Drawing.Point(644, 438);
            this.lblTx.Name = "lblTx";
            this.lblTx.Size = new System.Drawing.Size(55, 20);
            this.lblTx.TabIndex = 4;
            this.lblTx.Text = "Taxes:";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.ForeColor = System.Drawing.Color.White;
            this.lblSub.Location = new System.Drawing.Point(623, 386);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(77, 20);
            this.lblSub.TabIndex = 3;
            this.lblSub.Text = "SubTotal:";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(261, 74);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.Size = new System.Drawing.Size(578, 254);
            this.dgvResults.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblCust.Size = new System.Drawing.Size(128, 20);
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
            this.lblInfo.Size = new System.Drawing.Size(378, 40);
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
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(562, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 54);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(824, 29);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(46, 20);
            this.lblHelp.TabIndex = 3;
            this.lblHelp.Text = "&Help";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 694);
            this.ControlBox = false;
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tbMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblTx;
        private System.Windows.Forms.Label lblTt;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTaxes;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Label lblCreditCard;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.TextBox tbxCreditCard;
        private System.Windows.Forms.TextBox tbxExpirationDate;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.HelpProvider hlpMain;
    }
}