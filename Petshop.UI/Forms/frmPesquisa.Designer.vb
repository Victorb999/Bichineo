<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesquisa
    'Inherits System.Windows.Forms.Form
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPesquisa))
      Me.dgvPesq = New System.Windows.Forms.DataGridView()
      Me.txtPesquisa = New MetroFramework.Controls.MetroTextBox()
      Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
      Me.lblGrid = New MetroFramework.Controls.MetroLabel()
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
      Me.dgvPesq.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
      Me.dgvPesq.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
      DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
      DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aquamarine
      DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
      DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.dgvPesq.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
      DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
      DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
      DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Aquamarine
      DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
      DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
      Me.dgvPesq.DefaultCellStyle = DataGridViewCellStyle2
      Me.dgvPesq.EnableHeadersVisualStyles = False
      Me.dgvPesq.GridColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(43, Byte), Integer))
      Me.dgvPesq.Location = New System.Drawing.Point(23, 165)
      Me.dgvPesq.MultiSelect = False
      Me.dgvPesq.Name = "dgvPesq"
      Me.dgvPesq.ReadOnly = True
      Me.dgvPesq.RowHeadersVisible = False
      Me.dgvPesq.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
      Me.dgvPesq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.dgvPesq.Size = New System.Drawing.Size(940, 288)
      Me.dgvPesq.TabIndex = 3
      '
      'txtPesquisa
      '
      '
      '
      '
      Me.txtPesquisa.CustomButton.Image = Nothing
      Me.txtPesquisa.CustomButton.Location = New System.Drawing.Point(298, 1)
      Me.txtPesquisa.CustomButton.Name = ""
      Me.txtPesquisa.CustomButton.Size = New System.Drawing.Size(27, 27)
      Me.txtPesquisa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
      Me.txtPesquisa.CustomButton.TabIndex = 1
      Me.txtPesquisa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
      Me.txtPesquisa.CustomButton.UseSelectable = True
      Me.txtPesquisa.CustomButton.Visible = False
      Me.txtPesquisa.FontSize = MetroFramework.MetroTextBoxSize.Medium
      Me.txtPesquisa.FontWeight = MetroFramework.MetroTextBoxWeight.Light
      Me.txtPesquisa.Lines = New String(-1) {}
      Me.txtPesquisa.Location = New System.Drawing.Point(23, 121)
      Me.txtPesquisa.MaxLength = 50
      Me.txtPesquisa.Name = "txtPesquisa"
      Me.txtPesquisa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
      Me.txtPesquisa.ScrollBars = System.Windows.Forms.ScrollBars.None
      Me.txtPesquisa.SelectedText = ""
      Me.txtPesquisa.SelectionLength = 0
      Me.txtPesquisa.SelectionStart = 0
      Me.txtPesquisa.ShortcutsEnabled = True
      Me.txtPesquisa.Size = New System.Drawing.Size(326, 29)
      Me.txtPesquisa.Style = MetroFramework.MetroColorStyle.Green
      Me.txtPesquisa.TabIndex = 0
      Me.txtPesquisa.UseSelectable = True
      Me.txtPesquisa.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
      Me.txtPesquisa.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
      '
      'MetroButton1
      '
      Me.MetroButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(151, Byte), Integer))
      Me.MetroButton1.ForeColor = System.Drawing.Color.White
      Me.MetroButton1.Location = New System.Drawing.Point(356, 121)
      Me.MetroButton1.Name = "MetroButton1"
      Me.MetroButton1.Size = New System.Drawing.Size(111, 29)
      Me.MetroButton1.TabIndex = 4
      Me.MetroButton1.Text = "Filtrar"
      Me.MetroButton1.UseCustomBackColor = True
      Me.MetroButton1.UseCustomForeColor = True
      Me.MetroButton1.UseSelectable = True
      Me.MetroButton1.UseStyleColors = True
      '
      'lblGrid
      '
      Me.lblGrid.AutoSize = True
      Me.lblGrid.Location = New System.Drawing.Point(524, 130)
      Me.lblGrid.Name = "lblGrid"
      Me.lblGrid.Size = New System.Drawing.Size(0, 0)
      Me.lblGrid.TabIndex = 5
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = Global.Petshop.UI.My.Resources.Resources.icons8_Search_Property_64px
      Me.PictureBox1.Location = New System.Drawing.Point(129, 8)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(90, 62)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
      Me.PictureBox1.TabIndex = 6
      Me.PictureBox1.TabStop = False
      '
      'frmPesquisa
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(1000, 500)
      Me.Controls.Add(Me.PictureBox1)
      Me.Controls.Add(Me.lblGrid)
      Me.Controls.Add(Me.MetroButton1)
      Me.Controls.Add(Me.txtPesquisa)
      Me.Controls.Add(Me.dgvPesq)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmPesquisa"
      Me.Resizable = False
      Me.Style = MetroFramework.MetroColorStyle.Green
      Me.Text = "Pesquisa"
      CType(Me.dgvPesq, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

    Friend WithEvents dgvPesq As DataGridView
    Friend WithEvents txtPesquisa As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
   Friend WithEvents lblGrid As MetroFramework.Controls.MetroLabel
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
