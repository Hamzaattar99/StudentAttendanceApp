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
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            try
            {
                InitializeComponent();
            }

            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // an object to take the answer (Yes/No) from messageBox
            DialogResult YesNoResult = MessageBox.Show("Are You Sure!? You Want to Exit ?", "Eixt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (YesNoResult == DialogResult.Yes) // checks if chose Yes it will get out of the program
            {
                Application.Exit(); // Exits from whole program and all Forms .
            }
        }


        private void LoadUserControl(UserControl userControl)
        {
            panel1.Controls.Clear();

            userControl.Dock = DockStyle.Fill;

            panel1.Controls.Add(userControl);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadUserControl(new HomeControl());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new SubjectsControl());
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ReportsControl());
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new StudentsControl());
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AttendanceControl());
        }

    
    }
}
