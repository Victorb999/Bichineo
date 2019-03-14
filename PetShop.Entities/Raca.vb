Public Class Raca

    Private racaCodigo As Integer
    Public Property Codigo() As Integer
        Get
            Return racaCodigo
        End Get
        Set(ByVal value As Integer)
            racaCodigo = value
        End Set
    End Property

    Private racaNome As String
    Public Property Nome() As String
        Get
            Return racaNome
        End Get
        Set(ByVal value As String)
            racaNome = value
        End Set
    End Property

    Private racaObs As String
    Public Property Obs() As String
        Get
            Return racaObs
        End Get
        Set(ByVal value As String)
            racaObs = value
        End Set
    End Property

    Private racaEspecie As Integer
    Public Property Especie() As Integer
        Get
            Return racaEspecie
        End Get
        Set(ByVal value As Integer)
            racaEspecie = value
        End Set
    End Property

End Class
