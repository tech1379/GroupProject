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
    public partial class frmNewAccount : Form
    {
        public static string message = "An error has occurred in the program.";
        int intToggle = 0;
        int intToggle2 = 0;
        public frmNewAccount()
        {
            InitializeComponent();
        }

        private void frmNewAccount_Load(object sender, EventArgs e)
        {
            //set background image
            Image myimage = new Bitmap(@"taco.jpg");
            this.BackgroundImage = myimage;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //take input and save new login and customer to db
            //verify email
            string strEmail = tbxEmail.Text.Trim();
            string strLogin = tbxLogin.Text.Trim();
            string strPassword = tbxPassword.Text.Trim();
            string strConfirmPassword = tbxConfirm.Text.Trim();
            string strFirstName = tbxFirstName.Text.Trim();
            string strLastName = tbxLastName.Text.Trim();
            string strAddress = tbxAddress.Text.Trim();
            string strCity = tbxCity.Text.Trim();
            string strState = tbxState.Text.Trim();
            string strZipCode = tbxZipCode.Text.Trim();
            string strPhone = tbxPhone.Text.Trim();
            try
            {
                if (!Validation.ValidEmail(strEmail))
                {
                    MessageBox.Show("Email not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (tbxEmail.Text == "")
                {
                    MessageBox.Show("Email cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tbxLogin.Text == "")
                {
                    MessageBox.Show("Login cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tbxPassword.Text == "")
                {
                    MessageBox.Show("Password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tbxConfirm.Text == "")
                {
                    MessageBox.Show("Confirm Password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tbxFirstName.Text == "")
                {
                    MessageBox.Show("First Name cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tbxLastName.Text == "")
                {
                    MessageBox.Show("Last Name cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (strPassword != strConfirmPassword)
                {
                    MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string strLoginQuery = "SELECT COUNT(LogOnName) FROM group3fa212330.LogOn WHERE LogOnName = '" + strLogin + "';";
                string strLoginCount = ProgOps.DatabaseCommandLogon(strLoginQuery);
                int intLoginCount = Convert.ToInt32(strLoginCount);
                if (intLoginCount > 0)
                {
                    MessageBox.Show("Login already used.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxLogin.Clear();
                    tbxLogin.Focus();
                    return;
                }
                string strInsertLogin = "INSERT INTO group3fa212330.LogOn VALUES ('" + strLogin + "', '" + strPassword +
                    "', 0, 1);";
                ProgOps.UpdateDatabase(strInsertLogin);
                string strQueryLogOnId = "SELECT MAX(LogOnID) FROM group3fa212330.LogOn;";
                string strLogonID = ProgOps.DatabaseCommandLogon(strQueryLogOnId);
                int intLogOnID = Convert.ToInt32(strLogonID);
                string strInsertCustomer = "INSERT INTO group3fa212330.Customers VALUES (" + intLogOnID + ",'" + strFirstName +
                    "', '" + strLastName + "', '" + strAddress + "', '" + strCity + "', '" + strState + "', '" + strZipCode +
                    "', '" + strEmail + "', '" + strPhone + "');";
                ProgOps.UpdateDatabase(strInsertCustomer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxToggle_Click(object sender, EventArgs e)
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

        private void pbxToggle2_Click(object sender, EventArgs e)
        {
            if (intToggle2 % 2 == 0)
            {
                tbxConfirm.PasswordChar = '\0';
                intToggle++;
            }
            else
            {
                tbxConfirm.PasswordChar = '*';
                intToggle2++;
            }
        }

        private void tbxZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (int)e.KeyChar == 8)
            { //acceptable keystrokes
                e.Handled = false;
            }
            else if ((int)e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (int)e.KeyChar == 8)
            { //acceptable keystrokes
                e.Handled = false;
            }
            else if ((int)e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.ShowDialog();
        }
    }
}
