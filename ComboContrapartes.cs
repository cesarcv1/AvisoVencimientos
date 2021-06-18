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

    class ComboContrapartes
    {
        
        SQLiteConnection con = new SQLiteConnection("Data Source =" + ConfigurationManager.AppSettings["RutaBBDD"].ToString());

        public void Seleccionar_Contrapartes(ComboBox cb)
        {
            try
            {
                cb.Items.Clear();
                con.Open();
                string sql = "select * from Contrapartes order by idContraparte";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                SQLiteDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //cb.Items.Add(dr[0].ToString() + "-" + dr[1].ToString());
                    cb.Items.Add(dr[1].ToString());
                }

                con.Close();
                cb.Items.Insert(0, "--Seleccione Contraparte--");
                cb.SelectedIndex = 0;
            }
            catch (SQLiteException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        
        public String[] Captar_Contrapartes(string Descripcion)
        {
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand("select * from Contrapartes where Descripcion='" + Descripcion + "'", con);
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

        internal void Captar_Contrapartes()
        {
            throw new NotImplementedException();
        }
    }
}
