namespace AppDiagramaClase
{
    partial class Clienteregistrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clienteregistrado));
            this.dgvclienter = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclienter)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvclienter
            // 
            this.dgvclienter.AllowUserToAddRows = false;
            this.dgvclienter.AllowUserToDeleteRows = false;
            this.dgvclienter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclienter.Location = new System.Drawing.Point(60, 33);
            this.dgvclienter.Name = "dgvclienter";
            this.dgvclienter.ReadOnly = true;
            this.dgvclienter.Size = new System.Drawing.Size(1171, 161);
            this.dgvclienter.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1131, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cargar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Clienteregistrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvclienter);
            this.Name = "Clienteregistrado";
            this.Text = "Clientes Registrado";
            this.Load += new System.EventHandler(this.Clienteregistrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclienter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvclienter;
        private System.Windows.Forms.Button button1;
    }
}