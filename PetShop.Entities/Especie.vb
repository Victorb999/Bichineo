Public Class Especie

    Private especieCodigo As Integer
    Public Property Codigo() As Integer
        Get
            Return especieCodigo
        End Get
        Set(ByVal value As Integer)
            especieCodigo = value
        End Set
    End Property

    Private especieNome As String
    Public Property Nome() As String
        Get
            Return especieNome
        End Get
        Set(ByVal value As String)
            especieNome = value
        End Set
    End Property

    Private especieObs As String
    Public Property Obs() As String
        Get
            Return especieObs
        End Get
        Set(ByVal value As String)
            especieObs = value
        End Set
    End Property

    Private listaRaca As List(Of Raca)
    Public Property Raca() As List(Of Raca)
        Get
            Return listaRaca
        End Get
        Set(ByVal value As List(Of Raca))
            listaRaca = value
        End Set
    End Property

End Class
