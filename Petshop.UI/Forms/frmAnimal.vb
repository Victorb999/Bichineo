Imports Petshop.Entities
Imports Petshop.BLL

Public Class frmAnimal

    Enum Modo
        Insercao
        Alteracao
    End Enum

    Dim ModoAtual As Modo
    Dim RegraAnimal As New AnimalBL
    Dim clienteselecionado As Integer = 0
    Dim flagAnimal As Integer = 0
    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub
    Sub New(cliente As Integer)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        'Dim RegraCliente As New ClienteBL
        'Dim clienteOB As Entities.Cliente = RegraCliente.ClientePorCodigo(cliente)

        'Dim ListaCliente As New List(Of Cliente)

        'ListaCliente.Add(clienteOB)
        'cboCliente.DataSource = ListaCliente
        'cboCliente.DisplayMember = "Nome"
        'cboCliente.ValueMember = "Codigo"
        'cboCliente.SelectedIndex = -1
        clienteselecionado = cliente

    End Sub

    Sub New(animal As Integer, nome As String)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        flagAnimal = animal
    End Sub

    Private Sub Animal_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim RegraEspecie As New EspecieBL
        Dim ListaEspecie As List(Of Especie) = RegraEspecie.RetornaTodos
        cboEspecie.DataSource = ListaEspecie
        cboEspecie.DisplayMember = "Nome"
        cboEspecie.ValueMember = "Codigo"
        cboEspecie.SelectedIndex = -1

        Dim RegraCliente As New ClienteBL
        Dim ListaCliente As List(Of Cliente) = RegraCliente.RetornaTodos
        cboCliente.DataSource = ListaCliente
        cboCliente.DisplayMember = "Nome"
        cboCliente.ValueMember = "Codigo"
        cboCliente.SelectedIndex = -1

        Dim RegraRaca As New RacaBL
        Dim ListaRaca As List(Of Raca) = RegraRaca.RetornaTodos
        cboRaca.DataSource = listaraca
        cboRaca.DisplayMember = "Nome"
        cboRaca.ValueMember = "Codigo"
        cboRaca.SelectedIndex = -1

        If clienteselecionado > 0 Then
            cboCliente.SelectedValue = clienteselecionado
        End If

        If flagAnimal > 0 Then
            txtCodigo.Text = flagAnimal
            txtCodigo_Leave(Nothing, Nothing)
        End If

    End Sub

    Private Sub btsalvar_Click(sender As Object, e As EventArgs) Handles btsalvar.Click

        If Not Validar Then
            Exit Sub
        End If

        Dim Animal As New Animal
        Animal.Nome = txtNome.Text
        Animal.DtNascimento = mdtDtNascimento.Value
        Animal.Sexo = IIf(cboSexo.SelectedItem = "Masculino", "M", "F")
        Animal.Obs = txtObservacao.Text
        Animal.Raca = cboRaca.SelectedValue
        Animal.Cliente = cboCliente.SelectedValue
        Animal.Racao = txtRacao.Text

        If ModoAtual = Modo.Insercao Then
            txtCodigo.Text = RegraAnimal.InsereAnimal(Animal)
            If txtCodigo.Text > 0 Then
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Animal incluído com sucesso!", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ModoAtual = Modo.Alteracao
            Else
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Falha ao tentar incluir o animal.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else

            Animal.Codigo = txtCodigo.Text
            txtCodigo.Text = RegraAnimal.AlteraAnimal(Animal)

            If txtCodigo.Text > 0 Then
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Animal atualizado com sucesso!", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Falha ao tentar alterar o animal.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

        If Not IsNumeric(txtCodigo.Text) And (Len(txtCodigo.Text) >= 2) Then
            Dim pesq As New frmPesquisa("animal", txtCodigo.Text)
            Me.BackColor = Color.Gray
            pesq.ShowDialog()
            txtCodigo.Text = pesq.CodRetorno
            pesq.Dispose()
        End If

    End Sub

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave

        If txtCodigo.Text = "" Then ModoAtual = Modo.Insercao

        If IsNumeric(txtCodigo.Text) Then

            Dim Animal As Animal = RegraAnimal.AnimalPorCodigo(txtCodigo.Text)
            If Animal.Codigo = 0 Then
                MetroFramework.MetroMessageBox.Show(frmPrincipal, "Animal não cadastrado.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Call LimparCampos()
                txtCodigo.Focus()
            Else
                txtNome.Text = Animal.Nome
                mdtDtNascimento.Value = Animal.DtNascimento
                cboSexo.SelectedItem = IIf(Animal.Sexo = "M", "Masculino", "Feminino")
                txtObservacao.Text = Animal.Obs

                Dim RegraRaca As New RacaBL
                cboEspecie.SelectedValue = RegraRaca.RacaPorCodigo(Animal.Raca).Especie
                cboRaca.SelectedValue = Animal.Raca

                Dim RegraCliente As New ClienteBL
                cboCliente.SelectedValue = RegraCliente.ClientePorCodigo(Animal.Cliente).Codigo

                txtRacao.Text = Animal.Racao
                ModoAtual = Modo.Alteracao
            End If

        End If

    End Sub

    Private Function Validar() As Boolean

        If Len(txtNome.Text) <= 1 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Informe um nome válido para o Animal.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNome.Focus()
            Return False
        End If

        If cboCliente.SelectedIndex = -1 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Selecione um cliente.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboCliente.Focus()
            Return False
        End If

        If cboSexo.SelectedIndex = -1 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Selecione o sexo.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboSexo.Focus()
            Return False
        End If

        If cboEspecie.SelectedIndex = -1 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Selecione uma Espécie.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboEspecie.Focus()
            Return False
        End If

        If cboRaca.SelectedIndex = -1 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Selecione uma Raça.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboRaca.Focus()
            Return False
        End If

        If txtRacao.Text = "" Then
            txtRacao.Text = " "
        End If

        Return True

    End Function

    Private Sub cboEspecie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEspecie.SelectedIndexChanged

        If cboEspecie.SelectedIndex > 0 Then

            Dim RacaRegra As New RacaBL
            Dim ListaRaca As List(Of Raca)
            ListaRaca = RacaRegra.RacaPorEspecie(cboEspecie.SelectedValue)
            cboRaca.DataSource = ListaRaca
            cboRaca.DisplayMember = "Nome"
            cboRaca.ValueMember = "Codigo"
            cboRaca.SelectedIndex = -1

        End If
    End Sub

    Private Sub btnAddEspecie_Click(sender As Object, e As EventArgs) Handles btnAddEspecie.Click

        Dim frmEspecie As New frmEspecie
        frmEspecie.ShowDialog()
        frmEspecie.Dispose()

    End Sub

    Private Sub btnAddRaca_Click(sender As Object, e As EventArgs) Handles btnAddRaca.Click

        Dim frmRaca As New frmRaca
        frmRaca.ShowDialog()
        frmRaca.Dispose()

    End Sub

    Private Sub btnProcurar_Click(sender As Object, e As EventArgs) Handles btnProcurar.Click

        Dim frmPesquisa As New frmPesquisa("cliente", "")
        frmPesquisa.ShowDialog()
        frmPesquisa.Dispose()
        If frmPesquisa.CodRetorno <> 0 Then
            cboCliente.SelectedValue = frmPesquisa.CodRetorno
        End If
        frmPesquisa.Dispose()

    End Sub

    Private Sub frmAnimal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call btnAddEspecie_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            Call btnAddRaca_Click(Nothing, Nothing)
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

    Private Sub LimparCampos()

        txtCodigo.Clear()
        txtCodigo.Focus()
        txtNome.Clear()
        txtObservacao.Clear()
        cboCliente.SelectedIndex = -1
        cboEspecie.SelectedIndex = -1
        cboRaca.SelectedIndex = -1
        txtRacao.Clear()
        ModoAtual = Modo.Insercao

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If ModoAtual = Modo.Insercao Then Exit Sub
        If txtCodigo.Text = "" Then Exit Sub
        If Not IsNumeric(txtCodigo.Text) Then Exit Sub

        If MetroFramework.MetroMessageBox.Show(frmPrincipal, "Confirma exclusão deste Animal?", frmPrincipal.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
            Exit Sub
        End If

        Dim RegraAgenda As New AgendaBL
        Dim ListaAgenda As List(Of Entities.Agenda)
        ListaAgenda = RegraAgenda.obterAgendaPorAnimal(txtCodigo.Text)

        If ListaAgenda.Count > 0 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Impossível excluir animal com evento Agendado.", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        txtCodigo.Text = RegraAnimal.ExcluiAnimal(txtCodigo.Text)
        If txtCodigo.Text > 0 Then
            MetroFramework.MetroMessageBox.Show(frmPrincipal, "Animal excluído com sucesso!", frmPrincipal.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call LimparCampos()
        End If

    End Sub

End Class