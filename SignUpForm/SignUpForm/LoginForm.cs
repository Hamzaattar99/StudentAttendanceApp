// This the login Form, it is used for entering the password if it exists before .

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

namespace SignUpForm
{
    public partial class LoginForm : Form
    {
        //To ensure that the file exsits in the specific folder and combine it and assign it string variable
      private  string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "secret.txt");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void iconConfirm_Click(object sender, EventArgs e)
        {
            //Nothing Here .....
        }

        // Clicking (Login) Button will do :
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            // Taking the password from the user from the TextBox and assigned to a string variable .
            string pass = passwordTextBox.Text;
            //Crating an object to get the hashed password from it
            Form1 obj = new Form1();
            //using the object to call the public the method from (Form1) and send the password to hash it and retrun the hashed password and assign to a variable .
            string hashedPass = obj.getHashedPassword(pass);


              if(!File.Exists(filePath)) // check if the exsits 
              {
                  MessageBox.Show("The File Not Exists!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // it show a message
                  return; // get out and stop from comparing and other opearations because no file ...
              }

            // if the file exists then will execute these below ..

              string storedHashedPassword = File.ReadAllText(filePath).Trim(); // it reads all the text in the file and deletes the white spaces and \n and \t
              
            //To check the equality between the stored password and the entered password
            // StringCompariosn.[Ordinal - OrdinalIgnoreCase -CurrenCulture - InvariantCultureIgnoreCase] options .
            if(hashedPass.Equals(storedHashedPassword, StringComparison.OrdinalIgnoreCase))
            {
                // if equal then :
                errorProvider1.SetError(passwordTextBox, ""); // hiding the error provider icon
                MessageBox.Show("Login is Done Successfully!", "Passed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); // showing a message
            }

            else // otherwise :
            {
                errorProvider1.SetError(passwordTextBox, "Wrong Password Entered!!"); //Showing the error provider icon
                MessageBox.Show("Password is Wrong!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); // Showing a message
            }
              


        }

        
        // clicking Exit Button :
        private void exitButton_Click(object sender, EventArgs e)
        {
            // an object to take the answer (Yes/No) from messageBox
            DialogResult YesNoResult = MessageBox.Show("Are You Sure!? You Want to Exit ?", "Eixt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (YesNoResult == DialogResult.Yes) // checks if chose Yes it will get out of the program
            {
                Application.Exit(); // Exits from whole program and all Forms .
            }
        }

        // Changeing the Color of the side Panel :
        private void panelBackground_MouseHover(object sender, EventArgs e)
        {
            // it change the color of the panel when moves the mouse on it ...
            panelBackground.BackColor = Color.LightSeaGreen; // background To ......
            panelBackground.ForeColor = Color.White; // background To ......
        }

        private void panelBackground_MouseLeave(object sender, EventArgs e)
        { // it returns the colors to the last colors when is leaves the panel using the mouse .
            panelBackground.BackColor = Color.WhiteSmoke; // background To ......
            panelBackground.ForeColor = Color.Black;  // background To ......
        }


        // before opening (Login Form ) these happen :
        private void LoginForm_Load(object sender, EventArgs e) 
        {
            Form1 obj = new Form1(); // Creating an object from (Sign Up ) form to open it .


            if (!File.Exists(filePath)) // if the file does not exsists then :
            {
                this.Hide(); // hide the current form
                obj.Show(); // show the (Sign Up) for entering a new password because no password exsists .
            }
        }
    }
}
