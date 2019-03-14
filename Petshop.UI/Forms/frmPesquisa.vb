Imports Petshop.BLL
Imports Petshop.Entities

Public Class frmPesquisa

    Public CodRetorno As Integer
    Dim tpPesquisa As String

    Sub New(TipoPesquisa, Texto)

        ' This call is required by the designer.
        InitializeComponent()
        'tabela = TipoPesquisa

        tpPesquisa = TipoPesquisa
        txtPesquisa.Text = Texto
        txtPesquisa.SelectionStart = Len(txtPesquisa.Text)
        txtPesquisa.Focus()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Pesquisa_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyCode = Keys.Escape Then
            If txtPesquisa.Text = "" Then
                CodRetorno = 0
                Me.Close()
            Else
                dgvPesq.DataSource = Nothing
                txtPesquisa.Clear()
                txtPesquisa.Focus()
            End If
        End If

    End Sub

    Private Sub txtPesquisa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPesquisa.KeyDown
        If e.KeyCode = Keys.Down Then
            dgvPesq.Focus()
        ElseIf e.KeyCode = Keys.Return Then
            Call Buscar()
        End If
    End Sub

    Private Sub dgvPesq_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvPesq.KeyDown

        If e.KeyCode = Keys.Return Then
            If dgvPesq.Rows.Count > 0 Then
                CodRetorno = dgvPesq.SelectedCells.Item(0).Value
                Me.Close()
            End If

        End If

    End Sub

    Private Sub Pesquisa_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Buscar()

        Select Case tpPesquisa

            Case "cliente"

                'Dim ListaCliente As List(Of Entities.Cliente)
                'Dim RegraCliente As New BLL.ClienteBL
                ' ListaCliente = RegraCliente.ClientePorNome(txtPesquisa.Text)
                'dgvPesq.DataSource = ListaCliente
                gridCliente()

            Case "raca"
                'Dim ListaRaca As List(Of Raca)
                'Dim RegraRaca As New RacaBL
                'ListaRaca = RegraRaca.RacaPorNome(txtPesquisa.Text)
                'dgvPesq.DataSource = ListaRaca
                gridRaca()

            Case "servico"
                'Dim ListaServico As List(Of Servico)
                'Dim RegraServico As New ServicoBL
                'ListaServico = RegraServico.ServicoPorDescricao(txtPesquisa.Text)
                'dgvPesq.DataSource = ListaServico
                gridServico()

            Case "animal"
                'Dim ListaAnimal As List(Of Animal)
                'Dim RegraAnimal As New AnimalBL
                'ListaAnimal = RegraAnimal.AnimalPorNome(txtPesquisa.Text)
                'dgvPesq.DataSource = ListaAnimal
                gridAnimal()

            Case "especie"
                Dim ListaEspecie As List(Of Especie)
                Dim RegraEspecie As New EspecieBL
                ListaEspecie = RegraEspecie.EspeciePorNome(txtPesquisa.Text)
                dgvPesq.DataSource = ListaEspecie
            Case "produto"
                gridProduto()
        End Select

    End Sub


    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Call Buscar()
    End Sub

    Private Sub gridAnimal()

        'Dim cli As New Entities.Cliente

        Dim ListaAnimal As New List(Of Entities.Animal)
        Dim regraAnimal As New AnimalBL

        Dim Raca As New Entities.Raca
        Dim regraRaca As New RacaBL

        Dim Cliente As New Entities.Cliente
        Dim regraCliente As New ClienteBL

        ListaAnimal = regraAnimal.AnimalPorNome(txtPesquisa.Text)

        If ListaAnimal.Count = 0 Then
            dgvPesq.Visible = False
            lblGrid.Text = "Nenhum animal encontrado."
            Exit Sub
        End If

        With dgvPesq
            'limpa o form
            .Rows.Clear()
            .Visible = True
            lblGrid.Text = ""

            'preenche grid
            For i As Integer = 0 To ListaAnimal.Count - 1

                .ColumnCount = 4

                .Columns(0).Name = "Codigo"
                .Columns(1).Name = "Animal"
                .Columns(2).Name = "Cliente"
                .Columns(3).Name = "Raca"

                .Rows.Add()

                Raca = regraRaca.RacaPorCodigo(ListaAnimal(i).Raca)
                Cliente = regraCliente.ClientePorCodigo(ListaAnimal(i).Cliente)
                .Rows(i).Cells("Codigo").Value = ListaAnimal(i).Codigo
                .Rows(i).Cells("Animal").Value = ListaAnimal(i).Nome
                .Rows(i).Cells("Cliente").Value = Cliente.Nome
                .Rows(i).Cells("Raca").Value = Raca.Nome

                .AutoResizeColumns()

            Next

        End With

    End Sub

    Private Sub gridCliente()
        'Dim cli As New Entities.Cliente

        Dim ListaCliente As New List(Of Entities.Cliente)
        Dim regraCliente As New ClienteBL


        ListaCliente = regraCliente.ClientePorNome(txtPesquisa.Text)

        If ListaCliente.Count = 0 Then
            dgvPesq.Visible = False
            lblGrid.Text = "Nenhum Cliente encontrado."
            Exit Sub
        End If

        With dgvPesq
            'limpa o form
            .Rows.Clear()
            .Visible = True
            lblGrid.Text = ""

            'preenche grid
            For i As Integer = 0 To ListaCliente.Count - 1

                .ColumnCount = 5

                .Columns(0).Name = "Codigo"
                .Columns(1).Name = "Cliente"
                .Columns(2).Name = "CPF"
                .Columns(3).Name = "Telefone"
                .Columns(4).Name = "Endereco"

                .Rows.Add()

                .Rows(i).Cells("Codigo").Value = ListaCliente(i).Codigo
                .Rows(i).Cells("Cliente").Value = ListaCliente(i).Nome
                .Rows(i).Cells("CPF").Value = ListaCliente(i).CPF
                .Rows(i).Cells("Telefone").Value = ListaCliente(i).Telefone
                .Rows(i).Cells("Endereco").Value = ListaCliente(i).Endereco

                .AutoResizeColumns()

            Next

        End With

    End Sub

    Private Sub gridServico()
        Dim ListaServico As List(Of Servico)
        Dim RegraServico As New ServicoBL
        ListaServico = RegraServico.ServicoPorDescricao(txtPesquisa.Text)

        With dgvPesq
            .DataSource = ListaServico

            .Columns("Preco").DefaultCellStyle.Format = "C"
            .AutoResizeColumns()
        End With

    End Sub

    Private Sub gridRaca()

        Dim ListaRaca As New List(Of Entities.Raca)
        Dim regraRaca As New RacaBL

        Dim Especie As New Entities.Especie
        Dim regraEspecie As New EspecieBL

        ListaRaca = regraRaca.RacaPorNome(txtPesquisa.Text)

        If ListaRaca.Count = 0 Then
            dgvPesq.Visible = False
            lblGrid.Text = "Nenhum Raca encontrado."
            Exit Sub
        End If

        With dgvPesq
            'limpa o form
            .Rows.Clear()
            .Visible = True
            lblGrid.Text = ""

            'preenche grid
            For i As Integer = 0 To ListaRaca.Count - 1

                .ColumnCount = 3

                .Columns(0).Name = "Codigo"
                .Columns(1).Name = "Raca"
                .Columns(2).Name = "Especie"

                .Rows.Add()

                Especie = regraEspecie.EspeciePorCodigo(ListaRaca(i).Especie)
                .Rows(i).Cells("Codigo").Value = ListaRaca(i).Codigo
                .Rows(i).Cells("Raca").Value = ListaRaca(i).Nome
                .Rows(i).Cells("Especie").Value = Especie.Nome

                .AutoResizeColumns()

            Next

        End With
    End Sub

    Private Sub gridProduto()
        Dim ListaProduto As List(Of Produto)
        Dim RegraProduto As New ProdutoBL
        ListaProduto = RegraProduto.ProdutoPorDescricao(txtPesquisa.Text)

        With dgvPesq
            .DataSource = ListaProduto

            .Columns("PrecoVenda").DefaultCellStyle.Format = "C"
            .AutoResizeColumns()
        End With
    End Sub

End Class