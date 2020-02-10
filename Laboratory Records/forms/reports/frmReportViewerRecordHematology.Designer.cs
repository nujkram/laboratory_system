namespace Laboratory_Records.forms.reports
{
    partial class frmReportViewerRecordHematology
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportViewerRecordHematology));
            this.rpvHematology = new Microsoft.Reporting.WinForms.ReportViewer();
            this.records = new Laboratory_Records.Records();
            this.recordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.records)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvHematology
            // 
            this.rpvHematology.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "HematologyReport";
            reportDataSource1.Value = this.recordsBindingSource;
            this.rpvHematology.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvHematology.LocalReport.ReportEmbeddedResource = "Laboratory_Records.reports.rptReportHematology.rdlc";
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
            // recordsBindingSource
            // 
            this.recordsBindingSource.DataSource = this.records;
            this.recordsBindingSource.Position = 0;
            // 
            // frmReportViewerRecordHematology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rpvHematology);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportViewerRecordHematology";
            this.Text = "Hematology Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportViewerRecordHematology_Load);
            ((System.ComponentModel.ISupportInitialize)(this.records)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvHematology;
        private System.Windows.Forms.BindingSource recordsBindingSource;
        private Records records;
    }
}