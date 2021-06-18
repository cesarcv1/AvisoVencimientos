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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void paisesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMantenimiento"] != null)
            {
                    MessageBox.Show("Formulario ya abierto");
            }
            else
            {
                frmMantenimiento Paises = new frmMantenimiento("Paises", "idPais", "descripcion");
               Paises.Text = "Paises";
                Paises.MdiParent = this;
                Paises.Show();
            }
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tipoDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMantenimiento"] != null)
            {
                MessageBox.Show("Formulario ya abierto");
            }
            else
            {
                //instancion el formulario que quiero brir
                frmMantenimiento Tipocontratos = new frmMantenimiento("Tipocontrato", "idTipo", "descripcion");
                Tipocontratos.Text = "Tipos";
                Tipocontratos.MdiParent = this;//indicar atributo que diga que pertenece al contenedor Principal
                Tipocontratos.Show();
            }
        }

        private void territoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMantenimiento"] != null)
            {
                MessageBox.Show("Formulario ya abierto");
            }
            else
            {
                frmMantenimiento Territorios = new frmMantenimiento("Territorios", "idTerritorio", "descripcion");
                Territorios.Text = "Territorios";
                Territorios.MdiParent = this;
                Territorios.Show();
            }
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMantenimiento"] != null)
            {
                MessageBox.Show("Formulario ya abierto");
            }
            else
            {
                frmMantenimiento Empresas = new frmMantenimiento("Empresas", "idEmpresa", "descripcion");
                Empresas.Text = "Empresas";
                Empresas.MdiParent = this;
                Empresas.Show();
            }

        }

        private void contrapartesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMantenimiento"] != null)
            {
                MessageBox.Show("Formulario ya abierto");
            }
            else
            {
                frmMantenimiento Contrapartes = new frmMantenimiento("Contrapartes", "idContraparte", "descripcion");
                Contrapartes.Text = "Contrapartes";
                Contrapartes.MdiParent = this;
                Contrapartes.Show();
            }
        }

        private void tiposDeContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMantenimiento"] != null)
            {
                MessageBox.Show("Formulario ya abierto");
            }
            else
            {
                frmMantenimiento TiposContrato = new frmMantenimiento("TipoContrato", "idTipo", "descripcion");
                TiposContrato.Text = "Tipos de Contratos";
                TiposContrato.MdiParent = this; //indicar atributo que diga que pertenece al contenedor Principal
                TiposContrato.Show();
            }
        }

        private void empresasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms["frmMantenimiento"] != null)
            {
                MessageBox.Show("Formulario ya abierto");
            }
            else
            {
                frmMantenimiento mtoEmpresas = new frmMantenimiento("Empresas", "idEmpresa", "descripcion");
                mtoEmpresas.Text = "Mantenimiento de Empresas";
                mtoEmpresas.MdiParent = this;
                mtoEmpresas.Show();
            }
        }

        private void fichasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmFichasGeneral"] != null)
            {
                MessageBox.Show("Formulario ya abierto");
            }
            else
            {
                frmFichasGeneral mtoFichas = new frmFichasGeneral();
                mtoFichas.MdiParent = this;     //indicar atributo que diga que pertenece al contenedor Principal
                mtoFichas.Show();
            }

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //instancion el formulario que quiero brir
            frmFichasGeneral mtoFichas = new frmFichasGeneral();

            //indicar atributo que diga que pertenece al contenedor Principal
            mtoFichas.MdiParent = this;

            //ahora hay que llamarlo 
            mtoFichas.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmConsultas"] != null)
            {
                MessageBox.Show("Formulario ya abierto");
            }
            else
            {
                frmConsultas consultas = new frmConsultas();
                consultas.MdiParent = this;
                consultas.Show();
            }
        }

        private void enviarMailToolStripMenuItem_Click(object sender, EventArgs e)
        {

            String fecha = DateTime.Today.ToString("dd/MM/yyyy");

            string select = "SELECT id Ficha , (select a.descripcion from Tipodocumento a where a.idTipo=fichas.idTipo) tipo, " +
                                          "(select b.descripcion from Contrapartes b where b.idContraparte = fichas.idContraparte) contraparte, " +
                                          "(select c.descripcion from Paises c where c.idPais = fichas.idPais) paisfirma, " +
                                          "fechafirma ,fechainicio ,fechavencimiento " +
                                          ", asunto" +
                                          " from Fichas where fechavencimiento >= '" + fecha + "'";

            MailAvisos avisos = new MailAvisos();
           
            avisos.LeerBBDD(select);

         
            

        }
    }
}

