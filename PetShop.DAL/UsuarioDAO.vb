Imports System.Data.SqlClient
Imports PetShop.Entities

Public Class UsuarioDAO
    Inherits ConexaoDAO

    Public Function RetornaTodos() As List(Of Usuario)
        Dim oComm As New SqlCommand
		
        Try
            Dim listaUsuario As List(Of Usuario)

            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Nome, Senha, Nivel FROM Usuario"
            oComm.Connection.Open()
			
            Dim oDR As SqlDataReader = oComm.ExecuteReader()
			
            listaUsuario = PreencherLista(oDR)
			
            oDR.Close()
            oComm.Connection.Close()
			
            Return listaUsuario
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter usuário.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function
	
    Private Function PreencherLista(ByVal reader As SqlDataReader) As List(Of Usuario)
        Try

            Dim listaUsuario As New List(Of Usuario)

            While (reader.Read)
			
                Dim c As New Usuario
                c.Codigo = reader.GetInt32(0)
                c.Nome = reader.GetString(1)
                c.Senha = reader.GetString(2)
                c.Nivel = reader.GetByte(3)

                listaUsuario.Add(c)

            End While

            Return listaUsuario

        Catch ex As Exception
		
        End Try
    End Function
	
    Public Function usuarioporCodigo(ByVal Codigo As Integer) As List(Of Usuario)
        Dim oComm As New SqlCommand
		
        Try
            Dim listaUsuario As List(Of Usuario)
			
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Nome, Senha, Nivel FROM Usuario WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            listaUsuario = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

            Return listaUsuario

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter usuário.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function
	
    Public Sub excluiUsuario(ByVal listaUsuario As List(Of Usuario))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM Usuario WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Connection.Open()
			
            For Each c As Usuario In listaUsuario
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.ExecuteNonQuery()
            Next
			
            oComm.Connection.Close()
			
        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar usuário.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub excluiUsuario(ByVal Codigo As Integer)
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM Usuario WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo

            oComm.Connection.Open()
            oComm.ExecuteNonQuery()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível deletar usuário.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub
	
    Public Sub insereUsuario(ByVal listaUsuario As List(Of Usuario))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO Usuario (Nome, Senha, Nivel) VALUES(@Nome, @Senha, @Nivel)"

            oComm.Parameters.Add("@Nome", SqlDbType.NChar)
            oComm.Parameters.Add("@Senha", SqlDbType.NChar)
            oComm.Parameters.Add("@Nivel", SqlDbType.Int)

            oComm.Connection.Open()

            For Each c As Usuario In listaUsuario
                oComm.Parameters("@Nome").Value = c.Nome
                oComm.Parameters("@Senha").Value = c.Senha
                oComm.Parameters("@Nivel").Value = c.Nivel

                oComm.ExecuteNonQuery()
            Next

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir usuarios", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub insereUsuario(ByVal Usuario As Usuario) '
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO Usuario (Nome, Obs, Especie) VALUES(@Nome, @Obs, @Especie)"

            oComm.Parameters.Add("@Nome", SqlDbType.NChar)
            oComm.Parameters.Add("@Senha", SqlDbType.NChar)
            oComm.Parameters.Add("@Nivel", SqlDbType.Int)

            oComm.Connection.Open()

            oComm.Parameters("@Nome").Value = Usuario.Nome
            oComm.Parameters("@Senha").Value = Usuario.Senha
            oComm.Parameters("@Nivel").Value = Usuario.Nivel

            oComm.ExecuteNonQuery()

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir o usuário", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

    Public Sub updateUsuario(ByVal listaUsuario As List(Of Usuario))
        Dim oComm As New SqlCommand
		
        Try
            oComm.Connection = MyBase.obterConexao
            oComm.CommandText = "UPDATE Usuario SET Nome = @Nome, Senha = @Senha, Nivel = @Nivel WHERE Codigo = @Codigo"

            oComm.Parameters.Add("@Codigo", SqlDbType.Int)
            oComm.Parameters.Add("@Nome", SqlDbType.NChar)
            oComm.Parameters.Add("@Obs", SqlDbType.NChar)
			oComm.Parameters.Add("@Especie", SqlDbType.Int)
            
            For Each c As Usuario In listaUsuario
                oComm.Parameters("@Codigo").Value = c.Codigo
                oComm.Parameters("@Nome").Value = c.Nome
                oComm.Parameters("@Senha").Value = c.Senha
                oComm.Parameters("@Nivel").Value = c.Nivel

                oComm.ExecuteNonQuery()
            Next

            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível atualizar usuários", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Sub

End Class
