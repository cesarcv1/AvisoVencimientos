using System;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace rDocumentos
{

    class CaptarDato
    {

        //SQLiteConnection con = new SQLiteConnection("Data Source =C:/z-pruebas/rDocumentos/Documentos.db");
        SQLiteConnection con = new SQLiteConnection("Data Source =" + ConfigurationManager.AppSettings["RutaBBDD"].ToString());
        
        
        public String[] Captar_Dato(string tabla, int id)
        {
            string sql = "select * from " + tabla + " where id=" + id;
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores =
                {
                    dr[0].ToString(),
                    dr[1].ToString()
                };
                resultado = valores;
            }

            con.Close();
            return resultado;

        }

    }
}
