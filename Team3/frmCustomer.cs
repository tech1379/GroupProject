using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Team3
{
    public partial class frmCustomer : Form
    {
        public static string message = "An error has occurred in the program.";
        public static List<Menu> lstEntrees = new List<Menu>();
        public static List<Menu> lstDrinks = new List<Menu>();
        public static List<Menu> lstDesserts = new List<Menu>();
        public static List<Image> lstImages = new List<Image>();
        public static List<Image> lstImagesDrinks = new List<Image>();
        public static List<Image> lstImagesDesserts = new List<Image>();
        public static string strFirstName = "";
        public static string strLastName = "";
        NumericUpDown[] numQuantity;
        NumericUpDown[] numQuantityDrinks;
        NumericUpDown[] numQuantityDesserts;
        public static List<int> lstQuantityEntrees = new List<int>();
        public static List<string> lstNameEntrees = new List<string>();
        public static List<decimal> lstPriceEntrees = new List<decimal>();
        public static List<int> lstQuantityDrinks = new List<int>();
        public static List<string> lstNameDrinks = new List<string>();
        public static List<decimal> lstPriceDrinks = new List<decimal>();
        public static bool boolAdded = false;




        public frmCustomer(string FirstName, string LastName)
        {
            InitializeComponent();
            strFirstName = FirstName;
            strLastName = LastName;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            try 
            { 
                //setup background
            Image myimage = new Bitmap(@"Background.jpg");
            this.BackgroundImage = myimage;
            tbMenuItems.BackgroundImage = myimage;
            tbDrinks.BackgroundImage = myimage;
            tbDesserts.BackgroundImage = myimage;
            tbOrder.BackgroundImage = myimage;
            lblCustomerName.Text = strFirstName + " " + strLastName;
           
            //load images to the tabs
                string strCommand = $"SELECT MenuID, CategoryID, Name, Description, Price, Image FROM group3fa212330.Menu WHERE CategoryID = 9000;"; // 
                lstEntrees = ProgOps.ReloadImageList(strCommand);
                lstImages = ListImages(lstEntrees);
                numQuantity = new NumericUpDown[lstEntrees.Count];
                LoadEntrees();
                string strCommand1 = $"SELECT MenuID, CategoryID, Name, Description, Price, Image FROM group3fa212330.Menu WHERE CategoryID = 9001;"; // 
                lstDrinks = ProgOps.ReloadImageList(strCommand1);
                lstImagesDrinks = ListImages(lstDrinks);
                numQuantityDrinks = new NumericUpDown[lstDrinks.Count];
                LoadDrinks();
                string strCommand2 = $"SELECT MenuID, CategoryID, Name, Description, Price, Image FROM group3fa212330.Menu WHERE CategoryID = 9002;"; // 
                lstDesserts = ProgOps.ReloadImageList(strCommand2);
                lstImagesDesserts = ListImages(lstDesserts);
                numQuantityDesserts = new NumericUpDown[lstDesserts.Count];
                LoadDesserts();

                //set dgv for Order
                dgvResults.Columns.Add("Menu Item", "Menu Item");
                dgvResults.Columns.Add("Quantity", "Quantity");
                dgvResults.Columns.Add("Line Item Total", "Line Item Total");

            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void myPicBox_click(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            for(int i= 0; i < lstEntrees.Count; i++)
            {
                if (picBox.Name == "pbx" + lstEntrees[i].name)
                {
                    MessageBox.Show("Description: " + lstEntrees[i].description + "\n\n" + "Price: " + lstEntrees[i].price.ToString("C2"));
                    return;
                }
            }
            
        }
        public void myPicBoxDrinks_click(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            for (int i = 0; i < lstDrinks.Count; i++)
            {
                if (picBox.Name == "pbx" + lstDrinks[i].name)
                {
                    MessageBox.Show("Description: " + lstDrinks[i].description + "\n\n" + "Price: " + lstDrinks[i].price.ToString("C2"));
                    return;
                }
            }

        }
        public void myPicBoxDesserts_click(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            for (int i = 0; i < lstDesserts.Count; i++)
            {
                if (picBox.Name == "pbx" + lstDesserts[i].name)
                {
                    MessageBox.Show("Description: " + lstDesserts[i].description + "\n\n" + "Price: " + lstDesserts[i].price.ToString("C2"));
                    return;
                }
            }

        }
        public List<Image> ListImages(List<Menu> lstMenu)
        {
            List<Image> lstImages = new List<Image>();
            try
            {
                for (int i = 0; i < lstMenu.Count; i++)
                {
                    using (MemoryStream ms = new MemoryStream(lstMenu[i].Image))
                    {
                        Image image = Image.FromStream(ms);
                        lstImages.Add(image);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lstImages;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                for (int i = 0; i < lstEntrees.Count; i++)
                {
                    if (numQuantity[i].Value > 0)
                    {
                        lstQuantityEntrees.Add(Convert.ToInt32(numQuantity[i].Value));
                        lstNameEntrees.Add(lstEntrees[i].name);
                        lstPriceEntrees.Add(lstEntrees[i].price);
                    }
                }
                for (int i = 0; i < lstDrinks.Count; i++)
                {
                    if (numQuantityDrinks[i].Value > 0)
                    {
                        lstQuantityDrinks.Add(Convert.ToInt32(numQuantityDrinks[i].Value));
                        lstNameDrinks.Add(lstDrinks[i].name);
                        lstPriceDrinks.Add(lstDrinks[i].price);
                    }
                }
                LoadDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadEntrees()
        {
            int perCol = 5;
            int disBetWeen = 15;
            int width = 150;
            int height = 150;
            int lblHeight = 180;
            int numHeight = -10;
            try
            {
                PictureBox[] myPicBox = new PictureBox[lstEntrees.Count];
                Label[] lblMenuName = new Label[lstEntrees.Count];
               


                for (int i = 0; i < lstEntrees.Count; i++)
                {
                    myPicBox[i] = (new PictureBox());
                    myPicBox[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    myPicBox[i].Location = new System.Drawing.Point(disBetWeen + (disBetWeen * (i % perCol) + (width * (i % perCol))),
                        100 + (100 * (i / perCol)) + (height * (i / perCol)));
                    myPicBox[i].Name = "pbx" + lstEntrees[i].name;
                    myPicBox[i].Size = new System.Drawing.Size(width, height);
                    myPicBox[i].Image = lstImages[i];
                    myPicBox[i].Click += new EventHandler(myPicBox_click);
                    lblMenuName[i] = new Label();
                    lblMenuName[i].Size = new Size(150, 50);
                    lblMenuName[i].Location = new System.Drawing.Point(disBetWeen + (disBetWeen * (i % perCol) + (width * (i % perCol))),
                        75 + (75 * (i / perCol)) + (lblHeight * (i / perCol)));
                    lblMenuName[i].Name = "lbl" + lstEntrees[i].name;
                    lblMenuName[i].Text = (i + 1).ToString() + ". " + lstEntrees[i].name;
                    lblMenuName[i].ForeColor = System.Drawing.Color.White;
                    numQuantity[i] = new NumericUpDown();
                    numQuantity[i].Size = new System.Drawing.Size(30, 30);
                    numQuantity[i].Location = new System.Drawing.Point(disBetWeen + (disBetWeen * (i % perCol) + (width * (i % perCol))),
                        260 + (260 * (i / perCol)) + (numHeight * (i / perCol)));
                    numQuantity[i].Name = "nbx" + lstEntrees[i].name;
                    numQuantity[i].Value = 0;
                    numQuantity[i].Maximum = 50;
                    numQuantity[i].Minimum = 0;
                    numQuantity[i].Increment = 1;
                    //numQuantity[i].BringToFront();
                    tbMenuItems.Controls.Add(myPicBox[i]);
                    tbMenuItems.Controls.Add(lblMenuName[i]);
                    tbMenuItems.Controls.Add(numQuantity[i]);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadDrinks()
        {
            int perCol = 5;
            int disBetWeen = 15;
            int width = 150;
            int height = 150;
            int lblHeight = 180;
            int numHeight = -10;

            try
            {
                PictureBox[] myPicBox = new PictureBox[lstDrinks.Count];
                Label[] lblMenuName = new Label[lstDrinks.Count];
                

                for (int i = 0; i < lstDrinks.Count; i++)
                {
                    myPicBox[i] = (new PictureBox());
                    myPicBox[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    myPicBox[i].Location = new System.Drawing.Point(disBetWeen + (disBetWeen * (i % perCol) + (width * (i % perCol))),
                        100 + (100 * (i / perCol)) + (height * (i / perCol)));
                    myPicBox[i].Name = "pbx" + lstDrinks[i].name;
                    myPicBox[i].Size = new System.Drawing.Size(width, height);
                    myPicBox[i].Image = lstImagesDrinks[i];
                    myPicBox[i].Click += new EventHandler(myPicBoxDrinks_click);
                    lblMenuName[i] = new Label();
                    lblMenuName[i].Size = new Size(150, 50);
                    lblMenuName[i].Location = new System.Drawing.Point(disBetWeen + (disBetWeen * (i % perCol) + (width * (i % perCol))),
                        75 + (75 * (i / perCol)) + (lblHeight * (i / perCol)));
                    lblMenuName[i].Name = "lbl" + lstDrinks[i].name;
                    lblMenuName[i].Text = (i + 1).ToString() + ". " + lstDrinks[i].name;
                    lblMenuName[i].ForeColor = System.Drawing.Color.White;
                    numQuantityDrinks[i] = new NumericUpDown();
                    numQuantityDrinks[i].Size = new System.Drawing.Size(30, 30);
                    numQuantityDrinks[i].Location = new System.Drawing.Point(disBetWeen + (disBetWeen * (i % perCol) + (width * (i % perCol))),
                        260 + (260 * (i / perCol)) + (numHeight * (i / perCol)));
                    numQuantityDrinks[i].Name = "nbx" + lstDrinks[i].name;
                    numQuantityDrinks[i].Value = 0;
                    numQuantityDrinks[i].Maximum = 50;
                    numQuantityDrinks[i].Minimum = 0;
                    numQuantityDrinks[i].Increment = 1;
                    //numQuantity[i].BringToFront();
                    tbDrinks.Controls.Add(myPicBox[i]);
                    tbDrinks.Controls.Add(lblMenuName[i]);
                    tbDrinks.Controls.Add(numQuantityDrinks[i]);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadDesserts()
        {
            int perCol = 5;
            int disBetWeen = 15;
            int width = 150;
            int height = 150;
            int lblHeight = 180;
            int numHeight = -10;
            try
            {
                PictureBox[] myPicBox = new PictureBox[lstDesserts.Count];
                Label[] lblMenuName = new Label[lstDesserts.Count];
               
                for (int i = 0; i < lstDesserts.Count; i++)
                {
                    myPicBox[i] = (new PictureBox());
                    myPicBox[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    myPicBox[i].Location = new System.Drawing.Point(disBetWeen + (disBetWeen * (i % perCol) + (width * (i % perCol))),
                        100 + (100 * (i / perCol)) + (height * (i / perCol)));
                    myPicBox[i].Name = "pbx" + lstDesserts[i].name;
                    myPicBox[i].Size = new System.Drawing.Size(width, height);
                    myPicBox[i].Image = lstImagesDesserts[i];
                    myPicBox[i].Click += new EventHandler(myPicBoxDesserts_click);
                    lblMenuName[i] = new Label();
                    lblMenuName[i].Size = new Size(150, 50);
                    lblMenuName[i].Location = new System.Drawing.Point(disBetWeen + (disBetWeen * (i % perCol) + (width * (i % perCol))),
                        65 + (65 * (i / perCol)) + (lblHeight * (i / perCol)));
                    lblMenuName[i].Name = "lbl" + lstDesserts[i].name;
                    lblMenuName[i].Text = (i + 1).ToString() + ". " + lstDesserts[i].name;
                    lblMenuName[i].ForeColor = System.Drawing.Color.White;
                    numQuantityDesserts[i] = new NumericUpDown();
                    numQuantityDesserts[i].Size = new System.Drawing.Size(30, 30);
                    numQuantityDesserts[i].Location = new System.Drawing.Point(disBetWeen + (disBetWeen * (i % perCol) + (width * (i % perCol))),
                        260 + (260 * (i / perCol)) + (numHeight * (i / perCol)));
                    numQuantityDesserts[i].Name = "nbx" + lstDesserts[i].name;
                    numQuantityDesserts[i].Value = 0;
                    numQuantityDesserts[i].Maximum = 50;
                    numQuantityDesserts[i].Minimum = 0;
                    numQuantityDesserts[i].Increment = 1;
                    //numQuantity[i].BringToFront();
                    tbDesserts.Controls.Add(myPicBox[i]);
                    tbDesserts.Controls.Add(lblMenuName[i]);
                    tbDesserts.Controls.Add(numQuantityDesserts[i]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadDGV()
        {
            try
            {
                int intK = 0;
                int intL = 0;
                //load DGV
               
                //fill the datagrid view with values from Shop form
                for (int i = 0; i < lstQuantityEntrees.Count(); i++)
                {
                    dgvResults.Rows.Add();
                    dgvResults[0, i].Value = lstNameEntrees[i];
                    dgvResults[1, i].Value = lstQuantityEntrees[i];
                    dgvResults[2, i].Value = ((lstQuantityEntrees[i] * lstPriceEntrees[i]).ToString("C2"));
                    intK++;
                }
                MessageBox.Show(intK.ToString());
                for (int i = 0; i < lstQuantityDrinks.Count(); i++)
                {
                    dgvResults.Rows.Add();
                    dgvResults.Rows[i + (intK)].Cells[0].Style.BackColor = Color.LightGray;
                    dgvResults.Rows[i + (intK)].Cells[1].Style.BackColor = Color.LightGray;
                    dgvResults.Rows[i + (intK)].Cells[2].Style.BackColor = Color.LightGray;
                    dgvResults[0, i + (intK)].Value = lstNameDrinks[i];
                    dgvResults[1, i + (intK)].Value = lstQuantityDrinks[i];
                    dgvResults[2, i + (intK)].Value = ((lstQuantityDrinks[i] * lstPriceDrinks[i]).ToString("C2"));
                    intL++;
                }
                dgvResults.RowsDefaultCellStyle.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
