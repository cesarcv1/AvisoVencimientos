using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using System.Data;


namespace rDocumentos
{
    class ADDBB
    {

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        //private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        public void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source = " + ConfigurationManager.AppSettings["RutaBBDD"].ToString());
        }

        public Boolean ExecuteQuery(string txtQuery)
        {
            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = txtQuery;
                sql_cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                sql_con.Close();

            }
        }
    }
}
