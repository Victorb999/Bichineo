Imports PetShop.DAL
Imports PetShop.Entities

Public Class EspecieBL

    Public Function InsereEspecie(ByVal oEspecie As Especie) As Integer

        Dim c As New EspecieDAO
        InsereEspecie = c.InsereEspecie(oEspecie)

    End Function

    Public Function AlteraEspecie(ByVal Especie As Especie) As Integer

        Dim c As New EspecieDAO
        AlteraEspecie = c.AlteraEspecie(Especie)

    End Function

    Public Function ExcluiEspecie(ByVal Codigo As Integer) As Integer

        Dim c As New EspecieDAO
        ExcluiEspecie = c.ExcluiEspecie(Codigo)

    End Function

    Public Function RetornaTodos() As List(Of Especie)

        Dim c As New EspecieDAO
        RetornaTodos = c.RetornaTodos()

    End Function

    Public Function EspeciePorCodigo(ByVal Codigo As Integer) As Especie

        Dim c As New EspecieDAO
        EspeciePorCodigo = c.EspecieporCodigo(Codigo)

    End Function

    Public Function EspeciePorNome(ByVal Nome As String) As List(Of Especie)

        Dim c As New EspecieDAO
        EspeciePorNome = c.EspeciePorNome(Nome)

    End Function

End Class