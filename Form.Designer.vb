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
    Me.SuspendLayout()
    '
    'Form
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.ControlLight
    Me.ClientSize = New System.Drawing.Size(918, 526)
    Me.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "Form"
    Me.Text = "Form"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

End Class
