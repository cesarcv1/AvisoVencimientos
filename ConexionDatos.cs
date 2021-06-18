using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rDocumentos
{
    public partial class ConexionDatos : Form
    {
        public ConexionDatos()
        {
            InitializeComponent();

            //estado inicial de los controles
            grSQLite.Visible = true;
            grMySql.Visible = false;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string servidor = txtServidor.Text;
            string puerto = txtPuerto.Text;
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            string bd = txtDB.Text;

            string CadenaConexion = "Database=" + bd +
                                  "; Data Source=" + servidor +
                                  "; Port=" + puerto +
                                  "; User Id=" + usuario +
                                  "; Password=" + password;
            //video con la explicacion del conector
            //https://youtu.be/IfJfaDtaFpQ

        }

        private void cbBases_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbBases.Text == "SQLite")
            {
                grSQLite.Visible = true;
                grMySql.Visible = false;
            }
            else if (cbBases.Text == "MySql")
            {
                grSQLite.Visible = false;
                grMySql.Visible = true;
            }

        }

        private void txtRutaNombreSQLite_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };
        }
    }
}
