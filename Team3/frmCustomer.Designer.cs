
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbDrinks = new System.Windows.Forms.TabPage();
            this.tbOrder = new System.Windows.Forms.TabPage();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tbMenu.SuspendLayout();
            this.tbMenuItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMenu
            // 
            this.tbMenu.Controls.Add(this.tbMenuItems);
            this.tbMenu.Controls.Add(this.tbDesserts);
            this.tbMenu.Controls.Add(this.tbDrinks);
            this.tbMenu.Controls.Add(this.tbOrder);
            this.tbMenu.Location = new System.Drawing.Point(18, 24);
            this.tbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.SelectedIndex = 0;
            this.tbMenu.Size = new System.Drawing.Size(881, 657);
            this.tbMenu.TabIndex = 0;
            // 
            // tbMenuItems
            // 
            this.tbMenuItems.AutoScroll = true;
            this.tbMenuItems.Controls.Add(this.lblInfo);
            this.tbMenuItems.Controls.Add(this.btnAdd);
            this.tbMenuItems.Location = new System.Drawing.Point(4, 26);
            this.tbMenuItems.Margin = new System.Windows.Forms.Padding(4);
            this.tbMenuItems.Name = "tbMenuItems";
            this.tbMenuItems.Padding = new System.Windows.Forms.Padding(4);
            this.tbMenuItems.Size = new System.Drawing.Size(873, 627);
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
            this.tbDesserts.Size = new System.Drawing.Size(873, 627);
            this.tbDesserts.TabIndex = 1;
            this.tbDesserts.Text = "Desserts";
            this.tbDesserts.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(399, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 54);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add to Order";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbDrinks
            // 
            this.tbDrinks.Location = new System.Drawing.Point(4, 26);
            this.tbDrinks.Name = "tbDrinks";
            this.tbDrinks.Padding = new System.Windows.Forms.Padding(3);
            this.tbDrinks.Size = new System.Drawing.Size(873, 627);
            this.tbDrinks.TabIndex = 2;
            this.tbDrinks.Text = "Drinks";
            this.tbDrinks.UseVisualStyleBackColor = true;
            // 
            // tbOrder
            // 
            this.tbOrder.Location = new System.Drawing.Point(4, 26);
            this.tbOrder.Name = "tbOrder";
            this.tbOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbOrder.Size = new System.Drawing.Size(873, 627);
            this.tbOrder.TabIndex = 3;
            this.tbOrder.Text = "View Order";
            this.tbOrder.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(3, 16);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(369, 17);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Please click Menu image for description and price:";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 694);
            this.Controls.Add(this.tbMenu);
            this.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.tbMenu.ResumeLayout(false);
            this.tbMenuItems.ResumeLayout(false);
            this.tbMenuItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbMenu;
        private System.Windows.Forms.TabPage tbMenuItems;
        private System.Windows.Forms.TabPage tbDesserts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tbDrinks;
        private System.Windows.Forms.TabPage tbOrder;
        private System.Windows.Forms.Label lblInfo;
    }
}