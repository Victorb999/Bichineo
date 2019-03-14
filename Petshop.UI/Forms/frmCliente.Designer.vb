<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCliente))
      Me.lblCodigo = New MetroFramework.Controls.MetroLabel()
      Me.txtCodigo = New MetroFramework.Controls.MetroTextBox()
      Me.txtNome = New MetroFramework.Controls.MetroTextBox()
      Me.lblNome = New MetroFramework.Controls.MetroLabel()
      Me.lblTelefone = New MetroFramework.Controls.MetroLabel()
      Me.txtCPF = New MetroFramework.Controls.MetroTextBox()
      Me.lblCPF = New MetroFramework.Controls.MetroLabel()
      Me.TxtEndereco = New MetroFramework.Controls.MetroTextBox()
      Me.lblEndereco = New MetroFramework.Controls.MetroLabel()
      Me.txtCidade = New MetroFramework.Controls.MetroTextBox()
      Me.lblCidade = New MetroFramework.Controls.MetroLabel()
      Me.txtBairro = New MetroFramework.Controls.MetroTextBox()
      Me.lblBairro = New MetroFramework.Controls.MetroLabel()
      Me.txtUF = New MetroFramework.Controls.MetroTextBox()
      Me.lblUf = New MetroFramework.Controls.MetroLabel()
      Me.txtTelefone = New MetroFramework.Controls.MetroTextBox()
      Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
      Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
      Me.txtTelefone2 = New MetroFramework.Controls.MetroTextBox()
      Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
      Me.txtTelefone3 = New MetroFramework.Controls.MetroTextBox()
      Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
      Me.cboSexo = New MetroFramework.Controls.MetroComboBox()
      Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
      Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
      Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
      Me.txtCEP = New MetroFramework.Controls.MetroTextBox()
      Me.btsalvar = New System.Windows.Forms.Button()
      Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.mdtDtNascimento = New MetroFramework.Controls.MetroDateTime()
      Me.btnExcluir = New System.Windows.Forms.Button()
      Me.dgvAnimal = New System.Windows.Forms.DataGridView()
      Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Animal = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Raca = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.lblAnimaisTitulo = New MetroFramework.Controls.MetroLabel()
      Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.dgvAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'lblCodigo
      '
      Me.lblCodigo.AutoSize = True
      Me.lblCodigo.Location = New System.Drawing.Point(22, 92)
      Me.lblCodigo.Name = "lblCodigo"
      Me.lblCodigo.Size = New System.Drawing.Size(53, 19)
      Me.lblCodigo.TabIndex = 1
      Me.lblCodigo.Text = "Código"
      '
      'txtCodigo
      '
      '
      '
      '
      Me.txtCodigo.CustomButton.Image = Nothing
      Me.txtCodigo.CustomButton.Location = New System.Drawing.Point(107, 1)
      Me.txtCodigo.CustomButton.Name = ""
      Me.txtCodigo.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtCodigo.CustomButton.TabIndex = 1
      Me.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtCodigo.CustomButton.UseSelectable = True
      Me.txtCodigo.CustomButton.Visible = False
      Me.txtCodigo.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtCodigo.Lines = New String(-1) {}
      Me.txtCodigo.Location = New System.Drawing.Point(22, 114)
      Me.txtCodigo.MaxLength = 5
      Me.txtCodigo.Name = "txtCodigo"
      Me.txtCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtCodigo.SelectedText = ""
      Me.txtCodigo.SelectionLength = 0
      Me.txtCodigo.SelectionStart = 0
      Me.txtCodigo.ShortcutsEnabled = True
      Me.txtCodigo.Size = New System.Drawing.Size(135, 29)
      Me.txtCodigo.TabIndex = 0
      Me.txtCodigo.UseSelectable = True
      Me.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtCodigo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'txtNome
      '
      '
      '
      '
      Me.txtNome.CustomButton.Image = Nothing
      Me.txtNome.CustomButton.Location = New System.Drawing.Point(442, 1)
      Me.txtNome.CustomButton.Name = ""
      Me.txtNome.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtNome.CustomButton.TabIndex = 1
      Me.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtNome.CustomButton.UseSelectable = True
      Me.txtNome.CustomButton.Visible = False
      Me.txtNome.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtNome.Lines = New String(-1) {}
      Me.txtNome.Location = New System.Drawing.Point(22, 168)
      Me.txtNome.MaxLength = 50
      Me.txtNome.Name = "txtNome"
      Me.txtNome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtNome.SelectedText = ""
      Me.txtNome.SelectionLength = 0
      Me.txtNome.SelectionStart = 0
      Me.txtNome.ShortcutsEnabled = True
      Me.txtNome.Size = New System.Drawing.Size(470, 29)
      Me.txtNome.TabIndex = 1
      Me.txtNome.UseSelectable = True
      Me.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtNome.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'lblNome
      '
      Me.lblNome.AutoSize = True
      Me.lblNome.Location = New System.Drawing.Point(22, 146)
      Me.lblNome.Name = "lblNome"
      Me.lblNome.Size = New System.Drawing.Size(46, 19)
      Me.lblNome.TabIndex = 3
      Me.lblNome.Text = "Nome"
      '
      'lblTelefone
      '
      Me.lblTelefone.AutoSize = True
      Me.lblTelefone.Location = New System.Drawing.Point(202, 200)
      Me.lblTelefone.Name = "lblTelefone"
      Me.lblTelefone.Size = New System.Drawing.Size(128, 19)
      Me.lblTelefone.TabIndex = 5
      Me.lblTelefone.Text = "Data de Nascimento"
      '
      'txtCPF
      '
      '
      '
      '
      Me.txtCPF.CustomButton.Image = Nothing
      Me.txtCPF.CustomButton.Location = New System.Drawing.Point(134, 1)
      Me.txtCPF.CustomButton.Name = ""
      Me.txtCPF.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.txtCPF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtCPF.CustomButton.TabIndex = 1
      Me.txtCPF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtCPF.CustomButton.UseSelectable = True
      Me.txtCPF.CustomButton.Visible = False
      Me.txtCPF.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtCPF.Lines = New String(-1) {}
      Me.txtCPF.Location = New System.Drawing.Point(22, 222)
      Me.txtCPF.MaxLength = 11
      Me.txtCPF.Name = "txtCPF"
      Me.txtCPF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtCPF.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtCPF.SelectedText = ""
      Me.txtCPF.SelectionLength = 0
      Me.txtCPF.SelectionStart = 0
      Me.txtCPF.ShortcutsEnabled = True
      Me.txtCPF.Size = New System.Drawing.Size(162, 29)
      Me.txtCPF.TabIndex = 2
      Me.txtCPF.UseSelectable = True
      Me.txtCPF.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtCPF.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'lblCPF
      '
      Me.lblCPF.AutoSize = True
      Me.lblCPF.Location = New System.Drawing.Point(22, 200)
      Me.lblCPF.Name = "lblCPF"
      Me.lblCPF.Size = New System.Drawing.Size(33, 19)
      Me.lblCPF.TabIndex = 7
      Me.lblCPF.Text = "CPF"
      '
      'TxtEndereco
      '
      '
      '
      '
      Me.TxtEndereco.CustomButton.Image = Nothing
      Me.TxtEndereco.CustomButton.Location = New System.Drawing.Point(442, 1)
      Me.TxtEndereco.CustomButton.Name = ""
      Me.TxtEndereco.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.TxtEndereco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.TxtEndereco.CustomButton.TabIndex = 1
      Me.TxtEndereco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.TxtEndereco.CustomButton.UseSelectable = True
      Me.TxtEndereco.CustomButton.Visible = False
      Me.TxtEndereco.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.TxtEndereco.Lines = New String(-1) {}
      Me.TxtEndereco.Location = New System.Drawing.Point(22, 441)
      Me.TxtEndereco.MaxLength = 80
      Me.TxtEndereco.Name = "TxtEndereco"
      Me.TxtEndereco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.TxtEndereco.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.TxtEndereco.SelectedText = ""
      Me.TxtEndereco.SelectionLength = 0
      Me.TxtEndereco.SelectionStart = 0
      Me.TxtEndereco.ShortcutsEnabled = True
      Me.TxtEndereco.Size = New System.Drawing.Size(470, 29)
      Me.TxtEndereco.TabIndex = 10
      Me.TxtEndereco.UseSelectable = True
      Me.TxtEndereco.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.TxtEndereco.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'lblEndereco
      '
      Me.lblEndereco.AutoSize = True
      Me.lblEndereco.Location = New System.Drawing.Point(22, 419)
      Me.lblEndereco.Name = "lblEndereco"
      Me.lblEndereco.Size = New System.Drawing.Size(64, 19)
      Me.lblEndereco.TabIndex = 10
      Me.lblEndereco.Text = "Endereço"
      '
      'txtCidade
      '
      '
      '
      '
      Me.txtCidade.CustomButton.Image = Nothing
      Me.txtCidade.CustomButton.Location = New System.Drawing.Point(176, 1)
      Me.txtCidade.CustomButton.Name = ""
      Me.txtCidade.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.txtCidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtCidade.CustomButton.TabIndex = 1
      Me.txtCidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtCidade.CustomButton.UseSelectable = True
      Me.txtCidade.CustomButton.Visible = False
      Me.txtCidade.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtCidade.Lines = New String(-1) {}
      Me.txtCidade.Location = New System.Drawing.Point(239, 495)
      Me.txtCidade.MaxLength = 50
      Me.txtCidade.Name = "txtCidade"
      Me.txtCidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtCidade.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtCidade.SelectedText = ""
      Me.txtCidade.SelectionLength = 0
      Me.txtCidade.SelectionStart = 0
      Me.txtCidade.ShortcutsEnabled = True
      Me.txtCidade.Size = New System.Drawing.Size(204, 29)
      Me.txtCidade.TabIndex = 12
      Me.txtCidade.UseSelectable = True
      Me.txtCidade.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtCidade.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'lblCidade
      '
      Me.lblCidade.AutoSize = True
      Me.lblCidade.Location = New System.Drawing.Point(239, 473)
      Me.lblCidade.Name = "lblCidade"
      Me.lblCidade.Size = New System.Drawing.Size(51, 19)
      Me.lblCidade.TabIndex = 14
      Me.lblCidade.Text = "Cidade"
      '
      'txtBairro
      '
      '
      '
      '
      Me.txtBairro.CustomButton.Image = Nothing
      Me.txtBairro.CustomButton.Location = New System.Drawing.Point(183, 1)
      Me.txtBairro.CustomButton.Name = ""
      Me.txtBairro.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.txtBairro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtBairro.CustomButton.TabIndex = 1
      Me.txtBairro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtBairro.CustomButton.UseSelectable = True
      Me.txtBairro.CustomButton.Visible = False
      Me.txtBairro.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtBairro.Lines = New String(-1) {}
      Me.txtBairro.Location = New System.Drawing.Point(22, 495)
      Me.txtBairro.MaxLength = 50
      Me.txtBairro.Name = "txtBairro"
      Me.txtBairro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtBairro.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtBairro.SelectedText = ""
      Me.txtBairro.SelectionLength = 0
      Me.txtBairro.SelectionStart = 0
      Me.txtBairro.ShortcutsEnabled = True
      Me.txtBairro.Size = New System.Drawing.Size(211, 29)
      Me.txtBairro.TabIndex = 11
      Me.txtBairro.UseSelectable = True
      Me.txtBairro.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtBairro.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'lblBairro
      '
      Me.lblBairro.AutoSize = True
      Me.lblBairro.Location = New System.Drawing.Point(22, 473)
      Me.lblBairro.Name = "lblBairro"
      Me.lblBairro.Size = New System.Drawing.Size(45, 19)
      Me.lblBairro.TabIndex = 12
      Me.lblBairro.Text = "Bairro"
      '
      'txtUF
      '
      '
      '
      '
      Me.txtUF.CustomButton.Image = Nothing
      Me.txtUF.CustomButton.Location = New System.Drawing.Point(14, 1)
      Me.txtUF.CustomButton.Name = ""
      Me.txtUF.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.txtUF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtUF.CustomButton.TabIndex = 1
      Me.txtUF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtUF.CustomButton.UseSelectable = True
      Me.txtUF.CustomButton.Visible = False
      Me.txtUF.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtUF.Lines = New String(-1) {}
      Me.txtUF.Location = New System.Drawing.Point(450, 495)
      Me.txtUF.MaxLength = 2
      Me.txtUF.Name = "txtUF"
      Me.txtUF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtUF.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtUF.SelectedText = ""
      Me.txtUF.SelectionLength = 0
      Me.txtUF.SelectionStart = 0
      Me.txtUF.ShortcutsEnabled = True
      Me.txtUF.Size = New System.Drawing.Size(42, 29)
      Me.txtUF.TabIndex = 13
      Me.txtUF.UseSelectable = True
      Me.txtUF.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtUF.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'lblUf
      '
      Me.lblUf.AutoSize = True
      Me.lblUf.Location = New System.Drawing.Point(450, 473)
      Me.lblUf.Name = "lblUf"
      Me.lblUf.Size = New System.Drawing.Size(25, 19)
      Me.lblUf.TabIndex = 16
      Me.lblUf.Text = "UF"
      '
      'txtTelefone
      '
      '
      '
      '
      Me.txtTelefone.CustomButton.Image = Nothing
      Me.txtTelefone.CustomButton.Location = New System.Drawing.Point(105, 1)
      Me.txtTelefone.CustomButton.Name = ""
      Me.txtTelefone.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.txtTelefone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtTelefone.CustomButton.TabIndex = 1
      Me.txtTelefone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtTelefone.CustomButton.UseSelectable = True
      Me.txtTelefone.CustomButton.Visible = False
      Me.txtTelefone.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtTelefone.Lines = New String(-1) {}
      Me.txtTelefone.Location = New System.Drawing.Point(22, 279)
      Me.txtTelefone.MaxLength = 11
      Me.txtTelefone.Name = "txtTelefone"
      Me.txtTelefone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtTelefone.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtTelefone.SelectedText = ""
      Me.txtTelefone.SelectionLength = 0
      Me.txtTelefone.SelectionStart = 0
      Me.txtTelefone.ShortcutsEnabled = True
      Me.txtTelefone.Size = New System.Drawing.Size(133, 29)
      Me.txtTelefone.TabIndex = 5
      Me.txtTelefone.UseSelectable = True
      Me.txtTelefone.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtTelefone.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'MetroLabel1
      '
      Me.MetroLabel1.AutoSize = True
      Me.MetroLabel1.Location = New System.Drawing.Point(22, 257)
      Me.MetroLabel1.Name = "MetroLabel1"
      Me.MetroLabel1.Size = New System.Drawing.Size(127, 19)
      Me.MetroLabel1.TabIndex = 10
      Me.MetroLabel1.Text = "Telefone Residencial"
      '
      'MetroLabel2
      '
      Me.MetroLabel2.AutoSize = True
      Me.MetroLabel2.Location = New System.Drawing.Point(202, 257)
      Me.MetroLabel2.Name = "MetroLabel2"
      Me.MetroLabel2.Size = New System.Drawing.Size(104, 19)
      Me.MetroLabel2.TabIndex = 10
      Me.MetroLabel2.Text = "Telefone Celular"
      '
      'txtTelefone2
      '
      '
      '
      '
      Me.txtTelefone2.CustomButton.Image = Nothing
      Me.txtTelefone2.CustomButton.Location = New System.Drawing.Point(105, 1)
      Me.txtTelefone2.CustomButton.Name = ""
      Me.txtTelefone2.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.txtTelefone2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtTelefone2.CustomButton.TabIndex = 1
      Me.txtTelefone2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtTelefone2.CustomButton.UseSelectable = True
      Me.txtTelefone2.CustomButton.Visible = False
      Me.txtTelefone2.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtTelefone2.Lines = New String(-1) {}
      Me.txtTelefone2.Location = New System.Drawing.Point(202, 279)
      Me.txtTelefone2.MaxLength = 11
      Me.txtTelefone2.Name = "txtTelefone2"
      Me.txtTelefone2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtTelefone2.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtTelefone2.SelectedText = ""
      Me.txtTelefone2.SelectionLength = 0
      Me.txtTelefone2.SelectionStart = 0
      Me.txtTelefone2.ShortcutsEnabled = True
      Me.txtTelefone2.Size = New System.Drawing.Size(133, 29)
      Me.txtTelefone2.TabIndex = 6
      Me.txtTelefone2.UseSelectable = True
      Me.txtTelefone2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtTelefone2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'MetroLabel3
      '
      Me.MetroLabel3.AutoSize = True
      Me.MetroLabel3.Location = New System.Drawing.Point(359, 257)
      Me.MetroLabel3.Name = "MetroLabel3"
      Me.MetroLabel3.Size = New System.Drawing.Size(123, 19)
      Me.MetroLabel3.TabIndex = 10
      Me.MetroLabel3.Text = "Telefone Comercial"
      '
      'txtTelefone3
      '
      '
      '
      '
      Me.txtTelefone3.CustomButton.Image = Nothing
      Me.txtTelefone3.CustomButton.Location = New System.Drawing.Point(105, 1)
      Me.txtTelefone3.CustomButton.Name = ""
      Me.txtTelefone3.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.txtTelefone3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtTelefone3.CustomButton.TabIndex = 1
      Me.txtTelefone3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtTelefone3.CustomButton.UseSelectable = True
      Me.txtTelefone3.CustomButton.Visible = False
      Me.txtTelefone3.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtTelefone3.Lines = New String(-1) {}
      Me.txtTelefone3.Location = New System.Drawing.Point(359, 279)
      Me.txtTelefone3.MaxLength = 11
      Me.txtTelefone3.Name = "txtTelefone3"
      Me.txtTelefone3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtTelefone3.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtTelefone3.SelectedText = ""
      Me.txtTelefone3.SelectionLength = 0
      Me.txtTelefone3.SelectionStart = 0
      Me.txtTelefone3.ShortcutsEnabled = True
      Me.txtTelefone3.Size = New System.Drawing.Size(133, 29)
      Me.txtTelefone3.TabIndex = 7
      Me.txtTelefone3.UseSelectable = True
      Me.txtTelefone3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtTelefone3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'MetroLabel4
      '
      Me.MetroLabel4.AutoSize = True
      Me.MetroLabel4.Location = New System.Drawing.Point(359, 200)
      Me.MetroLabel4.Name = "MetroLabel4"
      Me.MetroLabel4.Size = New System.Drawing.Size(37, 19)
      Me.MetroLabel4.TabIndex = 5
      Me.MetroLabel4.Text = "Sexo"
      '
      'cboSexo
      '
      Me.cboSexo.FormattingEnabled = True
      Me.cboSexo.ItemHeight = 23
      Me.cboSexo.Items.AddRange(New Object() {"Feminino", "Masculino"})
      Me.cboSexo.Location = New System.Drawing.Point(359, 222)
      Me.cboSexo.Name = "cboSexo"
      Me.cboSexo.Size = New System.Drawing.Size(133, 29)
      Me.cboSexo.TabIndex = 4
      Me.cboSexo.UseSelectable = True
      '
      'MetroLabel5
      '
      Me.MetroLabel5.AutoSize = True
      Me.MetroLabel5.Location = New System.Drawing.Point(22, 311)
      Me.MetroLabel5.Name = "MetroLabel5"
      Me.MetroLabel5.Size = New System.Drawing.Size(41, 19)
      Me.MetroLabel5.TabIndex = 10
      Me.MetroLabel5.Text = "Email"
      '
      'txtEmail
      '
      '
      '
      '
      Me.txtEmail.CustomButton.Image = Nothing
      Me.txtEmail.CustomButton.Location = New System.Drawing.Point(442, 1)
      Me.txtEmail.CustomButton.Name = ""
      Me.txtEmail.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtEmail.CustomButton.TabIndex = 1
      Me.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtEmail.CustomButton.UseSelectable = True
      Me.txtEmail.CustomButton.Visible = False
      Me.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtEmail.Lines = New String(-1) {}
      Me.txtEmail.Location = New System.Drawing.Point(22, 333)
      Me.txtEmail.MaxLength = 50
      Me.txtEmail.Name = "txtEmail"
      Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtEmail.SelectedText = ""
      Me.txtEmail.SelectionLength = 0
      Me.txtEmail.SelectionStart = 0
      Me.txtEmail.ShortcutsEnabled = True
      Me.txtEmail.Size = New System.Drawing.Size(470, 29)
      Me.txtEmail.TabIndex = 8
      Me.txtEmail.UseSelectable = True
      Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'MetroLabel6
      '
      Me.MetroLabel6.AutoSize = True
      Me.MetroLabel6.Location = New System.Drawing.Point(22, 365)
      Me.MetroLabel6.Name = "MetroLabel6"
      Me.MetroLabel6.Size = New System.Drawing.Size(33, 19)
      Me.MetroLabel6.TabIndex = 10
      Me.MetroLabel6.Text = "CEP"
      '
      'txtCEP
      '
      '
      '
      '
      Me.txtCEP.CustomButton.Image = Nothing
      Me.txtCEP.CustomButton.Location = New System.Drawing.Point(105, 1)
      Me.txtCEP.CustomButton.Name = ""
      Me.txtCEP.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.txtCEP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtCEP.CustomButton.TabIndex = 1
      Me.txtCEP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtCEP.CustomButton.UseSelectable = True
      Me.txtCEP.CustomButton.Visible = False
      Me.txtCEP.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtCEP.Lines = New String(-1) {}
      Me.txtCEP.Location = New System.Drawing.Point(22, 387)
      Me.txtCEP.MaxLength = 10
      Me.txtCEP.Name = "txtCEP"
      Me.txtCEP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtCEP.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtCEP.SelectedText = ""
      Me.txtCEP.SelectionLength = 0
      Me.txtCEP.SelectionStart = 0
      Me.txtCEP.ShortcutsEnabled = True
      Me.txtCEP.Size = New System.Drawing.Size(133, 29)
      Me.txtCEP.TabIndex = 9
      Me.txtCEP.UseSelectable = True
      Me.txtCEP.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtCEP.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
      Me.btsalvar.Location = New System.Drawing.Point(22, 539)
      Me.btsalvar.Name = "btsalvar"
      Me.btsalvar.Size = New System.Drawing.Size(129, 45)
      Me.btsalvar.TabIndex = 14
      Me.btsalvar.Text = "Salvar"
      Me.btsalvar.UseVisualStyleBackColor = False
      '
      'MetroTile1
      '
      Me.MetroTile1.ActiveControl = Nothing
      Me.MetroTile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
      Me.MetroTile1.Location = New System.Drawing.Point(863, 517)
      Me.MetroTile1.Name = "MetroTile1"
      Me.MetroTile1.Size = New System.Drawing.Size(114, 67)
      Me.MetroTile1.TabIndex = 17
      Me.MetroTile1.Text = "Adicionar Bicho"
      Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
      Me.MetroTile1.TileImage = Global.Petshop.UI.My.Resources.Resources.icons8_Cat_Footprint_32px
      Me.MetroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
      Me.MetroTile1.UseCustomBackColor = True
      Me.MetroTile1.UseSelectable = True
      Me.MetroTile1.UseTileImage = True
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = Global.Petshop.UI.My.Resources.Resources.icons8_People_64px
      Me.PictureBox1.Location = New System.Drawing.Point(97, 6)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(90, 62)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.PictureBox1.TabIndex = 0
      Me.PictureBox1.TabStop = False
      '
      'mdtDtNascimento
      '
      Me.mdtDtNascimento.FontWeight = MetroFramework.MetroDateTimeWeight.Light
      Me.mdtDtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.mdtDtNascimento.Location = New System.Drawing.Point(202, 222)
      Me.mdtDtNascimento.MaxDate = New Date(2017, 12, 31, 0, 0, 0, 0)
      Me.mdtDtNascimento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
      Me.mdtDtNascimento.MinimumSize = New System.Drawing.Size(0, 29)
      Me.mdtDtNascimento.Name = "mdtDtNascimento"
      Me.mdtDtNascimento.Size = New System.Drawing.Size(133, 29)
      Me.mdtDtNascimento.TabIndex = 3
      '
      'btnExcluir
      '
      Me.btnExcluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
      Me.btnExcluir.FlatAppearance.BorderSize = 0
      Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.btnExcluir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnExcluir.ForeColor = System.Drawing.Color.White
      Me.btnExcluir.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Cancel_32px_11
      Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnExcluir.Location = New System.Drawing.Point(363, 539)
      Me.btnExcluir.Name = "btnExcluir"
      Me.btnExcluir.Size = New System.Drawing.Size(129, 45)
      Me.btnExcluir.TabIndex = 15
      Me.btnExcluir.Text = "Excluir"
      Me.btnExcluir.UseVisualStyleBackColor = False
      '
      'dgvAnimal
      '
      Me.dgvAnimal.AllowUserToAddRows = False
      Me.dgvAnimal.AllowUserToDeleteRows = False
      Me.dgvAnimal.AllowUserToOrderColumns = True
      Me.dgvAnimal.BackgroundColor = System.Drawing.Color.White
      Me.dgvAnimal.BorderStyle = System.Windows.Forms.BorderStyle.None
      Me.dgvAnimal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
      Me.dgvAnimal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
      DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
      DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aquamarine
      DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
      DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.dgvAnimal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
      Me.dgvAnimal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Animal, Me.Raca, Me.Obs})
      DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
      DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
      DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Aquamarine
      DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
      DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.dgvAnimal.DefaultCellStyle = DataGridViewCellStyle2
      Me.dgvAnimal.EnableHeadersVisualStyles = False
      Me.dgvAnimal.GridColor = System.Drawing.Color.Silver
      Me.dgvAnimal.Location = New System.Drawing.Point(572, 168)
      Me.dgvAnimal.MultiSelect = False
      Me.dgvAnimal.Name = "dgvAnimal"
      Me.dgvAnimal.ReadOnly = True
      Me.dgvAnimal.RowHeadersVisible = False
      Me.dgvAnimal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
      Me.dgvAnimal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.dgvAnimal.Size = New System.Drawing.Size(405, 324)
      Me.dgvAnimal.TabIndex = 16
      '
      'Codigo
      '
      Me.Codigo.HeaderText = "Código"
      Me.Codigo.Name = "Codigo"
      Me.Codigo.ReadOnly = True
      Me.Codigo.Visible = False
      '
      'Animal
      '
      Me.Animal.HeaderText = "Animal"
      Me.Animal.Name = "Animal"
      Me.Animal.ReadOnly = True
      Me.Animal.Width = 130
      '
      'Raca
      '
      Me.Raca.HeaderText = "Raça"
      Me.Raca.Name = "Raca"
      Me.Raca.ReadOnly = True
      '
      'Obs
      '
      Me.Obs.HeaderText = "Obs"
      Me.Obs.Name = "Obs"
      Me.Obs.ReadOnly = True
      Me.Obs.Width = 140
      '
      'lblAnimaisTitulo
      '
      Me.lblAnimaisTitulo.AutoSize = True
      Me.lblAnimaisTitulo.FontSize = MetroFramework.MetroLabelSize.Tall
      Me.lblAnimaisTitulo.Location = New System.Drawing.Point(572, 114)
      Me.lblAnimaisTitulo.Name = "lblAnimaisTitulo"
      Me.lblAnimaisTitulo.Size = New System.Drawing.Size(72, 25)
      Me.lblAnimaisTitulo.TabIndex = 18
      Me.lblAnimaisTitulo.Text = "Animais"
      '
      'MetroStyleManager1
      '
      Me.MetroStyleManager1.Owner = Me
      Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Green
      '
      'frmCliente
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1000, 620)
      Me.Controls.Add(Me.lblAnimaisTitulo)
      Me.Controls.Add(Me.dgvAnimal)
      Me.Controls.Add(Me.mdtDtNascimento)
      Me.Controls.Add(Me.cboSexo)
      Me.Controls.Add(Me.btnExcluir)
      Me.Controls.Add(Me.btsalvar)
      Me.Controls.Add(Me.txtUF)
      Me.Controls.Add(Me.lblUf)
      Me.Controls.Add(Me.txtCidade)
      Me.Controls.Add(Me.lblCidade)
      Me.Controls.Add(Me.txtBairro)
      Me.Controls.Add(Me.lblBairro)
      Me.Controls.Add(Me.txtTelefone3)
      Me.Controls.Add(Me.txtTelefone2)
      Me.Controls.Add(Me.txtCEP)
      Me.Controls.Add(Me.txtTelefone)
      Me.Controls.Add(Me.txtEmail)
      Me.Controls.Add(Me.TxtEndereco)
      Me.Controls.Add(Me.MetroLabel3)
      Me.Controls.Add(Me.MetroLabel2)
      Me.Controls.Add(Me.MetroLabel6)
      Me.Controls.Add(Me.MetroLabel1)
      Me.Controls.Add(Me.MetroLabel5)
      Me.Controls.Add(Me.lblEndereco)
      Me.Controls.Add(Me.MetroTile1)
      Me.Controls.Add(Me.txtCPF)
      Me.Controls.Add(Me.lblCPF)
      Me.Controls.Add(Me.MetroLabel4)
      Me.Controls.Add(Me.lblTelefone)
      Me.Controls.Add(Me.txtNome)
      Me.Controls.Add(Me.lblNome)
      Me.Controls.Add(Me.txtCodigo)
      Me.Controls.Add(Me.lblCodigo)
      Me.Controls.Add(Me.PictureBox1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.Movable = False
      Me.Name = "frmCliente"
      Me.Resizable = False
      Me.Style = MetroFramework.MetroColorStyle.Green
      Me.Text = "Cliente"
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.dgvAnimal, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblCodigo As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCodigo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNome As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblNome As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTelefone As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCPF As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCPF As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents TxtEndereco As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblEndereco As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCidade As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCidade As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtBairro As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblBairro As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtUF As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblUf As MetroFramework.Controls.MetroLabel
    Friend WithEvents btsalvar As Button
    Friend WithEvents txtTelefone As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTelefone2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTelefone3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboSexo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCEP As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mdtDtNascimento As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btnExcluir As Button
    Friend WithEvents dgvAnimal As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Animal As DataGridViewTextBoxColumn
    Friend WithEvents Raca As DataGridViewTextBoxColumn
    Friend WithEvents Obs As DataGridViewTextBoxColumn
   Friend WithEvents lblAnimaisTitulo As MetroFramework.Controls.MetroLabel
   Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
End Class
