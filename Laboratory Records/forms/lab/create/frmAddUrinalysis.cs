using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_Records.forms.lab
{
    public partial class frmAddUrinalysis : MetroFramework.Forms.MetroForm
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        functions.Urinalysis urinalysis = new functions.Urinalysis();
        functions.Profile profile = new functions.Profile();

        public frmAddUrinalysis()
        {
            InitializeComponent();
        }

        private void frmAddUrinalysis_Load(object sender, EventArgs e)
        {
            lblDate.Text = String.Format("Date: {0}", DateTime.Now);
            lblName.Text = String.Format("Full Name: {0}", val.PatientFullName);
            lblRequest.Text = String.Format("Requested by: {0}", val.RecordRequest);
            lblCase.Text = String.Format("Case No.: {0}", val.RecordCase);
            lblAge.Text = String.Format("Age: {0}", val.PatientAge);
            lblGender.Text = String.Format("Gender: {0}", val.PatientGender);
            profile.LoadPathologist(cboPathologist);
            profile.LoadMedTech(cboMedTech);
        }

        private void txtReaction_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetNumbersOnly(txtReaction, e);
        }

        private void txtSpecificGravity_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetNumbersOnly(txtSpecificGravity, e);
        }

        private void txtFineGran_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void txtCoarseGran_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void txtPusCellCast_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void txtHyaline_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (urinalysis.AddUrinalysisRecord(val.RecordID, val.LabID, txtExamDesired.Text, txtColor.Text, txtTransparency.Text, txtReaction.Text,
                txtSpecificGravity.Text, txtProtein.Text, txtSugar.Text, txtFineGran.Text, txtCoarseGran.Text, txtPusCellCast.Text, txtHyaline.Text, 
                txtRBC.Text, txtPusCells.Text, txtUricAcid.Text, txtCalciumOxalate.Text, txtAmorphous.Text, txtTriplePhosphates.Text, 
                txtSquamous.Text, txtBacteria.Text, txtMucous.Text, txtRoundEpithelia.Text, txtYeastCells.Text, txtVaginalis.Text, 
                txtHominis.Text, val.PatID, val.MedID))
            {
                MetroFramework.MetroMessageBox.Show(this, "Urinalysis record saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void cboPathologist_SelectedIndexChanged(object sender, EventArgs e)
        {
            profile.GetPathologistProfile(int.Parse(cboPathologist.SelectedValue.ToString()));
        }

        private void cboMedTech_SelectedIndexChanged(object sender, EventArgs e)
        {
            profile.GetMedTechProfile(int.Parse(cboMedTech.SelectedValue.ToString()));
        }

        // Added functions
        public void SetNumbersOnly(MetroFramework.Controls.MetroTextBox txt, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txt.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
