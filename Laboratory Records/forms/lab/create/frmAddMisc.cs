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
    public partial class frmAddMisc : MetroFramework.Forms.MetroForm
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        functions.Miscellaneous miscellaneous = new functions.Miscellaneous();
        functions.Profile profile = new functions.Profile();

        public frmAddMisc()
        {
            InitializeComponent();
        }

        private void frmAddMisc_Load(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(miscellaneous.AddMiscRecord(val.RecordID, val.LabID, cboExamDesired.Text, txtSpecimen.Text, txtResult.Text, txtRemarks.Text, txtNotes.Text, val.PatID, val.MedID))
            {
                MetroFramework.MetroMessageBox.Show(this, "Miscellaneous record saved!",
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

        private void cboExamDesired_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboExamDesired.Text)
            {
                case "Anti - HAV":
                    txtRemarks.Visible = true;
                    txtNotes.Visible = false;
                    txtResult.WaterMark = "IgM";
                    txtRemarks.WaterMark = "IgG";
                    break;
                case "Anti - HBs":
                    txtRemarks.Visible = false;
                    txtNotes.Visible = false;
                    txtResult.WaterMark = "Result";
                    break;
                case "ASOT":
                    txtRemarks.Visible = false;
                    txtNotes.Visible = false;
                    txtResult.WaterMark = "Result";
                    break;
                case "CRP":
                    txtRemarks.Visible = false;
                    txtNotes.Visible = false;
                    txtResult.WaterMark = "Result";
                    break;
                case "Dengue Duo":
                    txtRemarks.Visible = true;
                    txtNotes.Visible = true;
                    txtResult.WaterMark = "NS1";
                    txtRemarks.WaterMark = "IgM";
                    txtNotes.WaterMark = "IgG";
                    break;
                case "Gram's Stain":
                    txtRemarks.Visible = false;
                    txtNotes.Visible = false;
                    txtResult.WaterMark = "Result";
                    break;
                case "HBsAg":
                    txtRemarks.Visible = false;
                    txtNotes.Visible = false;
                    txtResult.WaterMark = "Result";
                    break;
                case "H.Pylori":
                    txtRemarks.Visible = false;
                    txtNotes.Visible = false;
                    txtResult.WaterMark = "Result";
                    break;
                case "KOH":
                    txtRemarks.Visible = false;
                    txtNotes.Visible = false;
                    txtResult.WaterMark = "Result";
                    break;
                case "Pregnancy Test":
                    txtRemarks.Visible = false;
                    txtNotes.Visible = false;
                    txtResult.WaterMark = "Result";
                    break;
                case "RPR":
                    txtRemarks.Visible = false;
                    txtNotes.Visible = false;
                    txtResult.WaterMark = "Result";
                    break;
            }
        }
    }
}
