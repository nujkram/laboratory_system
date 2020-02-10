namespace Laboratory_Records.forms.lab
{
    partial class frmLabMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLabMenu));
            this.tileChemistry = new MetroFramework.Controls.MetroTile();
            this.tileHematology = new MetroFramework.Controls.MetroTile();
            this.tileParasitology = new MetroFramework.Controls.MetroTile();
            this.tileUrinalysis = new MetroFramework.Controls.MetroTile();
            this.tileMisc = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tileChemistry
            // 
            this.tileChemistry.ActiveControl = null;
            this.tileChemistry.BackColor = System.Drawing.Color.ForestGreen;
            this.tileChemistry.Location = new System.Drawing.Point(23, 63);
            this.tileChemistry.Name = "tileChemistry";
            this.tileChemistry.Size = new System.Drawing.Size(180, 134);
            this.tileChemistry.TabIndex = 3;
            this.tileChemistry.Text = "Chemistry";
            this.tileChemistry.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileChemistry.UseCustomBackColor = true;
            this.tileChemistry.UseCustomForeColor = true;
            this.tileChemistry.UseSelectable = true;
            this.tileChemistry.UseTileImage = true;
            this.tileChemistry.Click += new System.EventHandler(this.tileChemistry_Click);
            // 
            // tileHematology
            // 
            this.tileHematology.ActiveControl = null;
            this.tileHematology.BackColor = System.Drawing.Color.Brown;
            this.tileHematology.Location = new System.Drawing.Point(23, 202);
            this.tileHematology.Name = "tileHematology";
            this.tileHematology.Size = new System.Drawing.Size(180, 134);
            this.tileHematology.TabIndex = 4;
            this.tileHematology.Text = "Hematology";
            this.tileHematology.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileHematology.UseCustomBackColor = true;
            this.tileHematology.UseCustomForeColor = true;
            this.tileHematology.UseSelectable = true;
            this.tileHematology.UseTileImage = true;
            this.tileHematology.Click += new System.EventHandler(this.tileHematology_Click);
            // 
            // tileParasitology
            // 
            this.tileParasitology.ActiveControl = null;
            this.tileParasitology.BackColor = System.Drawing.Color.Khaki;
            this.tileParasitology.Location = new System.Drawing.Point(209, 156);
            this.tileParasitology.Name = "tileParasitology";
            this.tileParasitology.Size = new System.Drawing.Size(123, 87);
            this.tileParasitology.TabIndex = 5;
            this.tileParasitology.Text = "Parasitology";
            this.tileParasitology.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileParasitology.UseCustomBackColor = true;
            this.tileParasitology.UseCustomForeColor = true;
            this.tileParasitology.UseSelectable = true;
            this.tileParasitology.UseTileImage = true;
            this.tileParasitology.Click += new System.EventHandler(this.tileParasitology_Click);
            // 
            // tileUrinalysis
            // 
            this.tileUrinalysis.ActiveControl = null;
            this.tileUrinalysis.BackColor = System.Drawing.Color.Gold;
            this.tileUrinalysis.Location = new System.Drawing.Point(209, 63);
            this.tileUrinalysis.Name = "tileUrinalysis";
            this.tileUrinalysis.Size = new System.Drawing.Size(123, 87);
            this.tileUrinalysis.TabIndex = 6;
            this.tileUrinalysis.Text = "Urinalysis";
            this.tileUrinalysis.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileUrinalysis.UseCustomBackColor = true;
            this.tileUrinalysis.UseCustomForeColor = true;
            this.tileUrinalysis.UseSelectable = true;
            this.tileUrinalysis.UseTileImage = true;
            this.tileUrinalysis.Click += new System.EventHandler(this.tileUrinalysis_Click);
            // 
            // tileMisc
            // 
            this.tileMisc.ActiveControl = null;
            this.tileMisc.BackColor = System.Drawing.Color.RoyalBlue;
            this.tileMisc.Location = new System.Drawing.Point(209, 249);
            this.tileMisc.Name = "tileMisc";
            this.tileMisc.Size = new System.Drawing.Size(123, 87);
            this.tileMisc.TabIndex = 7;
            this.tileMisc.Text = "Misc";
            this.tileMisc.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileMisc.UseCustomBackColor = true;
            this.tileMisc.UseCustomForeColor = true;
            this.tileMisc.UseSelectable = true;
            this.tileMisc.UseTileImage = true;
            this.tileMisc.Click += new System.EventHandler(this.tileMisc_Click);
            // 
            // frmLabMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 350);
            this.Controls.Add(this.tileMisc);
            this.Controls.Add(this.tileUrinalysis);
            this.Controls.Add(this.tileParasitology);
            this.Controls.Add(this.tileHematology);
            this.Controls.Add(this.tileChemistry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLabMenu";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Laboratory Test Menu";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmLabMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileChemistry;
        private MetroFramework.Controls.MetroTile tileHematology;
        private MetroFramework.Controls.MetroTile tileParasitology;
        private MetroFramework.Controls.MetroTile tileUrinalysis;
        private MetroFramework.Controls.MetroTile tileMisc;
    }
}