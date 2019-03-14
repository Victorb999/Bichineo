Imports PetShop.DAL
Imports PetShop.Entities

Public Class ProdutoBL

    Public Function TodosProdutos() As List(Of Produto)

        Dim c As New ProdutoDAO
        Return c.RetornaTodos()

    End Function

    Public Function ProdutoPorCodigo(ByVal Codigo As Integer) As Produto

        Dim c As New ProdutoDAO
        Return c.ProdutoporCodigo(Codigo)

    End Function

    Public Sub updateProduto(ByVal listaProduto As List(Of Produto))

        Dim c As New ProdutoDAO
        c.updateProduto(listaProduto)

    End Sub

    Public Sub excluiProduto(ByVal listaProduto As List(Of Produto))

        Dim c As New ProdutoDAO
        c.excluiProduto(listaProduto)

    End Sub

    Public Function excluiProduto(ByVal Codigo As Integer) As Integer

        Dim c As New ProdutoDAO
        excluiProduto = c.excluiProduto(Codigo)

    End Function

    Public Sub insereProduto(ByVal listaProduto As List(Of Produto))

        Dim c As New ProdutoDAO
        c.insereProduto(listaProduto)

    End Sub

    Public Function insereProduto(ByVal oProduto As Produto) As Integer

        Dim c As New ProdutoDAO
        insereProduto = c.insereProduto(oProduto)

    End Function

    Public Function AlteraProduto(ByVal oProduto As Produto) As Integer

        Dim c As New ProdutoDAO
        AlteraProduto = c.updateProduto(oProduto)

    End Function

    Public Function ProdutoPorDescricao(ByVal Descricao As String) As List(Of Produto)

        Dim c As New ProdutoDAO
        ProdutoPorDescricao = c.ProdutoPorDescricao(Descricao)

    End Function

End Class
