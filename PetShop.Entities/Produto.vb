Public Class Produto

    Private produtoCodigo As Integer
    Public Property Codigo() As Integer
        Get
            Return produtoCodigo
        End Get
        Set(ByVal value As Integer)
            produtoCodigo = value
        End Set
    End Property

	Private produtoDescricao As String
    Public Property Descricao() As String
        Get
            Return produtoDescricao
        End Get
        Set(ByVal value As String)
            produtoDescricao = value
        End Set
    End Property
	
	Private produtoPrecoCusto As Decimal
    Public Property PrecoCusto() As Decimal
        Get
            Return produtoPrecoCusto
        End Get
        Set(ByVal value As Decimal)
            produtoPrecoCusto = value
        End Set
    End Property
	
	Private produtoPrecoVenda As Decimal
    Public Property PrecoVenda() As Decimal
        Get
            Return produtoPrecoVenda
        End Get
        Set(ByVal value As Decimal)
            produtoPrecoVenda = value
        End Set
    End Property
	
	Private produtoCodigoBarras As String
    Public Property CodigoBarras() As String
        Get
            Return produtoCodigoBarras
        End Get
        Set(ByVal value As String)
            produtoCodigoBarras = value
        End Set
    End Property

	Private produtoEstoque As Integer
    Public Property Estoque() As Integer
        Get
            Return produtoEstoque
        End Get
        Set(ByVal value As Integer)
            produtoEstoque = value
        End Set
    End Property
	
	Private produtoTipo As Byte
    Public Property Tipo() As Byte
        Get
            Return produtoTipo
        End Get
        Set(ByVal value As Byte)
            produtoTipo = value
        End Set
    End Property
	
End Class