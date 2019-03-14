Imports Petshop.BLL
Imports Petshop.Entities

Public Class frmRaca

    Enum Modo
        Insercao
        Alteracao
    End Enum

    Dim ModoAtual As Modo
    Dim RegraRaca As New RacaBL

    Private Sub Raca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim EspecieRegra As New EspecieBL
        Dim ListaEspecie As List(Of Especie)
        ListaEspecie = EspecieRegra.RetornaTodos

        cboEspecie.DataSource = ListaEspecie
        cboEspecie.DisplayMember = "Nome"
        cboEspecie.ValueMember = "Codigo"
        cboEspecie.SelectedIndex = -1

    End Sub

    Private Sub btsalvar_Click(sender As Object, e As EventArgs) Handles btsalvar.Click

        If Not Validar Then
            Exit Sub
        End If

        Dim Raca As New Raca
        Raca.Nome = txtNome.Text
        Raca.Obs = txtObservacao.Text
        Raca.Especie = cboEspecie.SelectedValue

        If ModoAtual = Modo.Insercao Then

            txtCodigo.Text = RegraRaca.insereRaca(Raca)
            If txtCodigo.Text > 0 Then
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Raça incluída com sucesso!", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ModoAtual = Modo.Alteracao
            Else
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Falha ao tentar incluir a raça.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else

            Raca.Codigo = txtCodigo.Text
            txtCodigo.Text = RegraRaca.AlteraRaca(Raca)

            If txtCodigo.Text > 0 Then
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Raça atualizada com sucesso!", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Falha ao tentar alterar a raça.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub

    Private Sub frmRaca_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call btnAddEspecie_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyCode = Keys.Escape Then
            If txtCodigo.Text = "" Then
                Me.Close()
            Else
                Call LimparCampos()
            End If
        End If

    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

        If Not IsNumeric(txtCodigo.Text) And (Len(txtCodigo.Text) >= 2) Then
            Dim pesq As New frmPesquisa("raca", txtCodigo.Text)
            Me.BackColor = Color.Gray
            pesq.ShowDialog()
            txtCodigo.Text = pesq.CodRetorno
            pesq.Dispose()
        End If

    End Sub

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave

        If txtCodigo.Text = "" Then ModoAtual = Modo.Insercao

        If IsNumeric(txtCodigo.Text) Then

            Dim Raca As Raca = RegraRaca.RacaPorCodigo(txtCodigo.Text)
            If Raca.Codigo = 0 Then
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Raça não cadastrada.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Call LimparCampos()
                txtCodigo.Focus()
            Else
                txtNome.Text = Raca.Nome
                txtObservacao.Text = Raca.Obs
                cboEspecie.SelectedValue = Raca.Especie
                ModoAtual = Modo.Alteracao
            End If

        End If

    End Sub

    Private Function Validar() As Boolean

        If Len(txtNome.Text) <= 1 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Informe um nome válido para a Raça.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNome.Focus()
            Return False
        End If

        If cboEspecie.SelectedIndex = -1 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Selecione uma Espécie.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboEspecie.Focus()
            Return False
        End If

        Return True

    End Function

    Private Sub LimparCampos()

        txtCodigo.Clear()
        txtCodigo.Focus()
        txtNome.Clear()
        txtObservacao.Clear()
        cboEspecie.SelectedIndex = -1
        ModoAtual = Modo.Insercao

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If ModoAtual = Modo.Insercao Then Exit Sub
        If txtCodigo.Text = "" Then Exit Sub
        If Not IsNumeric(txtCodigo.Text) Then Exit Sub

        If MetroFramework.MetroMessageBox.Show(frmPrincipal, "Confirma exclusão desta Raça?", frmPrincipal.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
            Exit Sub
        End If

        Dim RegraAnimal As New AnimalBL
        Dim ListaAnimal As List(Of Animal)
        ListaAnimal = RegraAnimal.AnimalPorRaca(txtCodigo.Text)

        If ListaAnimal.Count > 0 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Impossível excluir a raça com animais cadastrados.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        txtCodigo.Text = RegraRaca.ExcluiRaca(txtCodigo.Text)
        If txtCodigo.Text > 0 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Raça excluída com sucesso!", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call LimparCampos()
        End If

    End Sub

    Private Sub btnAddEspecie_Click(sender As Object, e As EventArgs) Handles btnAddEspecie.Click
        Dim frmEspecie As New frmEspecie
        frmEspecie.ShowDialog()
        frmEspecie.Dispose()
        Call Raca_Load(Nothing, Nothing)
    End Sub

End Class