<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.lblCodigo = New MetroFramework.Controls.MetroLabel()
        Me.cboUsuario = New MetroFramework.Controls.MetroComboBox()
        Me.btsalvar = New System.Windows.Forms.Button()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtNome.Location = New System.Drawing.Point(76, 161)
        Me.txtNome.MaxLength = 50
        Me.txtNome.Name = "txtNome"
        Me.txtNome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNome.SelectedText = ""
        Me.txtNome.SelectionLength = 0
        Me.txtNome.SelectionStart = 0
        Me.txtNome.ShortcutsEnabled = True
        Me.txtNome.Size = New System.Drawing.Size(290, 23)
        Me.txtNome.TabIndex = 12
        Me.txtNome.UseSelectable = True
        Me.txtNome.UseSystemPasswordChar = True
        Me.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNome.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Location = New System.Drawing.Point(76, 139)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(44, 19)
        Me.lblSenha.TabIndex = 11
        Me.lblSenha.Text = "Senha"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(76, 71)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(53, 19)
        Me.lblCodigo.TabIndex = 9
        Me.lblCodigo.Text = "Usuário"
        '
        'cboUsuario
        '
        Me.cboUsuario.FormattingEnabled = True
        Me.cboUsuario.ItemHeight = 23
        Me.cboUsuario.Location = New System.Drawing.Point(76, 93)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(290, 29)
        Me.cboUsuario.TabIndex = 13
        Me.cboUsuario.UseSelectable = True
        '
        'btsalvar
        '
        Me.btsalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btsalvar.FlatAppearance.BorderSize = 0
        Me.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btsalvar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsalvar.ForeColor = System.Drawing.Color.White
        Me.btsalvar.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Login_Rounded_Up_32px
        Me.btsalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btsalvar.Location = New System.Drawing.Point(237, 235)
        Me.btsalvar.Name = "btsalvar"
        Me.btsalvar.Size = New System.Drawing.Size(129, 45)
        Me.btsalvar.TabIndex = 21
        Me.btsalvar.Text = "Entrar"
        Me.btsalvar.UseVisualStyleBackColor = False
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.Petshop.UI.My.Resources.Resources.pETSHOW
        Me.pbLogo.Location = New System.Drawing.Point(8, 210)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(121, 105)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 2
        Me.pbLogo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Lock_64px_1
        Me.PictureBox1.Location = New System.Drawing.Point(101, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 322)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btsalvar)
        Me.Controls.Add(Me.cboUsuario)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.pbLogo)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Login"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents txtNome As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblSenha As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCodigo As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboUsuario As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btsalvar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
