Public Class Venda

    Private vendaCodigo As Integer
    Public Property Codigo() As Integer
        Get
            Return vendaCodigo
        End Get
        Set(ByVal value As Integer)
            vendaCodigo = value
        End Set
    End Property

    Private vendaUsuario As Integer
    Public Property Usuario() As Integer
        Get
            Return vendaUsuario
        End Get
        Set(ByVal value As Integer)
            vendaUsuario = value
        End Set
    End Property
	
	Private vendaCliente As Integer
    Public Property Cliente() As Integer
        Get
            Return vendaCliente
        End Get
        Set(ByVal value As Integer)
            vendaCliente = value
        End Set
    End Property

	Private vendaData As DateTime
    Public Property Data() As DateTime
        Get
            Return vendaData
        End Get
        Set(ByVal value As DateTime)
            vendaData = value
        End Set
    End Property

    Private vendaValor As Decimal
    Public Property Valor() As Decimal
        Get
            Return vendaValor
        End Get
        Set(ByVal value As Decimal)
            vendaValor = value
        End Set
    End Property

    Private vendaStatus As Byte
    Public Property Status() As Byte
        Get
            Return vendaStatus
        End Get
        Set(ByVal value As Byte)
            vendaStatus = value
        End Set
    End Property

End Class
