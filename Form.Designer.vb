<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
  Inherits System.Windows.Forms.Form

  'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
  <System.Diagnostics.DebuggerNonUserCode()>
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Windows フォーム デザイナーで必要です。
  Private components As System.ComponentModel.IContainer

  'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
  'Windows フォーム デザイナーを使用して変更できます。  
  'コード エディターを使って変更しないでください。
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
    Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
    Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.TextBox2 = New System.Windows.Forms.TextBox()
    Me.SearchLabel2 = New System.Windows.Forms.Label()
    Me.DataGridView1 = New System.Windows.Forms.DataGridView()
    Me.SearchLabel = New System.Windows.Forms.Label()
    Me.SearchBox = New System.Windows.Forms.TextBox()
    Me.ComboBox1 = New System.Windows.Forms.ComboBox()
    Me.StatusStrip1.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'StatusStrip1
    '
    Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
    Me.StatusStrip1.Location = New System.Drawing.Point(0, 504)
    Me.StatusStrip1.Name = "StatusStrip1"
    Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
    Me.StatusStrip1.Size = New System.Drawing.Size(918, 22)
    Me.StatusStrip1.TabIndex = 0
    Me.StatusStrip1.Text = "StatusStrip1"
    '
    'ToolStripStatusLabel1
    '
    Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
    Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
    Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
    Me.ToolStripStatusLabel1.Visible = False
    '
    'ToolStripProgressBar1
    '
    Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
    Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
    Me.ToolStripProgressBar1.Visible = False
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
    Me.MenuStrip1.Size = New System.Drawing.Size(1080, 25)
    Me.MenuStrip1.TabIndex = 1
    Me.MenuStrip1.Text = "MenuStrip1"
    Me.MenuStrip1.Visible = False
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight
    Me.TableLayoutPanel1.ColumnCount = 5
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 4, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.SearchLabel2, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.SearchLabel, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.SearchBox, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.ComboBox1, 3, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(918, 504)
    Me.TableLayoutPanel1.TabIndex = 2
    '
    'TextBox2
    '
    Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TextBox2.Location = New System.Drawing.Point(895, 5)
    Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TextBox2.Name = "TextBox2"
    Me.TextBox2.Size = New System.Drawing.Size(19, 27)
    Me.TextBox2.TabIndex = 6
    '
    'SearchLabel2
    '
    Me.SearchLabel2.AutoSize = True
    Me.SearchLabel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SearchLabel2.Location = New System.Drawing.Point(471, 5)
    Me.SearchLabel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.SearchLabel2.Name = "SearchLabel2"
    Me.SearchLabel2.Size = New System.Drawing.Size(45, 32)
    Me.SearchLabel2.TabIndex = 5
    Me.SearchLabel2.Text = "種類別検索"
    Me.SearchLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'DataGridView1
    '
    Me.DataGridView1.AllowUserToAddRows = False
    Me.DataGridView1.AllowUserToDeleteRows = False
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.TableLayoutPanel1.SetColumnSpan(Me.DataGridView1, 5)
    Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridView1.Location = New System.Drawing.Point(0, 42)
    Me.DataGridView1.Margin = New System.Windows.Forms.Padding(0)
    Me.DataGridView1.Name = "DataGridView1"
    Me.DataGridView1.ReadOnly = True
    Me.DataGridView1.RowTemplate.Height = 21
    Me.DataGridView1.Size = New System.Drawing.Size(918, 462)
    Me.DataGridView1.TabIndex = 0
    '
    'SearchLabel
    '
    Me.SearchLabel.AutoSize = True
    Me.SearchLabel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SearchLabel.Location = New System.Drawing.Point(4, 5)
    Me.SearchLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.SearchLabel.Name = "SearchLabel"
    Me.SearchLabel.Size = New System.Drawing.Size(88, 32)
    Me.SearchLabel.TabIndex = 1
    Me.SearchLabel.Text = "検索文字列"
    Me.SearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'SearchBox
    '
    Me.SearchBox.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SearchBox.Location = New System.Drawing.Point(100, 5)
    Me.SearchBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.SearchBox.Name = "SearchBox"
    Me.SearchBox.Size = New System.Drawing.Size(363, 27)
    Me.SearchBox.TabIndex = 2
    '
    'ComboBox1
    '
    Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ComboBox1.FormattingEnabled = True
    Me.ComboBox1.Location = New System.Drawing.Point(524, 5)
    Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.ComboBox1.Name = "ComboBox1"
    Me.ComboBox1.Size = New System.Drawing.Size(363, 28)
    Me.ComboBox1.TabIndex = 4
    '
    'Form
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.ControlLight
    Me.ClientSize = New System.Drawing.Size(918, 526)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.StatusStrip1)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "Form"
    Me.Text = "Form1"
    Me.StatusStrip1.ResumeLayout(False)
    Me.StatusStrip1.PerformLayout()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents StatusStrip1 As StatusStrip
  Friend WithEvents MenuStrip1 As MenuStrip
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents DataGridView1 As DataGridView
  Friend WithEvents TextBox2 As TextBox
  Friend WithEvents SearchLabel2 As Label
  Friend WithEvents SearchLabel As Label
  Friend WithEvents SearchBox As TextBox
  Friend WithEvents ComboBox1 As ComboBox
  Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
  Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
End Class
