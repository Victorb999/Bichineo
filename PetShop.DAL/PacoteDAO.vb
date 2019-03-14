Imports System.Data.SqlClient
Imports PetShop.Entities

Public Class PacoteDAO
    Inherits ConexaoDAO
	
    Public Function RetornaTodos() As List(Of Pacote)
        Dim oComm As New SqlCommand
		
        Try
            Dim listaPacote As List(Of Pacote)
			
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Descricao, Preco FROM Pacote"
            oComm.Connection.Open()
			
            Dim oDR As SqlDataReader = oComm.ExecuteReader()
			
            listaPacote = PreencherLista(oDR)
			
            oDR.Close()
            oComm.Connection.Close()
			
            Return listaPacote
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter pacotes.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function
	
    Private Function PreencherLista(ByVal reader As SqlDataReader) As List(Of Pacote)
        Try
			
            Dim listaPacote As New List(Of Pacote)
			
            While (reader.Read)
			
                Dim c As New Pacote
                c.Codigo = reader.GetInt32(0)
                c.Descricao = reader.GetString(1)
                c.Preco = reader.GetDecimal(2)

                listaPacote.Add(c)
				
            End While
			
            Return listaPacote
			
        Catch ex As Exception
		
        End Try
    End Function
	
    Public Function pacoteporCodigo(ByVal Codigo As Integer) As List(Of Pacote)
        Dim oComm As New SqlCommand
		
        Try
            Dim listaPacote As List(Of Pacote)
			
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Descricao, Preco FROM Pacote WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            listaPacote = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

            Return listaPacote

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter pacote.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function
	
    Public Sub excluiPacote(ByVal listaPacote As List(Of Pacote))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM Pacote WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Connection.Open()
			
            For Each c As Pacote In listaPacote
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.ExecuteNonQuery()
            Next
			
            oComm.Connection.Close()
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar pacotes.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub
	
    Public Sub excluiPacote(ByVal Codigo As Integer)
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM Pacote WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo

            oComm.Connection.Open()
            oComm.ExecuteNonQuery()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar pacote.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub
	
    Public Sub inserePacote(ByVal listaPacote As List(Of Pacote))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO Pacote (Descricao, Preco) VALUES(@Descricao, @Preco)"

            oComm.Parameters.Add("@Descricao", SqlDbType.NChar)
            oComm.Parameters.Add("@Preco", SqlDbType.Decimal)

            oComm.Connection.Open()

            For Each c As Pacote In listaPacote
                oComm.Parameters("@Descricao").Value = c.Descricao
                oComm.Parameters("@Preco").Value = c.Preco

                oComm.ExecuteNonQuery()
            Next

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir pacotes.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub inserePacote(ByVal Pacote As Pacote) '
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO Pacote (Descricao, Preco) VALUES(@Descricao, @Preco)"

            oComm.Parameters.Add("@Descricao", SqlDbType.NChar)
            oComm.Parameters.Add("@Preco", SqlDbType.Decimal)

            oComm.Connection.Open()

            oComm.Parameters("@Descricao").Value = Pacote.Descricao
            oComm.Parameters("@Preco").Value = Pacote.Preco

            oComm.ExecuteNonQuery()

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir o Pacote.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub updatePacote(ByVal listaPacote As List(Of Pacote))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao
            oComm.CommandText = "UPDATE Pacote SET Descricao = @Descricao, Preco = @Preco WHERE Codigo = @Codigo"

            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Parameters.Add("@Descricao", SqlDbType.NChar)
            oComm.Parameters.Add("@Preco", SqlDbType.Decimal)

            For Each c As Pacote In listaPacote
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.Parameters("@Descricao").Value = c.Descricao
                oComm.Parameters("@Preco").Value = c.Preco

                oComm.ExecuteNonQuery()
            Next

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível atualizar pacotes.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

End Class
