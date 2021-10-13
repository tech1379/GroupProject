using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team3
{
    public partial class frmClockInClockOut : Form
    {
        DateTime clockInTime;
        DateTime clockOutTime;

        public frmClockInClockOut()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //to show in label the current time and date
        private void frmClockInClockOut_Load(object sender, EventArgs e)
        {
            //start timer
            timer1.Start();
            //current time
            lblTime.Text = DateTime.Now.ToLongTimeString();
            //current date
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        //running clock that displays time change my the second
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnClockIn_Click(object sender, EventArgs e)
        {
            //current time is set to the clockInTime
            clockInTime = DateTime.Now;

            //add if statement and show message box that confirms clock in or clock out
        }

        private void btnClockOut_Click(object sender, EventArgs e)
        {
            //current time is set to the clockOutTime
            clockOutTime = DateTime.Now;
            //by subtracting we get the working time in minutes
            System.TimeSpan diffResult = clockOutTime.Subtract(clockInTime);
            //pass the total hours as string to the textbox
            tbxTimeOutput.Text = Convert.ToString(diffResult.TotalHours);
        }
    }
}

//private void pbxClockIn_Click(object sender, EventArgs e)
//{
//    //Get current date and time
//    DateTime theDate;
//    theDate = DateTime.Now;
//    string strEmployee = tbxEmpID.Text;

//    //send date and time to sql server
//    SqlConnection objConnect = new SqlConnection();

//    string sqlClockIn = "INSERT INTO tblTimeClock (tcEmpID, tcClockIn) VALUES (@tcEmpID, @tcClockIn)";

//    objConnect.Open();
//    try
//    {
//        SqlCommand sqlClockIn = new SqlCommand(sqlClockIn, objConnect);
//        sqlClockIn.Parameters.Add("@tcEmpID", strEmployee);
//        sqlClockIn.Parameters.Add("@sqlClockIn", theDate);
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show(ex.Message);
//    }
//    finally
//    {
//        objConnect.Close();
//    }
//    //display message box
//    MessageBox.Show("Hi, " + strEmployee.ToString() + ".\n" + "You are clocking in at: " + theDate.ToString() +
//        ".", "Clock In", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
//}