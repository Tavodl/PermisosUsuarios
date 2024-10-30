Namespace PermisosUsuarios.ClasesComunes
    ' Clase para representar el estado del usuario
    Public Class EstadoEmpleado
        Public Property Texto As String
        Public Property Valor As Integer

        Public Sub New(texto As String, valor As Integer)
            Me.Texto = texto
            Me.Valor = valor
        End Sub

        Public Overrides Function ToString() As String
            Return Texto
        End Function
    End Class
End Namespace
