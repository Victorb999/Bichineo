Public Class PagamentoVenda

	Private pagamentovendaCodigo As Integer
    Public Property Codigo() As Integer
        Get
            Return pagamentovendaCodigo
        End Get
        Set(ByVal value As Integer)
            pagamentovendaCodigo = value
        End Set
    End Property
	
    Private pagamentovendaVenda As Integer
    Public Property Venda() As Integer
        Get
            Return pagamentovendaVenda
        End Get
        Set(ByVal value As Integer)
            pagamentovendaVenda = value
        End Set
    End Property

    Private pagamentovendaPagamento As Integer
    Public Property Pagamento() As Integer
        Get
            Return pagamentovendaPagamento
        End Get
        Set(ByVal value As Integer)
            pagamentovendaPagamento = value
        End Set
    End Property

    Private pagamentovendaValor As Decimal
    Public Property Valor() As Decimal
        Get
            Return pagamentovendaValor
        End Get
        Set(ByVal value As Decimal)
            pagamentovendaValor = value
        End Set
    End Property

End Class
