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
    //public, para que la clase se puede usar en todo el sistema y en el resto de clases
    public class datos2
    {
        //public SQLiteConnection cn= new SQLiteConnection("Data Source =C:/z-pruebas/rDocumentos/Documentos.db");
        //private string cadena = "Data Source =C:/z-pruebas/rDocumentos/Documentos.db";
        private string cadena = "Data Source =" + ConfigurationManager.AppSettings["RutaBBDD"].ToString();
        
        
        public SQLiteConnection cn;
        //private SQLiteCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SQLiteDataAdapter da;
        public SQLiteCommand cmd;

        private void Conectar()
        {
            cn = new SQLiteConnection(cadena);
        }

        public datos2()
        {
            Conectar();
        }

        //para consultar

        /*
                SQLiteCommand cmd = new SQLiteCommand(sbSQL.ToString(), con);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet dsDatos = new DataSet();
                con.Open();
                da.Fill(dsDatos);
                con.Close();
                grid.DataSource = dsDatos.Tables[0];

         */

        public void consultar(string sql, string tabla)
        {
            cmd = new SQLiteCommand(sql, cn);
            da = new SQLiteDataAdapter(cmd);
            cn.Open();
            ds.Tables.Clear();
            da.Fill(ds, tabla);
            cn.Close();
        }

        //para elminar
        public Boolean eliminar(string tabla, string condicion)
        {
            cn.Open();
            string sql = "delete from " + tabla + " where " + condicion;
            cmd = new SQLiteCommand(sql, cn);
            int i = cmd.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
                {return true;}
            else 
                { return false; }
        }

        //actualizar
        public Boolean actualizar(string tabla, string campos, string condicion)
        {
            cn.Open();
            string sql = "update " + tabla + " set " + campos + " where " + condicion;
            cmd = new SQLiteCommand(sql, cn);
            int i = cmd.ExecuteNonQuery();
            cn.Close();
            if(i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //consulta en el combo para rellenar y modificar datos
        public DataTable consultar2(string tabla)
        {
            string sql = " select * from " + tabla;        //sentenecia sql
            da = new SQLiteDataAdapter(sql, cn);    
            DataSet dts = new DataSet();    
            da.Fill(dts, tabla);                //llenar el dataadpater con el dataaset
            DataTable dt = new DataTable(); 
            dt = dts.Tables[tabla];             //las tabla en C# se manejan como arreglos, por eso los corchetes
            return dt;                          //devuelve el datatable.

        }

        public bool insertar(string sql)
        {
            cn.Open();
            cmd = new SQLiteCommand(sql, cn);
            int i = cmd.ExecuteNonQuery();
            cn.Close();
            if(i > 0)
            {
                return true;
            }
            else { return false; 
            }
        }
    }
}
