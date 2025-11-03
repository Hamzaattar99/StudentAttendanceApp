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
    public partial class AdminDashboard : Form
    {

        private RSAHelper rsaHelper;

        private string publicKey;
        private string privateKey;

        DatabaseConnection db = new DatabaseConnection();
        public AdminDashboard()
        {
            InitializeComponent();

            rsaHelper = new RSAHelper();

            publicKey = rsaHelper.GetPublicKeyXml();
            privateKey = rsaHelper.GetPrivateKeyXml();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new AddUserForm().Show();
            LoadUsers();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            /*DatabaseConnection db = new DatabaseConnection();
            OleDbConnection conn = db.GetConnection();

            try
            {
                conn.Open();
                MessageBox.Show("Connected Successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection Failed: " + ex.Message);
            }
            finally
            {
                conn.Close();
            } */
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            OleDbConnection conn = DatabaseConnection.GetConnection();
            string query = "SELECT * FROM users";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);


            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a Row to Delete.");
                    return;

            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["user_id"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                try
                {

                    OleDbConnection conn = DatabaseConnection.GetConnection();
                    string query = "DELETE FROM users WHERE user_id = @id";
                    OleDbCommand cmd = new OleDbCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User Deleted Successfully!!!");
                    LoadUsers();
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    if(row.Cells["user_id"].Value != null  && row.Cells["user_id"].Value != DBNull.Value)
                    {
                        int id = Convert.ToInt32(row.Cells["user_id"].Value);
                        string username = row.Cells["username"].Value.ToString();
                        string fullname = row.Cells["fullname"].Value.ToString();

                        string query = "UPDATE users SET username = ?, fullname = ? WHERE user_id = ?";

                       // OleDbConnection conn = DatabaseConnection.GetConnection;

                        using (OleDbCommand cmd = new OleDbCommand(query, DatabaseConnection.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("?", username);
                            cmd.Parameters.AddWithValue("?", fullname);
                            cmd.Parameters.AddWithValue("?", id);

                            cmd.ExecuteNonQuery();
                        }
                    }

                }

                MessageBox.Show("User has been updated!!!");
                LoadUsers();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
