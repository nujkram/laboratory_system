namespace Laboratory_Records.forms.reports
{
    partial class frmReportViewerRecordChemistry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportViewerRecordChemistry));
            this.rpvChemistry = new Microsoft.Reporting.WinForms.ReportViewer();
            this.records = new Laboratory_Records.Records();
            this.chemistryReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.records)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemistryReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvChemistry
            // 
            this.rpvChemistry.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ChemistryRecord";
            reportDataSource1.Value = this.chemistryReportBindingSource;
            this.rpvChemistry.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvChemistry.LocalReport.ReportEmbeddedResource = "Laboratory_Records.reports.rptReportChemistry.rdlc";
            this.rpvChemistry.Location = new System.Drawing.Point(0, 0);
            this.rpvChemistry.Name = "rpvChemistry";
            this.rpvChemistry.Size = new System.Drawing.Size(730, 394);
            this.rpvChemistry.TabIndex = 0;
            // 
            // records
            // 
            this.records.DataSetName = "Records";
            this.records.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chemistryReportBindingSource
            // 
            this.chemistryReportBindingSource.DataMember = "ChemistryReport";
            this.chemistryReportBindingSource.DataSource = this.records;
            // 
            // frmReportViewerRecordChemistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 394);
            this.Controls.Add(this.rpvChemistry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportViewerRecordChemistry";
            this.Text = "Chemistry Record";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportViewerRecordChemistry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.records)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chemistryReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvChemistry;
        private System.Windows.Forms.BindingSource chemistryReportBindingSource;
        private Records records;
    }
}