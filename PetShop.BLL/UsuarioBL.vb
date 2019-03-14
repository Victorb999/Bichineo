Imports PetShop.DAL
Imports PetShop.Entities

Public Class UsuarioBL

    Public Function obterTodosUsuarios() As List(Of Usuario)

        Dim c As New UsuarioDAO
        Return c.RetornaTodos()

    End Function

    Public Function obterUsuarioPorCodigo(ByVal Codigo As Integer) As List(Of Usuario)

        Dim c As New UsuarioDAO
        Return c.usuarioporCodigo(Codigo)

    End Function

    Public Sub updateUsuario(ByVal listaUsuario As List(Of Usuario))

        Dim c As New UsuarioDAO
        c.updateUsuario(listaUsuario)

    End Sub

    Public Sub excluiUsuario(ByVal listaUsuario As List(Of Usuario))

        Dim c As New UsuarioDAO
        c.excluiUsuario(listaUsuario)

    End Sub

    Public Sub excluiUsuario(ByVal Codigo As Integer)

        Dim c As New UsuarioDAO
        c.excluiUsuario(Codigo)

    End Sub

    Public Sub insereUsuario(ByVal listaUsuario As List(Of Usuario))

        Dim c As New UsuarioDAO
        c.insereUsuario(listaUsuario)

    End Sub

    Public Sub insereUsuario(ByVal oUsuario As Usuario)

        Dim c As New UsuarioDAO
        c.insereUsuario(oUsuario)

    End Sub

End Class
