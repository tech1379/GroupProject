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
        public static string strMenuID;
        public static int intMenuID;
        public static int intMouseHover = 0;
        public static int intMouseHover2 = 0;
        public frmUpdateMenuItem()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Server=cstnt.tstc.edu;Database= inew2330fa21;User Id=group3fa212330;password=3954755");

        public void populate()
        {
            try
            {
                
                string query = "SELECT * FROM group3fa212330.Menu";
                ProgOps.DatabaseCommandDGV(query, dgvMenu);
                dgvMenu.ClearSelection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmUpdateMenuItem_Load(object sender, EventArgs e)
        {

            populate(); 
            dgvMenu.CurrentCell = null;
            dgvMenu.ClearSelection();

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
                populate();
                tbxName.Text = "";
                tbxDescription.Text = "";
                tbxPrice.Text = "";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMenu.RowCount == 0)
                {
                    MessageBox.Show("No Menu Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int intIndex = dgvMenu.CurrentRow.Index;
                string strMenuName = dgvMenu.Rows[intIndex].Cells[2].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete " + strMenuName + " ?", "Inventory Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {

                    string strMenuID = dgvMenu.Rows[intIndex].Cells[0].Value.ToString();
                    intMenuID = Convert.ToInt32(strMenuID);
                    string strDeleteOrderItems = "DELETE FROM group3fa212330.OrderItems WHERE MenuID = " + intMenuID + ";";
                    ProgOps.UpdateDatabase(strDeleteOrderItems);
                    string strDeleteMenu = "DELETE FROM group3fa212330.Menu WHERE MenuID = " + intMenuID + ";";
                    ProgOps.UpdateDatabase(strDeleteMenu);
                    MessageBox.Show("Menu item successfully deleted.", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populate();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            //if (intMouseHover == 0)
            //{
            //    MessageBox.Show("Please select a menu item to edit in the datagrid view.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    intMouseHover++;
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                if (cbxCategoryID.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int intCategoryID = Convert.ToInt32(cbxCategoryID.SelectedItem);
                string strName = tbxName.Text;
                string strDesc = tbxDescription.Text;
                decimal decRetailPrice = Convert.ToDecimal(tbxPrice.Text);
                ProgOps.DatabaseCommandEditItem(intCategoryID, strName, strDesc, decRetailPrice, intMenuID);
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            cbxCategoryID.SelectedIndex = -1;
            tbxName.Text = "";
            tbxDescription.Text = "";
            tbxPrice.Text = "";
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            if (intMouseHover2 == 0)
            {
                MessageBox.Show("Please select a menu item to edit in the datagrid view.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                intMouseHover2++;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMenu.RowCount == 0)
            {
                // MessageBox.Show("No Menu Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dgvMenu != null && dgvMenu.Rows.Count > 1 && dgvMenu.Columns.Count > 1)
            {
                try
                {
                    tbxName.Text = "";
                    tbxPrice.Text = "";
                    tbxDescription.Text = "";
                    if (dgvMenu.RowCount == 0)
                    {
                        MessageBox.Show("No Menu Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int intIndex = dgvMenu.CurrentRow.Index;
                    strMenuID = dgvMenu.Rows[intIndex].Cells[0].Value.ToString();
                    intMenuID = Convert.ToInt32(strMenuID);
                    ProgOps.DatabaseCommandMenu(tbxName, tbxDescription, tbxPrice, intMenuID);
                    //populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
