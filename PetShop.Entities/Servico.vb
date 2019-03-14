Public Class Servico

    Private servicoCodigo As Integer
    Public Property Codigo() As Integer
        Get
            Return servicoCodigo
        End Get
        Set(ByVal value As Integer)
            servicoCodigo = value
        End Set
    End Property

    Private servicoDescricao As String
    Public Property Descricao() As String
        Get
            Return servicoDescricao
        End Get
        Set(ByVal value As String)
            servicoDescricao = value
        End Set
    End Property

    Private servicoPreco As Decimal
    Public Property Preco() As Decimal
        Get
            Return servicoPreco
        End Get
        Set(ByVal value As Decimal)
            servicoPreco = value
        End Set
    End Property

    Private servicoObs As String
    Public Property Obs() As String
        Get
            Return servicoObs
        End Get
        Set(ByVal value As String)
            servicoObs = value
        End Set
    End Property

End Class