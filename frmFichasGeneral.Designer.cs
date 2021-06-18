
namespace rDocumentos
{
    partial class frmFichasGeneral
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
            this.lblEmpresas = new System.Windows.Forms.Label();
            this.cbEmpresas = new System.Windows.Forms.ComboBox();
            this.dgvEmpresas = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbxPrueba = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdNuevaFicha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpresas
            // 
            this.lblEmpresas.AutoSize = true;
            this.lblEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresas.Location = new System.Drawing.Point(95, 24);
            this.lblEmpresas.Name = "lblEmpresas";
            this.lblEmpresas.Size = new System.Drawing.Size(100, 25);
            this.lblEmpresas.TabIndex = 0;
            this.lblEmpresas.Text = "Empresas";
            this.lblEmpresas.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbEmpresas
            // 
            this.cbEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpresas.FormattingEnabled = true;
            this.cbEmpresas.Location = new System.Drawing.Point(213, 24);
            this.cbEmpresas.Name = "cbEmpresas";
            this.cbEmpresas.Size = new System.Drawing.Size(315, 33);
            this.cbEmpresas.TabIndex = 1;
            this.cbEmpresas.SelectedIndexChanged += new System.EventHandler(this.cbEmpresas_SelectedIndexChanged);
            // 
            // dgvEmpresas
            // 
            this.dgvEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmpresas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvEmpresas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresas.Location = new System.Drawing.Point(12, 101);
            this.dgvEmpresas.Name = "dgvEmpresas";
            this.dgvEmpresas.ReadOnly = true;
            this.dgvEmpresas.RowHeadersWidth = 51;
            this.dgvEmpresas.RowTemplate.Height = 24;
            this.dgvEmpresas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEmpresas.Size = new System.Drawing.Size(893, 295);
            this.dgvEmpresas.TabIndex = 2;
            this.dgvEmpresas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresas_CellClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1293, 24);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 33);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cbxPrueba
            // 
            this.cbxPrueba.FormattingEnabled = true;
            this.cbxPrueba.Location = new System.Drawing.Point(982, 24);
            this.cbxPrueba.Name = "cbxPrueba";
            this.cbxPrueba.Size = new System.Drawing.Size(229, 24);
            this.cbxPrueba.TabIndex = 4;
            this.cbxPrueba.SelectedIndexChanged += new System.EventHandler(this.cbxPrueba_SelectedIndexChanged);
            this.cbxPrueba.Click += new System.EventHandler(this.cbxPrueba_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(979, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // cmdNuevaFicha
            // 
            this.cmdNuevaFicha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevaFicha.Location = new System.Drawing.Point(564, 24);
            this.cmdNuevaFicha.Name = "cmdNuevaFicha";
            this.cmdNuevaFicha.Size = new System.Drawing.Size(235, 33);
            this.cmdNuevaFicha.TabIndex = 6;
            this.cmdNuevaFicha.Text = "Nueva Ficha";
            this.cmdNuevaFicha.UseVisualStyleBackColor = true;
            this.cmdNuevaFicha.Click += new System.EventHandler(this.cmdNuevaFicha_Click);
            // 
            // frmFichasGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 435);
            this.Controls.Add(this.cmdNuevaFicha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPrueba);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvEmpresas);
            this.Controls.Add(this.cbEmpresas);
            this.Controls.Add(this.lblEmpresas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFichasGeneral";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fichas de Documentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresas;
        private System.Windows.Forms.ComboBox cbEmpresas;
        private System.Windows.Forms.DataGridView dgvEmpresas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbxPrueba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdNuevaFicha;
    }
}