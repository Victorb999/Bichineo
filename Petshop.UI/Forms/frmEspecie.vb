Imports Petshop.Entities
Imports Petshop.BLL

Public Class frmEspecie

    Enum Modo
        Insercao
        Alteracao
    End Enum

    Dim ModoAtual As Modo
    Dim RegraEspecie As New EspecieBL

    Private Sub frmEspecie_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

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

        Dim Especie As New Especie
        Especie.Nome = txtNome.Text
        Especie.Obs = txtObservacao.Text

        If ModoAtual = Modo.Insercao Then

            txtCodigo.Text = RegraEspecie.InsereEspecie(Especie)
            If txtCodigo.Text > 0 Then
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Espécie incluída com sucesso!", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ModoAtual = Modo.Alteracao
            Else
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Falha ao tentar incluir a Espécie.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else

            Especie.Codigo = txtCodigo.Text
            txtCodigo.Text = RegraEspecie.AlteraEspecie(Especie)

            If txtCodigo.Text > 0 Then
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Espécie atualizada com sucesso!", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Falha ao tentar alterar a Espécie.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

        If Not IsNumeric(txtCodigo.Text) And (Len(txtCodigo.Text) >= 2) Then
            Dim pesq As New frmPesquisa("especie", txtCodigo.Text)
            Me.BackColor = Color.Gray
            pesq.ShowDialog()
            txtCodigo.Text = pesq.CodRetorno
            pesq.Dispose()
        End If

    End Sub

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave

        If txtCodigo.Text = "" Then ModoAtual = Modo.Insercao

        If IsNumeric(txtCodigo.Text) Then

            Dim Especie As Especie = RegraEspecie.EspeciePorCodigo(txtCodigo.Text)
            If Especie.Codigo = 0 Then
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Espécie não cadastrada.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Call LimparCampos()
                txtCodigo.Focus()
            Else
                txtNome.Text = Especie.Nome
                txtObservacao.Text = Especie.Obs
                ModoAtual = Modo.Alteracao
            End If

        End If

    End Sub

    Private Sub txtCodigo_LostFocus(sender As Object, e As EventArgs) Handles txtCodigo.LostFocus
        'If txtCodigo.Text = "" Then Exit Sub
        'If IsNumeric(txtCodigo.Text) Then
        '    Dim NovaEspecie As New Entities.Especie
        '    NovaEspecie = RegraEspecie.EspeciePorCodigo(txtCodigo.Text)
        '    If NovaEspecie.Codigo = 0 Then
        '        Call LimparCampos()
        '        MetroFramework.MetroMessageBox.Show(Me, "Espécie não encontrada.")
        '    Else
        '        txtCodigo.Text = NovaEspecie.Codigo
        '        txtNome.Text = NovaEspecie.Nome
        '        txtObservacao.Text = NovaEspecie.Obs
        '        ModoAtual = Modo.Alteracao
        '    End If
        'End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If ModoAtual = Modo.Insercao Then Exit Sub
        If txtCodigo.Text = "" Then Exit Sub
        If Not IsNumeric(txtCodigo.Text) Then Exit Sub

        If MetroFramework.MetroMessageBox.Show(frmPrincipal, "Confirma exclusão desta Espécie?", frmPrincipal.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
            Exit Sub
        End If

        Dim RegraRaca As New RacaBL
        Dim ListaRaca As List(Of Raca)
        ListaRaca = RegraRaca.RacaPorEspecie(txtCodigo.Text)

        If ListaRaca.Count > 0 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Impossível excluir uma Espécie com Raças cadastradas.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        txtCodigo.Text = RegraEspecie.ExcluiEspecie(txtCodigo.Text)
        If txtCodigo.Text > 0 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Espécie excluída com sucesso!", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call LimparCampos()
        End If

    End Sub

    Private Sub LimparCampos()

        txtCodigo.Clear()
        txtCodigo.Focus()
        txtNome.Clear()
        txtObservacao.Clear()
        ModoAtual = Modo.Insercao

    End Sub

    Private Function Validar() As Boolean

        If Len(txtNome.Text) <= 1 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Informe um nome válido para a Espécie.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNome.Focus()
            Return False
        End If

        Return True

    End Function

End Class
