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
    public partial class frmAddParasitology : MetroFramework.Forms.MetroForm
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        functions.Parasitology parasitology = new functions.Parasitology();
        functions.Profile profile = new functions.Profile();

        public frmAddParasitology()
        {
            InitializeComponent();
        }

        private void frmAddParasitology_Load(object sender, EventArgs e)
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

        private void txtAscaris_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void txtHookworm_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void txtTrichuris_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void txtStrongyloides_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void txtEntaColiCyst_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void txtEntaColiTrop_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void txtEntaHisCyst_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void txtEntaHisTrop_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void txtPusCell_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void txtRBC_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (parasitology.AddParasitologyRecord(val.RecordID, val.LabID, txtColor.Text, txtConsistency.Text, txtAscaris.Text,
                txtHookworm.Text, txtTrichuris.Text, txtStrongyloides.Text, txtEntaColiCyst.Text, txtEntaColiTrop.Text, txtEntaHisCyst.Text, 
                txtEntaHisTrop.Text, txtPusCell.Text, txtRBC.Text, txtYeastCell.Text, txtFatGlobules.Text, txtBacteria.Text, txtRemarks.Text, 
                txtOthers.Text, val.PatID, val.MedID))
            {
                MetroFramework.MetroMessageBox.Show(this, "Parasitology record saved!",
                   "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
