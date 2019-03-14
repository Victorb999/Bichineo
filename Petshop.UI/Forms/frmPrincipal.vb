Public Class frmPrincipal
    Public Const Titulo = "Bichíneo"

    Private Sub Petshop_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Return Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyCode = Keys.Escape Then
            Application.Exit()
            Me.Close()
        ElseIf e.KeyCode = Keys.F2 Then
            MtAgenda_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            'MtAgenda_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F4 Then
            MtCliente_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F5 Then
            MtPet_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F6 Then
            MtServico_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F7 Then
            MtProduto_Click_1(Nothing, Nothing)
        End If
    End Sub


    Private Sub Petshop_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged

        'centraliza o panel principal
        PnlPrincipal.Left = (Me.Width - PnlPrincipal.Width) / 2
        PnlPrincipal.Top = (Me.Height - PnlPrincipal.Height) / 2
        pbLogo.Left = Me.Width - pbLogo.Width - 25
        pbLogo.Top = Me.Height - pbLogo.Height - 50
    End Sub

    Private Sub MtAgenda_Click(sender As Object, e As EventArgs) Handles MtAgenda.Click
        Dim agenda As New Agenda
        agenda.ShowDialog()
    End Sub

    Private Sub MtCliente_Click(sender As Object, e As EventArgs) Handles MtCliente.Click
        Dim cliente As New frmCliente
        cliente.ShowDialog()
    End Sub

    Private Sub MtPet_Click(sender As Object, e As EventArgs) Handles MtPet.Click
        Dim pet As New frmAnimal
        pet.ShowDialog()
        pet.Dispose()
    End Sub

    Private Sub MtServico_Click(sender As Object, e As EventArgs) Handles MtServico.Click
        Dim produto As New frmServico
        produto.ShowDialog()
    End Sub

    Private Sub MtProduto_Click_1(sender As Object, e As EventArgs) Handles MtProduto.Click
        Dim produto As New ProdutoServico
        produto.ShowDialog()
    End Sub

    Private Sub MtVenda_Click(sender As Object, e As EventArgs) Handles MtVenda.Click
        Dim produto As New Vendas
        produto.ShowDialog()
    End Sub
End Class
