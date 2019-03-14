<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendas
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.pnlLateral = New MetroFramework.Controls.MetroPanel()
        Me.txtPrevenda = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtClienteDesc = New MetroFramework.Controls.MetroTextBox()
        Me.txtClienteCod = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtQuantidade = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtServicoDesc = New MetroFramework.Controls.MetroTextBox()
        Me.txtServicaoCod = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtProdutoDesc = New MetroFramework.Controls.MetroTextBox()
        Me.txtProdutoCod = New MetroFramework.Controls.MetroTextBox()
        Me.lblServico = New MetroFramework.Controls.MetroLabel()
        Me.pnlPrincipal = New MetroFramework.Controls.MetroPanel()
        Me.dgvFormas = New System.Windows.Forms.DataGridView()
        Me.dgvItens = New System.Windows.Forms.DataGridView()
        Me.mtTotal = New MetroFramework.Controls.MetroTile()
        Me.mtFinalizar = New MetroFramework.Controls.MetroTile()
        Me.mtPagamento = New MetroFramework.Controls.MetroTile()
        Me.mtCliente = New MetroFramework.Controls.MetroTile()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.mtVendedor = New MetroFramework.Controls.MetroTile()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLateral.SuspendLayout()
        Me.pnlPrincipal.SuspendLayout()
        CType(Me.dgvFormas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvItens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Green
        '
        'pnlLateral
        '
        Me.pnlLateral.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlLateral.Controls.Add(Me.mtFinalizar)
        Me.pnlLateral.Controls.Add(Me.mtPagamento)
        Me.pnlLateral.Controls.Add(Me.mtCliente)
        Me.pnlLateral.Controls.Add(Me.Button1)
        Me.pnlLateral.Controls.Add(Me.txtPrevenda)
        Me.pnlLateral.Controls.Add(Me.MetroLabel4)
        Me.pnlLateral.Controls.Add(Me.btnProcurar)
        Me.pnlLateral.Controls.Add(Me.mtVendedor)
        Me.pnlLateral.Controls.Add(Me.txtClienteDesc)
        Me.pnlLateral.Controls.Add(Me.txtClienteCod)
        Me.pnlLateral.Controls.Add(Me.MetroLabel3)
        Me.pnlLateral.Controls.Add(Me.txtQuantidade)
        Me.pnlLateral.Controls.Add(Me.MetroLabel2)
        Me.pnlLateral.Controls.Add(Me.txtServicoDesc)
        Me.pnlLateral.Controls.Add(Me.txtServicaoCod)
        Me.pnlLateral.Controls.Add(Me.MetroLabel1)
        Me.pnlLateral.Controls.Add(Me.txtProdutoDesc)
        Me.pnlLateral.Controls.Add(Me.txtProdutoCod)
        Me.pnlLateral.Controls.Add(Me.lblServico)
        Me.pnlLateral.HorizontalScrollbarBarColor = True
        Me.pnlLateral.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlLateral.HorizontalScrollbarSize = 10
        Me.pnlLateral.Location = New System.Drawing.Point(1, 75)
        Me.pnlLateral.Name = "pnlLateral"
        Me.pnlLateral.Size = New System.Drawing.Size(386, 724)
        Me.pnlLateral.TabIndex = 31
        Me.pnlLateral.VerticalScrollbarBarColor = True
        Me.pnlLateral.VerticalScrollbarHighlightOnWheel = False
        Me.pnlLateral.VerticalScrollbarSize = 10
        '
        'txtPrevenda
        '
        '
        '
        '
        Me.txtPrevenda.CustomButton.Image = Nothing
        Me.txtPrevenda.CustomButton.Location = New System.Drawing.Point(99, 1)
        Me.txtPrevenda.CustomButton.Name = ""
        Me.txtPrevenda.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtPrevenda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrevenda.CustomButton.TabIndex = 1
        Me.txtPrevenda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrevenda.CustomButton.UseSelectable = True
        Me.txtPrevenda.CustomButton.Visible = False
        Me.txtPrevenda.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPrevenda.Lines = New String(-1) {}
        Me.txtPrevenda.Location = New System.Drawing.Point(16, 37)
        Me.txtPrevenda.MaxLength = 5
        Me.txtPrevenda.Name = "txtPrevenda"
        Me.txtPrevenda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrevenda.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrevenda.SelectedText = ""
        Me.txtPrevenda.SelectionLength = 0
        Me.txtPrevenda.SelectionStart = 0
        Me.txtPrevenda.ShortcutsEnabled = True
        Me.txtPrevenda.Size = New System.Drawing.Size(127, 29)
        Me.txtPrevenda.TabIndex = 0
        Me.txtPrevenda.UseSelectable = True
        Me.txtPrevenda.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrevenda.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(12, 15)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel4.TabIndex = 71
        Me.MetroLabel4.Text = "Pré-Venda"
        '
        'txtClienteDesc
        '
        Me.txtClienteDesc.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtClienteDesc.CustomButton.Image = Nothing
        Me.txtClienteDesc.CustomButton.Location = New System.Drawing.Point(202, 1)
        Me.txtClienteDesc.CustomButton.Name = ""
        Me.txtClienteDesc.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtClienteDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtClienteDesc.CustomButton.TabIndex = 1
        Me.txtClienteDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtClienteDesc.CustomButton.UseSelectable = True
        Me.txtClienteDesc.CustomButton.Visible = False
        Me.txtClienteDesc.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtClienteDesc.Lines = New String(-1) {}
        Me.txtClienteDesc.Location = New System.Drawing.Point(97, 335)
        Me.txtClienteDesc.MaxLength = 5
        Me.txtClienteDesc.Name = "txtClienteDesc"
        Me.txtClienteDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClienteDesc.ReadOnly = True
        Me.txtClienteDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtClienteDesc.SelectedText = ""
        Me.txtClienteDesc.SelectionLength = 0
        Me.txtClienteDesc.SelectionStart = 0
        Me.txtClienteDesc.ShortcutsEnabled = True
        Me.txtClienteDesc.Size = New System.Drawing.Size(230, 29)
        Me.txtClienteDesc.TabIndex = 65
        Me.txtClienteDesc.UseCustomBackColor = True
        Me.txtClienteDesc.UseCustomForeColor = True
        Me.txtClienteDesc.UseSelectable = True
        Me.txtClienteDesc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtClienteDesc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtClienteCod
        '
        '
        '
        '
        Me.txtClienteCod.CustomButton.Image = Nothing
        Me.txtClienteCod.CustomButton.Location = New System.Drawing.Point(53, 1)
        Me.txtClienteCod.CustomButton.Name = ""
        Me.txtClienteCod.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtClienteCod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtClienteCod.CustomButton.TabIndex = 1
        Me.txtClienteCod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtClienteCod.CustomButton.UseSelectable = True
        Me.txtClienteCod.CustomButton.Visible = False
        Me.txtClienteCod.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtClienteCod.Lines = New String(-1) {}
        Me.txtClienteCod.Location = New System.Drawing.Point(16, 335)
        Me.txtClienteCod.MaxLength = 5
        Me.txtClienteCod.Name = "txtClienteCod"
        Me.txtClienteCod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClienteCod.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtClienteCod.SelectedText = ""
        Me.txtClienteCod.SelectionLength = 0
        Me.txtClienteCod.SelectionStart = 0
        Me.txtClienteCod.ShortcutsEnabled = True
        Me.txtClienteCod.Size = New System.Drawing.Size(81, 29)
        Me.txtClienteCod.TabIndex = 7
        Me.txtClienteCod.UseSelectable = True
        Me.txtClienteCod.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtClienteCod.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(12, 313)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel3.TabIndex = 64
        Me.MetroLabel3.Text = "Cliente"
        '
        'txtQuantidade
        '
        '
        '
        '
        Me.txtQuantidade.CustomButton.Image = Nothing
        Me.txtQuantidade.CustomButton.Location = New System.Drawing.Point(53, 1)
        Me.txtQuantidade.CustomButton.Name = ""
        Me.txtQuantidade.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtQuantidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtQuantidade.CustomButton.TabIndex = 1
        Me.txtQuantidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtQuantidade.CustomButton.UseSelectable = True
        Me.txtQuantidade.CustomButton.Visible = False
        Me.txtQuantidade.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtQuantidade.Lines = New String(-1) {}
        Me.txtQuantidade.Location = New System.Drawing.Point(16, 149)
        Me.txtQuantidade.MaxLength = 5
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQuantidade.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtQuantidade.SelectedText = ""
        Me.txtQuantidade.SelectionLength = 0
        Me.txtQuantidade.SelectionStart = 0
        Me.txtQuantidade.ShortcutsEnabled = True
        Me.txtQuantidade.Size = New System.Drawing.Size(81, 29)
        Me.txtQuantidade.TabIndex = 2
        Me.txtQuantidade.UseSelectable = True
        Me.txtQuantidade.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtQuantidade.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(12, 127)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel2.TabIndex = 62
        Me.MetroLabel2.Text = "Quantidade"
        '
        'txtServicoDesc
        '
        Me.txtServicoDesc.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtServicoDesc.CustomButton.Image = Nothing
        Me.txtServicoDesc.CustomButton.Location = New System.Drawing.Point(202, 1)
        Me.txtServicoDesc.CustomButton.Name = ""
        Me.txtServicoDesc.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtServicoDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtServicoDesc.CustomButton.TabIndex = 1
        Me.txtServicoDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtServicoDesc.CustomButton.UseSelectable = True
        Me.txtServicoDesc.CustomButton.Visible = False
        Me.txtServicoDesc.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtServicoDesc.Lines = New String(-1) {}
        Me.txtServicoDesc.Location = New System.Drawing.Point(97, 214)
        Me.txtServicoDesc.MaxLength = 5
        Me.txtServicoDesc.Name = "txtServicoDesc"
        Me.txtServicoDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtServicoDesc.ReadOnly = True
        Me.txtServicoDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtServicoDesc.SelectedText = ""
        Me.txtServicoDesc.SelectionLength = 0
        Me.txtServicoDesc.SelectionStart = 0
        Me.txtServicoDesc.ShortcutsEnabled = True
        Me.txtServicoDesc.Size = New System.Drawing.Size(230, 29)
        Me.txtServicoDesc.TabIndex = 5
        Me.txtServicoDesc.UseCustomBackColor = True
        Me.txtServicoDesc.UseCustomForeColor = True
        Me.txtServicoDesc.UseSelectable = True
        Me.txtServicoDesc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtServicoDesc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtServicaoCod
        '
        '
        '
        '
        Me.txtServicaoCod.CustomButton.Image = Nothing
        Me.txtServicaoCod.CustomButton.Location = New System.Drawing.Point(53, 1)
        Me.txtServicaoCod.CustomButton.Name = ""
        Me.txtServicaoCod.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtServicaoCod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtServicaoCod.CustomButton.TabIndex = 1
        Me.txtServicaoCod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtServicaoCod.CustomButton.UseSelectable = True
        Me.txtServicaoCod.CustomButton.Visible = False
        Me.txtServicaoCod.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtServicaoCod.Lines = New String(-1) {}
        Me.txtServicaoCod.Location = New System.Drawing.Point(16, 214)
        Me.txtServicaoCod.MaxLength = 5
        Me.txtServicaoCod.Name = "txtServicaoCod"
        Me.txtServicaoCod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtServicaoCod.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtServicaoCod.SelectedText = ""
        Me.txtServicaoCod.SelectionLength = 0
        Me.txtServicaoCod.SelectionStart = 0
        Me.txtServicaoCod.ShortcutsEnabled = True
        Me.txtServicaoCod.Size = New System.Drawing.Size(81, 29)
        Me.txtServicaoCod.TabIndex = 4
        Me.txtServicaoCod.UseSelectable = True
        Me.txtServicaoCod.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtServicaoCod.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(12, 192)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel1.TabIndex = 59
        Me.MetroLabel1.Text = "Serviço"
        '
        'txtProdutoDesc
        '
        Me.txtProdutoDesc.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtProdutoDesc.CustomButton.Image = Nothing
        Me.txtProdutoDesc.CustomButton.Location = New System.Drawing.Point(202, 1)
        Me.txtProdutoDesc.CustomButton.Name = ""
        Me.txtProdutoDesc.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtProdutoDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtProdutoDesc.CustomButton.TabIndex = 1
        Me.txtProdutoDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtProdutoDesc.CustomButton.UseSelectable = True
        Me.txtProdutoDesc.CustomButton.Visible = False
        Me.txtProdutoDesc.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtProdutoDesc.Lines = New String(-1) {}
        Me.txtProdutoDesc.Location = New System.Drawing.Point(97, 96)
        Me.txtProdutoDesc.MaxLength = 5
        Me.txtProdutoDesc.Name = "txtProdutoDesc"
        Me.txtProdutoDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProdutoDesc.ReadOnly = True
        Me.txtProdutoDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtProdutoDesc.SelectedText = ""
        Me.txtProdutoDesc.SelectionLength = 0
        Me.txtProdutoDesc.SelectionStart = 0
        Me.txtProdutoDesc.ShortcutsEnabled = True
        Me.txtProdutoDesc.Size = New System.Drawing.Size(230, 29)
        Me.txtProdutoDesc.TabIndex = 57
        Me.txtProdutoDesc.UseCustomBackColor = True
        Me.txtProdutoDesc.UseCustomForeColor = True
        Me.txtProdutoDesc.UseSelectable = True
        Me.txtProdutoDesc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtProdutoDesc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtProdutoCod
        '
        '
        '
        '
        Me.txtProdutoCod.CustomButton.Image = Nothing
        Me.txtProdutoCod.CustomButton.Location = New System.Drawing.Point(53, 1)
        Me.txtProdutoCod.CustomButton.Name = ""
        Me.txtProdutoCod.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtProdutoCod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtProdutoCod.CustomButton.TabIndex = 1
        Me.txtProdutoCod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtProdutoCod.CustomButton.UseSelectable = True
        Me.txtProdutoCod.CustomButton.Visible = False
        Me.txtProdutoCod.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtProdutoCod.Lines = New String(-1) {}
        Me.txtProdutoCod.Location = New System.Drawing.Point(16, 96)
        Me.txtProdutoCod.MaxLength = 5
        Me.txtProdutoCod.Name = "txtProdutoCod"
        Me.txtProdutoCod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProdutoCod.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtProdutoCod.SelectedText = ""
        Me.txtProdutoCod.SelectionLength = 0
        Me.txtProdutoCod.SelectionStart = 0
        Me.txtProdutoCod.ShortcutsEnabled = True
        Me.txtProdutoCod.Size = New System.Drawing.Size(81, 29)
        Me.txtProdutoCod.TabIndex = 1
        Me.txtProdutoCod.UseSelectable = True
        Me.txtProdutoCod.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtProdutoCod.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblServico
        '
        Me.lblServico.AutoSize = True
        Me.lblServico.Location = New System.Drawing.Point(12, 74)
        Me.lblServico.Name = "lblServico"
        Me.lblServico.Size = New System.Drawing.Size(57, 19)
        Me.lblServico.TabIndex = 56
        Me.lblServico.Text = "Produto"
        '
        'pnlPrincipal
        '
        Me.pnlPrincipal.Controls.Add(Me.MetroLabel6)
        Me.pnlPrincipal.Controls.Add(Me.MetroLabel5)
        Me.pnlPrincipal.Controls.Add(Me.dgvFormas)
        Me.pnlPrincipal.Controls.Add(Me.dgvItens)
        Me.pnlPrincipal.Controls.Add(Me.mtTotal)
        Me.pnlPrincipal.HorizontalScrollbarBarColor = True
        Me.pnlPrincipal.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlPrincipal.HorizontalScrollbarSize = 10
        Me.pnlPrincipal.Location = New System.Drawing.Point(390, 75)
        Me.pnlPrincipal.Name = "pnlPrincipal"
        Me.pnlPrincipal.Size = New System.Drawing.Size(608, 723)
        Me.pnlPrincipal.TabIndex = 32
        Me.pnlPrincipal.VerticalScrollbarBarColor = True
        Me.pnlPrincipal.VerticalScrollbarHighlightOnWheel = False
        Me.pnlPrincipal.VerticalScrollbarSize = 10
        '
        'dgvFormas
        '
        Me.dgvFormas.AllowUserToAddRows = False
        Me.dgvFormas.AllowUserToDeleteRows = False
        Me.dgvFormas.AllowUserToOrderColumns = True
        Me.dgvFormas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvFormas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvFormas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvFormas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFormas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFormas.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvFormas.EnableHeadersVisualStyles = False
        Me.dgvFormas.GridColor = System.Drawing.Color.Silver
        Me.dgvFormas.Location = New System.Drawing.Point(246, 476)
        Me.dgvFormas.MultiSelect = False
        Me.dgvFormas.Name = "dgvFormas"
        Me.dgvFormas.ReadOnly = True
        Me.dgvFormas.RowHeadersVisible = False
        Me.dgvFormas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvFormas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFormas.Size = New System.Drawing.Size(261, 72)
        Me.dgvFormas.TabIndex = 70
        '
        'dgvItens
        '
        Me.dgvItens.AllowUserToAddRows = False
        Me.dgvItens.AllowUserToDeleteRows = False
        Me.dgvItens.AllowUserToOrderColumns = True
        Me.dgvItens.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvItens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvItens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItens.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Aquamarine
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItens.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvItens.EnableHeadersVisualStyles = False
        Me.dgvItens.GridColor = System.Drawing.Color.Silver
        Me.dgvItens.Location = New System.Drawing.Point(102, 90)
        Me.dgvItens.MultiSelect = False
        Me.dgvItens.Name = "dgvItens"
        Me.dgvItens.ReadOnly = True
        Me.dgvItens.RowHeadersVisible = False
        Me.dgvItens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItens.Size = New System.Drawing.Size(405, 324)
        Me.dgvItens.TabIndex = 69
        '
        'mtTotal
        '
        Me.mtTotal.ActiveControl = Nothing
        Me.mtTotal.Location = New System.Drawing.Point(296, 640)
        Me.mtTotal.Name = "mtTotal"
        Me.mtTotal.Size = New System.Drawing.Size(281, 52)
        Me.mtTotal.Style = MetroFramework.MetroColorStyle.Red
        Me.mtTotal.TabIndex = 0
        Me.mtTotal.Text = "Total:"
        Me.mtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mtTotal.TileImage = Global.Petshop.UI.My.Resources.Resources.icons8_Money_32px
        Me.mtTotal.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mtTotal.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtTotal.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.mtTotal.UseSelectable = True
        Me.mtTotal.UseTileImage = True
        '
        'mtFinalizar
        '
        Me.mtFinalizar.ActiveControl = Nothing
        Me.mtFinalizar.Location = New System.Drawing.Point(16, 498)
        Me.mtFinalizar.Name = "mtFinalizar"
        Me.mtFinalizar.Size = New System.Drawing.Size(194, 101)
        Me.mtFinalizar.Style = MetroFramework.MetroColorStyle.Green
        Me.mtFinalizar.TabIndex = 9
        Me.mtFinalizar.Text = "F6 - Finalizar"
        Me.mtFinalizar.TileImage = Global.Petshop.UI.My.Resources.Resources.icons8_Paid_32px
        Me.mtFinalizar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtFinalizar.UseSelectable = True
        Me.mtFinalizar.UseTileImage = True
        '
        'mtPagamento
        '
        Me.mtPagamento.ActiveControl = Nothing
        Me.mtPagamento.Location = New System.Drawing.Point(137, 391)
        Me.mtPagamento.Name = "mtPagamento"
        Me.mtPagamento.Size = New System.Drawing.Size(190, 101)
        Me.mtPagamento.Style = MetroFramework.MetroColorStyle.Green
        Me.mtPagamento.TabIndex = 8
        Me.mtPagamento.Text = "F5 - Forma de Pagamento"
        Me.mtPagamento.TileImage = Global.Petshop.UI.My.Resources.Resources.icons8_Card_Payment_32px
        Me.mtPagamento.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtPagamento.UseSelectable = True
        Me.mtPagamento.UseTileImage = True
        '
        'mtCliente
        '
        Me.mtCliente.ActiveControl = Nothing
        Me.mtCliente.Location = New System.Drawing.Point(16, 391)
        Me.mtCliente.Name = "mtCliente"
        Me.mtCliente.Size = New System.Drawing.Size(115, 101)
        Me.mtCliente.Style = MetroFramework.MetroColorStyle.Green
        Me.mtCliente.TabIndex = 73
        Me.mtCliente.Text = "F4 - Cliente"
        Me.mtCliente.TileImage = Global.Petshop.UI.My.Resources.Resources.icons8_Customer_32px
        Me.mtCliente.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mtCliente.UseSelectable = True
        Me.mtCliente.UseTileImage = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Plus_32px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(16, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 40)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "F3 - Adicionar serviço"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnProcurar
        '
        Me.btnProcurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnProcurar.FlatAppearance.BorderSize = 0
        Me.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcurar.ForeColor = System.Drawing.Color.White
        Me.btnProcurar.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Plus_32px
        Me.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcurar.Location = New System.Drawing.Point(110, 141)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(217, 40)
        Me.btnProcurar.TabIndex = 3
        Me.btnProcurar.Text = "F2 - Adicionar produto"
        Me.btnProcurar.UseVisualStyleBackColor = False
        '
        'mtVendedor
        '
        Me.mtVendedor.ActiveControl = Nothing
        Me.mtVendedor.Location = New System.Drawing.Point(16, 640)
        Me.mtVendedor.Name = "mtVendedor"
        Me.mtVendedor.Size = New System.Drawing.Size(304, 52)
        Me.mtVendedor.Style = MetroFramework.MetroColorStyle.Green
        Me.mtVendedor.TabIndex = 67
        Me.mtVendedor.Text = "Vendedor:"
        Me.mtVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mtVendedor.TileImage = Global.Petshop.UI.My.Resources.Resources.icons8_Account_32px
        Me.mtVendedor.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mtVendedor.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtVendedor.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.mtVendedor.UseSelectable = True
        Me.mtVendedor.UseTileImage = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Checkout_64px
        Me.PictureBox1.Location = New System.Drawing.Point(121, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(246, 454)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(148, 19)
        Me.MetroLabel5.TabIndex = 71
        Me.MetroLabel5.Text = "Formas de Pagamentos"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.Location = New System.Drawing.Point(102, 62)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(47, 25)
        Me.MetroLabel6.TabIndex = 72
        Me.MetroLabel6.Text = "Itens"
        '
        'Vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 800)
        Me.Controls.Add(Me.pnlPrincipal)
        Me.Controls.Add(Me.pnlLateral)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Vendas"
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Vendas"
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLateral.ResumeLayout(False)
        Me.pnlLateral.PerformLayout()
        Me.pnlPrincipal.ResumeLayout(False)
        Me.pnlPrincipal.PerformLayout()
        CType(Me.dgvFormas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvItens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlPrincipal As MetroFramework.Controls.MetroPanel
    Friend WithEvents pnlLateral As MetroFramework.Controls.MetroPanel
    Friend WithEvents txtServicoDesc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtServicaoCod As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtProdutoDesc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtProdutoCod As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblServico As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtClienteDesc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtClienteCod As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtQuantidade As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtTotal As MetroFramework.Controls.MetroTile
    Friend WithEvents mtVendedor As MetroFramework.Controls.MetroTile
    Friend WithEvents btnProcurar As Button
    Friend WithEvents dgvFormas As DataGridView
    Friend WithEvents dgvItens As DataGridView
    Friend WithEvents mtPagamento As MetroFramework.Controls.MetroTile
    Friend WithEvents mtCliente As MetroFramework.Controls.MetroTile
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPrevenda As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtFinalizar As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
End Class
