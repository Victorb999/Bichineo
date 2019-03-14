Imports System.Data.SqlClient

Public MustInherit Class ConexaoDAO

    Protected Function obterConexao() As SqlConnection

        Dim oConn As New SqlConnection()
      oConn.ConnectionString = "Data Source=LOCALHOST;Initial Catalog=PetShop;Integrated Security=True;User Id=SA;Password=123456"

        Return oConn

    End Function

End Class
