Imports PetShop.DAL
Imports PetShop.Entities

Public Class AgendaBL

    Public Function obterTodosAgendas() As List(Of Agenda)

        Dim c As New AgendaDAO
        Return c.RetornaTodos()

    End Function

    Public Function obterAgendaPorCodigo(ByVal Codigo As Integer) As List(Of Agenda)

        Dim c As New AgendaDAO
        Return c.agendaporCodigo(Codigo)

    End Function

    Public Function obterAgendaPorData(ByVal Data As Date) As List(Of Agenda)

        Dim c As New AgendaDAO
        Return c.agendapordata(Data)

    End Function

    Public Function obterAgendaPorAnimal(ByVal animal As Integer) As List(Of Agenda)

        Dim c As New AgendaDAO
        Return c.agendaporAnimal(animal)

    End Function

    Public Function obterAgendaPorServico(ByVal servico As Integer) As List(Of Agenda)

        Dim c As New AgendaDAO
        Return c.agendaporServico(servico)

    End Function

    Public Sub updateAgenda(ByVal listaAgenda As List(Of Agenda))

        Dim c As New AgendaDAO
        c.updateAgenda(listaAgenda)

    End Sub

    Public Sub updateAgendaStatus(ByVal listaAgenda As List(Of Agenda))

        Dim c As New AgendaDAO
        c.updateAgendaStatus(listaAgenda)

    End Sub

    Public Sub excluiAgenda(ByVal listaAgenda As List(Of Agenda))

        Dim c As New AgendaDAO
        c.excluiAgenda(listaAgenda)

    End Sub

    Public Sub excluiAgenda(ByVal Codigo As Integer)

        Dim c As New AgendaDAO
        c.excluiAgenda(Codigo)

    End Sub

    Public Sub insereAgenda(ByVal listaAgenda As List(Of Agenda))

        Dim c As New AgendaDAO
        c.insereAgenda(listaAgenda)

    End Sub

    Public Function insereAgenda(ByVal oAgenda As Agenda) As Integer

        Dim c As New AgendaDAO
        insereAgenda = c.insereAgenda(oAgenda)

    End Function

End Class
