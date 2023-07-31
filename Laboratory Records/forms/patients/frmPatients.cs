using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_Records.forms.patients
{
    public partial class frmPatients : MetroFramework.Forms.MetroForm
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();
        functions.Profile profile = new functions.Profile();
        functions.Record record = new functions.Record();
        functions.Transaction trans = new functions.Transaction();
        functions.Chemistry chemistry = new functions.Chemistry();
        functions.Hematology hematology = new functions.Hematology();
        functions.Miscellaneous miscellaneous = new functions.Miscellaneous();
        functions.Parasitology parasitology = new functions.Parasitology();
        functions.Urinalysis urinalysis = new functions.Urinalysis();

        private DataTable originalDataTable;

        public frmPatients()
        {
            InitializeComponent();
        }

        private void frmPatients_Load(object sender, EventArgs e)
        {
            patient.LoadPatients(gridPatients);
            record.LoadPatientRecords(val.PatientID, gridRecords);
            SetPatienInfo();
            trans.LoadTransactions(val.RecordID, gridTrans);
            lblPatientCount.Text = String.Format("Patient Count: {0}", val.PatientCount.ToString());
            PopulateYear();
            originalDataTable = (DataTable)gridPatients.DataSource;
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text.Trim();

            if(originalDataTable == null || originalDataTable.Rows.Count == 0)
            {
                return;
            }

            try
            {
                var filteredRows = originalDataTable.AsEnumerable()
                .Where(row =>
                    row.Field<string>("last_name").IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0
                ).CopyToDataTable();
                gridPatients.DataSource = filteredRows;
                record.LoadPatientRecords(val.PatientID, gridRecords);
                lblPatientCount.Text = String.Format("Patient Count: {0}", val.PatientCount.ToString());
                
            } catch (InvalidOperationException)
            {
                gridPatients.DataSource = null;
            }
            
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            frmAddPatient add_patient = new frmAddPatient();
            add_patient.FormClosing += new FormClosingEventHandler(this.frmPatients_FormClosing);
            add_patient.ShowDialog();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            records.frmAddRecord add_record = new records.frmAddRecord();
            add_record.FormClosing += new FormClosingEventHandler(this.frmPatients_FormClosing);
            add_record.ShowDialog();
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            lab.frmLabMenu lab_menu = new lab.frmLabMenu();
            lab_menu.FormClosing += new FormClosingEventHandler(this.frmPatients_FormClosing);
            lab_menu.ShowDialog();
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            frmUpdatePatient update_patient = new frmUpdatePatient();
            update_patient.FormClosing += new FormClosingEventHandler(this.frmPatients_FormClosing);
            update_patient.ShowDialog();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            records.frmUpdateRecord update_record = new records.frmUpdateRecord();
            update_record.FormClosing += new FormClosingEventHandler(this.frmPatients_FormClosing);
            update_record.ShowDialog();
        }

        private void btnChemUpdate_Click(object sender, EventArgs e)
        {
            lab.update.frmUpdateChemistry update_chemistry = new lab.update.frmUpdateChemistry();
            update_chemistry.FormClosing += new FormClosingEventHandler(this.frmPatients_FormClosing);
            update_chemistry.ShowDialog();

        }

        private void btnHemaUpdate_Click(object sender, EventArgs e)
        {
            lab.update.frmUpdateHematology update_hematology = new lab.update.frmUpdateHematology();
            update_hematology.FormClosing += new FormClosingEventHandler(this.frmPatients_FormClosing);
            update_hematology.ShowDialog();
        }

        private void btnMiscUpdate_Click(object sender, EventArgs e)
        {
            lab.update.frmUpdateMisc update_misc = new lab.update.frmUpdateMisc();
            update_misc.FormClosing += new FormClosingEventHandler(this.frmPatients_FormClosing);
            update_misc.ShowDialog();
        }

        private void btnParaUpdate_Click(object sender, EventArgs e)
        {
            lab.update.frmUpdateParasitology update_parasitology = new lab.update.frmUpdateParasitology();
            update_parasitology.FormClosing += new FormClosingEventHandler(this.frmPatients_FormClosing);
            update_parasitology.ShowDialog();
        }

        private void btnUriUpdate_Click(object sender, EventArgs e)
        {
            lab.update.frmUpdateUrinalysis update_urinalysis = new lab.update.frmUpdateUrinalysis();
            update_urinalysis.FormClosing += new FormClosingEventHandler(this.frmPatients_FormClosing);
            update_urinalysis.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPatients_FormClosing(object sender, FormClosingEventArgs e)
        {
            patient.LoadPatients(gridPatients);
            record.LoadPatientRecords(val.PatientID, gridRecords);
            trans.LoadTransactions(val.RecordID, gridTrans);
            FilterLabResult(0);
        }

        private void gridPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            patient.GetPatientDetail(gridPatients.CurrentRow.Index, gridPatients);
            record.LoadPatientRecords(val.PatientID, gridRecords);
            trans.LoadTransactions(val.RecordID, gridTrans);
            FilterLabResult(0);
            SetPatienInfo();
            CheckPatientRecord();
        }

        private void gridPatients_KeyDown(object sender, KeyEventArgs e)
        {
            int i = gridPatients.CurrentRow.Index;

            if (e.KeyCode == Keys.Down && i + 2 <= gridPatients.RowCount)
            {
                i = gridPatients.CurrentRow.Index + 1;
                patient.GetPatientDetail(i, gridPatients);

            }
            else if (e.KeyCode == Keys.Up && i - 1 >= 0)
            {
                i = gridPatients.CurrentRow.Index - 1;
                patient.GetPatientDetail(i, gridPatients);
            }
            record.LoadPatientRecords(val.PatientID, gridRecords);
            trans.LoadTransactions(val.RecordID, gridTrans);
            FilterLabResult(0);
            SetPatienInfo();
            CheckPatientRecord();
        }

        private void gridRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridRecords.Rows.Count != 0)
            {
                record.GetPatientRecord(gridRecords.CurrentRow.Index, gridRecords);
                trans.LoadTransactions(val.RecordID, gridTrans);
                FilterLabResult(0);
            }
        }

        private void gridRecords_KeyDown(object sender, KeyEventArgs e)
        {
            int i = gridRecords.CurrentRow.Index;

            if (e.KeyCode == Keys.Down && i + 2 <= gridRecords.RowCount)
            {
                i = gridRecords.CurrentRow.Index + 1;
                record.GetPatientRecord(i, gridRecords);
                trans.LoadTransactions(val.RecordID, gridTrans);

            }
            else if (e.KeyCode == Keys.Up && i - 1 >= 0)
            {
                i = gridRecords.CurrentRow.Index - 1;
                record.GetPatientRecord(i, gridRecords);
                trans.LoadTransactions(val.RecordID, gridTrans);
            }

            
            FilterLabResult(0);
            //if (gridRecords.Rows.Count != 0)
            //{
            //    int i = gridRecords.CurrentRow.Index;

            //    if (e.KeyCode == Keys.Down && i + 2 <= gridRecords.RowCount)
            //    {
            //        i = gridRecords.CurrentRow.Index + 1;
            //        record.GetPatientRecord(i, gridRecords);
            //        trans.LoadTransactions(i, gridTrans);

            //    }
            //    else if (e.KeyCode == Keys.Up && i - 1 >= 0)
            //    {
            //        i = gridRecords.CurrentRow.Index - 1;
            //        record.GetPatientRecord(i, gridRecords);
            //        trans.LoadTransactions(i, gridTrans);
            //    }
            //    FilterLabResult(0);
            //}
        }

        private void gridTrans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            trans.GetTransaction(gridTrans.CurrentRow.Index, gridTrans);
            FilterLabResult(gridTrans.CurrentRow.Index);
        }

        private void gridTrans_KeyDown(object sender, KeyEventArgs e)
        {
            int i = gridTrans.CurrentRow.Index;

            if (e.KeyCode == Keys.Down && i + 2 <= gridTrans.RowCount)
            {
                i = gridTrans.CurrentRow.Index + 1;
                trans.GetTransaction(i, gridTrans);

            }
            else if (e.KeyCode == Keys.Up && i - 1 >= 0)
            {
                i = gridTrans.CurrentRow.Index - 1;
                trans.GetTransaction(i, gridTrans);
            }
            FilterLabResult(i);
        }

        private void btnPrintChemistry_Click(object sender, EventArgs e)
        {
            reports.frmReportViewerChemistry report_chemistry = new reports.frmReportViewerChemistry();
            report_chemistry.ShowDialog();
        }

        private void btnPrintHematology_Click(object sender, EventArgs e)
        {
            reports.frmReportViewerHematology report_hematology = new reports.frmReportViewerHematology();
            report_hematology.ShowDialog();
        }
    
        private void btnPrintMisc_Click(object sender, EventArgs e)
        {
            reports.frmReportViewerMiscellaneous report_miscellaneous = new reports.frmReportViewerMiscellaneous();
            report_miscellaneous.ShowDialog();
        }

        private void btnPrintParasitology_Click(object sender, EventArgs e)
        {
            reports.frmReportViewerParasitology report_parasitology = new reports.frmReportViewerParasitology();
            report_parasitology.ShowDialog();

        }

        private void btnPrintUrinalysis_Click(object sender, EventArgs e)
        {
            reports.frmReportViewerUrinalysis report_urinalysis = new reports.frmReportViewerUrinalysis();
            report_urinalysis.ShowDialog();
        }
        
        /// <summary>
        /// Set patient information
        /// </summary>
        private void SetPatienInfo()
        {
            lblFullName.Text = val.PatientFullName;
            lblGender.Text = val.PatientGender;
            lblBirthDate.Text = val.PatientBirthDate.ToString("MM/dd/yyyy");
            lblAge.Text = val.PatientAge.ToString();
            lblAddress.Text = val.PatientAddress;
        }

        /// Chemistry Lab Result Functions and Events 
        /// <summary>
        /// Set chemistry data
        /// </summary>
        private void SetChemistryRecord()
        {
            lblChemStat.Text = val.ChemStat;
            lblChemFasting.Text = val.ChemFastingBloodSugar.ToString();
            lblChemRandom.Text = val.ChemRandomBloodSugar.ToString();
            lblChemPostPrandial.Text = val.ChemPostPrandial.ToString();
            lblChemHBa1c.Text = val.ChemHba1c.ToString();
            lblChemUrea.Text = val.ChemUrea.ToString();
            lblChemCreatinine.Text = val.ChemCreatinine.ToString();
            lblChemUricAcid.Text = val.ChemUricAcid.ToString();
            lblChemCholesterol.Text = val.ChemCholesterol.ToString();
            lblChemTriglycerides.Text = val.ChemTriglycerides.ToString();
            lblChemHDL.Text = val.ChemHdlCholesterol.ToString();
            lblChemLDL.Text = val.ChemLdlCholesterol.ToString();
            lblChemSGOT.Text = val.ChemSgotAst.ToString();
            lblChemSGPT.Text = val.ChemSgptAlt.ToString();
            lblChemSodium.Text = val.ChemSodium.ToString();
            lblChemPotassium.Text = val.ChemPotassium.ToString();
            lblChemCalcium.Text = val.ChemCalcium.ToString();
            lblChemPathologist.Text = val.PatFullName;
            lblChemMedTech.Text = val.MedFullName;
        }

        /// Miscellaneous Lab Result Functions and Events
        /// <summary>
        /// Set miscellaneous data
        /// </summary>
        private void SetMiscellaneousRecord()
        {
            lblMiscExam.Text = val.MiscExam;
            lblMiscSpecimen.Text = val.MiscSpecimen;
            lblMiscResult.Text = val.MiscResult;
            lblMiscRemarks.Text = val.MiscRemarks;
            lblMiscNotes.Text = val.MiscNotes;
            lblMiscOthers.Text = val.MiscOthers;
            lblMiscPathologist.Text = val.PatFullName;
            lblMiscMedTech.Text = val.MedFullName;
        }
        
        /// Parasitology Lab Result Functions and Events         
        /// <summary>
        /// Set Parasitology data
        /// </summary>
        private void SetParasitologyRecord()
        {
            lblParaColor.Text = val.ParaColor;
            lblParaConsistency.Text = val.ParaConsistency;
            lblParaAscaris.Text = val.ParaAscaris.ToString();
            lblParaHookworm.Text = val.ParaHookworm.ToString();
            lblParaTrichuris.Text = val.ParaTrichuris.ToString();
            lblParaStrongyloides.Text = val.ParaStrongyloides.ToString();
            lblParaEnColiCyst.Text = val.ParaEntColiCyst.ToString();
            lblParaEnColiTrop.Text = val.ParaEntColiTrop.ToString();
            lblParaEnHisCyst.Text = val.ParaEntHisCyst.ToString();
            lblParaEnHisTrop.Text = val.ParaEntHisTrop.ToString();
            lblParaPusCell.Text = val.ParaPusCells.ToString();
            lblParaRBC.Text = val.ParaRBC.ToString();
            lblParaYeastCell.Text = val.ParaYeastCell;
            lblParaFatGlobules.Text = val.ParaFatGlobules;
            lblParaBacteria.Text = val.ParaBacteria;
            lblParaResult.Text = val.ParaRemarks;
            lblParaOthers.Text = val.ParaOthers;
            lblParaPathologist.Text = val.PatFullName;
            lblParaMedTech.Text = val.MedFullName;
        }

        /// Urinalysis Lab Result Functions and Events
        /// <summary>
        /// Set Urinalysis data
        /// </summary>
        private void SetUrinalysisRecord()
        {
            lblUriColor.Text = val.UriColor;
            lblUriTrans.Text = val.UriTrans;
            lblUriReaction.Text = val.UriReaction;
            lblUriSpecificGravity.Text = val.UriSpecificGravity;
            lblUriProtein.Text = val.UriProtein;
            lblUriSugar.Text = val.UriSugar;
            lblUriFineGran.Text = val.UriFineGran;
            lblUriCoarseGran.Text = val.UriCoarseGran;
            lblUriPusCell.Text = val.UriPusCellCast;
            lblUriHyaline.Text = val.UriHyaline;
            lblUriRBC.Text = val.UriRBC;
            lblUriPusCells.Text = val.UriPusCells;
            lblUriUricAcid.Text = val.UriUricAcid;
            lblUriCalciumOxalate.Text = val.UriCalciumOxolate;
            lblUriAmorphous.Text = val.UriAmorphous;
            lblUriTripPhosphates.Text = val.UriTriplePhospahtes;
            lblUriSquamous.Text = val.UriSquamous;
            lblUriBacteria.Text = val.UriBacteria;
            lblUriMucous.Text = val.UriMucous;
            lblUriRoundEpi.Text = val.UriRoundEpi;
            lblUriYeastCells.Text = val.UriYeastCells;
            lblUriTriVaginalis.Text = val.UriVaginalis;
            lblUriTriHominis.Text = val.UriHominis;
        }

        /// Urinalysis Lab Result Functions and Events
        /// <summary>
        /// Set Urinalysis data
        /// </summary>
        private void SetHematologyRecord()
        {
            lblHemaHemoglobin.Text = val.HemaHemoglobin;
            lblHemaEryVol.Text = val.HemaEryVol;
            lblHemaEryNum.Text = val.HemaEryNum;
            lblHemaLeukocyte.Text = val.HemaLeukocyte;
            lblHemaBloodType.Text = val.HemaBloodType;
            lblHemaRH.Text = val.HemaRH;
            lblHemaNeutrophil.Text = val.HemaNeutrophil;
            lblHemaSegmenters.Text = val.HemaSegmenters;
            lblHemaStab.Text = val.HemaStab;
            lblHemaEosinophil.Text = val.HemaEosinophil;
            lblHemaBasophil.Text = val.HemaBasophil;
            lblHemaLymphocyte.Text = val.HemaLymphocyte;
            lblHemaMonocyte.Text = val.HemaMonocyte;
            lblHemaTotal.Text = val.HemaTotal;
            lblHemaErySed.Text = val.HemaErySed;
            lblHemaThrombocyte.Text = val.HemaThrombocyte;
            lblHemaBleedingTime.Text = val.HemaBleedingTime;
            lblHemaClottingTime.Text = val.HemaClottingTime;

        }

        // Added functions
        public void CheckPatientRecord()
        {
            if (gridRecords.Rows.Count != 0)
            {
                btnAddTest.Enabled = true;
            }
            else
            {
                btnAddTest.Enabled = false;
            }
        }

        private void FilterLabResult(int row)
        {
            if (gridTrans.Rows.Count != 0)
            {
                if ((int)gridTrans[2, row].Value == 1)
                {
                    chemistry.LoadChemistryRecord(val.TransID);
                    grpChemistry.BringToFront();
                    SetChemistryRecord();
                } else if ((int)gridTrans[2, row].Value == 2)
                {
                    hematology.LoadHematologyRecords(val.TransID);
                    grpHematology.BringToFront();
                    SetHematologyRecord();
                }
                else if ((int)gridTrans[2, row].Value == 3)
                {
                    miscellaneous.LoadMiscRecord(val.TransID);
                    grpMiscellaneous.BringToFront();
                    SetMiscellaneousRecord();   
                }
                else if ((int)gridTrans[2, row].Value == 4)
                {
                    parasitology.LoadParasitologyRecords(val.TransID);
                    grpParasitology.BringToFront();
                    SetParasitologyRecord();
                } else if ((int)gridTrans[2, row].Value == 5)
                {
                    urinalysis.LoadUrinalysisRecord(val.TransID);
                    grpUrinalysis.BringToFront();
                    SetUrinalysisRecord();
                } 
                
            } else
            {
                grpEmpty.BringToFront();
            }
        }

        /// Populate Dropdown Value 
        /// <summary>
        /// Set dropdown values from 2019 to present year
        /// </summary>
        private void PopulateYear()
        {
            int currentYear = DateTime.Now.Year;
            int startingYear = 2019;

            for (int year = currentYear; year >= startingYear; year--)
            {
                cboYear.Items.Add(year.ToString());
            }

            cboYear.SelectedIndex = cboYear.Items.IndexOf(currentYear.ToString());
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            patient.FilterPatientByYear(cboYear.Text, gridPatients);
            originalDataTable = (DataTable)gridPatients.DataSource;
            record.LoadPatientRecords(val.PatientID, gridRecords);
            lblPatientCount.Text = String.Format("Patient Count: {0}", val.PatientCount.ToString());
        }
    }
}
