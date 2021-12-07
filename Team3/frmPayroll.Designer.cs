namespace Team3
{
    partial class frmPayroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayroll));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbxRateOfPay = new System.Windows.Forms.TextBox();
            this.tbxHoursWorked = new System.Windows.Forms.TextBox();
            this.tbxEmployeeID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPayStub = new System.Windows.Forms.Label();
            this.lblTextEmpID = new System.Windows.Forms.Label();
            this.lblTextHourlyRate = new System.Windows.Forms.Label();
            this.lblTextWeeklyHours = new System.Windows.Forms.Label();
            this.lblTextOTHours = new System.Windows.Forms.Label();
            this.lblTextOT = new System.Windows.Forms.Label();
            this.lblTextGross = new System.Windows.Forms.Label();
            this.lblTextSocSecWithheld = new System.Windows.Forms.Label();
            this.lblTextFICAwithheld = new System.Windows.Forms.Label();
            this.lblTextNetPay = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblWeekHoursWorked = new System.Windows.Forms.Label();
            this.lblOTHoursWorked = new System.Windows.Forms.Label();
            this.lblOTPay = new System.Windows.Forms.Label();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.lblSocSecWithheld = new System.Windows.Forms.Label();
            this.lblFICAWithheld = new System.Windows.Forms.Label();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.tbxRateOfPay);
            this.groupBox1.Controls.Add(this.tbxHoursWorked);
            this.groupBox1.Controls.Add(this.tbxEmployeeID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 203);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payroll Information";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(182, 162);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 35);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbxRateOfPay
            // 
            this.tbxRateOfPay.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRateOfPay.Location = new System.Drawing.Point(182, 124);
            this.tbxRateOfPay.Name = "tbxRateOfPay";
            this.tbxRateOfPay.Size = new System.Drawing.Size(100, 29);
            this.tbxRateOfPay.TabIndex = 3;
            // 
            // tbxHoursWorked
            // 
            this.tbxHoursWorked.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHoursWorked.Location = new System.Drawing.Point(182, 81);
            this.tbxHoursWorked.Name = "tbxHoursWorked";
            this.tbxHoursWorked.Size = new System.Drawing.Size(100, 29);
            this.tbxHoursWorked.TabIndex = 2;
            // 
            // tbxEmployeeID
            // 
            this.tbxEmployeeID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmployeeID.Location = new System.Drawing.Point(182, 38);
            this.tbxEmployeeID.Name = "tbxEmployeeID";
            this.tbxEmployeeID.Size = new System.Drawing.Size(100, 29);
            this.tbxEmployeeID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hourly Rate";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weekly Hours Worked";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmployeeID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(400, 407);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 33);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Cl&ose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(275, 407);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 33);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPayStub
            // 
            this.lblPayStub.AutoSize = true;
            this.lblPayStub.BackColor = System.Drawing.Color.Transparent;
            this.lblPayStub.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayStub.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPayStub.Location = new System.Drawing.Point(521, 22);
            this.lblPayStub.Name = "lblPayStub";
            this.lblPayStub.Size = new System.Drawing.Size(99, 28);
            this.lblPayStub.TabIndex = 8;
            this.lblPayStub.Text = "Pay Stub";
            // 
            // lblTextEmpID
            // 
            this.lblTextEmpID.AutoSize = true;
            this.lblTextEmpID.BackColor = System.Drawing.Color.Transparent;
            this.lblTextEmpID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextEmpID.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblTextEmpID.Location = new System.Drawing.Point(403, 72);
            this.lblTextEmpID.Name = "lblTextEmpID";
            this.lblTextEmpID.Size = new System.Drawing.Size(103, 22);
            this.lblTextEmpID.TabIndex = 17;
            this.lblTextEmpID.Text = "EmployeeID";
            // 
            // lblTextHourlyRate
            // 
            this.lblTextHourlyRate.AutoSize = true;
            this.lblTextHourlyRate.BackColor = System.Drawing.Color.Transparent;
            this.lblTextHourlyRate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextHourlyRate.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblTextHourlyRate.Location = new System.Drawing.Point(406, 110);
            this.lblTextHourlyRate.Name = "lblTextHourlyRate";
            this.lblTextHourlyRate.Size = new System.Drawing.Size(100, 22);
            this.lblTextHourlyRate.TabIndex = 19;
            this.lblTextHourlyRate.Text = "Hourly Rate";
            // 
            // lblTextWeeklyHours
            // 
            this.lblTextWeeklyHours.AutoSize = true;
            this.lblTextWeeklyHours.BackColor = System.Drawing.Color.Transparent;
            this.lblTextWeeklyHours.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextWeeklyHours.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblTextWeeklyHours.Location = new System.Drawing.Point(325, 146);
            this.lblTextWeeklyHours.Name = "lblTextWeeklyHours";
            this.lblTextWeeklyHours.Size = new System.Drawing.Size(179, 22);
            this.lblTextWeeklyHours.TabIndex = 20;
            this.lblTextWeeklyHours.Text = "Weekly Hours Worked";
            // 
            // lblTextOTHours
            // 
            this.lblTextOTHours.AutoSize = true;
            this.lblTextOTHours.BackColor = System.Drawing.Color.Transparent;
            this.lblTextOTHours.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextOTHours.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblTextOTHours.Location = new System.Drawing.Point(311, 182);
            this.lblTextOTHours.Name = "lblTextOTHours";
            this.lblTextOTHours.Size = new System.Drawing.Size(195, 22);
            this.lblTextOTHours.TabIndex = 21;
            this.lblTextOTHours.Text = "Overtime Hours Worked";
            // 
            // lblTextOT
            // 
            this.lblTextOT.AutoSize = true;
            this.lblTextOT.BackColor = System.Drawing.Color.Transparent;
            this.lblTextOT.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextOT.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblTextOT.Location = new System.Drawing.Point(396, 218);
            this.lblTextOT.Name = "lblTextOT";
            this.lblTextOT.Size = new System.Drawing.Size(111, 22);
            this.lblTextOT.TabIndex = 22;
            this.lblTextOT.Text = "Overtime Pay";
            // 
            // lblTextGross
            // 
            this.lblTextGross.AutoSize = true;
            this.lblTextGross.BackColor = System.Drawing.Color.Transparent;
            this.lblTextGross.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextGross.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblTextGross.Location = new System.Drawing.Point(419, 254);
            this.lblTextGross.Name = "lblTextGross";
            this.lblTextGross.Size = new System.Drawing.Size(83, 22);
            this.lblTextGross.TabIndex = 23;
            this.lblTextGross.Text = "Gross Pay";
            // 
            // lblTextSocSecWithheld
            // 
            this.lblTextSocSecWithheld.AutoSize = true;
            this.lblTextSocSecWithheld.BackColor = System.Drawing.Color.Transparent;
            this.lblTextSocSecWithheld.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextSocSecWithheld.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblTextSocSecWithheld.Location = new System.Drawing.Point(307, 290);
            this.lblTextSocSecWithheld.Name = "lblTextSocSecWithheld";
            this.lblTextSocSecWithheld.Size = new System.Drawing.Size(194, 22);
            this.lblTextSocSecWithheld.TabIndex = 24;
            this.lblTextSocSecWithheld.Text = "Social Security Withheld";
            // 
            // lblTextFICAwithheld
            // 
            this.lblTextFICAwithheld.AutoSize = true;
            this.lblTextFICAwithheld.BackColor = System.Drawing.Color.Transparent;
            this.lblTextFICAwithheld.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextFICAwithheld.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblTextFICAwithheld.Location = new System.Drawing.Point(385, 326);
            this.lblTextFICAwithheld.Name = "lblTextFICAwithheld";
            this.lblTextFICAwithheld.Size = new System.Drawing.Size(123, 22);
            this.lblTextFICAwithheld.TabIndex = 25;
            this.lblTextFICAwithheld.Text = "FICA Withheld";
            // 
            // lblTextNetPay
            // 
            this.lblTextNetPay.AutoSize = true;
            this.lblTextNetPay.BackColor = System.Drawing.Color.Transparent;
            this.lblTextNetPay.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextNetPay.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblTextNetPay.Location = new System.Drawing.Point(439, 362);
            this.lblTextNetPay.Name = "lblTextNetPay";
            this.lblTextNetPay.Size = new System.Drawing.Size(67, 22);
            this.lblTextNetPay.TabIndex = 26;
            this.lblTextNetPay.Text = "Net Pay";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployeeID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(521, 71);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(214, 23);
            this.lblEmployeeID.TabIndex = 7;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHourlyRate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.Location = new System.Drawing.Point(522, 109);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(214, 23);
            this.lblHourlyRate.TabIndex = 9;
            // 
            // lblWeekHoursWorked
            // 
            this.lblWeekHoursWorked.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeekHoursWorked.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekHoursWorked.Location = new System.Drawing.Point(522, 145);
            this.lblWeekHoursWorked.Name = "lblWeekHoursWorked";
            this.lblWeekHoursWorked.Size = new System.Drawing.Size(214, 23);
            this.lblWeekHoursWorked.TabIndex = 10;
            // 
            // lblOTHoursWorked
            // 
            this.lblOTHoursWorked.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOTHoursWorked.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTHoursWorked.Location = new System.Drawing.Point(522, 181);
            this.lblOTHoursWorked.Name = "lblOTHoursWorked";
            this.lblOTHoursWorked.Size = new System.Drawing.Size(214, 23);
            this.lblOTHoursWorked.TabIndex = 11;
            // 
            // lblOTPay
            // 
            this.lblOTPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOTPay.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTPay.Location = new System.Drawing.Point(522, 217);
            this.lblOTPay.Name = "lblOTPay";
            this.lblOTPay.Size = new System.Drawing.Size(214, 23);
            this.lblOTPay.TabIndex = 12;
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrossPay.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPay.Location = new System.Drawing.Point(522, 253);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(214, 23);
            this.lblGrossPay.TabIndex = 13;
            // 
            // lblSocSecWithheld
            // 
            this.lblSocSecWithheld.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSocSecWithheld.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocSecWithheld.Location = new System.Drawing.Point(522, 289);
            this.lblSocSecWithheld.Name = "lblSocSecWithheld";
            this.lblSocSecWithheld.Size = new System.Drawing.Size(214, 23);
            this.lblSocSecWithheld.TabIndex = 14;
            // 
            // lblFICAWithheld
            // 
            this.lblFICAWithheld.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFICAWithheld.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFICAWithheld.Location = new System.Drawing.Point(522, 325);
            this.lblFICAWithheld.Name = "lblFICAWithheld";
            this.lblFICAWithheld.Size = new System.Drawing.Size(214, 23);
            this.lblFICAWithheld.TabIndex = 15;
            // 
            // lblNetPay
            // 
            this.lblNetPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetPay.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPay.Location = new System.Drawing.Point(522, 361);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(214, 23);
            this.lblNetPay.TabIndex = 16;
            // 
            // frmPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Team3.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(763, 480);
            this.Controls.Add(this.lblNetPay);
            this.Controls.Add(this.lblFICAWithheld);
            this.Controls.Add(this.lblSocSecWithheld);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.lblOTPay);
            this.Controls.Add(this.lblOTHoursWorked);
            this.Controls.Add(this.lblWeekHoursWorked);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblTextNetPay);
            this.Controls.Add(this.lblTextFICAwithheld);
            this.Controls.Add(this.lblTextSocSecWithheld);
            this.Controls.Add(this.lblTextGross);
            this.Controls.Add(this.lblTextOT);
            this.Controls.Add(this.lblTextOTHours);
            this.Controls.Add(this.lblTextWeeklyHours);
            this.Controls.Add(this.lblTextHourlyRate);
            this.Controls.Add(this.lblTextEmpID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPayStub);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbxRateOfPay;
        private System.Windows.Forms.TextBox tbxHoursWorked;
        private System.Windows.Forms.TextBox tbxEmployeeID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPayStub;
        private System.Windows.Forms.Label lblTextEmpID;
        private System.Windows.Forms.Label lblTextHourlyRate;
        private System.Windows.Forms.Label lblTextWeeklyHours;
        private System.Windows.Forms.Label lblTextOTHours;
        private System.Windows.Forms.Label lblTextOT;
        private System.Windows.Forms.Label lblTextGross;
        private System.Windows.Forms.Label lblTextSocSecWithheld;
        private System.Windows.Forms.Label lblTextFICAwithheld;
        private System.Windows.Forms.Label lblTextNetPay;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblWeekHoursWorked;
        private System.Windows.Forms.Label lblOTHoursWorked;
        private System.Windows.Forms.Label lblOTPay;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label lblSocSecWithheld;
        private System.Windows.Forms.Label lblFICAWithheld;
        private System.Windows.Forms.Label lblNetPay;
    }
}