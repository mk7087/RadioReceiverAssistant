Public Class Form
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Text = My.Application.Info.Title
    TableLayoutPanel1.RowStyles(0) = New RowStyle(SizeType.Absolute, Me.SearchTypeBox.Height + 6)
  End Sub
End Class
