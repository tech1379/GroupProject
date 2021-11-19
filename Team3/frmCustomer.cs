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
using WMPLib;

namespace Team3
{
    public partial class frmCustomer : Form
    {
        public static frmMain frmMainForm;
        public static string message = "An error has occurred in the program.";
        public static List<Menu> lstEntrees = new List<Menu>();
        public static List<Menu> lstDrinks = new List<Menu>();
        public static List<Menu> lstDesserts = new List<Menu>();
        public static List<Image> lstImages = new List<Image>();
        public static List<Image> lstImagesDrinks = new List<Image>();
        public static List<Image> lstImagesDesserts = new List<Image>();
        public static string strFirstName = "";
        public static string strLastName = "";
        public static string strCustomerID = "";
        NumericUpDown[] numQuantity;
        NumericUpDown[] numQuantityDrinks;
        NumericUpDown[] numQuantityDesserts;
        public static List<int> lstQuantityEntrees = new List<int>();
        public static List<int> lstMenuIDEntrees = new List<int>();
        public static List<string> lstNameEntrees = new List<string>();
        public static List<decimal> lstPriceEntrees = new List<decimal>();
        public static List<int> lstQuantityDrinks = new List<int>();
        public static List<int> lstMenuIDDrinks = new List<int>();
        public static List<string> lstNameDrinks = new List<string>();
        public static List<decimal> lstPriceDrinks = new List<decimal>();
        public static List<int> lstQuantityDesserts = new List<int>();
        public static List<int> lstMenuIDDesserts = new List<int>();
        public static List<string> lstNameDesserts = new List<string>();
        public static List<decimal> lstPriceDesserts = new List<decimal>();
        public static bool boolAdded = false;
        public static bool boolEntreesAdded = false;
        public static decimal decSubTotal = 0;
        public static decimal decTaxes = 0;
        public static decimal decTotal = 0;
        public static string strMaxOrderID;
        public static string strPhoneNumber;
        public static int intMusicCount = 0;
        public static bool boolOrderMade = false;
        public static bool boolPlayMusic = false;
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();




