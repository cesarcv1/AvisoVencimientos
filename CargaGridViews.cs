using System;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace rDocumentos
{
    class CargaGridViews
    {
        //SQLiteConnection con = new SQLiteConnection("Data Source =C:/z-pruebas/rDocumentos/Documentos.db");
        SQLiteConnection con = new SQLiteConnection("Data Source =" + ConfigurationManager.AppSettings["RutaBBDD"].ToString());
        

        public void CargarDocoumentos(DataGridView grid, int empresa)
        {
            try
            {
                //substr(fecha,7)||substr(fecha,4,2)||substr(fecha,1,2)||substr(hora,1,2) ||substr(hora,4,2) 

                StringBuilder sbSQL = new StringBuilder();
                sbSQL.Append("SELECT id ,Asunto, (select descripcion from tipodocumento a where a.tipo=documentos.tipodocumento) Tipo, ");
                sbSQL.Append("contraparte Contraparte ,jurisdiccion Jurisdiccion,territorio Territorio,paisfirma,fechafirma,fechainicio,fechavencimiento ");
                sbSQL.Append("from Documentos where Empresa = " + empresa);

                SQLiteCommand cmd = new SQLiteCommand(sbSQL.ToString(), con);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataSet dsDatos = new DataSet();
                con.Open();
                da.Fill(dsDatos);
                con.Close();
                grid.DataSource = dsDatos.Tables[0];
            }
            catch
            {
                ///
            }
        }


        public void CargarPorSelect(DataGridView grid, string select)
        {
            if (select != null)
            {
               
                try
                {
                    StringBuilder sbSQL = new StringBuilder();
                    sbSQL.Append(select);
                    SQLiteCommand cmd = new SQLiteCommand(sbSQL.ToString(), con);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    DataSet dsDatos = new DataSet();

                    con.Open();
                    da.Fill(dsDatos);
                    
                    grid.DataSource = dsDatos.Tables[0];
                }
                catch (Exception ex)
                {
                    // Qué ha sucedido
                    var mensaje = "Error message: " + ex.Message;

                    // Información sobre la excepción interna
                    if (ex.InnerException != null)
                    {
                        mensaje = mensaje + " Inner exception: " + ex.InnerException.Message;
                    }

                    // Dónde ha sucedido
                    mensaje = mensaje + " Stack trace: " + ex.StackTrace;

                    MessageBox.Show(mensaje);
                }
                finally{
                    con.Close();
                   //ConnectionState estado = con.State;
                   //
                   //if (estado == ConnectionState.Open)
                   //{
                   //    con.Close();
                   //}
                }
            }
        }
    }
}

