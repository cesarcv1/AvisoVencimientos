using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Configuration;
using System.Net.Mail;

namespace rDocumentos
{
    class MailAvisos
    {

       SQLiteConnection con = new SQLiteConnection("Data Source =" + ConfigurationManager.AppSettings["RutaBBDD"].ToString());

        public void LeerBBDD(string sSQL)
        {
            string ficha;
            string tipo;
            string contraparte;
            string paisfirma;
            string ffirma;
            string finicio;
            string fvencimiento;
            string asunto;

            try
            {
                DataSet dsDatos = new DataSet();

                //StringBuilder sbSQL = new StringBuilder();
                //sbSQL.Append(sSQL);
                //SQLiteCommand cmd = new SQLiteCommand(sSQL, con);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sSQL, con);
                
                con.Open();

                da.Fill(dsDatos, "Fichas");

                foreach (DataRow row in dsDatos.Tables[0].Rows)
                {
                     ficha = row["Ficha"].ToString();
                     tipo= row["Tipo"].ToString();
                     contraparte = row["contraparte"].ToString();
                     paisfirma = row["paisfirma"].ToString();
                     ffirma = row["fechafirma"].ToString();
                     finicio = row["fechainicio"].ToString();
                     fvencimiento = row["fechavencimiento"].ToString();
                     asunto = row["asunto"].ToString();

                    enviarCorreo(ficha, tipo, contraparte, paisfirma, ffirma, finicio, fvencimiento, asunto);

                }

            }
            catch(Exception)
            {
                //
            }
            finally
            {
                con.Close();
            }
        }


        public void enviarCorreo(string ficha, string tipo, string contraparte, string paisfirma, string firma, string inicio,string vencimiento, string asunto)
        {

                string asunto2 = "Vencimiento del contrato: " + asunto + " - Vencimiento: " + vencimiento;
                string mailBody = "El contrato con " + contraparte + " esta a punto de vencer";
                mailBody += "\n Id del Contrato: " + ficha;
                mailBody += "\n Tipo Contrato: " + tipo;
                mailBody += "\n Fecha de Firma: " + firma;
                mailBody += "\n Fecha de Inicio: " + inicio;
                mailBody += "\n Fecha de Vencimiento Original: " + vencimiento;

            try
            {
                MailMessage mmsg = new MailMessage();

                mmsg.To.Add(ConfigurationManager.AppSettings["TO"].ToString());

                if (ConfigurationManager.AppSettings["CC"].ToString() != "")
                    mmsg.CC.Add(ConfigurationManager.AppSettings["CC"].ToString());

                // if (ConfigurationManager.AppSettings["CO"].ToString() != "")
                //     mmsg.Bcc.Add(ConfigurationManager.AppSettings["CO"].ToString());

                mmsg.Subject = asunto2;
                mmsg.Body = mailBody;
                mmsg.BodyEncoding = System.Text.Encoding.UTF8;

                mmsg.From = new MailAddress(ConfigurationManager.AppSettings["CuentaUso"].ToString());

                SmtpClient cliente = new SmtpClient();
                cliente.UseDefaultCredentials = false;
                cliente.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["CuentaUso"].ToString(), ConfigurationManager.AppSettings["PassUso"].ToString());
                cliente.Host = "smtp.gmail.com";
                cliente.Port = 587;
                cliente.EnableSsl = true;

                cliente.Send(mmsg);
            } catch (Exception xs)
            {
                string x = xs.ToString(); 
            }

        }

    }
}
