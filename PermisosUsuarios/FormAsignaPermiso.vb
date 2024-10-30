Imports MySql.Data.MySqlClient
Imports PermisosUsuarios.PermisosUsuarios.ClasesComunes
Public Class FormAsignaPermiso
    Private _codigoId As Integer
    Private _usuario As String
    Private _apellido1 As String
    Private _apellido2 As String
    Private _nombre1 As String
    Private _nombre2 As String
    Private _estado As Integer
    ' Clase para representar el estado

    ' Constructor
    Public Sub New(codigo As Integer, usuario As String, apellido1 As String, apellido2 As String, nombre1 As String, nombre2 As String, estado As Integer)
        InitializeComponent()

        ' Asignar valores a los TextBox
        'txtCodigo.Text = codigo.ToString()
        _codigoId = codigo
        _usuario = usuario
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

    Private Sub FormAsignaPermiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAccesos()

        'Bloquear campos
        txtUsuario.ReadOnly = True
        txtNombre1.ReadOnly = True
        txtApellido1.ReadOnly = True
        txtApellido2.ReadOnly = True
        txtNombre2.ReadOnly = True
        cmbEstado.Enabled = False

    End Sub



    ' Cargar registros
    Private Sub LoadAccesos()
        Try
            Using connection As MySqlConnection = GetConnection()
                Dim query As String = "
            SELECT
                p.pro_codigo AS codigo,
                p.pro_descripcion AS descripcion, 
                IFNULL(IF(a.seg_insertar = 'SI', 1, 0), 0) AS seg_insertar, 
                IFNULL(IF(a.seg_editar = 'SI', 1, 0), 0) AS seg_editar, 
                IFNULL(IF(a.seg_borrar = 'SI', 1, 0), 0) AS seg_borrar, 
                IFNULL(IF(a.seg_buscar = 'SI', 1, 0), 0) AS seg_buscar 
            FROM 
                Programas p 
            LEFT JOIN 
                Accesos a ON a.seg_programa = p.pro_codigo AND a.seg_usuario = @usuario
            "

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@usuario", _usuario) ' Asigna el usuario actual
                    connection.Open()

                    ' Usar MySqlDataAdapter para llenar el DataTable
                    Dim adapter As New MySqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    ' Limpiar el DataGridView antes de llenarlo
                    DataGridView1.Rows.Clear()

                    ' Llenar el DataGridView con los datos del DataTable
                    For Each row As DataRow In dataTable.Rows
                        ' Asumir que las columnas ya están creadas en DataGridView
                        Dim index As Integer = DataGridView1.Rows.Add()
                        DataGridView1.Rows(index).Cells("codigo").Value = row("codigo")
                        DataGridView1.Rows(index).Cells("descripcion").Value = row("descripcion")
                        DataGridView1.Rows(index).Cells("seg_insertar").Value = Convert.ToBoolean(row("seg_insertar"))
                        DataGridView1.Rows(index).Cells("seg_editar").Value = Convert.ToBoolean(row("seg_editar"))
                        DataGridView1.Rows(index).Cells("seg_borrar").Value = Convert.ToBoolean(row("seg_borrar"))
                        DataGridView1.Rows(index).Cells("seg_buscar").Value = Convert.ToBoolean(row("seg_buscar"))

                    Next
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los accesos: " & ex.Message)
        End Try
    End Sub





    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            ' Mostrar mensaje de confirmación
            Dim resultado As DialogResult = MessageBox.Show("¿Está seguro de que desea guardar nueva configuracion?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            ' Si el usuario confirma la eliminación
            If resultado = DialogResult.Yes Then
                Using connection As MySqlConnection = GetConnection()
                    connection.Open()

                    ' Recorre cada fila del DataGridView
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        Dim codigo As Integer = Convert.ToInt32(row.Cells("codigo").Value)
                        ' Comprobar si el valor es DBNull antes de la conversión
                        Dim insertar As Boolean = If(IsDBNull(row.Cells("seg_insertar").Value), False, Convert.ToBoolean(row.Cells("seg_insertar").Value))
                        Dim editar As Boolean = If(IsDBNull(row.Cells("seg_editar").Value), False, Convert.ToBoolean(row.Cells("seg_editar").Value))
                        Dim borrar As Boolean = If(IsDBNull(row.Cells("seg_borrar").Value), False, Convert.ToBoolean(row.Cells("seg_borrar").Value))
                        Dim buscar As Boolean = If(IsDBNull(row.Cells("seg_buscar").Value), False, Convert.ToBoolean(row.Cells("seg_buscar").Value))

                        ' Query para actualizar el estado en la base de datos
                        ' Query para insertar o actualizar según corresponda
                        Dim query As String = "
                        INSERT INTO Accesos (seg_programa, seg_usuario, seg_insertar, seg_editar, seg_borrar, seg_buscar) 
                        VALUES (@codigo, @usuario, @insertar, @editar, @borrar, @buscar)
                        ON DUPLICATE KEY UPDATE 
                        seg_insertar = VALUES(seg_insertar), 
                        seg_editar = VALUES(seg_editar), 
                        seg_borrar = VALUES(seg_borrar), 
                        seg_buscar = VALUES(seg_buscar)"

                        Using command As New MySqlCommand(query, connection)
                            command.Parameters.AddWithValue("@codigo", codigo)
                            command.Parameters.AddWithValue("@usuario", _usuario) ' Variable usuario de la clase
                            command.Parameters.AddWithValue("@insertar", If(insertar, "SI", "NO"))
                            command.Parameters.AddWithValue("@editar", If(editar, "SI", "NO"))
                            command.Parameters.AddWithValue("@borrar", If(borrar, "SI", "NO"))
                            command.Parameters.AddWithValue("@buscar", If(buscar, "SI", "NO"))

                            ' Ejecuta el comando
                            command.ExecuteNonQuery()
                        End Using

                    Next

                    MessageBox.Show("Los cambios se guardaron correctamente.")
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show("Error al guardar los cambios: " & ex.Message)
        End Try
    End Sub

End Class
