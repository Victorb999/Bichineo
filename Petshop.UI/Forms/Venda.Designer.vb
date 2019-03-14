<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Venda
    Inherits MetroFramework.Forms.MetroForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCodigo = New MetroFramework.Controls.MetroTextBox()
        Me.lblCodigo = New MetroFramework.Controls.MetroLabel()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.MtAgenda = New MetroFramework.Controls.MetroTile()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MetroTile2)
        Me.Panel1.Controls.Add(Me.MetroTile1)
        Me.Panel1.Controls.Add(Me.MtAgenda)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.lblCodigo)
        Me.Panel1.Location = New System.Drawing.Point(23, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 460)
        Me.Panel1.TabIndex = 0
        '
        'txtCodigo
        '
        '
        '
        '
        Me.txtCodigo.CustomButton.Image = Nothing
        Me.txtCodigo.CustomButton.Location = New System.Drawing.Point(284, 1)
        Me.txtCodigo.CustomButton.Name = ""
        Me.txtCodigo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodigo.CustomButton.TabIndex = 1
        Me.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodigo.CustomButton.UseSelectable = True
        Me.txtCodigo.CustomButton.Visible = False
        Me.txtCodigo.Lines = New String(-1) {}
        Me.txtCodigo.Location = New System.Drawing.Point(9, 39)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodigo.SelectedText = ""
        Me.txtCodigo.SelectionLength = 0
        Me.txtCodigo.SelectionStart = 0
        Me.txtCodigo.ShortcutsEnabled = True
        Me.txtCodigo.Size = New System.Drawing.Size(306, 23)
        Me.txtCodigo.TabIndex = 28
        Me.txtCodigo.UseSelectable = True
        Me.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodigo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(8, 11)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(53, 19)
        Me.lblCodigo.TabIndex = 27
        Me.lblCodigo.Text = "Código"
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.MetroTile2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile2.Location = New System.Drawing.Point(217, 68)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(98, 89)
        Me.MetroTile2.TabIndex = 31
        Me.MetroTile2.Text = "Quantidade"
        Me.MetroTile2.TileImage = Global.Petshop.UI.My.Resources.Resources.icons8_Minus_32px
        Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile2.UseCustomBackColor = True
        Me.MetroTile2.UseSelectable = True
        Me.MetroTile2.UseStyleColors = True
        Me.MetroTile2.UseTileImage = True
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.MetroTile1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile1.Location = New System.Drawing.Point(113, 68)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(98, 89)
        Me.MetroTile1.TabIndex = 30
        Me.MetroTile1.Text = "Quantidade"
        Me.MetroTile1.TileImage = Global.Petshop.UI.My.Resources.Resources.icons8_Plus_32px
        Me.MetroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.UseCustomBackColor = True
        Me.MetroTile1.UseSelectable = True
        Me.MetroTile1.UseStyleColors = True
        Me.MetroTile1.UseTileImage = True
        '
        'MtAgenda
        '
        Me.MtAgenda.ActiveControl = Nothing
        Me.MtAgenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.MtAgenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MtAgenda.Location = New System.Drawing.Point(9, 68)
        Me.MtAgenda.Name = "MtAgenda"
        Me.MtAgenda.Size = New System.Drawing.Size(98, 89)
        Me.MtAgenda.TabIndex = 29
        Me.MtAgenda.Text = "F2 -Vendas"
        Me.MtAgenda.TileImage = Global.Petshop.UI.My.Resources.Resources.icons8_Shopping_Cart_32px
        Me.MtAgenda.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MtAgenda.UseCustomBackColor = True
        Me.MtAgenda.UseSelectable = True
        Me.MtAgenda.UseStyleColors = True
        Me.MtAgenda.UseTileImage = True
        '
        'Venda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Venda"
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Venda"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCodigo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCodigo As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MtAgenda As MetroFramework.Controls.MetroTile
End Class
