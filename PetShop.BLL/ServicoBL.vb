Imports PetShop.DAL
Imports PetShop.Entities

Public Class ServicoBL

    Public Function InsereServico(ByVal Servico As Servico) As Integer

        Dim c As New ServicoDAO
        InsereServico = c.InsereServico(Servico)

    End Function

    Public Function AlteraServico(ByVal Servico As Servico) As Integer

        Dim c As New ServicoDAO
        AlteraServico = c.AlteraServico(Servico)

    End Function

    Public Function ExcluiServico(ByVal Codigo As Integer) As Integer

        Dim c As New ServicoDAO
        ExcluiServico = c.ExcluiServico(Codigo)

    End Function

    Public Function RetornaTodos() As List(Of Servico)

        Dim c As New ServicoDAO
        RetornaTodos = c.RetornaTodos()

    End Function

    Public Function ServicoPorCodigo(ByVal Codigo As Integer) As Servico

        Dim c As New ServicoDAO
        ServicoPorCodigo = c.ServicoPorCodigo(Codigo)

    End Function

    Public Function ServicoPorDescricao(ByVal Descricao As String) As List(Of Servico)

        Dim c As New ServicoDAO
        ServicoPorDescricao = c.ServicoPorDescricao(Descricao)

    End Function

End Class
