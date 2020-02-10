using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_Records.forms.records
{
    public partial class frmRecords : Form
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        functions.Record record = new functions.Record();

        public frmRecords()
        {
            InitializeComponent();
        }

        private void frmRecords_Load(object sender, EventArgs e)
        {
            lblChemistryCount.Text = record.LoadChemistry(dtpChemistryFrom.Value, dtpChemistryTo.Value, gridChemistry);
            lblHematologyCount.Text = record.LoadHematology(dtpHematologyFrom.Value, dtpHematologyTo.Value, gridHematology);
            lblMiscCount.Text = record.LoadMiscellaneous(dtpMiscFrom.Value, dtpMiscTo.Value, gridMisc);
            lblParasitologyCount.Text = record.LoadParasitology(dtpParasitologyFrom.Value, dtpParasitologyTo.Value, gridParasitology);
            lblUrinalysisCount.Text = record.LoadUrinalysisRecord(dtpUrinalysisFrom.Value, dtpUrinalysisTo.Value, gridUrinalysis);
        }

        private void dtpUrinalysisFrom_ValueChanged(object sender, EventArgs e)
        {
            lblUrinalysisCount.Text = record.LoadUrinalysisRecord(dtpUrinalysisFrom.Value, dtpUrinalysisTo.Value, gridUrinalysis);
        }

        private void dtpUrinalysisTo_ValueChanged(object sender, EventArgs e)
        {
            lblUrinalysisCount.Text = record.LoadUrinalysisRecord(dtpUrinalysisFrom.Value, dtpUrinalysisTo.Value, gridUrinalysis);
        }

        private void dtpParasitologyFrom_ValueChanged(object sender, EventArgs e)
        {
            lblParasitologyCount.Text = record.LoadParasitology(dtpParasitologyFrom.Value, dtpParasitologyTo.Value, gridParasitology);
        }

        private void dtpParasitologyTo_ValueChanged(object sender, EventArgs e)
        {
            lblParasitologyCount.Text = record.LoadParasitology(dtpParasitologyFrom.Value, dtpParasitologyTo.Value, gridParasitology);
        }

        private void dtpMiscFrom_ValueChanged(object sender, EventArgs e)
        {
            lblMiscCount.Text = record.LoadMiscellaneous(dtpMiscFrom.Value, dtpMiscTo.Value, gridMisc);
        }  

        private void dtpMiscTo_ValueChanged(object sender, EventArgs e)
        {
            lblMiscCount.Text = record.LoadMiscellaneous(dtpMiscFrom.Value, dtpMiscTo.Value, gridMisc);
        }

        private void dtpHematologyFrom_ValueChanged(object sender, EventArgs e)
        {
            lblHematologyCount.Text = record.LoadHematology(dtpHematologyFrom.Value, dtpHematologyTo.Value, gridHematology);
        }

        private void dtpHematologyTo_ValueChanged(object sender, EventArgs e)
        {
            lblHematologyCount.Text = record.LoadHematology(dtpHematologyFrom.Value, dtpHematologyTo.Value, gridHematology);
        }

        private void dtpChemistryFrom_ValueChanged(object sender, EventArgs e)
        {
            lblChemistryCount.Text = record.LoadChemistry(dtpChemistryFrom.Value, dtpChemistryTo.Value, gridChemistry);
        }

        private void dtpChemistryTo_ValueChanged(object sender, EventArgs e)
        {
            lblChemistryCount.Text = record.LoadChemistry(dtpChemistryFrom.Value, dtpChemistryTo.Value, gridChemistry);
        }

        private void btnPrintChemistry_Click(object sender, EventArgs e)
        {
            val.DateFrom = dtpChemistryFrom.Value;
            val.DateTo = dtpChemistryTo.Value;

            reports.frmReportViewerRecordChemistry record_chemistry = new reports.frmReportViewerRecordChemistry();
            record_chemistry.ShowDialog();
        }

        private void btnPrintHematology_Click(object sender, EventArgs e)
        {
            val.DateFrom = dtpHematologyFrom.Value;
            val.DateTo = dtpHematologyTo.Value;

            reports.frmReportViewerRecordHematology record_hematology = new reports.frmReportViewerRecordHematology();
            record_hematology.ShowDialog();
        }

        private void btnPrintParasitology_Click(object sender, EventArgs e)
        {
            val.DateFrom = dtpParasitologyFrom.Value;
            val.DateTo = dtpParasitologyTo.Value;

            reports.frmReportViewerRecordParasitology record_parasitology = new reports.frmReportViewerRecordParasitology();
            record_parasitology.ShowDialog();
        }

        private void btnPrintUrinalysis_Click(object sender, EventArgs e)
        {
            val.DateFrom = dtpUrinalysisFrom.Value;
            val.DateTo = dtpUrinalysisTo.Value;

            reports.frmReportViewerRecordUrinalysis record_urinalysis = new reports.frmReportViewerRecordUrinalysis();
            record_urinalysis.ShowDialog();
        }              
    }
}
