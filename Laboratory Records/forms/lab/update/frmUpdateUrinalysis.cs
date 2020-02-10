using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_Records.forms.lab.update
{
    public partial class frmUpdateUrinalysis : MetroFramework.Forms.MetroForm
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        functions.Urinalysis urinalysis = new functions.Urinalysis();
        functions.Profile profile = new functions.Profile();

        public frmUpdateUrinalysis()
        {
            InitializeComponent();
        }

        private void frmUpdateUrinalysis_Load(object sender, EventArgs e)
        {
            lblDate.Text = String.Format("Date: {0}", DateTime.Now);
            lblName.Text = String.Format("Full Name: {0}", val.PatientFullName);
            lblRequest.Text = String.Format("Requested by: {0}", val.RecordRequest);
            lblCase.Text = String.Format("Case No.: {0}", val.RecordCase);
            lblAge.Text = String.Format("Age: {0}", val.PatientAge);
            lblGender.Text = String.Format("Gender: {0}", val.PatientGender);
            profile.LoadPathologist(cboPathologist);
            profile.LoadMedTech(cboMedTech);

            txtExamDesired.Text = val.UriExam;
            txtColor.Text = val.UriColor;
            txtTransparency.Text = val.UriTrans;
            txtReaction.Text = val.UriReaction;
            txtSpecificGravity.Text = val.UriSpecificGravity;
            txtProtein.Text = val.UriProtein;
            txtSugar.Text = val.UriSugar;
            txtFineGran.Text = val.UriFineGran;
            txtCoarseGran.Text = val.UriCoarseGran;
            txtPusCellCast.Text = val.UriPusCellCast;
            txtHyaline.Text = val.UriHyaline;
            txtRBC.Text = val.UriRBC;
            txtPusCells.Text = val.UriPusCells;
            txtUricAcid.Text = val.UriUricAcid;
            txtCalciumOxalate.Text = val.UriCalciumOxolate;
            txtAmorphous.Text = val.UriAmorphous;
            txtTriplePhosphates.Text = val.UriTriplePhospahtes;
            txtSquamous.Text = val.UriSquamous;
            txtBacteria.Text = val.UriBacteria;
            txtMucous.Text = val.UriMucous;
            txtRoundEpithelia.Text = val.UriRoundEpi;
            txtYeastCells.Text = val.UriYeastCells;
            txtVaginalis.Text = val.UriVaginalis;
            txtHominis.Text = val.UriHominis;
            cboPathologist.SelectedIndex = cboPathologist.FindStringExact(String.Format("{0} {1}", val.PatFirstName, val.PatLastName));
            cboMedTech.SelectedIndex = cboMedTech.FindStringExact(String.Format("{0} {1}", val.MedFirstName, val.MedLastName));
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (urinalysis.UpdateUrinalysis(val.UriID, txtExamDesired.Text, txtColor.Text, txtTransparency.Text, txtReaction.Text,
                txtSpecificGravity.Text, txtProtein.Text, txtSugar.Text, txtFineGran.Text,txtCoarseGran.Text, txtPusCellCast.Text,
                txtHyaline.Text, txtRBC.Text, txtPusCells.Text, txtUricAcid.Text, txtCalciumOxalate.Text, txtAmorphous.Text,
                txtTriplePhosphates.Text, txtSquamous.Text,txtBacteria.Text, txtMucous.Text,txtRoundEpithelia.Text, txtYeastCells.Text,
                txtVaginalis.Text, txtHominis.Text, val.PatID, val.MedID))
            {
                MetroFramework.MetroMessageBox.Show(this, "Urinalysis record updated!",
                   "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void cboPathologist_SelectionChangeCommitted(object sender, EventArgs e)
        {
            profile.GetPathologistProfile(int.Parse(cboPathologist.SelectedValue.ToString()));
        }

        private void cboMedTech_SelectionChangeCommitted(object sender, EventArgs e)
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
