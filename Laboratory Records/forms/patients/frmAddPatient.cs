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
    public partial class frmAddPatient : MetroFramework.Forms.MetroForm
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        functions.Patient patient = new functions.Patient();

        public frmAddPatient()
        {
            InitializeComponent();
        }

        private void frmAddPatientcs_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime? d = null;
            DateTime d2;
            bool success = DateTime.TryParse(txtBirthDate.Text, out d2);
            if (success) d = d2;
            if (string.IsNullOrEmpty(txtAge.Text))
            {
                txtAge.Text = "0";
            }


            if (patient.AddPatient(txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, cboGender.Text, d2, int.Parse(txtAge.Text), txtAddress.Text))
            {
                records.frmAddRecord add_record = new records.frmAddRecord();
                MetroFramework.MetroMessageBox.Show(this, "Patient record saved!",
                   "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                add_record.ShowDialog();
            }
        }

        private void txtBirthDate_TextChanged(object sender, EventArgs e)
        {
            DateTime temp;
            DateTime now = DateTime.Now;
            
            if (DateTime.TryParse(txtBirthDate.Text, out temp))
            {
                int age = 0;
                age = DateTime.Now.Year - DateTime.Parse(txtBirthDate.Text).Year;

                if (DateTime.Now.DayOfYear < DateTime.Parse(txtBirthDate.Text).DayOfYear)
                    age = age - 1;

                txtAge.Text = age.ToString();
            }
            else
            {
                txtAge.Text = "0";
            }
        }
    }
}
