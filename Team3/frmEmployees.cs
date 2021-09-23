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
        string EmployeeID;

        //will accept a variable that holds employees ID number
        public frmEmployees(string ID)
        {
            InitializeComponent();
            EmployeeID = ID;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //Modify button will be primarly use to edit personal info such as address and contact info.
            //will open a new form
            var frmModify = new frmModify();
            frmModify.Show();
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            //SQL statements will be used to load employees info

            /* FORM HAS NOT BEEN TESTED YET (9/21/21) AND IS UP FOR CHANGE */
            dbConnection = new SqlConnection("Server = cstnt.tstc.edu; Database = inew2330fa21; User Id = group3fa212330; password = 3954755");
            ProgOps.ConnectDatabase();

            SqlCommand resultsCmd = null;
            String sqlStatement = "SELECT FirstName FROM group3fa212330.Employees WHERE EmployeeID = " + EmployeeID;


        }
    }
}