        public frmCustomer(string FirstName, string LastName, string CustomerID)
        {
            InitializeComponent();
            strFirstName = FirstName;
            strLastName = LastName;
            strCustomerID = CustomerID;
            
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
                dgvResults.Columns.Add("Category", "Category");
                dgvResults.Columns.Add("Menu Item", "Menu Item");
                dgvResults.Columns.Add("Quantity", "Quantity");
                dgvResults.Columns.Add("Line Item Total", "Line Item Total");

                try
                {

                   
                    wplayer.PlayStateChange +=
               new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
                    wplayer.MediaError +=
                        new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
                    wplayer.URL = "runningdownadream.mp3";
                    //wplayer.settings.setMode("loop", true);
                    wplayer.controls.play();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Windows Media Player Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


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
                        lstMenuIDEntrees.Add(lstEntrees[i].menuID);
                        numQuantity[i].Value = 0;
                    }
                }
                for (int i = 0; i < lstDrinks.Count; i++)
                {
                    if (numQuantityDrinks[i].Value > 0)
                    {
                        lstQuantityDrinks.Add(Convert.ToInt32(numQuantityDrinks[i].Value));
                        lstNameDrinks.Add(lstDrinks[i].name);
                        lstPriceDrinks.Add(lstDrinks[i].price);
                        lstMenuIDDrinks.Add(lstDrinks[i].menuID);
                        numQuantityDrinks[i].Value = 0;
                    }
                }
                for (int i = 0; i < lstDesserts.Count; i++)
                {
                    if (numQuantityDesserts[i].Value > 0)
                    {
                        lstQuantityDesserts.Add(Convert.ToInt32(numQuantityDesserts[i].Value));
                        lstNameDesserts.Add(lstDesserts[i].name);
                        lstPriceDesserts.Add(lstDesserts[i].price);
                        lstMenuIDDesserts.Add(lstDesserts[i].menuID);
                        numQuantityDesserts[i].Value = 0;
                    }
                }
                boolEntreesAdded = true;
                LoadDGV();
                decSubTotal = 0;
                LoadLabels();
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
                        55 + (55 * (i / perCol)) + (lblHeight * (i / perCol)));
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
                //clear dgv and remake it so it looks nice each time
                if (dgvResults.RowCount != 0)
                {
                    dgvResults.Rows.Clear();
                }
                dgvResults.Rows.Add("Entrees");
                //load DGV
                dgvResults.RowsDefaultCellStyle.BackColor = Color.White;
                //fill the datagrid view with values from Shop form
                 for (int i = 0; i < lstQuantityEntrees.Count(); i++)
                    {
                        dgvResults.Rows.Add();
                        dgvResults[1, i+1].Value = lstNameEntrees[i];
                        dgvResults[2, i+1].Value = lstQuantityEntrees[i];
                        dgvResults[3, i+1].Value = ((lstQuantityEntrees[i] * lstPriceEntrees[i]).ToString("C2"));
                        intK++;
                    }
                intL = (intK);
                dgvResults.Rows.Add("Drinks");
                for (int i = 0; i < lstQuantityDrinks.Count(); i++)
                    {
                        dgvResults.Rows.Add();
                        dgvResults.Rows[i + (intK+2)].Cells[0].Style.BackColor = Color.LightGray;
                        dgvResults.Rows[i + (intK+2)].Cells[1].Style.BackColor = Color.LightGray;
                        dgvResults.Rows[i + (intK+2)].Cells[2].Style.BackColor = Color.LightGray;
                        dgvResults[1, i + (intK+2)].Value = lstNameDrinks[i];
                        dgvResults[2, i + (intK+2)].Value = lstQuantityDrinks[i];
                        dgvResults[3, i + (intK+2)].Value = ((lstQuantityDrinks[i] * lstPriceDrinks[i]).ToString("C2"));
                        intL++;
                    }
                dgvResults.Rows.Add("Desserts");
                for (int i = 0; i < lstQuantityDesserts.Count(); i++)
                    {
                        dgvResults.Rows.Add();
                        dgvResults.Rows[i + (intL+3)].Cells[0].Style.BackColor = Color.LightPink;
                        dgvResults.Rows[i + (intL+3)].Cells[1].Style.BackColor = Color.LightPink;
                        dgvResults.Rows[i + (intL+3)].Cells[2].Style.BackColor = Color.LightPink;
                        dgvResults[1, i + (intL+3)].Value = lstNameDesserts[i];
                        dgvResults[2, i + (intL+3)].Value = lstQuantityDesserts[i];
                        dgvResults[3, i + (intL+3)].Value = ((lstQuantityDesserts[i] * lstPriceDesserts[i]).ToString("C2"));
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadLabels()
        {
            try
            {
                if (lstQuantityEntrees.Count > 0)
                {
                    for (int i = 0; i < lstQuantityEntrees.Count(); i++)
                    {
                        decSubTotal += lstQuantityEntrees[i] * lstPriceEntrees[i];
                    }
                }
                if (lstQuantityDrinks.Count > 0)
                {
                    for (int i = 0; i < lstQuantityDrinks.Count(); i++)
                    {
                        decSubTotal += lstQuantityDrinks[i] * lstPriceDrinks[i];
                    }
                }
                if (lstQuantityDesserts.Count > 0)
                {
                    for (int i = 0; i < lstQuantityDesserts.Count(); i++)
                    {
                        decSubTotal += lstQuantityDesserts[i] * lstPriceDesserts[i];
                    }
                }
                lblSubTotal.Text = decSubTotal.ToString("C2");
                decTaxes = decSubTotal * .0825M;
                lblTaxes.Text = decTaxes.ToString("C2");
                decTotal = decSubTotal + decTaxes;
                lblTotal.Text = decTotal.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvResults.RowCount == 0)
                {
                    MessageBox.Show("Nothing to Remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lstNameEntrees.Clear();
                lstNameDrinks.Clear();
                lstNameDesserts.Clear();
                lstPriceDrinks.Clear();
                lstPriceDesserts.Clear();
                lstPriceEntrees.Clear();
                lstQuantityDesserts.Clear();
                lstQuantityDrinks.Clear();
                lstQuantityEntrees.Clear();
                lstMenuIDDesserts.Clear();
                lstMenuIDDrinks.Clear();
                lstMenuIDEntrees.Clear();

                //clear the datagrid view
                dgvResults.Rows.Clear();

                //clear labels
                decSubTotal = 0;
                lblSubTotal.Text = "";
                lblTaxes.Text = "";
                lblTotal.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvResults.RowCount == 0)
                {
                    MessageBox.Show("Nothing to Remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int index = dgvResults.CurrentRow.Index;
                for (int i = 0; i < lstNameEntrees.Count(); i++)
                {
                    if (dgvResults[1, index].Value != null)
                    {
                        if (dgvResults[1, index].Value.ToString() == lstNameEntrees[i])
                        {
                            lstNameEntrees.Remove(lstNameEntrees[i]);
                            lstPriceEntrees.Remove(lstPriceEntrees[i]);
                            lstQuantityEntrees.Remove(lstQuantityEntrees[i]);
                            lstMenuIDEntrees.Remove(lstMenuIDEntrees[i]);
                        }
                    }
                }
                for (int i = 0; i < lstNameDrinks.Count(); i++)
                {
                    if (dgvResults[1, index].Value != null)
                    {
                        if (dgvResults[1, index].Value.ToString() == lstNameDrinks[i])
                        {
                            lstNameDrinks.Remove(lstNameDrinks[i]);
                            lstPriceDrinks.Remove(lstPriceDrinks[i]);
                            lstQuantityDrinks.Remove(lstQuantityDrinks[i]);
                            lstMenuIDDrinks.Remove(lstMenuIDDrinks[i]);
                        }
                    }
                }
                for (int i = 0; i < lstNameDesserts.Count(); i++)
                {
                    if (dgvResults[1, index].Value != null)
                    {
                        if (dgvResults[1, index].Value.ToString() == lstNameDesserts[i])
                        {
                            lstNameDesserts.Remove(lstNameDesserts[i]);
                            lstPriceDesserts.Remove(lstPriceDesserts[i]);
                            lstQuantityDesserts.Remove(lstQuantityDesserts[i]);
                            lstMenuIDDesserts.Remove(lstMenuIDDesserts[i]);
                        }
                    }
                }
                if (dgvResults[1, index].Value != null)
                {
                    dgvResults.Rows.RemoveAt(index);
                }
                decSubTotal = 0;
                LoadLabels();
            }
            catch(Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool ExpirationDatePast(string strExpirationDate)
        { //check to see if credit card expiration date is past
            bool boolPastExpiration = true;
            try
            {
                int intMonth = DateTime.Now.Month;
                int intYear = DateTime.Now.Year;
                string strMonth = strExpirationDate.Substring(0, 2);
                string strYear = strExpirationDate.Substring(3);
                int intMonthExp = Convert.ToInt32(strMonth);
                int intYearExp = Convert.ToInt32(strYear) + 2000;
                if (intYearExp <= intYear)
                {
                    if (intYearExp < intYear)
                    {
                        boolPastExpiration = true;
                    }
                    else if (intYearExp == intYear)
                    {
                        if (intMonthExp < intMonth)
                        {
                            boolPastExpiration = true;
                        }
                        else
                        {
                            boolPastExpiration = false;
                        }
                    }
                }
                else
                {
                    boolPastExpiration = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return boolPastExpiration;
        }

        public bool CreditCardUpdate()
        {
            //validate credit card and expiration format and update database
            bool boolCreditCardUpdate = false;
            try
            {
                string strCreditCard = tbxCreditCard.Text;
                string strExpiration = tbxExpirationDate.Text;
                if (strCreditCard == "")
                {
                    MessageBox.Show("Credit Card cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    boolCreditCardUpdate = false;
                }
                else if (!Validation.ValidCreditCard(strCreditCard))
                {
                    MessageBox.Show("Credit Card Format 1234-5678-1234-5678.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    boolCreditCardUpdate = false;
                }
                else if (strExpiration == "")
                {
                    MessageBox.Show("Expiration Date cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    boolCreditCardUpdate = false;
                }
                else if (!Validation.ValidExpiration(strExpiration))
                {
                    MessageBox.Show("Expiration Date Format MM/YY.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    boolCreditCardUpdate = false;
                }
                else if (ExpirationDatePast(strExpiration))
                {
                    MessageBox.Show("Card is Expired.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    boolCreditCardUpdate = false;
                }
                else
                {
                    string strInsertCreditCardQuery = "INSERT INTO group3fa212330.CreditCard VALUES (" + Convert.ToInt32(strCustomerID) + ", '" + strCreditCard +
                        "', '" + strExpiration + "');";
                    ProgOps.UpdateDatabase(strInsertCreditCardQuery);
                    boolCreditCardUpdate = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return boolCreditCardUpdate;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            bool boolCreditCardValid = CreditCardUpdate();
            try
            {
                if (boolCreditCardValid == true)
                {
                    MessageBox.Show("Valid CC");
                }
                else
                {
                    MessageBox.Show("Invalid CC. Please Try Again!", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //save order to db
                int rowCount = dgvResults.RowCount;
                if (dgvResults.RowCount == 0 || dgvResults.RowCount == 3)
                {
                    MessageBox.Show("Nothing to Order. Please make selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var date = DateTime.Now.ToString("yyyy-MM-dd");
                string strInsertOrder = "INSERT INTO group3fa212330.Orders VALUES (" + Convert.ToInt32(strCustomerID) + ", '" + date + "', " + decTotal + ");";
                ProgOps.UpdateDatabase(strInsertOrder);
                string strMaxOrderIDQuery = "SELECT MAX(OrderID) FROM group3fa212330.Orders;";
                string strCustomerPhoneQuery = "SELECT Phone FROM group3fa212330.Customers WHERE CustomerID = " + Convert.ToInt32(strCustomerID) + ";";
                strMaxOrderID = ProgOps.DatabaseCommandLogon(strMaxOrderIDQuery);
                strPhoneNumber = ProgOps.DatabaseCommandLogon(strCustomerPhoneQuery);
                for(int i = 0; i < lstNameEntrees.Count; i++)
                {
                    string strInsertOrderItems = "INSERT INTO group3fa212330.OrderItems VALUES (" + lstMenuIDEntrees[i] + ", " + Convert.ToInt32(strMaxOrderID) + ", " + lstQuantityEntrees[i] + ", " + (lstQuantityEntrees[i] * lstPriceEntrees[i]) + ");";
                    ProgOps.UpdateDatabase(strInsertOrderItems);
                }
                for (int i = 0; i < lstNameDrinks.Count; i++)
                {
                    string strInsertOrderItems = "INSERT INTO group3fa212330.OrderItems VALUES (" + lstMenuIDDrinks[i] + ", " + Convert.ToInt32(strMaxOrderID) + ", " + lstQuantityDrinks[i] + ", " + (lstQuantityDrinks[i] * lstPriceDrinks[i]) + ");";
                    ProgOps.UpdateDatabase(strInsertOrderItems);
                }
                for (int i = 0; i < lstNameDesserts.Count; i++)
                {
                    string strInsertOrderItems = "INSERT INTO group3fa212330.OrderItems VALUES (" + lstMenuIDDesserts[i] + ", " + Convert.ToInt32(strMaxOrderID) + ", " + lstQuantityDesserts[i] + ", " + (lstQuantityDesserts[i] * lstPriceDesserts[i]) + ");";
                    ProgOps.UpdateDatabase(strInsertOrderItems);
                }
                MessageBox.Show("Order Updated Successfully.", "Order Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                boolOrderMade = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private StringBuilder GenerateReport()
        {
            StringBuilder html = new StringBuilder();
            StringBuilder css = new StringBuilder();
            try
            {
                // CSS is a way to style the HTML page. Each HTML tag can be customized.
                // In this example, the H1 and TD tags are customized.
                // Refer to this website for examples: https://www.w3schools.com/Css/css_syntax.asp

                css.AppendLine("<style>");
                css.AppendLine("td {padding: 5px; text-align:center; font-weight: bold; text-align: center; font-size: 12px;}");
                css.AppendLine("h1 {color: blue;}");
                css.AppendLine("</style>");

                html.AppendLine("<html>");
                css.AppendLine("<center {display: block;margin - left: auto;margin - right: auto;width: 50 %;}</center>");
                html.AppendLine($"<head style = 'align:center'>{css}<title>{"Receipt"}</title></head>");
                css.AppendLine("<left {display: block;margin - left: auto;margin - right: auto;width: 50 %;}</left>");
                html.Append("<img src= " + clsLogo.strLogo + " style=' align: center; width: 75px; height: 50px;'>");
                html.AppendLine("<body>");

                html.AppendLine($"<h1>{" Order Receipt"}</h1>");
                html.Append($"<br>{css}</br>");
                html.Append($"<p style = 'text-align: left; font-size: 25px'><b>{"Customer: " + strFirstName + " " + strLastName}</b></p>");
                html.Append($"<p style = 'text-align: left; font-size: 15px'><b>{"Order Number: " + strMaxOrderID}</b></p>");
                html.Append($"<p style = 'text-align: left; font-size: 15px'><b>{"Phone Number: " + strPhoneNumber}</b></p>");
                // Create table of data
                // <TABLE> and </TABLE> is the start and end of a table of rows and data.
                // <TR> and </TR> is one row of data. They contain <TD> and </TD> tags.
                // <TD> and </TD> represents the data inside of the table in a particular row.
                // https://www.w3schools.com/tags/tag_table.asp

                // I used an <HR /> tag which is a "horizontal rule" as table data.
                // You can "span" it across multiple columns of data.

                html.AppendLine("<table>");
                html.AppendLine("<tr ><td style = 'font-size: 20px'>Menu Item</td><td style = 'font-size: 20px'>Quantity</td><td style = 'font-size: 20px'>Price</td></tr>");
                html.AppendLine("<tr><td colspan=3><hr /></td></tr>");
                html.Append("<tr><td style = 'font-size: 15px'>**********Entrees**********</tr></td>");
                for (int i = 0; i < lstNameEntrees.Count; i++)
                {
                    html.Append("<tr>");
                    html.Append($"<td>{lstNameEntrees[i]}</td>");
                    html.Append($"<td>{lstQuantityEntrees[i]}</td>");
                    html.Append($"<td>{(lstQuantityEntrees[i]* lstPriceEntrees[i])}</td>");
                    html.Append("</tr>");
                    html.AppendLine("<tr><td colspan=4><hr /></td></tr>");
                }
                html.Append("<tr><td style = 'font-size: 15px' >**********Drinks**********</tr></td>");
                for (int i = 0; i < lstNameDrinks.Count; i++)
                {
                    html.Append("<tr>");
                    html.Append($"<td>{lstNameDrinks[i]}</td>");
                    html.Append($"<td>{lstQuantityDrinks[i]}</td>");
                    html.Append($"<td>{(lstQuantityDrinks[i] * lstPriceDrinks[i])}</td>");
                    html.Append("</tr>");
                    html.AppendLine("<tr><td colspan=4><hr /></td></tr>");
                }
                html.Append("<tr><td style = 'font-size: 15px'>**********Desserts**********</tr></td>");
                for (int i = 0; i < lstNameDesserts.Count; i++)
                {
                    html.Append("<tr>");
                    html.Append($"<td>{lstNameDesserts[i]}</td>");
                    html.Append($"<td>{lstQuantityDesserts[i]}</td>");
                    html.Append($"<td>{(lstQuantityDesserts[i] * lstPriceDesserts[i])}</td>");
                    html.Append("</tr>");
                    html.AppendLine("<tr><td colspan=4><hr /></td></tr>");
                }
                html.AppendLine("</table>");
                html.Append($"<br></br><br></br>");
                html.Append($"<p style = 'text-align:right; text-indent: 0px; font-size: 15px '><b>{"SubTotal: " + decSubTotal.ToString("C2")}</b></p>");
                html.Append($"<p style = 'text-align:right; text-indent: -5px; font-size: 15px '><b>{"Taxes: " + decTaxes.ToString("C2")}</b></p>");
                html.Append($"<p style = 'text-align:right; text-indent: 0px; font-size: 20px ' ><b>{"Total: " + decTotal.ToString("C2")}</b></p>");
                html.Append($"<div><button onClick='window.print()'> {"Print this page"}</ button ></ div >");
                html.AppendLine("</body></html>");
            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return html; // The returned value has all the HTML and CSS code to represent a webpage
        }
        private void PrintReport(StringBuilder html)
        {
            // Write (and overwrite) to the hard drive using the same filename of "Report.html"
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                // A "using" statement will automatically close a file after opening it.
                // It never hurts to include a file.Close() once you are done with a file.
                using (StreamWriter writer = new StreamWriter(path + "\\MyReceipts\\" + strMaxOrderID + "Receipt.html"))
                {
                    writer.WriteLine(html);
                }
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyReceipts"));
                System.Diagnostics.Process.Start(@path + "\\MyReceipts\\" + strMaxOrderID + "Receipt.html"); //Open the report in the default web browser

            }
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                if (boolOrderMade == false)
                {
                    MessageBox.Show("You must make a order.", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                StringBuilder html = new StringBuilder();
                html = GenerateReport();
                PrintReport(html);
            }
            catch(Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                wplayer.controls.stop();
                this.Hide();
                Application.OpenForms["frmMain"].Show();
                frmMain f2 = (frmMain)Application.OpenForms["frmMain"];
                f2.frmMain_Load(f2, EventArgs.Empty);
            }
            catch(Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {

            }
        }

        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot play media file.");
            this.Close();
        }
    }
}
