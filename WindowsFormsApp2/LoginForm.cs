using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class LoginForm : Form
    {
        private readonly UserManager _userManager;
        public User AuthenticatedUser { get; private set; }

        public LoginForm(UserManager userManager)
        {
            _userManager = userManager;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            var user = _userManager.Authenticate(username, password);

            if (user != null)
            {
                AuthenticatedUser = user;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                lblError.Visible = true;
            }
        }
    }
}
