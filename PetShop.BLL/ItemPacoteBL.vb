Imports PetShop.DAL
Imports PetShop.Entities

Public Class ItemPacoteBL

    Public Function obterTodosItemPacotes() As List(Of ItemPacote)

        Dim c As New ItemPacoteDAO
        Return c.RetornaTodos()

    End Function

    Public Function obterItemPacotePorCodigo(ByVal Codigo As Integer) As List(Of ItemPacote)

        Dim c As New ItemPacoteDAO
        Return c.itemPacoteporCodigo(Codigo)

    End Function

    Public Sub updateItemPacote(ByVal listaItemPacote As List(Of ItemPacote))

        Dim c As New ItemPacoteDAO
        c.updateItemPacote(listaItemPacote)

    End Sub

    Public Sub excluiItemPacote(ByVal listaItemPacote As List(Of ItemPacote))

        Dim c As New ItemPacoteDAO
        c.excluiItemPacote(listaItemPacote)

    End Sub

    Public Sub excluiItemPacote(ByVal Codigo As Integer)

        Dim c As New ItemPacoteDAO
        c.excluiItemPacote(Codigo)

    End Sub

    Public Sub insereItemPacote(ByVal listaItemPacote As List(Of ItemPacote))

        Dim c As New ItemPacoteDAO
        c.insereItemPacote(listaItemPacote)

    End Sub

    Public Sub insereItemPacote(ByVal oItemPacote As ItemPacote)

        Dim c As New ItemPacoteDAO
        c.insereItemPacote(oItemPacote)

    End Sub

End Class
