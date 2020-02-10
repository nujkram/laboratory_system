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
    public partial class frmReportViewerChemistry :Form
    {
        components.Values val = new components.Values();
        functions.Chemistry chemistry = new functions.Chemistry();

        public frmReportViewerChemistry()
        {
            InitializeComponent();
        }

        private void frmReportChemistry_Load(object sender, EventArgs e)
        {

            var settings = rpvChemistry.GetPageSettings();
            settings.Margins = new System.Drawing.Printing.Margins(1, 1, 1, 1);
            rpvChemistry.SetPageSettings(settings);

            Records dsChemistry = chemistry.GetChemistryData(val.ChemID);
            ReportDataSource datasource = new ReportDataSource("Chemistry", dsChemistry.Tables["Chemistry"]);
            ReportParameter[] rParams = new ReportParameter[] {
                new ReportParameter("patient_name", val.PatientFullName),
                new ReportParameter("patient_age", val.PatientAge.ToString()),
                new ReportParameter("patient_gender", val.PatientGender),
                new ReportParameter("record_date", val.RecordCreated.ToString("MM-dd-yyyy")),
                new ReportParameter("record_case_no", val.RecordCase.ToString()),
                new ReportParameter("record_stat", val.ChemStat),
                new ReportParameter("record_requested_by", val.RecordRequest),
                new ReportParameter("med_tech_name", String.Format("{0}, {1}", val.MedFullName, val.MedTitle)),
                new ReportParameter("med_tech_license", String.Format("License #{0}", val.MedLicense)),
                new ReportParameter("pathologist_name", String.Format("{0}, {1}", val.PatFullName, val.PatTitle)),
                new ReportParameter("pathologist_license", String.Format("License #{0}", val.PatLicense)),
                new ReportParameter("created_by", val.EncoderNiceName)
            };

            this.rpvChemistry.LocalReport.SetParameters(rParams);
            this.rpvChemistry.LocalReport.DataSources.Clear();
            this.rpvChemistry.LocalReport.DataSources.Add(datasource);
            this.rpvChemistry.RefreshReport();
        }
    }
}
