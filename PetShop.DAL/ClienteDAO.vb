Imports System.Data.SqlClient
Imports PetShop.Entities

Public Class ClienteDAO
    Inherits ConexaoDAO

    Public Function InsereCliente(ByVal Cliente As Cliente) As Integer
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "INSERT INTO Cliente " &
            "(Nome, CPF, Sexo, DtNascimento, DtCadastro, Telefone, Telefone2, Telefone3, Email, CEP, Endereco, Bairro, Cidade, UF) OUTPUT INSERTED.Codigo VALUES " &
            "(@Nome, @CPF, @Sexo, @DtNascimento, @DtCadastro, @Telefone, @Telefone2, @Telefone3, @Email, @CEP, @Endereco, @Bairro, @Cidade, @UF)"

            oComm.Parameters.Add("@Nome", SqlDbType.NChar).Value = Cliente.Nome
            oComm.Parameters.Add("@CPF", SqlDbType.NChar).Value = Cliente.CPF
            oComm.Parameters.Add("@Sexo", SqlDbType.NChar).Value = Cliente.Sexo
            oComm.Parameters.Add("@DtNascimento", SqlDbType.DateTime).Value = Cliente.DtNascimento
            oComm.Parameters.Add("@DtCadastro", SqlDbType.DateTime).Value = Cliente.DtCadastro
            oComm.Parameters.Add("@Telefone", SqlDbType.NChar).Value = Cliente.Telefone
            oComm.Parameters.Add("@Telefone2", SqlDbType.NChar).Value = Cliente.Telefone2
            oComm.Parameters.Add("@Telefone3", SqlDbType.NChar).Value = Cliente.Telefone3
            oComm.Parameters.Add("@Email", SqlDbType.NChar).Value = Cliente.Email
            oComm.Parameters.Add("@CEP", SqlDbType.NChar).Value = Cliente.CEP
            oComm.Parameters.Add("@Endereco", SqlDbType.NChar).Value = Cliente.Endereco
            oComm.Parameters.Add("@Bairro", SqlDbType.NChar).Value = Cliente.Bairro
            oComm.Parameters.Add("@Cidade", SqlDbType.NChar).Value = Cliente.Cidade
            oComm.Parameters.Add("@UF", SqlDbType.NChar).Value = Cliente.UF

            oComm.Connection.Open()
            InsereCliente = oComm.ExecuteScalar()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível inserir o cliente.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function AlteraCliente(ByVal Cliente As Cliente) As Integer
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao
            oComm.CommandText = "UPDATE Cliente SET Nome = @Nome, CPF = @CPF, Sexo = @Sexo, DtNascimento = @DtNascimento, DtCadastro = @DtCadastro, Telefone = @Telefone, " &
                "Telefone2 = @Telefone2,Telefone3 = @Telefone3, Email = @Email, CEP = @CEP, Endereco = @Endereco, Bairro = @Bairro, Cidade = @Cidade, UF = @UF " &
                "OUTPUT INSERTED.Codigo WHERE Codigo = @Codigo"

            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Cliente.Codigo
            oComm.Parameters.Add("@Nome", SqlDbType.NChar).Value = Cliente.Nome
            oComm.Parameters.Add("@CPF", SqlDbType.NChar).Value = Cliente.CPF
            oComm.Parameters.Add("@Sexo", SqlDbType.NChar).Value = Cliente.Sexo
            oComm.Parameters.Add("@DtNascimento", SqlDbType.DateTime).Value = Cliente.DtNascimento
            oComm.Parameters.Add("@DtCadastro", SqlDbType.DateTime).Value = Cliente.DtCadastro
            oComm.Parameters.Add("@Telefone", SqlDbType.NChar).Value = Cliente.Telefone
            oComm.Parameters.Add("@Telefone2", SqlDbType.NChar).Value = Cliente.Telefone2
            oComm.Parameters.Add("@Telefone3", SqlDbType.NChar).Value = Cliente.Telefone3
            oComm.Parameters.Add("@Email", SqlDbType.NChar).Value = Cliente.Email
            oComm.Parameters.Add("@CEP", SqlDbType.NChar).Value = Cliente.CEP
            oComm.Parameters.Add("@Endereco", SqlDbType.NChar).Value = Cliente.Endereco
            oComm.Parameters.Add("@Bairro", SqlDbType.NChar).Value = Cliente.Bairro
            oComm.Parameters.Add("@Cidade", SqlDbType.NChar).Value = Cliente.Cidade
            oComm.Parameters.Add("@UF", SqlDbType.NChar).Value = Cliente.UF

            oComm.Connection.Open()
            AlteraCliente = oComm.ExecuteScalar()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível atualizar o cliente.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function ExcluiCliente(ByVal Codigo As Integer) As Integer
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "DELETE FROM Cliente OUTPUT DELETED.Codigo WHERE Codigo = @Codigo"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo

            oComm.Connection.Open()
            ExcluiCliente = oComm.ExecuteScalar()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível excluir o cliente.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function RetornaTodos() As List(Of Cliente)
        Dim oComm As New SqlCommand

        Try
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Nome, CPF, Sexo, DtNascimento, DtCadastro, Telefone, Telefone2, Telefone3, Email, CEP, Endereco, " &
            "Bairro, Cidade, UF FROM Cliente order by Nome"
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            RetornaTodos = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter clientes.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function ClientePorCodigo(ByVal Codigo As Integer) As Cliente
        Dim oComm As New SqlCommand

        Try
            Dim ListaCliente As List(Of Cliente)
            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Nome, CPF, Sexo, DtNascimento, DtCadastro, Telefone, Telefone2, Telefone3, Email, CEP, Endereco, Bairro, Cidade, UF FROM Cliente WHERE Codigo = @Codigo ORDER BY Nome"
            oComm.Parameters.Add("@Codigo", SqlDbType.Int).Value = Codigo
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            ListaCliente = PreencherLista(oDR)

            If ListaCliente.Count = 0 Then
                ClientePorCodigo = New Cliente
            Else
                ClientePorCodigo = ListaCliente.Item(0)
            End If

            oDR.Close()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter cliente.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try
    End Function

    Public Function ClientePorNome(ByVal Nome As String) As List(Of Cliente)
        Dim oComm As New SqlCommand

        Try

            oComm.Connection = MyBase.obterConexao()
            oComm.CommandText = "SELECT Codigo, Nome, CPF, Sexo, DtNascimento, DtCadastro, Telefone, Telefone2, Telefone3, Email, CEP, Endereco, Bairro, Cidade, UF FROM Cliente WHERE Nome LIKE +@Nome +'%' "
            oComm.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = Nome
            oComm.Connection.Open()

            Dim oDR As SqlDataReader = oComm.ExecuteReader()

            ClientePorNome = PreencherLista(oDR)

            oDR.Close()
            oComm.Connection.Close()

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter clientes.", ex)
        Finally
            If oComm.Connection.State = ConnectionState.Open Then
                oComm.Connection.Close()
            End If
        End Try

    End Function

    Private Function PreencherLista(ByVal reader As SqlDataReader) As List(Of Cliente)
        Try

            Dim ListaCliente As New List(Of Cliente)

            While (reader.Read)

                Dim c As New Cliente

                c.Codigo = reader.Item("Codigo")
                c.Nome = reader.Item("Nome")
                c.CPF = reader.Item("CPF")
                c.Sexo = reader.Item("Sexo")
                c.DtNascimento = reader.Item("DtNascimento")
                c.DtCadastro = reader.Item("DtCadastro")
                c.Telefone = reader.Item("Telefone")
                c.Telefone2 = reader.Item("Telefone2")
                c.Telefone3 = reader.Item("Telefone3")
                c.Email = reader.Item("Email")
                c.CEP = reader.Item("CEP")
                c.Endereco = reader.Item("Endereco")
                c.Bairro = reader.Item("Bairro")
                c.Cidade = reader.Item("Cidade")
                c.UF = reader.Item("UF")

                ListaCliente.Add(c)

            End While

            PreencherLista = ListaCliente

        Catch ex As Exception
            Throw New ApplicationException("Não foi possível obter cliente.", ex)
        End Try
    End Function

End Class
