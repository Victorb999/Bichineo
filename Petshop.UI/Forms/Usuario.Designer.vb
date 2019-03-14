<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario
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
        Me.txtNome = New MetroFramework.Controls.MetroTextBox()
        Me.lblSenha = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.lblNome = New MetroFramework.Controls.MetroLabel()
        Me.txtCliente = New MetroFramework.Controls.MetroTextBox()
        Me.lblCodigo = New MetroFramework.Controls.MetroLabel()
        Me.txtConfirm = New MetroFramework.Controls.MetroTextBox()
        Me.lblConfirm = New MetroFramework.Controls.MetroLabel()
        Me.lblNivel = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.btsalvar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.txtNome.Location = New System.Drawing.Point(23, 234)
        Me.txtNome.MaxLength = 50
        Me.txtNome.Name = "txtNome"
        Me.txtNome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNome.SelectedText = ""
        Me.txtNome.SelectionLength = 0
        Me.txtNome.SelectionStart = 0
        Me.txtNome.ShortcutsEnabled = True
        Me.txtNome.Size = New System.Drawing.Size(290, 23)
        Me.txtNome.TabIndex = 24
        Me.txtNome.UseSelectable = True
        Me.txtNome.UseSystemPasswordChar = True
        Me.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNome.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Location = New System.Drawing.Point(23, 207)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(44, 19)
        Me.lblSenha.TabIndex = 23
        Me.lblSenha.Text = "Senha"
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(268, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(23, 176)
        Me.MetroTextBox1.MaxLength = 50
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(290, 23)
        Me.MetroTextBox1.TabIndex = 28
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(23, 149)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(46, 19)
        Me.lblNome.TabIndex = 27
        Me.lblNome.Text = "Nome"
        '
        'txtCliente
        '
        '
        '
        '
        Me.txtCliente.CustomButton.Image = Nothing
        Me.txtCliente.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.txtCliente.CustomButton.Name = ""
        Me.txtCliente.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCliente.CustomButton.TabIndex = 1
        Me.txtCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCliente.CustomButton.UseSelectable = True
        Me.txtCliente.CustomButton.Visible = False
        Me.txtCliente.Lines = New String(-1) {}
        Me.txtCliente.Location = New System.Drawing.Point(23, 118)
        Me.txtCliente.MaxLength = 5
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCliente.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCliente.SelectedText = ""
        Me.txtCliente.SelectionLength = 0
        Me.txtCliente.SelectionStart = 0
        Me.txtCliente.ShortcutsEnabled = True
        Me.txtCliente.Size = New System.Drawing.Size(147, 23)
        Me.txtCliente.TabIndex = 26
        Me.txtCliente.UseSelectable = True
        Me.txtCliente.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCliente.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(23, 91)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(53, 19)
        Me.lblCodigo.TabIndex = 25
        Me.lblCodigo.Text = "Código"
        '
        'txtConfirm
        '
        '
        '
        '
        Me.txtConfirm.CustomButton.Image = Nothing
        Me.txtConfirm.CustomButton.Location = New System.Drawing.Point(268, 1)
        Me.txtConfirm.CustomButton.Name = ""
        Me.txtConfirm.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtConfirm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtConfirm.CustomButton.TabIndex = 1
        Me.txtConfirm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtConfirm.CustomButton.UseSelectable = True
        Me.txtConfirm.CustomButton.Visible = False
        Me.txtConfirm.Lines = New String(-1) {}
        Me.txtConfirm.Location = New System.Drawing.Point(23, 292)
        Me.txtConfirm.MaxLength = 50
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtConfirm.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtConfirm.SelectedText = ""
        Me.txtConfirm.SelectionLength = 0
        Me.txtConfirm.SelectionStart = 0
        Me.txtConfirm.ShortcutsEnabled = True
        Me.txtConfirm.Size = New System.Drawing.Size(290, 23)
        Me.txtConfirm.TabIndex = 30
        Me.txtConfirm.UseSelectable = True
        Me.txtConfirm.UseSystemPasswordChar = True
        Me.txtConfirm.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtConfirm.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Location = New System.Drawing.Point(23, 265)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(108, 19)
        Me.lblConfirm.TabIndex = 29
        Me.lblConfirm.Text = "Confirmar Senha"
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.Location = New System.Drawing.Point(23, 323)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(38, 19)
        Me.lblNivel.TabIndex = 31
        Me.lblNivel.Text = "Nível"
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Location = New System.Drawing.Point(23, 350)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(290, 29)
        Me.MetroComboBox1.TabIndex = 34
        Me.MetroComboBox1.UseSelectable = True
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
        Me.btsalvar.Location = New System.Drawing.Point(184, 417)
        Me.btsalvar.Name = "btsalvar"
        Me.btsalvar.Size = New System.Drawing.Size(129, 45)
        Me.btsalvar.TabIndex = 33
        Me.btsalvar.Text = "Salvar"
        Me.btsalvar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.petshop.UI.My.Resources.Resources.icons8_User_64px_1
        Me.PictureBox1.Location = New System.Drawing.Point(111, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 512)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.btsalvar)
        Me.Controls.Add(Me.lblNivel)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Usuario"
        Me.Style = MetroFramework.MetroColorStyle.Lime
        Me.Text = "Usuário"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtNome As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblSenha As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblNome As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCliente As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCodigo As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtConfirm As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblConfirm As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNivel As MetroFramework.Controls.MetroLabel
    Friend WithEvents btsalvar As Button
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
End Class
