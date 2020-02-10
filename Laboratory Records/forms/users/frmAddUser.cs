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
    public partial class frmAddUser : MetroFramework.Forms.MetroForm
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        functions.User user = new functions.User();
        int user_level;
        bool is_valid = false;

        public frmAddUser()
        {
            InitializeComponent();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboUserType.Text == "Pathologist") {
                user_level = 145;
            } else {
                user_level = 184;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CheckPassword();
            if (is_valid == true)
            {
                if (user.AddUser(txtUsername.Text, txtPassword.Text, user_level, txtFirstName.Text,
                txtMiddleName.Text, txtLastName.Text, txtTitle.Text, txtLicense.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "User saved!",
                       "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
        }

        private void CheckPassword()
        {
            if (txtPassword.Text == txtConfirmPass.Text)
            {
                is_valid = true;
            }
            else
            {
                is_valid = false;
                MetroFramework.MetroMessageBox.Show(this, "Password doesn't match!",
                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
            }
        }
    }
}
