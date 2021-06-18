using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace rDocumentos
{
    class DataGridVEmpresas
    {
        //SQLiteConnection con = new SQLiteConnection("Data Source =C:/z-pruebas/rDocumentos/Documentos.db");
        SQLiteConnection con = new SQLiteConnection("Data Source =" + ConfigurationManager.AppSettings["RutaBBDD"].ToString());

        public void CargarDocoumentos(DataGridView grid, int empresa)
        {
            try
            {
                //substr(fecha,7)||substr(fecha,4,2)||substr(fecha,1,2)||substr(hora,1,2) ||substr(hora,4,2) 

                StringBuilder sbSQL = new StringBuilder();
                sbSQL.Append("SELECT id , (select descripcion from tipodocumento a where a.tipo=documentos.tipodocumento) Tipo, ");
                sbSQL.Append("contraparte Contraparte ,jurisdiccion Jurisdiccion,territorio Territorio,paisfirma,fechafirma,fechainicio,fechavencimiento ");
                sbSQL.Append("from Documentos where Empresa = " + empresa );

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

            }
        }
    }
}

