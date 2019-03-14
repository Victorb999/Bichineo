Imports Petshop.Entities
Imports Petshop.BLL

Public Class frmProduto
    Enum Modo
        Insercao
        Alteracao
    End Enum

    Dim ModoAtual As Modo
    Dim RegraProduto As New ProdutoBL

    Private Sub ProdutoProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyCode = Keys.Escape Then
            If txtCodigo.Text = "" Then
                Me.Close()
            Else
                Call LimparCampos()
            End If
        End If
    End Sub

    Private Sub LimparCampos()

        txtCodigo.Clear()
        txtCodigo.Focus()
        txtCodBarras.Clear()
        txtDescricao.Clear()
        txtPrecoVenda.Clear()
        txtPrecoCusto.Clear()
        txtEstoque.Clear()
        ModoAtual = Modo.Insercao

    End Sub

    Private Function Validar() As Boolean

        If Len(txtDescricao.Text) <= 1 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Informe uma Descrição válida para o Produto.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescricao.Focus()
            Return False
        End If

        If Val(txtPrecoCusto.Text) <= 0 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Informe um Preço.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrecoCusto.Focus()
            Return False
        End If

        Return True

    End Function

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

        If Not IsNumeric(txtCodigo.Text) And (Len(txtCodigo.Text) >= 2) Then
            Dim pesq As New frmPesquisa("produto", txtCodigo.Text)
            Me.BackColor = Color.Gray
            pesq.ShowDialog()
            txtCodigo.Text = pesq.CodRetorno
            pesq.Dispose()
        End If

    End Sub


    Private Sub btsalvar_Click_1(sender As Object, e As EventArgs) Handles btsalvar.Click
        If Not Validar() Then
            Exit Sub
        End If

        Dim Produto As New Produto
        Produto.Descricao = txtDescricao.Text
        Produto.CodigoBarras = txtCodigo.Text
        Produto.PrecoVenda = txtPrecoVenda.Text
        Produto.PrecoCusto = txtPrecoCusto.Text
        Produto.Estoque = txtEstoque.Text
        Produto.Tipo = 1

        If ModoAtual = Modo.Insercao Then

            txtCodigo.Text = RegraProduto.insereProduto(Produto)
            If txtCodigo.Text > 0 Then
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Produto incluído com sucesso!", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ModoAtual = Modo.Alteracao
            Else
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Falha ao tentar incluir o Produto.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else

            Produto.Codigo = txtCodigo.Text
            txtCodigo.Text = RegraProduto.AlteraProduto(Produto)

            If txtCodigo.Text > 0 Then
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Produto atualizado com sucesso!", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Falha ao tentar alterar o Produto.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave
        If txtCodigo.Text = "" Then ModoAtual = Modo.Insercao

        If IsNumeric(txtCodigo.Text) Then

            Dim Produto As Produto = RegraProduto.ProdutoPorCodigo(txtCodigo.Text)
            If Produto.Codigo = 0 Then
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Produto não cadastrado.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Call LimparCampos()
                txtCodigo.Focus()
            Else
                txtDescricao.Text = Produto.Descricao
                txtPrecoVenda.Text = Format(Produto.PrecoVenda, "0.00")
                txtPrecoCusto.Text = Format(Produto.PrecoCusto, "0.00")
                txtCodBarras.Text = Produto.CodigoBarras
                txtEstoque.Text = Produto.Estoque

                ModoAtual = Modo.Alteracao
            End If

        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If ModoAtual = Modo.Insercao Then Exit Sub
        If txtCodigo.Text = "" Then Exit Sub
        If Not IsNumeric(txtCodigo.Text) Then Exit Sub

        If MetroFramework.MetroMessageBox.Show(frmPrincipal, "Confirma exclusão deste Serviço?", frmPrincipal.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
            Exit Sub
        End If



        txtCodigo.Text = RegraProduto.excluiProduto(txtCodigo.Text)
        If txtCodigo.Text > 0 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Serviço excluído com sucesso!", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call LimparCampos()
        End If
    End Sub
End Class