Public Class ItemProduto

    Private itemprodutoCodigo As Integer
    Public Property Codigo() As Integer
        Get
            Return itemprodutoCodigo
        End Get
        Set(ByVal value As Integer)
            itemprodutoCodigo = value
        End Set
    End Property

    Private itemprodutoVenda As Integer
    Public Property Venda() As Integer
        Get
            Return itemprodutoVenda
        End Get
        Set(ByVal value As Integer)
            itemprodutoVenda = value
        End Set
    End Property

    Private itemprodutoProduto As Integer
    Public Property Produto() As Integer
        Get
            Return itemprodutoproduto
        End Get
        Set(ByVal value As Integer)
            itemprodutoproduto = value
        End Set
    End Property

    Private itemprodutoPrecoCusto As Decimal
    Public Property PrecoCusto() As Decimal
        Get
            Return itemprodutoPrecoCusto
        End Get
        Set(ByVal value As Decimal)
            itemprodutoPrecoCusto = value
        End Set
    End Property

    Private itemprodutoPrecoVenda As Decimal
    Public Property PrecoVenda() As Decimal
        Get
            Return itemprodutoPrecoVenda
        End Get
        Set(ByVal value As Decimal)
            itemprodutoPrecoVenda = value
        End Set
    End Property

    Private itemprodutoDesconto As Decimal
    Public Property Desconto() As Decimal
        Get
            Return itemprodutoDesconto
        End Get
        Set(ByVal value As Decimal)
            itemprodutoDesconto = value
        End Set
    End Property

    Private itemprodutoQuantidade As Decimal
    Public Property Quantidade() As Decimal
        Get
            Return itemprodutoQuantidade
        End Get
        Set(ByVal value As Decimal)
            itemprodutoQuantidade = value
        End Set
    End Property

End Class