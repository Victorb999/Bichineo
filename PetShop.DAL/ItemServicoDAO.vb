Imports System.Data.SqlClient
Imports PetShop.Entities

Public Class ItemServicoDAO
    Inherits ConexaoDAO

    Public Function RetornaTodos() As List(Of ItemServico)
        Dim oComm As New SqlCommand
		
        Try
            Dim listaItemServico As List(Of ItemServico)
			
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Venda, Desconto, Profissional, Preco FROM ItemServico"
            oComm.Connection.Open()
			
            Dim oDR As SqlDataReader = oComm.ExecuteReader()
			
            listaItemServico = PreencherLista(oDR)
			
            oDR.Close()
            oComm.Connection.Close()
			
            Return listaItemServico
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter ItemServico", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function
	
    Private Function PreencherLista(ByVal reader As SqlDataReader) As List(Of ItemServico)
        Try
			
            Dim listaItemServico As New List(Of ItemServico)
			
            While (reader.Read)
				
                Dim c As New ItemServico
                c.Codigo = reader.GetInt32(0)
                c.Venda = reader.GetInt32(1)
                c.Desconto = reader.GetDecimal(2)
                c.Profissional = reader.GetInt32(3)
                c.Preco = reader.GetDecimal(4)

                listaItemServico.Add(c)

            End While

            Return listaItemServico

        Catch ex As Exception
		
        End Try
    End Function
	
    Public Function itemServicoporCodigo(ByVal Codigo As Integer) As List(Of ItemServico)
        Dim oComm As New SqlCommand
		
        Try
            Dim listaItemServico As List(Of ItemServico)
			
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Venda, Desconto, Profissional, Preco FROM ItemServico WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
            oComm.Connection.Open()
			
            Dim oDR As SqlDataReader = oComm.ExecuteReader()
			
            listaItemServico = PreencherLista(oDR)
			
            oDR.Close()	
            oComm.Connection.Close()
			
            Return listaItemServico
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter itemServico", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function
	
    Public Sub excluiItemServico(ByVal listaItemServico As List(Of ItemServico))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM ItemServico WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Connection.Open()
			
            For Each c As ItemServico In listaItemServico
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.ExecuteNonQuery()
            Next
			
            oComm.Connection.Close()
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar itemServico", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub
	
    Public Sub excluiItemServico(ByVal Codigo As Integer)
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM ItemServico WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
			
            oComm.Connection.Open()
            oComm.ExecuteNonQuery()
            oComm.Connection.Close()
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar itemServico", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub
	
    Public Sub insereItemServico(ByVal listaItemServico As List(Of ItemServico))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO ItemServico " &
            "(Venda, Desconto, Profissional, Preco) VALUES " &
            "(@venda, @Desconto, @Profissional, @Preco)"

            oComm.Parameters.Add("@Venda", SqlDbType.Int)
            oComm.Parameters.Add("@Desconto", SqlDbType.Decimal)
            oComm.Parameters.Add("@Profissional", SqlDbType.Int)
            oComm.Parameters.Add("@Preco", SqlDbType.Decimal)

            oComm.Connection.Open()
			
            For Each c As ItemServico In listaItemServico
                oComm.Parameters("@Venda").Value = c.Venda
                oComm.Parameters("@Desconto").Value = c.Desconto
                oComm.Parameters("@Profissional").Value = c.Profissional
                oComm.Parameters("@Preco").Value = c.Preco

                oComm.ExecuteNonQuery()
            Next
			
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir ItemServiço", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub insereItemServico(ByVal ItemServico As ItemServico) '
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO ItemServico " &
            "(Venda, Desconto, Profissional, Preco) VALUES " &
            "(@venda, @Desconto, @Profissional, @Preco)"

            oComm.Parameters.Add("@Venda", SqlDbType.Int)
            oComm.Parameters.Add("@Desconto", SqlDbType.Decimal)
            oComm.Parameters.Add("@Profissional", SqlDbType.Int)
            oComm.Parameters.Add("@Preco", SqlDbType.Decimal)

            oComm.Connection.Open()

            oComm.Parameters("@Venda").Value = ItemServico.Venda
            oComm.Parameters("@Desconto").Value = ItemServico.Desconto
            oComm.Parameters("@Profissional").Value = ItemServico.Profissional
            oComm.Parameters("@Preco").Value = ItemServico.Preco

            oComm.ExecuteNonQuery()

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir o itemServico", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub updateItemServico(ByVal listaItemServico As List(Of ItemServico))
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao
            oComm.CommandText = "UPDATE ItemServico SET Venda = @Venda, Desconto = @Desconto, Profissional = @Profissional, Preco = @Preco " &
                "WHERE Codigo = @Codigo"

            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Parameters.Add("@Venda", SqlDbType.Int)
            oComm.Parameters.Add("@Desconto", SqlDbType.Decimal)
            oComm.Parameters.Add("@Profissional", SqlDbType.Int)
            oComm.Parameters.Add("@Preco", SqlDbType.Decimal)

            For Each c As ItemServico In listaItemServico
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.Parameters("@Venda").Value = c.Venda
                oComm.Parameters("@Desconto").Value = c.Desconto
                oComm.Parameters("@Profissional").Value = c.Profissional
                oComm.Parameters("@Preco").Value = c.Preco

                oComm.ExecuteNonQuery()
            Next

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível atualizar eventos de ItemServico", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

End Class
