namespace Laboratory_Records.forms.reports
{
    partial class frmReportViewerUrinalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportViewerUrinalysis));
            this.urinalysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.records = new Laboratory_Records.Records();
            this.rpvUrinalysis = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.urinalysisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.records)).BeginInit();
            this.SuspendLayout();
            // 
            // urinalysisBindingSource
            // 
            this.urinalysisBindingSource.DataMember = "Urinalysis";
            this.urinalysisBindingSource.DataSource = this.records;
            // 
            // records
            // 
            this.records.DataSetName = "Records";
            this.records.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvUrinalysis
            // 
            this.rpvUrinalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Urinalysis";
            reportDataSource1.Value = this.urinalysisBindingSource;
            this.rpvUrinalysis.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvUrinalysis.LocalReport.ReportEmbeddedResource = "Laboratory_Records.reports.rptUrinalysis.rdlc";
            this.rpvUrinalysis.Location = new System.Drawing.Point(0, 0);
            this.rpvUrinalysis.Name = "rpvUrinalysis";
            this.rpvUrinalysis.Size = new System.Drawing.Size(284, 261);
            this.rpvUrinalysis.TabIndex = 0;
            // 
            // frmReportViewerUrinalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rpvUrinalysis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportViewerUrinalysis";
            this.Text = "Urinalysis Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportViewerUrinalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urinalysisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.records)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvUrinalysis;
        private System.Windows.Forms.BindingSource urinalysisBindingSource;
        private Records records;
    }
}