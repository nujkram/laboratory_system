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
    public partial class frmReportViewerMiscellaneous : Form
    {
        components.Values val = new components.Values();
        functions.Miscellaneous miscellaneous = new functions.Miscellaneous();

        public frmReportViewerMiscellaneous()
        {
            InitializeComponent();
        }

        private void frmReportViewerMiscellaneous_Load(object sender, EventArgs e)
        {
            string report_location;
            var rpvMiscellaneous = new ReportViewer { Dock = DockStyle.Fill };
            this.Controls.Add(rpvMiscellaneous);

            // Set page margins 
            // References: https://forums.asp.net/t/2053895.aspx?How+to+set+page+size+in+a+Report+viewer+in+Microsoft+ReportViewer+WebForms

            System.Drawing.Printing.PageSettings page_settings = new System.Drawing.Printing.PageSettings();
            page_settings.Margins.Top = 0;
            page_settings.Margins.Right = 0;
            page_settings.Margins.Bottom = 0;
            page_settings.Margins.Left = 0;
                       
                        
            Records dsMiscellaneous = miscellaneous.GetMiscData(val.MiscID);

            switch (val.MiscExam)
            {
                case "Anti - HAV":
                    report_location = "..\\..\\reports\\miscellaneous\\rptAntiHAV.rdlc";
                    break;

                case "Anti - HBs":
                    report_location = "..\\..\\reports\\miscellaneous\\rptAntiHBs.rdlc";
                    break;

                case "ASOT":
                    report_location = "..\\..\\reports\\miscellaneous\\rptASOT.rdlc";
                    break;

                case "CRP":
                    report_location = "..\\..\\reports\\miscellaneous\\rptCRP.rdlc";
                    break;

                case "Dengue Duo":
                    report_location = "..\\..\\reports\\miscellaneous\\rptDengueDuo.rdlc";
                    break;

                case "Gram's Stain":
                    report_location = "..\\..\\reports\\miscellaneous\\rptGramStain.rdlc";
                    break;

                case "HBsAg":
                    report_location = "..\\..\\reports\\miscellaneous\\rptHBsAg.rdlc";
                    break;

                case "H.Pylori":
                    report_location = "..\\..\\reports\\miscellaneous\\rptHPylori.rdlc";
                    break;

                case "KOH":
                    report_location = "..\\..\\reports\\miscellaneous\\rptKOH.rdlc";
                    break;

                case "Pregnancy Test":
                    report_location = "..\\..\\reports\\miscellaneous\\rptPregnancyTest.rdlc";
                    break;

                case "RPR":
                    report_location = "..\\..\\reports\\miscellaneous\\rptRPR.rdlc";
                    break;

                default:
                    report_location = "";
                    break;
            }
            

            rpvMiscellaneous.Reset();

            using (var reportDesignStream = System.IO.File.OpenRead(report_location))
            {

                ReportDataSource datasource = new ReportDataSource("Miscellaneous", dsMiscellaneous.Tables["Miscellaneous"]);

                ReportParameter[] rParams = new ReportParameter[] {
                new ReportParameter("patient_name", val.PatientFullName),
                new ReportParameter("patient_age", val.PatientAge.ToString()),
                new ReportParameter("patient_gender", val.PatientGender),
                new ReportParameter("record_date", val.RecordCreated.ToString("MM-dd-yyyy")),
                new ReportParameter("record_case_no", val.RecordCase.ToString()),
                new ReportParameter("exam_desired", val.MiscExam),
                new ReportParameter("record_requested_by", val.RecordRequest),
                new ReportParameter("med_tech_name", String.Format("{0}, {1}", val.MedFullName, val.MedTitle)),
                new ReportParameter("med_tech_license", String.Format("License #{0}", val.MedLicense)),
                new ReportParameter("pathologist_name", String.Format("{0}, {1}", val.PatFullName, val.PatTitle)),
                new ReportParameter("pathologist_license", String.Format("License #{0}", val.PatLicense)),
                new ReportParameter("created_by", val.EncoderNiceName)
                };

                rpvMiscellaneous.SetPageSettings(page_settings);
                rpvMiscellaneous.LocalReport.LoadReportDefinition(reportDesignStream);
                rpvMiscellaneous.LocalReport.DataSources.Clear();
                rpvMiscellaneous.LocalReport.SetParameters(rParams);
                rpvMiscellaneous.LocalReport.DataSources.Add(datasource);
                rpvMiscellaneous.RefreshReport();
            }
            
            
            
        }
    }
}
