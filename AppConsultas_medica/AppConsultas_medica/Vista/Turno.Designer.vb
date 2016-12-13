<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Turno))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtespecialidad = New System.Windows.Forms.TextBox()
        Me.btnsala = New System.Windows.Forms.Button()
        Me.txtsala = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btncita = New System.Windows.Forms.Button()
        Me.btnmedico = New System.Windows.Forms.Button()
        Me.dtphora = New System.Windows.Forms.DateTimePicker()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtcita = New System.Windows.Forms.TextBox()
        Me.txtmedico = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnmodifica = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnregistrar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvturno = New System.Windows.Forms.DataGridView()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtfiltro = New System.Windows.Forms.TextBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.txtturno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvturno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(-86, 114)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "No"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtturno)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtespecialidad)
        Me.GroupBox1.Controls.Add(Me.btnsala)
        Me.GroupBox1.Controls.Add(Me.txtsala)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btncita)
        Me.GroupBox1.Controls.Add(Me.btnmedico)
        Me.GroupBox1.Controls.Add(Me.dtphora)
        Me.GroupBox1.Controls.Add(Me.dtfecha)
        Me.GroupBox1.Controls.Add(Me.txtcita)
        Me.GroupBox1.Controls.Add(Me.txtmedico)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtnumero)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(683, 224)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos  Del Turno"
        '
        'txtespecialidad
        '
        Me.txtespecialidad.Location = New System.Drawing.Point(131, 170)
        Me.txtespecialidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtespecialidad.Name = "txtespecialidad"
        Me.txtespecialidad.Size = New System.Drawing.Size(168, 24)
        Me.txtespecialidad.TabIndex = 3
        '
        'btnsala
        '
        Me.btnsala.BackgroundImage = CType(resources.GetObject("btnsala.BackgroundImage"), System.Drawing.Image)
        Me.btnsala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsala.Location = New System.Drawing.Point(636, 128)
        Me.btnsala.Name = "btnsala"
        Me.btnsala.Size = New System.Drawing.Size(38, 29)
        Me.btnsala.TabIndex = 61
        Me.btnsala.UseVisualStyleBackColor = True
        '
        'txtsala
        '
        Me.txtsala.Location = New System.Drawing.Point(467, 133)
        Me.txtsala.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsala.Name = "txtsala"
        Me.txtsala.Size = New System.Drawing.Size(162, 24)
        Me.txtsala.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(356, 135)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 16)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Sala"
        '
        'btncita
        '
        Me.btncita.BackgroundImage = CType(resources.GetObject("btncita.BackgroundImage"), System.Drawing.Image)
        Me.btncita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncita.Location = New System.Drawing.Point(636, 169)
        Me.btncita.Name = "btncita"
        Me.btncita.Size = New System.Drawing.Size(38, 29)
        Me.btncita.TabIndex = 58
        Me.btncita.UseVisualStyleBackColor = True
        '
        'btnmedico
        '
        Me.btnmedico.BackgroundImage = CType(resources.GetObject("btnmedico.BackgroundImage"), System.Drawing.Image)
        Me.btnmedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnmedico.Location = New System.Drawing.Point(306, 126)
        Me.btnmedico.Name = "btnmedico"
        Me.btnmedico.Size = New System.Drawing.Size(38, 29)
        Me.btnmedico.TabIndex = 57
        Me.btnmedico.UseVisualStyleBackColor = True
        '
        'dtphora
        '
        Me.dtphora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtphora.Location = New System.Drawing.Point(467, 92)
        Me.dtphora.Name = "dtphora"
        Me.dtphora.Size = New System.Drawing.Size(200, 24)
        Me.dtphora.TabIndex = 6
        '
        'dtfecha
        '
        Me.dtfecha.Location = New System.Drawing.Point(467, 51)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(200, 24)
        Me.dtfecha.TabIndex = 5
        '
        'txtcita
        '
        Me.txtcita.Location = New System.Drawing.Point(467, 174)
        Me.txtcita.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcita.Name = "txtcita"
        Me.txtcita.Size = New System.Drawing.Size(162, 24)
        Me.txtcita.TabIndex = 8
        '
        'txtmedico
        '
        Me.txtmedico.Location = New System.Drawing.Point(131, 131)
        Me.txtmedico.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmedico.Name = "txtmedico"
        Me.txtmedico.Size = New System.Drawing.Size(168, 24)
        Me.txtmedico.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 133)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 16)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Medico"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(356, 94)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Hora"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(356, 53)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Fecha"
        '
        'txtnumero
        '
        Me.txtnumero.Enabled = False
        Me.txtnumero.Location = New System.Drawing.Point(131, 53)
        Me.txtnumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(168, 24)
        Me.txtnumero.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(356, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "No. Cita"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-1, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Especialidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "No. Turno"
        '
        'btnmodifica
        '
        Me.btnmodifica.Image = CType(resources.GetObject("btnmodifica.Image"), System.Drawing.Image)
        Me.btnmodifica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodifica.Location = New System.Drawing.Point(153, 244)
        Me.btnmodifica.Name = "btnmodifica"
        Me.btnmodifica.Size = New System.Drawing.Size(114, 48)
        Me.btnmodifica.TabIndex = 11
        Me.btnmodifica.Text = "Modifcar"
        Me.btnmodifica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmodifica.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(419, 244)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(114, 48)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Imprimir"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), System.Drawing.Image)
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminar.Location = New System.Drawing.Point(286, 244)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(114, 48)
        Me.btneliminar.TabIndex = 12
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnregistrar
        '
        Me.btnregistrar.Image = CType(resources.GetObject("btnregistrar.Image"), System.Drawing.Image)
        Me.btnregistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnregistrar.Location = New System.Drawing.Point(20, 244)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(114, 48)
        Me.btnregistrar.TabIndex = 10
        Me.btnregistrar.Text = "Registrar"
        Me.btnregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnregistrar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvturno)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(14, 326)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(659, 174)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Turno Registrados"
        '
        'dgvturno
        '
        Me.dgvturno.AllowUserToAddRows = False
        Me.dgvturno.AllowUserToDeleteRows = False
        Me.dgvturno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvturno.Location = New System.Drawing.Point(6, 23)
        Me.dgvturno.Name = "dgvturno"
        Me.dgvturno.ReadOnly = True
        Me.dgvturno.Size = New System.Drawing.Size(647, 144)
        Me.dgvturno.TabIndex = 42
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(446, 307)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(41, 16)
        Me.Label22.TabIndex = 56
        Me.Label22.Text = "Filtrar"
        '
        'txtfiltro
        '
        Me.txtfiltro.Location = New System.Drawing.Point(503, 307)
        Me.txtfiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(168, 20)
        Me.txtfiltro.TabIndex = 9
        '
        'btnsalir
        '
        Me.btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), System.Drawing.Image)
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsalir.Location = New System.Drawing.Point(552, 244)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(114, 48)
        Me.btnsalir.TabIndex = 14
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'txtturno
        '
        Me.txtturno.Location = New System.Drawing.Point(131, 92)
        Me.txtturno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtturno.Name = "txtturno"
        Me.txtturno.Size = New System.Drawing.Size(168, 24)
        Me.txtturno.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(-1, 95)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 16)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Turno"
        '
        'Turno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(691, 505)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.txtfiltro)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnregistrar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btnmodifica)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.MaximizeBox = False
        Me.Name = "Turno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turno"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvturno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsala As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btncita As System.Windows.Forms.Button
    Friend WithEvents btnmedico As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnmodifica As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnregistrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvturno As System.Windows.Forms.DataGridView
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtfiltro As System.Windows.Forms.TextBox
    Public WithEvents txtsala As System.Windows.Forms.TextBox
    Public WithEvents dtphora As System.Windows.Forms.DateTimePicker
    Public WithEvents dtfecha As System.Windows.Forms.DateTimePicker
    Public WithEvents txtcita As System.Windows.Forms.TextBox
    Public WithEvents txtmedico As System.Windows.Forms.TextBox
    Public WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Public WithEvents txtespecialidad As System.Windows.Forms.TextBox
    Public WithEvents txtturno As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
