Imports MySql.Data.MySqlClient
Imports PermisosUsuarios.PermisosUsuarios.ClasesComunes

Public Class FormEdit
    Private _codigo As Integer

    ' Clase para representar el estado

    Public Sub New(codigo As Integer, usuario As String, apellido1 As String, apellido2 As String, nombre1 As String, nombre2 As String, estado As Integer)
        InitializeComponent()

        ' Asignar valores a los controles
        _codigo = codigo
        txtUsuario.Text = usuario
        txtApellido1.Text = apellido1
        txtApellido2.Text = apellido2
        txtNombre1.Text = nombre1
        txtNombre2.Text = nombre2

        ' Cargar el ComboBox con opciones de estado
        cmbEstado.Items.Add(New EstadoEmpleado("Activo", 1))
        cmbEstado.Items.Add(New EstadoEmpleado("Inactivo", 0))

        ' Seleccionar el estado actual
        For Each item As EstadoEmpleado In cmbEstado.Items
            If item.Valor = estado Then
                cmbEstado.SelectedItem = item
                Exit For
            End If
        Next
    End Sub

    ' Manejar el evento del botón de guardar
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using connection As MySqlConnection = GetConnection()
            Dim query As String = "UPDATE Personal SET per_usuario = @usuario, per_apellido1 = @apellido1, per_apellido2 = @apellido2, per_nombre1 = @nombre1, per_nombre2 = @nombre2, per_estado = @estado WHERE per_codigo = @codigo"

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@codigo", _codigo)
                command.Parameters.AddWithValue("@usuario", txtUsuario.Text)
                command.Parameters.AddWithValue("@apellido1", txtApellido1.Text)
                command.Parameters.AddWithValue("@apellido2", txtApellido2.Text)
                command.Parameters.AddWithValue("@nombre1", txtNombre1.Text)
                command.Parameters.AddWithValue("@nombre2", txtNombre2.Text)
                command.Parameters.AddWithValue("@estado", CType(cmbEstado.SelectedItem, EstadoEmpleado).Valor)


                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub FormEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
