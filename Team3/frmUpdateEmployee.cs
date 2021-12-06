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
            //tbxEmployeeID.Clear();
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
                mskDOB.Text == "" || tbxAge.Text == "" || mskStartDate.Text == "" || cbxType.SelectedIndex == -1)
            {
                MessageBox.Show("You forgot something! Please go back and make sure you filled in everything.");
            }
            else
            {
                try
                {
                    int isManager = 0;
                    if (cbxType.SelectedItem.ToString() == "Manager")
                    {
                        isManager = 1;
                    }
                    else
                    {
                        isManager = 0;
                    }
                    con.Open();
                    SqlCommand resultsCmd = null;

                    string queryLogOn = "INSERT INTO group3fa212330.LogOn VALUES('" + tbxLogOnName.Text + "','" + tbxLogOnPassword.Text + "', " + isManager + ", 0);";
                    ProgOps.UpdateDatabase(queryLogOn);
                    string queryLogOnID = "SELECT MAX(LogOnID) FROM group3fa212330.LogOn";
                    string LogonID = ProgOps.DatabaseCommandLogon(queryLogOnID);
                    //MessageBox.Show(LogonID);
                    string query = "insert into group3fa212330.Employees values('" + tbxFirstName.Text + "','" + tbxLastName.Text + "','" + cbxGender.SelectedItem.ToString() + "','" + tbxAddress.Text + "','" + tbxCity.Text + "','" + cbxState.SelectedItem.ToString() + "','" + tbxZipCode.Text + "','" + tbxPhoneNumber.Text + "','" + tbxEmail.Text + "','" + cbxRole.SelectedItem.ToString() + "','" + mskDOB.Text + "'," + Convert.ToInt32(tbxAge.Text) + ",'" + mskStartDate.Text + "'," + Convert.ToInt32(LogonID) + ", " + isManager + ")";
                    //MessageBox.Show(query);
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Employee Successfully Added");
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
            cbxType.Items.Add("Manager");
            cbxType.Items.Add("Employee");
            populate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpManager.CurrentCell == null)
            {
                MessageBox.Show("You must select a row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int intIndex = dgvEmpManager.CurrentRow.Index;
            string strEmpID = dgvEmpManager.Rows[intIndex].Cells[0].Value.ToString();


          
                    con.Open();
                    string query = "DELETE FROM group3fa212330.Employees WHERE EmployeeID=" + Convert.ToInt32(strEmpID) + ";";
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
        //when cell content is clicked the info will fill text boxes information
        private void dgvEmpManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpManager.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                //tbxEmployeeID.Text = dgvEmpManager.Rows[e.RowIndex].Cells["EmployeeID"].FormattedValue.ToString();
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
                //tbxLogOnName.Text = dgvEmpManager.Rows[e.RowIndex].Cells["LogOnID"].FormattedValue.ToString();
                tbxLogOnName.Visible = false;
                tbxLogOnPassword.Visible = false;
 
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbxFirstName.Text == "" || tbxLastName.Text == "" || cbxGender.Text == "" || tbxAddress.Text == "" ||
                tbxCity.Text == "" || cbxState.Text == "" || tbxZipCode.Text == "" || tbxPhoneNumber.Text == "" || tbxEmail.Text == "" || cbxRole.Text == "" ||
                mskDOB.Text == "" || tbxAge.Text == "" || mskStartDate.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int isManager = 0;
                    if (cbxType.SelectedItem.ToString() == "Manager")
                    {
                        isManager = 1;
                    }
                    else
                    {
                        isManager = 0;
                    }
                    int intIndex = dgvEmpManager.CurrentRow.Index;
                    string strEmpID = dgvEmpManager.Rows[intIndex].Cells[0].Value.ToString();
                    con.Open();
                    SqlCommand resultsCmd = null;

                    //string queryLogOn = "INSERT INTO group3fa212330.LogOn(LogOnName, Password) VALUES('" + tbxLogOnName.Text + "','" + tbxLogOnPassword.Text + "')";
                    //ProgOps.UpdateDatabase(queryLogOn);
                    //string queryLogOnID = "SELECT (LogOnID) FROM group3fa212330.LogOn WHERE LogOnName = '" + tbxLogOnName.Text + "' AND Password ='" + tbxLogOnPassword.Text + "';";
                    //string LogonID = ProgOps.DatabaseCommandLogon(queryLogOnID);
                    string LogonID = dgvEmpManager.Rows[intIndex].Cells[14].Value.ToString();
                   // MessageBox.Show(LogonID);
                    string query = "UPDATE group3fa212330.Employees SET FirstName='" + tbxFirstName.Text + "', LastName='" + tbxLastName.Text + "',Gender='" + cbxGender.SelectedItem.ToString() + "',Address='" + tbxAddress.Text + "',City='" + tbxCity.Text + "',State='" + cbxState.SelectedItem.ToString() + "',ZipCode='" + tbxZipCode.Text + "',PhoneNumber='" + tbxPhoneNumber.Text + "',Email='" + tbxEmail.Text + "',JobTitle='" + cbxRole.SelectedItem.ToString() + "',DOB='" + mskDOB.Text + "',Age=" + Convert.ToInt32(tbxAge.Text) + ",StartDate='" + mskStartDate.Text + "',LogonID=" + Convert.ToInt32(LogonID) + ", isManager= " + isManager + " WHERE EmployeeID = " + Convert.ToInt32(strEmpID) + ";";
                    MessageBox.Show(query);
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated Successfully");
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
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
