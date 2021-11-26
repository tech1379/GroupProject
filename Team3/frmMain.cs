using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team3
{
    public partial class frmMain : Form
    {
       
        public static string message = "An error has occurred in the program.";
        int intToggle = 0;
        public static string strLogin;
        public frmMain()
        {
            InitializeComponent();
           
        }

        internal void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                //just to see if it works on github
                Image myimage = new Bitmap(@"Background.jpg");
                this.BackgroundImage = myimage;
                tbxLogin.Clear();
                tbxPassword.Clear();
                tbxLogin.Focus();
                hlpMain.HelpNamespace = Application.StartupPath + "\\LoginHelp.chm";
            }
            catch(Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            frmNewAccount account = new frmNewAccount();
            this.Hide();
            account.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string strUserName = tbxLogin.Text.Trim();
                string strPassword = tbxPassword.Text.Trim();
                if (strUserName == "")
                {
                    MessageBox.Show("LogIn cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (strPassword == "")
                {
                    MessageBox.Show("Password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Logon.Verify(strUserName, strPassword);
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxEye_Click(object sender, EventArgs e)
        {
            if (intToggle % 2 == 0)
            {
                tbxPassword.PasswordChar = '\0';
                intToggle++;
            }
            else
            {
                tbxPassword.PasswordChar = '*';
                intToggle++;
            }
        }

        private void lblForgot_Click(object sender, EventArgs e)
        {
            strLogin = tbxLogin.Text.Trim();
            try
            {
                if (tbxLogin.Text == "")
                {
                    MessageBox.Show("Login cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Logon.VerifyLogon(strLogin);
                MessageBox.Show("An email was sent to your email with a new password. Check your spam folder.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmResetPassword resetPassword = new frmResetPassword();
                resetPassword.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTruckLocation_Click(object sender, EventArgs e)
        {
            try
            {
                string strSqlLatQuery = "SELECT Latitude FROM group3fa212330.TruckLocation WHERE TruckLocationID = 23000;";
                string strSqlLongQuery = "SELECT Longitude FROM group3fa212330.TruckLocation WHERE TruckLocationID = 23000;";
                string latitude = ProgOps.DatabaseCommandLogon(strSqlLatQuery);
                string longitude = ProgOps.DatabaseCommandLogon(strSqlLongQuery);
                StringBuilder query = new StringBuilder();
                query.Append("https://www.google.com/maps/search/?api=1&query=");
                query.Append(latitude + ",");
                query.Append(longitude);
                System.Diagnostics.Process.Start(query.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpMain.HelpNamespace);
        }
    }
}
