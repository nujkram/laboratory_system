using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_Records.forms
{
    public partial class frmDashboard : MetroFramework.Forms.MetroForm
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void tilePatients_Click(object sender, EventArgs e)
        {
            patients.frmPatients patients = new patients.frmPatients();
            patients.ShowDialog();
        }

        private void tileAddPatient_Click(object sender, EventArgs e)
        {

        }

        private void tileUsers_Click(object sender, EventArgs e)
        {
            users.frmUsers users = new users.frmUsers();
            users.ShowDialog();
        }

        private void tileProfile_Click(object sender, EventArgs e)
        {

        }

        private void tileReport_Click(object sender, EventArgs e)
        {
            records.frmRecords rec = new records.frmRecords();
            rec.ShowDialog();
        }
    }
}
