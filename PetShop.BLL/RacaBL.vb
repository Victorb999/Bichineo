Imports PetShop.DAL
Imports PetShop.Entities

Public Class RacaBL

    Public Function InsereRaca(ByVal Raca As Raca) As Integer

        Dim c As New RacaDAO
        InsereRaca = c.InsereRaca(Raca)

    End Function

    Public Function AlteraRaca(ByVal Raca As Raca) As Integer

        Dim c As New RacaDAO
        AlteraRaca = c.AlteraRaca(Raca)

    End Function

    Public Function ExcluiRaca(ByVal Codigo As Integer) As Integer

        Dim c As New RacaDAO
        ExcluiRaca = c.ExcluiRaca(Codigo)

    End Function

    Public Function RetornaTodos() As List(Of Raca)

        Dim c As New RacaDAO
        RetornaTodos = c.RetornaTodos()

    End Function

    Public Function RacaPorCodigo(ByVal Codigo As Integer) As Raca

        Dim c As New RacaDAO
        RacaPorCodigo = c.RacaPorCodigo(Codigo)

    End Function

    Public Function RacaPorNome(ByVal Nome As String) As List(Of Raca)

        Dim c As New RacaDAO
        RacaPorNome = c.RacaPorNome(Nome)

    End Function

    Public Function RacaPorEspecie(ByVal Especie As Integer) As List(Of Raca)

        Dim c As New RacaDAO
        RacaPorEspecie = c.RacaPorEspecie(Especie)

    End Function

End Class
