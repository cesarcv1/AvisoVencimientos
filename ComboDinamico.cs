using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;



namespace rDocumentos
{

    class ComboDinamico
    {
        SQLiteConnection con = new SQLiteConnection("Data Source =" + ConfigurationManager.AppSettings["RutaBBDD"].ToString());
        public class Valor
        {
            public string Value { get; set; }
            public string Index { get; set; }
        }
        public void Selecciona_Dato(SQLiteConnection con, ComboBox cb, string vTabla)
        {
            try
            {
                cb.Items.Clear();
                con.Open();
                string sql = "select * from " + vTabla; // + " order by " + vId;
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr[0].ToString() + "-" + dr[1].ToString());
                   // cb.Items.Add(dr[1].ToString());
                }

                con.Close();
                cb.Items.Insert(0, "--Seleccione Dato--");
                cb.SelectedIndex = 0;
            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
        }


        public String[] Captar_Dato(SQLiteConnection con, string vTabla, string vDescripcion)
        {
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand("select * from " + vTabla + " where Descripcion='" + vDescripcion + "'", con);
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
