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

            /* FORM HAS NOT BEEN TESTED YET (9/21/21) AND IS UP FOR CHANGE */
            dbConnection = new SqlConnection("Server = cstnt.tstc.edu; Database = inew2330fa21; User Id = group3fa212330; password = 3954755");
            ProgOps.OpenDatabase(dbConnection);

            SqlCommand resultsCmd = null;
            String sqlStatement = "SELECT FirstName FROM group3fa212330.Employees WHERE LogOnID = '" + strLogOnID + "';";

            resultsCmd = new SqlCommand(sqlStatement, dbConnection);

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

            resultsCmd.Dispose();

        }

        private void btnTimeClock_Click(object sender, EventArgs e)
        {
            frmClockInClockOut formTimeClock = new frmClockInClockOut();
            formTimeClock.ShowDialog();
        }
    }
}
