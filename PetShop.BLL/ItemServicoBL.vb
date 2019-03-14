Imports PetShop.DAL
Imports PetShop.Entities

Public Class ItemServicoBL

    Public Function obterTodosItemServicos() As List(Of ItemServico)

        Dim c As New ItemServicoDAO
        Return c.RetornaTodos()

    End Function

    Public Function obterItemServicoPorCodigo(ByVal Codigo As Integer) As List(Of ItemServico)

        Dim c As New ItemServicoDAO
        Return c.itemServicoporCodigo(Codigo)

    End Function

    Public Sub updateItemServico(ByVal listaItemServico As List(Of ItemServico))

        Dim c As New ItemServicoDAO
        c.updateItemServico(listaItemServico)

    End Sub

    Public Sub excluiItemServico(ByVal listaItemServico As List(Of ItemServico))

        Dim c As New ItemServicoDAO
        c.excluiItemServico(listaItemServico)

    End Sub

    Public Sub excluiItemServico(ByVal Codigo As Integer)

        Dim c As New ItemServicoDAO
        c.excluiItemServico(Codigo)

    End Sub

    Public Sub insereItemServico(ByVal listaItemServico As List(Of ItemServico))

        Dim c As New ItemServicoDAO
        c.insereItemServico(listaItemServico)

    End Sub

    Public Sub insereItemServico(ByVal oItemServico As ItemServico)

        Dim c As New ItemServicoDAO
        c.insereItemServico(oItemServico)

    End Sub

End Class
