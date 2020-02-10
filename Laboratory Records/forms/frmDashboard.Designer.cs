namespace Laboratory_Records.forms
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.tileProfile = new MetroFramework.Controls.MetroTile();
            this.tileReport = new MetroFramework.Controls.MetroTile();
            this.tileAddPatient = new MetroFramework.Controls.MetroTile();
            this.tileUsers = new MetroFramework.Controls.MetroTile();
            this.tilePatients = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tileProfile
            // 
            this.tileProfile.ActiveControl = null;
            this.tileProfile.BackColor = System.Drawing.Color.Green;
            this.tileProfile.Location = new System.Drawing.Point(209, 343);
            this.tileProfile.Name = "tileProfile";
            this.tileProfile.Size = new System.Drawing.Size(180, 134);
            this.tileProfile.TabIndex = 4;
            this.tileProfile.Text = "Profile";
            this.tileProfile.TileImage = global::Laboratory_Records.Properties.Resources._285645___user;
            this.tileProfile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileProfile.UseCustomBackColor = true;
            this.tileProfile.UseSelectable = true;
            this.tileProfile.UseTileImage = true;
            this.tileProfile.Click += new System.EventHandler(this.tileProfile_Click);
            // 
            // tileReport
            // 
            this.tileReport.ActiveControl = null;
            this.tileReport.BackColor = System.Drawing.Color.Green;
            this.tileReport.Location = new System.Drawing.Point(395, 343);
            this.tileReport.Name = "tileReport";
            this.tileReport.Size = new System.Drawing.Size(180, 134);
            this.tileReport.TabIndex = 5;
            this.tileReport.Text = "Reports";
            this.tileReport.TileImage = global::Laboratory_Records.Properties.Resources._285636___book;
            this.tileReport.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileReport.UseCustomBackColor = true;
            this.tileReport.UseSelectable = true;
            this.tileReport.UseTileImage = true;
            this.tileReport.Click += new System.EventHandler(this.tileReport_Click);
            // 
            // tileAddPatient
            // 
            this.tileAddPatient.ActiveControl = null;
            this.tileAddPatient.BackColor = System.Drawing.Color.Green;
            this.tileAddPatient.Location = new System.Drawing.Point(23, 203);
            this.tileAddPatient.Name = "tileAddPatient";
            this.tileAddPatient.Size = new System.Drawing.Size(180, 134);
            this.tileAddPatient.TabIndex = 2;
            this.tileAddPatient.Text = "Add Patient";
            this.tileAddPatient.TileImage = global::Laboratory_Records.Properties.Resources._299068___add_sign;
            this.tileAddPatient.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileAddPatient.UseCustomBackColor = true;
            this.tileAddPatient.UseSelectable = true;
            this.tileAddPatient.UseTileImage = true;
            this.tileAddPatient.Click += new System.EventHandler(this.tileAddPatient_Click);
            // 
            // tileUsers
            // 
            this.tileUsers.ActiveControl = null;
            this.tileUsers.BackColor = System.Drawing.Color.Green;
            this.tileUsers.Location = new System.Drawing.Point(23, 343);
            this.tileUsers.Name = "tileUsers";
            this.tileUsers.Size = new System.Drawing.Size(180, 134);
            this.tileUsers.TabIndex = 3;
            this.tileUsers.Text = "Users";
            this.tileUsers.TileImage = global::Laboratory_Records.Properties.Resources._285648___group_user;
            this.tileUsers.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileUsers.UseCustomBackColor = true;
            this.tileUsers.UseSelectable = true;
            this.tileUsers.UseTileImage = true;
            this.tileUsers.Click += new System.EventHandler(this.tileUsers_Click);
            // 
            // tilePatients
            // 
            this.tilePatients.ActiveControl = null;
            this.tilePatients.BackColor = System.Drawing.Color.Green;
            this.tilePatients.Location = new System.Drawing.Point(209, 63);
            this.tilePatients.Name = "tilePatients";
            this.tilePatients.Size = new System.Drawing.Size(366, 274);
            this.tilePatients.TabIndex = 1;
            this.tilePatients.Text = "Patients";
            this.tilePatients.TileImage = global::Laboratory_Records.Properties.Resources._285658___blue_folder;
            this.tilePatients.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tilePatients.UseCustomBackColor = true;
            this.tilePatients.UseSelectable = true;
            this.tilePatients.UseTileImage = true;
            this.tilePatients.Click += new System.EventHandler(this.tilePatients_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 499);
            this.Controls.Add(this.tileReport);
            this.Controls.Add(this.tileAddPatient);
            this.Controls.Add(this.tileProfile);
            this.Controls.Add(this.tileUsers);
            this.Controls.Add(this.tilePatients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDashboard";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tilePatients;
        private MetroFramework.Controls.MetroTile tileUsers;
        private MetroFramework.Controls.MetroTile tileProfile;
        private MetroFramework.Controls.MetroTile tileAddPatient;
        private MetroFramework.Controls.MetroTile tileReport;
    }
}