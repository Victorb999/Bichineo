Imports System.Data.SqlClient
Imports PetShop.Entities

Public Class ServicoDAO
    Inherits ConexaoDAO

    Public Function InsereServico(ByVal Servico As Servico) As Integer
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO Servico (Descricao, Preco, Obs) OUTPUT INSERTED.Codigo VALUES (@Descricao, @Preco, @Obs)"

            oComm.Parameters.Add("@Descricao", SqlDbType.NChar).Value = Servico.Descricao
            oComm.Parameters.Add("@Preco", SqlDbType.Decimal).Value = Servico.Preco
            oComm.Parameters.Add("@Obs", SqlDbType.NText).Value = Servico.Obs

            oComm.Connection.Open()
            InsereServico = oComm.ExecuteScalar()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir o Serviço.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try

    End Function

    Public Function AlteraServico(ByVal Servico As Servico) As Integer
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao
            oComm.CommandText = "UPDATE Servico SET Descricao = @Descricao, Preco = @Preco, Obs = @Obs OUTPUT INSERTED.Codigo WHERE Codigo = @Codigo"

            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Servico.Codigo
            oComm.Parameters.Add("@Descricao", SqlDbType.NChar).Value = Servico.Descricao
            oComm.Parameters.Add("@Preco", SqlDbType.Decimal).Value = Servico.Preco
            oComm.Parameters.Add("@Obs", SqlDbType.NText).Value = Servico.Obs

            oComm.Connection.Open()
            AlteraServico = oComm.ExecuteScalar()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível atualizar o Serviço.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function ExcluiServico(ByVal Codigo As Integer) As Integer
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM Servico OUTPUT DELETED.Codigo WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo

            oComm.Connection.Open()
            ExcluiServico = oComm.ExecuteScalar()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar o serviço.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function RetornaTodos() As List(Of Servico)
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Descricao, Preco, Obs FROM Servico"
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            RetornaTodos = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter serviços.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try

    End Function

    Private Function PreencherLista(ByVal reader As SqlDataReader) As List(Of Servico)
        Try

            Dim ListaServico As New List(Of Servico)

            While (reader.Read)

                Dim c As New Servico
                c.Codigo = reader.Item("Codigo")
                c.Descricao = reader.Item("Descricao")
                c.Preco = reader.Item("Preco")
                c.Obs = reader.Item("Obs")

                ListaServico.Add(c)

            End While

            PreencherLista = ListaServico

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter serviços.", ex)
        End Try

    End Function

    Public Function ServicoPorCodigo(ByVal Codigo As Integer) As Servico
        Dim oComm As New SqlCommand

        Try
            Dim ListaServico As List(Of Servico)
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Descricao, Preco, Obs FROM Servico WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            ListaServico = PreencherLista(oDR)

            If ListaServico.Count = 0 Then
                ServicoPorCodigo = New Servico
            Else
                ServicoPorCodigo = ListaServico.Item(0)
            End If

            oDR.Close()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter serviço.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function ServicoPorDescricao(ByVal descricao As String) As List(Of Servico)
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Descricao, Preco, Obs FROM Servico WHERE Descricao LIKE +@Descricao +'%' "
            oComm.Parameters.Add("@Descricao", SqlDbType.NVarChar).Value = descricao
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            ServicoPorDescricao = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter serviço.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try

    End Function

End Class
