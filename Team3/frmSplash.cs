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
    public partial class frmSplash : Form
    {
        public int timeLeft { get; set; }
        public frmSplash()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            ProgOps.ConnectDatabase();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timeLeft = 15;
            tmrTime.Start();
        }

        private void trmTime_Tick(object sender, EventArgs e)
        {
            try
            {
                if (timeLeft > 0)
                {
                    timeLeft -= 1;
                }
                else
                {
                    tmrTime.Stop();
                    this.Hide();
                    new frmMain().ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("I'm sorry an error has occurred in the program. \n\n" +
                    "Please inform the Program Developer that the following error occurred: \n\n\n" + ex.Message,
                    "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
