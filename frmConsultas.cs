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

namespace rDocumentos
{
    public partial class frmConsultas : Form
    {
        CargaGridViews datag = new CargaGridViews();
       
        ComboEmpresas qcb_empresas = new ComboEmpresas();
        ComboContrapartes qcb_contrapartes = new ComboContrapartes();

        //CargaGridViews q_datag = new CargaGridViews();


        string select_base = "SELECT id , (select a.descripcion from Tipodocumento a where a.idTipo=fichas.idTipo) Tipo, " +
             "(select b.descripcion from Contrapartes b where b.idContraparte = fichas.idContraparte) Contraparte, " +
             "(select c.descripcion from Paises c where c.idPais = fichas.idPais) 'Pais de Firma', " +
             "fechafirma 'Fecha Firma' ,fechainicio 'Fecha Inicio' ,fechavencimiento 'Fecha Vencimiento' " +
             " from Fichas ";

        string select;


        int idEmpresa;
        int idContraparte;
        
        public frmConsultas()
        {
            InitializeComponent();
            qcb_empresas.Seleccionar_Empresas(cbEmpresas);
            qcb_contrapartes.Seleccionar_Contrapartes(cbContrapartes);

        }

        public DataSet LlenarDataGridView(string tabla)
        {
            DataSet DS;
            String cmd = String.Format("Select * from " + tabla);
            DS = Utilidades.Ejecutar(cmd);

            return DS;
        }

        public void cbEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            select = null;
            select = select_base;

            if (cbEmpresas.SelectedIndex > 0)
            {
                string[] valores = qcb_empresas.Captar_Empresa(cbEmpresas.Text);

                //empresa = valores[1].ToString();
                idEmpresa=Int32.Parse(valores[0]);

                select += "  where idEmpresa =" + idEmpresa;
                datag.CargarPorSelect(this.dgvConsultas, select);
            }
        }

        public void cbContrapartes_SelectedIndexChanged(object sender, EventArgs e)
        {

            select = null;
            select = select_base;

            //si está informada la empresa, sumar 
            if (cbEmpresas.SelectedIndex > 0 && cbContrapartes.SelectedIndex > 0)
            {
                string[] valoresE = qcb_empresas.Captar_Empresa(cbEmpresas.Text);
                idEmpresa = Int32.Parse(valoresE[0]);

                string[] valoresC = qcb_contrapartes.Captar_Contrapartes(cbContrapartes.Text);
                idContraparte = Int32.Parse(valoresC[0]);

                select += " where idEmpresa =" + idEmpresa + " and idContraparte=" + idContraparte;

            }
            else if(cbContrapartes.SelectedIndex > 0) //si no, solo la contraparte
            {
                string[] valoresC = qcb_contrapartes.Captar_Contrapartes(cbContrapartes.Text);
                idContraparte = Int32.Parse(valoresC[0]);

                select += " where idContraparte=" + idContraparte;
            }

            datag.CargarPorSelect(this.dgvConsultas, select);
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            datag.CargarPorSelect(this.dgvConsultas, select_base + "order by id");
        }

    }
}
