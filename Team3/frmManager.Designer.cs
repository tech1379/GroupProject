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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPaySchedule = new System.Windows.Forms.Button();
            this.btnEventRequests = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnLocationToday = new System.Windows.Forms.Button();
            this.btnManageMenuItems = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnPayDetails = new System.Windows.Forms.Button();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.inew2330fa21DataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inew2330fa21DataSet = new Team3.inew2330fa21DataSet();
            this.dgvTester = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330fa21DataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330fa21DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTester)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSchedule);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.Controls.Add(this.btnPaySchedule);
            this.groupBox1.Controls.Add(this.btnEventRequests);
            this.groupBox1.Controls.Add(this.btnCustomers);
            this.groupBox1.Controls.Add(this.btnLocationToday);
            this.groupBox1.Controls.Add(this.btnManageMenuItems);
            this.groupBox1.Controls.Add(this.btnOrders);
            this.groupBox1.Controls.Add(this.btnPayDetails);
            this.groupBox1.Controls.Add(this.btnNewEmployee);
            this.groupBox1.Controls.Add(this.btnEmployees);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 619);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Denali Indian Tacos";
            // 
            // btnSchedule
            // 
            this.btnSchedule.ForeColor = System.Drawing.Color.Black;
            this.btnSchedule.Location = new System.Drawing.Point(10, 478);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(180, 32);
            this.btnSchedule.TabIndex = 28;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(10, 579);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 32);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "E&XIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Team3.Properties.Resources.denali_logo;
            this.pictureBox1.Location = new System.Drawing.Point(10, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(10, 541);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 32);
            this.btnLogout.TabIndex = 25;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnPaySchedule
            // 
            this.btnPaySchedule.ForeColor = System.Drawing.Color.Black;
            this.btnPaySchedule.Location = new System.Drawing.Point(10, 441);
            this.btnPaySchedule.Name = "btnPaySchedule";
            this.btnPaySchedule.Size = new System.Drawing.Size(180, 32);
            this.btnPaySchedule.TabIndex = 24;
            this.btnPaySchedule.Text = "PaySchedule";
            this.btnPaySchedule.UseVisualStyleBackColor = true;
            this.btnPaySchedule.Click += new System.EventHandler(this.btnPaySchedule_Click);
            // 
            // btnEventRequests
            // 
            this.btnEventRequests.ForeColor = System.Drawing.Color.Black;
            this.btnEventRequests.Location = new System.Drawing.Point(10, 219);
            this.btnEventRequests.Name = "btnEventRequests";
            this.btnEventRequests.Size = new System.Drawing.Size(180, 32);
            this.btnEventRequests.TabIndex = 23;
            this.btnEventRequests.Text = "Event Requests";
            this.btnEventRequests.UseVisualStyleBackColor = true;
            this.btnEventRequests.Click += new System.EventHandler(this.btnEventRequests_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.ForeColor = System.Drawing.Color.Black;
            this.btnCustomers.Location = new System.Drawing.Point(10, 145);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(180, 32);
            this.btnCustomers.TabIndex = 22;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnLocationToday
            // 
            this.btnLocationToday.ForeColor = System.Drawing.Color.Black;
            this.btnLocationToday.Location = new System.Drawing.Point(10, 256);
            this.btnLocationToday.Name = "btnLocationToday";
            this.btnLocationToday.Size = new System.Drawing.Size(180, 32);
            this.btnLocationToday.TabIndex = 21;
            this.btnLocationToday.Text = "Location Today";
            this.btnLocationToday.UseVisualStyleBackColor = true;
            // 
            // btnManageMenuItems
            // 
            this.btnManageMenuItems.ForeColor = System.Drawing.Color.Black;
            this.btnManageMenuItems.Location = new System.Drawing.Point(10, 293);
            this.btnManageMenuItems.Name = "btnManageMenuItems";
            this.btnManageMenuItems.Size = new System.Drawing.Size(180, 32);
            this.btnManageMenuItems.TabIndex = 20;
            this.btnManageMenuItems.Text = "Manage Menu Items";
            this.btnManageMenuItems.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            this.btnOrders.ForeColor = System.Drawing.Color.Black;
            this.btnOrders.Location = new System.Drawing.Point(10, 367);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(180, 32);
            this.btnOrders.TabIndex = 19;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnPayDetails
            // 
            this.btnPayDetails.ForeColor = System.Drawing.Color.Black;
            this.btnPayDetails.Location = new System.Drawing.Point(10, 404);
            this.btnPayDetails.Name = "btnPayDetails";
            this.btnPayDetails.Size = new System.Drawing.Size(180, 32);
            this.btnPayDetails.TabIndex = 18;
            this.btnPayDetails.Text = "Pay Details";
            this.btnPayDetails.UseVisualStyleBackColor = true;
            this.btnPayDetails.Click += new System.EventHandler(this.btnPayDetails_Click);
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnNewEmployee.Location = new System.Drawing.Point(10, 330);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(180, 32);
            this.btnNewEmployee.TabIndex = 16;
            this.btnNewEmployee.Text = "New Employee";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.ForeColor = System.Drawing.Color.Black;
            this.btnEmployees.Location = new System.Drawing.Point(10, 182);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(180, 32);
            this.btnEmployees.TabIndex = 15;
            this.btnEmployees.Text = "Employee";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // inew2330fa21DataBindingSource
            // 
            this.inew2330fa21DataBindingSource.DataSource = this.inew2330fa21DataSet;
            this.inew2330fa21DataBindingSource.Position = 0;
            // 
            // inew2330fa21DataSet
            // 
            this.inew2330fa21DataSet.DataSetName = "inew2330fa21DataSet";
            this.inew2330fa21DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvTester
            // 
            this.dgvTester.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTester.Location = new System.Drawing.Point(207, 75);
            this.dgvTester.Name = "dgvTester";
            this.dgvTester.Size = new System.Drawing.Size(749, 544);
            this.dgvTester.TabIndex = 27;
            // 
            // btnView
            // 
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Location = new System.Drawing.Point(219, 37);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(180, 32);
            this.btnView.TabIndex = 29;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnSalary
            // 
            this.btnSalary.ForeColor = System.Drawing.Color.Black;
            this.btnSalary.Location = new System.Drawing.Point(432, 37);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(180, 32);
            this.btnSalary.TabIndex = 30;
            this.btnSalary.Text = "Salary";
            this.btnSalary.UseVisualStyleBackColor = true;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::Team3.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(961, 623);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dgvTester);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330fa21DataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330fa21DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTester)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPaySchedule;
        private System.Windows.Forms.Button btnEventRequests;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnLocationToday;
        private System.Windows.Forms.Button btnManageMenuItems;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnPayDetails;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.BindingSource inew2330fa21DataBindingSource;
        private inew2330fa21DataSet inew2330fa21DataSet;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvTester;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSalary;
    }
}