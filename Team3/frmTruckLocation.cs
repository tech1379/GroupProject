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
    public partial class frmTruckLocation : Form
    {
        public static string message = "An error has occurred in the program.";
        public frmTruckLocation()
        {
            InitializeComponent();
        }

        private void frmTruckLocation_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"Background.jpg");
            this.BackgroundImage = myimage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxLat.Text == "")
                {
                    MessageBox.Show("You must enter a lat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (tbxLong.Text == "")
                {
                    MessageBox.Show("You must enter a long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Validation.ValidDecimal(tbxLat.Text))
                {
                    MessageBox.Show("Lat must be in decimal format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Validation.ValidDecimal(tbxLong.Text))
                {
                    MessageBox.Show("Long must be in decimal format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string strUpdateTruckLocation = "UPDATE group3fa212330.TruckLocation SET Latitude = '" + tbxLat.Text + "', Longitude = '" + tbxLong.Text + "' WHERE TruckLocationID = 23000;";
                ProgOps.UpdateDatabase(strUpdateTruckLocation);
                MessageBox.Show("Truck Location Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
