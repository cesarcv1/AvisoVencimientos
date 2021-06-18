using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SQLite;
using System.Configuration;

namespace rDocumentos
{

    public partial class frmFichaMto : Form
    {
        SQLiteConnection con = new SQLiteConnection("Data Source =" + ConfigurationManager.AppSettings["RutaBBDD"].ToString());

        //al cargar el formulario instancio los combos que necesito
        ComboTipoDocumento cbTipoDoc = new ComboTipoDocumento();
        ComboEmpresas cbEmpresa = new ComboEmpresas();
        ComboPais cbPaises = new ComboPais();
        ComboPais cbTerr = new ComboPais();
        ComboPais cbPaisFirm = new ComboPais();
        ComboDias cbDiasAviso = new ComboDias();
        ComboDias cbPrDiasPr = new ComboDias();
        ComboContrapartes cbCP = new ComboContrapartes();

        public int CodigoFicha;

        public frmFichaMto(int vIdFicha)
        {
            InitializeComponent();

            cbEmpresa.Seleccionar_Empresas(cbEmpresas);
            cbTipoDoc.Seleccionar_Tipos(cbTipoDocumento);
            //cbTerr.Seleccionar_Paises(cbTerritorio);
            cbPaisFirm.Seleccionar_Paises(cbPaisFirma);     //combo pais firma
            cbDiasAviso.Cargar_Dias(cbDias);                //comobo dias aviso
            cbPrDiasPr.Cargar_Dias(cbPrDias);               //combo dias prorroga
            cbCP.Seleccionar_Contrapartes(cbContraparte);

            CodigoFicha = vIdFicha;

            if (vIdFicha > 0)
            {

                #region
                try
                {
                    con.Open();
                    string sql = "select id,";
                    sql += "idEmpresa, (select descripcion from empresas where idEmpresa = fichas.id) Empresa,";
                    sql += "idContraparte,(select descripcion from contrapartes where idContraparte = fichas.idContraparte) Contraparte,";
                    sql += "Asunto,";
                    sql += "idTipo,(select descripcion from tipodocumento where idTipo = fichas.idTipo) Tipodocumento,";
                    sql += "idPais,(select descripcion from paises where idpais = fichas.idpais)Pais,";
                    sql += "fechafirma,";
                    sql += "fechainicio,";
                    sql += "fechavencimiento,";
                    sql += "FechaAvisoVencimiento,";
                    sql += "FechaAvisoProrroga ";
                    sql += " from fichas where id = " + vIdFicha;


                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lblIdFicha.Text = dr[0].ToString();

                        txtIdFicha.Text = (dr[0].ToString());
                        txtIdEmpresa.Text = (dr[1].ToString());
                        cbEmpresas.Text = (dr[2].ToString());
                        txtIdContraparte.Text = (dr[3].ToString());
                        cbContraparte.Text = (dr[4].ToString());
                        txtAsunto.Text = (dr[5].ToString());
                        txtIdTipoDocumento.Text = (dr[6].ToString());
                        cbTipoDocumento.Text = (dr[7].ToString());
                        txtIdPaisFirma.Text = (dr[8].ToString());
                        cbPaisFirma.Text = (dr[9].ToString());
                        dtpFechaFirma.Text = (dr[10].ToString());
                        dtpFechaInicio.Text = (dr[11].ToString());
                        dtpFechaVencimiento.Text = (dr[12].ToString());
                        //dtpFechaAvisoVto.Text = (dr[13].ToString());
                        //dtpFechaAvisoVto    Prorroga.Text = (dr[14].ToString());
                        //txtLink.Text = (dr[14].ToString());
                        //txtDudas.Text = (dr[16].ToString());

                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                finally
                {
                    con.Close();
                }
                #endregion
            }
            else
            {
                dtpFechaFirma.Text = "";
                dtpFechaInicio.Text = "";
                dtpFechaInicio.Text = "";
                dtpFechaVencimiento.Text = "";

            }

        }//fin de public

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dtpFechaFirma.Value;
            //txtFechaFirma.Text = fecha.ToString();
        }

        private void btGrabar_Click(object sender, EventArgs e)
        {

            if (CodigoFicha <= 0)
            {
                //https://www.tutorialesprogramacionya.com/csharpya/detalleconcepto.php?codigo=203&inicio=60

                string ssql = "insert into Fichas(idEmpresa, idContraparte,idTipo,idPais,fechafirma,fechainicio,fechavencimiento,FechaAvisoVencimiento,FechaAvisoProrroga,Asunto,Link,dudas) values(";
                ssql += cbEmpresas.SelectedIndex + "," + cbContraparte.SelectedIndex + "," + cbTipoDocumento.SelectedIndex;
                ssql += "," + cbPaisFirma.SelectedValue + ",'" + dtpFechaFirma.Value.ToString("d/MM/yyyy") + "'";
                ssql += ",'" + dtpFechaInicio.Value.ToString("d/MM/yyyy") + "','" + dtpFechaVencimiento.Value.ToString("d/MM/yyyy") + "','" + dtpFechaAvisoVto.Value.ToString("d/MM/yyyy") + "','" + dtpFechaAvisoVtoProrroga.Value.ToString("d/MM/yyyy") + "','" + txtAsunto.Text + "','" + txtLink.Text + "','" + txtDudas.Text + "' )";

                Boolean estado;
                ADDBB ejecuta = new ADDBB();
                estado = ejecuta.ExecuteQuery(ssql);
                MessageBox.Show(estado.ToString());
            }
            else
            {
                //update
                string ssql = " update Fichas set " +
                " idEmpresa= " + cbEmpresas.SelectedIndex + "," +
                " idContraparte= " + cbContraparte.SelectedIndex + "," +
                " idTipo= " + cbTipoDocumento.SelectedIndex + "," +
                " idPais= " + cbPaisFirma.SelectedIndex + "," +
                " fechafirma= '" + dtpFechaFirma.Value.ToString("d/MM/yyyy") + "'," +
                " fechainicio= '" + dtpFechaInicio.Value.ToString("d/MM/yyyy") + "'," +
                " fechavencimiento= '" + dtpFechaVencimiento.Value.ToString("d/MM/yyyy") + "', " +
                " FechaAvisoVencimiento= '" + dtpFechaAvisoVto.Value.ToString("d/MM/yyyy") + "', " +
                " FechaAvisoProrroga= '" + dtpFechaAvisoVtoProrroga.Value.ToString("d/MM/yyyy") + "', " +
                " Asunto= '" + txtAsunto.Text + "', " +
                " Link= '" + txtLink.Text + "' , " +
                " dudas= ' " + txtDudas.Text + "' " +
                " where id=" + CodigoFicha;


                Boolean estado;
                ADDBB ejecuta = new ADDBB();
                estado = ejecuta.ExecuteQuery(ssql);
                MessageBox.Show(estado.ToString());


            }

        }

