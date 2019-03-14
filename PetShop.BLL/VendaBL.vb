Imports PetShop.DAL
Imports PetShop.Entities

Public Class VendaBL

    Public Function obterTodosVendas() As List(Of Venda)

        Dim c As New VendaDAO
        Return c.RetornaTodos()

    End Function

    Public Function obterVendaPorCodigo(ByVal Codigo As Integer) As List(Of Venda)

        Dim c As New VendaDAO
        Return c.vendaporCodigo(Codigo)

    End Function

    Public Sub updateVenda(ByVal listaVenda As List(Of Venda))

        Dim c As New VendaDAO
        c.updateVenda(listaVenda)

    End Sub

    Public Sub excluiVenda(ByVal listaVenda As List(Of Venda))

        Dim c As New VendaDAO
        c.excluiVenda(listaVenda)

    End Sub

    Public Sub excluiVenda(ByVal Codigo As Integer)

        Dim c As New VendaDAO
        c.excluiVenda(Codigo)

    End Sub

    Public Sub insereVenda(ByVal listaVenda As List(Of Venda))

        Dim c As New VendaDAO
        c.insereVenda(listaVenda)

    End Sub

    Public Sub insereVenda(ByVal oVenda As Venda)

        Dim c As New VendaDAO
        c.insereVenda(oVenda)

    End Sub

End Class
