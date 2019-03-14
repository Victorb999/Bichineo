Imports System.Data.SqlClient
Imports PetShop.Entities

Public Class EspecieDAO
    Inherits ConexaoDAO

    Public Function InsereEspecie(ByVal Especie As Especie) As Integer

        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO Especie (Nome, Obs) OUTPUT INSERTED.Codigo VALUES(@Nome, @Obs)"

            oComm.Parameters.Add("@Nome", SqlDbType.NChar).Value = Especie.Nome
            oComm.Parameters.Add("@Obs", SqlDbType.NText).Value = Especie.Obs

            oComm.Connection.Open()
            InsereEspecie = oComm.ExecuteScalar()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir a espécie.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function AlteraEspecie(ByVal Especie As Especie) As Integer
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao
            oComm.CommandText = "UPDATE Especie SET Nome = @Nome, Obs = @Obs OUTPUT Inserted.Codigo WHERE Codigo = @Codigo"

            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Especie.Codigo
            oComm.Parameters.Add("@Nome", SqlDbType.NChar).Value = Especie.Nome
            oComm.Parameters.Add("@Obs", SqlDbType.NText).Value = Especie.Obs

            oComm.Connection.Open()
            AlteraEspecie = oComm.ExecuteScalar()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível atualizar a espécie.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function ExcluiEspecie(ByVal Codigo As Integer) As Integer
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM Especie OUTPUT Deleted.Codigo WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo

            oComm.Connection.Open()
            ExcluiEspecie = oComm.ExecuteScalar()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível excluir a espécie.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function RetornaTodos() As List(Of Especie)
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Nome, Obs FROM Especie"
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            RetornaTodos = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter espécies.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function EspecieporCodigo(ByVal Codigo As Integer) As Especie
        Dim oComm As New SqlCommand

        Try
            Dim ListaEspecie As List(Of Especie)
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Nome, Obs FROM Especie WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            ListaEspecie = PreencherLista(oDR)

            If ListaEspecie.Count = 0 Then
                EspecieporCodigo = New Especie
            Else
                EspecieporCodigo = ListaEspecie.Item(0)
            End If

            oDR.Close()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter espécie.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function EspeciePorNome(ByVal Nome As String) As List(Of Especie)
        Dim oComm As New SqlCommand

        Try

            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Nome, Obs FROM Especie WHERE Nome LIKE +@Nome +'%' "
            oComm.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = Nome
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            EspeciePorNome = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

        Catch ex As Exception
            MsgBox("Não foi possível obter Espécies.")
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Private Function PreencherLista(ByVal reader As SqlDataReader) As List(Of Especie)
        Try

            Dim listaEspecie As New List(Of Especie)

            While (reader.Read)

                Dim c As New Especie
                c.Codigo = reader.Item("Codigo")
                c.Nome = reader.Item("Nome")
                c.Obs = reader.Item("Obs")

                listaEspecie.Add(c)

            End While

            PreencherLista = listaEspecie

        Catch ex As Exception

        End Try
    End Function

End Class
