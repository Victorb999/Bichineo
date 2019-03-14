Imports PetShop.DAL
Imports PetShop.Entities

Public Class PagamentoBL

    Public Function obterTodosPagamentos() As List(Of Pagamento)

        Dim c As New PagamentoDAO
        Return c.RetornaTodos()

    End Function

    Public Function obterPagamentoPorCodigo(ByVal Codigo As Integer) As List(Of Pagamento)

        Dim c As New PagamentoDAO
        Return c.pagamentoporCodigo(Codigo)

    End Function

    Public Sub updatePagamento(ByVal listaPagamento As List(Of Pagamento))

        Dim c As New PagamentoDAO
        c.updatePagamento(listaPagamento)

    End Sub

    Public Sub excluiPagamento(ByVal listaPagamento As List(Of Pagamento))

        Dim c As New PagamentoDAO
        c.excluiPagamento(listaPagamento)

    End Sub

    Public Sub excluiPagamento(ByVal Codigo As Integer)

        Dim c As New PagamentoDAO
        c.excluiPagamento(Codigo)

    End Sub

    Public Sub inserePagamento(ByVal listaPagamento As List(Of Pagamento))

        Dim c As New PagamentoDAO
        c.inserePagamento(listaPagamento)

    End Sub

    Public Sub inserePagamento(ByVal oPagamento As Pagamento)

        Dim c As New PagamentoDAO
        c.inserePagamento(oPagamento)

    End Sub

End Class
