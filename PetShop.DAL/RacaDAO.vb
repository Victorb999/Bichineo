Imports System.Data.SqlClient
Imports PetShop.Entities

Public Class RacaDAO
    Inherits ConexaoDAO

    Public Function InsereRaca(ByVal Raca As Raca) As Integer
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO Raca (Nome, Obs, Especie) OUTPUT INSERTED.Codigo VALUES(@Nome, @Obs, @Especie)"

            oComm.Parameters.Add("@Nome", SqlDbType.NChar).Value = Raca.Nome
            oComm.Parameters.Add("@Obs", SqlDbType.NText).Value = Raca.Obs
            oComm.Parameters.Add("@Especie", SqlDbType.Int).Value = Raca.Especie

            oComm.Connection.Open()
            InsereRaca = oComm.ExecuteScalar()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir a raça.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try

    End Function

    Public Function AlteraRaca(ByVal Raca As Raca) As Integer
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao
            oComm.CommandText = "UPDATE Raca SET Nome = @Nome, Obs = @Obs, Especie = @Especie OUTPUT INSERTED.Codigo WHERE Codigo = @Codigo"

            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Raca.Codigo
            oComm.Parameters.Add("@Nome", SqlDbType.NChar).Value = Raca.Nome
            oComm.Parameters.Add("@Obs", SqlDbType.NText).Value = Raca.Obs
            oComm.Parameters.Add("@Especie", SqlDbType.Int).Value = Raca.Especie

            oComm.Connection.Open()
            AlteraRaca = oComm.ExecuteScalar()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível atualizar a raça especificada.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try

    End Function

    Public Function ExcluiRaca(ByVal Codigo As Integer) As Integer
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM Raca OUTPUT DELETED.Codigo WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo

            oComm.Connection.Open()
            ExcluiRaca = oComm.ExecuteScalar()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível excluir a raça.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function RetornaTodos() As List(Of Raca)
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Nome, Obs, Especie FROM Raca order by nome"
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            RetornaTodos = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter raças.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function RacaPorCodigo(ByVal Codigo As Integer) As Raca
        Dim oComm As New SqlCommand

        Try
            Dim ListaRaca As List(Of Raca)
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Nome, Obs, Especie FROM Raca WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            ListaRaca = PreencherLista(oDR)

            If ListaRaca.Count = 0 Then
                RacaPorCodigo = New Raca
            Else
                RacaPorCodigo = ListaRaca.Item(0)
            End If

            oDR.Close()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter raca.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try

    End Function

    Public Function RacaPorNome(ByVal Nome As String) As List(Of Raca)
        Dim oComm As New SqlCommand

        Try

            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Nome, Obs, Especie FROM Raca WHERE Nome LIKE +@Nome +'%' "
            oComm.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = Nome
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            RacaPorNome = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter raça.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function RacaPorEspecie(ByVal Especie As Integer) As List(Of Raca)
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Nome, Obs, Especie FROM Raca WHERE Especie = @Especie order by nome"
            oComm.Parameters.Add("@Especie", SqlDbType.Int).Value = Especie
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            RacaPorEspecie = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter raças.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Private Function PreencherLista(ByVal reader As SqlDataReader) As List(Of Raca)
        Try

            Dim ListaRaca As New List(Of Raca)

            While (reader.Read)

                Dim c As New Raca
                c.Codigo = reader.Item("Codigo")
                c.Nome = reader.Item("Nome")
                c.Obs = reader.Item("Obs")
                c.Especie = reader.Item("Especie")

                ListaRaca.Add(c)

            End While

            PreencherLista = ListaRaca

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter raça.", ex)
        End Try
    End Function

End Class
