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
    public partial class frmUpdateMenuItem : Form
    {
        public frmUpdateMenuItem()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Server=cstnt.tstc.edu;Database= inew2330fa21;User Id=group3fa212330;password=3954755");

        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM group3fa212330.Menu";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder build = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgvMenu.DataSource = ds.Tables[0];
            con.Close();
        }
        private void frmUpdateMenuItem_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (tbxMenuID.Text == "" || tbxCategoryID.Text == "" || tbxName.Text == "" || tbxDescription.Text == "" || tbxPrice.Text == "")
            //{
            //    MessageBox.Show("Please Fill All of the Data");
            //}
            //else
            //{
            //    con.Open();
            //    string query = "update group3fa212330.Menu set CategoryID='" + tbxCategoryID.Text + "',Name='" + tbxName.Text + "',Description='" + tbxDescription.Text + "',Price=" + tbxPrice.Text + " where MenuID=" + tbxMenuID + "";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Item Updated");
            //    con.Close();
            //    populate();
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (tbxMenuID.Text == "")
            //{
            //    MessageBox.Show("Select Item to Delete");
            //}
            //else
            //{
            //    try
            //    {
            //        con.Open();
            //        string query = "DELETE FROM group3fa212330.Menu WHERE MenuID='" + tbxMenuID.Text + "';";
            //        SqlCommand cmd = new SqlCommand(query, con);
            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("Item Deleted Successfully");
            //        con.Close();
            //        populate();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
        }
    }
}
