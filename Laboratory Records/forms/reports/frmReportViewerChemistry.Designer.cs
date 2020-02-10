namespace Laboratory_Records.forms.reports
{
    partial class frmReportViewerChemistry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportViewerChemistry));
            this.chemistryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.records = new Laboratory_Records.Records();
            this.rpvChemistry = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.chemistryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.records)).BeginInit();
            this.SuspendLayout();
            // 
            // chemistryBindingSource
            // 
            this.chemistryBindingSource.DataMember = "Chemistry";
            this.chemistryBindingSource.DataSource = this.records;
            // 
            // records
            // 
            this.records.DataSetName = "Records";
            this.records.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvChemistry
            // 
            this.rpvChemistry.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Chemistry";
            reportDataSource1.Value = this.chemistryBindingSource;
            this.rpvChemistry.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvChemistry.LocalReport.ReportEmbeddedResource = "Laboratory_Records.reports.rptChemistry.rdlc";
            this.rpvChemistry.Location = new System.Drawing.Point(0, 0);
            this.rpvChemistry.Name = "rpvChemistry";
            this.rpvChemistry.Size = new System.Drawing.Size(634, 342);
            this.rpvChemistry.TabIndex = 0;
            // 
            // frmReportViewerChemistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 342);
            this.Controls.Add(this.rpvChemistry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportViewerChemistry";
            this.Text = "Chemistry Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportChemistry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chemistryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.records)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Records records;
        private Microsoft.Reporting.WinForms.ReportViewer rpvChemistry;
        private System.Windows.Forms.BindingSource chemistryBindingSource;
    }
}