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
    public partial class frmNewAccount : Form
    {
        public frmNewAccount()
        {
            InitializeComponent();
        }

        private void frmNewAccount_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"taco.jpg");
            this.BackgroundImage = myimage;
        }
    }
}
