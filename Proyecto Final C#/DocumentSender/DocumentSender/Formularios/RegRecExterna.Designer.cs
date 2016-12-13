namespace DocumentSender.Formularios
{
    partial class RegRecExterna
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
            this.label9 = new System.Windows.Forms.Label();
            this.tboxTelefono = new System.Windows.Forms.TextBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboxEmpresa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Telefono";
            // 
            // tboxTelefono
            // 
            this.tboxTelefono.Location = new System.Drawing.Point(111, 95);
            this.tboxTelefono.Name = "tboxTelefono";
            this.tboxTelefono.Size = new System.Drawing.Size(224, 20);
            this.tboxTelefono.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Mensajero";
            // 
            // tboxMensajero
            // 
            this.tboxMensajero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxMensajero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxMensajero.Location = new System.Drawing.Point(123, 103);
            this.tboxMensajero.Name = "tboxMensajero";
            this.tboxMensajero.Size = new System.Drawing.Size(224, 20);
            this.tboxMensajero.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "(hora en formato militar)";
            // 
            // tboxHora
            // 
            this.tboxHora.Location = new System.Drawing.Point(123, 382);
            this.tboxHora.Mask = "00:00";
            this.tboxHora.Name = "tboxHora";
            this.tboxHora.Size = new System.Drawing.Size(35, 20);
            this.tboxHora.TabIndex = 69;
            this.tboxHora.ValidatingType = typeof(System.DateTime);
            // 
            // dateFecha
            // 
            this.dateFecha.CustomFormat = "";
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(123, 340);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(111, 20);
            this.dateFecha.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Hora de envio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Fecha de envio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Asunto";
            // 
            // tboxAsunto
            // 
            this.tboxAsunto.Location = new System.Drawing.Point(123, 298);
            this.tboxAsunto.Name = "tboxAsunto";
            this.tboxAsunto.Size = new System.Drawing.Size(224, 20);
            this.tboxAsunto.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Direccion";
            // 
            // tboxDireccion
            // 
            this.tboxDireccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxDireccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxDireccion.Location = new System.Drawing.Point(111, 57);
            this.tboxDireccion.Name = "tboxDireccion";
            this.tboxDireccion.Size = new System.Drawing.Size(224, 20);
            this.tboxDireccion.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Destinatario";
            // 
            // tboxRemitente
            // 
            this.tboxRemitente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxRemitente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxRemitente.Location = new System.Drawing.Point(123, 63);
            this.tboxRemitente.Name = "tboxRemitente";
            this.tboxRemitente.Size = new System.Drawing.Size(224, 20);
            this.tboxRemitente.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "No. Documento";
            // 
            // tboxNumeroDoc
            // 
            this.tboxNumeroDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxNumeroDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxNumeroDoc.Location = new System.Drawing.Point(123, 25);
            this.tboxNumeroDoc.Name = "tboxNumeroDoc";
            this.tboxNumeroDoc.ReadOnly = true;
            this.tboxNumeroDoc.Size = new System.Drawing.Size(224, 20);
            this.tboxNumeroDoc.TabIndex = 58;
            // 
            // butCancelar
            // 
            this.butCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancelar.Location = new System.Drawing.Point(287, 435);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(92, 29);
            this.butCancelar.TabIndex = 57;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            // 
            // butAceptar
            // 
            this.butAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butAceptar.Location = new System.Drawing.Point(180, 435);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(92, 29);
            this.butAceptar.TabIndex = 56;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tboxEmpresa);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tboxDireccion);
            this.groupBox1.Controls.Add(this.tboxTelefono);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 135);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remitente";
            // 
            // tboxEmpresa
            // 
            this.tboxEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxEmpresa.Location = new System.Drawing.Point(111, 21);
            this.tboxEmpresa.Name = "tboxEmpresa";
            this.tboxEmpresa.Size = new System.Drawing.Size(224, 20);
            this.tboxEmpresa.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 76;
            this.label10.Text = "Empresa";
            // 
            // RegRecExterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 490);
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
            this.Name = "RegRecExterna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegRecExterna";
            this.Load += new System.EventHandler(this.RegRecExterna_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tboxTelefono;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboxEmpresa;
        private System.Windows.Forms.Label label10;
    }
}