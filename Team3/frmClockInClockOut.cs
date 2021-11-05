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

        public frmClockInClockOut()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //timer1.Stop();
            this.Close();

        }

        //void Start()
        //{
        //    clockInTime = DateTime.Now;
        //}
        //void upDateTime()
        //{
        //    TimeSpan totalTime = DateTime.Now - clockInTime;
        //}

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

        //running clock that displays time change by the second
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnClockIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (timer1.Enabled)
                {
                    timer1.Start();
                    MessageBox.Show("You have clocked in. ");
                    //this.Hide();
                    clockInTime = DateTime.Now;
                }
                else
                {
                    timer1.Stop();
                }
            }
            catch (Exception ex) { }
            
            //current time is set to the clockInTime
            //clockInTime = DateTime.Now;
        }

        private void btnClockOut_Click(object sender, EventArgs e)
        {
            try
            {
                string strHours = "";
                double dblMinutes = 0;

                //current time is set to the clockOutTime
                clockOutTime = DateTime.Now;
                //by subtracting we get the working time in minutes
                System.TimeSpan diffResult = clockOutTime.Subtract(clockInTime);
                ////pass the total hours as string to the textbox
                //tbxTimeOutput.Text = Convert.ToString(diffResult.TotalHours);
                //tbxTimeOutput.Text = Convert.ToString(diffResult.
                strHours = diffResult.Hours.ToString();
                dblMinutes = diffResult.Minutes / 60;
                //strMinutes = diffResult.Minutes.ToString();
                tbxTimeOutput.Text = strHours + dblMinutes.ToString();
            }
            catch (Exception ex) { }

        }
    }
}
