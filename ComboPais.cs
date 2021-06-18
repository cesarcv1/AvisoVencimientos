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

    class ComboPais
    {
        //SQLiteConnection con = new SQLiteConnection("Data Source =C:/z-pruebas/rDocumentos/Documentos.db");
        SQLiteConnection con = new SQLiteConnection("Data Source =" + ConfigurationManager.AppSettings["RutaBBDD"].ToString());
        
         public class Valor
	     {
	         public string Value { get; set; }
	         public string Index { get; set; }
	     }

        public void Seleccionar_Paises(ComboBox cb)
        {
            cb.Items.Clear();
            con.Open();
            string sql = "select idpais,descripcion from Paises order by idpais";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader dr = cmd.ExecuteReader();
            
            var Valores = new List<Valor>();
            
            while (dr.Read())
            {
                //cb.Items.Add(dr[0].ToString() + "-" + dr[1].ToString());
                //cb.Items.Add(dr[1].ToString());
                Valores.Add(new Valor() { Index = dr[0].ToString(), Value = dr[1].ToString() });
            }
            
            con.Close();
            
            //cb.Items.Insert(0, "--Seleccione Pais--");
            //cb.SelectedIndex = 0;
            
            cb.DataSource = Valores;
            cb.DisplayMember = "Value";
            cb.ValueMember = "Index";
            cb.Text = "Value";
        }

        public String[] Captar_Pais(string Descripcion)
        {
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand("select * from Paises where Descripcion='" + Descripcion + "'", con);
            SQLiteDataReader dr = cmd.ExecuteReader();
            string[] resultado = null;
            while (dr.Read())
            {
                string[] valores =
                {
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString()
                };
                resultado = valores;
            }

            con.Close();
            return resultado;
        }
    }
}
