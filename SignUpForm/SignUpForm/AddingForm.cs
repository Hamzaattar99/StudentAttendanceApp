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
using System.Data.OleDb;

namespace SignUpForm
{
    public partial class AddingForm : Form
    {
        OleDbConnection baseCon = new OleDbConnection();
         OleDbConnection sourceCon = new OleDbConnection();

        public AddingForm()
        {
            InitializeComponent();
            baseCon = openConnection("D:/IT4/projects/attendence_system/SignUpForm/SignUpForm/test.accdb");
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult YesNoResult = MessageBox.Show("Are You Sure!? You Want to Exit ?", "Eixt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (YesNoResult == DialogResult.Yes) // checks if chose Yes it will get out of the program
            {
                Application.Exit(); // Exits from whole program and all Forms .
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Access DataBase (*.accdb;*.mdb)|*.accdb;*.mdb";

            if(ofd.ShowDialog()  == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                try
                {
                   
                    sourceCon = openConnection(filePath);

                    sourceCon.Open();
                    baseCon.Open();

                    DataTable tables = sourceCon.GetSchema("Tables");

                    foreach(DataRow row in tables.Rows)
                    {
                        string tableName = row["TABLE_NAME"].ToString();
                        string tableType = row["TABLE_TYPE"].ToString();

                        if(tableType == "TABLE")
                        {
                            OleDbDataAdapter da = new OleDbDataAdapter("select * from " + tableName , sourceCon);
                            DataTable dt = new DataTable();
                            da.Fill(dt);


                           /* try
                            {

                            string createTableSql = GenerateCreateTableSql(tableName, dt);

                            OleDbCommand createCmd = new OleDbCommand(createTableSql, baseCon);

                           
                                createCmd.ExecuteNonQuery();
                            }

                            //catch(Exception ex)
                            //{
                              //  MessageBox.Show(ex.ToString());
                            //} */

                            if (!TableExists(baseCon, tableName))
                            {
                                string createTableSql = GenerateCreateTableSql(tableName, dt);

                                OleDbCommand createCmd = new OleDbCommand(createTableSql, baseCon);


                                createCmd.ExecuteNonQuery();

                            }
                            else
                            {
                                MessageBox.Show("Exitxsssssssss!!!!!!");
                            }
                            foreach(DataRow dr in dt.Rows)
                            {
                                string insertSql = GenerateInsertSql(tableName, dt, dr);
                                OleDbCommand insertCmd = new OleDbCommand(insertSql, baseCon);

                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }


                    MessageBox.Show("Done!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                
            }
        }


        private string GenerateCreateTableSql(string tableName , DataTable dt)
        {
            string sql = "create table " + tableName + " (";

            for(int i = 0 ; i < dt.Columns.Count ; i++)
            {
                var col = dt.Columns[i];
                string colName = col.ColumnName;

                if(i == 0)
                {
                    sql += colName + " AUTOINCREMENT PRIMARY KEY, ";
                }

                else if (col.DataType == typeof(bool))
                {
                    sql += colName + " YESNO, ";
                }

                else
                {
                    sql += colName + " TEXT, ";
                }
            }

            sql = sql.TrimEnd(',' , ' ') + ")";
            return sql;
        }

        private string GenerateInsertSql(string tableName , DataTable dt , DataRow dr)
        {
            string cols = "";
            string vals = "";


            for(int i = 0 ; i < dt.Columns.Count ; i++)
            {
                if (i == 0)
                    continue;

               
                var col = dt.Columns[i];
                string colName = col.ColumnName;
                object val = dr[col];

                cols += colName + ",";

               

                

                if(val == DBNull.Value)
                {
                    vals += "NULL,";
                    
                }

               

                else if(col.DataType == typeof(bool))
                {
                    vals += ((bool)val) ? "True," : "False,";
                    

                }

                else
                {
                    vals += "'" + val.ToString() + "'" + ",";
                }
            }

            cols = cols.TrimEnd(',');
            vals = vals.TrimEnd(',');

            return "insert into " + tableName + " (" + cols + ") values (" + vals + ")";

        }

        private bool TableExists(OleDbConnection connection , string tabelName)
        {
            DataTable schema = connection.GetSchema("Tables");

            foreach(DataRow row in schema.Rows)
            {
                if (row["TABLE_NAME"].ToString().Equals(tabelName, StringComparison.OrdinalIgnoreCase))
                    return true;

            }
            return false;
        }

        

        public OleDbConnection openConnection(string fileName)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+fileName);


            return con;
        }
    }
}
