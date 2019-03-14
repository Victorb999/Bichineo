Public Class ItemPacote

    Private itempacoteCodigo As Integer
    Public Property Codigo() As Integer
        Get
            Return itempacoteCodigo
        End Get
        Set(ByVal value As Integer)
            itempacoteCodigo = value
        End Set
    End Property

	Private itempacotePacote As Integer
    Public Property Pacote() As Integer
        Get
            Return itempacotePacote
        End Get
        Set(ByVal value As Integer)
            itempacotePacote = value
        End Set
    End Property
	
    Private itempacoteServico As Integer
    Public Property Servico() As Integer
        Get
            Return itempacoteServico
        End Get
        Set(ByVal value As Integer)
            itempacoteServico = value
        End Set
    End Property
	
	Private itempacoteQuantidade As Integer
    Public Property Quantidade() As Integer
        Get
            Return itempacoteQuantidade
        End Get
        Set(ByVal value As Integer)
            itempacoteQuantidade = value
        End Set
    End Property
	
    Private itempacotePreco As Decimal
    Public Property Preco() As Decimal
        Get
            Return itempacotePreco
        End Get
        Set(ByVal value As Decimal)
            itempacotePreco = value
        End Set
    End Property

End Class