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
    public partial class frmResetPassword : Form
    {
        int intToggle = 0;
        int intToggle2 = 0;
        int intToggle3 = 0;
        public static string strLogin = frmMain.strLogin;
        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.ShowDialog();
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

        private void pbxEye2_Click(object sender, EventArgs e)
        {
            if (intToggle2 % 2 == 0)
            {
                tbxNewPassword.PasswordChar = '\0';
                intToggle2++;
            }
            else
            {
                tbxNewPassword.PasswordChar = '*';
                intToggle2++;
            }
        }

        private void pbxEye3_Click(object sender, EventArgs e)
        {
            if (intToggle3 % 2 == 0)
            {
                tbxConfirm.PasswordChar = '\0';
                intToggle3++;
            }
            else
            {
                tbxConfirm.PasswordChar = '*';
                intToggle3++;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxNewPassword.Text.Trim() != tbxConfirm.Text.Trim())
            {
                MessageBox.Show("Passwords do not match! Try again.", "Password Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string strOldPassword = tbxPassword.Text.Trim();
            string strNewPassword = tbxNewPassword.Text.Trim();
            Logon.ResetPassword(strLogin, strOldPassword, strNewPassword);
        }

        private void frmResetPassword_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"Background.jpg");
            this.BackgroundImage = myimage;
        }
    }
}
