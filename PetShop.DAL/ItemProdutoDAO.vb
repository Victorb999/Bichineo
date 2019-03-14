Imports System.Data.SqlClient
Imports PetShop.Entities

Public Class ItemProdutoDAO
    Inherits ConexaoDAO

    Public Function RetornaTodos() As List(Of ItemProduto)
        Dim oComm As New SqlCommand

        Try
            Dim listaItemProduto As List(Of ItemProduto)
			
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Venda, Produto, PrecoCusto, PrecoVenda, Desconto, Quantidade FROM ItemProduto"
            oComm.Connection.Open()
			
            Dim oDR As SqlDataReader = oComm.ExecuteReader()
			
            listaItemProduto = PreencherLista(oDR)
			
            oDR.Close()
            oComm.Connection.Close()
			
            Return listaItemProduto
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter ItemProduto", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function
	
    Private Function PreencherLista(ByVal reader As SqlDataReader) As List(Of ItemProduto)
        Try
			
            Dim listaItemProduto As New List(Of ItemProduto)
			
            While (reader.Read)
				
                Dim c As New ItemProduto
                c.Codigo = reader.GetInt32(0)
                c.Venda = reader.GetInt32(1)
                c.Produto = reader.GetInt32(2)
                c.PrecoCusto = reader.GetDecimal(3)
                c.PrecoVenda = reader.GetDecimal(4)
                c.Desconto = reader.GetDecimal(5)
                c.Quantidade = reader.GetDecimal(6)

                listaItemProduto.Add(c)

            End While

            Return listaItemProduto

        Catch ex As Exception
		
        End Try
    End Function
	
    Public Function itemProdutoporCodigo(ByVal Codigo As Integer) As List(Of ItemProduto)
        Dim oComm As New SqlCommand
		
        Try
            Dim listaItemProduto As List(Of ItemProduto)
			
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Venda, Produto, PrecoCusto, PrecoVenda, Desconto, Quantidade FROM ItemProduto WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
            oComm.Connection.Open()
			
            Dim oDR As SqlDataReader = oComm.ExecuteReader()
			
            listaItemProduto = PreencherLista(oDR)
			
            oDR.Close()	
            oComm.Connection.Close()
			
            Return listaItemProduto
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter itemProduto", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function
	
    Public Sub excluiItemProduto(ByVal listaItemProduto As List(Of ItemProduto))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM ItemProduto WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Connection.Open()
			
            For Each c As ItemProduto In listaItemProduto
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.ExecuteNonQuery()
            Next
			
            oComm.Connection.Close()
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar itemProduto", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub
	
    Public Sub excluiItemProduto(ByVal Codigo As Integer)
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM ItemProduto WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
			
            oComm.Connection.Open()
            oComm.ExecuteNonQuery()
            oComm.Connection.Close()
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar itemProduto", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub
	
    Public Sub insereItemProduto(ByVal listaItemProduto As List(Of ItemProduto))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO ItemProduto " &
            "(Venda, Produto, PrecoCusto, PrecoVenda, Desconto, Quantidade) VALUES " &
            "(@venda, @Produto, @PrecoCusto, @PrecoVenda, @Desconto, @Quantidade)"

            oComm.Parameters.Add("@Venda", SqlDbType.Int)
            oComm.Parameters.Add("@Produto", SqlDbType.Int)
            oComm.Parameters.Add("@PrecoCusto", SqlDbType.Decimal)
            oComm.Parameters.Add("@PrecoVenda", SqlDbType.Decimal)
            oComm.Parameters.Add("@Desconto", SqlDbType.Decimal)
            oComm.Parameters.Add("@Quantidade", SqlDbType.Decimal)

            oComm.Connection.Open()
			
            For Each c As ItemProduto In listaItemProduto
                oComm.Parameters("@Venda").Value = c.Venda
                oComm.Parameters("@Produto").Value = c.Produto
                oComm.Parameters("@PrecoCusto").Value = c.PrecoCusto
                oComm.Parameters("@PrecoVenda").Value = c.PrecoVenda
                oComm.Parameters("@Desconto").Value = c.Desconto
                oComm.Parameters("@Quantidade").Value = c.Quantidade

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

    Public Sub insereItemProduto(ByVal ItemProduto As ItemProduto) '
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO ItemProduto " &
            "(Venda, Produto, PrecoCusto, PrecoVenda, Desconto, Quantidade) VALUES " &
            "(@venda, @Produto, @PrecoCusto, @PrecoVenda, @Desconto, @Quantidade)"

            oComm.Parameters.Add("@Venda", SqlDbType.Int)
            oComm.Parameters.Add("@Produto", SqlDbType.Int)
            oComm.Parameters.Add("@PrecoCusto", SqlDbType.Decimal)
            oComm.Parameters.Add("@PrecoVenda", SqlDbType.Decimal)
            oComm.Parameters.Add("@Desconto", SqlDbType.Decimal)
            oComm.Parameters.Add("@Quantidade", SqlDbType.Decimal)

            oComm.Connection.Open()

            oComm.Parameters("@Venda").Value = ItemProduto.Venda
            oComm.Parameters("@Produto").Value = ItemProduto.Produto
            oComm.Parameters("@PrecoCusto").Value = ItemProduto.PrecoCusto
            oComm.Parameters("@PrecoVenda").Value = ItemProduto.PrecoVenda
            oComm.Parameters("@Desconto").Value = ItemProduto.Desconto
            oComm.Parameters("@Quantidade").Value = ItemProduto.Quantidade

            oComm.ExecuteNonQuery()

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir o itemProduto", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub updateItemProduto(ByVal listaItemProduto As List(Of ItemProduto))
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao
            oComm.CommandText = "UPDATE ItemProduto SET Venda = @Venda, Produto = @Produto, PrecoCusto = @PrecoCusto, PrecoVenda = @PrecoVenda, Desconto = @Desconto, " &
                "Quantidade = @Quantidade WHERE Codigo = @Codigo"

            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Parameters.Add("@Venda", SqlDbType.Int)
            oComm.Parameters.Add("@Produto", SqlDbType.Int)
            oComm.Parameters.Add("@PrecoCusto", SqlDbType.Decimal)
            oComm.Parameters.Add("@PrecoVenda", SqlDbType.Decimal)
            oComm.Parameters.Add("@Desconto", SqlDbType.Decimal)
            oComm.Parameters.Add("@Quantidade", SqlDbType.Decimal)

            For Each c As ItemProduto In listaItemProduto
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.Parameters("@Venda").Value = c.Venda
                oComm.Parameters("@Produto").Value = c.Produto
                oComm.Parameters("@PrecoCusto").Value = c.PrecoCusto
                oComm.Parameters("@PrecoVenda").Value = c.PrecoVenda
                oComm.Parameters("@Desconto").Value = c.Desconto
                oComm.Parameters("@Quantidade").Value = c.Quantidade

                oComm.ExecuteNonQuery()
            Next

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível atualizar ItemProduto", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

End Class
