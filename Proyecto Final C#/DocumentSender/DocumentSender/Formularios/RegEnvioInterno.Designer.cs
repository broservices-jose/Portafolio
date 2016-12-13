namespace DocumentSender.Formularios
{
    partial class RegEnvioInterno
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
            this.tboxNumeroDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxRemitente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxDestinatario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxAsunto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.tboxHora = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxMensajero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butCancelar
            // 
            this.butCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancelar.Location = new System.Drawing.Point(282, 343);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(92, 29);
            this.butCancelar.TabIndex = 21;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            // 
            // butAceptar
            // 
            this.butAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butAceptar.Location = new System.Drawing.Point(175, 343);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(92, 29);
            this.butAceptar.TabIndex = 20;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // tboxNumeroDoc
            // 
            this.tboxNumeroDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxNumeroDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxNumeroDoc.Location = new System.Drawing.Point(118, 52);
            this.tboxNumeroDoc.Name = "tboxNumeroDoc";
            this.tboxNumeroDoc.ReadOnly = true;
            this.tboxNumeroDoc.Size = new System.Drawing.Size(224, 20);
            this.tboxNumeroDoc.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "No. Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Remitente";
            // 
            // tboxRemitente
            // 
            this.tboxRemitente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxRemitente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxRemitente.Location = new System.Drawing.Point(118, 90);
            this.tboxRemitente.Name = "tboxRemitente";
            this.tboxRemitente.Size = new System.Drawing.Size(224, 20);
            this.tboxRemitente.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Destinatario";
            // 
            // tboxDestinatario
            // 
            this.tboxDestinatario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxDestinatario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxDestinatario.Location = new System.Drawing.Point(118, 127);
            this.tboxDestinatario.Name = "tboxDestinatario";
            this.tboxDestinatario.Size = new System.Drawing.Size(224, 20);
            this.tboxDestinatario.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Asunto";
            // 
            // tboxAsunto
            // 
            this.tboxAsunto.Location = new System.Drawing.Point(118, 202);
            this.tboxAsunto.Name = "tboxAsunto";
            this.tboxAsunto.Size = new System.Drawing.Size(224, 20);
            this.tboxAsunto.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fecha de envio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Hora de envio";
            // 
            // dateFecha
            // 
            this.dateFecha.CustomFormat = "";
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(118, 239);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(111, 20);
            this.dateFecha.TabIndex = 32;
            // 
            // tboxHora
            // 
            this.tboxHora.Location = new System.Drawing.Point(118, 281);
            this.tboxHora.Mask = "00:00";
            this.tboxHora.Name = "tboxHora";
            this.tboxHora.Size = new System.Drawing.Size(35, 20);
            this.tboxHora.TabIndex = 33;
            this.tboxHora.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "(hora en formato militar)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Mensajero";
            // 
            // tboxMensajero
            // 
            this.tboxMensajero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tboxMensajero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tboxMensajero.Location = new System.Drawing.Point(118, 163);
            this.tboxMensajero.Name = "tboxMensajero";
            this.tboxMensajero.Size = new System.Drawing.Size(224, 20);
            this.tboxMensajero.TabIndex = 35;
            // 
            // RegEnvioInterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 401);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tboxMensajero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tboxHora);
            this.Controls.Add(this.dateFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxAsunto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxDestinatario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxRemitente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxNumeroDoc);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.butAceptar);
            this.Name = "RegEnvioInterno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar envio inter-departamental";
            this.Load += new System.EventHandler(this.RegEnvioInterno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.TextBox tboxNumeroDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxRemitente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxDestinatario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxAsunto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.MaskedTextBox tboxHora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxMensajero;
    }
}