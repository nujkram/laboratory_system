namespace Laboratory_Records.forms.reports
{
    partial class frmReportViewerHematology
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportViewerHematology));
            this.rpvHematology = new Microsoft.Reporting.WinForms.ReportViewer();
            this.records = new Laboratory_Records.Records();
            this.hematologyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.records)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hematologyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvHematology
            // 
            this.rpvHematology.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvHematology.LocalReport.ReportEmbeddedResource = "Laboratory_Records.reports.rptHematology.rdlc";
            this.rpvHematology.Location = new System.Drawing.Point(0, 0);
            this.rpvHematology.Name = "rpvHematology";
            this.rpvHematology.Size = new System.Drawing.Size(284, 261);
            this.rpvHematology.TabIndex = 0;
            // 
            // records
            // 
            this.records.DataSetName = "Records";
            this.records.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hematologyBindingSource
            // 
            this.hematologyBindingSource.DataMember = "Hematology";
            this.hematologyBindingSource.DataSource = this.records;
            // 
            // frmReportViewerHematology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rpvHematology);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportViewerHematology";
            this.Text = "Hematology Result";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportViewerHematology_Load);
            ((System.ComponentModel.ISupportInitialize)(this.records)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hematologyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvHematology;
        private Records records;
        private System.Windows.Forms.BindingSource hematologyBindingSource;
    }
}