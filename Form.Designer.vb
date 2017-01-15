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
    Me.MenuStrip = New System.Windows.Forms.MenuStrip()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.TypeSearchBox = New System.Windows.Forms.TextBox()
    Me.TypeSearchLabel = New System.Windows.Forms.Label()
    Me.DataGridView1 = New System.Windows.Forms.DataGridView()
    Me.SearchLabel = New System.Windows.Forms.Label()
    Me.SearchBox = New System.Windows.Forms.TextBox()
    Me.SearchTypeBox = New System.Windows.Forms.ComboBox()
    Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
    Me.ShowHelp = New System.Windows.Forms.ToolStripMenuItem()
    Me.VersionInfo = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
    Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
    Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
    Me.Copy = New System.Windows.Forms.ToolStripMenuItem()
    Me.Paste = New System.Windows.Forms.ToolStripMenuItem()
    Me.Close = New System.Windows.Forms.ToolStripMenuItem()
    Me.CreateData = New System.Windows.Forms.ToolStripMenuItem()
    Me.OpenData = New System.Windows.Forms.ToolStripMenuItem()
    Me.SaveAs = New System.Windows.Forms.ToolStripMenuItem()
    Me.SaveData = New System.Windows.Forms.ToolStripMenuItem()
    Me.Separator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.Export = New System.Windows.Forms.ToolStripMenuItem()
    Me.Separator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.ExportToXML = New System.Windows.Forms.ToolStripMenuItem()
    Me.ExportToHTML = New System.Windows.Forms.ToolStripMenuItem()
    Me.ExportToText = New System.Windows.Forms.ToolStripMenuItem()
    Me.Config = New System.Windows.Forms.ToolStripMenuItem()
    Me.Delete = New System.Windows.Forms.ToolStripMenuItem()
    Me.StatusStrip.SuspendLayout()
    Me.MenuStrip.SuspendLayout()
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
    Me.ToolStripStatusLabel.Size = New System.Drawing.Size(696, 17)
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
    'MenuStrip
    '
    Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.ToolsMenu, Me.HelpMenu})
    Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip.Name = "MenuStrip"
    Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
    Me.MenuStrip.Size = New System.Drawing.Size(918, 25)
    Me.MenuStrip.TabIndex = 1
    Me.MenuStrip.Text = "MenuStrip1"
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
    'HelpMenu
    '
    Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowHelp, Me.VersionInfo})
    Me.HelpMenu.Name = "HelpMenu"
    Me.HelpMenu.Size = New System.Drawing.Size(65, 19)
    Me.HelpMenu.Text = "ヘルプ(&H)"
    '
    'ShowHelp
    '
    Me.ShowHelp.Name = "ShowHelp"
    Me.ShowHelp.Size = New System.Drawing.Size(152, 22)
    Me.ShowHelp.Text = "ヘルプの表示"
    Me.ShowHelp.Visible = False
    '
    'VersionInfo
    '
    Me.VersionInfo.Name = "VersionInfo"
    Me.VersionInfo.Size = New System.Drawing.Size(152, 22)
    Me.VersionInfo.Text = "バージョン情報"
    '
    'ToolsMenu
    '
    Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Config})
    Me.ToolsMenu.Name = "ToolsMenu"
    Me.ToolsMenu.Size = New System.Drawing.Size(60, 19)
    Me.ToolsMenu.Text = "ツール(&T)"
    '
    'FileMenu
    '
    Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateData, Me.OpenData, Me.SaveData, Me.SaveAs, Me.Separator1, Me.Export, Me.Separator2, Me.Close})
    Me.FileMenu.Name = "FileMenu"
    Me.FileMenu.Size = New System.Drawing.Size(52, 19)
    Me.FileMenu.Text = "ファイル"
    Me.FileMenu.Visible = False
    '
    'EditMenu
    '
    Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Copy, Me.Paste, Me.Delete})
    Me.EditMenu.Name = "EditMenu"
    Me.EditMenu.Size = New System.Drawing.Size(43, 19)
    Me.EditMenu.Text = "編集"
    Me.EditMenu.Visible = False
    '
    'Copy
    '
    Me.Copy.Name = "Copy"
    Me.Copy.Size = New System.Drawing.Size(152, 22)
    Me.Copy.Text = "コピー"
    '
    'Paste
    '
    Me.Paste.Name = "Paste"
    Me.Paste.Size = New System.Drawing.Size(152, 22)
    Me.Paste.Text = "貼り付け"
    '
    'Close
    '
    Me.Close.Name = "Close"
    Me.Close.Size = New System.Drawing.Size(153, 22)
    Me.Close.Text = "閉じる"
    '
    'CreateData
    '
    Me.CreateData.Name = "CreateData"
    Me.CreateData.Size = New System.Drawing.Size(153, 22)
    Me.CreateData.Text = "新しい表を作成"
    '
    'OpenData
    '
    Me.OpenData.Name = "OpenData"
    Me.OpenData.Size = New System.Drawing.Size(153, 22)
    Me.OpenData.Text = "表を開く"
    '
    'SaveAs
    '
    Me.SaveAs.Name = "SaveAs"
    Me.SaveAs.Size = New System.Drawing.Size(153, 22)
    Me.SaveAs.Text = "表を別名で保存"
    '
    'SaveData
    '
    Me.SaveData.Name = "SaveData"
    Me.SaveData.Size = New System.Drawing.Size(153, 22)
    Me.SaveData.Text = "表を上書き保存"
    '
    'Separator2
    '
    Me.Separator2.Name = "Separator2"
    Me.Separator2.Size = New System.Drawing.Size(150, 6)
    '
    'Export
    '
    Me.Export.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToXML, Me.ExportToHTML, Me.ExportToText})
    Me.Export.Name = "Export"
    Me.Export.Size = New System.Drawing.Size(153, 22)
    Me.Export.Text = "エクスポート"
    '
    'Separator1
    '
    Me.Separator1.Name = "Separator1"
    Me.Separator1.Size = New System.Drawing.Size(150, 6)
    '
    'ExportToXML
    '
    Me.ExportToXML.Name = "ExportToXML"
    Me.ExportToXML.Size = New System.Drawing.Size(152, 22)
    Me.ExportToXML.Text = "XML"
    '
    'ExportToHTML
    '
    Me.ExportToHTML.Name = "ExportToHTML"
    Me.ExportToHTML.Size = New System.Drawing.Size(152, 22)
    Me.ExportToHTML.Text = "HTML"
    '
    'ExportToText
    '
    Me.ExportToText.Name = "ExportToText"
    Me.ExportToText.Size = New System.Drawing.Size(152, 22)
    Me.ExportToText.Text = "テキストファイル"
    '
    'Config
    '
    Me.Config.Name = "Config"
    Me.Config.Size = New System.Drawing.Size(152, 22)
    Me.Config.Text = "設定"
    '
    'Delete
    '
    Me.Delete.Name = "Delete"
    Me.Delete.Size = New System.Drawing.Size(152, 22)
    Me.Delete.Text = "削除"
    '
    'Form
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.ControlLight
    Me.ClientSize = New System.Drawing.Size(918, 526)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.StatusStrip)
    Me.Controls.Add(Me.MenuStrip)
    Me.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me.MainMenuStrip = Me.MenuStrip
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "Form"
    Me.Text = "Form1"
    Me.StatusStrip.ResumeLayout(False)
    Me.StatusStrip.PerformLayout()
    Me.MenuStrip.ResumeLayout(False)
    Me.MenuStrip.PerformLayout()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents StatusStrip As StatusStrip
  Friend WithEvents MenuStrip As MenuStrip
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents DataGridView1 As DataGridView
  Friend WithEvents TypeSearchBox As TextBox
  Friend WithEvents TypeSearchLabel As Label
  Friend WithEvents SearchLabel As Label
  Friend WithEvents SearchBox As TextBox
  Friend WithEvents SearchTypeBox As ComboBox
  Friend WithEvents ToolStripStatusLabel As ToolStripStatusLabel
  Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
  Friend WithEvents HelpMenu As ToolStripMenuItem
  Friend WithEvents ShowHelp As ToolStripMenuItem
  Friend WithEvents VersionInfo As ToolStripMenuItem
  Friend WithEvents ToolsMenu As ToolStripMenuItem
  Friend WithEvents FileMenu As ToolStripMenuItem
  Friend WithEvents EditMenu As ToolStripMenuItem
  Friend WithEvents Copy As ToolStripMenuItem
  Friend WithEvents Paste As ToolStripMenuItem
  Friend WithEvents CreateData As ToolStripMenuItem
  Friend WithEvents OpenData As ToolStripMenuItem
  Friend WithEvents SaveData As ToolStripMenuItem
  Friend WithEvents SaveAs As ToolStripMenuItem
  Friend WithEvents Separator1 As ToolStripSeparator
  Friend WithEvents Export As ToolStripMenuItem
  Friend WithEvents ExportToXML As ToolStripMenuItem
  Friend WithEvents ExportToHTML As ToolStripMenuItem
  Friend WithEvents ExportToText As ToolStripMenuItem
  Friend WithEvents Separator2 As ToolStripSeparator
  Friend WithEvents Close As ToolStripMenuItem
  Friend WithEvents Config As ToolStripMenuItem
  Friend WithEvents Delete As ToolStripMenuItem
End Class
