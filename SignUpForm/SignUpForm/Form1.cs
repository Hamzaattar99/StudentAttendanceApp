using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace SignUpForm
{
    public partial class Form1 : Form
    {
        //
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "secret.txt");

        public Form1()
        {
            InitializeComponent();


            passwordTextBox.OnValueChanged += TxtBoxes_OnValueChanged;

            confirmPassword.OnValueChanged += TxtBoxes_OnValueChanged;

            MakePictureBoxCircular(iconConfirm);

            bunifuThinButton21.Visible = false;
            bunifuThinButton21.Enabled = false;

        }


        private void MakePictureBoxCircular(PictureBox pic)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddEllipse(0, 0, pic.Width - 1, pic.Height - 1);

            pic.Region = new Region(gp);
        }


        private void TxtBoxes_OnValueChanged(object sender, EventArgs e)
        {
            CheckPasswordsMatch();
        }

        private void CheckPasswordsMatch()
        {
             string pass = passwordTextBox.Text;
             string confirm = confirmPassword.Text;

             try
             {



                 if (string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(confirm))
                 {
                     iconConfirm.Visible = false;
                     bunifuThinButton21.Enabled = false;
                     bunifuThinButton21.Visible = false;


                 }

                 string basePath = "D:/IT4/projects/attendence_system/SignUpForm/SignUpForm/Resources/icons/";


                 if (pass == confirm && !string.IsNullOrWhiteSpace(pass) && !string.IsNullOrWhiteSpace(confirm))
                 {
                     iconConfirm.Image = Image.FromFile(basePath + "accept.png");
                     iconConfirm.Visible = true;
                     bunifuThinButton21.Visible = true;
                     bunifuThinButton21.Enabled = true;

                 }

                 else
                 {
                     iconConfirm.Image = Image.FromFile(basePath + "remove.png");
                     iconConfirm.Visible = true;
                     bunifuThinButton21.Visible = false;
                     bunifuThinButton21.Enabled = false;

                 }

             }

            catch(Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            DialogResult YesNoResult = MessageBox.Show("Are You Sure!? You Want to Exit ?", "Eixt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (YesNoResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("This is the first time to open this program. Therefore, you have to create new password for you\n-This creation occur only once .", "First Opening", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string pass = passwordTextBox.Text;
            string hashedPass = ComputeSha256Hash(pass);


            try
            {
                File.WriteAllText(filePath, hashedPass);
                File.SetAttributes(filePath, FileAttributes.Hidden);

                MessageBox.Show("Password Hashed and Saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                passwordTextBox.Text = "";
                confirmPassword.Text = "";
                iconConfirm.Visible = false;
                bunifuThinButton21.Enabled = false;
                bunifuThinButton21.Visible = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show("The password already exixts! . Try to login :" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }


        }

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));

                return builder.ToString();
            }
        }
    }
}
