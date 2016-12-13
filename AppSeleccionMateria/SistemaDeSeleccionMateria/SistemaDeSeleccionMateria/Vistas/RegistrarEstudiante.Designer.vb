<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarEstudiante
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
        Me.cedulaUsuarioTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombreUsuarioTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cuentaUsuarioTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.claveUsuarioTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.confirmacionClaveTxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.apellidoUsuarioTxt = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.sexsoUsuarioCbb = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.picturePerfil = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.picturePerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cedulaUsuarioTxt
        '
        Me.cedulaUsuarioTxt.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cedulaUsuarioTxt.ForeColor = System.Drawing.Color.DimGray
        Me.cedulaUsuarioTxt.Location = New System.Drawing.Point(10, 86)
        Me.cedulaUsuarioTxt.Name = "cedulaUsuarioTxt"
        Me.cedulaUsuarioTxt.Size = New System.Drawing.Size(218, 23)
        Me.cedulaUsuarioTxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(5, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Cedula:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(5, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre:"
        '
        'nombreUsuarioTxt
        '
        Me.nombreUsuarioTxt.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombreUsuarioTxt.ForeColor = System.Drawing.Color.DimGray
        Me.nombreUsuarioTxt.Location = New System.Drawing.Point(10, 138)
        Me.nombreUsuarioTxt.Name = "nombreUsuarioTxt"
        Me.nombreUsuarioTxt.Size = New System.Drawing.Size(218, 23)
        Me.nombreUsuarioTxt.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(4, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Cuenta:"
        '
        'cuentaUsuarioTxt
        '
        Me.cuentaUsuarioTxt.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuentaUsuarioTxt.ForeColor = System.Drawing.Color.DimGray
        Me.cuentaUsuarioTxt.Location = New System.Drawing.Point(9, 247)
        Me.cuentaUsuarioTxt.Name = "cuentaUsuarioTxt"
        Me.cuentaUsuarioTxt.Size = New System.Drawing.Size(218, 23)
        Me.cuentaUsuarioTxt.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(5, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 25)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Clave:"
        '
        'claveUsuarioTxt
        '
        Me.claveUsuarioTxt.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.claveUsuarioTxt.ForeColor = System.Drawing.Color.DimGray
        Me.claveUsuarioTxt.Location = New System.Drawing.Point(10, 376)
        Me.claveUsuarioTxt.Name = "claveUsuarioTxt"
        Me.claveUsuarioTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.claveUsuarioTxt.Size = New System.Drawing.Size(218, 23)
        Me.claveUsuarioTxt.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(5, 408)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 25)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Reingresa la Clave:"
        '
        'confirmacionClaveTxt
        '
        Me.confirmacionClaveTxt.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmacionClaveTxt.ForeColor = System.Drawing.Color.DimGray
        Me.confirmacionClaveTxt.Location = New System.Drawing.Point(10, 436)
        Me.confirmacionClaveTxt.Name = "confirmacionClaveTxt"
        Me.confirmacionClaveTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.confirmacionClaveTxt.Size = New System.Drawing.Size(218, 23)
        Me.confirmacionClaveTxt.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(392, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 35)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(242, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Imagen de perfil:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(247, 255)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(263, 35)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cargar imagen"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(522, 55)
        Me.Panel1.TabIndex = 26
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(520, 5)
        Me.Panel2.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Snow
        Me.Label7.Location = New System.Drawing.Point(3, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(341, 32)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Registro de cuenta estudiante"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Symbol", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(7, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 12)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "@sitema"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(4, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 25)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Apellido:"
        '
        'apellidoUsuarioTxt
        '
        Me.apellidoUsuarioTxt.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apellidoUsuarioTxt.ForeColor = System.Drawing.Color.DimGray
        Me.apellidoUsuarioTxt.Location = New System.Drawing.Point(9, 191)
        Me.apellidoUsuarioTxt.Name = "apellidoUsuarioTxt"
        Me.apellidoUsuarioTxt.Size = New System.Drawing.Size(218, 23)
        Me.apellidoUsuarioTxt.TabIndex = 2
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'sexsoUsuarioCbb
        '
        Me.sexsoUsuarioCbb.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!)
        Me.sexsoUsuarioCbb.FormattingEnabled = True
        Me.sexsoUsuarioCbb.Items.AddRange(New Object() {"Maculino", "Femenino", "Otro"})
        Me.sexsoUsuarioCbb.Location = New System.Drawing.Point(12, 322)
        Me.sexsoUsuarioCbb.Name = "sexsoUsuarioCbb"
        Me.sexsoUsuarioCbb.Size = New System.Drawing.Size(215, 23)
        Me.sexsoUsuarioCbb.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(7, 294)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 25)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Sexo:"
        '
        'picturePerfil
        '
        Me.picturePerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picturePerfil.Location = New System.Drawing.Point(247, 84)
        Me.picturePerfil.Name = "picturePerfil"
        Me.picturePerfil.Size = New System.Drawing.Size(263, 158)
        Me.picturePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picturePerfil.TabIndex = 23
        Me.picturePerfil.TabStop = False
        '
        'RegistrarEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(522, 467)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.sexsoUsuarioCbb)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.apellidoUsuarioTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.picturePerfil)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.confirmacionClaveTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.claveUsuarioTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cuentaUsuarioTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nombreUsuarioTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cedulaUsuarioTxt)
        Me.Name = "RegistrarEstudiante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrarEstudiante"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picturePerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cedulaUsuarioTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nombreUsuarioTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cuentaUsuarioTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents claveUsuarioTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents confirmacionClaveTxt As System.Windows.Forms.TextBox
    Public WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents picturePerfil As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents apellidoUsuarioTxt As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sexsoUsuarioCbb As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
