<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagamento
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtComissao = New MetroFramework.Controls.MetroTextBox()
        Me.lblMaxparcelas = New MetroFramework.Controls.MetroLabel()
        Me.btsalvar = New System.Windows.Forms.Button()
        Me.txtDescricao = New MetroFramework.Controls.MetroTextBox()
        Me.txtCodigo = New MetroFramework.Controls.MetroTextBox()
        Me.lblCodigo = New MetroFramework.Controls.MetroLabel()
        Me.lblDescricao = New MetroFramework.Controls.MetroLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Card_Payment_64px
        Me.PictureBox1.Location = New System.Drawing.Point(155, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'txtComissao
        '
        '
        '
        '
        Me.txtComissao.CustomButton.Image = Nothing
        Me.txtComissao.CustomButton.Location = New System.Drawing.Point(141, 1)
        Me.txtComissao.CustomButton.Name = ""
        Me.txtComissao.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtComissao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtComissao.CustomButton.TabIndex = 1
        Me.txtComissao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtComissao.CustomButton.UseSelectable = True
        Me.txtComissao.CustomButton.Visible = False
        Me.txtComissao.Lines = New String(-1) {}
        Me.txtComissao.Location = New System.Drawing.Point(23, 161)
        Me.txtComissao.MaxLength = 5
        Me.txtComissao.Name = "txtComissao"
        Me.txtComissao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComissao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtComissao.SelectedText = ""
        Me.txtComissao.SelectionLength = 0
        Me.txtComissao.SelectionStart = 0
        Me.txtComissao.ShortcutsEnabled = True
        Me.txtComissao.Size = New System.Drawing.Size(163, 23)
        Me.txtComissao.TabIndex = 36
        Me.txtComissao.UseSelectable = True
        Me.txtComissao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtComissao.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblMaxparcelas
        '
        Me.lblMaxparcelas.AutoSize = True
        Me.lblMaxparcelas.Location = New System.Drawing.Point(23, 139)
        Me.lblMaxparcelas.Name = "lblMaxparcelas"
        Me.lblMaxparcelas.Size = New System.Drawing.Size(129, 19)
        Me.lblMaxparcelas.TabIndex = 35
        Me.lblMaxparcelas.Text = "Número de parcelas"
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
        Me.btsalvar.Location = New System.Drawing.Point(183, 288)
        Me.btsalvar.Name = "btsalvar"
        Me.btsalvar.Size = New System.Drawing.Size(129, 45)
        Me.btsalvar.TabIndex = 34
        Me.btsalvar.Text = "Salvar"
        Me.btsalvar.UseVisualStyleBackColor = False
        '
        'txtDescricao
        '
        '
        '
        '
        Me.txtDescricao.CustomButton.Image = Nothing
        Me.txtDescricao.CustomButton.Location = New System.Drawing.Point(268, 1)
        Me.txtDescricao.CustomButton.Name = ""
        Me.txtDescricao.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDescricao.CustomButton.TabIndex = 1
        Me.txtDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDescricao.CustomButton.UseSelectable = True
        Me.txtDescricao.CustomButton.Visible = False
        Me.txtDescricao.Lines = New String(-1) {}
        Me.txtDescricao.Location = New System.Drawing.Point(23, 219)
        Me.txtDescricao.MaxLength = 50
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescricao.SelectedText = ""
        Me.txtDescricao.SelectionLength = 0
        Me.txtDescricao.SelectionStart = 0
        Me.txtDescricao.ShortcutsEnabled = True
        Me.txtDescricao.Size = New System.Drawing.Size(290, 23)
        Me.txtDescricao.TabIndex = 33
        Me.txtDescricao.UseSelectable = True
        Me.txtDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDescricao.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.txtCodigo.Location = New System.Drawing.Point(22, 104)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodigo.SelectedText = ""
        Me.txtCodigo.SelectionLength = 0
        Me.txtCodigo.SelectionStart = 0
        Me.txtCodigo.ShortcutsEnabled = True
        Me.txtCodigo.Size = New System.Drawing.Size(163, 23)
        Me.txtCodigo.TabIndex = 32
        Me.txtCodigo.UseSelectable = True
        Me.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodigo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(18, 82)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(53, 19)
        Me.lblCodigo.TabIndex = 31
        Me.lblCodigo.Text = "Código"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(23, 197)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(65, 19)
        Me.lblDescricao.TabIndex = 38
        Me.lblDescricao.Text = "Descrição"
        '
        'Pagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 386)
        Me.Controls.Add(Me.lblDescricao)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtComissao)
        Me.Controls.Add(Me.lblMaxparcelas)
        Me.Controls.Add(Me.btsalvar)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "Pagamento"
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Pagamento"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtComissao As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblMaxparcelas As MetroFramework.Controls.MetroLabel
    Friend WithEvents btsalvar As Button
    Friend WithEvents txtDescricao As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCodigo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCodigo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDescricao As MetroFramework.Controls.MetroLabel
End Class
