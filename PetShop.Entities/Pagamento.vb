Public Class Pagamento

	Private pagamentoCodigo As Integer
    Public Property Codigo() As Integer
        Get
            Return pagamentoCodigo
        End Get
        Set(ByVal value As Integer)
            pagamentoCodigo = value
        End Set
    End Property
	
    Private pagamentoDescricao As String
    Public Property Descricao() As String
        Get
            Return pagamentoDescricao
        End Get
        Set(ByVal value As String)
            pagamentoDescricao = value
        End Set
    End Property

    Private pagamentoMaxParcela As Byte
    Public Property MaxParcela() As Byte
        Get
            Return pagamentoMaxParcela
        End Get
        Set(ByVal value As Byte)
            pagamentoMaxParcela = value
        End Set
    End Property

End Class
