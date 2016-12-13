namespace AppDiagramaClase
{
    partial class Vehiculosregistrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehiculosregistrado));
            this.dgvvehiculor = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvehiculor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvvehiculor
            // 
            this.dgvvehiculor.AllowUserToAddRows = false;
            this.dgvvehiculor.AllowUserToDeleteRows = false;
            this.dgvvehiculor.AllowUserToResizeColumns = false;
            this.dgvvehiculor.AllowUserToResizeRows = false;
            this.dgvvehiculor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvehiculor.Location = new System.Drawing.Point(24, 12);
            this.dgvvehiculor.Name = "dgvvehiculor";
            this.dgvvehiculor.Size = new System.Drawing.Size(872, 124);
            this.dgvvehiculor.TabIndex = 0;
            this.dgvvehiculor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvehiculor_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(789, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cargar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vehiculosregistrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 193);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvvehiculor);
            this.Name = "Vehiculosregistrado";
            this.Text = "Vehiculosregistrado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvvehiculor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvvehiculor;
        private System.Windows.Forms.Button button1;
    }
}