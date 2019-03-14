Public Class Animal

    Private animalCodigo As Integer
    Public Property Codigo() As Integer
        Get
            Return animalCodigo
        End Get
        Set(ByVal value As Integer)
            animalCodigo = value
        End Set
    End Property

    Private animalNome As String
    Public Property Nome() As String
        Get
            Return animalNome
        End Get
        Set(ByVal value As String)
            animalNome = value
        End Set
    End Property

    Private animalDtNascimento As DateTime
    Public Property DtNascimento() As DateTime
        Get
            Return animalDtNascimento
        End Get
        Set(ByVal value As DateTime)
            animalDtNascimento = value
        End Set
    End Property

    Private animalSexo As String
    Public Property Sexo() As String
        Get
            Return animalSexo
        End Get
        Set(ByVal value As String)
            animalSexo = value
        End Set
    End Property

    Private animalObs As String
    Public Property Obs() As String
        Get
            Return animalObs
        End Get
        Set(ByVal value As String)
            animalObs = value
        End Set
    End Property

    Private animalRaca As Integer
    Public Property Raca() As Integer
        Get
            Return animalRaca
        End Get
        Set(ByVal value As Integer)
            animalRaca = value
        End Set
    End Property

    Private animalCliente As Integer
    Public Property Cliente() As Integer
        Get
            Return animalCliente
        End Get
        Set(ByVal value As Integer)
            animalCliente = value
        End Set
    End Property

    Private animalRacao As String
    Public Property Racao() As String
        Get
            Return animalRacao
        End Get
        Set(ByVal value As String)
            animalRacao = value
        End Set
    End Property

End Class
