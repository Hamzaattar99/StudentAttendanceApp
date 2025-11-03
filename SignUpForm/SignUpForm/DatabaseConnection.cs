using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace SignUpForm
{
    class DatabaseConnection
    {

        private static OleDbConnection Connection;

        private static readonly string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:/IT4/Frist_Term/projects/attendence_systemDB.accdb;";
        //public DatabaseConnection()
        //{
         //   connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:/IT4/Frist_Term/projects/attendence_systemDB.accdb;"; 
       // }

        public static OleDbConnection GetConnection()
        {
            if(Connection == null)
            {
                Connection = new OleDbConnection(connectionString);
            }

            if(Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }

            return Connection;
        }


        public static void CloseConnection()
        {
            if(Connection != null && Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
        }


        public bool TestConnection()
        {
            try
            {
                using(OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }


    }
}
