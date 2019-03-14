Imports PetShop.DAL
Imports PetShop.Entities

Public Class PacoteBL

    Public Function obterTodosPacotes() As List(Of Pacote)

        Dim c As New PacoteDAO
        Return c.RetornaTodos()

    End Function

    Public Function obterPacotePorCodigo(ByVal Codigo As Integer) As List(Of Pacote)

        Dim c As New PacoteDAO
        Return c.pacoteporCodigo(Codigo)

    End Function

    Public Sub updatePacote(ByVal listaPacote As List(Of Pacote))

        Dim c As New PacoteDAO
        c.updatePacote(listaPacote)

    End Sub

    Public Sub excluiPacote(ByVal listaPacote As List(Of Pacote))

        Dim c As New PacoteDAO
        c.excluiPacote(listaPacote)

    End Sub

    Public Sub excluiPacote(ByVal Codigo As Integer)

        Dim c As New PacoteDAO
        c.excluiPacote(Codigo)

    End Sub

    Public Sub inserePacote(ByVal listaPacote As List(Of Pacote))

        Dim c As New PacoteDAO
        c.inserePacote(listaPacote)

    End Sub

    Public Sub inserePacote(ByVal oPacote As Pacote)

        Dim c As New PacoteDAO
        c.inserePacote(oPacote)

    End Sub

End Class
