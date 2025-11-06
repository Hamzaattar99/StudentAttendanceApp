using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SignUpForm
{
    public partial class ChangePasswordControl1 : UserControl
    {

        private string currentUser;
        public ChangePasswordControl1(string username)
        {
            InitializeComponent();
            currentUser = username;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            string oldPass = bunifuTextbox1.text.Trim();
            string newPass = bunifuTextbox2.text.Trim();

            if(oldPass == "" || newPass == "")
            {
                MessageBox.Show("Please fill in both fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string oldHashed = HashingClass.getHashedPassword(oldPass);
            string newHashed = HashingClass.getHashedPassword(newPass);


            try
            {
                OleDbConnection conn = DatabaseConnection.GetConnection();
                string selectQuery = "SELECT password FROM users WHERE username = ?";

                using(OleDbCommand cmd = new OleDbCommand(selectQuery , conn))
                {
                    cmd.Parameters.AddWithValue("?", currentUser);
                    object result = cmd.ExecuteScalar();

                    if(result == null)
                    {
                        MessageBox.Show("No Such User!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string storedPassword = result.ToString();

                    if(storedPassword != oldHashed)
                    {
                        MessageBox.Show("Old Password is Incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    string updateQuery = "UPDATE users SET [password] = ? WHERE [username] = ?";

                    using(OleDbCommand updateCmd = new OleDbCommand(updateQuery , conn))
                    {
                        updateCmd.Parameters.AddWithValue("?", newHashed);
                        updateCmd.Parameters.AddWithValue("?", currentUser);


                        int rows = updateCmd.ExecuteNonQuery();

                        if(rows > 0)
                        {
                            MessageBox.Show("Password Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        else
                        {
                            MessageBox.Show("No Changes Made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }
    }
}
