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
        public static string message = "An error has occurred in the program.";
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
            cbxCategoryID.Items.Add("9000");
            cbxCategoryID.Items.Add("9001");
            cbxCategoryID.Items.Add("9001");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxName.Text == "")
                {
                    MessageBox.Show("Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxName.Focus();
                    return;
                }
                else if (tbxDescription.Text == "")
                {
                    MessageBox.Show("Description cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxDescription.Focus();
                    return;
                }
                else if (tbxPrice.Text == "")
                {
                    MessageBox.Show("Price cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxPrice.Focus();
                    return;
                }
                if (!Validation.ValidDecimal(tbxPrice.Text))
                {
                    MessageBox.Show("Retail Price must be in decimal form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxPrice.Clear();
                    tbxPrice.Focus();
                    return;
                }
                if(cbxCategoryID.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int intCategoryID = Convert.ToInt32(cbxCategoryID.SelectedItem);
                string strName = tbxName.Text;
                string strDesc = tbxDescription.Text;
                decimal decRetailPrice = Convert.ToDecimal(tbxPrice.Text);
                ProgOps.DatabaseCommandAddItem(intCategoryID, strName, strDesc, decRetailPrice);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void tbxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (int)e.KeyChar == 8)
            { //acceptable keystrokes
                e.Handled = false;
            }
            else if ((int)e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
