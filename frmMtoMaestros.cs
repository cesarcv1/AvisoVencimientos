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
    public partial class frmMantenimiento : Form
    {
        public string vTabla;
        public string vCampoId;
        public string vCampoDescripcion;
        public frmMantenimiento(string p_Tabla, String p_CampoId,String p_CampoDescripcion)
        {
            vTabla = p_Tabla;
            vCampoId = p_CampoId;
            vCampoDescripcion = p_CampoDescripcion;
            InitializeComponent();

            lblName.Text = vTabla;
            LoadData();

        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        //set coneccion
        private void SetConnection()
        {
            //sql_con = new SQLiteConnection("Data Source =C:/z-pruebas/rDocumentos/Documentos.db");
			sql_con = new SQLiteConnection("Data Source = " + ConfigurationManager.AppSettings["RutaBBDD"].ToString());
        }
        //set executequery
        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        //set loadDB
        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select " + vCampoId +","+ vCampoDescripcion +" Nombre from '" + vTabla +"'";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
            txtID.Clear();
            txtNombre.Clear();
        }

        private void ftmEmpresasMto_Load(object sender, EventArgs e)
        {
            lblName.Text = vTabla;
            LoadData();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells['"'+ vTabla +'"'].Value.ToString();
            txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells["'" + vCampoDescripcion + "'"].Value.ToString();

        }

        

        private int ContarRegistros(string tabla, string campoid, int id)
        {

            //https://www.it-swarm-es.com/es/c%23/como-contar-el-numero-de-filas-de-la-tabla-sql-en-c/1042768076/
            string txtQuery = "select count(*) from fichas where  " + vCampoId + "= " + id;
            int count;
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            count = Convert.ToInt32(sql_cmd.ExecuteScalar());
            sql_con.Close();
            return count;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNombre.TextLength != 0)
            {
                string txtQuery = "insert into " + vTabla + "(" + vCampoDescripcion + ") values ('" + txtNombre.Text + "')";
                ExecuteQuery(txtQuery);
                LoadData();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.TextLength != 0)
                {
                    string txtQuery = "update " + vTabla + " set " + vCampoDescripcion + "='" + txtNombre.Text + "' where " + vCampoId + "=" + int.Parse(txtID.Text);
                    ExecuteQuery(txtQuery);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Seleccione una Fila para Modificar");
                }
            }
            catch (Exception em)
            {
                MessageBox.Show(em.Message.ToString());
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.TextLength > 0)
                {
                    int id = int.Parse(txtID.Text);
                    int cuantos = ContarRegistros("Fichas", vCampoId, id);
                    if (cuantos > 0)
                    {
                        MessageBox.Show("Dato Asignado a " + cuantos + " Contratos, No se puede borrar la Entrada");
                        txtID.Clear();
                        txtNombre.Clear();
                    }
                    else
                    {
                        string txtQuery = "delete from " + vTabla + " where " + vCampoId + "=" + id;
                        ExecuteQuery(txtQuery);
                        LoadData();
                    }
                }
            }
            catch (Exception em)
            {
                MessageBox.Show(em.Message.ToString());
            }
        }
    }
}