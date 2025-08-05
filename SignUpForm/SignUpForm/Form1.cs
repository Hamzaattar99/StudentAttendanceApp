//This Form For (Sign Up), it is used for creating password for the first time .
// it appears only once when no password .

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
using System.Drawing.Drawing2D;

namespace SignUpForm
{
    public partial class Form1 : Form
    {
        //To ensure that the file exsits in the specific folder and combine it and assign it string variable
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "secret.txt");

        public Form1()
        {
            InitializeComponent();
            //string pat = AppDomain.CurrentDomain.BaseDirectory;

            //string pp = Directory.GetParent(pat).Parent.Parent.FullName;
            //MessageBox.Show(pp);

            // adding the event of typing in the first TextBox to this method .
            passwordTextBox.OnValueChanged += TxtBoxes_OnValueChanged;

            // adding the event of typing in the second TextBox to this method .
            confirmPassword.OnValueChanged += TxtBoxes_OnValueChanged;
            
            //when opening the form calling this method it edits the shape of the pictureBox to make it circle .
            MakePictureBoxCircular(iconConfirm);

            // When opening the form , by default the (save) button is unenabled and hidden .
            bunifuThinButton21.Visible = false;
            bunifuThinButton21.Enabled = false;

        }

        // This function is (static) used without object . For getting the path of the project , out of (bin) and (Debug) folders .
        public static string GetFolderRoot()
        {
            // Represents the domain of the project folder (current folder) in other words, the place where the program executes .
            string path = AppDomain.CurrentDomain.BaseDirectory; // (BaseDirectory) --> gets the full path where program executes  ... (\bin\Debug)


            //Gets the parent folder from the current path - (Parent.Parent) --> used twice to get back from (Debug) then (bin)
            string projectPath = Directory.GetParent(path).Parent.Parent.FullName; // (FullName --> Gets the full path in string form instead of (DirectoryInfo) ... for example --> (C:\MyProject)


            return projectPath;
        }


        // this method to make the pictureBox circle .
        private void MakePictureBoxCircular(PictureBox pic)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddEllipse(0, 0, pic.Width - 1, pic.Height - 1);

            pic.Region = new Region(gp);
        }


        // this has the 2 events of the 2 textBoxes .
        private void TxtBoxes_OnValueChanged(object sender, EventArgs e)
        {
            CheckPasswordLength(); // Method to check the length of the password when typing .
            CheckPasswordsMatch(); // Method to check if the confirmation textBox equals the password textBox .
        }


        // Method to check the length of the password when typing .
        private void CheckPasswordLength()
        {
            string password = passwordTextBox.Text.Trim(); // assigns the password from the textBox to a variable without white spaces and \n and \t .

            if(password.Length < 6)  // checks if the password has less than 6 letters .. if yes then :
            {
               // Shows an error provider icon .
                errorProvider1.SetError(passwordTextBox, "Password Must Be at Least 6 Characters."); 
            }

            else // otherwise :
            {
                // Hides the error provider icon .
                errorProvider1.SetError(passwordTextBox, "");
            }
        }


        // Method to check if the confirmation textBox equals the password textBox .
        private void CheckPasswordsMatch()
        {
             string pass = passwordTextBox.Text; // geting the password from the first textBox and assign it to a variable .
             string confirm = confirmPassword.Text; // geting the password from the second textBox and assign it to a variable .

             try // Error handling specially for file errors ! .
             {



                 if (string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(confirm)) // if the 2 textBoxes are empty or has white spaces the disactivate the (save) button and hide it .
                 {
                     iconConfirm.Visible = false; // hides the (x) icon
                     bunifuThinButton21.Enabled = false;
                     bunifuThinButton21.Visible = false;


                 }
                 //assigning the path for the photos .
                 string CurrentPath = Path.Combine(GetFolderRoot(), "Resources/icons/");


                 // this Comment was a mistake about getting the full path of the project
                // string basePath = "D:/IT4/projects/attendence_system/SignUpForm/SignUpForm/Resources/icons/";


                 if (pass == confirm && !string.IsNullOrWhiteSpace(pass) && !string.IsNullOrWhiteSpace(confirm)) // if 2 textBoxes are equal and none of them has white space then :
                 {
                     // assigning the photo icon to the pictureBox and shows the (correct) icon
                     iconConfirm.Image = Image.FromFile(CurrentPath + "accept.png");
                     iconConfirm.Visible = true;
                     // shows the (save) button and enable it
                     bunifuThinButton21.Visible = true; 
                     bunifuThinButton21.Enabled = true;

                 }

                 else // otherwise :
                 { // assigning the (x) icon to the pictureBox and shows it .
                     iconConfirm.Image = Image.FromFile(CurrentPath + "remove.png");
                     iconConfirm.Visible = true;

                     // Hides the (save) button and disenable it
                     bunifuThinButton21.Visible = false;
                     bunifuThinButton21.Enabled = false;

                 }

             }

            catch(Exception ex) // if it had an error it catches it and shows a message .
             {
                 MessageBox.Show(ex.ToString());
             }
        }


        //Clicking the Exit Button :
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
            // Nothing Here ...
        }


        // This Function does not work !!!!!!!!
        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("This is the first time to open this program. Therefore, you have to create new password for you\n-This creation occur only once .", "First Opening", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // Clicking the (Save) button :
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            LoginForm obj = new LoginForm(); // Creating an object to open the (Login) form after finishing work here ...

            string pass = passwordTextBox.Text; // assigns and gets the password
            string hashedPass = ComputeSha256Hash(pass); //gets the hashed password from a method


            try // For Error Handling : 
            {
                File.WriteAllText(filePath, hashedPass); //it writes all the text to the file in the path or create it if does not exist .
                File.SetAttributes(filePath, FileAttributes.Hidden); // Sets the attributes of the file to (hidden)

                MessageBox.Show("Password Hashed and Saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); // it shows a message if it is successfully login .

                // Returning every thing to default :
                passwordTextBox.Text = ""; // return it to empty
                confirmPassword.Text = ""; // return it to empty
                // returns them to disabled and hidden
                iconConfirm.Visible = false;
                bunifuThinButton21.Enabled = false;
                bunifuThinButton21.Visible = false;

                // Then : it hides the current form after that it shows the (Login) form to enter the password that you created .
                this.Hide();
                obj.Show();

            }

            catch (Exception ex) // if the file already exsists then show a message about that .
            {
                MessageBox.Show("The password already exixts! . Try to login :" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }


        }

        // This public method is getter for the hashed password .
        public string getHashedPassword(string password)
        {
            string HashedPass = ComputeSha256Hash(password); // calls the hashing method and returns the hashed password .


            return HashedPass; // Returns the hashed password to anywhere it called this method .
        }


        // This Method hashes the password :
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256 = SHA256.Create()) // Creating an object from this kind of hashing .
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData)); // sending the password and change it to bytes and assign to array of bytes .

                StringBuilder builder = new StringBuilder(); // Creating a string builder object 

                foreach (byte b in bytes) // it is used to make one counter goes through the array of bytes 
                    builder.Append(b.ToString("x2")); // and every time it appends the single byte (x2) .

                return builder.ToString(); // then converting the string builder to a normal string and return it .
            }
        }
    }
}
