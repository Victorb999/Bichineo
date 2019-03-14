Public Class Pacote

    Private pacoteCodigo As Integer
    Public Property Codigo() As Integer
        Get
            Return pacoteCodigo
        End Get
        Set(ByVal value As Integer)
            pacoteCodigo = value
        End Set
    End Property

	Private pacoteDescricao As String
    Public Property Descricao() As String
        Get
            Return pacoteDescricao
        End Get
        Set(ByVal value As String)
            pacoteDescricao = value
        End Set
    End Property
	
    Private pacotePreco As Decimal
    Public Property Preco() As Decimal
        Get
            Return pacotePreco
        End Get
        Set(ByVal value As Decimal)
            pacotePreco = value
        End Set
    End Property

    Private listaItemPacote As List(Of ItemPacote)
    Public Property ItemPacote() As List(Of ItemPacote)
        Get
            Return listaItemPacote
        End Get
        Set(ByVal value As List(Of ItemPacote))
            listaItemPacote = value
        End Set
    End Property

End Class