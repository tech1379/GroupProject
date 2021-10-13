namespace Team3
{
    partial class frmClockInClockOut
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxEmpID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClockIn = new System.Windows.Forms.Button();
            this.btnClockOut = new System.Windows.Forms.Button();
            this.tbxTimeOutput = new System.Windows.Forms.TextBox();
            this.lblClockText = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(181, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(196, 48);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELCOME";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter EmployeeID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxEmpID
            // 
            this.tbxEmpID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmpID.Location = new System.Drawing.Point(205, 140);
            this.tbxEmpID.Name = "tbxEmpID";
            this.tbxEmpID.Size = new System.Drawing.Size(149, 29);
            this.tbxEmpID.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(206, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(194, 212);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(171, 51);
            this.lblTime.TabIndex = 9;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(27, 57);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(505, 51);
            this.lblDate.TabIndex = 10;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClockIn
            // 
            this.btnClockIn.BackColor = System.Drawing.Color.Transparent;
            this.btnClockIn.BackgroundImage = global::Team3.Properties.Resources.ClockIn;
            this.btnClockIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClockIn.Location = new System.Drawing.Point(42, 176);
            this.btnClockIn.Name = "btnClockIn";
            this.btnClockIn.Size = new System.Drawing.Size(146, 112);
            this.btnClockIn.TabIndex = 11;
            this.btnClockIn.UseVisualStyleBackColor = false;
            this.btnClockIn.Click += new System.EventHandler(this.btnClockIn_Click);
            // 
            // btnClockOut
            // 
            this.btnClockOut.BackColor = System.Drawing.Color.Transparent;
            this.btnClockOut.BackgroundImage = global::Team3.Properties.Resources.ClockOut;
            this.btnClockOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClockOut.Location = new System.Drawing.Point(371, 176);
            this.btnClockOut.Name = "btnClockOut";
            this.btnClockOut.Size = new System.Drawing.Size(146, 112);
            this.btnClockOut.TabIndex = 12;
            this.btnClockOut.UseVisualStyleBackColor = false;
            this.btnClockOut.Click += new System.EventHandler(this.btnClockOut_Click);
            // 
            // tbxTimeOutput
            // 
            this.tbxTimeOutput.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTimeOutput.Location = new System.Drawing.Point(340, 360);
            this.tbxTimeOutput.Name = "tbxTimeOutput";
            this.tbxTimeOutput.Size = new System.Drawing.Size(117, 29);
            this.tbxTimeOutput.TabIndex = 13;
            // 
            // lblClockText
            // 
            this.lblClockText.BackColor = System.Drawing.Color.Transparent;
            this.lblClockText.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClockText.ForeColor = System.Drawing.Color.White;
            this.lblClockText.Location = new System.Drawing.Point(12, 360);
            this.lblClockText.Name = "lblClockText";
            this.lblClockText.Size = new System.Drawing.Size(322, 29);
            this.lblClockText.TabIndex = 14;
            this.lblClockText.Text = "Thank your for your hard work!  You worked ";
            // 
            // lblMinutes
            // 
            this.lblMinutes.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.ForeColor = System.Drawing.Color.White;
            this.lblMinutes.Location = new System.Drawing.Point(463, 360);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(69, 29);
            this.lblMinutes.TabIndex = 15;
            this.lblMinutes.Text = "hours!";
            // 
            // frmClockInClockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Team3.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(560, 402);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblClockText);
            this.Controls.Add(this.tbxTimeOutput);
            this.Controls.Add(this.btnClockOut);
            this.Controls.Add(this.btnClockIn);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbxEmpID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcome);
            this.DoubleBuffered = true;
            this.Name = "frmClockInClockOut";
            this.Text = "Clock In / Clock Out";
            this.Load += new System.EventHandler(this.frmClockInClockOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEmpID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClockIn;
        private System.Windows.Forms.Button btnClockOut;
        private System.Windows.Forms.TextBox tbxTimeOutput;
        private System.Windows.Forms.Label lblClockText;
        private System.Windows.Forms.Label lblMinutes;
    }
}