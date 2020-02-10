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
    public partial class frmAddRecord : MetroFramework.Forms.MetroForm
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        functions.Record record = new functions.Record();

        public frmAddRecord()
        {
            InitializeComponent();
        }

        private void frmAddRecord_Load(object sender, EventArgs e)
        {
            lblDate.Text = String.Format("Date: {0}", DateTime.Now);
            lblName.Text = String.Format("Full Name: {0}", val.PatientFullName);
            lblAge.Text = String.Format("Age: {0}", val.PatientAge);
            lblGender.Text = String.Format("Gender: {0}", val.PatientGender);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (record.CheckCaseNo(val.PatientID, int.Parse(txtCase.Text)))
            {
                lab.frmLabMenu lab_menu = new lab.frmLabMenu();
                record.AddPatientRecord(val.PatientID, txtRequest.Text, int.Parse(txtCase.Text));
                MetroFramework.MetroMessageBox.Show(this, "Patient record saved!",
                   "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                lab_menu.ShowDialog();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Case number already exist!",
                   "Record Exist!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCase.Focus();
            }
            
        }
    }
}
