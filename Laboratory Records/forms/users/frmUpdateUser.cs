using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_Records.forms.users
{
    public partial class frmUpdateUser : MetroFramework.Forms.MetroForm
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        functions.Profile profile = new functions.Profile();
        int user_level;
        bool is_active;

        public frmUpdateUser()
        {
            InitializeComponent();
        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            txtTitle.Text = val.ProfileTitle;
            txtFirstName.Text = val.ProfileFirstName;
            txtMiddleName.Text = val.ProfileMiddleName;
            txtLastName.Text = val.ProfileLastName;
            txtLicense.Text = val.ProfileLicenseNo;
            is_active = val.UserActive;

            if (val.UserActive == true)
            {
                chkIsActive.Checked = true;
            }
            else
            {
                chkIsActive.Checked = false;
            }

            if (val.UserLevel == 145)
            {
                cboUserType.SelectedIndex = 1;
            }
            else
            {
                cboUserType.SelectedIndex = 0;
            }
        }

        private void cboUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUserType.Text == "Pathologist")
            {
                user_level = 145;
            }
            else
            {
                user_level = 184;
            }
        }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine(chkIsActive.CheckState.ToString());
            if (chkIsActive.CheckState == CheckState.Checked)
            {
                is_active = true;
            }
            else
            {
                is_active = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (profile.UpdateProfile(val.ProfileID, user_level, is_active, txtLicense.Text, txtTitle.Text, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text)) {
                MetroFramework.MetroMessageBox.Show(this, "User updated!",
                       "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
            }
        }
    }
}
