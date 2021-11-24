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
    public partial class frmClockInClockOut : Form
    {
        DateTime clockInTime;
        DateTime clockOutTime;

        int intEmployeeID;

        public frmClockInClockOut(int EmployeeID)
        {
            InitializeComponent();

            intEmployeeID = EmployeeID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //to show in label the current time and date
        private void frmClockInClockOut_Load(object sender, EventArgs e)
        {
            //Showing current logged in Employee
            lblEmployeeID.Text = "EmployeeID: " + intEmployeeID.ToString();

            //start timer
            timer1.Start();
            //current time
            lblTime.Text = DateTime.Now.ToLongTimeString();
            //current date
            lblDate.Text = DateTime.Now.ToLongDateString();

            //hiding button clock out so user cannot clock out when they arent clocked in
            btnClockOut.Hide();
        }

        //running clock that displays time change my the second
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnClockIn_Click(object sender, EventArgs e)
        {

            //inserting a try catch statement just in case of error
            try
            {
                //current time is set to the clockInTime
                clockInTime = DateTime.Now;

                //showing the user the clock out button
                btnClockOut.Show();

                //maybe add an if statement and show message box that confirms clock in or clock out
                MessageBox.Show("You are now clocking in at: " + clockInTime.ToString(), "Clocking In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured trying to clock in. ", "Clocking In Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClockOut_Click(object sender, EventArgs e)
        {
            //hiding clock out button again
            btnClockOut.Hide();
            //current time is set to the clockOutTime
            clockOutTime = DateTime.Now;
            //by subtracting we get the working time in minutes
            System.TimeSpan diffResult = clockOutTime.Subtract(clockInTime);
            //pass the total hours as string to the textbox
            tbxTimeOutput.Text = Convert.ToString(diffResult.TotalHours);
        }
    }
}
