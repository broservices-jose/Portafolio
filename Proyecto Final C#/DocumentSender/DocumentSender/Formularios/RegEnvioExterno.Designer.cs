namespace DocumentSender.Formularios
{
    partial class RegEnvioExterno
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
            this.label8 = new System.Windows.Forms.Label();
            this.tboxMensajero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxHora = new System.Windows.Forms.MaskedTextBox();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxAsunto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxRemitente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxNumeroDoc = new System.Windows.Forms.TextBox();
            this.butCancelar = new System.Windows.Forms.Button();
            this.butAceptar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tboxTelefono = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboxEmpresa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Mensajero";
            // 
            // tboxMensajero
            // 
            this.tboxMensajero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxMensajero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxMensajero.Location = new System.Drawing.Point(111, 108);
            this.tboxMensajero.Name = "tboxMensajero";
            this.tboxMensajero.Size = new System.Drawing.Size(224, 20);
            this.tboxMensajero.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "(hora en formato militar)";
            // 
            // tboxHora
            // 
            this.tboxHora.Location = new System.Drawing.Point(111, 378);
            this.tboxHora.Mask = "00:00";
            this.tboxHora.Name = "tboxHora";
            this.tboxHora.Size = new System.Drawing.Size(35, 20);
            this.tboxHora.TabIndex = 50;
            this.tboxHora.ValidatingType = typeof(System.DateTime);
            // 
            // dateFecha
            // 
            this.dateFecha.CustomFormat = "";
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(118, 341);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(111, 20);
            this.dateFecha.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Hora de envio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Fecha de envio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Asunto";
            // 
            // tboxAsunto
            // 
            this.tboxAsunto.Location = new System.Drawing.Point(111, 301);
            this.tboxAsunto.Name = "tboxAsunto";
            this.tboxAsunto.Size = new System.Drawing.Size(224, 20);
            this.tboxAsunto.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Direccion";
            // 
            // tboxDireccion
            // 
            this.tboxDireccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxDireccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxDireccion.Location = new System.Drawing.Point(92, 65);
            this.tboxDireccion.Name = "tboxDireccion";
            this.tboxDireccion.Size = new System.Drawing.Size(224, 20);
            this.tboxDireccion.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Remitente";
            // 
            // tboxRemitente
            // 
            this.tboxRemitente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxRemitente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxRemitente.Location = new System.Drawing.Point(111, 68);
            this.tboxRemitente.Name = "tboxRemitente";
            this.tboxRemitente.Size = new System.Drawing.Size(224, 20);
            this.tboxRemitente.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "No. Documento";
            // 
            // tboxNumeroDoc
            // 
            this.tboxNumeroDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxNumeroDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxNumeroDoc.Location = new System.Drawing.Point(111, 30);
            this.tboxNumeroDoc.Name = "tboxNumeroDoc";
            this.tboxNumeroDoc.ReadOnly = true;
            this.tboxNumeroDoc.Size = new System.Drawing.Size(224, 20);
            this.tboxNumeroDoc.TabIndex = 39;
            // 
            // butCancelar
            // 
            this.butCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancelar.Location = new System.Drawing.Point(275, 440);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(92, 29);
            this.butCancelar.TabIndex = 38;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            // 
            // butAceptar
            // 
            this.butAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butAceptar.Location = new System.Drawing.Point(168, 440);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(92, 29);
            this.butAceptar.TabIndex = 37;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Telefono";
            // 
            // tboxTelefono
            // 
            this.tboxTelefono.Location = new System.Drawing.Point(92, 101);
            this.tboxTelefono.Name = "tboxTelefono";
            this.tboxTelefono.Size = new System.Drawing.Size(224, 20);
            this.tboxTelefono.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tboxEmpresa);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tboxTelefono);
            this.groupBox1.Controls.Add(this.tboxDireccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(22, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 143);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destinatario";
            // 
            // tboxEmpresa
            // 
            this.tboxEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxEmpresa.Location = new System.Drawing.Point(92, 28);
            this.tboxEmpresa.Name = "tboxEmpresa";
            this.tboxEmpresa.Size = new System.Drawing.Size(224, 20);
            this.tboxEmpresa.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Empresa";
            // 
            // RegEnvioExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 500);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tboxMensajero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tboxHora);
            this.Controls.Add(this.dateFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxAsunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxRemitente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxNumeroDoc);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegEnvioExterno";
            this.Text = "Registrar envio externo";
            this.Load += new System.EventHandler(this.RegEnvioExterno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxMensajero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox tboxHora;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxAsunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxRemitente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxNumeroDoc;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tboxTelefono;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboxEmpresa;
        private System.Windows.Forms.Label label10;
    }
}