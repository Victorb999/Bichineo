<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profissional
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
        Me.btsalvar = New System.Windows.Forms.Button()
        Me.txtNome = New MetroFramework.Controls.MetroTextBox()
        Me.lblNome = New MetroFramework.Controls.MetroLabel()
        Me.txtCodigo = New MetroFramework.Controls.MetroTextBox()
        Me.lblCodigo = New MetroFramework.Controls.MetroLabel()
        Me.txtComissao = New MetroFramework.Controls.MetroTextBox()
        Me.lblComissao = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtFuncao = New MetroFramework.Controls.MetroTextBox()
        Me.lvlFuncao = New MetroFramework.Controls.MetroLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btsalvar.Location = New System.Drawing.Point(183, 319)
        Me.btsalvar.Name = "btsalvar"
        Me.btsalvar.Size = New System.Drawing.Size(129, 45)
        Me.btsalvar.TabIndex = 25
        Me.btsalvar.Text = "Salvar"
        Me.btsalvar.UseVisualStyleBackColor = False
        '
        'txtNome
        '
        '
        '
        '
        Me.txtNome.CustomButton.Image = Nothing
        Me.txtNome.CustomButton.Location = New System.Drawing.Point(268, 1)
        Me.txtNome.CustomButton.Name = ""
        Me.txtNome.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNome.CustomButton.TabIndex = 1
        Me.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNome.CustomButton.UseSelectable = True
        Me.txtNome.CustomButton.Visible = False
        Me.txtNome.Lines = New String(-1) {}
        Me.txtNome.Location = New System.Drawing.Point(22, 174)
        Me.txtNome.MaxLength = 50
        Me.txtNome.Name = "txtNome"
        Me.txtNome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNome.SelectedText = ""
        Me.txtNome.SelectionLength = 0
        Me.txtNome.SelectionStart = 0
        Me.txtNome.ShortcutsEnabled = True
        Me.txtNome.Size = New System.Drawing.Size(290, 23)
        Me.txtNome.TabIndex = 24
        Me.txtNome.UseSelectable = True
        Me.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNome.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(23, 152)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(46, 19)
        Me.lblNome.TabIndex = 23
        Me.lblNome.Text = "Nome"
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
        Me.txtCodigo.Location = New System.Drawing.Point(22, 105)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodigo.SelectedText = ""
        Me.txtCodigo.SelectionLength = 0
        Me.txtCodigo.SelectionStart = 0
        Me.txtCodigo.ShortcutsEnabled = True
        Me.txtCodigo.Size = New System.Drawing.Size(163, 23)
        Me.txtCodigo.TabIndex = 22
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
        Me.lblCodigo.TabIndex = 21
        Me.lblCodigo.Text = "Código"
        '
        'txtComissao
        '
        '
        '
        '
        Me.txtComissao.CustomButton.Image = Nothing
        Me.txtComissao.CustomButton.Location = New System.Drawing.Point(84, 1)
        Me.txtComissao.CustomButton.Name = ""
        Me.txtComissao.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtComissao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtComissao.CustomButton.TabIndex = 1
        Me.txtComissao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtComissao.CustomButton.UseSelectable = True
        Me.txtComissao.CustomButton.Visible = False
        Me.txtComissao.Lines = New String(-1) {}
        Me.txtComissao.Location = New System.Drawing.Point(206, 247)
        Me.txtComissao.MaxLength = 5
        Me.txtComissao.Name = "txtComissao"
        Me.txtComissao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComissao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtComissao.SelectedText = ""
        Me.txtComissao.SelectionLength = 0
        Me.txtComissao.SelectionStart = 0
        Me.txtComissao.ShortcutsEnabled = True
        Me.txtComissao.Size = New System.Drawing.Size(106, 23)
        Me.txtComissao.TabIndex = 27
        Me.txtComissao.UseSelectable = True
        Me.txtComissao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtComissao.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblComissao
        '
        Me.lblComissao.AutoSize = True
        Me.lblComissao.Location = New System.Drawing.Point(207, 225)
        Me.lblComissao.Name = "lblComissao"
        Me.lblComissao.Size = New System.Drawing.Size(66, 19)
        Me.lblComissao.TabIndex = 26
        Me.lblComissao.Text = "Comissão"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Management_64px
        Me.PictureBox1.Location = New System.Drawing.Point(145, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'txtFuncao
        '
        '
        '
        '
        Me.txtFuncao.CustomButton.Image = Nothing
        Me.txtFuncao.CustomButton.Location = New System.Drawing.Point(140, 1)
        Me.txtFuncao.CustomButton.Name = ""
        Me.txtFuncao.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFuncao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFuncao.CustomButton.TabIndex = 1
        Me.txtFuncao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFuncao.CustomButton.UseSelectable = True
        Me.txtFuncao.CustomButton.Visible = False
        Me.txtFuncao.Lines = New String(-1) {}
        Me.txtFuncao.Location = New System.Drawing.Point(23, 247)
        Me.txtFuncao.MaxLength = 5
        Me.txtFuncao.Name = "txtFuncao"
        Me.txtFuncao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFuncao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFuncao.SelectedText = ""
        Me.txtFuncao.SelectionLength = 0
        Me.txtFuncao.SelectionStart = 0
        Me.txtFuncao.ShortcutsEnabled = True
        Me.txtFuncao.Size = New System.Drawing.Size(162, 23)
        Me.txtFuncao.TabIndex = 30
        Me.txtFuncao.UseSelectable = True
        Me.txtFuncao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFuncao.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lvlFuncao
        '
        Me.lvlFuncao.AutoSize = True
        Me.lvlFuncao.Location = New System.Drawing.Point(24, 225)
        Me.lvlFuncao.Name = "lvlFuncao"
        Me.lvlFuncao.Size = New System.Drawing.Size(51, 19)
        Me.lvlFuncao.TabIndex = 29
        Me.lvlFuncao.Text = "Função"
        '
        'Profissional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 400)
        Me.Controls.Add(Me.txtFuncao)
        Me.Controls.Add(Me.lvlFuncao)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtComissao)
        Me.Controls.Add(Me.lblComissao)
        Me.Controls.Add(Me.btsalvar)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "Profissional"
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Profissional"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btsalvar As Button
    Friend WithEvents txtNome As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblNome As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCodigo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCodigo As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtComissao As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblComissao As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtFuncao As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lvlFuncao As MetroFramework.Controls.MetroLabel
End Class
