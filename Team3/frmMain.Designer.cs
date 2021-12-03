
namespace Team3
{
    partial class frmMain
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
            this.lblTruckLocation = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblNew = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblForgot = new System.Windows.Forms.Label();
            this.pbxEye = new System.Windows.Forms.PictureBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.hlpMain = new System.Windows.Forms.HelpProvider();
            this.lblHelp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTruckLocation
            // 
            this.lblTruckLocation.AutoSize = true;
            this.lblTruckLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblTruckLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTruckLocation.ForeColor = System.Drawing.Color.White;
            this.lblTruckLocation.Location = new System.Drawing.Point(12, 9);
            this.lblTruckLocation.Name = "lblTruckLocation";
            this.lblTruckLocation.Size = new System.Drawing.Size(127, 20);
            this.lblTruckLocation.TabIndex = 0;
            this.lblTruckLocation.Text = "&Truck Location";
            this.lblTruckLocation.Click += new System.EventHandler(this.lblTruckLocation_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Goldenrod;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(70, 110);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(505, 42);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Aho To Denali Indian Tacos";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(170, 180);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 22);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "LogIn";
            // 
            // tbxLogin
            // 
            this.tbxLogin.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLogin.Location = new System.Drawing.Point(174, 203);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(270, 29);
            this.tbxLogin.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(174, 289);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(270, 33);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "&Sign In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.BackColor = System.Drawing.Color.Transparent;
            this.lblNew.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.ForeColor = System.Drawing.Color.White;
            this.lblNew.Location = new System.Drawing.Point(229, 334);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(117, 20);
            this.lblNew.TabIndex = 9;
            this.lblNew.Text = "New Customer?";
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUp.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSignUp.Location = new System.Drawing.Point(352, 334);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(64, 20);
            this.lblSignUp.TabIndex = 10;
            this.lblSignUp.Text = "&Sign Up";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(509, 319);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 41);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(174, 235);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(270, 29);
            this.tbxPassword.TabIndex = 6;
            // 
            // lblForgot
            // 
            this.lblForgot.AutoSize = true;
            this.lblForgot.BackColor = System.Drawing.Color.Transparent;
            this.lblForgot.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgot.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblForgot.Location = new System.Drawing.Point(325, 266);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(119, 20);
            this.lblForgot.TabIndex = 8;
            this.lblForgot.Text = "&Forgot Password";
            this.lblForgot.Click += new System.EventHandler(this.lblForgot_Click);
            // 
            // pbxEye
            // 
            this.pbxEye.BackColor = System.Drawing.Color.Gray;
            this.pbxEye.Image = global::Team3.Properties.Resources.eye;
            this.pbxEye.Location = new System.Drawing.Point(450, 235);
            this.pbxEye.Name = "pbxEye";
            this.pbxEye.Size = new System.Drawing.Size(41, 26);
            this.pbxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEye.TabIndex = 11;
            this.pbxEye.TabStop = false;
            this.pbxEye.Click += new System.EventHandler(this.pbxEye_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::Team3.Properties.Resources.denali_logo;
            this.pbxLogo.Location = new System.Drawing.Point(245, 9);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(128, 98);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(551, 18);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(46, 20);
            this.lblHelp.TabIndex = 13;
            this.lblHelp.Text = "&Help";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Team3.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(645, 372);
            this.ControlBox = false;
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbxEye);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.lblForgot);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblTruckLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Denali Indian Tacos";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTruckLocation;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbxEye;
        private System.Windows.Forms.Label lblForgot;
        public System.Windows.Forms.TextBox tbxLogin;
        public System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.HelpProvider hlpMain;
        private System.Windows.Forms.Label lblHelp;
    }
}