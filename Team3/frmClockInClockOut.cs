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
    public partial class frmClockInClockOut : Form
    {
        DateTime clockInTime;
        DateTime clockOutTime;
        SqlConnection dbConnection;

        int intEmployeeID;

        public frmClockInClockOut(int EmployeeID)
        {
            InitializeComponent();

            intEmployeeID = EmployeeID;
        }

        public frmClockInClockOut()
        {
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

            try
            {
                //will grab clockin data from db
                dbConnection = new SqlConnection("Server = cstnt.tstc.edu; Database = inew2330fa21; User Id = group3fa212330; password = 3954755");
                ProgOps.OpenDatabase(dbConnection);


                
                SqlCommand resultsCmd = null;
                String sqlStatement = "SELECT ClockInTime FROM group3fa212330.ClockInClockOut WHERE EmployeeID = '" + intEmployeeID + "';";
                resultsCmd = new SqlCommand(sqlStatement, dbConnection);

                DateTime ClockIn = (DateTime)resultsCmd.ExecuteScalar();

                sqlStatement = "SELECT ClockOutTime FROM group3fa212330.ClockInClockOut WHERE EmployeeID = '" + intEmployeeID + "';";
                resultsCmd = new SqlCommand(sqlStatement, dbConnection);

                DateTime ClockOut = (DateTime)resultsCmd.ExecuteScalar();

                DateTime ZeroTime = new DateTime(1800, 01, 01, 0, 0, 0);


                //this will check if employee is clocked in or clocked out 
                if (ClockOut == ZeroTime && ClockIn != ZeroTime)
                {
                    clockInTime = ClockIn;
                    btnClockOut.Show();
                    btnClockIn.Hide();
                }
                else if (ClockIn == ZeroTime)
                {
                    btnClockIn.Show();
                    btnClockOut.Hide();
                }
                else if(ClockIn != ZeroTime && ClockOut != ZeroTime)
                { 
                   btnClockIn.Show();
                   btnClockOut.Hide();
                }
                else if (ClockIn == ZeroTime && ClockOut == ZeroTime)
                { 
                   btnClockIn.Show();
                   btnClockOut.Hide();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR 402" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

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

                 string sqlStatement = "UPDATE group3fa212330.ClockInClockOut SET ClockInTime = '" + clockInTime.ToString("yyyy-MM-dd HH:mm:ss") + "', ClockOutTime = '1800-01-01 00:00:00'  WHERE EmployeeID = '" + intEmployeeID + "';";
                 ProgOps.UpdateDatabase(sqlStatement);

                //maybe add an if statement and show message box that confirms clock in or clock out
                MessageBox.Show("You are now clocking in at: " + clockInTime.ToString(), "Clocking In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClockIn.Hide();
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured trying to clock in. ", "Clocking In Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClockOut_Click(object sender, EventArgs e)
        {
            string Hours;
            //hiding clock out button again
            btnClockOut.Hide();
            //current time is set to the clockOutTime
            clockOutTime = DateTime.Now;
            //by subtracting we get the working time in minutes
            System.TimeSpan diffResult = clockOutTime.Subtract(clockInTime);
            //pass the total hours as string to the textbox
            Hours = Convert.ToString(diffResult.TotalHours);
            tbxTimeOutput.Text = Convert.ToString(diffResult.TotalHours);
            
            string sqlStatement = "UPDATE group3fa212330.ClockInClockOut SET ClockInTime = '1800-01-01 00:00:00', ClockOutTime = '" + clockOutTime.ToString("yyyy-MM-dd HH:mm:ss") + "', HoursTotal = '" +  Hours + "' WHERE EmployeeID = '" + intEmployeeID + "';";
            ProgOps.UpdateDatabase(sqlStatement);

            btnClockIn.Show();

            this.Refresh();

        }
    }
}
