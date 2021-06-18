
namespace rDocumentos
{
    partial class frmLogin
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
        	this.lblUsuario = new System.Windows.Forms.Label();
        	this.lblPassword = new System.Windows.Forms.Label();
        	this.txtUser = new System.Windows.Forms.TextBox();
        	this.txtPassword = new System.Windows.Forms.TextBox();
        	this.btAceptar = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// lblUsuario
        	// 
        	this.lblUsuario.AutoSize = true;
        	this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblUsuario.Location = new System.Drawing.Point(16, 44);
        	this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.lblUsuario.Name = "lblUsuario";
        	this.lblUsuario.Size = new System.Drawing.Size(138, 20);
        	this.lblUsuario.TabIndex = 0;
        	this.lblUsuario.Text = "Código de Acceso";
        	// 
        	// lblPassword
        	// 
        	this.lblPassword.AutoSize = true;
        	this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblPassword.Location = new System.Drawing.Point(60, 84);
        	this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        	this.lblPassword.Name = "lblPassword";
        	this.lblPassword.Size = new System.Drawing.Size(92, 20);
        	this.lblPassword.TabIndex = 1;
        	this.lblPassword.Text = "Contraseña";
        	// 
        	// txtUser
        	// 
        	this.txtUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        	this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtUser.Location = new System.Drawing.Point(150, 44);
        	this.txtUser.Margin = new System.Windows.Forms.Padding(2);
        	this.txtUser.Name = "txtUser";
        	this.txtUser.Size = new System.Drawing.Size(158, 26);
        	this.txtUser.TabIndex = 2;
        	// 
        	// txtPassword
        	// 
        	this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        	this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtPassword.Location = new System.Drawing.Point(150, 84);
        	this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
        	this.txtPassword.Name = "txtPassword";
        	this.txtPassword.PasswordChar = '*';
        	this.txtPassword.Size = new System.Drawing.Size(158, 26);
        	this.txtPassword.TabIndex = 3;
        	this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPasswordKeyDown);
        	// 
        	// btAceptar
        	// 
        	this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btAceptar.Location = new System.Drawing.Point(150, 132);
        	this.btAceptar.Margin = new System.Windows.Forms.Padding(2);
        	this.btAceptar.Name = "btAceptar";
        	this.btAceptar.Size = new System.Drawing.Size(158, 32);
        	this.btAceptar.TabIndex = 4;
        	this.btAceptar.Text = "Aceptar";
        	this.btAceptar.UseVisualStyleBackColor = true;
        	this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
        	// 
        	// frmLogin
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(375, 198);
        	this.Controls.Add(this.btAceptar);
        	this.Controls.Add(this.txtPassword);
        	this.Controls.Add(this.txtUser);
        	this.Controls.Add(this.lblPassword);
        	this.Controls.Add(this.lblUsuario);
        	this.Margin = new System.Windows.Forms.Padding(2);
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "frmLogin";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Control de Acceso";
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btAceptar;
    }
}