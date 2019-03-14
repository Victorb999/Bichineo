<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdutoServico
    Inherits MetroFramework.Forms.MetroForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbProdutoServico = New MetroFramework.Controls.MetroTabControl()
        Me.tpProduto = New MetroFramework.Controls.MetroTabPage()
        Me.btsalvar = New System.Windows.Forms.Button()
        Me.txtEstoque = New MetroFramework.Controls.MetroTextBox()
        Me.lblEstoque = New MetroFramework.Controls.MetroLabel()
        Me.txtPrecoVenda = New MetroFramework.Controls.MetroTextBox()
        Me.PrecoVenda = New MetroFramework.Controls.MetroLabel()
        Me.txtPrecoCusto = New MetroFramework.Controls.MetroTextBox()
        Me.lblPrecoCusto = New MetroFramework.Controls.MetroLabel()
        Me.txtFabricante = New MetroFramework.Controls.MetroTextBox()
        Me.lblFabricante = New MetroFramework.Controls.MetroLabel()
        Me.txtCodBarras = New MetroFramework.Controls.MetroTextBox()
        Me.lblCodBarras = New MetroFramework.Controls.MetroLabel()
        Me.txtDescricao = New MetroFramework.Controls.MetroTextBox()
        Me.lblDescricao = New MetroFramework.Controls.MetroLabel()
        Me.txtCodigo = New MetroFramework.Controls.MetroTextBox()
        Me.lblCodigo = New MetroFramework.Controls.MetroLabel()
        Me.tbServico = New MetroFramework.Controls.MetroTabPage()
        Me.txtObservacao = New MetroFramework.Controls.MetroTextBox()
        Me.lblObservacao = New MetroFramework.Controls.MetroLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.lblPreco = New MetroFramework.Controls.MetroLabel()
        Me.txtDescricaoServico = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtCodigoServico = New MetroFramework.Controls.MetroTextBox()
        Me.lblCodigoServico = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbProdutoServico.SuspendLayout()
        Me.tpProduto.SuspendLayout()
        Me.tbServico.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbProdutoServico
        '
        Me.tbProdutoServico.Controls.Add(Me.tpProduto)
        Me.tbProdutoServico.Controls.Add(Me.tbServico)
        Me.tbProdutoServico.Location = New System.Drawing.Point(47, 64)
        Me.tbProdutoServico.Name = "tbProdutoServico"
        Me.tbProdutoServico.SelectedIndex = 1
        Me.tbProdutoServico.Size = New System.Drawing.Size(465, 529)
        Me.tbProdutoServico.Style = MetroFramework.MetroColorStyle.Lime
        Me.tbProdutoServico.TabIndex = 0
        Me.tbProdutoServico.UseSelectable = True
        '
        'tpProduto
        '
        Me.tpProduto.Controls.Add(Me.btsalvar)
        Me.tpProduto.Controls.Add(Me.txtEstoque)
        Me.tpProduto.Controls.Add(Me.lblEstoque)
        Me.tpProduto.Controls.Add(Me.txtPrecoVenda)
        Me.tpProduto.Controls.Add(Me.PrecoVenda)
        Me.tpProduto.Controls.Add(Me.txtPrecoCusto)
        Me.tpProduto.Controls.Add(Me.lblPrecoCusto)
        Me.tpProduto.Controls.Add(Me.txtFabricante)
        Me.tpProduto.Controls.Add(Me.lblFabricante)
        Me.tpProduto.Controls.Add(Me.txtCodBarras)
        Me.tpProduto.Controls.Add(Me.lblCodBarras)
        Me.tpProduto.Controls.Add(Me.txtDescricao)
        Me.tpProduto.Controls.Add(Me.lblDescricao)
        Me.tpProduto.Controls.Add(Me.txtCodigo)
        Me.tpProduto.Controls.Add(Me.lblCodigo)
        Me.tpProduto.HorizontalScrollbarBarColor = True
        Me.tpProduto.HorizontalScrollbarHighlightOnWheel = False
        Me.tpProduto.HorizontalScrollbarSize = 10
        Me.tpProduto.Location = New System.Drawing.Point(4, 38)
        Me.tpProduto.Name = "tpProduto"
        Me.tpProduto.Size = New System.Drawing.Size(457, 487)
        Me.tpProduto.Style = MetroFramework.MetroColorStyle.Lime
        Me.tpProduto.TabIndex = 0
        Me.tpProduto.Text = "F2 - Produto"
        Me.tpProduto.VerticalScrollbarBarColor = True
        Me.tpProduto.VerticalScrollbarHighlightOnWheel = False
        Me.tpProduto.VerticalScrollbarSize = 10
        '
        'btsalvar
        '
        Me.btsalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btsalvar.FlatAppearance.BorderSize = 0
        Me.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btsalvar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsalvar.ForeColor = System.Drawing.Color.White
        Me.btsalvar.Image = Global.petshop.UI.My.Resources.Resources.icons8_Save_32px_1
        Me.btsalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btsalvar.Location = New System.Drawing.Point(286, 413)
        Me.btsalvar.Name = "btsalvar"
        Me.btsalvar.Size = New System.Drawing.Size(129, 45)
        Me.btsalvar.TabIndex = 40
        Me.btsalvar.Text = "Salvar"
        Me.btsalvar.UseVisualStyleBackColor = False
        '
        'txtEstoque
        '
        '
        '
        '
        Me.txtEstoque.CustomButton.Image = Nothing
        Me.txtEstoque.CustomButton.Location = New System.Drawing.Point(154, 1)
        Me.txtEstoque.CustomButton.Name = ""
        Me.txtEstoque.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEstoque.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEstoque.CustomButton.TabIndex = 1
        Me.txtEstoque.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEstoque.CustomButton.UseSelectable = True
        Me.txtEstoque.CustomButton.Visible = False
        Me.txtEstoque.Lines = New String(-1) {}
        Me.txtEstoque.Location = New System.Drawing.Point(13, 285)
        Me.txtEstoque.MaxLength = 5
        Me.txtEstoque.Name = "txtEstoque"
        Me.txtEstoque.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEstoque.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEstoque.SelectedText = ""
        Me.txtEstoque.SelectionLength = 0
        Me.txtEstoque.SelectionStart = 0
        Me.txtEstoque.ShortcutsEnabled = True
        Me.txtEstoque.Size = New System.Drawing.Size(176, 23)
        Me.txtEstoque.TabIndex = 38
        Me.txtEstoque.UseSelectable = True
        Me.txtEstoque.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEstoque.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblEstoque
        '
        Me.lblEstoque.AutoSize = True
        Me.lblEstoque.Location = New System.Drawing.Point(12, 257)
        Me.lblEstoque.Name = "lblEstoque"
        Me.lblEstoque.Size = New System.Drawing.Size(55, 19)
        Me.lblEstoque.TabIndex = 37
        Me.lblEstoque.Text = "Estoque"
        '
        'txtPrecoVenda
        '
        '
        '
        '
        Me.txtPrecoVenda.CustomButton.Image = Nothing
        Me.txtPrecoVenda.CustomButton.Location = New System.Drawing.Point(153, 1)
        Me.txtPrecoVenda.CustomButton.Name = ""
        Me.txtPrecoVenda.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPrecoVenda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrecoVenda.CustomButton.TabIndex = 1
        Me.txtPrecoVenda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrecoVenda.CustomButton.UseSelectable = True
        Me.txtPrecoVenda.CustomButton.Visible = False
        Me.txtPrecoVenda.Lines = New String(-1) {}
        Me.txtPrecoVenda.Location = New System.Drawing.Point(240, 225)
        Me.txtPrecoVenda.MaxLength = 5
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecoVenda.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecoVenda.SelectedText = ""
        Me.txtPrecoVenda.SelectionLength = 0
        Me.txtPrecoVenda.SelectionStart = 0
        Me.txtPrecoVenda.ShortcutsEnabled = True
        Me.txtPrecoVenda.Size = New System.Drawing.Size(175, 23)
        Me.txtPrecoVenda.TabIndex = 36
        Me.txtPrecoVenda.UseSelectable = True
        Me.txtPrecoVenda.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrecoVenda.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PrecoVenda
        '
        Me.PrecoVenda.AutoSize = True
        Me.PrecoVenda.Location = New System.Drawing.Point(240, 197)
        Me.PrecoVenda.Name = "PrecoVenda"
        Me.PrecoVenda.Size = New System.Drawing.Size(83, 19)
        Me.PrecoVenda.TabIndex = 35
        Me.PrecoVenda.Text = "Preço Venda"
        '
        'txtPrecoCusto
        '
        '
        '
        '
        Me.txtPrecoCusto.CustomButton.Image = Nothing
        Me.txtPrecoCusto.CustomButton.Location = New System.Drawing.Point(154, 1)
        Me.txtPrecoCusto.CustomButton.Name = ""
        Me.txtPrecoCusto.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPrecoCusto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrecoCusto.CustomButton.TabIndex = 1
        Me.txtPrecoCusto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrecoCusto.CustomButton.UseSelectable = True
        Me.txtPrecoCusto.CustomButton.Visible = False
        Me.txtPrecoCusto.Lines = New String(-1) {}
        Me.txtPrecoCusto.Location = New System.Drawing.Point(12, 225)
        Me.txtPrecoCusto.MaxLength = 5
        Me.txtPrecoCusto.Name = "txtPrecoCusto"
        Me.txtPrecoCusto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecoCusto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecoCusto.SelectedText = ""
        Me.txtPrecoCusto.SelectionLength = 0
        Me.txtPrecoCusto.SelectionStart = 0
        Me.txtPrecoCusto.ShortcutsEnabled = True
        Me.txtPrecoCusto.Size = New System.Drawing.Size(176, 23)
        Me.txtPrecoCusto.TabIndex = 34
        Me.txtPrecoCusto.UseSelectable = True
        Me.txtPrecoCusto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrecoCusto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblPrecoCusto
        '
        Me.lblPrecoCusto.AutoSize = True
        Me.lblPrecoCusto.Location = New System.Drawing.Point(11, 197)
        Me.lblPrecoCusto.Name = "lblPrecoCusto"
        Me.lblPrecoCusto.Size = New System.Drawing.Size(80, 19)
        Me.lblPrecoCusto.TabIndex = 33
        Me.lblPrecoCusto.Text = "Preço Custo"
        '
        'txtFabricante
        '
        '
        '
        '
        Me.txtFabricante.CustomButton.Image = Nothing
        Me.txtFabricante.CustomButton.Location = New System.Drawing.Point(380, 1)
        Me.txtFabricante.CustomButton.Name = ""
        Me.txtFabricante.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFabricante.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFabricante.CustomButton.TabIndex = 1
        Me.txtFabricante.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFabricante.CustomButton.UseSelectable = True
        Me.txtFabricante.CustomButton.Visible = False
        Me.txtFabricante.Lines = New String(-1) {}
        Me.txtFabricante.Location = New System.Drawing.Point(13, 165)
        Me.txtFabricante.MaxLength = 50
        Me.txtFabricante.Name = "txtFabricante"
        Me.txtFabricante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFabricante.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFabricante.SelectedText = ""
        Me.txtFabricante.SelectionLength = 0
        Me.txtFabricante.SelectionStart = 0
        Me.txtFabricante.ShortcutsEnabled = True
        Me.txtFabricante.Size = New System.Drawing.Size(402, 23)
        Me.txtFabricante.TabIndex = 32
        Me.txtFabricante.UseSelectable = True
        Me.txtFabricante.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFabricante.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblFabricante
        '
        Me.lblFabricante.AutoSize = True
        Me.lblFabricante.Location = New System.Drawing.Point(13, 137)
        Me.lblFabricante.Name = "lblFabricante"
        Me.lblFabricante.Size = New System.Drawing.Size(69, 19)
        Me.lblFabricante.TabIndex = 31
        Me.lblFabricante.Text = "Fabricante"
        '
        'txtCodBarras
        '
        '
        '
        '
        Me.txtCodBarras.CustomButton.Image = Nothing
        Me.txtCodBarras.CustomButton.Location = New System.Drawing.Point(200, 1)
        Me.txtCodBarras.CustomButton.Name = ""
        Me.txtCodBarras.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCodBarras.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodBarras.CustomButton.TabIndex = 1
        Me.txtCodBarras.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodBarras.CustomButton.UseSelectable = True
        Me.txtCodBarras.CustomButton.Visible = False
        Me.txtCodBarras.Lines = New String(-1) {}
        Me.txtCodBarras.Location = New System.Drawing.Point(193, 45)
        Me.txtCodBarras.MaxLength = 5
        Me.txtCodBarras.Name = "txtCodBarras"
        Me.txtCodBarras.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodBarras.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodBarras.SelectedText = ""
        Me.txtCodBarras.SelectionLength = 0
        Me.txtCodBarras.SelectionStart = 0
        Me.txtCodBarras.ShortcutsEnabled = True
        Me.txtCodBarras.Size = New System.Drawing.Size(222, 23)
        Me.txtCodBarras.TabIndex = 30
        Me.txtCodBarras.UseSelectable = True
        Me.txtCodBarras.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodBarras.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblCodBarras
        '
        Me.lblCodBarras.AutoSize = True
        Me.lblCodBarras.Location = New System.Drawing.Point(193, 17)
        Me.lblCodBarras.Name = "lblCodBarras"
        Me.lblCodBarras.Size = New System.Drawing.Size(113, 19)
        Me.lblCodBarras.TabIndex = 29
        Me.lblCodBarras.Text = "Código de Barras"
        '
        'txtDescricao
        '
        '
        '
        '
        Me.txtDescricao.CustomButton.Image = Nothing
        Me.txtDescricao.CustomButton.Location = New System.Drawing.Point(380, 1)
        Me.txtDescricao.CustomButton.Name = ""
        Me.txtDescricao.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDescricao.CustomButton.TabIndex = 1
        Me.txtDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDescricao.CustomButton.UseSelectable = True
        Me.txtDescricao.CustomButton.Visible = False
        Me.txtDescricao.Lines = New String(-1) {}
        Me.txtDescricao.Location = New System.Drawing.Point(13, 105)
        Me.txtDescricao.MaxLength = 50
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescricao.SelectedText = ""
        Me.txtDescricao.SelectionLength = 0
        Me.txtDescricao.SelectionStart = 0
        Me.txtDescricao.ShortcutsEnabled = True
        Me.txtDescricao.Size = New System.Drawing.Size(402, 23)
        Me.txtDescricao.TabIndex = 28
        Me.txtDescricao.UseSelectable = True
        Me.txtDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDescricao.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(12, 77)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(65, 19)
        Me.lblDescricao.TabIndex = 27
        Me.lblDescricao.Text = "Descrição"
        '
        'txtCodigo
        '
        '
        '
        '
        Me.txtCodigo.CustomButton.Image = Nothing
        Me.txtCodigo.CustomButton.Location = New System.Drawing.Point(141, 1)
        Me.txtCodigo.CustomButton.Name = ""
        Me.txtCodigo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodigo.CustomButton.TabIndex = 1
        Me.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodigo.CustomButton.UseSelectable = True
        Me.txtCodigo.CustomButton.Visible = False
        Me.txtCodigo.Lines = New String(-1) {}
        Me.txtCodigo.Location = New System.Drawing.Point(13, 45)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodigo.SelectedText = ""
        Me.txtCodigo.SelectionLength = 0
        Me.txtCodigo.SelectionStart = 0
        Me.txtCodigo.ShortcutsEnabled = True
        Me.txtCodigo.Size = New System.Drawing.Size(163, 23)
        Me.txtCodigo.TabIndex = 26
        Me.txtCodigo.UseSelectable = True
        Me.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodigo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(12, 17)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(53, 19)
        Me.lblCodigo.TabIndex = 25
        Me.lblCodigo.Text = "Código"
        '
        'tbServico
        '
        Me.tbServico.Controls.Add(Me.txtObservacao)
        Me.tbServico.Controls.Add(Me.lblObservacao)
        Me.tbServico.Controls.Add(Me.Button1)
        Me.tbServico.Controls.Add(Me.MetroTextBox2)
        Me.tbServico.Controls.Add(Me.lblPreco)
        Me.tbServico.Controls.Add(Me.txtDescricaoServico)
        Me.tbServico.Controls.Add(Me.MetroLabel6)
        Me.tbServico.Controls.Add(Me.txtCodigoServico)
        Me.tbServico.Controls.Add(Me.lblCodigoServico)
        Me.tbServico.HorizontalScrollbarBarColor = True
        Me.tbServico.HorizontalScrollbarHighlightOnWheel = False
        Me.tbServico.HorizontalScrollbarSize = 10
        Me.tbServico.Location = New System.Drawing.Point(4, 38)
        Me.tbServico.Name = "tbServico"
        Me.tbServico.Size = New System.Drawing.Size(457, 487)
        Me.tbServico.TabIndex = 1
        Me.tbServico.Text = "F3 - Serviço"
        Me.tbServico.VerticalScrollbarBarColor = True
        Me.tbServico.VerticalScrollbarHighlightOnWheel = False
        Me.tbServico.VerticalScrollbarSize = 10
        '
        'txtObservacao
        '
        '
        '
        '
        Me.txtObservacao.CustomButton.Image = Nothing
        Me.txtObservacao.CustomButton.Location = New System.Drawing.Point(293, 2)
        Me.txtObservacao.CustomButton.Name = ""
        Me.txtObservacao.CustomButton.Size = New System.Drawing.Size(107, 107)
        Me.txtObservacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtObservacao.CustomButton.TabIndex = 1
        Me.txtObservacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtObservacao.CustomButton.UseSelectable = True
        Me.txtObservacao.CustomButton.Visible = False
        Me.txtObservacao.Lines = New String(-1) {}
        Me.txtObservacao.Location = New System.Drawing.Point(13, 221)
        Me.txtObservacao.MaxLength = 50
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtObservacao.SelectedText = ""
        Me.txtObservacao.SelectionLength = 0
        Me.txtObservacao.SelectionStart = 0
        Me.txtObservacao.ShortcutsEnabled = True
        Me.txtObservacao.Size = New System.Drawing.Size(403, 112)
        Me.txtObservacao.TabIndex = 57
        Me.txtObservacao.UseSelectable = True
        Me.txtObservacao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtObservacao.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblObservacao
        '
        Me.lblObservacao.AutoSize = True
        Me.lblObservacao.Location = New System.Drawing.Point(13, 194)
        Me.lblObservacao.Name = "lblObservacao"
        Me.lblObservacao.Size = New System.Drawing.Size(80, 19)
        Me.lblObservacao.TabIndex = 56
        Me.lblObservacao.Text = "Observação"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.petshop.UI.My.Resources.Resources.icons8_Save_32px_1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(276, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 45)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Salvar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = Nothing
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(153, 1)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(13, 163)
        Me.MetroTextBox2.MaxLength = 5
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.ShortcutsEnabled = True
        Me.MetroTextBox2.Size = New System.Drawing.Size(175, 23)
        Me.MetroTextBox2.TabIndex = 52
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblPreco
        '
        Me.lblPreco.AutoSize = True
        Me.lblPreco.Location = New System.Drawing.Point(15, 136)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(43, 19)
        Me.lblPreco.TabIndex = 51
        Me.lblPreco.Text = "Preço"
        '
        'txtDescricaoServico
        '
        '
        '
        '
        Me.txtDescricaoServico.CustomButton.Image = Nothing
        Me.txtDescricaoServico.CustomButton.Location = New System.Drawing.Point(380, 1)
        Me.txtDescricaoServico.CustomButton.Name = ""
        Me.txtDescricaoServico.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDescricaoServico.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDescricaoServico.CustomButton.TabIndex = 1
        Me.txtDescricaoServico.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDescricaoServico.CustomButton.UseSelectable = True
        Me.txtDescricaoServico.CustomButton.Visible = False
        Me.txtDescricaoServico.Lines = New String(-1) {}
        Me.txtDescricaoServico.Location = New System.Drawing.Point(13, 105)
        Me.txtDescricaoServico.MaxLength = 50
        Me.txtDescricaoServico.Name = "txtDescricaoServico"
        Me.txtDescricaoServico.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescricaoServico.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescricaoServico.SelectedText = ""
        Me.txtDescricaoServico.SelectionLength = 0
        Me.txtDescricaoServico.SelectionStart = 0
        Me.txtDescricaoServico.ShortcutsEnabled = True
        Me.txtDescricaoServico.Size = New System.Drawing.Size(402, 23)
        Me.txtDescricaoServico.TabIndex = 44
        Me.txtDescricaoServico.UseSelectable = True
        Me.txtDescricaoServico.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDescricaoServico.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(13, 78)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel6.TabIndex = 43
        Me.MetroLabel6.Text = "Descrição"
        '
        'txtCodigoServico
        '
        '
        '
        '
        Me.txtCodigoServico.CustomButton.Image = Nothing
        Me.txtCodigoServico.CustomButton.Location = New System.Drawing.Point(153, 1)
        Me.txtCodigoServico.CustomButton.Name = ""
        Me.txtCodigoServico.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCodigoServico.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodigoServico.CustomButton.TabIndex = 1
        Me.txtCodigoServico.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodigoServico.CustomButton.UseSelectable = True
        Me.txtCodigoServico.CustomButton.Visible = False
        Me.txtCodigoServico.Lines = New String(-1) {}
        Me.txtCodigoServico.Location = New System.Drawing.Point(13, 47)
        Me.txtCodigoServico.MaxLength = 5
        Me.txtCodigoServico.Name = "txtCodigoServico"
        Me.txtCodigoServico.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigoServico.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodigoServico.SelectedText = ""
        Me.txtCodigoServico.SelectionLength = 0
        Me.txtCodigoServico.SelectionStart = 0
        Me.txtCodigoServico.ShortcutsEnabled = True
        Me.txtCodigoServico.Size = New System.Drawing.Size(175, 23)
        Me.txtCodigoServico.TabIndex = 42
        Me.txtCodigoServico.UseSelectable = True
        Me.txtCodigoServico.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodigoServico.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblCodigoServico
        '
        Me.lblCodigoServico.AutoSize = True
        Me.lblCodigoServico.Location = New System.Drawing.Point(14, 20)
        Me.lblCodigoServico.Name = "lblCodigoServico"
        Me.lblCodigoServico.Size = New System.Drawing.Size(53, 19)
        Me.lblCodigoServico.TabIndex = 41
        Me.lblCodigoServico.Text = "Código"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.petshop.UI.My.Resources.Resources.icons8_Product_64px
        Me.PictureBox1.Location = New System.Drawing.Point(213, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'ProdutoServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 632)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tbProdutoServico)
        Me.MaximizeBox = False
        Me.Name = "ProdutoServico"
        Me.Style = MetroFramework.MetroColorStyle.Lime
        Me.Text = "Produto / Serviço"
        Me.tbProdutoServico.ResumeLayout(False)
        Me.tpProduto.ResumeLayout(False)
        Me.tpProduto.PerformLayout()
        Me.tbServico.ResumeLayout(False)
        Me.tbServico.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbProdutoServico As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tpProduto As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tbServico As MetroFramework.Controls.MetroTabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btsalvar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblPreco As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDescricaoServico As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCodigoServico As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCodigoServico As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtObservacao As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblObservacao As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEstoque As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblEstoque As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPrecoVenda As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PrecoVenda As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPrecoCusto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblPrecoCusto As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtFabricante As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblFabricante As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCodBarras As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCodBarras As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDescricao As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblDescricao As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCodigo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCodigo As MetroFramework.Controls.MetroLabel
End Class
