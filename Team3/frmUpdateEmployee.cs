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
    public partial class frmUpdateEmployee : Form
    {
        public frmUpdateEmployee()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Server=cstnt.tstc.edu;Database= inew2330fa21;User Id=group3fa212330;password=3954755");

        private void btnAdd_Click(object sender, EventArgs e)
        { 
            if (tbxFirstName.Text == "" || tbxLastName.Text == "" || cbxGender.Text == "" || tbxAddress.Text == "" ||
                tbxCity.Text == "" || cbxState.Text == "" || tbxZipCode.Text == "" || tbxPhoneNumber.Text == "" || tbxEmail.Text == "" || cbxRole.Text == "" ||
                mskDOB.Text == "" || tbxAge.Text == "" || mskStartDate.Text == "")
            {
                MessageBox.Show("You forgot something! Please go back and make sure you filled in everything.");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand resultsCmd = null;

                    string queryLogOn = "INSERT INTO group3fa212330.LogOn(LogOnName, Password) VALUES('" + tbxLogOnName.Text + "','" + tbxLogOnPassword.Text + "')";
                    ProgOps.UpdateDatabase(queryLogOn);
                    string queryLogOnID = "SELECT MAX(LogOnID) FROM group3fa212330.LogOn";
                    string LogonID = ProgOps.DatabaseCommandLogon(queryLogOnID);
                    MessageBox.Show(LogonID);
                    string query = "insert into group3fa212330.Employees values('" + tbxFirstName.Text + "','" + tbxLastName.Text + "','" + cbxGender.SelectedItem.ToString() + "','" + tbxAddress.Text + "','" + tbxCity.Text + "','" + cbxState.SelectedItem.ToString() + "','" + tbxZipCode.Text + "','" + tbxPhoneNumber.Text + "','" + tbxEmail.Text + "','" + cbxRole.SelectedItem.ToString() + "','" + mskDOB.Text + "'," + Convert.ToInt32(tbxAge.Text) + ",'" + mskStartDate.Text + "'," + Convert.ToInt32(LogonID) + ", 0)";
                    MessageBox.Show(query);
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Added");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM group3fa212330.Employees";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder build = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvEmpManager.DataSource = ds.Tables[0];
            con.Close();
        }

        private void frmUpdateEmployee_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(tbxEmployeeID.Text == "")
            {
                MessageBox.Show("Please enter EmployeeID");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM group3fa212330.Employees WHERE EmployeeID='" + tbxEmployeeID.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted Successfully");
                    con.Close();
                    populate();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //when cell content is clicked the info will fill text boxes information
        private void dgvEmpManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //tbxEmployeeID.Text = dgvEmpManager.SelectedRows[0].Cells[0].Value.ToString();
            //tbxFirstName.Text = dgvEmpManager.SelectedRows[0].Cells[1].Value.ToString();
            //tbxLastName.Text = dgvEmpManager.SelectedRows[0].Cells[2].Value.ToString();
            //cbxGender.Text = dgvEmpManager.SelectedRows[0].Cells[3].Value.ToString();
            //tbxAddress.Text = dgvEmpManager.SelectedRows[0].Cells[4].Value.ToString();
            //tbxCity.Text = dgvEmpManager.SelectedRows[0].Cells[5].Value.ToString();
            //cbxState.Text = dgvEmpManager.SelectedRows[0].Cells[6].Value.ToString();
            //tbxZipCode.Text = dgvEmpManager.SelectedRows[0].Cells[7].Value.ToString();
            //tbxPhoneNumber.Text = dgvEmpManager.SelectedRows[0].Cells[8].Value.ToString();
            //tbxEmail.Text = dgvEmpManager.SelectedRows[0].Cells[9].Value.ToString();
            //cbxRole.Text = dgvEmpManager.SelectedRows[0].Cells[10].Value.ToString();
            //tbxAge.Text = dgvEmpManager.SelectedRows[0].Cells[12].Value.ToString();
            //tbxLogOnName.Text = dgvEmpManager.SelectedRows[0].Cells[14].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
