using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SignUpForm
{
    public partial class AddUserForm : Form
    {
        private RSAHelper rsaHelper;

        private string publicKey;
        private string privateKey;

        public AddUserForm()
        {
            InitializeComponent();
            roleComboBox.SelectedIndex = 1;
            rsaHelper = new RSAHelper();

            publicKey = rsaHelper.GetPublicKeyXml();
            privateKey = rsaHelper.GetPrivateKeyXml();
        }

        private void AddUser(string username , string password, string fullname , string role)
        {
            try
            {
               /* OleDbConnection conn = new OleDbConnection();
                string query = "INSERT INTO users (username, password, fullname, role) VALUES (@u, @p, @f, @r)";
                OleDbCommand cmd = new OleDbCommand(query, conn);

                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                cmd.Parameters.AddWithValue("@f", fullname);
                cmd.Parameters.AddWithValue("@r", role);

                cmd.ExecuteNonQuery();*/
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:/IT4/Frist_Term/projects/attendence_systemDB.accdb;"))
                {
                    string query = "INSERT INTO users ([username], [password], [fullname], [role]) VALUES (@u, @p, @f, @r)";
                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);
                    cmd.Parameters.AddWithValue("@f", fullname);
                    cmd.Parameters.AddWithValue("@r", role);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("User Added Successfully!!!");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {


                string username = usernameTextField.Text.Trim();
                string password = passwordTextField.Text.Trim();
                string fullname = fullnameTextField.Text;
                string role = roleComboBox.SelectedItem.ToString();

                

                if (username == "" || password == "" || role == "" || role == null)
                {
                    MessageBox.Show("Please Fill All Fields! .", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


              string encryptedPassword = Encrypt(password);
              AddUser(username, encryptedPassword, fullname, role);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private string Encrypt(string pass)
        {
            rsaHelper.LoadKeyFromXml(publicKey);
            string encrypted = rsaHelper.Encrypt(pass);

            return encrypted;
        }
    }
}
