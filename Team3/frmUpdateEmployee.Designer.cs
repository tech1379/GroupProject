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
            this.lblHintInfo = new System.Windows.Forms.Label();
            this.mskStartDate = new System.Windows.Forms.MaskedTextBox();
            this.mskDOB = new System.Windows.Forms.MaskedTextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbxLogOnName = new System.Windows.Forms.TextBox();
            this.lblLogonName = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.dgvEmpManager = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.tbxLogOnPassword = new System.Windows.Forms.TextBox();
            this.lblLogOnPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpManager)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(59, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 22);
            this.label13.TabIndex = 54;
            this.label13.Text = "Phone:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhoneNumber.ForeColor = System.Drawing.Color.Red;
            this.tbxPhoneNumber.Location = new System.Drawing.Point(122, 292);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(283, 29);
            this.tbxPhoneNumber.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(52, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 22);
            this.label12.TabIndex = 51;
            this.label12.Text = "Gender:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.cbxRole.Location = new System.Drawing.Point(122, 372);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(283, 30);
            this.cbxRole.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(47, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 22);
            this.label10.TabIndex = 48;
            this.label10.Text = "Job Title:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(67, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 22);
            this.label9.TabIndex = 47;
            this.label9.Text = "DOB:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(62, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 22);
            this.label8.TabIndex = 46;
            this.label8.Text = "Email:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.ForeColor = System.Drawing.Color.Red;
            this.tbxEmail.Location = new System.Drawing.Point(122, 332);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(283, 29);
            this.tbxEmail.TabIndex = 11;
            // 
            // tbxZipCode
            // 
            this.tbxZipCode.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxZipCode.ForeColor = System.Drawing.Color.Red;
            this.tbxZipCode.Location = new System.Drawing.Point(281, 252);
            this.tbxZipCode.Name = "tbxZipCode";
            this.tbxZipCode.Size = new System.Drawing.Size(124, 29);
            this.tbxZipCode.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(197, 259);
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
            this.cbxState.Location = new System.Drawing.Point(122, 253);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(69, 30);
            this.cbxState.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(64, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 22);
            this.label6.TabIndex = 41;
            this.label6.Text = "State:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbxCity
            // 
            this.tbxCity.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCity.ForeColor = System.Drawing.Color.Red;
            this.tbxCity.Location = new System.Drawing.Point(122, 212);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(283, 29);
            this.tbxCity.TabIndex = 7;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.Black;
            this.lblCity.Location = new System.Drawing.Point(69, 215);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 22);
            this.lblCity.TabIndex = 39;
            this.lblCity.Text = "City:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.ForeColor = System.Drawing.Color.Red;
            this.tbxAddress.Location = new System.Drawing.Point(122, 172);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(283, 29);
            this.tbxAddress.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(48, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 37;
            this.label4.Text = "Address:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.ForeColor = System.Drawing.Color.Red;
            this.tbxLastName.Location = new System.Drawing.Point(122, 92);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(283, 29);
            this.tbxLastName.TabIndex = 3;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.ForeColor = System.Drawing.Color.Red;
            this.tbxFirstName.Location = new System.Drawing.Point(122, 52);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(283, 29);
            this.tbxFirstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Last Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "First Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbxGender
            // 
            this.cbxGender.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGender.ForeColor = System.Drawing.Color.Red;
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbxGender.Location = new System.Drawing.Point(122, 132);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(69, 30);
            this.cbxGender.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxType);
            this.panel1.Controls.Add(this.lblHintInfo);
            this.panel1.Controls.Add(this.tbxLogOnPassword);
            this.panel1.Controls.Add(this.lblLogOnPassword);
            this.panel1.Controls.Add(this.mskStartDate);
            this.panel1.Controls.Add(this.mskDOB);
            this.panel1.Controls.Add(this.tbxAge);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.tbxLogOnName);
            this.panel1.Controls.Add(this.lblLogonName);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.lblEmpID);
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
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 573);
            this.panel1.TabIndex = 57;
            // 
            // lblHintInfo
            // 
            this.lblHintInfo.AutoSize = true;
            this.lblHintInfo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHintInfo.Location = new System.Drawing.Point(707, 514);
            this.lblHintInfo.Name = "lblHintInfo";
            this.lblHintInfo.Size = new System.Drawing.Size(465, 25);
            this.lblHintInfo.TabIndex = 76;
            this.lblHintInfo.Text = "Double click on a cell to insert employee information ";
            // 
            // mskStartDate
            // 
            this.mskStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskStartDate.Location = new System.Drawing.Point(122, 450);
            this.mskStartDate.Name = "mskStartDate";
            this.mskStartDate.Size = new System.Drawing.Size(283, 26);
            this.mskStartDate.TabIndex = 14;
            // 
            // mskDOB
            // 
            this.mskDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDOB.Location = new System.Drawing.Point(122, 413);
            this.mskDOB.Name = "mskDOB";
            this.mskDOB.Size = new System.Drawing.Size(283, 26);
            this.mskDOB.TabIndex = 13;
            // 
            // tbxAge
            // 
            this.tbxAge.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAge.ForeColor = System.Drawing.Color.Red;
            this.tbxAge.Location = new System.Drawing.Point(326, 132);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(79, 29);
            this.tbxAge.TabIndex = 5;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.Black;
            this.lblAge.Location = new System.Drawing.Point(277, 134);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 22);
            this.lblAge.TabIndex = 70;
            this.lblAge.Text = "Age:";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxLogOnName
            // 
            this.tbxLogOnName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLogOnName.ForeColor = System.Drawing.Color.Red;
            this.tbxLogOnName.Location = new System.Drawing.Point(122, 487);
            this.tbxLogOnName.Name = "tbxLogOnName";
            this.tbxLogOnName.Size = new System.Drawing.Size(152, 29);
            this.tbxLogOnName.TabIndex = 15;
            // 
            // lblLogonName
            // 
            this.lblLogonName.AutoSize = true;
            this.lblLogonName.BackColor = System.Drawing.Color.Transparent;
            this.lblLogonName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogonName.ForeColor = System.Drawing.Color.Black;
            this.lblLogonName.Location = new System.Drawing.Point(11, 490);
            this.lblLogonName.Name = "lblLogonName";
            this.lblLogonName.Size = new System.Drawing.Size(105, 22);
            this.lblLogonName.TabIndex = 67;
            this.lblLogonName.Text = "LogOnName:";
            this.lblLogonName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.Black;
            this.lblStartDate.Location = new System.Drawing.Point(33, 452);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(83, 22);
            this.lblStartDate.TabIndex = 64;
            this.lblStartDate.Text = "Start Date:";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.ForeColor = System.Drawing.Color.Black;
            this.lblEmpID.Location = new System.Drawing.Point(0, 13);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(120, 22);
            this.lblEmpID.TabIndex = 63;
            this.lblEmpID.Text = "Employee Type:";
            this.lblEmpID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvEmpManager
            // 
            this.dgvEmpManager.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvEmpManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpManager.Location = new System.Drawing.Point(411, 13);
            this.dgvEmpManager.Name = "dgvEmpManager";
            this.dgvEmpManager.Size = new System.Drawing.Size(804, 468);
            this.dgvEmpManager.TabIndex = 60;
            this.dgvEmpManager.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpManager_CellContentClick);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(527, 534);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(112, 29);
            this.btnHome.TabIndex = 20;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(409, 534);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 29);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(527, 496);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 29);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(409, 497);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 29);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxType
            // 
            this.cbxType.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(122, 13);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(283, 30);
            this.cbxType.TabIndex = 77;
            // 
            // tbxLogOnPassword
            // 
            this.tbxLogOnPassword.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLogOnPassword.ForeColor = System.Drawing.Color.Red;
            this.tbxLogOnPassword.Location = new System.Drawing.Point(122, 527);
            this.tbxLogOnPassword.Name = "tbxLogOnPassword";
            this.tbxLogOnPassword.Size = new System.Drawing.Size(152, 29);
            this.tbxLogOnPassword.TabIndex = 16;
            // 
            // lblLogOnPassword
            // 
            this.lblLogOnPassword.AutoSize = true;
            this.lblLogOnPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblLogOnPassword.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOnPassword.ForeColor = System.Drawing.Color.Black;
            this.lblLogOnPassword.Location = new System.Drawing.Point(38, 530);
            this.lblLogOnPassword.Name = "lblLogOnPassword";
            this.lblLogOnPassword.Size = new System.Drawing.Size(78, 22);
            this.lblLogOnPassword.TabIndex = 75;
            this.lblLogOnPassword.Text = "Password:";
            this.lblLogOnPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Team3.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1260, 616);
            this.Controls.Add(this.panel1);
            this.Name = "frmUpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Employee";
            this.Load += new System.EventHandler(this.frmUpdateEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpManager)).EndInit();
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
        private System.Windows.Forms.TextBox tbxLogOnName;
        private System.Windows.Forms.Label lblLogonName;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.MaskedTextBox mskStartDate;
        private System.Windows.Forms.MaskedTextBox mskDOB;
        private System.Windows.Forms.Label lblHintInfo;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.TextBox tbxLogOnPassword;
        private System.Windows.Forms.Label lblLogOnPassword;
    }
}