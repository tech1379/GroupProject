namespace Team3
{
    partial class EmployeeEmergecyContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvwEmergencyContactList = new System.Windows.Forms.ListView();
            this.chEmployee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmergencyContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmergencyContactNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRelation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblListOfEmployees = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwEmergencyContactList
            // 
            this.lvwEmergencyContactList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEmployee,
            this.chEmergencyContact,
            this.chEmergencyContactNum,
            this.chRelation});
            this.lvwEmergencyContactList.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwEmergencyContactList.GridLines = true;
            this.lvwEmergencyContactList.HideSelection = false;
            this.lvwEmergencyContactList.Location = new System.Drawing.Point(17, 64);
            this.lvwEmergencyContactList.Name = "lvwEmergencyContactList";
            this.lvwEmergencyContactList.Size = new System.Drawing.Size(808, 215);
            this.lvwEmergencyContactList.TabIndex = 0;
            this.lvwEmergencyContactList.UseCompatibleStateImageBehavior = false;
            this.lvwEmergencyContactList.View = System.Windows.Forms.View.Details;
            this.lvwEmergencyContactList.SelectedIndexChanged += new System.EventHandler(this.lvwEmergencyContactList_SelectedIndexChanged);
            // 
            // chEmployee
            // 
            this.chEmployee.Text = "Employee Name";
            this.chEmployee.Width = 208;
            // 
            // chEmergencyContact
            // 
            this.chEmergencyContact.Text = "Emergency Contact";
            this.chEmergencyContact.Width = 187;
            // 
            // chEmergencyContactNum
            // 
            this.chEmergencyContactNum.Text = "Emergency Contact Number";
            this.chEmergencyContactNum.Width = 253;
            // 
            // chRelation
            // 
            this.chRelation.Text = "Relation";
            this.chRelation.Width = 154;
            // 
            // lblListOfEmployees
            // 
            this.lblListOfEmployees.AutoSize = true;
            this.lblListOfEmployees.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfEmployees.Location = new System.Drawing.Point(12, 35);
            this.lblListOfEmployees.Name = "lblListOfEmployees";
            this.lblListOfEmployees.Size = new System.Drawing.Size(262, 26);
            this.lblListOfEmployees.TabIndex = 1;
            this.lblListOfEmployees.Text = "Employee Emergency Contact";
            // 
            // EmployeeEmergecyContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 300);
            this.Controls.Add(this.lblListOfEmployees);
            this.Controls.Add(this.lvwEmergencyContactList);
            this.Name = "EmployeeEmergecyContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Emergency Contact List";
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwEmergencyContactList;
        private System.Windows.Forms.ColumnHeader chEmployee;
        private System.Windows.Forms.Label lblListOfEmployees;
        private System.Windows.Forms.ColumnHeader chEmergencyContact;
        private System.Windows.Forms.ColumnHeader chEmergencyContactNum;
        private System.Windows.Forms.ColumnHeader chRelation;
    }
}