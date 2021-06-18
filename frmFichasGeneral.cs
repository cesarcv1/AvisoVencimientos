using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;

namespace rDocumentos
{ 
    public partial class frmFichasGeneral : Form
    {

        SQLiteConnection Xcon = new SQLiteConnection("Data Source =" + ConfigurationManager.AppSettings["RutaBBDD"].ToString());


        ComboEmpresas combo = new ComboEmpresas();
        CargaGridViews datag = new CargaGridViews();

        ComboDinamico cmPrueba = new ComboDinamico();

        int idEmpresa;
        string empresa;

        public frmFichasGeneral()
        {
            InitializeComponent();
            combo.Seleccionar_Empresas(cbEmpresas);

            //cmPrueba.Seleccionar_Dato(Xcon, cbxPrueba, "Empresas");
            cmPrueba.Selecciona_Dato(Xcon, cbxPrueba, "Paises");

        }

        private void cbEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmpresas.SelectedIndex > 0)
            {
               
                string[] valores = combo.Captar_Empresa(cbEmpresas.Text);

                idEmpresa = Int32.Parse(valores[0]);
                empresa = valores[1].ToString();

                string select = "SELECT id ,Asunto, (select a.descripcion from Tipodocumento a where a.idTipo=fichas.idTipo) Tipo, " +
                                              "(select b.descripcion from Contrapartes b where b.idContraparte = fichas.idContraparte) Contraparte, " +
                                              "(select c.descripcion from Paises c where c.idPais = fichas.idPais) PaisFirma, " +
                                              "fechafirma,fechainicio,fechavencimiento " +
                                              "from Fichas where idEmpresa = " + idEmpresa + "";

                datag.CargarPorSelect(this.dgvEmpresas, select);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();

        }

        private void dgvEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = (dgvEmpresas.Rows[e.RowIndex].Cells["id"].Value.ToString());

                frmFichaMto Ficha = new frmFichaMto(int.Parse(id));
                
                Ficha.Show();
            }
            catch (Exception em )
            {
                MessageBox.Show(em.Message.ToString());
            }
        }

        private void cbxPrueba_Click(object sender, EventArgs e)
        {
            label1.Text= cbxPrueba.SelectedIndex.ToString() + " click";
        }

        private void cbxPrueba_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = cbxPrueba.SelectedIndex.ToString() + " select index changed";
        }

        private void cmdNuevaFicha_Click(object sender, EventArgs e)
        {
            frmFichaMto NuevaFicha = new frmFichaMto(0);
            this.Visible = false;
            NuevaFicha.Show();
        
        }

       
    }
}

