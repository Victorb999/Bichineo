Imports PetShop.DAL
Imports PetShop.Entities

Public Class ProfissionalBL

    Public Function obterTodosProfissionals() As List(Of Profissional)

        Dim c As New ProfissionalDAO
        Return c.RetornaTodos()

    End Function

    Public Function obterProfissionalPorCodigo(ByVal Codigo As Integer) As List(Of Profissional)

        Dim c As New ProfissionalDAO
        Return c.profissionalporCodigo(Codigo)

    End Function

    Public Sub updateProfissional(ByVal listaProfissional As List(Of Profissional))

        Dim c As New ProfissionalDAO
        c.updateProfissional(listaProfissional)

    End Sub

    Public Sub excluiProfissional(ByVal listaProfissional As List(Of Profissional))

        Dim c As New ProfissionalDAO
        c.excluiProfissional(listaProfissional)

    End Sub

    Public Sub excluiProfissional(ByVal Codigo As Integer)

        Dim c As New ProfissionalDAO
        c.excluiProfissional(Codigo)

    End Sub

    Public Sub insereProfissional(ByVal listaProfissional As List(Of Profissional))

        Dim c As New ProfissionalDAO
        c.insereProfissional(listaProfissional)

    End Sub

    Public Sub insereProfissional(ByVal oProfissional As Profissional)

        Dim c As New ProfissionalDAO
        c.insereProfissional(oProfissional)

    End Sub

End Class
