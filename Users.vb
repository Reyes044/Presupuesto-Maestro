Public Class Users
    Private usuario As String
    Private password As String

    Public Sub New(usuario As String, password As String)
        Me.usuario = usuario
        Me.password = password
    End Sub

    Public Property UsuarioP As String
        Get
            Return usuario
        End Get
        Set(value As String)
            usuario = value
        End Set
    End Property

    Public Property PasswordP As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property
End Class
