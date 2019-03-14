Imports PetShop.DAL
Imports PetShop.Entities

Public Class PagamentoVendaBL

    Public Function obterTodosPagamentoVendas() As List(Of PagamentoVenda)

        Dim c As New PagamentoVendaDAO
        Return c.RetornaTodos()

    End Function

    Public Function obterPagamentoVendaPorCodigo(ByVal Codigo As Integer) As List(Of PagamentoVenda)

        Dim c As New PagamentoVendaDAO
        Return c.pagamentoVendaporCodigo(Codigo)

    End Function

    Public Sub updatePagamentoVenda(ByVal listaPagamentoVenda As List(Of PagamentoVenda))

        Dim c As New PagamentoVendaDAO
        c.updatePagamentoVenda(listaPagamentoVenda)

    End Sub

    Public Sub excluiPagamentoVenda(ByVal listaPagamentoVenda As List(Of PagamentoVenda))

        Dim c As New PagamentoVendaDAO
        c.excluiPagamentoVenda(listaPagamentoVenda)

    End Sub

    Public Sub excluiPagamentoVenda(ByVal Codigo As Integer)

        Dim c As New PagamentoVendaDAO
        c.excluiPagamentoVenda(Codigo)

    End Sub

    Public Sub inserePagamentoVenda(ByVal listaPagamentoVenda As List(Of PagamentoVenda))

        Dim c As New PagamentoVendaDAO
        c.inserePagamentoVenda(listaPagamentoVenda)

    End Sub

    Public Sub inserePagamentoVenda(ByVal oPagamentoVenda As PagamentoVenda)

        Dim c As New PagamentoVendaDAO
        c.inserePagamentoVenda(oPagamentoVenda)

    End Sub

End Class
