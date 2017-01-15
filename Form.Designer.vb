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
    Me.StatusStrip = New System.Windows.Forms.StatusStrip()
    Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
    Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.TypeSearchBox = New System.Windows.Forms.TextBox()
    Me.TypeSearchLabel = New System.Windows.Forms.Label()
    Me.DataGridView1 = New System.Windows.Forms.DataGridView()
    Me.SearchLabel = New System.Windows.Forms.Label()
    Me.SearchBox = New System.Windows.Forms.TextBox()
    Me.SearchTypeBox = New System.Windows.Forms.ComboBox()
    Me.StatusStrip.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'StatusStrip
    '
    Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.ToolStripProgressBar1})
    Me.StatusStrip.Location = New System.Drawing.Point(0, 504)
    Me.StatusStrip.Name = "StatusStrip"
    Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
    Me.StatusStrip.Size = New System.Drawing.Size(918, 22)
    Me.StatusStrip.TabIndex = 0
    Me.StatusStrip.Text = "StatusStrip1"
    '
    'ToolStripStatusLabel
    '
    Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
    Me.ToolStripStatusLabel.Size = New System.Drawing.Size(765, 17)
    Me.ToolStripStatusLabel.Spring = True
    Me.ToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.ToolStripStatusLabel.Visible = False
    '
    'ToolStripProgressBar1
    '
    Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
    Me.ToolStripProgressBar1.Size = New System.Drawing.Size(200, 16)
    Me.ToolStripProgressBar1.Step = 1
    Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
    Me.ToolStripProgressBar1.Visible = False
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
    Me.MenuStrip1.Size = New System.Drawing.Size(918, 25)
    Me.MenuStrip1.TabIndex = 1
    Me.MenuStrip1.Text = "MenuStrip1"
    Me.MenuStrip1.Visible = False
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight
    Me.TableLayoutPanel1.ColumnCount = 5
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.TypeSearchBox, 4, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.TypeSearchLabel, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.SearchLabel, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.SearchBox, 1, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.SearchTypeBox, 3, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
    Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(918, 479)
    Me.TableLayoutPanel1.TabIndex = 2
    '
    'TypeSearchBox
    '
    Me.TypeSearchBox.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TypeSearchBox.Location = New System.Drawing.Point(848, 5)
    Me.TypeSearchBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TypeSearchBox.Name = "TypeSearchBox"
    Me.TypeSearchBox.Size = New System.Drawing.Size(66, 27)
    Me.TypeSearchBox.TabIndex = 6
    '
    'TypeSearchLabel
    '
    Me.TypeSearchLabel.AutoSize = True
    Me.TypeSearchLabel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TypeSearchLabel.Location = New System.Drawing.Point(680, 5)
    Me.TypeSearchLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TypeSearchLabel.Name = "TypeSearchLabel"
    Me.TypeSearchLabel.Size = New System.Drawing.Size(88, 32)
    Me.TypeSearchLabel.TabIndex = 5
    Me.TypeSearchLabel.Text = "種類別検索"
    Me.TypeSearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
    Me.DataGridView1.Size = New System.Drawing.Size(918, 437)
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
    Me.SearchBox.Size = New System.Drawing.Size(572, 27)
    Me.SearchBox.TabIndex = 2
    '
    'SearchTypeBox
    '
    Me.SearchTypeBox.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SearchTypeBox.FormattingEnabled = True
    Me.SearchTypeBox.Location = New System.Drawing.Point(776, 5)
    Me.SearchTypeBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.SearchTypeBox.Name = "SearchTypeBox"
    Me.SearchTypeBox.Size = New System.Drawing.Size(64, 28)
    Me.SearchTypeBox.TabIndex = 4
    '
    'Form
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.ControlLight
    Me.ClientSize = New System.Drawing.Size(918, 526)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.StatusStrip)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "Form"
    Me.Text = "Form1"
    Me.StatusStrip.ResumeLayout(False)
    Me.StatusStrip.PerformLayout()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents StatusStrip As StatusStrip
  Friend WithEvents MenuStrip1 As MenuStrip
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents DataGridView1 As DataGridView
  Friend WithEvents TypeSearchBox As TextBox
  Friend WithEvents TypeSearchLabel As Label
  Friend WithEvents SearchLabel As Label
  Friend WithEvents SearchBox As TextBox
  Friend WithEvents SearchTypeBox As ComboBox
  Friend WithEvents ToolStripStatusLabel As ToolStripStatusLabel
  Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
End Class
