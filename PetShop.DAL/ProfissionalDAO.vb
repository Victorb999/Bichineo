Imports System.Data.SqlClient
Imports PetShop.Entities

Public Class ProfissionalDAO
    Inherits ConexaoDAO
	
    Public Function RetornaTodos() As List(Of Profissional)
        Dim oComm As New SqlCommand
		
        Try
            Dim listaProfissional As List(Of Profissional)
			
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Nome, Comissao,Funcao FROM Profissional"
            oComm.Connection.Open()
			
            Dim oDR As SqlDataReader = oComm.ExecuteReader()
			
            listaProfissional = PreencherLista(oDR)
			
            oDR.Close()
            oComm.Connection.Close()
			
            Return listaProfissional
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter profissionais.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function
	
    Private Function PreencherLista(ByVal reader As SqlDataReader) As List(Of Profissional)
        Try
			
            Dim listaProfissional As New List(Of Profissional)
			
            While (reader.Read)
			
                Dim c As New Profissional
                c.Codigo = reader.GetInt32(0)
                c.Nome = reader.GetString(1)
                c.Comissao = reader.GetDecimal(2)
                c.Funcao = reader.GetString(3)

                listaProfissional.Add(c)
				
            End While
			
            Return listaProfissional
			
        Catch ex As Exception
		
        End Try
    End Function
	
    Public Function profissionalporCodigo(ByVal Codigo As Integer) As List(Of Profissional)
        Dim oComm As New SqlCommand
		
        Try
            Dim listaProfissional As List(Of Profissional)
			
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Nome, Comissao, Funcao FROM Profissional WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            listaProfissional = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

            Return listaProfissional

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter profissional.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function
	
    Public Sub excluiProfissional(ByVal listaProfissional As List(Of Profissional))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM Profissional WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Connection.Open()
			
            For Each c As Profissional In listaProfissional
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.ExecuteNonQuery()
            Next
			
            oComm.Connection.Close()
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar profissional.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub
	
    Public Sub excluiProfissional(ByVal Codigo As Integer)
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM Profissional WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo

            oComm.Connection.Open()
            oComm.ExecuteNonQuery()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar profissional.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub
	
    Public Sub insereProfissional(ByVal listaProfissional As List(Of Profissional))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO Profissional (Nome, Comissao, Funcao) VALUES(@Nome, @Comissao, @Funcao)"

            oComm.Parameters.Add("@Nome", SqlDbType.NChar)
            oComm.Parameters.Add("@Comissao", SqlDbType.Decimal)
            oComm.Parameters.Add("@Funcao", SqlDbType.NChar)

            oComm.Connection.Open()

            For Each c As Profissional In listaProfissional
                oComm.Parameters("@Nome").Value = c.Nome
                oComm.Parameters("@Comissao").Value = c.Comissao
                oComm.Parameters("@Funcao").Value = c.Funcao

                oComm.ExecuteNonQuery()
            Next

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir profissionais.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub insereProfissional(ByVal Profissional As Profissional) '
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO Profissional (Nome, Comissao, Funcao) VALUES(@Nome, @Comissao, @Funcao)"

            oComm.Parameters.Add("@Nome", SqlDbType.NChar)
            oComm.Parameters.Add("@Comissao", SqlDbType.Decimal)
            oComm.Parameters.Add("@Funcao", SqlDbType.NChar)

            oComm.Connection.Open()

            oComm.Parameters("@Nome").Value = Profissional.Nome
            oComm.Parameters("@Comissao").Value = Profissional.Comissao
            oComm.Parameters("@Funcao").Value = Profissional.Funcao

            oComm.ExecuteNonQuery()

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir o Profissional.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub updateProfissional(ByVal listaProfissional As List(Of Profissional))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao
            oComm.CommandText = "UPDATE Profissional SET Nome = @Nome, Comissao = @Comissao, Funcao = @Funcao WHERE Codigo = @Codigo"

            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Parameters.Add("@Nome", SqlDbType.NChar)
            oComm.Parameters.Add("@Comissao", SqlDbType.Decimal)
            oComm.Parameters.Add("@Funcao", SqlDbType.NChar)

            For Each c As Profissional In listaProfissional
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.Parameters("@Nome").Value = c.Nome
                oComm.Parameters("@Comissao").Value = c.Comissao
                oComm.Parameters("@Funcao").Value = c.Funcao

                oComm.ExecuteNonQuery()
            Next

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível atualizar profissionais.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

End Class
