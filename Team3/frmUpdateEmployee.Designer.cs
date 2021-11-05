namespace Team3
{
    partial class frmUpdateEmployee
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
            this.label13 = new System.Windows.Forms.Label();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxZipCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxState = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.mskStartDate = new System.Windows.Forms.MaskedTextBox();
            this.mskDOB = new System.Windows.Forms.MaskedTextBox();
            this.tbxEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmplID = new System.Windows.Forms.Label();
            this.tbxLogOnPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxLogOnName = new System.Windows.Forms.TextBox();
            this.lblLogOnName = new System.Windows.Forms.Label();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dgvEmpManager = new System.Windows.Forms.DataGridView();
            this.inew2330fa21DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inew2330fa21DataSet = new Team3.inew2330fa21DataSet();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330fa21DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330fa21DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(44, 299);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 22);
            this.label13.TabIndex = 54;
            this.label13.Text = "Phone:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhoneNumber.ForeColor = System.Drawing.Color.Red;
            this.tbxPhoneNumber.Location = new System.Drawing.Point(109, 292);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(283, 29);
            this.tbxPhoneNumber.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(41, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 22);
            this.label12.TabIndex = 51;
            this.label12.Text = "Gender:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxRole
            // 
            this.cbxRole.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRole.ForeColor = System.Drawing.Color.Red;
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Items.AddRange(new object[] {
            "Employee",
            "Owner",
            "Dishwasher",
            "Cashier"});
            this.cbxRole.Location = new System.Drawing.Point(109, 371);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(283, 30);
            this.cbxRole.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(32, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 22);
            this.label10.TabIndex = 48;
            this.label10.Text = "Job Title:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(49, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 22);
            this.label9.TabIndex = 47;
            this.label9.Text = "DOB:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(47, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 22);
            this.label8.TabIndex = 46;
            this.label8.Text = "Email:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.ForeColor = System.Drawing.Color.Red;
            this.tbxEmail.Location = new System.Drawing.Point(109, 332);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(283, 29);
            this.tbxEmail.TabIndex = 9;
            // 
            // tbxZipCode
            // 
            this.tbxZipCode.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxZipCode.ForeColor = System.Drawing.Color.Red;
            this.tbxZipCode.Location = new System.Drawing.Point(266, 252);
            this.tbxZipCode.Name = "tbxZipCode";
            this.tbxZipCode.Size = new System.Drawing.Size(124, 29);
            this.tbxZipCode.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(187, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 22);
            this.label7.TabIndex = 43;
            this.label7.Text = "Zip Code:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxState
            // 
            this.cbxState.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxState.ForeColor = System.Drawing.Color.Red;
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cbxState.Location = new System.Drawing.Point(109, 251);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(69, 30);
            this.cbxState.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(49, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 22);
            this.label6.TabIndex = 41;
            this.label6.Text = "State:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxCity
            // 
            this.tbxCity.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCity.ForeColor = System.Drawing.Color.Red;
            this.tbxCity.Location = new System.Drawing.Point(109, 212);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(283, 29);
            this.tbxCity.TabIndex = 4;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.Black;
            this.lblCity.Location = new System.Drawing.Point(53, 219);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 22);
            this.lblCity.TabIndex = 39;
            this.lblCity.Text = "City:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.ForeColor = System.Drawing.Color.Red;
            this.tbxAddress.Location = new System.Drawing.Point(109, 172);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(283, 29);
            this.tbxAddress.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 37;
            this.label4.Text = "Address:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.ForeColor = System.Drawing.Color.Red;
            this.tbxLastName.Location = new System.Drawing.Point(107, 92);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(283, 29);
            this.tbxLastName.TabIndex = 2;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.ForeColor = System.Drawing.Color.Red;
            this.tbxFirstName.Location = new System.Drawing.Point(107, 52);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(283, 29);
            this.tbxFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Last Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "First Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxGender
            // 
            this.cbxGender.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGender.ForeColor = System.Drawing.Color.Red;
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbxGender.Location = new System.Drawing.Point(107, 131);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(69, 30);
            this.cbxGender.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtStartDate);
            this.panel1.Controls.Add(this.dtDOB);
            this.panel1.Controls.Add(this.mskStartDate);
            this.panel1.Controls.Add(this.mskDOB);
            this.panel1.Controls.Add(this.tbxEmployeeID);
            this.panel1.Controls.Add(this.lblEmplID);
            this.panel1.Controls.Add(this.tbxLogOnPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbxLogOnName);
            this.panel1.Controls.Add(this.lblLogOnName);
            this.panel1.Controls.Add(this.tbxAge);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.dgvEmpManager);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.tbxFirstName);
            this.panel1.Controls.Add(this.cbxGender);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbxLastName);
            this.panel1.Controls.Add(this.tbxEmail);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxRole);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbxZipCode);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tbxAddress);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbxPhoneNumber);
            this.panel1.Controls.Add(this.tbxCity);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbxState);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(9, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1479, 715);
            this.panel1.TabIndex = 57;
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "yyyy-MM-dd";
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(418, 461);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtStartDate.TabIndex = 83;
            // 
            // dtDOB
            // 
            this.dtDOB.CustomFormat = "yyyy-MM-dd";
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDOB.Location = new System.Drawing.Point(418, 422);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(200, 20);
            this.dtDOB.TabIndex = 82;
            // 
            // mskStartDate
            // 
            this.mskStartDate.Location = new System.Drawing.Point(109, 459);
            this.mskStartDate.Mask = "0000-00-00";
            this.mskStartDate.Name = "mskStartDate";
            this.mskStartDate.Size = new System.Drawing.Size(283, 20);
            this.mskStartDate.TabIndex = 79;
            // 
            // mskDOB
            // 
            this.mskDOB.Location = new System.Drawing.Point(104, 422);
            this.mskDOB.Mask = "0000-00-00";
            this.mskDOB.Name = "mskDOB";
            this.mskDOB.Size = new System.Drawing.Size(283, 20);
            this.mskDOB.TabIndex = 78;
            // 
            // tbxEmployeeID
            // 
            this.tbxEmployeeID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmployeeID.ForeColor = System.Drawing.Color.Red;
            this.tbxEmployeeID.Location = new System.Drawing.Point(104, 6);
            this.tbxEmployeeID.Name = "tbxEmployeeID";
            this.tbxEmployeeID.Size = new System.Drawing.Size(283, 29);
            this.tbxEmployeeID.TabIndex = 76;
            // 
            // lblEmplID
            // 
            this.lblEmplID.AutoSize = true;
            this.lblEmplID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmplID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmplID.ForeColor = System.Drawing.Color.Black;
            this.lblEmplID.Location = new System.Drawing.Point(11, 13);
            this.lblEmplID.Name = "lblEmplID";
            this.lblEmplID.Size = new System.Drawing.Size(99, 22);
            this.lblEmplID.TabIndex = 77;
            this.lblEmplID.Text = "EmployeeID:";
            this.lblEmplID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxLogOnPassword
            // 
            this.tbxLogOnPassword.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLogOnPassword.ForeColor = System.Drawing.Color.Red;
            this.tbxLogOnPassword.Location = new System.Drawing.Point(146, 533);
            this.tbxLogOnPassword.Name = "tbxLogOnPassword";
            this.tbxLogOnPassword.Size = new System.Drawing.Size(283, 29);
            this.tbxLogOnPassword.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 75;
            this.label3.Text = "LogOn Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxLogOnName
            // 
            this.tbxLogOnName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLogOnName.ForeColor = System.Drawing.Color.Red;
            this.tbxLogOnName.Location = new System.Drawing.Point(146, 499);
            this.tbxLogOnName.Name = "tbxLogOnName";
            this.tbxLogOnName.Size = new System.Drawing.Size(283, 29);
            this.tbxLogOnName.TabIndex = 72;
            // 
            // lblLogOnName
            // 
            this.lblLogOnName.AutoSize = true;
            this.lblLogOnName.BackColor = System.Drawing.Color.Transparent;
            this.lblLogOnName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOnName.ForeColor = System.Drawing.Color.Black;
            this.lblLogOnName.Location = new System.Drawing.Point(3, 502);
            this.lblLogOnName.Name = "lblLogOnName";
            this.lblLogOnName.Size = new System.Drawing.Size(109, 22);
            this.lblLogOnName.TabIndex = 73;
            this.lblLogOnName.Text = "LogOn Name:";
            this.lblLogOnName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxAge
            // 
            this.tbxAge.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAge.ForeColor = System.Drawing.Color.Red;
            this.tbxAge.Location = new System.Drawing.Point(311, 131);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(79, 29);
            this.tbxAge.TabIndex = 71;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.Black;
            this.lblAge.Location = new System.Drawing.Point(262, 134);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 22);
            this.lblAge.TabIndex = 70;
            this.lblAge.Text = "Age:";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.Black;
            this.lblStartDate.Location = new System.Drawing.Point(18, 459);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(83, 22);
            this.lblStartDate.TabIndex = 64;
            this.lblStartDate.Text = "Start Date:";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvEmpManager
            // 
            this.dgvEmpManager.AutoGenerateColumns = false;
            this.dgvEmpManager.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvEmpManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpManager.DataSource = this.inew2330fa21DataSetBindingSource;
            this.dgvEmpManager.Location = new System.Drawing.Point(434, 13);
            this.dgvEmpManager.Name = "dgvEmpManager";
            this.dgvEmpManager.Size = new System.Drawing.Size(1033, 644);
            this.dgvEmpManager.TabIndex = 60;
            this.dgvEmpManager.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpManager_CellContentClick);
            // 
            // inew2330fa21DataSetBindingSource
            // 
            this.inew2330fa21DataSetBindingSource.DataSource = this.inew2330fa21DataSet;
            this.inew2330fa21DataSetBindingSource.Position = 0;
            // 
            // inew2330fa21DataSet
            // 
            this.inew2330fa21DataSet.DataSetName = "inew2330fa21DataSet";
            this.inew2330fa21DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(146, 663);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(126, 41);
            this.btnHome.TabIndex = 59;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(287, 616);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(126, 41);
            this.btnEdit.TabIndex = 58;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(146, 616);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 41);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 616);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 41);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Team3.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1500, 768);
            this.Controls.Add(this.panel1);
            this.Name = "frmUpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Employee";
            this.Load += new System.EventHandler(this.frmUpdateEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330fa21DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inew2330fa21DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxZipCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEmpManager;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox tbxLogOnPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxLogOnName;
        private System.Windows.Forms.Label lblLogOnName;
        private System.Windows.Forms.TextBox tbxEmployeeID;
        private System.Windows.Forms.Label lblEmplID;
        private System.Windows.Forms.MaskedTextBox mskStartDate;
        private System.Windows.Forms.MaskedTextBox mskDOB;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.BindingSource inew2330fa21DataSetBindingSource;
        private inew2330fa21DataSet inew2330fa21DataSet;
    }
}