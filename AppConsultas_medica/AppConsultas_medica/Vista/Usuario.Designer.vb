<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuario))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblcierre = New System.Windows.Forms.Label()
        Me.lblclave = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblinicio = New System.Windows.Forms.Label()
        Me.lblarea = New System.Windows.Forms.Label()
        Me.lblpermiso = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.txtfiltrar = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.dgvusuario = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnmodificar2 = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnreigstrar = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtruta = New System.Windows.Forms.TextBox()
        Me.label16 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpcierre = New System.Windows.Forms.DateTimePicker()
        Me.dtpinicio = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbpermiso = New System.Windows.Forms.ComboBox()
        Me.txtarea = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtidusuario = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvusuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(819, 401)
        Me.TabControl1.TabIndex = 51
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage1.Controls.Add(Me.btnmodificar)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.btneliminar)
        Me.TabPage1.Controls.Add(Me.btncerrar)
        Me.TabPage1.Controls.Add(Me.txtfiltrar)
        Me.TabPage1.Controls.Add(Me.label2)
        Me.TabPage1.Controls.Add(Me.dgvusuario)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(811, 375)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'btnmodificar
        '
        Me.btnmodificar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnmodificar.FlatAppearance.BorderSize = 3
        Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), System.Drawing.Image)
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodificar.Location = New System.Drawing.Point(361, 207)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(119, 42)
        Me.btnmodificar.TabIndex = 59
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PictureBox2)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(599, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(209, 191)
        Me.GroupBox5.TabIndex = 58
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Imagen"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(6, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(198, 149)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblid)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.lblcierre)
        Me.GroupBox4.Controls.Add(Me.lblclave)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.lblinicio)
        Me.GroupBox4.Controls.Add(Me.lblarea)
        Me.GroupBox4.Controls.Add(Me.lblpermiso)
        Me.GroupBox4.Controls.Add(Me.lblnombre)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(588, 191)
        Me.GroupBox4.TabIndex = 57
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos Paciente"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblid.Location = New System.Drawing.Point(112, 34)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(148, 16)
        Me.lblid.TabIndex = 62
        Me.lblid.Text = "____________________"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 16)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Id usuario"
        '
        'lblcierre
        '
        Me.lblcierre.AutoSize = True
        Me.lblcierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcierre.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblcierre.Location = New System.Drawing.Point(409, 116)
        Me.lblcierre.Name = "lblcierre"
        Me.lblcierre.Size = New System.Drawing.Size(148, 16)
        Me.lblcierre.TabIndex = 60
        Me.lblcierre.Text = "____________________"
        '
        'lblclave
        '
        Me.lblclave.AutoSize = True
        Me.lblclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclave.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblclave.Location = New System.Drawing.Point(111, 151)
        Me.lblclave.Name = "lblclave"
        Me.lblclave.Size = New System.Drawing.Size(148, 16)
        Me.lblclave.TabIndex = 59
        Me.lblclave.Text = "____________________"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(309, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 16)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Hora Cierre"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 151)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 16)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Clave"
        '
        'lblinicio
        '
        Me.lblinicio.AutoSize = True
        Me.lblinicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinicio.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblinicio.Location = New System.Drawing.Point(409, 69)
        Me.lblinicio.Name = "lblinicio"
        Me.lblinicio.Size = New System.Drawing.Size(148, 16)
        Me.lblinicio.TabIndex = 56
        Me.lblinicio.Text = "____________________"
        '
        'lblarea
        '
        Me.lblarea.AutoSize = True
        Me.lblarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblarea.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblarea.Location = New System.Drawing.Point(409, 34)
        Me.lblarea.Name = "lblarea"
        Me.lblarea.Size = New System.Drawing.Size(148, 16)
        Me.lblarea.TabIndex = 55
        Me.lblarea.Text = "____________________"
        '
        'lblpermiso
        '
        Me.lblpermiso.AutoSize = True
        Me.lblpermiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpermiso.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblpermiso.Location = New System.Drawing.Point(111, 104)
        Me.lblpermiso.Name = "lblpermiso"
        Me.lblpermiso.Size = New System.Drawing.Size(148, 16)
        Me.lblpermiso.TabIndex = 50
        Me.lblpermiso.Text = "____________________"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblnombre.Location = New System.Drawing.Point(111, 69)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(148, 16)
        Me.lblnombre.TabIndex = 49
        Me.lblnombre.Text = "____________________"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(309, 34)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(37, 16)
        Me.Label26.TabIndex = 44
        Me.Label26.Text = "Area"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(309, 69)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 16)
        Me.Label27.TabIndex = 43
        Me.Label27.Text = "Hora Inicio"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 104)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 16)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Permiso"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Nombre"
        '
        'btneliminar
        '
        Me.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btneliminar.FlatAppearance.BorderSize = 3
        Me.btneliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), System.Drawing.Image)
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminar.Location = New System.Drawing.Point(524, 205)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(119, 43)
        Me.btneliminar.TabIndex = 55
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btncerrar
        '
        Me.btncerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btncerrar.FlatAppearance.BorderSize = 3
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.Image = CType(resources.GetObject("btncerrar.Image"), System.Drawing.Image)
        Me.btncerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncerrar.Location = New System.Drawing.Point(686, 203)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(119, 46)
        Me.btncerrar.TabIndex = 56
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'txtfiltrar
        '
        Me.txtfiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfiltrar.Location = New System.Drawing.Point(14, 226)
        Me.txtfiltrar.Name = "txtfiltrar"
        Me.txtfiltrar.Size = New System.Drawing.Size(153, 21)
        Me.txtfiltrar.TabIndex = 48
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(12, 203)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(45, 18)
        Me.label2.TabIndex = 50
        Me.label2.Text = "Filtrar"
        '
        'dgvusuario
        '
        Me.dgvusuario.AllowUserToAddRows = False
        Me.dgvusuario.AllowUserToDeleteRows = False
        Me.dgvusuario.AllowUserToResizeColumns = False
        Me.dgvusuario.AllowUserToResizeRows = False
        Me.dgvusuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvusuario.Location = New System.Drawing.Point(15, 255)
        Me.dgvusuario.Name = "dgvusuario"
        Me.dgvusuario.ReadOnly = True
        Me.dgvusuario.Size = New System.Drawing.Size(788, 115)
        Me.dgvusuario.TabIndex = 49
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage2.Controls.Add(Me.btnmodificar2)
        Me.TabPage2.Controls.Add(Me.btnlimpiar)
        Me.TabPage2.Controls.Add(Me.btnsalir)
        Me.TabPage2.Controls.Add(Me.btnreigstrar)
        Me.TabPage2.Controls.Add(Me.groupBox2)
        Me.TabPage2.Controls.Add(Me.groupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(811, 375)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'btnmodificar2
        '
        Me.btnmodificar2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnmodificar2.FlatAppearance.BorderSize = 3
        Me.btnmodificar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar2.Image = CType(resources.GetObject("btnmodificar2.Image"), System.Drawing.Image)
        Me.btnmodificar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodificar2.Location = New System.Drawing.Point(446, 293)
        Me.btnmodificar2.Name = "btnmodificar2"
        Me.btnmodificar2.Size = New System.Drawing.Size(119, 42)
        Me.btnmodificar2.TabIndex = 60
        Me.btnmodificar2.Text = "Modificar"
        Me.btnmodificar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmodificar2.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnlimpiar.FlatAppearance.BorderSize = 3
        Me.btnlimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.Image = CType(resources.GetObject("btnlimpiar.Image"), System.Drawing.Image)
        Me.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlimpiar.Location = New System.Drawing.Point(266, 292)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(119, 43)
        Me.btnlimpiar.TabIndex = 58
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnsalir.FlatAppearance.BorderSize = 3
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), System.Drawing.Image)
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsalir.Location = New System.Drawing.Point(616, 289)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(119, 43)
        Me.btnsalir.TabIndex = 57
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnreigstrar
        '
        Me.btnreigstrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnreigstrar.FlatAppearance.BorderSize = 3
        Me.btnreigstrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreigstrar.Image = CType(resources.GetObject("btnreigstrar.Image"), System.Drawing.Image)
        Me.btnreigstrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreigstrar.Location = New System.Drawing.Point(74, 289)
        Me.btnreigstrar.Name = "btnreigstrar"
        Me.btnreigstrar.Size = New System.Drawing.Size(119, 46)
        Me.btnreigstrar.TabIndex = 51
        Me.btnreigstrar.Text = "Registrar"
        Me.btnreigstrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnreigstrar.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.button3)
        Me.groupBox2.Controls.Add(Me.pictureBox1)
        Me.groupBox2.Controls.Add(Me.txtruta)
        Me.groupBox2.Controls.Add(Me.label16)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(533, 6)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(258, 240)
        Me.groupBox2.TabIndex = 56
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Imagen"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(6, 176)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(36, 15)
        Me.label7.TabIndex = 102
        Me.label7.Text = "Ruta:"
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.button3.Location = New System.Drawing.Point(6, 204)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(57, 26)
        Me.button3.TabIndex = 8
        Me.button3.Text = "...."
        Me.button3.UseVisualStyleBackColor = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(9, 20)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(243, 154)
        Me.pictureBox1.TabIndex = 98
        Me.pictureBox1.TabStop = False
        '
        'txtruta
        '
        Me.txtruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtruta.Location = New System.Drawing.Point(69, 207)
        Me.txtruta.Name = "txtruta"
        Me.txtruta.Size = New System.Drawing.Size(176, 21)
        Me.txtruta.TabIndex = 9
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.Location = New System.Drawing.Point(-236, 104)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(43, 17)
        Me.label16.TabIndex = 99
        Me.label16.Text = "Ruta :"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.dtpcierre)
        Me.groupBox1.Controls.Add(Me.dtpinicio)
        Me.groupBox1.Controls.Add(Me.Label9)
        Me.groupBox1.Controls.Add(Me.Label8)
        Me.groupBox1.Controls.Add(Me.cbpermiso)
        Me.groupBox1.Controls.Add(Me.txtarea)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.txtclave)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.txtidusuario)
        Me.groupBox1.Controls.Add(Me.txtnombre)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(6, 6)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(521, 240)
        Me.groupBox1.TabIndex = 55
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Datos del Usuario"
        '
        'dtpcierre
        '
        Me.dtpcierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpcierre.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpcierre.Location = New System.Drawing.Point(385, 88)
        Me.dtpcierre.Name = "dtpcierre"
        Me.dtpcierre.Size = New System.Drawing.Size(121, 22)
        Me.dtpcierre.TabIndex = 7
        '
        'dtpinicio
        '
        Me.dtpinicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpinicio.Location = New System.Drawing.Point(383, 55)
        Me.dtpinicio.Name = "dtpinicio"
        Me.dtpinicio.Size = New System.Drawing.Size(121, 22)
        Me.dtpinicio.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(257, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 16)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Inicio Sesion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(257, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 16)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Cierre Sesion"
        '
        'cbpermiso
        '
        Me.cbpermiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbpermiso.FormattingEnabled = True
        Me.cbpermiso.Location = New System.Drawing.Point(114, 90)
        Me.cbpermiso.Name = "cbpermiso"
        Me.cbpermiso.Size = New System.Drawing.Size(121, 24)
        Me.cbpermiso.TabIndex = 3
        '
        'txtarea
        '
        Me.txtarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtarea.Location = New System.Drawing.Point(383, 26)
        Me.txtarea.Name = "txtarea"
        Me.txtarea.Size = New System.Drawing.Size(121, 22)
        Me.txtarea.TabIndex = 5
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(257, 29)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(37, 16)
        Me.label6.TabIndex = 45
        Me.label6.Text = "Area"
        '
        'txtclave
        '
        Me.txtclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclave.Location = New System.Drawing.Point(114, 126)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtclave.Size = New System.Drawing.Size(121, 22)
        Me.txtclave.TabIndex = 4
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(11, 29)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(69, 16)
        Me.label3.TabIndex = 43
        Me.label3.Text = "Id Usuario"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(11, 93)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(89, 16)
        Me.label4.TabIndex = 41
        Me.label4.Text = "Tipo Permiso"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(11, 129)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(43, 16)
        Me.label5.TabIndex = 39
        Me.label5.Text = "Clave"
        '
        'txtidusuario
        '
        Me.txtidusuario.Enabled = False
        Me.txtidusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidusuario.Location = New System.Drawing.Point(114, 26)
        Me.txtidusuario.Name = "txtidusuario"
        Me.txtidusuario.Size = New System.Drawing.Size(121, 22)
        Me.txtidusuario.TabIndex = 1
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(114, 58)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(121, 22)
        Me.txtnombre.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(11, 60)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(57, 16)
        Me.label1.TabIndex = 36
        Me.label1.Text = "Nombre"
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(824, 397)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuario"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvusuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Private WithEvents btneliminar As System.Windows.Forms.Button
    Private WithEvents btncerrar As System.Windows.Forms.Button
    Private WithEvents txtfiltrar As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents dgvusuario As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Private WithEvents btnsalir As System.Windows.Forms.Button
    Private WithEvents btnreigstrar As System.Windows.Forms.Button
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents txtruta As System.Windows.Forms.TextBox
    Private WithEvents label16 As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpcierre As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpinicio As System.Windows.Forms.DateTimePicker
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents cbpermiso As System.Windows.Forms.ComboBox
    Private WithEvents txtarea As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents txtclave As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents txtidusuario As System.Windows.Forms.TextBox
    Private WithEvents txtnombre As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblinicio As System.Windows.Forms.Label
    Friend WithEvents lblarea As System.Windows.Forms.Label
    Friend WithEvents lblpermiso As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents lblcierre As System.Windows.Forms.Label
    Friend WithEvents lblclave As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents btnlimpiar As System.Windows.Forms.Button
    Private WithEvents btnmodificar2 As System.Windows.Forms.Button
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
