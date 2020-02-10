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
    public partial class frmUsers : MetroFramework.Forms.MetroForm
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        functions.User user = new functions.User();
        functions.Profile profile = new functions.Profile();

        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            user.LoadUsers(gridUsers);
            profile.GetUserProfile(0);
            SetProfile();
        }

        private void frmUsers_Activated(object sender, EventArgs e)
        {
            user.LoadUsers(gridUsers);
            profile.GetUserProfile(0);
            SetProfile();
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            user.SearchUser(txtKeyword.Text, gridUsers);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUser add_user = new frmAddUser();
            add_user.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateUser update_user = new frmUpdateUser();
            update_user.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            user.GetUserDetail(gridUsers.CurrentRow.Index, gridUsers);
            profile.GetUserProfile(val.UserID);
            SetProfile();
        }

        private void gridUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (gridUsers.Rows.Count != 0)
            {
                int i = gridUsers.CurrentRow.Index;

                if (e.KeyCode == Keys.Down && i + 2 <= gridUsers.RowCount)
                {
                    i = gridUsers.CurrentRow.Index + 1;
                    user.GetUserDetail(i, gridUsers);
                    profile.GetUserProfile(val.UserID);
                    SetProfile();

                }
                else if (e.KeyCode == Keys.Up && i - 1 >= 0)
                {
                    i = gridUsers.CurrentRow.Index - 1;
                    user.GetUserDetail(i, gridUsers);
                    profile.GetUserProfile(val.UserID);
                    SetProfile();
                }
            }
        }

        private void SetProfile()
        {
            lblFullName.Text = val.ProfileFullName;
            lblTitle.Text = val.ProfileTitle;
            lblLicense.Text = val.ProfileLicenseNo;
            lblActive.Text = val.UserStatus;
            lblUsername.Text = val.Username;
            lblUserType.Text = val.UserType;
        }
    }
}
