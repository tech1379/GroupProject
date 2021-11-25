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

        //clear form
        public void Clear()
        {
            tbxEmployeeID.Clear();
            tbxFirstName.Clear();
            tbxLastName.Clear();
            cbxGender.Text = string.Empty;
            tbxAddress.Clear();
            tbxCity.Clear();
            cbxState.Text = string.Empty;
            tbxZipCode.Clear();
            tbxPhoneNumber.Clear();
            tbxEmail.Clear();
            cbxRole.Text = string.Empty;
            mskDOB.Clear();
            mskStartDate.Clear();
            tbxAge.Clear();
            tbxLogOnName.Clear();
            tbxLogOnPassword.Clear();
        }

        //add person
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
                    Clear(); //clear form
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
            if (dgvEmpManager.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                tbxEmployeeID.Text = dgvEmpManager.Rows[e.RowIndex].Cells["EmployeeID"].FormattedValue.ToString();
                tbxFirstName.Text = dgvEmpManager.Rows[e.RowIndex].Cells["FirstName"].FormattedValue.ToString();
                tbxLastName.Text = dgvEmpManager.Rows[e.RowIndex].Cells["LastName"].FormattedValue.ToString();
                cbxGender.Text = dgvEmpManager.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString();
                tbxAddress.Text = dgvEmpManager.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                tbxCity.Text = dgvEmpManager.Rows[e.RowIndex].Cells["City"].FormattedValue.ToString();
                cbxState.Text = dgvEmpManager.Rows[e.RowIndex].Cells["State"].FormattedValue.ToString();
                tbxZipCode.Text = dgvEmpManager.Rows[e.RowIndex].Cells["ZipCode"].FormattedValue.ToString();
                tbxPhoneNumber.Text = dgvEmpManager.Rows[e.RowIndex].Cells["PhoneNumber"].FormattedValue.ToString();
                tbxEmail.Text = dgvEmpManager.Rows[e.RowIndex].Cells["PhoneNumber"].FormattedValue.ToString();
                cbxRole.Text = dgvEmpManager.Rows[e.RowIndex].Cells["JobTitle"].FormattedValue.ToString();
                mskDOB.Text = dgvEmpManager.Rows[e.RowIndex].Cells["DOB"].FormattedValue.ToString();
                mskStartDate.Text = dgvEmpManager.Rows[e.RowIndex].Cells["StartDate"].FormattedValue.ToString();
                tbxAge.Text = dgvEmpManager.Rows[e.RowIndex].Cells["Age"].FormattedValue.ToString();
                tbxLogOnName.Text = dgvEmpManager.Rows[e.RowIndex].Cells["LogOnID"].FormattedValue.ToString();
 
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var row = dgvEmpManager.CurrentCell.RowIndex;
            //    var id = Convert.ToString(dgvEmpManager.Rows[row].Cells[0].Value);
            //    var name = Convert.ToString(dgvEmpManager.Rows[row].Cells[1].Value);
            //    var address = Convert.ToString(dgvEmpManager.Rows[row].Cells[2].Value);
            //    var contact = Convert.ToString(dgvEmpManager.Rows[row].Cells[3].Value);
            //    var email = Convert.ToString(dgvEmpManager.Rows[row].Cells[4].Value);
            //    var desigination = Convert.ToString(dgvEmpManager.Rows[row].Cells[5].Value);
            //    var department = Convert.ToString(dgvEmpManager.Rows[row].Cells[6].Value);
            //    var dateOfJoin = Convert.ToString(dgvEmpManager.Rows[row].Cells[7].Value);
            //    var wageRate = Convert.ToString(dgvEmpManager.Rows[row].Cells[8].Value);
            //    var hourWorked = Convert.ToString(dgvEmpManager.Rows[row].Cells[9].Value);

            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
