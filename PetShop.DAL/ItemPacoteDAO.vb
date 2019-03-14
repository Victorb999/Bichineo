Imports System.Data.SqlClient
Imports PetShop.Entities

Public Class ItemPacoteDAO
    Inherits ConexaoDAO

    Public Function RetornaTodos() As List(Of ItemPacote)
        Dim oComm As New SqlCommand
		
        Try
            Dim listaItemPacote As List(Of ItemPacote)
			
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Pacote, Servico, Quantidade, Preco FROM ItemPacote"
            oComm.Connection.Open()
			
            Dim oDR As SqlDataReader = oComm.ExecuteReader()
			
            listaItemPacote = PreencherLista(oDR)
			
            oDR.Close()
            oComm.Connection.Close()
			
            Return listaItemPacote
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter ItemPacote", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function
	
    Private Function PreencherLista(ByVal reader As SqlDataReader) As List(Of ItemPacote)
        Try
			
            Dim listaItemPacote As New List(Of ItemPacote)
			
            While (reader.Read)
				
                Dim c As New ItemPacote
                c.Codigo = reader.GetInt32(0)
                c.Pacote = reader.GetInt32(1)
                c.Servico = reader.GetInt32(2)
                c.Quantidade = reader.GetInt32(3)
                c.Preco = reader.GetDecimal(4)

                listaItemPacote.Add(c)

            End While

            Return listaItemPacote

        Catch ex As Exception
		
        End Try
    End Function

    Public Function itemPacoteporCodigo(ByVal Codigo As Integer) As List(Of ItemPacote)
        Dim oComm As New SqlCommand

        Try
            Dim listaItemPacote As List(Of ItemPacote)

            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Pacote, Servico, Quantidade, Preco FROM ItemPacote WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            listaItemPacote = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

            Return listaItemPacote

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter itemPacote", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function itemPacotePorPacote(ByVal Pacote As Integer) As List(Of ItemPacote)
        Dim oComm As New SqlCommand

        Try
            Dim listaItemPacote As List(Of ItemPacote)

            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Pacote, Servico, Quantidade, Preco FROM ItemPacote WHERE Pacote = @Pacote"
            oComm.Parameters.Add("@Pacote", SqlDbType.Int).Value = Pacote
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            listaItemPacote = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

            Return listaItemPacote

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter itemPacote", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Sub excluiItemPacote(ByVal listaItemPacote As List(Of ItemPacote))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM ItemPacote WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Connection.Open()
			
            For Each c As ItemPacote In listaItemPacote
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.ExecuteNonQuery()
            Next
			
            oComm.Connection.Close()
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar ItemPacote", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub
	
    Public Sub excluiItemPacote(ByVal Codigo As Integer)
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM ItemPacote WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
			
            oComm.Connection.Open()
            oComm.ExecuteNonQuery()
            oComm.Connection.Close()
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar itemPacote", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub
	
    Public Sub insereItemPacote(ByVal listaItemPacote As List(Of ItemPacote))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO ItemPacote " &
            "(Pacote, Servico, Quantidade, Preco) VALUES " &
            "(@Pacote, @Servico, @Quantidade, @Preco)"

            oComm.Parameters.Add("@Pacote", SqlDbType.Int)
            oComm.Parameters.Add("@Servico", SqlDbType.Int)
            oComm.Parameters.Add("@Quantidade", SqlDbType.Int)
            oComm.Parameters.Add("@Preco", SqlDbType.Decimal)

            oComm.Connection.Open()
			
            For Each c As ItemPacote In listaItemPacote
                oComm.Parameters("@Pacote").Value = c.Pacote
                oComm.Parameters("@Servico").Value = c.Servico
                oComm.Parameters("@Quantidade").Value = c.Quantidade
                oComm.Parameters("@Preco").Value = c.Preco

                oComm.ExecuteNonQuery()
            Next
			
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir ItemPacote", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub insereItemPacote(ByVal ItemPacote As ItemPacote) '
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO ItemPacote " &
            "(Pacote, Servico, Quantidade, Preco) VALUES " &
            "(@Pacote, @Servico, @Quantidade, @Preco)"

            oComm.Parameters.Add("@Pacote", SqlDbType.Int)
            oComm.Parameters.Add("@Servico", SqlDbType.Int)
            oComm.Parameters.Add("@Quantidade", SqlDbType.Int)
            oComm.Parameters.Add("@Preco", SqlDbType.Decimal)

            oComm.Connection.Open()

            oComm.Parameters("@Pacote").Value = ItemPacote.Pacote
            oComm.Parameters("@Servico").Value = ItemPacote.Servico
            oComm.Parameters("@Quantidade").Value = ItemPacote.Quantidade
            oComm.Parameters("@Preco").Value = ItemPacote.Preco

            oComm.ExecuteNonQuery()

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir o ItemPacote", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub updateItemPacote(ByVal listaItemPacote As List(Of ItemPacote))
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao
            oComm.CommandText = "UPDATE ItemPacote SET Pacote = @Pacote, Servico = @Servico, Quantidade = @Quantidade, Preco = @Preco " &
                "WHERE Codigo = @Codigo"

            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Parameters.Add("@Pacote", SqlDbType.Int)
            oComm.Parameters.Add("@Servico", SqlDbType.Int)
            oComm.Parameters.Add("@Quantidade", SqlDbType.Int)
            oComm.Parameters.Add("@Preco", SqlDbType.Decimal)

            For Each c As ItemPacote In listaItemPacote
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.Parameters("@Pacote").Value = c.Pacote
                oComm.Parameters("@Servico").Value = c.Servico
                oComm.Parameters("@Quantidade").Value = c.Quantidade
                oComm.Parameters("@Preco").Value = c.Preco

                oComm.ExecuteNonQuery()
            Next

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível atualizar ItemPacote", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

End Class
