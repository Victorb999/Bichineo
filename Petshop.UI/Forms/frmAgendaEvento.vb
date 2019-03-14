Imports Petshop.BLL
Imports Petshop.Entities

Public Class frmAgendaEvento
   Dim RegraServico As New ServicoBL
   Dim RegraAnimal As New AnimalBL
   Dim RegraAgenda As New AgendaBL
   Dim CodAnimal As Integer = 0
   Dim CodServico As Integer = 0

   Enum Modo
      Insercao
      Alteracao
   End Enum

   Dim ModoAtual As Modo
   Sub New(data)

      ' Esta chamada é requerida pelo designer.
      InitializeComponent()

      ' Adicione qualquer inicialização após a chamada InitializeComponent().
      dtData.Value = data
      Me.Text = FormatDateTime(data, DateFormat.LongDate)
   End Sub

   Private Sub AgendaEvento_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
      If e.KeyCode = Keys.Return Then
         SendKeys.Send("{TAB}")
      ElseIf e.KeyCode = Keys.Escape Then
         If txtCodigo.Text = "" Then
            Me.Close()
         Else
            ModoAtual = Modo.Insercao
            Call LimpaCampos()
         End If
      End If
   End Sub

   Private Sub txtServico_TextChanged(sender As Object, e As EventArgs) Handles txtServico.TextChanged
      If Not IsNumeric(txtServico.Text) And (Len(txtServico.Text) >= 2) Then
         Dim pesq As New frmPesquisa("servico", txtServico.Text)
         Me.BackColor = Color.Gray
         pesq.ShowDialog()
         txtServico.Text = pesq.CodRetorno
         pesq.Dispose()
         CodServico = txtServico.Text

         ' Dim servico As Servico = RegraServico.obterServicoPorCodigo(txtServico.Text)(0)
         'txtServico.Text = servico.Descricao

         'Call txtServico_Leave(Nothing, Nothing)

      End If
   End Sub

   Private Sub txtServico_Leave(sender As Object, e As EventArgs) Handles txtServico.Leave

      If txtServico.Text = "0" Then
         Exit Sub
      End If

      If IsNumeric(txtServico.Text) Then
         Dim servico As Servico = RegraServico.ServicoPorCodigo(txtServico.Text)

         txtServicodesc.Text = servico.Descricao

      End If


   End Sub

   Private Sub txtAnimal_TextChanged(sender As Object, e As EventArgs) Handles txtAnimal.TextChanged
      If Not IsNumeric(txtAnimal.Text) And (Len(txtAnimal.Text) >= 2) Then
         Dim pesq As New frmPesquisa("animal", txtAnimal.Text)
         Me.BackColor = Color.Gray
         pesq.ShowDialog()
         txtAnimal.Text = pesq.CodRetorno
         pesq.Dispose()
         CodAnimal = txtAnimal.Text

         'Dim animal As Animal = RegraAnimal.obterAnimalPorCodigo(txtAnimal.Text)(0)
         ' txtAnimal.Text = animal.Nome

         Call txtAnimal_Leave(Nothing, Nothing)

      End If
   End Sub

   Private Sub txtAnimal_Leave(sender As Object, e As EventArgs) Handles txtAnimal.Leave

      If txtAnimal.Text = "0" Then
         Exit Sub
      End If

      If IsNumeric(txtAnimal.Text) Then

         Dim animal As Animal = RegraAnimal.AnimalPorCodigo(txtAnimal.Text)
         txtAnimalNome.Text = animal.Nome

      End If


   End Sub

   Private Sub btsalvar_Click(sender As Object, e As EventArgs) Handles btsalvar.Click
      Dim Agenda As New Entities.Agenda

      'validacao
      If Val(txtAnimal.Text) = 0 Then
         MetroFramework.MetroMessageBox.Show(Me, "Selecione um animal.", "Bichíneo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
         Exit Sub
      End If
      If Val(txtServico.Text) = 0 Then
         MetroFramework.MetroMessageBox.Show(Me, "Selecione um servico.", "Bichíneo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
         Exit Sub
      End If
      If Not IsDate(Now.ToShortDateString & " " & txtHorarioInicio.Text) Or Not IsDate(Now.ToShortDateString & " " & txtHorarioFim.Text) Then
         MetroFramework.MetroMessageBox.Show(Me, "Selecione um horário válido.", "Bichíneo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
         Exit Sub
      End If


      'Agenda.Codigo = txtCodigo.Text
      Agenda.Animal = txtAnimal.Text
      Agenda.Servico = txtServico.Text
      Agenda.HorarioInicio = Now.ToShortDateString & " " & txtHorarioInicio.Text
      Agenda.HorarioFim = Now.ToShortDateString & " " & txtHorariofim.Text
      Agenda.Data = dtData.Value
      Agenda.Obs = txtObservacao.Text

      If ModoAtual = Modo.Insercao Then

         txtCodigo.Text = RegraAgenda.insereAgenda(Agenda)
         If txtCodigo.Text > 0 Then
            MsgBox("Evento incluído com sucesso!")
         Else
            MsgBox("Falhou")
         End If

      Else
         Dim listAgenda As New List(Of Entities.Agenda)
         listAgenda.Add(Agenda)
         RegraAgenda.updateAgenda(listAgenda)
      End If

      Preenchegrid()
      LimpaCampos()
   End Sub

   Private Sub AgendaEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Preenchegrid()
   End Sub

   Private Sub Preenchegrid()

      Dim ListaAgenda As List(Of Entities.Agenda)
      Dim animal As New Animal
      Dim servico As New Servico
      ListaAgenda = RegraAgenda.obterAgendaPorData(dtData.Value)

      If ListaAgenda.Count = 0 Then
         dgvAgenda.Visible = False
         lblGrid.Text = "Nenhum horário agendado."
         Exit Sub
      End If

      With dgvAgenda
         'limpa o form
         .Rows.Clear()
         .Visible = True
         lblGrid.Text = ""

         '.Columns.Item("Codigo").Width = .Width * 0.1
         '.Columns.Item("Data").Width = .Width * 0.2
         '.Columns.Item("Animal").Width = .Width * 0.1
         '.Columns.Item("Servico").Width = .Width * 0.1
         '.Columns.Item("HorarioInicio").Width = .Width * 0.2
         '.Columns.Item("HorarioFim").Width = .Width * 0.2
         '.Columns.Item("Status").Width = .Width * 0.1


         For i As Integer = 0 To ListaAgenda.Count - 1

            .Rows.Add()
            animal = RegraAnimal.AnimalPorCodigo(ListaAgenda(i).Animal)
            servico = RegraServico.ServicoPorCodigo(ListaAgenda(i).Servico)

            .Rows(i).Cells("Codigo").Value = ListaAgenda(i).Codigo
            .Rows(i).Cells("HorarioInicio").Value = FormatDateTime(ListaAgenda(i).HorarioInicio, DateFormat.ShortTime)
            .Rows(i).Cells("HorarioFim").Value = FormatDateTime(ListaAgenda(i).HorarioFim, DateFormat.ShortTime)
            .Rows(i).Cells("Data").Value = FormatDateTime(ListaAgenda(i).Data, DateFormat.ShortDate)
            '.Rows(i).Cells("Status").Value = IIf(ListaAgenda(i).Status = 0, "Pendente", "Atendido")
            .Rows(i).Cells("Animal").Value = animal.Nome
            .Rows(i).Cells("Servico").Value = servico.Descricao
            .Rows(i).Cells("Obs").Value = ListaAgenda(i).Obs

            .Rows(i).Cells("CodigoAnimal").Value = ListaAgenda(i).Animal
            .Rows(i).Cells("CodigoServico").Value = ListaAgenda(i).Servico

            '.Rows(i).DefaultCellStyle.BackColor = IIf(ListaAgenda(i).Status = 0, Color.White, Color.LightBlue)


            If ListaAgenda(i).Status = 0 Then 'marcado
               .Rows(i).Cells("Status").Value = "Pendente"
            ElseIf ListaAgenda(i).Status = 2 Then 'chegou
               .Rows(i).Cells("Status").Value = "Atendimento"
               .Rows(i).DefaultCellStyle.BackColor = Color.Yellow
            Else 'finalizou
               .Rows(i).Cells("Status").Value = "Atendido"
               .Rows(i).DefaultCellStyle.BackColor = Color.LightBlue
            End If
         Next


      End With

   End Sub

   Private Sub dgvAgenda_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAgenda.CellClick
      With dgvAgenda.CurrentRow
         txtCodigo.Text = .Cells("Codigo").Value
         txtHorariofim.Text = .Cells("HorarioFim").Value
         txtHorarioInicio.Text = .Cells("HorarioInicio").Value
         txtAnimalNome.Text = .Cells("Animal").Value
         txtServicodesc.Text = .Cells("Servico").Value
         dtData.Value = .Cells("Data").Value
         txtObservacao.Text = .Cells("Obs").Value

         txtAnimal.Text = .Cells("CodigoAnimal").Value
         txtServico.Text = .Cells("CodigoServico").Value
      End With

      ModoAtual = Modo.Alteracao
      btsalvar.Focus()
   End Sub

   Private Sub BtNovo_Click(sender As Object, e As EventArgs) Handles BtNovo.Click
      ModoAtual = Modo.Insercao
      LimpaCampos()
   End Sub

   Sub LimpaCampos()
      txtCodigo.Clear()
      txtHorarioFim.Clear()
      txtHorarioInicio.Clear()
      txtAnimalNome.Clear()
      txtServicodesc.Clear()
      dtData.Value = Me.Text
      txtObservacao.Clear()
      txtAnimal.Clear()
      txtServico.Clear()
   End Sub

   Private Sub BtConfirmar_Click(sender As Object, e As EventArgs) Handles BtConfirmar.Click

      'validacao
      If txtCodigo.Text = "" Then
         MetroFramework.MetroMessageBox.Show(Me, "Selecione um evento primeiro", "Bichíneo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
         Exit Sub
      End If

      Dim Agenda As New Entities.Agenda
      Agenda.Codigo = txtCodigo.Text
      Agenda.Status = 1

      Dim listAgenda As New List(Of Entities.Agenda)
      listAgenda.Add(Agenda)
      RegraAgenda.updateAgendaStatus(listAgenda)

      Preenchegrid()
      LimpaCampos()
   End Sub

   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      'validacao
      If txtCodigo.Text = "" Then
         MetroFramework.MetroMessageBox.Show(Me, "Selecione um evento primeiro", "Bichíneo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
         Exit Sub
      End If

      Dim Agenda As New Entities.Agenda
      Agenda.Codigo = txtCodigo.Text
      Agenda.Status = 2

      Dim listAgenda As New List(Of Entities.Agenda)
      listAgenda.Add(Agenda)
      RegraAgenda.updateAgendaStatus(listAgenda)

      Preenchegrid()
      LimpaCampos()
   End Sub

   Private Sub dtData_ValueChanged(sender As Object, e As EventArgs) Handles dtData.ValueChanged
      Call Preenchegrid()
      Me.Text = FormatDateTime(dtData.Value, DateFormat.LongDate)
      Me.Refresh()
   End Sub
End Class