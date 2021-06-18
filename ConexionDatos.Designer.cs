
namespace rDocumentos
{
    partial class ConexionDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConectar = new System.Windows.Forms.Button();
            this.lblDB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBases = new System.Windows.Forms.ComboBox();
            this.grMySql = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.grSQLite = new System.Windows.Forms.GroupBox();
            this.lblRutaSqlite = new System.Windows.Forms.Label();
            this.txtRutaNombreSQLite = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grMySql.SuspendLayout();
            this.grSQLite.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(306, 361);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(114, 42);
            this.btnConectar.TabIndex = 8;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDB.Location = new System.Drawing.Point(80, 205);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(0, 25);
            this.lblDB.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Base de Datos";
            // 
            // cbBases
            // 
            this.cbBases.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBases.FormattingEnabled = true;
            this.cbBases.Items.AddRange(new object[] {
            "SQLite",
            "MySql"});
            this.cbBases.Location = new System.Drawing.Point(332, 29);
            this.cbBases.Name = "cbBases";
            this.cbBases.Size = new System.Drawing.Size(174, 33);
            this.cbBases.TabIndex = 12;
            this.cbBases.Text = "SQLite";
            this.cbBases.SelectedValueChanged += new System.EventHandler(this.cbBases_SelectedValueChanged);
            // 
            // grMySql
            // 
            this.grMySql.Controls.Add(this.label2);
            this.grMySql.Controls.Add(this.txtDB);
            this.grMySql.Controls.Add(this.txtPassword);
            this.grMySql.Controls.Add(this.txtUsuario);
            this.grMySql.Controls.Add(this.txtPuerto);
            this.grMySql.Controls.Add(this.txtServidor);
            this.grMySql.Controls.Add(this.lblPassword);
            this.grMySql.Controls.Add(this.lblUsuario);
            this.grMySql.Controls.Add(this.lblPuerto);
            this.grMySql.Controls.Add(this.lblServidor);
            this.grMySql.Location = new System.Drawing.Point(139, 92);
            this.grMySql.Name = "grMySql";
            this.grMySql.Size = new System.Drawing.Size(473, 216);
            this.grMySql.TabIndex = 13;
            this.grMySql.TabStop = false;
            this.grMySql.Text = "MySql";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre DB";
            // 
            // txtDB
            // 
            this.txtDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDB.Location = new System.Drawing.Point(205, 184);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(196, 30);
            this.txtDB.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(205, 148);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(196, 30);
            this.txtPassword.TabIndex = 15;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(205, 110);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(196, 30);
            this.txtUsuario.TabIndex = 14;
            // 
            // txtPuerto
            // 
            this.txtPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuerto.Location = new System.Drawing.Point(205, 73);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(196, 30);
            this.txtPuerto.TabIndex = 13;
            // 
            // txtServidor
            // 
            this.txtServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServidor.Location = new System.Drawing.Point(205, 38);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(196, 30);
            this.txtServidor.TabIndex = 12;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(72, 148);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(114, 25);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(107, 110);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 25);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuerto.Location = new System.Drawing.Point(117, 73);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(69, 25);
            this.lblPuerto.TabIndex = 9;
            this.lblPuerto.Text = "Puerto";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServidor.Location = new System.Drawing.Point(101, 38);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(85, 25);
            this.lblServidor.TabIndex = 8;
            this.lblServidor.Text = "Servidor";
            // 
            // grSQLite
            // 
            this.grSQLite.Controls.Add(this.lblRutaSqlite);
            this.grSQLite.Controls.Add(this.txtRutaNombreSQLite);
            this.grSQLite.Location = new System.Drawing.Point(48, 92);
            this.grSQLite.Name = "grSQLite";
            this.grSQLite.Size = new System.Drawing.Size(674, 122);
            this.grSQLite.TabIndex = 14;
            this.grSQLite.TabStop = false;
            this.grSQLite.Text = "SQLite";
            // 
            // lblRutaSqlite
            // 
            this.lblRutaSqlite.AutoSize = true;
            this.lblRutaSqlite.Location = new System.Drawing.Point(21, 32);
            this.lblRutaSqlite.Name = "lblRutaSqlite";
            this.lblRutaSqlite.Size = new System.Drawing.Size(177, 17);
            this.lblRutaSqlite.TabIndex = 1;
            this.lblRutaSqlite.Text = "Ruta y Nombre del Fichero";
            // 
            // txtRutaNombreSQLite
            // 
            this.txtRutaNombreSQLite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaNombreSQLite.Location = new System.Drawing.Point(21, 68);
            this.txtRutaNombreSQLite.Name = "txtRutaNombreSQLite";
            this.txtRutaNombreSQLite.Size = new System.Drawing.Size(623, 30);
            this.txtRutaNombreSQLite.TabIndex = 0;
            this.txtRutaNombreSQLite.Click += new System.EventHandler(this.txtRutaNombreSQLite_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ConexionDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 421);
            this.Controls.Add(this.grSQLite);
            this.Controls.Add(this.grMySql);
            this.Controls.Add(this.cbBases);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.btnConectar);
            this.Name = "ConexionDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexión";
           // this.Load += new System.EventHandler(this.ConexionDatos_Load);
            this.grMySql.ResumeLayout(false);
            this.grMySql.PerformLayout();
            this.grSQLite.ResumeLayout(false);
            this.grSQLite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBases;
        private System.Windows.Forms.GroupBox grMySql;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.GroupBox grSQLite;
        private System.Windows.Forms.Label lblRutaSqlite;
        private System.Windows.Forms.TextBox txtRutaNombreSQLite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}