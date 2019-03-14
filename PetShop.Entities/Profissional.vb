Public Class Profissional

    Private profissionalCodigo As Integer
    Public Property Codigo() As Integer
        Get
            Return ProfissionalCodigo
        End Get
        Set(ByVal value As Integer)
            ProfissionalCodigo = value
        End Set
    End Property

    Private profissionalNome As String
    Public Property Nome() As String
        Get
            Return ProfissionalNome
        End Get
        Set(ByVal value As String)
            ProfissionalNome = value
        End Set
    End Property

    Private profissionalComissao As Decimal
    Public Property Comissao() As Decimal
        Get
            Return ProfissionalComissao
        End Get
        Set(ByVal value As Decimal)
            ProfissionalComissao = value
        End Set
    End Property

    Private profissionalFuncao As String
    Public Property Funcao() As String
        Get
            Return profissionalFuncao
        End Get
        Set(ByVal value As String)
            profissionalFuncao = value
        End Set
    End Property

End Class
