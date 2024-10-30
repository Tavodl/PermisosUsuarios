Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.CurrentCulture = New System.Globalization.CultureInfo("es")

        'Cargar datos
        LoadData()

    End Sub

    'CARGA REGISTRO USUARIOS
    Private Sub LoadData()
        Using connection As MySqlConnection = GetConnection()
            Dim query As String = "SELECT per_codigo AS 'Codigo', per_usuario AS 'Usuario', per_apellido1 AS 'Primer Apellido', per_apellido2 AS 'Segundo Apellido', per_nombre1 AS 'Primer Nombre', per_nombre2 AS 'Segundo Nombre', per_estado AS 'Estado' FROM Personal"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()

            adapter.Fill(table)



            DataGridView1.DataSource = table
        End Using
    End Sub


    'EVENTO CLICK PARA EDITAR
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If DataGridView1.SelectedRows.Count = 1 Then
            Dim selectedRow = DataGridView1.SelectedRows(0)
            Dim codigo As Integer = selectedRow.Cells("Codigo").Value
            Dim usuario = selectedRow.Cells("Usuario").Value.ToString
            Dim apellido1 = selectedRow.Cells("Primer Apellido").Value.ToString
            Dim apellido2 = selectedRow.Cells("Segundo Apellido").Value.ToString
            Dim nombre1 = selectedRow.Cells("Primer Nombre").Value.ToString
            Dim nombre2 = selectedRow.Cells("Segundo Nombre").Value.ToString
            Dim estado As Integer = selectedRow.Cells("Estado").Value

            Dim editForm As New FormEdit(codigo, usuario, apellido1, apellido2, nombre1, nombre2, estado)
            If editForm.ShowDialog = DialogResult.OK Then
                LoadData()
            End If
        Else
            MessageBox.Show("Por favor, seleccione una fila para editar.")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim RegistroForm As New FormRegistro()
        If RegistroForm.ShowDialog = DialogResult.OK Then
            ' Llamar al método para recargar los datos en el DataGrid
            LoadData()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Verificar si hay una fila seleccionada
        If DataGridView1.SelectedRows.Count = 1 Then
            ' Mostrar mensaje de confirmación
            Dim resultado As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            ' Si el usuario confirma la eliminación
            If resultado = DialogResult.Yes Then
                ' Obtener el código del usuario de la fila seleccionada
                Dim codigo As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("Codigo").Value)

                Using connection As MySqlConnection = GetConnection()
                    Dim query As String = "DELETE FROM Personal WHERE per_codigo = @codigo"

                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@codigo", codigo)

                        connection.Open()
                        command.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Usuario eliminado con éxito.")
                ' Llamar a la función para refrescar la lista después de la eliminación
                LoadData()
            End If
        Else
            MessageBox.Show("Por favor, seleccione una fila para eliminar.")
        End If
    End Sub

    Private Sub AsignaPermiso_Click(sender As Object, e As EventArgs) Handles AsignaPermiso.Click
        If DataGridView1.SelectedRows.Count = 1 Then
            Dim selectedRow = DataGridView1.SelectedRows(0)
            Dim codigo As Integer = selectedRow.Cells("Codigo").Value
            Dim usuario = selectedRow.Cells("Usuario").Value.ToString
            Dim apellido1 = selectedRow.Cells("Primer Apellido").Value.ToString
            Dim apellido2 = selectedRow.Cells("Segundo Apellido").Value.ToString
            Dim nombre1 = selectedRow.Cells("Primer Nombre").Value.ToString
            Dim nombre2 = selectedRow.Cells("Segundo Nombre").Value.ToString
            Dim estado As Integer = selectedRow.Cells("Estado").Value

            Dim AsignaPermisoForm As New FormAsignaPermiso(codigo, usuario, apellido1, apellido2, nombre1, nombre2, estado)
            If AsignaPermisoForm.ShowDialog = DialogResult.OK Then
                LoadData()
            End If
        Else
            MessageBox.Show("Por favor, seleccione una fila para continuar.")
        End If
    End Sub
End Class
