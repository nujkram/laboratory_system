namespace Laboratory_Records.forms.reports
{
    partial class frmReportViewerRecordMiscellaneous
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportViewerRecordMiscellaneous));
            this.rpvMiscellaneous = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvMiscellaneous
            // 
            this.rpvMiscellaneous.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "HematologyReport";
            reportDataSource1.Value = null;
            this.rpvMiscellaneous.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvMiscellaneous.LocalReport.ReportEmbeddedResource = "Laboratory_Records.reports.rptReportHematology.rdlc";
            this.rpvMiscellaneous.Location = new System.Drawing.Point(0, 0);
            this.rpvMiscellaneous.Name = "rpvMiscellaneous";
            this.rpvMiscellaneous.Size = new System.Drawing.Size(270, 278);
            this.rpvMiscellaneous.TabIndex = 1;
            // 
            // frmReportViewerRecordMiscellaneous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 278);
            this.Controls.Add(this.rpvMiscellaneous);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportViewerRecordMiscellaneous";
            this.Text = "Miscellaneous Report";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvMiscellaneous;
    }
}