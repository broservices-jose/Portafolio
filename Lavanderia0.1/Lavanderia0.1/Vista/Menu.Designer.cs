namespace Lavanderia0._1.Vista
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnfactura = new System.Windows.Forms.Button();
            this.btnusuario = new System.Windows.Forms.Button();
            this.btnarticulo = new System.Windows.Forms.Button();
            this.btnservicio = new System.Windows.Forms.Button();
            this.btnempleado = new System.Windows.Forms.Button();
            this.btncliente = new System.Windows.Forms.Button();
            this.btnpagonomina = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(20, 677);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(592, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(93, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 18);
            this.panel2.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Location = new System.Drawing.Point(-1, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(21, 18);
            this.panel3.TabIndex = 42;
            // 
            // btnfactura
            // 
            this.btnfactura.BackColor = System.Drawing.Color.Gold;
            this.btnfactura.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnfactura.FlatAppearance.BorderSize = 0;
            this.btnfactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Magenta;
            this.btnfactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnfactura.Image = ((System.Drawing.Image)(resources.GetObject("btnfactura.Image")));
            this.btnfactura.Location = new System.Drawing.Point(20, 60);
            this.btnfactura.Name = "btnfactura";
            this.btnfactura.Size = new System.Drawing.Size(105, 96);
            this.btnfactura.TabIndex = 44;
            this.btnfactura.UseVisualStyleBackColor = false;
            this.btnfactura.Click += new System.EventHandler(this.button1_Click);
            this.btnfactura.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // btnusuario
            // 
            this.btnusuario.BackColor = System.Drawing.Color.BlueViolet;
            this.btnusuario.Image = ((System.Drawing.Image)(resources.GetObject("btnusuario.Image")));
            this.btnusuario.Location = new System.Drawing.Point(19, 332);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(106, 96);
            this.btnusuario.TabIndex = 45;
            this.btnusuario.UseVisualStyleBackColor = false;
            this.btnusuario.Click += new System.EventHandler(this.button2_Click);
            this.btnusuario.MouseHover += new System.EventHandler(this.btnusuario_MouseHover);
            // 
            // btnarticulo
            // 
            this.btnarticulo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnarticulo.Image = ((System.Drawing.Image)(resources.GetObject("btnarticulo.Image")));
            this.btnarticulo.Location = new System.Drawing.Point(19, 241);
            this.btnarticulo.Name = "btnarticulo";
            this.btnarticulo.Size = new System.Drawing.Size(106, 96);
            this.btnarticulo.TabIndex = 46;
            this.btnarticulo.UseVisualStyleBackColor = false;
            this.btnarticulo.Click += new System.EventHandler(this.button3_Click);
            this.btnarticulo.MouseHover += new System.EventHandler(this.btnarticulo_MouseHover);
            // 
            // btnservicio
            // 
            this.btnservicio.BackColor = System.Drawing.Color.Orange;
            this.btnservicio.Image = ((System.Drawing.Image)(resources.GetObject("btnservicio.Image")));
            this.btnservicio.Location = new System.Drawing.Point(20, 149);
            this.btnservicio.Name = "btnservicio";
            this.btnservicio.Size = new System.Drawing.Size(105, 96);
            this.btnservicio.TabIndex = 47;
            this.btnservicio.UseVisualStyleBackColor = false;
            this.btnservicio.Click += new System.EventHandler(this.button4_Click);
            this.btnservicio.MouseHover += new System.EventHandler(this.btnservicio_MouseHover);
            // 
            // btnempleado
            // 
            this.btnempleado.BackColor = System.Drawing.Color.LawnGreen;
            this.btnempleado.Image = ((System.Drawing.Image)(resources.GetObject("btnempleado.Image")));
            this.btnempleado.Location = new System.Drawing.Point(20, 427);
            this.btnempleado.Name = "btnempleado";
            this.btnempleado.Size = new System.Drawing.Size(105, 96);
            this.btnempleado.TabIndex = 48;
            this.btnempleado.UseVisualStyleBackColor = false;
            this.btnempleado.Click += new System.EventHandler(this.button5_Click);
            this.btnempleado.MouseHover += new System.EventHandler(this.btnempleado_MouseHover);
            // 
            // btncliente
            // 
            this.btncliente.BackColor = System.Drawing.Color.Crimson;
            this.btncliente.Image = ((System.Drawing.Image)(resources.GetObject("btncliente.Image")));
            this.btncliente.Location = new System.Drawing.Point(20, 522);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(105, 96);
            this.btncliente.TabIndex = 49;
            this.btncliente.UseVisualStyleBackColor = false;
            this.btncliente.Click += new System.EventHandler(this.button6_Click);
            this.btncliente.MouseHover += new System.EventHandler(this.btncliente_MouseHover);
            // 
            // btnpagonomina
            // 
            this.btnpagonomina.BackColor = System.Drawing.Color.Olive;
            this.btnpagonomina.Image = ((System.Drawing.Image)(resources.GetObject("btnpagonomina.Image")));
            this.btnpagonomina.Location = new System.Drawing.Point(19, 615);
            this.btnpagonomina.Name = "btnpagonomina";
            this.btnpagonomina.Size = new System.Drawing.Size(106, 68);
            this.btnpagonomina.TabIndex = 51;
            this.btnpagonomina.UseVisualStyleBackColor = false;
            this.btnpagonomina.Click += new System.EventHandler(this.button7_Click);
            this.btnpagonomina.MouseHover += new System.EventHandler(this.btnpagonomina_MouseHover);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 719);
            this.Controls.Add(this.btnpagonomina);
            this.Controls.Add(this.btncliente);
            this.Controls.Add(this.btnempleado);
            this.Controls.Add(this.btnservicio);
            this.Controls.Add(this.btnarticulo);
            this.Controls.Add(this.btnusuario);
            this.Controls.Add(this.btnfactura);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Menu";
            this.Resizable = false;
            this.Text = "Menu";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnfactura;
        private System.Windows.Forms.Button btnusuario;
        private System.Windows.Forms.Button btnarticulo;
        private System.Windows.Forms.Button btnservicio;
        private System.Windows.Forms.Button btnempleado;
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btnpagonomina;
    }
}



