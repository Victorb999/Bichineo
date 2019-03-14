<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServico))
        Me.txtDescricao = New MetroFramework.Controls.MetroTextBox()
        Me.lblNome = New MetroFramework.Controls.MetroLabel()
        Me.txtCodigo = New MetroFramework.Controls.MetroTextBox()
        Me.lblCodigo = New MetroFramework.Controls.MetroLabel()
        Me.lblObs = New MetroFramework.Controls.MetroLabel()
        Me.txtObservacao = New MetroFramework.Controls.MetroTextBox()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btsalvar = New System.Windows.Forms.Button()
        Me.lblPreco = New MetroFramework.Controls.MetroLabel()
        Me.txtPreco = New MetroFramework.Controls.MetroTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescricao
        '
        '
        '
        '
        Me.txtDescricao.CustomButton.Image = Nothing
        Me.txtDescricao.CustomButton.Location = New System.Drawing.Point(262, 1)
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
        Me.txtDescricao.Location = New System.Drawing.Point(23, 159)
        Me.txtDescricao.MaxLength = 50
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescricao.SelectedText = ""
        Me.txtDescricao.SelectionLength = 0
        Me.txtDescricao.SelectionStart = 0
        Me.txtDescricao.ShortcutsEnabled = True
        Me.txtDescricao.Size = New System.Drawing.Size(290, 29)
        Me.txtDescricao.TabIndex = 1
        Me.txtDescricao.UseSelectable = True
        Me.txtDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDescricao.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(23, 137)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(65, 19)
        Me.lblNome.TabIndex = 7
        Me.lblNome.Text = "Descrição"
        '
        'txtCodigo
        '
        '
        '
        '
        Me.txtCodigo.CustomButton.Image = Nothing
        Me.txtCodigo.CustomButton.Location = New System.Drawing.Point(135, 1)
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
        Me.txtCodigo.Location = New System.Drawing.Point(23, 105)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodigo.SelectedText = ""
        Me.txtCodigo.SelectionLength = 0
        Me.txtCodigo.SelectionStart = 0
        Me.txtCodigo.ShortcutsEnabled = True
        Me.txtCodigo.Size = New System.Drawing.Size(163, 29)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.UseSelectable = True
        Me.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodigo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(23, 83)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(53, 19)
        Me.lblCodigo.TabIndex = 5
        Me.lblCodigo.Text = "Código"
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Location = New System.Drawing.Point(23, 245)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(33, 19)
        Me.lblObs.TabIndex = 7
        Me.lblObs.Text = "Obs"
        '
        'txtObservacao
        '
        '
        '
        '
        Me.txtObservacao.CustomButton.Image = Nothing
        Me.txtObservacao.CustomButton.Location = New System.Drawing.Point(212, 1)
        Me.txtObservacao.CustomButton.Name = ""
        Me.txtObservacao.CustomButton.Size = New System.Drawing.Size(77, 77)
        Me.txtObservacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtObservacao.CustomButton.TabIndex = 1
        Me.txtObservacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtObservacao.CustomButton.UseSelectable = True
        Me.txtObservacao.CustomButton.Visible = False
        Me.txtObservacao.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtObservacao.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txtObservacao.Lines = New String(-1) {}
        Me.txtObservacao.Location = New System.Drawing.Point(23, 272)
        Me.txtObservacao.MaxLength = 50
        Me.txtObservacao.Multiline = True
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtObservacao.SelectedText = ""
        Me.txtObservacao.SelectionLength = 0
        Me.txtObservacao.SelectionStart = 0
        Me.txtObservacao.ShortcutsEnabled = True
        Me.txtObservacao.Size = New System.Drawing.Size(290, 79)
        Me.txtObservacao.TabIndex = 3
        Me.txtObservacao.UseSelectable = True
        Me.txtObservacao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtObservacao.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Green
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
        Me.btnExcluir.Location = New System.Drawing.Point(184, 395)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(129, 45)
        Me.btnExcluir.TabIndex = 5
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
        Me.btsalvar.Location = New System.Drawing.Point(23, 395)
        Me.btsalvar.Name = "btsalvar"
        Me.btsalvar.Size = New System.Drawing.Size(129, 45)
        Me.btsalvar.TabIndex = 4
        Me.btsalvar.Text = "Salvar"
        Me.btsalvar.UseVisualStyleBackColor = False
        '
        'lblPreco
        '
        Me.lblPreco.AutoSize = True
        Me.lblPreco.Location = New System.Drawing.Point(23, 191)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(43, 19)
        Me.lblPreco.TabIndex = 51
        Me.lblPreco.Text = "Preço"
        '
        'txtPreco
        '
        '
        '
        '
        Me.txtPreco.CustomButton.Image = Nothing
        Me.txtPreco.CustomButton.Location = New System.Drawing.Point(147, 1)
        Me.txtPreco.CustomButton.Name = ""
        Me.txtPreco.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtPreco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPreco.CustomButton.TabIndex = 1
        Me.txtPreco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPreco.CustomButton.UseSelectable = True
        Me.txtPreco.CustomButton.Visible = False
        Me.txtPreco.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPreco.Lines = New String(-1) {}
        Me.txtPreco.Location = New System.Drawing.Point(23, 213)
        Me.txtPreco.MaxLength = 5
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPreco.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPreco.SelectedText = ""
        Me.txtPreco.SelectionLength = 0
        Me.txtPreco.SelectionStart = 0
        Me.txtPreco.ShortcutsEnabled = True
        Me.txtPreco.Size = New System.Drawing.Size(175, 29)
        Me.txtPreco.TabIndex = 2
        Me.txtPreco.UseSelectable = True
        Me.txtPreco.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPreco.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Syringe_64px_1
        Me.PictureBox2.Location = New System.Drawing.Point(107, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'frmServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 463)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btsalvar)
        Me.Controls.Add(Me.txtObservacao)
        Me.Controls.Add(Me.lblObs)
        Me.Controls.Add(Me.txtPreco)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.lblPreco)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Movable = False
        Me.Name = "frmServico"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Serviço"
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDescricao As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblNome As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCodigo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCodigo As MetroFramework.Controls.MetroLabel
    Friend WithEvents btsalvar As Button
    Friend WithEvents lblObs As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtObservacao As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents btnExcluir As Button
    Friend WithEvents txtPreco As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblPreco As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox2 As PictureBox
End Class
