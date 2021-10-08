using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team3
{
    public partial class EmployeeEmergecyContact : Form
    {
        public EmployeeEmergecyContact()
        {
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            var emergencyContact = GetEmergencyContact();

            //clear the list view
            lvwEmergencyContactList.Items.Clear();


            foreach (var contact in emergencyContact)
            {
                var row = new string[] { contact.EmployeeName, contact.EmergencyContactName, contact.EmergencyContactNumber };
                var lvw = new ListViewItem(row);
                //display details of selected item
                lvw.Tag = contact;
                //add item to list view control
                lvwEmergencyContactList.Items.Add(lvw);
            }
        }

        private List<Contact> GetEmergencyContact()
        {
            var list = new List<Contact>();
            list.Add(new Contact() { EmployeeName = "Eric Tekell", EmergencyContactName = "John Tekell", EmergencyContactNumber = "325-977-8956", Relation = "Father" });
            list.Add(new Contact() { EmployeeName = "Michal Downing", EmergencyContactName = "Michael Downing", EmergencyContactNumber = "325-977-9006", Relation = "Father" });
            list.Add(new Contact() { EmployeeName = "Guillermo Hernandez", EmergencyContactName = "Sophia Hernadez", EmergencyContactNumber = "325-967-9606", Relation = "Mother" });
            //list.Add(new Contact() { EmployeeName = "Eric Tekell", EmergencyContactName = "John Tekell", EmergencyContactNumber = "325-977-8950", Relation = "Father" });
            //list.Add(new Contact() { EmployeeName = "Eric Tekell", EmergencyContactName = "John Tekell", EmergencyContactNumber = "325-977-8950", Relation = "Father" });
        
            return list;
        }

        private void lvwEmergencyContactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = lvwEmergencyContactList.SelectedItems[0].Tag;

                if(selectedItem != null)
                {
                    MessageBox.Show(selectedItem.ToString(), "Contact Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
               
            }
        }
    }
}
