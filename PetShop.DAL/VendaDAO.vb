Imports System.Data.SqlClient
Imports PetShop.Entities

Public Class VendaDAO
    Inherits ConexaoDAO

    Public Function RetornaTodos() As List(Of Venda)
        Dim oComm As New SqlCommand
		
        Try
            Dim listaVenda As List(Of Venda)

            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Usuario, Cliente, Data, Valor, Status FROM Venda"
            oComm.Connection.Open()
			
            Dim oDR As SqlDataReader = oComm.ExecuteReader()
			
            listaVenda = PreencherLista(oDR)
			
            oDR.Close()
            oComm.Connection.Close()
			
            Return listaVenda
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter Venda", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function
	
    Private Function PreencherLista(ByVal reader As SqlDataReader) As List(Of Venda)
        Try
			
            Dim listaVenda As New List(Of Venda)
			
            While (reader.Read)
				
                Dim c As New Venda
                c.Codigo = reader.GetInt32(0)
                c.Usuario = reader.GetInt32(1)
                c.Cliente = reader.GetInt32(2)
                c.Data = reader.GetDateTime(3)
                c.Valor = reader.GetDecimal(4)
                c.Status = reader.GetInt16(5)

                listaVenda.Add(c)

            End While

            Return listaVenda

        Catch ex As Exception
		
        End Try
    End Function
	
    Public Function vendaporCodigo(ByVal Codigo As Integer) As List(Of Venda)
        Dim oComm As New SqlCommand
		
        Try
            Dim listaVenda As List(Of Venda)
			
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Usuario, Cliente, Data, Valor, Status FROM Venda WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
            oComm.Connection.Open()
			
            Dim oDR As SqlDataReader = oComm.ExecuteReader()
			
            listaVenda = PreencherLista(oDR)
			
            oDR.Close()	
            oComm.Connection.Close()
			
            Return listaVenda
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter venda", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function
	
    Public Sub excluiVenda(ByVal listaVenda As List(Of Venda))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM Venda WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Connection.Open()
			
            For Each c As Venda In listaVenda
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.ExecuteNonQuery()
            Next
			
            oComm.Connection.Close()
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar venda", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub
	
    Public Sub excluiVenda(ByVal Codigo As Integer)
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM Venda WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
			
            oComm.Connection.Open()
            oComm.ExecuteNonQuery()
            oComm.Connection.Close()
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar venda", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub
	
    Public Sub insereVenda(ByVal listaVenda As List(Of Venda))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO Venda (Usuario, Cliente, Data, Valor, Status) VALUES " &
            "(@Usuario, @Cliente, @Data, @Valor, @Status)"

            oComm.Parameters.Add("@Usuario", SqlDbType.Int)
            oComm.Parameters.Add("@Cliente", SqlDbType.Int)
            oComm.Parameters.Add("@Data", SqlDbType.DateTime)
            oComm.Parameters.Add("@Valor", SqlDbType.Decimal)
            oComm.Parameters.Add("@Status", SqlDbType.TinyInt)

            oComm.Connection.Open()
			
            For Each c As Venda In listaVenda
                oComm.Parameters("@Usuario").Value = c.Usuario
                oComm.Parameters("@Cliente").Value = c.Cliente
                oComm.Parameters("@Data").Value = c.Data
                oComm.Parameters("@Valor").Value = c.Valor
                oComm.Parameters("@Status").Value = c.Status

                oComm.ExecuteNonQuery()
            Next
			
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir animais", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub insereVenda(ByVal Venda As Venda) '
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO Venda " &
            "(Nome, DtNascimento, Sexo, Obs, Raca, Cliente) VALUES " &
            "(@Nome, @DtNascimento, @Sexo, @Obs, @Raca, @Cliente)"

            oComm.Parameters.Add("@Usuario", SqlDbType.Int)
            oComm.Parameters.Add("@Cliente", SqlDbType.Int)
            oComm.Parameters.Add("@Data", SqlDbType.DateTime)
            oComm.Parameters.Add("@Valor", SqlDbType.Decimal)
            oComm.Parameters.Add("@Status", SqlDbType.TinyInt)

            oComm.Connection.Open()

            oComm.Parameters("@Usuario").Value = Venda.Usuario
            oComm.Parameters("@Cliente").Value = Venda.Cliente
            oComm.Parameters("@Data").Value = Venda.Data
            oComm.Parameters("@Valor").Value = Venda.Valor
            oComm.Parameters("@Status").Value = Venda.Status

            oComm.ExecuteNonQuery()

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir o venda", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub updateVenda(ByVal listaVenda As List(Of Venda))
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao
            oComm.CommandText = "UPDATE Venda SET Usuario = @Usuario, Cliente = @Cliente, Data = @Data, Valor = @Valor, Status = @Status " &
                "WHERE Codigo = @Codigo"

            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Parameters.Add("@Usuario", SqlDbType.Int)
            oComm.Parameters.Add("@Cliente", SqlDbType.Int)
            oComm.Parameters.Add("@Data", SqlDbType.DateTime)
            oComm.Parameters.Add("@Valor", SqlDbType.Decimal)
            oComm.Parameters.Add("@Status", SqlDbType.TinyInt)

            For Each c As Venda In listaVenda
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.Parameters("@Usuario").Value = c.Usuario
                oComm.Parameters("@Cliente").Value = c.Cliente
                oComm.Parameters("@Data").Value = c.Data
                oComm.Parameters("@Valor").Value = c.Valor
                oComm.Parameters("@Status").Value = c.Status

                oComm.ExecuteNonQuery()
            Next

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível atualizar eventos de Venda", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

End Class