        void cargar_orden()
        {
            int orden = 1;
            this.chkVigente.TabIndex = orden;
            orden++;
            this.cbEmpresas.TabIndex = orden;
            orden++;
            this.cbContraparte.TabIndex = orden;
            orden++;
            this.txtAsunto.TabIndex = orden;
            orden++;
            this.cbTipoDocumento.TabIndex = orden;
            orden++;
            //this.cbTerritorio.TabIndex = orden;
            //orden++;
            this.cbPaisFirma.TabIndex = orden;
            orden++;
            this.dtpFechaFirma.TabIndex = orden;
            orden++;
            this.dtpFechaInicio.TabIndex = orden;
            orden++;
            this.dtpFechaVencimiento.TabIndex = orden;
            orden++;
            this.cbDias.TabIndex = orden;
            orden++;
            this.cbPeriodo.TabIndex = orden;
            orden++;
            this.dtpFechaAvisoVto.TabIndex = orden;
            orden++;
            this.cbPrDias.TabIndex = orden;
            orden++;
            this.cbPrPeriodo.TabIndex = orden;
            orden++;
            this.dtpFechaAvisoVtoProrroga.TabIndex = orden;
            orden++;
            this.txtDudas.TabIndex = orden;
            orden++;
            this.txtLink.TabIndex = orden;
            orden++;
            this.btnGrabar.TabIndex = orden;
            orden++;
            this.btnSalir.TabIndex = orden;
        }

        private void CalcularVencimiento()
        {


            DateTime fecha = Convert.ToDateTime( dtpFechaVencimiento.Value.ToString("dd/MM/yyyy"));
            int num;
            num = (-1) * int.Parse(cbDias.Text.ToString());

            if (cbPeriodo.Text.ToString() == "día/s")
            {
                fecha = fecha.AddDays(num);
            }
            else if (cbPeriodo.Text.ToString() == "mes/es")
            {
                fecha = fecha.AddMonths(num);
            }
            else if (cbPeriodo.Text.ToString() == "año/s")
            {
                fecha = fecha.AddYears(num);
            }

            dtpFechaAvisoVto.Value = fecha;
        }

        private void cbPeriodo_TextChanged(object sender, EventArgs e)
        {

            CalcularVencimiento();
        }

        private void cbDias_TextChanged(object sender, EventArgs e)
        {
            CalcularVencimiento();
        }


        private void CalcularVencimientoProrroga()
        {


            DateTime fecha = Convert.ToDateTime(dtpFechaAvisoVto.Value.ToString("dd/MM/yyyy"));
            int num;
            num = (+1) * int.Parse(cbPrDias.Text.ToString());

            if (cbPrPeriodo.Text.ToString() == "día/s")
            {
                fecha = fecha.AddDays(num);

            }
            else if (cbPrPeriodo.Text.ToString() == "mes/es")
            {
                fecha = fecha.AddMonths(num);

            }
            else if (cbPrPeriodo.Text.ToString() == "año/s")
            {
                fecha = fecha.AddYears(num);

            }

            dtpFechaAvisoVtoProrroga.Value = fecha;
        }

        private void cbPrDias_TextChanged(object sender, EventArgs e)
        {
            CalcularVencimientoProrroga();
        }

        private void cbPrPeriodo_TextChanged(object sender, EventArgs e)
        {
            CalcularVencimientoProrroga();
        }

        private void btAbrirLink_Click(object sender, EventArgs e)
        {
            if (txtLink.Text != "")
            {
                try
                {
                    Process AbrirLink = new Process();

                    AbrirLink.StartInfo.FileName = this.txtLink.Text;
                    AbrirLink.Start();
                }
                catch
                {
                    MessageBox.Show("Error en Apertura de Fichero, verifique ruta");
                }
            }
            else
            {
                OpenFileDialog abrir = new OpenFileDialog();
                if (abrir.ShowDialog() == DialogResult.OK)
                {
                    txtLink.Text=abrir.FileName;

                }
            }
          
        }

        private void frmFichaMto_Load(object sender, EventArgs e)
        {
            txtIdContraparte.Visible = false;
            txtIdEmpresa.Visible = false;
            txtIdPaisFirma.Visible = false;
            txtIdFicha.Visible = false;
            txtIdContraparte.Visible = false;
            txtIdTerritorio.Visible = false;
            txtIdTipoDocumento.Visible = false;

            dtpFechaFirma.Text = "";
            dtpFechaInicio.Text = "";
            dtpFechaInicio.Text = "";
            dtpFechaVencimiento.Text = "";

        }


    }
}