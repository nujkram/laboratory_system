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
    public partial class frmUpdateHematology : MetroFramework.Forms.MetroForm
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        functions.Hematology hematology = new functions.Hematology();
        functions.Profile profile = new functions.Profile();

        public frmUpdateHematology()
        {
            InitializeComponent();
        }

        private void frmUpdateHematology_Load(object sender, EventArgs e)
        {
            lblDate.Text = String.Format("Date: {0}", DateTime.Now);
            lblName.Text = String.Format("Full Name: {0}", val.PatientFullName);
            lblRequest.Text = String.Format("Requested by: {0}", val.RecordRequest);
            lblCase.Text = String.Format("Case No.: {0}", val.RecordCase);
            lblAge.Text = String.Format("Age: {0}", val.PatientAge);
            lblGender.Text = String.Format("Gender: {0}", val.PatientGender);
            profile.LoadPathologist(cboPathologist);
            profile.LoadMedTech(cboMedTech);
            txtExam.Text = val.HemaExam;
            txtStat.Text = val.HemaStat;
            txtHemoglobin.Text = val.HemaHemoglobin;
            txtEryVol.Text = val.HemaEryVol;
            txtEryNum.Text = val.HemaEryNum;
            txtLeukocyte.Text = val.HemaLeukocyte;
            txtBloodType.Text = val.HemaBloodType;
            txtRH.Text = val.HemaRH;
            txtNeutrophil.Text = val.HemaNeutrophil;
            txtSegmenters.Text = val.HemaSegmenters;
            txtStab.Text = val.HemaStab;
            txtEosinophil.Text = val.HemaEosinophil;
            txtBasophil.Text = val.HemaBasophil;
            txtLymphocyte.Text = val.HemaLymphocyte;
            txtMonocyte.Text = val.HemaMonocyte;
            txtTotal.Text = val.HemaTotal;
            txtErySed.Text = val.HemaErySed;
            txtThrombocyte.Text = val.HemaThrombocyte;
            txtBleedingTime.Text = val.HemaBleedingTime;
            txtClottingTime.Text = val.HemaClottingTime;
            txtOthers.Text = val.HemaOthers;
            cboPathologist.SelectedIndex = cboPathologist.FindStringExact(String.Format("{0} {1}", val.PatFirstName, val.PatLastName));
            cboMedTech.SelectedIndex = cboMedTech.FindStringExact(String.Format("{0} {1}", val.MedFirstName, val.MedLastName));

        }

        private void txtHemoglobin_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetNumbersOnly(txtHemoglobin, e);
        }

        private void txtEryVol_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetNumbersOnly(txtEryVol, e);
        }

        private void txtEryNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetNumbersOnly(txtEryNum, e);
        }

        private void txtLeukocyte_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetNumbersOnly(txtLeukocyte, e);
        }

        private void txtNeutrophil_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetNumbersOnly(txtNeutrophil, e);
        }

        private void txtSegmenters_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetNumbersOnly(txtSegmenters, e);
        }

        private void txtStab_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetNumbersOnly(txtStab, e);
        }

        private void txtEosinophil_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetNumbersOnly(txtEosinophil, e);
        }

        private void txtBasophil_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetNumbersOnly(txtBasophil, e);
        }

        private void txtLymphocyte_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetNumbersOnly(txtLymphocyte, e);
        }

        private void txtMonocyte_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetNumbersOnly(txtMonocyte, e);
        }

        private void txtErySed_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetNumbersOnly(txtErySed, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (hematology.UpdateHematology(val.HemaID, txtExam.Text, txtStat.Text, txtHemoglobin.Text, txtEryVol.Text, txtEryNum.Text,
                txtLeukocyte.Text, txtBloodType.Text, txtRH.Text, txtNeutrophil.Text, txtSegmenters.Text, txtStab.Text, txtEosinophil.Text,
                txtBasophil.Text, txtLymphocyte.Text, txtMonocyte.Text, txtTotal.Text, txtErySed.Text, txtThrombocyte.Text, 
                txtBleedingTime.Text, txtClottingTime.Text, txtOthers.Text, val.PatID, val.MedID))
            {
                MetroFramework.MetroMessageBox.Show(this, "Hematology record updated!",
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '*')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && txt.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
