Imports PetShop.DAL
Imports PetShop.Entities

Public Class AnimalBL

    Public Function InsereAnimal(ByVal Animal As Animal) As Integer

        Dim c As New AnimalDAO
        InsereAnimal = c.InsereAnimal(Animal)

    End Function

    Public Function AlteraAnimal(ByVal Animal As Animal) As Integer

        Dim c As New AnimalDAO
        AlteraAnimal = c.AlteraAnimal(Animal)

    End Function

    Public Function ExcluiAnimal(ByVal Codigo As Integer) As Integer

        Dim c As New AnimalDAO
        ExcluiAnimal = c.ExcluiAnimal(Codigo)

    End Function

    Public Function RetornaTodos() As List(Of Animal)

        Dim c As New AnimalDAO
        RetornaTodos = c.RetornaTodos()

    End Function

    Public Function AnimalPorCodigo(ByVal Codigo As Integer) As Animal

        Dim c As New AnimalDAO
        AnimalPorCodigo = c.AnimalPorCodigo(Codigo)

    End Function

    Public Function AnimalPorNome(ByVal Nome As String) As List(Of Animal)

        Dim c As New AnimalDAO
        AnimalPorNome = c.AnimalPorNome(Nome)

    End Function

    Public Function AnimalPorRaca(ByVal Raca As Integer) As List(Of Animal)

        Dim c As New AnimalDAO
        AnimalPorRaca = c.AnimalporRaca(Raca)

    End Function

    Public Function AnimalPorCliente(ByVal Cliente As Integer) As List(Of Animal)

        Dim c As New AnimalDAO
        AnimalPorCliente = c.AnimalPorCliente(Cliente)

    End Function

End Class