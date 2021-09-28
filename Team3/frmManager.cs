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

namespace Team3
{
    public partial class frmManager : Form
    {
        //var to hold default sql statement
        string sqlAll;
 

        public frmManager()
        {
            InitializeComponent();
        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            //connect database
            ProgOps.ConnectDatabase();

            //call database command
            

        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            frmNewEmployee formNewEmployee = new frmNewEmployee();
            formNewEmployee.ShowDialog();
        }


        //private void btnCustomers_Click(object sender, EventArgs e)
        //{
        //    sqlAll = "SELECT * FROM group3fa212330.Customers";
        //    ProgOps.DatabaseCommandManager(sqlAll, dgvResults);
        //}

        //private void btnEmployees_Click(object sender, EventArgs e)
        //{
        //    sqlAll = "SELECT * FROM group3fa212330.Employees";
        //    ProgOps.DatabaseCommandManager(sqlAll, dgvResults);
        //}

        private void btnEventRequests_Click(object sender, EventArgs e)
        {
            frmEventRequest formEventRequest = new frmEventRequest();
            formEventRequest.ShowDialog();
        }

        //private void btnEmergencyContacts_Click(object sender, EventArgs e)
        //{
        //    //frmEmergencyContact formEmergencyContact = new frmEmergencyContact();
        //    //formEmergencyContact.ShowDialog();
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit confirmation
            DialogResult response;
            response = MessageBox.Show("Are you sure you want to exit?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (response == DialogResult.No)
            {
                return;
            }
            //Exit the Program
            Application.Exit();
        }

        //private void btnOrders_Click(object sender, EventArgs e)
        //{
        //    sqlAll = "SELECT * FROM group3fa212330.Orders";
        //    ProgOps.DatabaseCommandManager(sqlAll, dgvResults);
        //}

        //private void btnPayDetails_Click(object sender, EventArgs e)
        //{
        //    sqlAll = "SELECT * FROM group3fa212330.PayDetails";
        //    ProgOps.DatabaseCommandManager(sqlAll, dgvResults);
        //}

        //private void btnPaySchedule_Click(object sender, EventArgs e)
        //{
        //    sqlAll = "SELECT * FROM group3fa212330.PaySchedule";
        //    ProgOps.DatabaseCommandManager(sqlAll, dgvResults);
        //}

        //private void btnSchedule_Click(object sender, EventArgs e)
        //{
        //    sqlAll = "SELECT * FROM group3fa212330.Schedule";
        //    ProgOps.DatabaseCommandManager(sqlAll, dgvResults);
        //}

        //private void frmManager_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    //close database when frmMain closes
        //    ProgOps.CloseDatabaseManager();
        //}

    }
}
