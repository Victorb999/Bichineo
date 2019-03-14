Imports PetShop.DAL
Imports PetShop.Entities

Public Class ClienteBL

    Public Function InsereCliente(ByVal Cliente As Cliente) As Integer

        Dim c As New ClienteDAO
        InsereCliente = c.InsereCliente(Cliente)

    End Function

    Public Function AlteraCliente(ByVal Cliente As Cliente) As Integer

        Dim c As New ClienteDAO
        AlteraCliente = c.AlteraCliente(Cliente)

    End Function

    Public Function ExcluiCliente(ByVal Codigo As Integer) As Integer

        Dim c As New ClienteDAO
        ExcluiCliente = c.ExcluiCliente(Codigo)

    End Function

    Public Function RetornaTodos() As List(Of Cliente)

        Dim c As New ClienteDAO
        RetornaTodos = c.RetornaTodos()

    End Function

    Public Function ClientePorCodigo(ByVal Codigo As Integer) As Cliente

        Dim c As New ClienteDAO
        ClientePorCodigo = c.ClientePorCodigo(Codigo)

    End Function

    Public Function ClientePorNome(ByVal Nome As String) As List(Of Cliente)

        Dim c As New ClienteDAO
        ClientePorNome = c.ClientePorNome(Nome)

    End Function

End Class
