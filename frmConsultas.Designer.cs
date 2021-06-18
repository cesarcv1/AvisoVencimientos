
namespace rDocumentos
{
    partial class frmConsultas
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
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblEmpresas = new System.Windows.Forms.Label();
            this.cbEmpresas = new System.Windows.Forms.ComboBox();
            this.cbContrapartes = new System.Windows.Forms.ComboBox();
            this.lblContrapartes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsultas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvConsultas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(12, 101);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.RowHeadersWidth = 51;
            this.dgvConsultas.RowTemplate.Height = 24;
            this.dgvConsultas.Size = new System.Drawing.Size(893, 295);
            this.dgvConsultas.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(768, 35);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(137, 34);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblEmpresas
            // 
            this.lblEmpresas.AutoSize = true;
            this.lblEmpresas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresas.Location = new System.Drawing.Point(86, 9);
            this.lblEmpresas.Name = "lblEmpresas";
            this.lblEmpresas.Size = new System.Drawing.Size(89, 23);
            this.lblEmpresas.TabIndex = 4;
            this.lblEmpresas.Text = "Empresa";
            // 
            // cbEmpresas
            // 
            this.cbEmpresas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpresas.FormattingEnabled = true;
            this.cbEmpresas.Location = new System.Drawing.Point(217, 6);
            this.cbEmpresas.Name = "cbEmpresas";
            this.cbEmpresas.Size = new System.Drawing.Size(345, 31);
            this.cbEmpresas.TabIndex = 7;
            this.cbEmpresas.SelectedIndexChanged += new System.EventHandler(this.cbEmpresas_SelectedIndexChanged);
            // 
            // cbContrapartes
            // 
            this.cbContrapartes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContrapartes.FormattingEnabled = true;
            this.cbContrapartes.Location = new System.Drawing.Point(217, 43);
            this.cbContrapartes.Name = "cbContrapartes";
            this.cbContrapartes.Size = new System.Drawing.Size(345, 31);
            this.cbContrapartes.TabIndex = 9;
            this.cbContrapartes.SelectedIndexChanged += new System.EventHandler(this.cbContrapartes_SelectedIndexChanged);
            // 
            // lblContrapartes
            // 
            this.lblContrapartes.AutoSize = true;
            this.lblContrapartes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrapartes.Location = new System.Drawing.Point(60, 46);
            this.lblContrapartes.Name = "lblContrapartes";
            this.lblContrapartes.Size = new System.Drawing.Size(115, 23);
            this.lblContrapartes.TabIndex = 8;
            this.lblContrapartes.Text = "Contraparte";
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 435);
            this.Controls.Add(this.cbContrapartes);
            this.Controls.Add(this.lblContrapartes);
            this.Controls.Add(this.cbEmpresas);
            this.Controls.Add(this.lblEmpresas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvConsultas);
            this.Location = new System.Drawing.Point(12, 101);
            this.Name = "frmConsultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblEmpresas;
        private System.Windows.Forms.ComboBox cbEmpresas;
        private System.Windows.Forms.ComboBox cbContrapartes;
        private System.Windows.Forms.Label lblContrapartes;
    }
}