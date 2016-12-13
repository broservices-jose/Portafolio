namespace DocumentSender.Formularios
{
    partial class Login
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
            this.butCancelar = new System.Windows.Forms.Button();
            this.butAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxUsuario = new System.Windows.Forms.TextBox();
            this.tboxContraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butCancelar
            // 
            this.butCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancelar.Location = new System.Drawing.Point(277, 134);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(92, 29);
            this.butCancelar.TabIndex = 23;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            // 
            // butAceptar
            // 
            this.butAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butAceptar.Location = new System.Drawing.Point(170, 134);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(92, 29);
            this.butAceptar.TabIndex = 22;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Contraseña";
            // 
            // tboxUsuario
            // 
            this.tboxUsuario.Location = new System.Drawing.Point(116, 32);
            this.tboxUsuario.Name = "tboxUsuario";
            this.tboxUsuario.Size = new System.Drawing.Size(197, 20);
            this.tboxUsuario.TabIndex = 26;
            // 
            // tboxContraseña
            // 
            this.tboxContraseña.Location = new System.Drawing.Point(116, 73);
            this.tboxContraseña.Name = "tboxContraseña";
            this.tboxContraseña.PasswordChar = '*';
            this.tboxContraseña.Size = new System.Drawing.Size(197, 20);
            this.tboxContraseña.TabIndex = 27;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 192);
            this.Controls.Add(this.tboxContraseña);
            this.Controls.Add(this.tboxUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.butAceptar);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxUsuario;
        private System.Windows.Forms.TextBox tboxContraseña;
    }
}