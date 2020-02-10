namespace Laboratory_Records.forms.reports
{
    partial class frmReportViewerRecordParasitology
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportViewerRecordParasitology));
            this.rpvParasitology = new Microsoft.Reporting.WinForms.ReportViewer();
            this.records = new Laboratory_Records.Records();
            this.recordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.records)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvParasitology
            // 
            this.rpvParasitology.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ParasitologyReport";
            reportDataSource1.Value = this.recordsBindingSource;
            this.rpvParasitology.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvParasitology.LocalReport.ReportEmbeddedResource = "Laboratory_Records.reports.rptReportParasitology.rdlc";
            this.rpvParasitology.Location = new System.Drawing.Point(0, 0);
            this.rpvParasitology.Name = "rpvParasitology";
            this.rpvParasitology.Size = new System.Drawing.Size(284, 261);
            this.rpvParasitology.TabIndex = 0;
            // 
            // records
            // 
            this.records.DataSetName = "Records";
            this.records.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordsBindingSource
            // 
            this.recordsBindingSource.DataSource = this.records;
            this.recordsBindingSource.Position = 0;
            // 
            // frmReportViewerRecordParasitology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rpvParasitology);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportViewerRecordParasitology";
            this.Text = "Parasitology Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportViewerRecordParasitology_Load);
            ((System.ComponentModel.ISupportInitialize)(this.records)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvParasitology;
        private Records records;
        private System.Windows.Forms.BindingSource recordsBindingSource;
    }
}