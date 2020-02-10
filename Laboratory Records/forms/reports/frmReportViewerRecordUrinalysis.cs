using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_Records.forms.reports
{
    public partial class frmReportViewerRecordUrinalysis : Form
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        functions.Report report = new functions.Report();

        public frmReportViewerRecordUrinalysis()
        {
            InitializeComponent();
        }

        private void frmReportViewerRecordUrinalysis_Load(object sender, EventArgs e)
        {
            var settings = rpvUrinalysis.GetPageSettings();
            settings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 850, 1300);
            settings.Margins = new System.Drawing.Printing.Margins(1, 1, 1, 1);
            settings.Landscape = true;

            rpvUrinalysis.SetPageSettings(settings);

            Records dsUrinalysis = report.GetReportUrinalysisData(val.DateFrom, val.DateTo);
            ReportDataSource datasource = new ReportDataSource("UrinalysisReport", dsUrinalysis.Tables["UrinalysisReport"]);
            ReportParameter[] rParams = new ReportParameter[] {
                new ReportParameter("date_from", val.DateFrom.ToString()),
                new ReportParameter("date_to", val.DateTo.ToString()),
                new ReportParameter("user", val.Username)
            };

            this.rpvUrinalysis.LocalReport.SetParameters(rParams);
            this.rpvUrinalysis.LocalReport.DataSources.Clear();
            this.rpvUrinalysis.LocalReport.DataSources.Add(datasource);
            this.rpvUrinalysis.RefreshReport();
            this.rpvUrinalysis.RefreshReport();
        }
    }
}
