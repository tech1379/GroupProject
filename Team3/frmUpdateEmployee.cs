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
            if (tbxFirstName.Text == "" || tbxLastName.Text == "" || tbxAddress.Text == "" || tbxCity.Text == "" || tbxZipCode.Text == "" || tbxPhoneNumber.Text == "" || tbxEmail.Text == "")
            {
                MessageBox.Show("You forgot something! Missing Information.");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into group3fa212330.Employees values('"+tbxFirstName.Text+"','"+tbxLastName.Text+"','"+cbxGender.SelectedItem.ToString()+"','"+tbxAddress.Text+ "','"+tbxCity.Text+ "','"+cbxState.SelectedItem.ToString() + "','" +tbxZipCode.Text+"','"+tbxPhoneNumber.Text+ "','"+tbxEmail.Text+ "','"+cbxGender.SelectedItem.ToString()+"')";
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
            string query = "SELECT * FROM group3fa212330.Employess";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder build = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvEmpManager.DataSource = ds.Tables[0];
            con.Close();
        }

        private void frmUpdateEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
