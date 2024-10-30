

Imports MySql.Data.MySqlClient

Module ConexionDB
    'String conexion
    Private connectionString As String = "Server=localhost;Database=pruebatecnica;User ID=root;Password=;charset=latin1;"

    ' Función para obtener la conexión a la base de datos
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function


End Module
