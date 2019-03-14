<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgendaEvento
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
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Me.lblHorariofim = New MetroFramework.Controls.MetroLabel()
      Me.lblHorarioinicio = New MetroFramework.Controls.MetroLabel()
      Me.lblServico = New MetroFramework.Controls.MetroLabel()
      Me.txtServico = New MetroFramework.Controls.MetroTextBox()
      Me.dtData = New MetroFramework.Controls.MetroDateTime()
      Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
      Me.txtAnimal = New MetroFramework.Controls.MetroTextBox()
      Me.lblAnimal = New MetroFramework.Controls.MetroLabel()
      Me.txtObservacao = New MetroFramework.Controls.MetroTextBox()
      Me.lblObservacao = New MetroFramework.Controls.MetroLabel()
      Me.txtCodigo = New MetroFramework.Controls.MetroTextBox()
      Me.lblCodigo = New MetroFramework.Controls.MetroLabel()
      Me.dgvAgenda = New System.Windows.Forms.DataGridView()
      Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.HorarioInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.HorarioFim = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Servico = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Animal = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.Obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.CodigoAnimal = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.CodigoServico = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.txtServicodesc = New MetroFramework.Controls.MetroTextBox()
      Me.txtAnimalNome = New MetroFramework.Controls.MetroTextBox()
      Me.txtHorarioInicio = New System.Windows.Forms.MaskedTextBox()
      Me.txtHorarioFim = New System.Windows.Forms.MaskedTextBox()
      Me.lblGrid = New MetroFramework.Controls.MetroLabel()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.BtConfirmar = New System.Windows.Forms.Button()
      Me.BtNovo = New System.Windows.Forms.Button()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.btsalvar = New System.Windows.Forms.Button()
      CType(Me.dgvAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'lblHorariofim
      '
      Me.lblHorariofim.AutoSize = True
      Me.lblHorariofim.Location = New System.Drawing.Point(193, 257)
      Me.lblHorariofim.Name = "lblHorariofim"
      Me.lblHorariofim.Size = New System.Drawing.Size(77, 19)
      Me.lblHorariofim.TabIndex = 46
      Me.lblHorariofim.Text = "Horário fim"
      '
      'lblHorarioinicio
      '
      Me.lblHorarioinicio.AutoSize = True
      Me.lblHorarioinicio.Location = New System.Drawing.Point(22, 257)
      Me.lblHorarioinicio.Name = "lblHorarioinicio"
      Me.lblHorarioinicio.Size = New System.Drawing.Size(88, 19)
      Me.lblHorarioinicio.TabIndex = 43
      Me.lblHorarioinicio.Text = "Horário início"
      '
      'lblServico
      '
      Me.lblServico.AutoSize = True
      Me.lblServico.Location = New System.Drawing.Point(18, 143)
      Me.lblServico.Name = "lblServico"
      Me.lblServico.Size = New System.Drawing.Size(51, 19)
      Me.lblServico.TabIndex = 39
      Me.lblServico.Text = "Serviço"
      '
      'txtServico
      '
      '
      '
      '
      Me.txtServico.CustomButton.Image = Nothing
      Me.txtServico.CustomButton.Location = New System.Drawing.Point(53, 1)
      Me.txtServico.CustomButton.Name = ""
      Me.txtServico.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.txtServico.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtServico.CustomButton.TabIndex = 1
      Me.txtServico.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtServico.CustomButton.UseSelectable = True
      Me.txtServico.CustomButton.Visible = False
      Me.txtServico.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtServico.Lines = New String(-1) {}
      Me.txtServico.Location = New System.Drawing.Point(22, 165)
      Me.txtServico.MaxLength = 5
      Me.txtServico.Name = "txtServico"
      Me.txtServico.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtServico.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtServico.SelectedText = ""
      Me.txtServico.SelectionLength = 0
      Me.txtServico.SelectionStart = 0
      Me.txtServico.ShortcutsEnabled = True
      Me.txtServico.Size = New System.Drawing.Size(81, 29)
      Me.txtServico.TabIndex = 0
      Me.txtServico.UseSelectable = True
      Me.txtServico.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtServico.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'dtData
      '
      Me.dtData.CustomFormat = ""
      Me.dtData.Location = New System.Drawing.Point(22, 335)
      Me.dtData.MinimumSize = New System.Drawing.Size(0, 29)
      Me.dtData.Name = "dtData"
      Me.dtData.Size = New System.Drawing.Size(311, 29)
      Me.dtData.TabIndex = 4
      '
      'MetroLabel1
      '
      Me.MetroLabel1.AutoSize = True
      Me.MetroLabel1.Location = New System.Drawing.Point(21, 313)
      Me.MetroLabel1.Name = "MetroLabel1"
      Me.MetroLabel1.Size = New System.Drawing.Size(36, 19)
      Me.MetroLabel1.TabIndex = 48
      Me.MetroLabel1.Text = "Data"
      '
      'txtAnimal
      '
      '
      '
      '
      Me.txtAnimal.CustomButton.Image = Nothing
      Me.txtAnimal.CustomButton.Location = New System.Drawing.Point(53, 1)
      Me.txtAnimal.CustomButton.Name = ""
      Me.txtAnimal.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.txtAnimal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtAnimal.CustomButton.TabIndex = 1
      Me.txtAnimal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtAnimal.CustomButton.UseSelectable = True
      Me.txtAnimal.CustomButton.Visible = False
      Me.txtAnimal.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtAnimal.Lines = New String(-1) {}
      Me.txtAnimal.Location = New System.Drawing.Point(22, 223)
      Me.txtAnimal.MaxLength = 5
      Me.txtAnimal.Name = "txtAnimal"
      Me.txtAnimal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtAnimal.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtAnimal.SelectedText = ""
      Me.txtAnimal.SelectionLength = 0
      Me.txtAnimal.SelectionStart = 0
      Me.txtAnimal.ShortcutsEnabled = True
      Me.txtAnimal.Size = New System.Drawing.Size(81, 29)
      Me.txtAnimal.TabIndex = 1
      Me.txtAnimal.UseSelectable = True
      Me.txtAnimal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtAnimal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'lblAnimal
      '
      Me.lblAnimal.AutoSize = True
      Me.lblAnimal.Location = New System.Drawing.Point(18, 201)
      Me.lblAnimal.Name = "lblAnimal"
      Me.lblAnimal.Size = New System.Drawing.Size(50, 19)
      Me.lblAnimal.TabIndex = 49
      Me.lblAnimal.Text = "Animal"
      '
      'txtObservacao
      '
      '
      '
      '
      Me.txtObservacao.CustomButton.Image = Nothing
      Me.txtObservacao.CustomButton.Location = New System.Drawing.Point(200, 2)
      Me.txtObservacao.CustomButton.Name = ""
      Me.txtObservacao.CustomButton.Size = New System.Drawing.Size(107, 107)
      Me.txtObservacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtObservacao.CustomButton.TabIndex = 1
      Me.txtObservacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtObservacao.CustomButton.UseSelectable = True
      Me.txtObservacao.CustomButton.Visible = False
      Me.txtObservacao.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtObservacao.Lines = New String(-1) {}
      Me.txtObservacao.Location = New System.Drawing.Point(23, 397)
      Me.txtObservacao.MaxLength = 50
      Me.txtObservacao.Multiline = True
      Me.txtObservacao.Name = "txtObservacao"
      Me.txtObservacao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtObservacao.SelectedText = ""
      Me.txtObservacao.SelectionLength = 0
      Me.txtObservacao.SelectionStart = 0
      Me.txtObservacao.ShortcutsEnabled = True
      Me.txtObservacao.Size = New System.Drawing.Size(310, 112)
      Me.txtObservacao.TabIndex = 5
      Me.txtObservacao.UseSelectable = True
      Me.txtObservacao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtObservacao.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'lblObservacao
      '
      Me.lblObservacao.AutoSize = True
      Me.lblObservacao.Location = New System.Drawing.Point(22, 375)
      Me.lblObservacao.Name = "lblObservacao"
      Me.lblObservacao.Size = New System.Drawing.Size(79, 19)
      Me.lblObservacao.TabIndex = 51
      Me.lblObservacao.Text = "Observação"
      '
      'txtCodigo
      '
      Me.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke
      '
      '
      '
      Me.txtCodigo.CustomButton.Image = Nothing
      Me.txtCodigo.CustomButton.Location = New System.Drawing.Point(283, 1)
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
      Me.txtCodigo.ReadOnly = True
      Me.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtCodigo.SelectedText = ""
      Me.txtCodigo.SelectionLength = 0
      Me.txtCodigo.SelectionStart = 0
      Me.txtCodigo.ShortcutsEnabled = True
      Me.txtCodigo.Size = New System.Drawing.Size(311, 29)
      Me.txtCodigo.TabIndex = 9
      Me.txtCodigo.UseCustomBackColor = True
      Me.txtCodigo.UseCustomForeColor = True
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
      Me.lblCodigo.TabIndex = 52
      Me.lblCodigo.Text = "Código"
      '
      'dgvAgenda
      '
      Me.dgvAgenda.AllowUserToAddRows = False
      Me.dgvAgenda.AllowUserToDeleteRows = False
      Me.dgvAgenda.AllowUserToOrderColumns = True
      Me.dgvAgenda.BackgroundColor = System.Drawing.Color.White
      Me.dgvAgenda.BorderStyle = System.Windows.Forms.BorderStyle.None
      Me.dgvAgenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
      Me.dgvAgenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
      DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
      DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
      DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Aquamarine
      DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
      DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.dgvAgenda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
      Me.dgvAgenda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Data, Me.HorarioInicio, Me.HorarioFim, Me.Servico, Me.Animal, Me.Status, Me.Obs, Me.CodigoAnimal, Me.CodigoServico})
      DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
      DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
      DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Aquamarine
      DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
      DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
      Me.dgvAgenda.DefaultCellStyle = DataGridViewCellStyle4
      Me.dgvAgenda.EnableHeadersVisualStyles = False
      Me.dgvAgenda.GridColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
      Me.dgvAgenda.Location = New System.Drawing.Point(369, 109)
      Me.dgvAgenda.MultiSelect = False
      Me.dgvAgenda.Name = "dgvAgenda"
      Me.dgvAgenda.ReadOnly = True
      Me.dgvAgenda.RowHeadersVisible = False
      Me.dgvAgenda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
      Me.dgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.dgvAgenda.Size = New System.Drawing.Size(640, 387)
      Me.dgvAgenda.TabIndex = 7
      '
      'Codigo
      '
      Me.Codigo.HeaderText = "Código"
      Me.Codigo.Name = "Codigo"
      Me.Codigo.ReadOnly = True
      Me.Codigo.Visible = False
      '
      'Data
      '
      Me.Data.HeaderText = "Data"
      Me.Data.Name = "Data"
      Me.Data.ReadOnly = True
      Me.Data.Width = 80
      '
      'HorarioInicio
      '
      Me.HorarioInicio.HeaderText = "Horário"
      Me.HorarioInicio.Name = "HorarioInicio"
      Me.HorarioInicio.ReadOnly = True
      Me.HorarioInicio.Width = 80
      '
      'HorarioFim
      '
      Me.HorarioFim.HeaderText = "Horário Fim"
      Me.HorarioFim.Name = "HorarioFim"
      Me.HorarioFim.ReadOnly = True
      Me.HorarioFim.Width = 80
      '
      'Servico
      '
      Me.Servico.HeaderText = "Serviço"
      Me.Servico.Name = "Servico"
      Me.Servico.ReadOnly = True
      Me.Servico.Width = 120
      '
      'Animal
      '
      Me.Animal.HeaderText = "Animal"
      Me.Animal.Name = "Animal"
      Me.Animal.ReadOnly = True
      Me.Animal.Width = 130
      '
      'Status
      '
      Me.Status.HeaderText = "Status"
      Me.Status.Name = "Status"
      Me.Status.ReadOnly = True
      '
      'Obs
      '
      Me.Obs.HeaderText = "Obs"
      Me.Obs.Name = "Obs"
      Me.Obs.ReadOnly = True
      Me.Obs.Visible = False
      '
      'CodigoAnimal
      '
      Me.CodigoAnimal.HeaderText = "CodigoAnimal"
      Me.CodigoAnimal.Name = "CodigoAnimal"
      Me.CodigoAnimal.ReadOnly = True
      Me.CodigoAnimal.Visible = False
      '
      'CodigoServico
      '
      Me.CodigoServico.HeaderText = "CodigoServico"
      Me.CodigoServico.Name = "CodigoServico"
      Me.CodigoServico.ReadOnly = True
      Me.CodigoServico.Visible = False
      '
      'txtServicodesc
      '
      Me.txtServicodesc.BackColor = System.Drawing.Color.WhiteSmoke
      '
      '
      '
      Me.txtServicodesc.CustomButton.Image = Nothing
      Me.txtServicodesc.CustomButton.Location = New System.Drawing.Point(202, 1)
      Me.txtServicodesc.CustomButton.Name = ""
      Me.txtServicodesc.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.txtServicodesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtServicodesc.CustomButton.TabIndex = 1
      Me.txtServicodesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtServicodesc.CustomButton.UseSelectable = True
      Me.txtServicodesc.CustomButton.Visible = False
      Me.txtServicodesc.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtServicodesc.Lines = New String(-1) {}
      Me.txtServicodesc.Location = New System.Drawing.Point(103, 165)
      Me.txtServicodesc.MaxLength = 5
      Me.txtServicodesc.Name = "txtServicodesc"
      Me.txtServicodesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtServicodesc.ReadOnly = True
      Me.txtServicodesc.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtServicodesc.SelectedText = ""
      Me.txtServicodesc.SelectionLength = 0
      Me.txtServicodesc.SelectionStart = 0
      Me.txtServicodesc.ShortcutsEnabled = True
      Me.txtServicodesc.Size = New System.Drawing.Size(230, 29)
      Me.txtServicodesc.TabIndex = 54
      Me.txtServicodesc.UseCustomBackColor = True
      Me.txtServicodesc.UseCustomForeColor = True
      Me.txtServicodesc.UseSelectable = True
      Me.txtServicodesc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtServicodesc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'txtAnimalNome
      '
      Me.txtAnimalNome.BackColor = System.Drawing.Color.WhiteSmoke
      '
      '
      '
      Me.txtAnimalNome.CustomButton.Image = Nothing
      Me.txtAnimalNome.CustomButton.Location = New System.Drawing.Point(202, 1)
      Me.txtAnimalNome.CustomButton.Name = ""
      Me.txtAnimalNome.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.txtAnimalNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtAnimalNome.CustomButton.TabIndex = 1
      Me.txtAnimalNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtAnimalNome.CustomButton.UseSelectable = True
      Me.txtAnimalNome.CustomButton.Visible = False
      Me.txtAnimalNome.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtAnimalNome.Lines = New String(-1) {}
      Me.txtAnimalNome.Location = New System.Drawing.Point(103, 223)
      Me.txtAnimalNome.MaxLength = 5
      Me.txtAnimalNome.Name = "txtAnimalNome"
      Me.txtAnimalNome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtAnimalNome.ReadOnly = True
      Me.txtAnimalNome.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtAnimalNome.SelectedText = ""
      Me.txtAnimalNome.SelectionLength = 0
      Me.txtAnimalNome.SelectionStart = 0
      Me.txtAnimalNome.ShortcutsEnabled = True
      Me.txtAnimalNome.Size = New System.Drawing.Size(230, 29)
      Me.txtAnimalNome.TabIndex = 55
      Me.txtAnimalNome.UseCustomBackColor = True
      Me.txtAnimalNome.UseCustomForeColor = True
      Me.txtAnimalNome.UseSelectable = True
      Me.txtAnimalNome.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtAnimalNome.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'txtHorarioInicio
      '
      Me.txtHorarioInicio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtHorarioInicio.Location = New System.Drawing.Point(22, 279)
      Me.txtHorarioInicio.Mask = "90:00"
      Me.txtHorarioInicio.Name = "txtHorarioInicio"
      Me.txtHorarioInicio.Size = New System.Drawing.Size(140, 29)
      Me.txtHorarioInicio.TabIndex = 2
      Me.txtHorarioInicio.ValidatingType = GetType(Date)
      '
      'txtHorarioFim
      '
      Me.txtHorarioFim.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtHorarioFim.Location = New System.Drawing.Point(193, 279)
      Me.txtHorarioFim.Mask = "90:00"
      Me.txtHorarioFim.Name = "txtHorarioFim"
      Me.txtHorarioFim.Size = New System.Drawing.Size(140, 29)
      Me.txtHorarioFim.TabIndex = 3
      Me.txtHorarioFim.ValidatingType = GetType(Date)
      '
      'lblGrid
      '
      Me.lblGrid.AutoSize = True
      Me.lblGrid.Location = New System.Drawing.Point(626, 318)
      Me.lblGrid.Name = "lblGrid"
      Me.lblGrid.Size = New System.Drawing.Size(0, 0)
      Me.lblGrid.TabIndex = 59
      '
      'Button1
      '
      Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
      Me.Button1.FlatAppearance.BorderSize = 0
      Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Button1.ForeColor = System.Drawing.Color.White
      Me.Button1.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Login_Rounded_Up_32px1
      Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.Button1.Location = New System.Drawing.Point(751, 532)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(111, 45)
      Me.Button1.TabIndex = 61
      Me.Button1.Text = "Informar chegada"
      Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.Button1.UseVisualStyleBackColor = False
      '
      'BtConfirmar
      '
      Me.BtConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
      Me.BtConfirmar.FlatAppearance.BorderSize = 0
      Me.BtConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.BtConfirmar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.BtConfirmar.ForeColor = System.Drawing.Color.White
      Me.BtConfirmar.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Checked_32px
      Me.BtConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.BtConfirmar.Location = New System.Drawing.Point(889, 532)
      Me.BtConfirmar.Name = "BtConfirmar"
      Me.BtConfirmar.Size = New System.Drawing.Size(120, 45)
      Me.BtConfirmar.TabIndex = 60
      Me.BtConfirmar.Text = "Finalizar Atendimento"
      Me.BtConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.BtConfirmar.UseVisualStyleBackColor = False
      '
      'BtNovo
      '
      Me.BtNovo.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
      Me.BtNovo.FlatAppearance.BorderSize = 0
      Me.BtNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.BtNovo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.BtNovo.ForeColor = System.Drawing.Color.White
      Me.BtNovo.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Plus_32px
      Me.BtNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.BtNovo.Location = New System.Drawing.Point(23, 532)
      Me.BtNovo.Name = "BtNovo"
      Me.BtNovo.Size = New System.Drawing.Size(129, 45)
      Me.BtNovo.TabIndex = 8
      Me.BtNovo.Text = "Novo"
      Me.BtNovo.UseVisualStyleBackColor = False
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Calendar_64px
      Me.PictureBox1.Location = New System.Drawing.Point(847, 18)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(90, 62)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.PictureBox1.TabIndex = 45
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
      Me.btsalvar.Location = New System.Drawing.Point(204, 532)
      Me.btsalvar.Name = "btsalvar"
      Me.btsalvar.Size = New System.Drawing.Size(129, 45)
      Me.btsalvar.TabIndex = 6
      Me.btsalvar.Text = "Salvar"
      Me.btsalvar.UseVisualStyleBackColor = False
      '
      'frmAgendaEvento
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1024, 600)
      Me.Controls.Add(Me.Button1)
      Me.Controls.Add(Me.BtConfirmar)
      Me.Controls.Add(Me.txtHorarioFim)
      Me.Controls.Add(Me.txtHorarioInicio)
      Me.Controls.Add(Me.BtNovo)
      Me.Controls.Add(Me.txtAnimalNome)
      Me.Controls.Add(Me.txtServicodesc)
      Me.Controls.Add(Me.dgvAgenda)
      Me.Controls.Add(Me.txtCodigo)
      Me.Controls.Add(Me.lblCodigo)
      Me.Controls.Add(Me.txtObservacao)
      Me.Controls.Add(Me.lblObservacao)
      Me.Controls.Add(Me.txtAnimal)
      Me.Controls.Add(Me.lblAnimal)
      Me.Controls.Add(Me.MetroLabel1)
      Me.Controls.Add(Me.dtData)
      Me.Controls.Add(Me.lblHorariofim)
      Me.Controls.Add(Me.PictureBox1)
      Me.Controls.Add(Me.lblHorarioinicio)
      Me.Controls.Add(Me.btsalvar)
      Me.Controls.Add(Me.txtServico)
      Me.Controls.Add(Me.lblServico)
      Me.Controls.Add(Me.lblGrid)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.Movable = False
      Me.Name = "frmAgendaEvento"
      Me.Resizable = False
      Me.Style = MetroFramework.MetroColorStyle.Green
      Me.Text = "AgendaEvento"
      CType(Me.dgvAgenda, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents lblHorariofim As MetroFramework.Controls.MetroLabel
   Friend WithEvents PictureBox1 As PictureBox
   Friend WithEvents lblHorarioinicio As MetroFramework.Controls.MetroLabel
   Friend WithEvents btsalvar As Button
   Friend WithEvents lblServico As MetroFramework.Controls.MetroLabel
   Friend WithEvents txtServico As MetroFramework.Controls.MetroTextBox
   Friend WithEvents dtData As MetroFramework.Controls.MetroDateTime
   Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
   Friend WithEvents txtAnimal As MetroFramework.Controls.MetroTextBox
   Friend WithEvents lblAnimal As MetroFramework.Controls.MetroLabel
   Friend WithEvents txtObservacao As MetroFramework.Controls.MetroTextBox
   Friend WithEvents lblObservacao As MetroFramework.Controls.MetroLabel
   Friend WithEvents txtCodigo As MetroFramework.Controls.MetroTextBox
   Friend WithEvents lblCodigo As MetroFramework.Controls.MetroLabel
   Friend WithEvents dgvAgenda As DataGridView
   Friend WithEvents txtServicodesc As MetroFramework.Controls.MetroTextBox
   Friend WithEvents txtAnimalNome As MetroFramework.Controls.MetroTextBox
   Friend WithEvents BtNovo As Button
   Friend WithEvents txtHorarioInicio As MaskedTextBox
   Friend WithEvents txtHorarioFim As MaskedTextBox
   Friend WithEvents lblGrid As MetroFramework.Controls.MetroLabel
   Friend WithEvents BtConfirmar As Button
   Friend WithEvents Button1 As Button
   Friend WithEvents Codigo As DataGridViewTextBoxColumn
   Friend WithEvents Data As DataGridViewTextBoxColumn
   Friend WithEvents HorarioInicio As DataGridViewTextBoxColumn
   Friend WithEvents HorarioFim As DataGridViewTextBoxColumn
   Friend WithEvents Servico As DataGridViewTextBoxColumn
   Friend WithEvents Animal As DataGridViewTextBoxColumn
   Friend WithEvents Status As DataGridViewTextBoxColumn
   Friend WithEvents Obs As DataGridViewTextBoxColumn
   Friend WithEvents CodigoAnimal As DataGridViewTextBoxColumn
   Friend WithEvents CodigoServico As DataGridViewTextBoxColumn
End Class
