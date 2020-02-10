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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        components.Values val = new components.Values();
        functions.Login login = new functions.Login();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Do you want to logout?",
                    "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                val.Username = null;
                login.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (login.AuthenticateUser(txtUsername.Text, txtPassword.Text))
            {
                this.Hide();
                forms.frmDashboard dashboard = new forms.frmDashboard();
                dashboard.FormClosing += new FormClosingEventHandler(Dashboard_FormClosing);
                dashboard.Show();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Incorrect username or password",
                   "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}
