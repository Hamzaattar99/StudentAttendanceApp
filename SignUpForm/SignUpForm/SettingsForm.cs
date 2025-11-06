using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpForm
{
    public partial class SettingsForm : Form
    {
        private string currentUser;
        public SettingsForm(string username)
        {
            InitializeComponent();
            currentUser = username;
        }


        private void LoadUserControl(UserControl userControl)
        {
            panel1.Controls.Clear();

            userControl.Dock = DockStyle.Fill;

            panel1.Controls.Add(userControl);
        }


        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ChangePasswordControl1(currentUser));
        }

        private void usernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ChangeUsernameControl1());
        }
    }
}
