Imports Petshop.BLL
Imports Petshop.Entities

Public Class frmCliente

    Enum Modo
        Insercao
        Alteracao
    End Enum

    Dim ModoAtual As Modo
    Dim RegraCliente As New ClienteBL

    Private Sub btsalvar_Click(sender As Object, e As EventArgs) Handles btsalvar.Click

        If Not Validar() Then
            Exit Sub
        End If

        Dim Cliente As New Cliente
        Cliente.Nome = txtNome.Text
        Cliente.CPF = txtCPF.Text
        Cliente.Sexo = IIf(cboSexo.SelectedItem = "Masculino", "M", "F")
        Cliente.DtCadastro = Date.Now
        Cliente.DtNascimento = mdtDtNascimento.Value
        Cliente.Telefone = txtTelefone.Text
        Cliente.Telefone2 = txtTelefone2.Text
        Cliente.Telefone3 = txtTelefone3.Text
        Cliente.Email = txtEmail.Text
        Cliente.CEP = txtCEP.Text
        Cliente.Endereco = TxtEndereco.Text
        Cliente.Bairro = txtBairro.Text
        Cliente.Cidade = txtCidade.Text
        Cliente.UF = txtUF.Text

        If ModoAtual = Modo.Insercao Then

            txtCodigo.Text = RegraCliente.InsereCliente(Cliente)
            If txtCodigo.Text > 0 Then
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Cliente incluído com sucesso!", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ModoAtual = Modo.Alteracao
            Else
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Falha ao tentar incluir o Cliente.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else

            Cliente.Codigo = txtCodigo.Text
            txtCodigo.Text = RegraCliente.AlteraCliente(Cliente)

            If txtCodigo.Text > 0 Then
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Cliente atualizado com sucesso!", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Falha ao tentar alterar o Cliente.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub

    Private Sub Cliente_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

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

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

        If Not IsNumeric(txtCodigo.Text) And (Len(txtCodigo.Text) >= 2) Then
            Dim pesq As New frmPesquisa("cliente", txtCodigo.Text)
            Me.BackColor = Color.Gray
            pesq.ShowDialog()
            txtCodigo.Text = pesq.CodRetorno
            pesq.Dispose()
        End If

    End Sub

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave

        If txtCodigo.Text = "" Then ModoAtual = Modo.Insercao

        If IsNumeric(txtCodigo.Text) Then

            Dim Cliente As Cliente = RegraCliente.ClientePorCodigo(txtCodigo.Text)
            If Cliente.Codigo = 0 Then
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Cliente não cadastrado.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Call LimparCampos()
                txtCodigo.Focus()
            Else
                txtNome.Text = Cliente.Nome
                txtCPF.Text = Cliente.CPF
                mdtDtNascimento.Value = Cliente.DtNascimento
                cboSexo.SelectedItem = IIf(Cliente.Sexo = "M", "Masculino", "Feminino")
                txtTelefone.Text = Cliente.Telefone
                txtTelefone2.Text = Cliente.Telefone2
                txtTelefone3.Text = Cliente.Telefone3
                txtEmail.Text = Cliente.Email
                txtCEP.Text = Cliente.CEP
                TxtEndereco.Text = Cliente.Endereco
                txtCidade.Text = Cliente.Cidade
                txtBairro.Text = Cliente.Bairro
                txtUF.Text = Cliente.UF
                Preenchegrid(Cliente.Codigo)
            End If
        End If

    End Sub

    Private Function Validar() As Boolean

        If Len(txtNome.Text) <= 1 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Informe um nome válido para o Cliente.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNome.Focus()
            Return False
        End If

        'If Len(txtCPF.Text) < 11 Then
        '    MetroFramework.MetroMessageBox.Show(frmPrincipal, "Informe um CPF válido.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtCPF.Focus()
        '    Return False
        'End If

        If cboSexo.SelectedIndex = -1 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Selecione o sexo.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboSexo.Focus()
            Return False
        End If

        If Len(TxtEndereco.Text) <= 1 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Informe um Endereço.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtEndereco.Focus()
            Return False
        End If

        If Len(txtCidade.Text) <= 1 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Informe a Cidade.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCidade.Focus()
            Return False
        End If

        If Len(txtUF.Text) < 2 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Informe a UF.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUF.Focus()
            Return False
        End If

        Return True

    End Function

    Private Sub LimparCampos()

        txtCodigo.Clear()
        txtCodigo.Focus()
        txtNome.Clear()
        txtCPF.Clear()
        cboSexo.SelectedIndex = -1
        mdtDtNascimento.Text = ""
        'mdtDtCadastro.Text = ""
        txtTelefone.Clear()
        txtTelefone2.Clear()
        txtTelefone3.Clear()
        txtEmail.Clear()
        txtCEP.Clear()
        TxtEndereco.Clear()
        txtBairro.Clear()
        txtCidade.Clear()
        txtUF.Clear()

        dgvAnimal.Rows.Clear()

        ModoAtual = Modo.Insercao

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If ModoAtual = Modo.Insercao Then Exit Sub
        If txtCodigo.Text = "" Then Exit Sub
        If Not IsNumeric(txtCodigo.Text) Then Exit Sub

        If MetroFramework.MetroMessageBox.Show(frmPrincipal, "Confirma exclusão deste Cliente?", frmPrincipal.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
            Exit Sub
        End If

        Dim RegraAnimal As New AnimalBL
        Dim ListaAnimal As List(Of Animal)
        ListaAnimal = RegraAnimal.AnimalPorCliente(txtCodigo.Text)

        If ListaAnimal.Count > 0 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Impossível excluir um Cliente com animais cadastrados.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Dim RegraVenda As New VendaBL
        'Dim ListaVenda As List(Of Venda)
        'ListaVenda = RegraVenda.VendaPorCliente(txtCodigo.Text)

        'If ListaVenda.Count > 0 Then
        '    MetroFramework.MetroMessageBox.Show(frmPrincipal, "Impossível excluir um Cliente com vendas registradas.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If

        txtCodigo.Text = RegraCliente.ExcluiCliente(txtCodigo.Text)
        If txtCodigo.Text > 0 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Cliente excluído com sucesso!", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call LimparCampos()
        End If

    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click

        If Val(txtCodigo.Text) > 0 Then

            Dim pet As New frmAnimal(txtCodigo.Text)
            pet.ShowDialog()
            pet.Dispose()
            Preenchegrid(txtCodigo.Text)
        Else
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Selecione o cliente antes de adicionar um Pet.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Preenchegrid(codigocliente)

        'Dim cli As New Entities.Cliente

        Dim ListaAnimal As New List(Of Entities.Animal)
        Dim regraAnimal As New AnimalBL

        Dim Raca As New Entities.Raca
        Dim regraRaca As New RacaBL

        ListaAnimal = regraAnimal.AnimalPorCliente(codigocliente)

        If ListaAnimal.Count = 0 Then
            dgvAnimal.Visible = False
            ' lblGrid.Text = "Nenhum horário agendado."
            Exit Sub
        End If

        With dgvAnimal
            'limpa o form
            .Rows.Clear()
            .Visible = True
            'lblGrid.Text = ""
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            'preenche grid
            For i As Integer = 0 To ListaAnimal.Count - 1

                .Rows.Add()

                Raca = regraRaca.RacaPorCodigo(ListaAnimal(i).Raca)
                .Rows(i).Cells("Codigo").Value = ListaAnimal(i).Codigo
                .Rows(i).Cells("Animal").Value = ListaAnimal(i).Nome
                .Rows(i).Cells("Obs").Value = ListaAnimal(i).Obs
                .Rows(i).Cells("Raca").Value = Raca.Nome

                .Columns(3).DefaultCellStyle.WrapMode = DataGridViewTriState.True

            Next

        End With

    End Sub

    Private Sub dgvAnimal_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvAnimal.CellMouseDoubleClick
        Dim pet As New frmAnimal(dgvAnimal.CurrentRow.Cells("Codigo").Value, dgvAnimal.CurrentRow.Cells("Animal").Value)
        pet.ShowDialog()
        pet.Dispose()
        Preenchegrid(txtCodigo.Text)
    End Sub
End Class