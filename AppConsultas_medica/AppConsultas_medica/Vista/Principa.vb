Imports System.Windows.Forms

Public Class Principa
    Dim Ingred = RGB(100%, 0%, 0%)

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub PacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacienteToolStripMenuItem.Click
        Paciente.MdiParent = Me
        Paciente.Show()
    End Sub

    Private Sub MedicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicoToolStripMenuItem.Click
        Medico.MdiParent = Me
        Medico.Show()
    End Sub

    Private Sub CitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CitaToolStripMenuItem.Click
        Cita.MdiParent = Me
        Cita.Show()
    End Sub

    Private Sub SalaMedicasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaMedicasToolStripMenuItem.Click
        Sala.MdiParent = Me
        Sala.Show()
    End Sub

    Private Sub TurnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TurnoToolStripMenuItem.Click
        Turno.MdiParent = Me
        Turno.Show()
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem.Click
        consulta_medica.MdiParent = Me
        consulta_medica.Show()
    End Sub

    Private Sub AgendaMedicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendaMedicaToolStripMenuItem.Click
        AgendaMedica.MdiParent = Me
        AgendaMedica.Show()
    End Sub

    Private Function StatusBarToolStripMenuItem() As Object
        Throw New NotImplementedException
    End Function

    Private Function ToolBarToolStripMenuItem() As Object
        Throw New NotImplementedException
    End Function

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        Usuario.MdiParent = Me
        Usuario.Show()
    End Sub



    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
    End Sub

    Private Sub Principa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.PictureBox1.Visible = False
        'Me.Label1.Parent = PictureBox1
        '  Me.Label3.Parent = New Principa()
        ' Me.Label4.Parent = New Principa()
        ' Me.Label5.Parent = New Principa()
        ' Me.Label6.Parent = New Principa()
        ' Me.Label7.Parent = New Principa()
        ' Me.Label8.Parent = New Principa()

        ' Me.Label3.ForeColor = Color.Black
        'Me.TransparencyKey = Me.BackColor
        '  Me.lblmedico.BackColor = RGB(CInt(Rnd() * 100), CInt(Rnd() * 0), CInt(Rnd() * 0))
        'RGB(100%, 0%, 0%)
    End Sub
End Class
