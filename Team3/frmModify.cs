using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Team3
{
    public partial class frmModify : Form
    {
        int intEmployeeID;
        SqlConnection dbConnection;
        public frmModify(int employeeID, SqlConnection connection)
        {
            InitializeComponent();
            intEmployeeID = employeeID;
            dbConnection = connection;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            tbxAddress.Clear();
            mskPhone.Clear();
            tbxEmail.Clear();
            tbxCity.Clear();
            this.Close();
        }

        private void frmModify_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Messagebox to prompt user if they want to save
            if (MessageBox.Show("Are you sure you would like to save? Once saved it cannot be undone.", "Update Information",
       MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    string strPhone, strAddress, strCity, strEmail;

                    //HAS BEEN TESTED 

                    strPhone = mskPhone.Text;
                    strAddress = tbxAddress.Text;
                    strEmail = tbxEmail.Text;
                    strCity = tbxCity.Text;

                    if (strPhone == "" || strAddress == "" || strEmail == "" || strCity == "")
                    {
                        //will throw exception if textboxes are left empty
                        throw(new Exception(""));
                    }
                    else
                    {
                       bool PhoneValid = validatePhoneNumber(strPhone);
                        if (PhoneValid == false)
                        {
                            throw (new Exception(""));
                        }

                        string sqlStatement = "UPDATE group3fa212330.Employees SET PhoneNumber = '" + strPhone + "', Address = '" + strAddress + "', City = '" + strCity + "', Email = '" + strEmail + "' WHERE EmployeeID = '" + intEmployeeID + "';";
                        ProgOps.UpdateDatabase(sqlStatement);
                        MessageBox.Show("Info Updated successfully.", "Update Completed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbxAddress.Clear();
                        mskPhone.Clear();
                        tbxEmail.Clear();
                        tbxCity.Clear();

                    }


                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error in saving into the database. Be sure to fill in all textboxes with the correct information.", "Update Info Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
        }

        private void tbxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        public static bool validatePhoneNumber(string Phone)
        {


            try
            {

                char[] phoneArray;
                phoneArray = Phone.ToCharArray();
                foreach (char Number in phoneArray)
                {
                    if (Number == ' ')
                    {
                        throw (new Exception());
                    }

                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Phone number has a empty space be sure to properly fill the blanks.", "Phone Textbox Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
