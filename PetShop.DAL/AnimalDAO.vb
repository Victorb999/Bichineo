Imports System.Data.SqlClient
Imports PetShop.Entities

Public Class AnimalDAO
    Inherits ConexaoDAO

    Public Function InsereAnimal(ByVal Animal As Animal) As Integer

        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO Animal " &
            "(Nome, DtNascimento, Sexo, Obs, Raca, Cliente,Racao) OUTPUT INSERTED.Codigo VALUES " &
            "(@Nome, @DtNascimento, @Sexo, @Obs, @Raca, @Cliente,@Racao)"

            oComm.Parameters.Add("@Nome", SqlDbType.NChar).Value = Animal.Nome
            oComm.Parameters.Add("@DtNascimento", SqlDbType.DateTime).Value = Animal.DtNascimento
            oComm.Parameters.Add("@Sexo", SqlDbType.NChar).Value = Animal.Sexo
            oComm.Parameters.Add("@Obs", SqlDbType.NText).Value = Animal.Obs
            oComm.Parameters.Add("@Raca", SqlDbType.Int).Value = Animal.Raca
            oComm.Parameters.Add("@Cliente", SqlDbType.Int).Value = Animal.Cliente
            oComm.Parameters.Add("@Racao", SqlDbType.NChar).Value = Animal.Racao

            oComm.Connection.Open()
            InsereAnimal = oComm.ExecuteScalar()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir o animal.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function AlteraAnimal(ByVal Animal As Animal) As Integer
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao
            oComm.CommandText = "UPDATE Animal SET Nome = @Nome, DtNascimento = @DtNascimento, Sexo = @Sexo, Obs = @Obs, Raca = @Raca,  Cliente = @Cliente, Racao =@Racao " &
                "OUTPUT INSERTED.Codigo WHERE Codigo = @Codigo"

            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Animal.Codigo
            oComm.Parameters.Add("@Nome", SqlDbType.NChar).Value = Animal.Nome
            oComm.Parameters.Add("@DtNascimento", SqlDbType.Date).Value = Animal.DtNascimento
            oComm.Parameters.Add("@Sexo", SqlDbType.NChar).Value = Animal.Sexo
            oComm.Parameters.Add("@Obs", SqlDbType.NText).Value = Animal.Obs
            oComm.Parameters.Add("@Raca", SqlDbType.Int).Value = Animal.Raca
            oComm.Parameters.Add("@Cliente", SqlDbType.Int).Value = Animal.Cliente
            oComm.Parameters.Add("@Racao", SqlDbType.NChar).Value = Animal.Racao

            oComm.Connection.Open()
            AlteraAnimal = oComm.ExecuteScalar()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível atualizar o animal.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try

    End Function

    Public Function ExcluiAnimal(ByVal Codigo As Integer) As Integer
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM Animal OUTPUT DELETED.Codigo WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo

            oComm.Connection.Open()
            ExcluiAnimal = oComm.ExecuteScalar()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar animal.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function RetornaTodos() As List(Of Animal)
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Nome, DtNascimento, Sexo, Obs, Raca, Cliente,Racao FROM Animal"
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            RetornaTodos = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter animais.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function AnimalPorCodigo(ByVal Codigo As Integer) As Animal
        Dim oComm As New SqlCommand

        Try
            Dim ListaAnimal As List(Of Animal)
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Nome, DtNascimento, Sexo, Obs, Raca, Cliente,Racao FROM Animal WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            ListaAnimal = PreencherLista(oDR)

            If ListaAnimal.Count = 0 Then
                AnimalPorCodigo = New Animal
            Else
                AnimalPorCodigo = ListaAnimal.Item(0)
            End If

            oDR.Close()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter animal.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try

    End Function

    Public Function AnimalPorNome(ByVal Nome As String) As List(Of Animal)
        Dim oComm As New SqlCommand

        Try

            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Nome, DtNascimento, Sexo, Obs, Raca, Cliente,Racao FROM Animal WHERE nome LIKE +@Nome +'%' "
            oComm.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = Nome
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            AnimalPorNome = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter animal.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try

    End Function

    Public Function AnimalPorRaca(ByVal Raca As Integer) As List(Of Animal)
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Nome, DtNascimento, Sexo, Obs, Raca, Cliente,Racao FROM Animal WHERE Raca = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Raca
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()
            AnimalPorRaca = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter animal.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function AnimalPorCliente(ByVal Cliente As Integer) As List(Of Animal)
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Nome, DtNascimento, Sexo, Obs, Raca, Cliente,Racao FROM Animal WHERE Cliente = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Cliente
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()
            AnimalPorCliente = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter animal.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Private Function PreencherLista(ByVal reader As SqlDataReader) As List(Of Animal)
        Try

            Dim ListaAnimal As New List(Of Animal)

            While (reader.Read)

                Dim c As New Animal
                c.Codigo = reader.Item("Codigo")
                c.Nome = reader.Item("Nome")
                c.DtNascimento = reader.Item("DtNascimento")
                c.Sexo = reader.Item("Sexo")
                c.Obs = reader.Item("Obs")
                c.Raca = reader.Item("Raca")
                c.Cliente = reader.Item("Cliente")
                c.Racao = reader.Item("Racao")

                ListaAnimal.Add(c)

            End While

            PreencherLista = ListaAnimal

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter animal.", ex)
        End Try

    End Function

End Class
