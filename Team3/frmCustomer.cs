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
        List<Menu> lstMenu = new List<Menu>();
        List<Image> lstImages = new List<Image>();
        
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"taco.jpg");
            this.BackgroundImage = myimage;
            tbMenuItems.BackgroundImage = myimage;
            try
            {
                lstMenu = ProgOps.ReloadImageList();
                lstImages = ListImages();

             
                int perCol = 5;
                int disBetWeen = 15;
                int width = 150;
                int height = 150;
                int lblHeight = 150;
                int numHeight = -10;
                PictureBox[] myPicBox = new PictureBox[lstMenu.Count];
                Label[] lblMenuName = new Label[lstMenu.Count];
                NumericUpDown[] numQuantity = new NumericUpDown[lstMenu.Count];
                for (int i = 0; i < lstMenu.Count; i++)
                {
                    myPicBox[i] = (new PictureBox());
                    myPicBox[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    myPicBox[i].Location = new System.Drawing.Point(disBetWeen + (disBetWeen * (i % perCol) + (width * (i % perCol))),
                        100 + (100 * (i / perCol)) + (height * (i / perCol)));
                    myPicBox[i].Name = "pictureBox" + i;
                    myPicBox[i].Size = new System.Drawing.Size(width, height);
                    myPicBox[i].Image = lstImages[i];
                    myPicBox[i].Click += new EventHandler(myPicBox_click);
                    lblMenuName[i] = new Label();
                    lblMenuName[i].Size = new Size(150, 50);
                    lblMenuName[i].Location = new System.Drawing.Point(disBetWeen + (disBetWeen * (i % perCol) + (width * (i % perCol))),
                        75 + (75 * (i / perCol)) + (lblHeight * (i / perCol)));
                    lblMenuName[i].Name = "label" + i.ToString();
                    lblMenuName[i].Text = (i + 1).ToString() + ". " + lstMenu[i].name;
                    numQuantity[i] = new NumericUpDown();
                    numQuantity[i].Size = new System.Drawing.Size(30, 30);
                    numQuantity[i].Location = new System.Drawing.Point(disBetWeen + (disBetWeen * (i % perCol) + (width * (i % perCol))),
                        260 + (260 * (i / perCol)) + (numHeight * (i / perCol)));
                    numQuantity[i].Name = "numQuantity" + i.ToString();
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
            catch (Exception ex)
            {
                MessageBox.Show(message + ex.Message, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void myPicBox_click(object sender, EventArgs e)
        {
            PictureBox picBox = sender as PictureBox;
            for(int i= 0; i < lstMenu.Count; i++)
            {
                if (picBox.Name == "pictureBox" + i.ToString())
                {
                    MessageBox.Show("Description: " + lstMenu[i].description + "\n\n" + "Price: " + lstMenu[i].price.ToString("C2"));
                    return;
                }
            }
            
        }
        public List<Image> ListImages()
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
            for(int i = 0; i < lstMenu.Count; i++)
            {
               
            }
        }
    }
}
