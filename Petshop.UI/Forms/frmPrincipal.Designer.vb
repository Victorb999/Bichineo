<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.PnlPrincipal = New MetroFramework.Controls.MetroPanel()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.MtProduto = New MetroFramework.Controls.MetroTile()
        Me.MtRelatorio = New MetroFramework.Controls.MetroTile()
        Me.MtServico = New MetroFramework.Controls.MetroTile()
        Me.MtPet = New MetroFramework.Controls.MetroTile()
        Me.MtCliente = New MetroFramework.Controls.MetroTile()
        Me.MtVenda = New MetroFramework.Controls.MetroTile()
        Me.MtAgenda = New MetroFramework.Controls.MetroTile()
        Me.PnlPrincipal.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlPrincipal
        '
        Me.PnlPrincipal.Controls.Add(Me.MtProduto)
        Me.PnlPrincipal.Controls.Add(Me.MtRelatorio)
        Me.PnlPrincipal.Controls.Add(Me.MtServico)
        Me.PnlPrincipal.Controls.Add(Me.MtPet)
        Me.PnlPrincipal.Controls.Add(Me.MtCliente)
        Me.PnlPrincipal.Controls.Add(Me.MtVenda)
        Me.PnlPrincipal.Controls.Add(Me.MtAgenda)
        Me.PnlPrincipal.HorizontalScrollbarBarColor = True
        Me.PnlPrincipal.HorizontalScrollbarHighlightOnWheel = False
        Me.PnlPrincipal.HorizontalScrollbarSize = 10
        Me.PnlPrincipal.Location = New System.Drawing.Point(235, 113)
        Me.PnlPrincipal.Name = "PnlPrincipal"
        Me.PnlPrincipal.Size = New System.Drawing.Size(554, 282)
        Me.PnlPrincipal.TabIndex = 0
        Me.PnlPrincipal.VerticalScrollbarBarColor = True
        Me.PnlPrincipal.VerticalScrollbarHighlightOnWheel = False
        Me.PnlPrincipal.VerticalScrollbarSize = 10
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.Petshop.UI.My.Resources.Resources.Bichineo
        Me.pbLogo.Location = New System.Drawing.Point(795, 534)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(206, 182)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 1
        Me.pbLogo.TabStop = False
        '
        'MtProduto
        '
        Me.MtProduto.ActiveControl = Nothing
        Me.MtProduto.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.MtProduto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MtProduto.Location = New System.Drawing.Point(148, 143)
        Me.MtProduto.Name = "MtProduto"
        Me.MtProduto.Size = New System.Drawing.Size(125, 125)
        Me.MtProduto.TabIndex = 7
        Me.MtProduto.Text = "F7 - Produto"
        Me.MtProduto.TileImage = Global.Petshop.UI.My.Resources.Resources.icons8_Product_96px
        Me.MtProduto.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MtProduto.UseCustomBackColor = True
        Me.MtProduto.UseSelectable = True
        Me.MtProduto.UseStyleColors = True
        Me.MtProduto.UseTileImage = True
        '
        'MtRelatorio
        '
        Me.MtRelatorio.ActiveControl = Nothing
        Me.MtRelatorio.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.MtRelatorio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MtRelatorio.Enabled = False
        Me.MtRelatorio.Location = New System.Drawing.Point(278, 143)
        Me.MtRelatorio.Name = "MtRelatorio"
        Me.MtRelatorio.Size = New System.Drawing.Size(125, 125)
        Me.MtRelatorio.TabIndex = 6
        Me.MtRelatorio.Text = "F7 - Relatórios"
        Me.MtRelatorio.TileImage = Global.Petshop.UI.My.Resources.Resources.icons8_Increase_96px
        Me.MtRelatorio.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MtRelatorio.UseCustomBackColor = True
        Me.MtRelatorio.UseSelectable = True
        Me.MtRelatorio.UseStyleColors = True
        Me.MtRelatorio.UseTileImage = True
        '
        'MtServico
        '
        Me.MtServico.ActiveControl = Nothing
        Me.MtServico.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.MtServico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MtServico.Location = New System.Drawing.Point(18, 143)
        Me.MtServico.Name = "MtServico"
        Me.MtServico.Size = New System.Drawing.Size(125, 125)
        Me.MtServico.TabIndex = 5
        Me.MtServico.Text = "F6 - Serviço"
        Me.MtServico.TileImage = Global.Petshop.UI.My.Resources.Resources.icons8_Syringe_96px
        Me.MtServico.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MtServico.UseCustomBackColor = True
        Me.MtServico.UseSelectable = True
        Me.MtServico.UseStyleColors = True
        Me.MtServico.UseTileImage = True
        '
        'MtPet
        '
        Me.MtPet.ActiveControl = Nothing
        Me.MtPet.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.MtPet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MtPet.Location = New System.Drawing.Point(409, 14)
        Me.MtPet.Name = "MtPet"
        Me.MtPet.Size = New System.Drawing.Size(125, 125)
        Me.MtPet.TabIndex = 4
        Me.MtPet.Text = "F5 - Pet"
        Me.MtPet.TileImage = Global.Petshop.UI.My.Resources.Resources.icons8_Cat_Footprint_96px
        Me.MtPet.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MtPet.UseCustomBackColor = True
        Me.MtPet.UseSelectable = True
        Me.MtPet.UseStyleColors = True
        Me.MtPet.UseTileImage = True
        '
        'MtCliente
        '
        Me.MtCliente.ActiveControl = Nothing
        Me.MtCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.MtCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MtCliente.Location = New System.Drawing.Point(278, 14)
        Me.MtCliente.Name = "MtCliente"
        Me.MtCliente.Size = New System.Drawing.Size(125, 125)
        Me.MtCliente.TabIndex = 3
        Me.MtCliente.Text = "F4 - Cliente"
        Me.MtCliente.TileImage = Global.Petshop.UI.My.Resources.Resources.icons8_People_96px_2
        Me.MtCliente.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MtCliente.UseCustomBackColor = True
        Me.MtCliente.UseSelectable = True
        Me.MtCliente.UseStyleColors = True
        Me.MtCliente.UseTileImage = True
        '
        'MtVenda
        '
        Me.MtVenda.ActiveControl = Nothing
        Me.MtVenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.MtVenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MtVenda.Location = New System.Drawing.Point(148, 14)
        Me.MtVenda.Name = "MtVenda"
        Me.MtVenda.Size = New System.Drawing.Size(125, 125)
        Me.MtVenda.TabIndex = 3
        Me.MtVenda.Text = "F3 - Venda"
        Me.MtVenda.TileImage = Global.Petshop.UI.My.Resources.Resources.icons8_Checkout_96px
        Me.MtVenda.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MtVenda.UseCustomBackColor = True
        Me.MtVenda.UseSelectable = True
        Me.MtVenda.UseStyleColors = True
        Me.MtVenda.UseTileImage = True
        '
        'MtAgenda
        '
        Me.MtAgenda.ActiveControl = Nothing
        Me.MtAgenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.MtAgenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MtAgenda.Location = New System.Drawing.Point(18, 14)
        Me.MtAgenda.Name = "MtAgenda"
        Me.MtAgenda.Size = New System.Drawing.Size(125, 125)
        Me.MtAgenda.TabIndex = 2
        Me.MtAgenda.Text = "F2 - Agenda"
        Me.MtAgenda.TileImage = Global.Petshop.UI.My.Resources.Resources.icons8_Schedule_96px
        Me.MtAgenda.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MtAgenda.UseCustomBackColor = True
        Me.MtAgenda.UseSelectable = True
        Me.MtAgenda.UseStyleColors = True
        Me.MtAgenda.UseTileImage = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.PnlPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPrincipal"
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Bichineo"
        Me.TransparencyKey = System.Drawing.Color.Aquamarine
        Me.PnlPrincipal.ResumeLayout(False)
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlPrincipal As MetroFramework.Controls.MetroPanel
    Friend WithEvents MtAgenda As MetroFramework.Controls.MetroTile
    Friend WithEvents MtRelatorio As MetroFramework.Controls.MetroTile
    Friend WithEvents MtServico As MetroFramework.Controls.MetroTile
    Friend WithEvents MtPet As MetroFramework.Controls.MetroTile
    Friend WithEvents MtCliente As MetroFramework.Controls.MetroTile
    Friend WithEvents MtVenda As MetroFramework.Controls.MetroTile
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents MtProduto As MetroFramework.Controls.MetroTile
End Class
