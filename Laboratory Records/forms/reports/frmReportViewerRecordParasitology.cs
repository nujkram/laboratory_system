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
    public partial class frmReportViewerRecordParasitology : Form
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        functions.Report report = new functions.Report();

        public frmReportViewerRecordParasitology()
        {
            InitializeComponent();
        }

        private void frmReportViewerRecordParasitology_Load(object sender, EventArgs e)
        {
            var settings = rpvParasitology.GetPageSettings();
            settings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 850, 1300);
            settings.Margins = new System.Drawing.Printing.Margins(1, 1, 1, 1);
            settings.Landscape = true;

            rpvParasitology.SetPageSettings(settings);

            Records dsParasitology = report.GetReportParasitologyData(val.DateFrom, val.DateTo);
            ReportDataSource datasource = new ReportDataSource("ParasitologyReport", dsParasitology.Tables["ParasitologyReport"]);
            ReportParameter[] rParams = new ReportParameter[] {
                new ReportParameter("date_from", val.DateFrom.ToString()),
                new ReportParameter("date_to", val.DateTo.ToString()),
                new ReportParameter("user", val.Username)
            };

            this.rpvParasitology.LocalReport.SetParameters(rParams);
            this.rpvParasitology.LocalReport.DataSources.Clear();
            this.rpvParasitology.LocalReport.DataSources.Add(datasource);
            this.rpvParasitology.RefreshReport();
        }
    }
}
