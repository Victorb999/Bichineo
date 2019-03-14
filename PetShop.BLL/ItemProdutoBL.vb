Imports PetShop.DAL
Imports PetShop.Entities

Public Class ItemProdutoBL

    Public Function obterTodosItemProdutos() As List(Of ItemProduto)

        Dim c As New ItemProdutoDAO
        Return c.RetornaTodos()

    End Function

    Public Function obterItemProdutoPorCodigo(ByVal Codigo As Integer) As List(Of ItemProduto)

        Dim c As New ItemProdutoDAO
        Return c.itemProdutoporCodigo(Codigo)

    End Function

    Public Sub updateItemProduto(ByVal listaItemProduto As List(Of ItemProduto))

        Dim c As New ItemProdutoDAO
        c.updateItemProduto(listaItemProduto)

    End Sub

    Public Sub excluiItemProduto(ByVal listaItemProduto As List(Of ItemProduto))

        Dim c As New ItemProdutoDAO
        c.excluiItemProduto(listaItemProduto)

    End Sub

    Public Sub excluiItemProduto(ByVal Codigo As Integer)

        Dim c As New ItemProdutoDAO
        c.excluiItemProduto(Codigo)

    End Sub

    Public Sub insereItemProduto(ByVal listaItemProduto As List(Of ItemProduto))

        Dim c As New ItemProdutoDAO
        c.insereItemProduto(listaItemProduto)

    End Sub

    Public Sub insereItemProduto(ByVal oItemProduto As ItemProduto)

        Dim c As New ItemProdutoDAO
        c.insereItemProduto(oItemProduto)

    End Sub

End Class
