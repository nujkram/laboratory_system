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
    public partial class frmLabMenu : MetroFramework.Forms.MetroForm
    {
        functions.Laboratory lab = new functions.Laboratory();

        public frmLabMenu()
        {
            InitializeComponent();
        }

        private void frmLabMenu_Load(object sender, EventArgs e)
        {

        }

        private void tileChemistry_Click(object sender, EventArgs e)
        {
            lab.GetLaboratoryType("Chemistry");
            frmAddChemistry add_chem = new frmAddChemistry();
            add_chem.ShowDialog();
        }

        private void tileUrinalysis_Click(object sender, EventArgs e)
        {
            lab.GetLaboratoryType("Urinalysis");
            frmAddUrinalysis add_uri = new frmAddUrinalysis();
            add_uri.ShowDialog();
        }

        private void tileHematology_Click(object sender, EventArgs e)
        {
            lab.GetLaboratoryType("Hematology");
            frmAddHematology add_hema = new frmAddHematology();
            add_hema.ShowDialog();
        }

        private void tileParasitology_Click(object sender, EventArgs e)
        {
            lab.GetLaboratoryType("Parasitology");
            frmAddParasitology add_para = new frmAddParasitology();
            add_para.ShowDialog();
        }

        private void tileMisc_Click(object sender, EventArgs e)
        {
            lab.GetLaboratoryType("Miscellaneous");
            frmAddMisc add_misc = new frmAddMisc();
            add_misc.ShowDialog();
        }
    }
}
