namespace Laboratory_Records.forms.reports
{
    partial class frmReportViewerParasitology
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportViewerParasitology));
            this.parasitologyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.records = new Laboratory_Records.Records();
            this.rpvParasitology = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.parasitologyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.records)).BeginInit();
            this.SuspendLayout();
            // 
            // parasitologyBindingSource
            // 
            this.parasitologyBindingSource.DataMember = "Parasitology";
            this.parasitologyBindingSource.DataSource = this.records;
            // 
            // records
            // 
            this.records.DataSetName = "Records";
            this.records.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvParasitology
            // 
            this.rpvParasitology.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Parasitology";
            reportDataSource1.Value = this.parasitologyBindingSource;
            this.rpvParasitology.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvParasitology.LocalReport.ReportEmbeddedResource = "Laboratory_Records.reports.rptParasitology.rdlc";
            this.rpvParasitology.Location = new System.Drawing.Point(0, 0);
            this.rpvParasitology.Name = "rpvParasitology";
            this.rpvParasitology.Size = new System.Drawing.Size(284, 261);
            this.rpvParasitology.TabIndex = 0;
            // 
            // frmReportViewerParasitology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rpvParasitology);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportViewerParasitology";
            this.Text = "Parasitology Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportViewerParasitology_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parasitologyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.records)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvParasitology;
        private System.Windows.Forms.BindingSource parasitologyBindingSource;
        private Records records;
    }
}