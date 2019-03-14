<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduto
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtEstoque = New MetroFramework.Controls.MetroTextBox()
        Me.lblEstoque = New MetroFramework.Controls.MetroLabel()
        Me.txtPrecoVenda = New MetroFramework.Controls.MetroTextBox()
        Me.PrecoVenda = New MetroFramework.Controls.MetroLabel()
        Me.txtPrecoCusto = New MetroFramework.Controls.MetroTextBox()
        Me.lblPrecoCusto = New MetroFramework.Controls.MetroLabel()
        Me.txtCodBarras = New MetroFramework.Controls.MetroTextBox()
        Me.lblCodBarras = New MetroFramework.Controls.MetroLabel()
        Me.txtDescricao = New MetroFramework.Controls.MetroTextBox()
        Me.lblDescricao = New MetroFramework.Controls.MetroLabel()
        Me.txtCodigo = New MetroFramework.Controls.MetroTextBox()
        Me.lblCodigo = New MetroFramework.Controls.MetroLabel()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btsalvar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Product_64px
        Me.PictureBox1.Location = New System.Drawing.Point(129, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'txtEstoque
        '
        '
        '
        '
        Me.txtEstoque.CustomButton.Image = Nothing
        Me.txtEstoque.CustomButton.Location = New System.Drawing.Point(121, 1)
        Me.txtEstoque.CustomButton.Name = ""
        Me.txtEstoque.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtEstoque.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEstoque.CustomButton.TabIndex = 1
        Me.txtEstoque.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEstoque.CustomButton.UseSelectable = True
        Me.txtEstoque.CustomButton.Visible = False
        Me.txtEstoque.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtEstoque.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txtEstoque.Lines = New String(-1) {}
        Me.txtEstoque.Location = New System.Drawing.Point(33, 361)
        Me.txtEstoque.MaxLength = 5
        Me.txtEstoque.Name = "txtEstoque"
        Me.txtEstoque.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEstoque.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEstoque.SelectedText = ""
        Me.txtEstoque.SelectionLength = 0
        Me.txtEstoque.SelectionStart = 0
        Me.txtEstoque.ShortcutsEnabled = True
        Me.txtEstoque.Size = New System.Drawing.Size(149, 29)
        Me.txtEstoque.TabIndex = 5
        Me.txtEstoque.UseSelectable = True
        Me.txtEstoque.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEstoque.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblEstoque
        '
        Me.lblEstoque.AutoSize = True
        Me.lblEstoque.Location = New System.Drawing.Point(32, 333)
        Me.lblEstoque.Name = "lblEstoque"
        Me.lblEstoque.Size = New System.Drawing.Size(55, 19)
        Me.lblEstoque.TabIndex = 55
        Me.lblEstoque.Text = "Estoque"
        '
        'txtPrecoVenda
        '
        '
        '
        '
        Me.txtPrecoVenda.CustomButton.Image = Nothing
        Me.txtPrecoVenda.CustomButton.Location = New System.Drawing.Point(122, 1)
        Me.txtPrecoVenda.CustomButton.Name = ""
        Me.txtPrecoVenda.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtPrecoVenda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrecoVenda.CustomButton.TabIndex = 1
        Me.txtPrecoVenda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrecoVenda.CustomButton.UseSelectable = True
        Me.txtPrecoVenda.CustomButton.Visible = False
        Me.txtPrecoVenda.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPrecoVenda.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txtPrecoVenda.Lines = New String(-1) {}
        Me.txtPrecoVenda.Location = New System.Drawing.Point(230, 301)
        Me.txtPrecoVenda.MaxLength = 5
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecoVenda.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecoVenda.SelectedText = ""
        Me.txtPrecoVenda.SelectionLength = 0
        Me.txtPrecoVenda.SelectionStart = 0
        Me.txtPrecoVenda.ShortcutsEnabled = True
        Me.txtPrecoVenda.Size = New System.Drawing.Size(150, 29)
        Me.txtPrecoVenda.TabIndex = 4
        Me.txtPrecoVenda.UseSelectable = True
        Me.txtPrecoVenda.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrecoVenda.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PrecoVenda
        '
        Me.PrecoVenda.AutoSize = True
        Me.PrecoVenda.Location = New System.Drawing.Point(230, 273)
        Me.PrecoVenda.Name = "PrecoVenda"
        Me.PrecoVenda.Size = New System.Drawing.Size(83, 19)
        Me.PrecoVenda.TabIndex = 53
        Me.PrecoVenda.Text = "Preço Venda"
        '
        'txtPrecoCusto
        '
        '
        '
        '
        Me.txtPrecoCusto.CustomButton.Image = Nothing
        Me.txtPrecoCusto.CustomButton.Location = New System.Drawing.Point(122, 1)
        Me.txtPrecoCusto.CustomButton.Name = ""
        Me.txtPrecoCusto.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtPrecoCusto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrecoCusto.CustomButton.TabIndex = 1
        Me.txtPrecoCusto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrecoCusto.CustomButton.UseSelectable = True
        Me.txtPrecoCusto.CustomButton.Visible = False
        Me.txtPrecoCusto.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPrecoCusto.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txtPrecoCusto.Lines = New String(-1) {}
        Me.txtPrecoCusto.Location = New System.Drawing.Point(32, 301)
        Me.txtPrecoCusto.MaxLength = 5
        Me.txtPrecoCusto.Name = "txtPrecoCusto"
        Me.txtPrecoCusto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecoCusto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecoCusto.SelectedText = ""
        Me.txtPrecoCusto.SelectionLength = 0
        Me.txtPrecoCusto.SelectionStart = 0
        Me.txtPrecoCusto.ShortcutsEnabled = True
        Me.txtPrecoCusto.Size = New System.Drawing.Size(150, 29)
        Me.txtPrecoCusto.TabIndex = 3
        Me.txtPrecoCusto.UseSelectable = True
        Me.txtPrecoCusto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrecoCusto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblPrecoCusto
        '
        Me.lblPrecoCusto.AutoSize = True
        Me.lblPrecoCusto.Location = New System.Drawing.Point(31, 273)
        Me.lblPrecoCusto.Name = "lblPrecoCusto"
        Me.lblPrecoCusto.Size = New System.Drawing.Size(80, 19)
        Me.lblPrecoCusto.TabIndex = 51
        Me.lblPrecoCusto.Text = "Preço Custo"
        '
        'txtCodBarras
        '
        '
        '
        '
        Me.txtCodBarras.CustomButton.Image = Nothing
        Me.txtCodBarras.CustomButton.Location = New System.Drawing.Point(319, 1)
        Me.txtCodBarras.CustomButton.Name = ""
        Me.txtCodBarras.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtCodBarras.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodBarras.CustomButton.TabIndex = 1
        Me.txtCodBarras.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodBarras.CustomButton.UseSelectable = True
        Me.txtCodBarras.CustomButton.Visible = False
        Me.txtCodBarras.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtCodBarras.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txtCodBarras.Lines = New String(-1) {}
        Me.txtCodBarras.Location = New System.Drawing.Point(33, 174)
        Me.txtCodBarras.MaxLength = 5
        Me.txtCodBarras.Name = "txtCodBarras"
        Me.txtCodBarras.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodBarras.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodBarras.SelectedText = ""
        Me.txtCodBarras.SelectionLength = 0
        Me.txtCodBarras.SelectionStart = 0
        Me.txtCodBarras.ShortcutsEnabled = True
        Me.txtCodBarras.Size = New System.Drawing.Size(347, 29)
        Me.txtCodBarras.TabIndex = 1
        Me.txtCodBarras.UseSelectable = True
        Me.txtCodBarras.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodBarras.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblCodBarras
        '
        Me.lblCodBarras.AutoSize = True
        Me.lblCodBarras.Location = New System.Drawing.Point(33, 146)
        Me.lblCodBarras.Name = "lblCodBarras"
        Me.lblCodBarras.Size = New System.Drawing.Size(113, 19)
        Me.lblCodBarras.TabIndex = 49
        Me.lblCodBarras.Text = "Código de Barras"
        '
        'txtDescricao
        '
        '
        '
        '
        Me.txtDescricao.CustomButton.Image = Nothing
        Me.txtDescricao.CustomButton.Location = New System.Drawing.Point(319, 1)
        Me.txtDescricao.CustomButton.Name = ""
        Me.txtDescricao.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDescricao.CustomButton.TabIndex = 1
        Me.txtDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDescricao.CustomButton.UseSelectable = True
        Me.txtDescricao.CustomButton.Visible = False
        Me.txtDescricao.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtDescricao.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txtDescricao.Lines = New String(-1) {}
        Me.txtDescricao.Location = New System.Drawing.Point(33, 234)
        Me.txtDescricao.MaxLength = 50
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescricao.SelectedText = ""
        Me.txtDescricao.SelectionLength = 0
        Me.txtDescricao.SelectionStart = 0
        Me.txtDescricao.ShortcutsEnabled = True
        Me.txtDescricao.Size = New System.Drawing.Size(347, 29)
        Me.txtDescricao.TabIndex = 2
        Me.txtDescricao.UseSelectable = True
        Me.txtDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDescricao.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(32, 206)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(65, 19)
        Me.lblDescricao.TabIndex = 47
        Me.lblDescricao.Text = "Descrição"
        '
        'txtCodigo
        '
        '
        '
        '
        Me.txtCodigo.CustomButton.Image = Nothing
        Me.txtCodigo.CustomButton.Location = New System.Drawing.Point(226, 1)
        Me.txtCodigo.CustomButton.Name = ""
        Me.txtCodigo.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodigo.CustomButton.TabIndex = 1
        Me.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodigo.CustomButton.UseSelectable = True
        Me.txtCodigo.CustomButton.Visible = False
        Me.txtCodigo.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtCodigo.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txtCodigo.Lines = New String(-1) {}
        Me.txtCodigo.Location = New System.Drawing.Point(33, 113)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodigo.SelectedText = ""
        Me.txtCodigo.SelectionLength = 0
        Me.txtCodigo.SelectionStart = 0
        Me.txtCodigo.ShortcutsEnabled = True
        Me.txtCodigo.Size = New System.Drawing.Size(254, 29)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.UseSelectable = True
        Me.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodigo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(32, 85)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(53, 19)
        Me.lblCodigo.TabIndex = 45
        Me.lblCodigo.Text = "Código"
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Cancel_32px_1
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(251, 414)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(129, 45)
        Me.btnExcluir.TabIndex = 7
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btsalvar
        '
        Me.btsalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btsalvar.FlatAppearance.BorderSize = 0
        Me.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btsalvar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsalvar.ForeColor = System.Drawing.Color.White
        Me.btsalvar.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Save_32px_1
        Me.btsalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btsalvar.Location = New System.Drawing.Point(33, 414)
        Me.btsalvar.Name = "btsalvar"
        Me.btsalvar.Size = New System.Drawing.Size(129, 45)
        Me.btsalvar.TabIndex = 6
        Me.btsalvar.Text = "Salvar"
        Me.btsalvar.UseVisualStyleBackColor = False
        '
        'frmProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 498)
        Me.Controls.Add(Me.btsalvar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.txtEstoque)
        Me.Controls.Add(Me.lblEstoque)
        Me.Controls.Add(Me.txtPrecoVenda)
        Me.Controls.Add(Me.PrecoVenda)
        Me.Controls.Add(Me.txtPrecoCusto)
        Me.Controls.Add(Me.lblPrecoCusto)
        Me.Controls.Add(Me.txtCodBarras)
        Me.Controls.Add(Me.lblCodBarras)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.lblDescricao)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.PictureBox1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmProduto"
        Me.Style = MetroFramework.MetroColorStyle.Lime
        Me.Text = "Produto"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtEstoque As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblEstoque As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPrecoVenda As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PrecoVenda As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPrecoCusto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblPrecoCusto As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCodBarras As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCodBarras As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDescricao As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblDescricao As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCodigo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCodigo As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btsalvar As Button
End Class
