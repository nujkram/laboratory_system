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
    public partial class frmReportViewerHematology : Form
    {
        components.Values val = new components.Values();
        functions.Hematology hematology = new functions.Hematology();

        public frmReportViewerHematology()
        {
            InitializeComponent();
        }

        private void frmReportViewerHematology_Load(object sender, EventArgs e)
        {
            var settings = rpvHematology.GetPageSettings();
            settings.Margins = new System.Drawing.Printing.Margins(1, 1, 1, 1);
            rpvHematology.SetPageSettings(settings);

            Records dsHematology = hematology.GetHematologyData(val.HemaID);
            ReportDataSource datasource = new ReportDataSource("Hematology", dsHematology.Tables["Hematology"]);
            ReportParameter[] rParams = new ReportParameter[] {
                new ReportParameter("patient_name", val.PatientFullName),
                new ReportParameter("patient_age", val.PatientAge.ToString()),
                new ReportParameter("patient_gender", val.PatientGender),
                new ReportParameter("record_date", val.RecordCreated.ToString("MM-dd-yyyy")),
                new ReportParameter("record_case_no", val.RecordCase.ToString()),
                new ReportParameter("record_stat", val.HemaStat),
                new ReportParameter("exam_desired", val.HemaExam),
                new ReportParameter("record_requested_by", val.RecordRequest),
                new ReportParameter("med_tech_name", String.Format("{0}, {1}", val.MedFullName, val.MedTitle)),
                new ReportParameter("med_tech_license", String.Format("License #{0}", val.MedLicense)),
                new ReportParameter("pathologist_name", String.Format("{0}, {1}", val.PatFullName, val.PatTitle)),
                new ReportParameter("pathologist_license", String.Format("License #{0}", val.PatLicense)),
                new ReportParameter("created_by", val.EncoderNiceName)
            };

            this.rpvHematology.LocalReport.SetParameters(rParams);
            this.rpvHematology.LocalReport.DataSources.Clear();
            this.rpvHematology.LocalReport.DataSources.Add(datasource);
            this.rpvHematology.RefreshReport();
        }
    }
}
