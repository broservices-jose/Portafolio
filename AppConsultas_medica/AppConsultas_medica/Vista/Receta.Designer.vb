<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Receta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rtreceta = New System.Windows.Forms.RichTextBox()
        Me.rtindicaciones = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfiltro = New System.Windows.Forms.TextBox()
        Me.btnregistrar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btncargar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Medicamentos de la Receta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Indicaciones"
        '
        'rtreceta
        '
        Me.rtreceta.Location = New System.Drawing.Point(13, 83)
        Me.rtreceta.Name = "rtreceta"
        Me.rtreceta.Size = New System.Drawing.Size(223, 57)
        Me.rtreceta.TabIndex = 2
        Me.rtreceta.Text = ""
        '
        'rtindicaciones
        '
        Me.rtindicaciones.Location = New System.Drawing.Point(267, 83)
        Me.rtindicaciones.Name = "rtindicaciones"
        Me.rtindicaciones.Size = New System.Drawing.Size(230, 57)
        Me.rtindicaciones.TabIndex = 3
        Me.rtindicaciones.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID receta"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(111, 19)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(167, 20)
        Me.txtid.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 239)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(372, 86)
        Me.DataGridView1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Filtrar"
        '
        'txtfiltro
        '
        Me.txtfiltro.Location = New System.Drawing.Point(59, 208)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(167, 20)
        Me.txtfiltro.TabIndex = 8
        '
        'btnregistrar
        '
        Me.btnregistrar.Image = CType(resources.GetObject("btnregistrar.Image"), System.Drawing.Image)
        Me.btnregistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnregistrar.Location = New System.Drawing.Point(365, 155)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(132, 39)
        Me.btnregistrar.TabIndex = 51
        Me.btnregistrar.Text = "Registrar"
        Me.btnregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnregistrar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), System.Drawing.Image)
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminar.Location = New System.Drawing.Point(232, 155)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(132, 40)
        Me.btneliminar.TabIndex = 50
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnimprimir
        '
        Me.btnimprimir.Image = CType(resources.GetObject("btnimprimir.Image"), System.Drawing.Image)
        Me.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnimprimir.Location = New System.Drawing.Point(232, 196)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(132, 37)
        Me.btnimprimir.TabIndex = 49
        Me.btnimprimir.Text = "Imprimir"
        Me.btnimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnimprimir.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), System.Drawing.Image)
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodificar.Location = New System.Drawing.Point(365, 196)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(132, 37)
        Me.btnmodificar.TabIndex = 48
        Me.btnmodificar.Text = "Modifcar"
        Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btncargar
        '
        Me.btncargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncargar.Image = CType(resources.GetObject("btncargar.Image"), System.Drawing.Image)
        Me.btncargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncargar.Location = New System.Drawing.Point(391, 239)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(106, 36)
        Me.btncargar.TabIndex = 52
        Me.btncargar.Text = "Cargar"
        Me.btncargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncargar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), System.Drawing.Image)
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsalir.Location = New System.Drawing.Point(391, 281)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(106, 44)
        Me.btnsalir.TabIndex = 53
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Receta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(511, 337)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncargar)
        Me.Controls.Add(Me.btnregistrar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnimprimir)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.txtfiltro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rtindicaciones)
        Me.Controls.Add(Me.rtreceta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Receta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rtreceta As System.Windows.Forms.RichTextBox
    Friend WithEvents rtindicaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtfiltro As System.Windows.Forms.TextBox
    Friend WithEvents btnregistrar As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnimprimir As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents btncargar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
End Class
