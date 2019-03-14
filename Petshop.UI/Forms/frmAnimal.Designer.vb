<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnimal
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnimal))
      Me.txtNome = New MetroFramework.Controls.MetroTextBox()
      Me.lblNome = New MetroFramework.Controls.MetroLabel()
      Me.txtCodigo = New MetroFramework.Controls.MetroTextBox()
      Me.lblCodigo = New MetroFramework.Controls.MetroLabel()
      Me.lblEspecie = New MetroFramework.Controls.MetroLabel()
      Me.cboEspecie = New MetroFramework.Controls.MetroComboBox()
      Me.btnAddEspecie = New System.Windows.Forms.Button()
      Me.btnAddRaca = New System.Windows.Forms.Button()
      Me.cboRaca = New MetroFramework.Controls.MetroComboBox()
      Me.lblRaca = New MetroFramework.Controls.MetroLabel()
      Me.lblObservacao = New MetroFramework.Controls.MetroLabel()
      Me.txtObservacao = New MetroFramework.Controls.MetroTextBox()
      Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
      Me.mdtDtNascimento = New MetroFramework.Controls.MetroDateTime()
      Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
      Me.cboSexo = New MetroFramework.Controls.MetroComboBox()
      Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
      Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
      Me.cboCliente = New MetroFramework.Controls.MetroComboBox()
      Me.btnProcurar = New System.Windows.Forms.Button()
      Me.btnExcluir = New System.Windows.Forms.Button()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.btsalvar = New System.Windows.Forms.Button()
      Me.txtRacao = New MetroFramework.Controls.MetroTextBox()
      Me.lblRacao = New MetroFramework.Controls.MetroLabel()
      CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'txtNome
      '
      '
      '
      '
      Me.txtNome.CustomButton.Image = Nothing
      Me.txtNome.CustomButton.Location = New System.Drawing.Point(277, 1)
      Me.txtNome.CustomButton.Name = ""
      Me.txtNome.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtNome.CustomButton.TabIndex = 1
      Me.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtNome.CustomButton.UseSelectable = True
      Me.txtNome.CustomButton.Visible = False
      Me.txtNome.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtNome.Lines = New String(-1) {}
      Me.txtNome.Location = New System.Drawing.Point(22, 161)
      Me.txtNome.MaxLength = 50
      Me.txtNome.Name = "txtNome"
      Me.txtNome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtNome.SelectedText = ""
      Me.txtNome.SelectionLength = 0
      Me.txtNome.SelectionStart = 0
      Me.txtNome.ShortcutsEnabled = True
      Me.txtNome.Size = New System.Drawing.Size(305, 29)
      Me.txtNome.TabIndex = 1
      Me.txtNome.UseSelectable = True
      Me.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtNome.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'lblNome
      '
      Me.lblNome.AutoSize = True
      Me.lblNome.Location = New System.Drawing.Point(22, 139)
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
      Me.txtCodigo.CustomButton.Location = New System.Drawing.Point(135, 1)
      Me.txtCodigo.CustomButton.Name = ""
      Me.txtCodigo.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtCodigo.CustomButton.TabIndex = 1
      Me.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtCodigo.CustomButton.UseSelectable = True
      Me.txtCodigo.CustomButton.Visible = False
      Me.txtCodigo.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtCodigo.Lines = New String(-1) {}
      Me.txtCodigo.Location = New System.Drawing.Point(22, 109)
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
      Me.lblCodigo.Location = New System.Drawing.Point(22, 87)
      Me.lblCodigo.Name = "lblCodigo"
      Me.lblCodigo.Size = New System.Drawing.Size(53, 19)
      Me.lblCodigo.TabIndex = 21
      Me.lblCodigo.Text = "Código"
      '
      'lblEspecie
      '
      Me.lblEspecie.AutoSize = True
      Me.lblEspecie.Location = New System.Drawing.Point(22, 308)
      Me.lblEspecie.Name = "lblEspecie"
      Me.lblEspecie.Size = New System.Drawing.Size(52, 19)
      Me.lblEspecie.TabIndex = 26
      Me.lblEspecie.Text = "Espécie"
      '
      'cboEspecie
      '
      Me.cboEspecie.FormattingEnabled = True
      Me.cboEspecie.ItemHeight = 23
      Me.cboEspecie.Location = New System.Drawing.Point(22, 330)
      Me.cboEspecie.Name = "cboEspecie"
      Me.cboEspecie.Size = New System.Drawing.Size(147, 29)
      Me.cboEspecie.TabIndex = 5
      Me.cboEspecie.UseSelectable = True
      '
      'btnAddEspecie
      '
      Me.btnAddEspecie.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
      Me.btnAddEspecie.FlatAppearance.BorderSize = 0
      Me.btnAddEspecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.btnAddEspecie.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnAddEspecie.ForeColor = System.Drawing.Color.White
      Me.btnAddEspecie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnAddEspecie.Location = New System.Drawing.Point(189, 330)
      Me.btnAddEspecie.Name = "btnAddEspecie"
      Me.btnAddEspecie.Size = New System.Drawing.Size(138, 29)
      Me.btnAddEspecie.TabIndex = 10
      Me.btnAddEspecie.Text = "F2 - Add Espécie"
      Me.btnAddEspecie.UseVisualStyleBackColor = False
      '
      'btnAddRaca
      '
      Me.btnAddRaca.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
      Me.btnAddRaca.FlatAppearance.BorderSize = 0
      Me.btnAddRaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.btnAddRaca.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnAddRaca.ForeColor = System.Drawing.Color.White
      Me.btnAddRaca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnAddRaca.Location = New System.Drawing.Point(189, 388)
      Me.btnAddRaca.Name = "btnAddRaca"
      Me.btnAddRaca.Size = New System.Drawing.Size(138, 29)
      Me.btnAddRaca.TabIndex = 11
      Me.btnAddRaca.Text = "F3 - Add Raça"
      Me.btnAddRaca.UseVisualStyleBackColor = False
      '
      'cboRaca
      '
      Me.cboRaca.FormattingEnabled = True
      Me.cboRaca.ItemHeight = 23
      Me.cboRaca.Location = New System.Drawing.Point(22, 388)
      Me.cboRaca.Name = "cboRaca"
      Me.cboRaca.Size = New System.Drawing.Size(147, 29)
      Me.cboRaca.TabIndex = 6
      Me.cboRaca.UseSelectable = True
      '
      'lblRaca
      '
      Me.lblRaca.AutoSize = True
      Me.lblRaca.Location = New System.Drawing.Point(23, 364)
      Me.lblRaca.Name = "lblRaca"
      Me.lblRaca.Size = New System.Drawing.Size(37, 19)
      Me.lblRaca.TabIndex = 30
      Me.lblRaca.Text = "Raça"
      '
      'lblObservacao
      '
      Me.lblObservacao.AutoSize = True
      Me.lblObservacao.Location = New System.Drawing.Point(22, 499)
      Me.lblObservacao.Name = "lblObservacao"
      Me.lblObservacao.Size = New System.Drawing.Size(79, 19)
      Me.lblObservacao.TabIndex = 33
      Me.lblObservacao.Text = "Observação"
      '
      'txtObservacao
      '
      '
      '
      '
      Me.txtObservacao.CustomButton.Image = Nothing
      Me.txtObservacao.CustomButton.Location = New System.Drawing.Point(221, 2)
      Me.txtObservacao.CustomButton.Name = ""
      Me.txtObservacao.CustomButton.Size = New System.Drawing.Size(81, 81)
      Me.txtObservacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtObservacao.CustomButton.TabIndex = 1
      Me.txtObservacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtObservacao.CustomButton.UseSelectable = True
      Me.txtObservacao.CustomButton.Visible = False
      Me.txtObservacao.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtObservacao.Lines = New String(-1) {}
      Me.txtObservacao.Location = New System.Drawing.Point(22, 521)
      Me.txtObservacao.MaxLength = 50
      Me.txtObservacao.Multiline = True
      Me.txtObservacao.Name = "txtObservacao"
      Me.txtObservacao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtObservacao.SelectedText = ""
      Me.txtObservacao.SelectionLength = 0
      Me.txtObservacao.SelectionStart = 0
      Me.txtObservacao.ShortcutsEnabled = True
      Me.txtObservacao.Size = New System.Drawing.Size(305, 86)
      Me.txtObservacao.TabIndex = 8
      Me.txtObservacao.UseSelectable = True
      Me.txtObservacao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtObservacao.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'MetroStyleManager1
      '
      Me.MetroStyleManager1.Owner = Me
      Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Green
      '
      'mdtDtNascimento
      '
      Me.mdtDtNascimento.FontWeight = MetroFramework.MetroDateTimeWeight.Light
      Me.mdtDtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.mdtDtNascimento.Location = New System.Drawing.Point(22, 276)
      Me.mdtDtNascimento.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
      Me.mdtDtNascimento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
      Me.mdtDtNascimento.MinimumSize = New System.Drawing.Size(0, 29)
      Me.mdtDtNascimento.Name = "mdtDtNascimento"
      Me.mdtDtNascimento.Size = New System.Drawing.Size(147, 29)
      Me.mdtDtNascimento.TabIndex = 3
      '
      'MetroLabel1
      '
      Me.MetroLabel1.AutoSize = True
      Me.MetroLabel1.Location = New System.Drawing.Point(22, 254)
      Me.MetroLabel1.Name = "MetroLabel1"
      Me.MetroLabel1.Size = New System.Drawing.Size(109, 19)
      Me.MetroLabel1.TabIndex = 36
      Me.MetroLabel1.Text = "Data Nascimento"
      '
      'cboSexo
      '
      Me.cboSexo.FormattingEnabled = True
      Me.cboSexo.ItemHeight = 23
      Me.cboSexo.Items.AddRange(New Object() {"Feminino", "Masculino"})
      Me.cboSexo.Location = New System.Drawing.Point(189, 276)
      Me.cboSexo.Name = "cboSexo"
      Me.cboSexo.Size = New System.Drawing.Size(138, 29)
      Me.cboSexo.TabIndex = 4
      Me.cboSexo.UseSelectable = True
      '
      'MetroLabel4
      '
      Me.MetroLabel4.AutoSize = True
      Me.MetroLabel4.Location = New System.Drawing.Point(179, 254)
      Me.MetroLabel4.Name = "MetroLabel4"
      Me.MetroLabel4.Size = New System.Drawing.Size(37, 19)
      Me.MetroLabel4.TabIndex = 38
      Me.MetroLabel4.Text = "Sexo"
      '
      'MetroLabel2
      '
      Me.MetroLabel2.AutoSize = True
      Me.MetroLabel2.Location = New System.Drawing.Point(22, 193)
      Me.MetroLabel2.Name = "MetroLabel2"
      Me.MetroLabel2.Size = New System.Drawing.Size(49, 19)
      Me.MetroLabel2.TabIndex = 21
      Me.MetroLabel2.Text = "Cliente"
      '
      'cboCliente
      '
      Me.cboCliente.FormattingEnabled = True
      Me.cboCliente.ItemHeight = 23
      Me.cboCliente.Items.AddRange(New Object() {"Feminino", "Masculino"})
      Me.cboCliente.Location = New System.Drawing.Point(22, 215)
      Me.cboCliente.Name = "cboCliente"
      Me.cboCliente.Size = New System.Drawing.Size(274, 29)
      Me.cboCliente.TabIndex = 2
      Me.cboCliente.UseSelectable = True
      '
      'btnProcurar
      '
      Me.btnProcurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
      Me.btnProcurar.FlatAppearance.BorderSize = 0
      Me.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.btnProcurar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnProcurar.ForeColor = System.Drawing.Color.White
      Me.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnProcurar.Location = New System.Drawing.Point(302, 215)
      Me.btnProcurar.Name = "btnProcurar"
      Me.btnProcurar.Size = New System.Drawing.Size(25, 29)
      Me.btnProcurar.TabIndex = 13
      Me.btnProcurar.Text = "..."
      Me.btnProcurar.UseVisualStyleBackColor = False
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
      Me.btnExcluir.Location = New System.Drawing.Point(198, 620)
      Me.btnExcluir.Name = "btnExcluir"
      Me.btnExcluir.Size = New System.Drawing.Size(129, 45)
      Me.btnExcluir.TabIndex = 12
      Me.btnExcluir.Text = "Excluir"
      Me.btnExcluir.UseVisualStyleBackColor = False
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Cat_Footprint_64px
      Me.PictureBox1.Location = New System.Drawing.Point(96, 6)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(90, 62)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.PictureBox1.TabIndex = 29
      Me.PictureBox1.TabStop = False
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
      Me.btsalvar.Location = New System.Drawing.Point(23, 620)
      Me.btsalvar.Name = "btsalvar"
      Me.btsalvar.Size = New System.Drawing.Size(129, 45)
      Me.btsalvar.TabIndex = 9
      Me.btsalvar.Text = "Salvar"
      Me.btsalvar.UseVisualStyleBackColor = False
      '
      'txtRacao
      '
      '
      '
      '
      Me.txtRacao.CustomButton.Image = Nothing
      Me.txtRacao.CustomButton.Location = New System.Drawing.Point(277, 1)
      Me.txtRacao.CustomButton.Name = ""
      Me.txtRacao.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.txtRacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtRacao.CustomButton.TabIndex = 1
      Me.txtRacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtRacao.CustomButton.UseSelectable = True
      Me.txtRacao.CustomButton.Visible = False
      Me.txtRacao.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtRacao.Lines = New String(-1) {}
      Me.txtRacao.Location = New System.Drawing.Point(23, 451)
      Me.txtRacao.MaxLength = 50
      Me.txtRacao.Name = "txtRacao"
      Me.txtRacao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtRacao.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtRacao.SelectedText = ""
      Me.txtRacao.SelectionLength = 0
      Me.txtRacao.SelectionStart = 0
      Me.txtRacao.ShortcutsEnabled = True
      Me.txtRacao.Size = New System.Drawing.Size(305, 29)
      Me.txtRacao.TabIndex = 7
      Me.txtRacao.UseSelectable = True
      Me.txtRacao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtRacao.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'lblRacao
      '
      Me.lblRacao.AutoSize = True
      Me.lblRacao.Location = New System.Drawing.Point(23, 429)
      Me.lblRacao.Name = "lblRacao"
      Me.lblRacao.Size = New System.Drawing.Size(45, 19)
      Me.lblRacao.TabIndex = 40
      Me.lblRacao.Text = "Ração"
      '
      'frmAnimal
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(350, 697)
      Me.Controls.Add(Me.txtRacao)
      Me.Controls.Add(Me.lblRacao)
      Me.Controls.Add(Me.btnExcluir)
      Me.Controls.Add(Me.cboCliente)
      Me.Controls.Add(Me.cboSexo)
      Me.Controls.Add(Me.MetroLabel4)
      Me.Controls.Add(Me.MetroLabel1)
      Me.Controls.Add(Me.mdtDtNascimento)
      Me.Controls.Add(Me.txtObservacao)
      Me.Controls.Add(Me.lblObservacao)
      Me.Controls.Add(Me.btnAddRaca)
      Me.Controls.Add(Me.cboRaca)
      Me.Controls.Add(Me.lblRaca)
      Me.Controls.Add(Me.PictureBox1)
      Me.Controls.Add(Me.btnProcurar)
      Me.Controls.Add(Me.btnAddEspecie)
      Me.Controls.Add(Me.cboEspecie)
      Me.Controls.Add(Me.lblEspecie)
      Me.Controls.Add(Me.btsalvar)
      Me.Controls.Add(Me.txtNome)
      Me.Controls.Add(Me.lblNome)
      Me.Controls.Add(Me.txtCodigo)
      Me.Controls.Add(Me.MetroLabel2)
      Me.Controls.Add(Me.lblCodigo)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.Movable = False
      Me.Name = "frmAnimal"
      Me.Resizable = False
      Me.Style = MetroFramework.MetroColorStyle.Green
      Me.Text = "Pet"
      CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

    Friend WithEvents btsalvar As Button
    Friend WithEvents txtNome As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblNome As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCodigo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCodigo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblEspecie As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboEspecie As MetroFramework.Controls.MetroComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAddEspecie As Button
    Friend WithEvents btnAddRaca As Button
    Friend WithEvents cboRaca As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblRaca As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblObservacao As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtObservacao As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents mdtDtNascimento As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboSexo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnExcluir As Button
    Friend WithEvents cboCliente As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnProcurar As Button
    Friend WithEvents txtRacao As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblRacao As MetroFramework.Controls.MetroLabel
End Class
