using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Configuration;

namespace rDocumentos
{
    class Utilidades
    {

        public static DataSet Ejecutar(string cmd)
        {
            //SQLiteConnection con = new SQLiteConnection("Data Source =C:/z-pruebas/rDocumentos/Documentos.db");
            SQLiteConnection con = new SQLiteConnection("Data Source =" + ConfigurationManager.AppSettings["RutaBBDD"].ToString());
            
            con.Open();

            //crea dataset para almacenar datos
            DataSet DS = new DataSet();

            //para adaptar los datos que devuelve la consulta al dataset (consulta, conexion abierta)
            SQLiteDataAdapter DP = new SQLiteDataAdapter(cmd, con);

            //para que rellene el dataset pasado por parametros
            DP.Fill(DS);

            //recomendable cerrar la conexion con la base de datos
            con.Close();

            //devuelve el Dataset
            return DS;
        }

    }
}
