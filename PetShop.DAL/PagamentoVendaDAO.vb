Imports System.Data.SqlClient
Imports PetShop.Entities

Public Class PagamentoVendaDAO
    Inherits ConexaoDAO
	
    Public Function RetornaTodos() As List(Of PagamentoVenda)
        Dim oComm As New SqlCommand
		
        Try
            Dim listaPagamentoVenda As List(Of PagamentoVenda)
			
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Venda, Pagamento, Valor FROM PagamentoVenda"
            oComm.Connection.Open()
			
            Dim oDR As SqlDataReader = oComm.ExecuteReader()
			
            listaPagamentoVenda = PreencherLista(oDR)
			
            oDR.Close()
            oComm.Connection.Close()
			
            Return listaPagamentoVenda
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter PagamentoVenda.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function
	
    Private Function PreencherLista(ByVal reader As SqlDataReader) As List(Of PagamentoVenda)
        Try
			
            Dim listaPagamentoVenda As New List(Of PagamentoVenda)
			
            While (reader.Read)
			
                Dim c As New PagamentoVenda
                c.Codigo = reader.GetInt32(0)
                c.Venda = reader.GetInt32(1)
                c.Pagamento = reader.GetInt32(2)
                c.Valor = reader.GetDecimal(2)

                listaPagamentoVenda.Add(c)
				
            End While
			
            Return listaPagamentoVenda
			
        Catch ex As Exception
		
        End Try
    End Function
	
    Public Function pagamentoVendaporCodigo(ByVal Codigo As Integer) As List(Of PagamentoVenda)
        Dim oComm As New SqlCommand
		
        Try
            Dim listaPagamentoVenda As List(Of PagamentoVenda)
			
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Venda, Pagamento, Valor FROM PagamentoVenda WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            listaPagamentoVenda = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

            Return listaPagamentoVenda

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter PagamentoVenda", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function pagamentoVendaporVenda(ByVal Venda As Integer) As List(Of PagamentoVenda)
        Dim oComm As New SqlCommand

        Try
            Dim listaPagamentoVenda As List(Of PagamentoVenda)

            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Venda, Pagamento, Valor FROM PagamentoVenda WHERE Venda = @Venda"
            oComm.Parameters.Add("@Venda", SqlDbType.Int).Value = Venda
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            listaPagamentoVenda = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

            Return listaPagamentoVenda

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter PagamentoVenda", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Sub excluiPagamentoVenda(ByVal listaPagamentoVenda As List(Of PagamentoVenda))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM PagamentoVenda WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Connection.Open()
			
            For Each c As PagamentoVenda In listaPagamentoVenda
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
	
    Public Sub excluiPagamentoVenda(ByVal Codigo As Integer)
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM PagamentoVenda WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo

            oComm.Connection.Open()
            oComm.ExecuteNonQuery()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar serviço", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub
	
    Public Sub inserePagamentoVenda(ByVal listaPagamentoVenda As List(Of PagamentoVenda))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO PagamentoVenda (Venda, Pagamento, Valor) VALUES (@Venda, @Pagamento, @Valor)"

            oComm.Parameters.Add("@Venda", SqlDbType.Int)
            oComm.Parameters.Add("@Pagamento", SqlDbType.Int)
            oComm.Parameters.Add("@Valor", SqlDbType.Decimal)

            oComm.Connection.Open()

            For Each c As PagamentoVenda In listaPagamentoVenda
                oComm.Parameters("@Venda").Value = c.Venda
                oComm.Parameters("@Pagamento").Value = c.Pagamento
                oComm.Parameters("@valor").Value = c.Valor

                oComm.ExecuteNonQuery()
            Next

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir Pagamentos", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub inserePagamentoVenda(ByVal PagamentoVenda As PagamentoVenda)
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO PagamentoVenda (Nome, Obs) VALUES(@Nome, @Obs)"

            oComm.Parameters.Add("@Venda", SqlDbType.Int)
            oComm.Parameters.Add("@Pagamento", SqlDbType.Int)
            oComm.Parameters.Add("@Valor", SqlDbType.Decimal)

            oComm.Connection.Open()

            oComm.Parameters("@Venda").Value = PagamentoVenda.Venda
            oComm.Parameters("@Pagamento").Value = PagamentoVenda.Pagamento
            oComm.Parameters("@valor").Value = PagamentoVenda.Valor

            oComm.ExecuteNonQuery()

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir o Pagamento", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub updatePagamentoVenda(ByVal listaPagamentoVenda As List(Of PagamentoVenda))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao
            oComm.CommandText = "UPDATE PagamentoVenda SET Venda = @Venda, Pagamento = @Pagamento, Valor = @Valor WHERE Codigo = @Codigo"

            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Parameters.Add("@Venda", SqlDbType.Int)
            oComm.Parameters.Add("@Pagamento", SqlDbType.Int)
            oComm.Parameters.Add("@Valor", SqlDbType.Decimal)

            For Each c As PagamentoVenda In listaPagamentoVenda
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.Parameters("@Venda").Value = c.Venda
                oComm.Parameters("@Pagamento").Value = c.Pagamento
                oComm.Parameters("@Valor").Value = c.Valor

                oComm.ExecuteNonQuery()
            Next

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível atualizar Pagamento", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

End Class
