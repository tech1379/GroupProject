namespace Team3
{
    partial class frmManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblViewEmployees = new System.Windows.Forms.Label();
            this.btnViewEmployees = new System.Windows.Forms.Button();
            this.lblSeeMenu = new System.Windows.Forms.Label();
            this.btnSeeMenuItems = new System.Windows.Forms.Button();
            this.lblLocationToday = new System.Windows.Forms.Label();
            this.lblUpdateMenu = new System.Windows.Forms.Label();
            this.lblPayroll = new System.Windows.Forms.Label();
            this.lblUpdateEmployee = new System.Windows.Forms.Label();
            this.btnPaySchedule = new System.Windows.Forms.Button();
            this.btnLocationToday = new System.Windows.Forms.Button();
            this.btnManageMenuItems = new System.Windows.Forms.Button();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblViewEmployees);
            this.groupBox1.Controls.Add(this.btnViewEmployees);
            this.groupBox1.Controls.Add(this.lblSeeMenu);
            this.groupBox1.Controls.Add(this.btnSeeMenuItems);
            this.groupBox1.Controls.Add(this.lblLocationToday);
            this.groupBox1.Controls.Add(this.lblUpdateMenu);
            this.groupBox1.Controls.Add(this.lblPayroll);
            this.groupBox1.Controls.Add(this.lblUpdateEmployee);
            this.groupBox1.Controls.Add(this.btnPaySchedule);
            this.groupBox1.Controls.Add(this.btnLocationToday);
            this.groupBox1.Controls.Add(this.btnManageMenuItems);
            this.groupBox1.Controls.Add(this.btnNewEmployee);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 581);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Denali Indian Tacos";
            // 
            // lblViewEmployees
            // 
            this.lblViewEmployees.Location = new System.Drawing.Point(12, 329);
            this.lblViewEmployees.Name = "lblViewEmployees";
            this.lblViewEmployees.Size = new System.Drawing.Size(78, 51);
            this.lblViewEmployees.TabIndex = 39;
            this.lblViewEmployees.Text = "View Employees";
            this.lblViewEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnViewEmployees
            // 
            this.btnViewEmployees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewEmployees.BackgroundImage")));
            this.btnViewEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewEmployees.ForeColor = System.Drawing.Color.Black;
            this.btnViewEmployees.Location = new System.Drawing.Point(94, 326);
            this.btnViewEmployees.Name = "btnViewEmployees";
            this.btnViewEmployees.Size = new System.Drawing.Size(68, 56);
            this.btnViewEmployees.TabIndex = 38;
            this.btnViewEmployees.UseVisualStyleBackColor = true;
            this.btnViewEmployees.Click += new System.EventHandler(this.btnViewEmployees_Click);
            // 
            // lblSeeMenu
            // 
            this.lblSeeMenu.Location = new System.Drawing.Point(10, 171);
            this.lblSeeMenu.Name = "lblSeeMenu";
            this.lblSeeMenu.Size = new System.Drawing.Size(78, 51);
            this.lblSeeMenu.TabIndex = 37;
            this.lblSeeMenu.Text = "See Menu";
            this.lblSeeMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSeeMenuItems
            // 
            this.btnSeeMenuItems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeeMenuItems.BackgroundImage")));
            this.btnSeeMenuItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeeMenuItems.ForeColor = System.Drawing.Color.Black;
            this.btnSeeMenuItems.Location = new System.Drawing.Point(94, 166);
            this.btnSeeMenuItems.Name = "btnSeeMenuItems";
            this.btnSeeMenuItems.Size = new System.Drawing.Size(68, 56);
            this.btnSeeMenuItems.TabIndex = 36;
            this.btnSeeMenuItems.UseVisualStyleBackColor = true;
            this.btnSeeMenuItems.Click += new System.EventHandler(this.btnSeeMenuItems_Click);
            // 
            // lblLocationToday
            // 
            this.lblLocationToday.Location = new System.Drawing.Point(10, 91);
            this.lblLocationToday.Name = "lblLocationToday";
            this.lblLocationToday.Size = new System.Drawing.Size(78, 51);
            this.lblLocationToday.TabIndex = 32;
            this.lblLocationToday.Text = "Location Today";
            this.lblLocationToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUpdateMenu
            // 
            this.lblUpdateMenu.Location = new System.Drawing.Point(14, 249);
            this.lblUpdateMenu.Name = "lblUpdateMenu";
            this.lblUpdateMenu.Size = new System.Drawing.Size(78, 51);
            this.lblUpdateMenu.TabIndex = 31;
            this.lblUpdateMenu.Text = "Update Menu";
            this.lblUpdateMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPayroll
            // 
            this.lblPayroll.Location = new System.Drawing.Point(14, 489);
            this.lblPayroll.Name = "lblPayroll";
            this.lblPayroll.Size = new System.Drawing.Size(78, 51);
            this.lblPayroll.TabIndex = 30;
            this.lblPayroll.Text = "Payroll";
            this.lblPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUpdateEmployee
            // 
            this.lblUpdateEmployee.Location = new System.Drawing.Point(14, 411);
            this.lblUpdateEmployee.Name = "lblUpdateEmployee";
            this.lblUpdateEmployee.Size = new System.Drawing.Size(78, 51);
            this.lblUpdateEmployee.TabIndex = 29;
            this.lblUpdateEmployee.Text = "Update Employee";
            this.lblUpdateEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPaySchedule
            // 
            this.btnPaySchedule.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaySchedule.BackgroundImage")));
            this.btnPaySchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaySchedule.ForeColor = System.Drawing.Color.Black;
            this.btnPaySchedule.Location = new System.Drawing.Point(94, 486);
            this.btnPaySchedule.Name = "btnPaySchedule";
            this.btnPaySchedule.Size = new System.Drawing.Size(68, 56);
            this.btnPaySchedule.TabIndex = 24;
            this.btnPaySchedule.UseVisualStyleBackColor = true;
            this.btnPaySchedule.Click += new System.EventHandler(this.btnPaySchedule_Click);
            // 
            // btnLocationToday
            // 
            this.btnLocationToday.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLocationToday.BackgroundImage")));
            this.btnLocationToday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocationToday.ForeColor = System.Drawing.Color.Black;
            this.btnLocationToday.Location = new System.Drawing.Point(94, 86);
            this.btnLocationToday.Name = "btnLocationToday";
            this.btnLocationToday.Size = new System.Drawing.Size(68, 56);
            this.btnLocationToday.TabIndex = 21;
            this.btnLocationToday.UseVisualStyleBackColor = true;
            this.btnLocationToday.Click += new System.EventHandler(this.btnLocationToday_Click);
            // 
            // btnManageMenuItems
            // 
            this.btnManageMenuItems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageMenuItems.BackgroundImage")));
            this.btnManageMenuItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageMenuItems.ForeColor = System.Drawing.Color.Black;
            this.btnManageMenuItems.Location = new System.Drawing.Point(94, 246);
            this.btnManageMenuItems.Name = "btnManageMenuItems";
            this.btnManageMenuItems.Size = new System.Drawing.Size(68, 56);
            this.btnManageMenuItems.TabIndex = 20;
            this.btnManageMenuItems.UseVisualStyleBackColor = true;
            this.btnManageMenuItems.Click += new System.EventHandler(this.btnManageMenuItems_Click);
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewEmployee.BackgroundImage")));
            this.btnNewEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnNewEmployee.Location = new System.Drawing.Point(94, 406);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(68, 56);
            this.btnNewEmployee.TabIndex = 16;
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(888, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 56);
            this.btnClose.TabIndex = 35;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Team3.Properties.Resources.denali_logo;
            this.pictureBox1.Location = new System.Drawing.Point(174, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(708, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // dgvTest
            // 
            this.dgvTest.AllowUserToAddRows = false;
            this.dgvTest.AllowUserToDeleteRows = false;
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Location = new System.Drawing.Point(177, 112);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.ReadOnly = true;
            this.dgvTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTest.Size = new System.Drawing.Size(779, 467);
            this.dgvTest.TabIndex = 36;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::Team3.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(961, 591);
            this.ControlBox = false;
            this.Controls.Add(this.dgvTest);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";

            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPaySchedule;
        private System.Windows.Forms.Button btnLocationToday;
        private System.Windows.Forms.Button btnManageMenuItems;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.DataGridView dgvTester;
        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.Label lblLocationToday;
        private System.Windows.Forms.Label lblUpdateMenu;
        private System.Windows.Forms.Label lblPayroll;
        private System.Windows.Forms.Label lblUpdateEmployee;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSeeMenu;
        private System.Windows.Forms.Button btnSeeMenuItems;
        private System.Windows.Forms.Label lblViewEmployees;
        private System.Windows.Forms.Button btnViewEmployees;

    }
}