Imports System.Data.SqlClient
Imports PetShop.Entities

Public Class ProdutoDAO
    Inherits ConexaoDAO

    Public Function RetornaTodos() As List(Of Produto)
        Dim oComm As New SqlCommand

        Try
            Dim listaProduto As List(Of Produto)
			
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Descricao, PrecoCusto, PrecoVenda, CodigoBarras, Estoque, Tipo FROM Produto"
            oComm.Connection.Open()
			
            Dim oDR As SqlDataReader = oComm.ExecuteReader()
			
            listaProduto = PreencherLista(oDR)
			
            oDR.Close()
            oComm.Connection.Close()
			
            Return listaProduto
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter Produto", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function
	
    Private Function PreencherLista(ByVal reader As SqlDataReader) As List(Of Produto)
        Try
			
            Dim listaProduto As New List(Of Produto)
			
            While (reader.Read)
				
                Dim c As New Produto
                c.Codigo = reader.Item("Codigo")
                c.Descricao = reader.Item("Descricao")
                c.PrecoCusto = reader.Item("PrecoCusto")
                c.PrecoVenda = reader.Item("PrecoVenda")
                c.CodigoBarras = reader.Item("CodigoBarras")
                c.Estoque = reader.Item("Estoque")
                c.Tipo = reader.Item("Tipo")

                listaProduto.Add(c)

            End While

            Return listaProduto

        Catch ex As Exception
		
        End Try
    End Function

    'Public Function ProdutoporCodigo(ByVal Codigo As Integer) As List(Of Produto)
    '    Dim oComm As New SqlCommand

    '    Try
    '        Dim listaProduto As List(Of Produto)

    '        oComm.Connection = MyBase.obterConexao()
    '        oComm.CommandText = "SELECT Codigo, Descricao, PrecoCusto, PrecoVenda, CodigoBarras, Estoque, Tipo FROM Produto WHERE Codigo = @Codigo"
    '        oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
    '        oComm.Connection.Open()

    '        Dim oDR As SqlDataReader = oComm.ExecuteReader()

    '        listaProduto = PreencherLista(oDR)

    '        oDR.Close()
    '        oComm.Connection.Close()

    '        Return listaProduto

    '    Catch ex As Exception
    '        Throw New ApplicationException("Não foi possível obter Produto", ex)
    '    Finally
    '        If oComm.Connection.State = ConnectionState.Open Then
    '            oComm.Connection.Close()
    '        End If
    '    End Try
    'End Function

    Public Function ProdutoporCodigo(ByVal Codigo As Integer) As Produto
        Dim oComm As New SqlCommand

        Try
            Dim listaProduto As List(Of Produto)

            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Descricao, PrecoCusto, PrecoVenda, CodigoBarras, Estoque, Tipo FROM Produto WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            listaProduto = PreencherLista(oDR)

            If listaProduto.Count = 0 Then
                ProdutoporCodigo = New Produto
            Else
                ProdutoporCodigo = listaProduto.Item(0)
            End If

            oDR.Close()
            oComm.Connection.Close()

            ' Return listaProduto

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter Produto", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Sub excluiProduto(ByVal listaProduto As List(Of Produto))
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM Produto WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Connection.Open()

            For Each c As Produto In listaProduto
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.ExecuteNonQuery()
            Next

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar Produto", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Function excluiProduto(ByVal Codigo As Integer) As Integer
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM Produto OUTPUT DELETED.Codigo WHERE  Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo

            oComm.Connection.Open()
            excluiProduto = oComm.ExecuteScalar()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar Produto", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Sub insereProduto(ByVal listaProduto As List(Of Produto))
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO Produto " &
            "(Descricao, PrecoCusto, PrecoVenda, CodigoBarras, Estoque, Tipo) VALUES " &
            "(@Descricao, @PrecoCusto, @PrecoVenda, @CodigoBarras, @Estoque, @Tipo)"

            oComm.Parameters.Add("@Descricao", SqlDbType.NChar)
            oComm.Parameters.Add("@PrecoCusto", SqlDbType.Decimal)
            oComm.Parameters.Add("@PrecoVenda", SqlDbType.Decimal)
            oComm.Parameters.Add("@CodigoBarras", SqlDbType.NChar)
            oComm.Parameters.Add("@Estoque", SqlDbType.Decimal)
            oComm.Parameters.Add("@Tipo", SqlDbType.TinyInt)

            oComm.Connection.Open()

            For Each c As Produto In listaProduto
                oComm.Parameters("@Descricao").Value = c.Descricao
                oComm.Parameters("@PrecoCusto").Value = c.PrecoCusto
                oComm.Parameters("@PrecoVenda").Value = c.PrecoVenda
                oComm.Parameters("@CodigoBarras").Value = c.CodigoBarras
                oComm.Parameters("@Estoque").Value = c.Estoque
                oComm.Parameters("@Tipo").Value = c.Tipo

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

    Public Function insereProduto(ByVal Produto As Produto) As Integer
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO Produto " &
            "(Descricao, PrecoCusto, PrecoVenda, CodigoBarras, Estoque, Tipo) OUTPUT INSERTED.Codigo VALUES " &
            "(@Descricao, @PrecoCusto, @PrecoVenda, @CodigoBarras, @Estoque, @Tipo)"

            oComm.Parameters.Add("@Descricao", SqlDbType.NChar)
            oComm.Parameters.Add("@PrecoCusto", SqlDbType.Decimal)
            oComm.Parameters.Add("@PrecoVenda", SqlDbType.Decimal)
            oComm.Parameters.Add("@CodigoBarras", SqlDbType.NChar)
            oComm.Parameters.Add("@Estoque", SqlDbType.Decimal)
            oComm.Parameters.Add("@Tipo", SqlDbType.TinyInt)

            oComm.Connection.Open()

            oComm.Parameters("@Descricao").Value = Produto.Descricao
            oComm.Parameters("@PrecoCusto").Value = Produto.PrecoCusto
            oComm.Parameters("@PrecoVenda").Value = Produto.PrecoVenda
            oComm.Parameters("@CodigoBarras").Value = Produto.CodigoBarras
            oComm.Parameters("@Estoque").Value = Produto.Estoque
            oComm.Parameters("@Tipo").Value = Produto.Tipo

            'oComm.ExecuteNonQuery()
            insereProduto = oComm.ExecuteScalar()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir o itemProduto", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function updateProduto(ByVal Produto As Produto) As Integer
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "UPDATE Produto SET Descricao = @Descricao, PrecoCusto = @PrecoCusto, PrecoVenda = @PrecoVenda, CodigoBarras = @CodigoBarras, " &
                "Estoque = @Estoque, Tipo = @Tipo OUTPUT INSERTED.Codigo WHERE Codigo = @Codigo"

            oComm.Parameters.Add("@Descricao", SqlDbType.NChar)
            oComm.Parameters.Add("@PrecoCusto", SqlDbType.Decimal)
            oComm.Parameters.Add("@PrecoVenda", SqlDbType.Decimal)
            oComm.Parameters.Add("@CodigoBarras", SqlDbType.NChar)
            oComm.Parameters.Add("@Estoque", SqlDbType.Decimal)
            oComm.Parameters.Add("@Tipo", SqlDbType.TinyInt)

            oComm.Connection.Open()

            oComm.Parameters("@Descricao").Value = Produto.Descricao
            oComm.Parameters("@PrecoCusto").Value = Produto.PrecoCusto
            oComm.Parameters("@PrecoVenda").Value = Produto.PrecoVenda
            oComm.Parameters("@CodigoBarras").Value = Produto.CodigoBarras
            oComm.Parameters("@Estoque").Value = Produto.Estoque
            oComm.Parameters("@Tipo").Value = Produto.Tipo

            'oComm.ExecuteNonQuery()
            updateProduto = oComm.ExecuteScalar()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir o itemProduto", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function


    Public Sub updateProduto(ByVal listaProduto As List(Of Produto))
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao
            oComm.CommandText = "UPDATE Produto SET Descricao = @Descricao, PrecoCusto = @PrecoCusto, PrecoVenda = @PrecoVenda, CodigoBarras = @CodigoBarras, " &
                "Estoque = @Estoque, Tipo = @Tipo WHERE Codigo = @Codigo"

            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Parameters.Add("@Descricao", SqlDbType.NChar)
            oComm.Parameters.Add("@PrecoCusto", SqlDbType.Decimal)
            oComm.Parameters.Add("@PrecoVenda", SqlDbType.Decimal)
            oComm.Parameters.Add("@CodigoBarras", SqlDbType.NChar)
            oComm.Parameters.Add("@Estoque", SqlDbType.Decimal)
            oComm.Parameters.Add("@Tipo", SqlDbType.TinyInt)

            For Each c As Produto In listaProduto
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.Parameters("@Descricao").Value = c.Descricao
                oComm.Parameters("@PrecoCusto").Value = c.PrecoCusto
                oComm.Parameters("@PrecoVenda").Value = c.PrecoVenda
                oComm.Parameters("@CodigoBarras").Value = c.CodigoBarras
                oComm.Parameters("@Estoque").Value = c.Estoque
                oComm.Parameters("@Tipo").Value = c.Tipo

                oComm.ExecuteNonQuery()
            Next

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível atualizar Produto", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Function ProdutoPorDescricao(ByVal descricao As String) As List(Of Produto)
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Descricao, PrecoCusto, PrecoVenda, CodigoBarras, Estoque, Tipo FROM Produto WHERE Descricao LIKE +@Descricao +'%' "
            oComm.Parameters.Add("@Descricao", SqlDbType.NVarChar).Value = descricao
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            ProdutoPorDescricao = PreencherLista(oDR)

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
