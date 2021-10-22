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
        { //INSERT INTO [group3fa212330].[Employees] ([EmployeeID], [FirstName], [LastName], [Gender], [Address], [City], [State], [ZipCode], [PhoneNumber], [Email], [JobTitle], [DOB], [Age], [StartDate], [LogOnID], [isManager])
          //VALUES (1000, N'Eric', N'Tekell', N'M', N'317 Penny Lane ', N'Waco', N'TX', N'79567', N'320-534-9243 ', N'billyH@Hmail.com', N'Dishwasher', N'1980-11-20', 40, N'2021-02-20', 3000, 0)
            if (tbxFirstName.Text == "" || tbxLastName.Text == "" || tbxAddress.Text == "" ||
                tbxCity.Text == "" || tbxZipCode.Text == "" || tbxPhoneNumber.Text == "" || tbxEmail.Text == "" || tbxAge.Text == "")
            {
                MessageBox.Show("You forgot something! Please go back and make sure you filled in everything.");
            }
            else
            {
                try
                {
                    con.Open();
                    /////////////////////fix SQL statement
                    string query = "insert into group3fa212330.Employees values(" + tbxEmployeeID.Text + "','" + tbxFirstName.Text + "','" + tbxLastName.Text + "'," +
                        "'" + cbxGender.SelectedItem.ToString() + "','" + tbxAddress.Text + "','" + tbxCity.Text + "','" + cbxState.SelectedItem.ToString() + "'," +
                        "'" + tbxZipCode.Text + "','" + tbxPhoneNumber.Text + "','" + tbxEmail.Text + "','" + cbxRole.SelectedItem.ToString() + "'," +
                        "'" + dtpDOB.Value.Date + "','" + tbxAge.Text + "','" + dtpStartDate.Value.Date + "','" + tbxLogOnID.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Added");
                    con.Close();
                    populate();
                }catch (Exception ex)
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
        //when cell content is clicked all tbx should fill up with database information
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
            //tbxLogOnID.Text = dgvEmpManager.SelectedRows[0].Cells[14].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if(tbxEmployeeID.Text == "" || tbxFirstName.Text == "" || tbxLastName.Text == "" || 
        }
    }
}
