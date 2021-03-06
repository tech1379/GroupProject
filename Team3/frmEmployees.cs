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
    public partial class frmEmployees : Form
    {
        public static string message = "An error has occurred in the program.";

        SqlConnection dbConnection;

        //TEST
        int EmployeeID;
        string strLogOnID;
       

        //will accept a variable that holds LogOnID number
        public frmEmployees(string LogOnID )
        {
            InitializeComponent();
             strLogOnID = LogOnID;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //once logged out it will take you to main screen
            var frmMain = new frmMain();
            frmMain.Show();

            this.Close();
            ProgOps.CloseDatabase(dbConnection);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //Modify button will be primarly use to edit personal info such as address and contact info.
            //will open a new form
            var frmModify = new frmModify(EmployeeID, dbConnection);
            frmModify.Show();
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            //SQL statements will be used to load employees info

            try
            {
                //help file
                hlpEmployees.HelpNamespace = Application.StartupPath + "\\EmployeeInterfaceHelp.chm";

                dbConnection = new SqlConnection("Server = cstnt.tstc.edu; Database = inew2330fa21; User Id = group3fa212330; password = 3954755");
                ProgOps.OpenDatabase(dbConnection);

                SqlCommand resultsCmd = null;
                String sqlStatement = "SELECT FirstName FROM group3fa212330.Employees WHERE LogOnID = '" + strLogOnID + "';";

                resultsCmd = new SqlCommand(sqlStatement, dbConnection);

                if (resultsCmd.ExecuteScalar() == null)
                {
                    throw (new Exception());
                    
                }

                string name = (string)resultsCmd.ExecuteScalar();



                lblWelcome.Text = "Welcome " + name + "!";

                sqlStatement = "SELECT JobTitle FROM group3fa212330.Employees WHERE LogOnID = '" + strLogOnID + "';";

                //new command
                resultsCmd = new SqlCommand(sqlStatement, dbConnection);
                string strPosition = (string)resultsCmd.ExecuteScalar();

                lblPosition.Text = "Position: " + strPosition;

                sqlStatement = "SELECT Email FROM group3fa212330.Employees WHERE LogOnID = '" + strLogOnID + "';";

                //new command
                resultsCmd = new SqlCommand(sqlStatement, dbConnection);
                string strEmail = (string)resultsCmd.ExecuteScalar();

                lblEmail.Text = "Email: " + strEmail;

                sqlStatement = "SELECT Address FROM group3fa212330.Employees WHERE LogOnID = '" + strLogOnID + "';";

                //new command
                resultsCmd = new SqlCommand(sqlStatement, dbConnection);
                string strAddress = (string)resultsCmd.ExecuteScalar();

                lblAddress.Text = "Address: " + strAddress;

                //new command
                sqlStatement = "SELECT EmployeeID FROM group3fa212330.Employees WHERE LogOnID = '" + strLogOnID + "';";

                resultsCmd = new SqlCommand(sqlStatement, dbConnection);


                EmployeeID = (int)resultsCmd.ExecuteScalar();

                lblEmployeeID.Text = "EmployeeID: " + EmployeeID;

                sqlStatement = "SELECT PhoneNumber FROM group3fa212330.Employees WHERE LogOnID = '" + strLogOnID + "';";

                resultsCmd = new SqlCommand(sqlStatement, dbConnection);

                string strPhone = (string)resultsCmd.ExecuteScalar();

                lblContact.Text = "Contact Number: " + strPhone;


                //statement to get work date
                sqlStatement = "SELECT Monday FROM group3fa212330.WorkSchedule WHERE EmployeeID = '" + EmployeeID + "';";
                resultsCmd = new SqlCommand(sqlStatement, dbConnection);

                //CODE FOR CALENDAR

                DateTime Monday;

                //if db returns a null if statement will handle it
                if (resultsCmd.ExecuteScalar() == null)
                {
                    //assigning minimum datetime if value is null
                    Monday = DateTime.MinValue;
                }
                else
                {
                    Monday = (DateTime)resultsCmd.ExecuteScalar();
                }

                sqlStatement = "SELECT Tuesday FROM group3fa212330.WorkSchedule WHERE EmployeeID = '" + EmployeeID + "';";
                resultsCmd = new SqlCommand(sqlStatement, dbConnection);

                DateTime Tuesday;

                if (resultsCmd.ExecuteScalar() == null)
                {

                    Tuesday = DateTime.MinValue;
                }
                else
                {
                    Tuesday = (DateTime)resultsCmd.ExecuteScalar();
                }

                sqlStatement = "SELECT Wednesday FROM group3fa212330.WorkSchedule WHERE EmployeeID = '" + EmployeeID + "';";
                resultsCmd = new SqlCommand(sqlStatement, dbConnection);
                DateTime Wednesday;

                if (resultsCmd.ExecuteScalar() == null)
                {

                    Wednesday = DateTime.MinValue;
                }
                else
                {
                    Wednesday = (DateTime)resultsCmd.ExecuteScalar();
                }
                sqlStatement = "SELECT Thursday FROM group3fa212330.WorkSchedule WHERE EmployeeID = '" + EmployeeID + "';";
                resultsCmd = new SqlCommand(sqlStatement, dbConnection);

                DateTime Thursday;
                if (resultsCmd.ExecuteScalar() == null)
                {

                    Thursday = DateTime.MinValue;
                }
                else
                {
                    Thursday = (DateTime)resultsCmd.ExecuteScalar();
                }

                sqlStatement = "SELECT Friday FROM group3fa212330.WorkSchedule WHERE EmployeeID = '" + EmployeeID + "';";
                resultsCmd = new SqlCommand(sqlStatement, dbConnection);

                DateTime Friday;

                if (resultsCmd.ExecuteScalar() == null)
                {

                    Friday = DateTime.MinValue;
                }
                else
                {
                    Friday = (DateTime)resultsCmd.ExecuteScalar();
                }


                sqlStatement = "SELECT Saturday FROM group3fa212330.WorkSchedule WHERE EmployeeID = '" + EmployeeID + "';";
                resultsCmd = new SqlCommand(sqlStatement, dbConnection);

                DateTime Saturday;

                if (resultsCmd.ExecuteScalar() == null)
                {

                    Saturday = DateTime.MinValue;
                }
                else
                {
                    Saturday = (DateTime)resultsCmd.ExecuteScalar();
                }


                sqlStatement = "SELECT Sunday FROM group3fa212330.WorkSchedule WHERE EmployeeID = '" + EmployeeID + "';";
                resultsCmd = new SqlCommand(sqlStatement, dbConnection);

                DateTime Sunday;

                if (resultsCmd.ExecuteScalar() == null)
                {

                    Sunday = DateTime.MinValue;
                }
                else
                {
                    Sunday = (DateTime)resultsCmd.ExecuteScalar();
                }


                DateTime[] DateArray = { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };


                //will now bold dates
                calSchedule.BoldedDates = DateArray;





                resultsCmd.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void calSchedule_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnTimeClock_Click(object sender, EventArgs e)
        {
            //passing the employee ID
            var frmClock = new frmClockInClockOut(EmployeeID);
           frmClock.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpEmployees.HelpNamespace);
        }
    }
}
