Imports MySql.Data.MySqlClient
Imports PermisosUsuarios.PermisosUsuarios.ClasesComunes

Public Class FormRegistro
    ' Constructor
    Public Sub New()
        InitializeComponent()
        ' Cargar el ComboBox al iniciar
        CargarComboBox()
    End Sub

    ' Método para cargar el ComboBox
    Private Sub CargarComboBox()
        cmbEstado.Items.Add(New EstadoEmpleado("Activo", 1))
        cmbEstado.Items.Add(New EstadoEmpleado("Inactivo", 0))
    End Sub

    ' Manejar el evento del botón de guardar
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        btnSave.Enabled = False ' Deshabilitar el botón


        Try
            ' Validar que los campos no estén vacíos
            If String.IsNullOrWhiteSpace(txtUsuario.Text) OrElse
           String.IsNullOrWhiteSpace(txtApellido1.Text) OrElse
           String.IsNullOrWhiteSpace(txtNombre1.Text) OrElse
           cmbEstado.SelectedItem Is Nothing Then

                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Salir del método si hay un campo vacío
            End If

            ' Lógica para guardar el nuevo usuario en la base de datos
            Using connection As MySqlConnection = GetConnection()
                Dim query As String = "INSERT INTO Personal (per_usuario, per_apellido1, per_apellido2, per_nombre1, per_nombre2, per_estado) VALUES (@usuario, @apellido1, @apellido2, @nombre1, @nombre2, @estado)"

                Using command As New MySqlCommand(query, connection)
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

            MessageBox.Show("Usuario registrado con éxito.")
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al registrar el usuario: " & ex.Message)
        Finally
            btnSave.Enabled = True ' Habilitar el botón de nuevo
        End Try
    End Sub

    ' Clase Estado


End Class
