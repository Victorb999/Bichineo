Imports System.Globalization

Public Class Agenda

    'cria um enum com os nomes dos dias da semana em portugues
    Enum diasemana
        Domingo = 0
        Segunda = 1
        Terça = 2
        Quarta = 3
        Quinta = 4
        Sexta = 5
        Sábado = 6
    End Enum


    Private Sub Agenda_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.D1 Then
            'MtAgenda_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.D2 Then
            'MtAgenda_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.D3 Then
            'MtCliente_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.D4 Then
            'MtPet_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.D5 Then
            'MtProduto_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.D6 Then
            'MtAgenda_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Right Then
            mtVoltar_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Left Then
            mtAvancar_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub Agenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreencheAgenda(Now)
    End Sub

    Private Sub mtVoltar_Click(sender As Object, e As EventArgs) Handles mtVoltar.Click
        'tira um dia da contagem atual
        PreencheAgenda(CDate(mtDia1.Text).AddDays(-1))
    End Sub

    Private Sub mtAvancar_Click(sender As Object, e As EventArgs) Handles mtAvancar.Click
        'adiciona um dia da contagem atual
        PreencheAgenda(CDate(mtDia1.Text).AddDays(1))
    End Sub


    Private Sub dtselecionarDia_ValueChanged(sender As Object, e As EventArgs) Handles dtselecionarDia.ValueChanged
        'seleciona a agenda de acordo com dia selecionado
        PreencheAgenda(CDate(dtselecionarDia.Text))
    End Sub

    Sub PreencheAgenda(Dia As DateTime)

        Dim labeldia() As MetroFramework.Controls.MetroLabel = {lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7}
        Dim dias() As MetroFramework.Controls.MetroTile = {mtDia1, mtDia2, mtDia3, mtDia4, mtDia5, mtDia6, mtDia7}

        For i As Integer = 0 To 6
            Dim diasemana As diasemana

            diasemana = Dia.DayOfWeek
            labeldia(i).Text = diasemana.ToString 'label recebe dia da semana
            dias(i).Text = Dia.Day & "/" & Dia.Month & "/" & Dia.Year 'tile recebe a data
            Dia = Dia.AddDays(1) 'adiciona um dia

        Next


    End Sub

    Private Sub mtDia1_Click(sender As Object, e As EventArgs) Handles mtDia1.Click
      Dim AgendaEv As New frmAgendaEvento(mtDia1.Text)
      AgendaEv.ShowDialog()
   End Sub

   Private Sub mtDia2_Click(sender As Object, e As EventArgs) Handles mtDia2.Click
      Dim AgendaEv As New frmAgendaEvento(mtDia2.Text)
      AgendaEv.ShowDialog()
   End Sub

   Private Sub mtDia3_Click(sender As Object, e As EventArgs) Handles mtDia3.Click
      Dim AgendaEv As New frmAgendaEvento(mtDia3.Text)
      AgendaEv.ShowDialog()
   End Sub

   Private Sub mtDia4_Click(sender As Object, e As EventArgs) Handles mtDia4.Click
      Dim AgendaEv As New frmAgendaEvento(mtDia4.Text)
      AgendaEv.ShowDialog()
   End Sub

   Private Sub mtDia5_Click(sender As Object, e As EventArgs) Handles mtDia5.Click
      Dim AgendaEv As New frmAgendaEvento(mtDia5.Text)
      AgendaEv.ShowDialog()
   End Sub

   Private Sub mtDia6_Click(sender As Object, e As EventArgs) Handles mtDia6.Click
      Dim AgendaEv As New frmAgendaEvento(mtDia6.Text)
      AgendaEv.ShowDialog()
   End Sub

   Private Sub mtDia7_Click(sender As Object, e As EventArgs) Handles mtDia7.Click
      Dim AgendaEv As New frmAgendaEvento(mtDia7.Text)
      AgendaEv.ShowDialog()
   End Sub
End Class