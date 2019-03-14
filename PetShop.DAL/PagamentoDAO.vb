Imports System.Data.SqlClient
Imports PetShop.Entities

Public Class PagamentoDAO
    Inherits ConexaoDAO

    Public Function RetornaTodos() As List(Of Pagamento)
        Dim oComm As New SqlCommand
		
        Try
            Dim listaPagamento As List(Of Pagamento)

            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Descricao, MaxParcela FROM Pagamento"
            oComm.Connection.Open()
			
            Dim oDR As SqlDataReader = oComm.ExecuteReader()
			
            listaPagamento = PreencherLista(oDR)
			
            oDR.Close()
            oComm.Connection.Close()
			
            Return listaPagamento
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter Pagamento.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function
	
    Private Function PreencherLista(ByVal reader As SqlDataReader) As List(Of Pagamento)
        Try

            Dim listaPagamento As New List(Of Pagamento)

            While (reader.Read)
			
                Dim c As New Pagamento
                c.Codigo = reader.GetInt32(0)
                c.Descricao = reader.GetString(1)
                c.MaxParcela = reader.GetByte(3)

                listaPagamento.Add(c)

            End While

            Return listaPagamento

        Catch ex As Exception
		
        End Try
    End Function
	
    Public Function pagamentoporCodigo(ByVal Codigo As Integer) As List(Of Pagamento)
        Dim oComm As New SqlCommand
		
        Try
            Dim listaPagamento As List(Of Pagamento)
			
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Descricao, MaxParcela FROM Pagamento WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            listaPagamento = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

            Return listaPagamento

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter Pagamento.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function
	
    Public Sub excluiPagamento(ByVal listaPagamento As List(Of Pagamento))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM Pagamento WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Connection.Open()
			
            For Each c As Pagamento In listaPagamento
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.ExecuteNonQuery()
            Next
			
            oComm.Connection.Close()
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar Pagamento.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub excluiPagamento(ByVal Codigo As Integer)
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM Pagamento WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo

            oComm.Connection.Open()
            oComm.ExecuteNonQuery()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar Pagamento.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub
	
    Public Sub inserePagamento(ByVal listaPagamento As List(Of Pagamento))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO Pagamento (Descricao, MaxParcela) VALUES(@Descricao, @MaxParcela)"

            oComm.Parameters.Add("@Descricao", SqlDbType.NChar)
            oComm.Parameters.Add("@MaxParcela", SqlDbType.TinyInt)

            oComm.Connection.Open()

            For Each c As Pagamento In listaPagamento
                oComm.Parameters("@Descricao").Value = c.Descricao
                oComm.Parameters("@MaxParcela").Value = c.MaxParcela

                oComm.ExecuteNonQuery()
            Next

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir pagamentos.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub inserePagamento(ByVal Pagamento As Pagamento) '
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO Pagamento (Descricao, MaxParcela) VALUES(@Descricao, @MaxParcela)"

            oComm.Parameters.Add("@Descricao", SqlDbType.NChar)
            oComm.Parameters.Add("@MaxParcela", SqlDbType.TinyInt)

            oComm.Connection.Open()

            oComm.Parameters("@Descricao").Value = Pagamento.Descricao
            oComm.Parameters("@MaxParcela").Value = Pagamento.MaxParcela

            oComm.ExecuteNonQuery()

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir o Pagamento.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub updatePagamento(ByVal listaPagamento As List(Of Pagamento))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao
            oComm.CommandText = "UPDATE Pagamento SET Descricao = @Descricao, MaxParcela= @MaxParcela WHERE Codigo = @Codigo"

            oComm.Parameters.Add("@Descricao", SqlDbType.NChar)
            oComm.Parameters.Add("@MaxParcela", SqlDbType.TinyInt)

            For Each c As Pagamento In listaPagamento
                oComm.Parameters("@Descricao").Value = c.Descricao
                oComm.Parameters("@MaxParcela").Value = c.MaxParcela

                oComm.ExecuteNonQuery()
            Next

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível atualizar Pagamento.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

End Class
