
namespace Team3
{
    partial class frmTruckLocation
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.lblLong = new System.Windows.Forms.Label();
            this.tbxLat = new System.Windows.Forms.TextBox();
            this.tbxLong = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(42, 31);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(380, 22);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Please enter the lat and long of the trucks new location:";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.BackColor = System.Drawing.Color.Transparent;
            this.lblLat.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.ForeColor = System.Drawing.Color.White;
            this.lblLat.Location = new System.Drawing.Point(112, 105);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(37, 22);
            this.lblLat.TabIndex = 1;
            this.lblLat.Text = "Lat:";
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.BackColor = System.Drawing.Color.Transparent;
            this.lblLong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLong.ForeColor = System.Drawing.Color.White;
            this.lblLong.Location = new System.Drawing.Point(99, 148);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(50, 22);
            this.lblLong.TabIndex = 2;
            this.lblLong.Text = "Long:";
            // 
            // tbxLat
            // 
            this.tbxLat.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLat.Location = new System.Drawing.Point(186, 98);
            this.tbxLat.Name = "tbxLat";
            this.tbxLat.Size = new System.Drawing.Size(100, 29);
            this.tbxLat.TabIndex = 3;
            // 
            // tbxLong
            // 
            this.tbxLong.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLong.Location = new System.Drawing.Point(186, 148);
            this.tbxLong.Name = "tbxLong";
            this.tbxLong.Size = new System.Drawing.Size(100, 29);
            this.tbxLong.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(58, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 47);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save Location";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(275, 202);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 47);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmTruckLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxLong);
            this.Controls.Add(this.tbxLat);
            this.Controls.Add(this.lblLong);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.lblInfo);
            this.Name = "frmTruckLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Truck Location";
            this.Load += new System.EventHandler(this.frmTruckLocation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.TextBox tbxLat;
        private System.Windows.Forms.TextBox tbxLong;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}