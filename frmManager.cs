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
        string sqlAll;


        public frmManager()
        {
            InitializeComponent();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            frmNewEmployee formNewEmployee = new frmNewEmployee();
            formNewEmployee.ShowDialog();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            frmPayroll formPayroll = new frmPayroll();
            formPayroll.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            sqlAll = "SELECT * FROM group3fa212330.Customers";
            ProgOps.DatabaseCommandManager(sqlAll, dgvTester);
        }
    }
}
