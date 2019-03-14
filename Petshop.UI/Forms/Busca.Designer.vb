<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busca
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvPesq = New System.Windows.Forms.DataGridView()
        Me.txtPesquisa = New MetroFramework.Controls.MetroTextBox()
        Me.lblPesquisa = New MetroFramework.Controls.MetroLabel()
        Me.btPesq = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvPesq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPesq
        '
        Me.dgvPesq.AllowUserToAddRows = False
        Me.dgvPesq.AllowUserToDeleteRows = False
        Me.dgvPesq.AllowUserToOrderColumns = True
        Me.dgvPesq.BackgroundColor = System.Drawing.Color.White
        Me.dgvPesq.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPesq.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPesq.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPesq.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPesq.EnableHeadersVisualStyles = False
        Me.dgvPesq.GridColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.dgvPesq.Location = New System.Drawing.Point(45, 171)
        Me.dgvPesq.MultiSelect = False
        Me.dgvPesq.Name = "dgvPesq"
        Me.dgvPesq.ReadOnly = True
        Me.dgvPesq.RowHeadersVisible = False
        Me.dgvPesq.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvPesq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPesq.Size = New System.Drawing.Size(553, 322)
        Me.dgvPesq.TabIndex = 101
        '
        'txtPesquisa
        '
        '
        '
        '
        Me.txtPesquisa.CustomButton.Image = Nothing
        Me.txtPesquisa.CustomButton.Location = New System.Drawing.Point(418, 1)
        Me.txtPesquisa.CustomButton.Name = ""
        Me.txtPesquisa.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPesquisa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPesquisa.CustomButton.TabIndex = 1
        Me.txtPesquisa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPesquisa.CustomButton.UseSelectable = True
        Me.txtPesquisa.CustomButton.Visible = False
        Me.txtPesquisa.Lines = New String(-1) {}
        Me.txtPesquisa.Location = New System.Drawing.Point(45, 110)
        Me.txtPesquisa.MaxLength = 5
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPesquisa.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPesquisa.SelectedText = ""
        Me.txtPesquisa.SelectionLength = 0
        Me.txtPesquisa.SelectionStart = 0
        Me.txtPesquisa.ShortcutsEnabled = True
        Me.txtPesquisa.Size = New System.Drawing.Size(440, 23)
        Me.txtPesquisa.TabIndex = 103
        Me.txtPesquisa.UseSelectable = True
        Me.txtPesquisa.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPesquisa.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblPesquisa
        '
        Me.lblPesquisa.AutoSize = True
        Me.lblPesquisa.Location = New System.Drawing.Point(44, 88)
        Me.lblPesquisa.Name = "lblPesquisa"
        Me.lblPesquisa.Size = New System.Drawing.Size(58, 19)
        Me.lblPesquisa.TabIndex = 102
        Me.lblPesquisa.Text = "Pesquisa"
        '
        'btPesq
        '
        Me.btPesq.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btPesq.FlatAppearance.BorderSize = 0
        Me.btPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btPesq.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPesq.ForeColor = System.Drawing.Color.White
        Me.btPesq.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Search_32px
        Me.btPesq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btPesq.Location = New System.Drawing.Point(491, 104)
        Me.btPesq.Name = "btPesq"
        Me.btPesq.Size = New System.Drawing.Size(107, 34)
        Me.btPesq.TabIndex = 104
        Me.btPesq.Text = "Pesquisar"
        Me.btPesq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btPesq.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Search_Property_64px
        Me.PictureBox1.Location = New System.Drawing.Point(98, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Busca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 565)
        Me.Controls.Add(Me.btPesq)
        Me.Controls.Add(Me.txtPesquisa)
        Me.Controls.Add(Me.lblPesquisa)
        Me.Controls.Add(Me.dgvPesq)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Busca"
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Busca"
        CType(Me.dgvPesq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvPesq As DataGridView
    Friend WithEvents txtPesquisa As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblPesquisa As MetroFramework.Controls.MetroLabel
    Friend WithEvents btPesq As Button
End Class
