Imports Petshop.Entities
Imports Petshop.BLL

Public Class frmServico

    Enum Modo
        Insercao
        Alteracao
    End Enum

    Dim ModoAtual As Modo
    Dim RegraServico As New ServicoBL

    Private Sub frmServico_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

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

    Private Sub btsalvar_Click(sender As Object, e As EventArgs) Handles btsalvar.Click

        If Not Validar() Then
            Exit Sub
        End If

        Dim Servico As New Servico
        Servico.Descricao = txtDescricao.Text
        Servico.Preco = txtPreco.Text
        Servico.Obs = txtObservacao.Text

        If ModoAtual = Modo.Insercao Then

            txtCodigo.Text = RegraServico.InsereServico(Servico)
            If txtCodigo.Text > 0 Then
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Serviço incluído com sucesso!", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ModoAtual = Modo.Alteracao
            Else
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Falha ao tentar incluir o Serviço.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else

            Servico.Codigo = txtCodigo.Text
            txtCodigo.Text = RegraServico.AlteraServico(Servico)

            If txtCodigo.Text > 0 Then
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Serviço atualizado com sucesso!", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Falha ao tentar alterar o Serviço.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

        If Not IsNumeric(txtCodigo.Text) And (Len(txtCodigo.Text) >= 2) Then
            Dim pesq As New frmPesquisa("servico", txtCodigo.Text)
            Me.BackColor = Color.Gray
            pesq.ShowDialog()
            txtCodigo.Text = pesq.CodRetorno
            pesq.Dispose()
        End If

    End Sub

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave

        If txtCodigo.Text = "" Then ModoAtual = Modo.Insercao

        If IsNumeric(txtCodigo.Text) Then

            Dim Servico As Servico = RegraServico.ServicoPorCodigo(txtCodigo.Text)
            If Servico.Codigo = 0 Then
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Serviço não cadastrado.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Call LimparCampos()
                txtCodigo.Focus()
            Else
                txtDescricao.Text = Servico.Descricao
                txtPreco.Text = Format(Servico.Preco, "0.00")
                txtObservacao.Text = Servico.Obs
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

        Dim RegraAgenda As New AgendaBL
        Dim ListaAgenda As List(Of Entities.Agenda)
        ListaAgenda = RegraAgenda.obterAgendaPorServico(txtCodigo.Text)

        If ListaAgenda.Count > 0 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Impossível excluir um Serviço com evento agendado.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        txtCodigo.Text = RegraServico.ExcluiServico(txtCodigo.Text)
        If txtCodigo.Text > 0 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Serviço excluído com sucesso!", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call LimparCampos()
        End If

    End Sub

    Private Sub LimparCampos()

        txtCodigo.Clear()
        txtCodigo.Focus()
        txtDescricao.Clear()
        txtPreco.Clear()
        txtObservacao.Clear()
        ModoAtual = Modo.Insercao

    End Sub

    Private Function Validar() As Boolean

        If Len(txtDescricao.Text) <= 1 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Informe uma Descrição válida para o Serviço.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescricao.Focus()
            Return False
        End If

        If Val(txtPreco.Text) <= 0 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Informe um Preço.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPreco.Focus()
            Return False
        End If

        Return True

    End Function

End Class
