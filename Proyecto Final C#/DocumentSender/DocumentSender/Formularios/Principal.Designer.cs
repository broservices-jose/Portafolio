namespace DocumentSender.Formularios
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRegistrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRegistrarDepartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDocumentos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRegEnvioInterno = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRegRecInterna = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRegEnvioExterno = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRegEnvio = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRegRecExterna = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRepDocUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRepDocDepartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDocTransito = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEntranteHoy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSalienteHoy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSistema,
            this.toolDocumentos,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolSistema
            // 
            this.toolSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolRegistrarUsuario,
            this.toolRegistrarDepartamento});
            this.toolSistema.Name = "toolSistema";
            this.toolSistema.Size = new System.Drawing.Size(60, 20);
            this.toolSistema.Text = "Sistema";
            // 
            // toolRegistrarUsuario
            // 
            this.toolRegistrarUsuario.Name = "toolRegistrarUsuario";
            this.toolRegistrarUsuario.Size = new System.Drawing.Size(198, 22);
            this.toolRegistrarUsuario.Text = "Registrar usuario";
            this.toolRegistrarUsuario.Click += new System.EventHandler(this.toolRegistrarUsuario_Click);
            // 
            // toolRegistrarDepartamento
            // 
            this.toolRegistrarDepartamento.Name = "toolRegistrarDepartamento";
            this.toolRegistrarDepartamento.Size = new System.Drawing.Size(198, 22);
            this.toolRegistrarDepartamento.Text = "Registrar departamento";
            this.toolRegistrarDepartamento.Click += new System.EventHandler(this.toolRegistrarDepartamento_Click);
            // 
            // toolDocumentos
            // 
            this.toolDocumentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolRegEnvioInterno,
            this.toolRegRecInterna,
            this.toolRegEnvioExterno,
            this.toolRegEnvio,
            this.toolRegRecExterna});
            this.toolDocumentos.Name = "toolDocumentos";
            this.toolDocumentos.Size = new System.Drawing.Size(87, 20);
            this.toolDocumentos.Text = "Documentos";
            // 
            // toolRegEnvioInterno
            // 
            this.toolRegEnvioInterno.Name = "toolRegEnvioInterno";
            this.toolRegEnvioInterno.Size = new System.Drawing.Size(278, 22);
            this.toolRegEnvioInterno.Text = "Registrar envio interno";
            this.toolRegEnvioInterno.Click += new System.EventHandler(this.toolRegEnvioInterno_Click);
            // 
            // toolRegRecInterna
            // 
            this.toolRegRecInterna.Name = "toolRegRecInterna";
            this.toolRegRecInterna.Size = new System.Drawing.Size(278, 22);
            this.toolRegRecInterna.Text = "Registrar recepcion interna";
            this.toolRegRecInterna.Click += new System.EventHandler(this.toolRegRecInterna_Click);
            // 
            // toolRegEnvioExterno
            // 
            this.toolRegEnvioExterno.Name = "toolRegEnvioExterno";
            this.toolRegEnvioExterno.Size = new System.Drawing.Size(278, 22);
            this.toolRegEnvioExterno.Text = "Registrar envio externo";
            this.toolRegEnvioExterno.Click += new System.EventHandler(this.toolRegEnvioExterno_Click);
            // 
            // toolRegEnvio
            // 
            this.toolRegEnvio.Name = "toolRegEnvio";
            this.toolRegEnvio.Size = new System.Drawing.Size(278, 22);
            this.toolRegEnvio.Text = "Registrar completitud de envio externo";
            this.toolRegEnvio.Click += new System.EventHandler(this.toolRegEnvioDesdeFuera_Click);
            // 
            // toolRegRecExterna
            // 
            this.toolRegRecExterna.Name = "toolRegRecExterna";
            this.toolRegRecExterna.Size = new System.Drawing.Size(278, 22);
            this.toolRegRecExterna.Text = "Registrar recepcion externa";
            this.toolRegRecExterna.Click += new System.EventHandler(this.toolRegRecExterna_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolRepDocUsuario,
            this.toolRepDocDepartamento,
            this.toolDocTransito,
            this.toolEntranteHoy,
            this.toolSalienteHoy});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // toolRepDocUsuario
            // 
            this.toolRepDocUsuario.Name = "toolRepDocUsuario";
            this.toolRepDocUsuario.Size = new System.Drawing.Size(241, 22);
            this.toolRepDocUsuario.Text = "Documentos por usuario";
            // 
            // toolRepDocDepartamento
            // 
            this.toolRepDocDepartamento.Name = "toolRepDocDepartamento";
            this.toolRepDocDepartamento.Size = new System.Drawing.Size(241, 22);
            this.toolRepDocDepartamento.Text = "Documentos por departamento";
            // 
            // toolDocTransito
            // 
            this.toolDocTransito.Name = "toolDocTransito";
            this.toolDocTransito.Size = new System.Drawing.Size(241, 22);
            this.toolDocTransito.Text = "Documentos en transito";
            // 
            // toolEntranteHoy
            // 
            this.toolEntranteHoy.Name = "toolEntranteHoy";
            this.toolEntranteHoy.Size = new System.Drawing.Size(241, 22);
            this.toolEntranteHoy.Text = "Documentos entrantes de hoy";
            // 
            // toolSalienteHoy
            // 
            this.toolSalienteHoy.Name = "toolSalienteHoy";
            this.toolSalienteHoy.Size = new System.Drawing.Size(241, 22);
            this.toolSalienteHoy.Text = "Documentos Salientes de hoy";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 458);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolSistema;
        private System.Windows.Forms.ToolStripMenuItem toolRegistrarUsuario;
        private System.Windows.Forms.ToolStripMenuItem toolRegistrarDepartamento;
        private System.Windows.Forms.ToolStripMenuItem toolDocumentos;
        private System.Windows.Forms.ToolStripMenuItem toolRegEnvioInterno;
        private System.Windows.Forms.ToolStripMenuItem toolRegRecInterna;
        private System.Windows.Forms.ToolStripMenuItem toolRegEnvioExterno;
        private System.Windows.Forms.ToolStripMenuItem toolRegRecExterna;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolRepDocUsuario;
        private System.Windows.Forms.ToolStripMenuItem toolRepDocDepartamento;
        private System.Windows.Forms.ToolStripMenuItem toolDocTransito;
        private System.Windows.Forms.ToolStripMenuItem toolEntranteHoy;
        private System.Windows.Forms.ToolStripMenuItem toolSalienteHoy;
        private System.Windows.Forms.ToolStripMenuItem toolRegEnvio;
    }
}

