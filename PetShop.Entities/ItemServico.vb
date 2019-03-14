Public Class ItemServico

    Private ItemServicoCodigo As Integer
    Public Property Codigo() As Integer
        Get
            Return ItemServicoCodigo
        End Get
        Set(ByVal value As Integer)
            ItemServicoCodigo = value
        End Set
    End Property

	Private ItemServicoVenda As Integer
    Public Property Venda() As Integer
        Get
            Return ItemServicoVenda
        End Get
        Set(ByVal value As Integer)
            ItemServicoVenda = value
        End Set
    End Property
	
	Private ItemServicoProfissional As Integer
    Public Property Profissional() As Integer
        Get
            Return ItemServicoProfissional
        End Get
        Set(ByVal value As Integer)
            ItemServicoProfissional = value
        End Set
    End Property
	
    Private ItemServicoPreco As Decimal
    Public Property Preco() As Decimal
        Get
            Return ItemServicoPreco
        End Get
        Set(ByVal value As Decimal)
            ItemServicoPreco = value
        End Set
    End Property

	Private ItemServicoDesconto As Decimal
    Public Property Desconto() As Decimal
        Get
            Return ItemServicoDesconto
        End Get
        Set(ByVal value As Decimal)
            ItemServicoDesconto = value
        End Set
    End Property

End Class