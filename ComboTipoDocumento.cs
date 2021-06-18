﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;

namespace rDocumentos
{
    class ComboTipoDocumento
    {
        //SQLiteConnection con = new SQLiteConnection("Data Source =C:/z-pruebas/rDocumentos/Documentos.db");
        SQLiteConnection con = new SQLiteConnection("Data Source =" + ConfigurationManager.AppSettings["RutaBBDD"].ToString());

        public void Seleccionar_Tipos(ComboBox cb)
        {
            cb.Items.Clear();
            con.Open();
            string sql = "select * from Tipodocumento order by idtipo";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[1].ToString());
            }

            con.Close();
            cb.Items.Insert(0, "--Tipo Documento--");
            cb.SelectedIndex = 0;
        }


        public String[] Captar_Tipodocumento(string Descripcion)
        {
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand("select * from Tipodocumento where descripcion='" + Descripcion + "'", con);
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
