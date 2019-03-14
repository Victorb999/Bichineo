<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEspecie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEspecie))
        Me.txtNome = New MetroFramework.Controls.MetroTextBox()
        Me.lblNome = New MetroFramework.Controls.MetroLabel()
        Me.txtCodigo = New MetroFramework.Controls.MetroTextBox()
        Me.lblCodigo = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btsalvar = New System.Windows.Forms.Button()
        Me.lblObs = New MetroFramework.Controls.MetroLabel()
        Me.txtObservacao = New MetroFramework.Controls.MetroTextBox()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.btnExcluir = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNome
        '
        '
        '
        '
        Me.txtNome.CustomButton.Image = Nothing
        Me.txtNome.CustomButton.Location = New System.Drawing.Point(262, 1)
        Me.txtNome.CustomButton.Name = ""
        Me.txtNome.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNome.CustomButton.TabIndex = 1
        Me.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNome.CustomButton.UseSelectable = True
        Me.txtNome.CustomButton.Visible = False
        Me.txtNome.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNome.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txtNome.Lines = New String(-1) {}
        Me.txtNome.Location = New System.Drawing.Point(23, 159)
        Me.txtNome.MaxLength = 40
        Me.txtNome.Name = "txtNome"
        Me.txtNome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNome.SelectedText = ""
        Me.txtNome.SelectionLength = 0
        Me.txtNome.SelectionStart = 0
        Me.txtNome.ShortcutsEnabled = True
        Me.txtNome.Size = New System.Drawing.Size(290, 29)
        Me.txtNome.TabIndex = 1
        Me.txtNome.UseSelectable = True
        Me.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNome.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(23, 137)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(46, 19)
        Me.lblNome.TabIndex = 7
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Cat_64px
        Me.PictureBox1.Location = New System.Drawing.Point(107, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
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
        Me.btsalvar.Location = New System.Drawing.Point(23, 328)
        Me.btsalvar.Name = "btsalvar"
        Me.btsalvar.Size = New System.Drawing.Size(129, 45)
        Me.btsalvar.TabIndex = 3
        Me.btsalvar.Text = "Salvar"
        Me.btsalvar.UseVisualStyleBackColor = False
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Location = New System.Drawing.Point(23, 191)
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
        Me.txtObservacao.Location = New System.Drawing.Point(23, 213)
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
        Me.txtObservacao.TabIndex = 2
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
        Me.btnExcluir.Location = New System.Drawing.Point(184, 328)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(129, 45)
        Me.btnExcluir.TabIndex = 4
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'frmEspecie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 396)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btsalvar)
        Me.Controls.Add(Me.txtObservacao)
        Me.Controls.Add(Me.lblObs)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Movable = False
        Me.Name = "frmEspecie"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Espécie"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNome As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblNome As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCodigo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCodigo As MetroFramework.Controls.MetroLabel
    Friend WithEvents btsalvar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblObs As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtObservacao As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents btnExcluir As Button
End Class
