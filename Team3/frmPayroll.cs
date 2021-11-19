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
    public partial class frmPayroll : Form
    {
        public frmPayroll()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //constants
                const decimal BASE_HOURS = 40m;
                const decimal OVERTIME_RATE = 1.5m;

                // Local variables 
                decimal hoursWorked;
                decimal hourlyPayRate;
                decimal basePay;
                decimal overtimeHours;
                decimal overtimePay;
                decimal grossPay;

                // Get the hours worked and hourly pay rate. 
                hoursWorked = decimal.Parse(tbxHoursWorked.Text);
                hourlyPayRate = decimal.Parse(tbxRateOfPay.Text);

                // Determine the gross pay. 
                if (hoursWorked > BASE_HOURS)
                {
                    // Calculate the base pay (without overtime). 
                    basePay = hourlyPayRate * BASE_HOURS;

                    // Calculate the number of overtime hours. 
                    overtimeHours = hoursWorked - BASE_HOURS;

                    // Calculate the overtime pay. 
                    overtimePay = overtimeHours * hourlyPayRate * OVERTIME_RATE;

                    // Calculate the gross pay. 
                    grossPay = basePay + overtimePay;
                }
                else
                {
                    // Calculate the gross pay. 
                    grossPay = hoursWorked * hourlyPayRate;
                }

                // Display the gross pay. 
                lblGross.Text = grossPay.ToString("c");
            }
            catch (Exception ex)
            {
                // Display an error message. 
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxEmployeeID.Text = "";
            tbxHoursWorked.Text = "";
            tbxRateOfPay.Text = "";

            //reset focus
            tbxHoursWorked.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
