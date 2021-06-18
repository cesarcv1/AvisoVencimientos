using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SQLite;

    

namespace rDocumentos
{
    public partial class frmLogin : Form
    {
        SQLiteConnection con = new SQLiteConnection("Data Source =" + ConfigurationManager.AppSettings["RutaBBDD"].ToString());
        string ssql;

        public frmLogin()
        {
            InitializeComponent();
        }

        public void logins()
        {


            try
            {
                con.Open();
                ssql = "select * from usuarios where descripcion='" + txtUser.Text + "' and password='" + txtPassword.Text + "'" ;

                SQLiteCommand cmd = new SQLiteCommand(ssql, con);
                SQLiteDataReader dr = cmd.ExecuteReader();

                int i = dr.StepCount;
                if(dr.HasRows)
                {
                    if (Application.OpenForms["Principal"] == null)
                    {

                        Principal ppl = new Principal();
                        
                        ppl.Show();
                        
                    }
                }else
                 {
                    MessageBox.Show("Login InCorrecto");
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message.ToString());   
            }
            finally { 
                con.Close();
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            logins();
        }

        
        void TxtPasswordKeyDown(object sender, KeyEventArgs e)
        {
        	if(e.KeyCode == Keys.Return)
            {
                logins();
            }
        }
    }
}
