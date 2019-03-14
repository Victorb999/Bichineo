Public Class Usuario

    Private usuarioCodigo As Integer
    Public Property Codigo() As Integer
        Get
            Return usuarioCodigo
        End Get
        Set(ByVal value As Integer)
            usuarioCodigo = value
        End Set
    End Property

    Private usuarioNome As String
    Public Property Nome() As String
        Get
            Return usuarioNome
        End Get
        Set(ByVal value As String)
            usuarioNome = value
        End Set
    End Property

    Private usuarioSenha As String
    Public Property Senha() As String
        Get
            Return usuarioSenha
        End Get
        Set(ByVal value As String)
            usuarioSenha = value
        End Set
    End Property
	
	Private usuarioNivel As Byte
    Public Property Nivel() As Byte
        Get
            Return usuarioNivel
        End Get
        Set(ByVal value As Byte)
            usuarioNivel = value
        End Set
    End Property

End Class