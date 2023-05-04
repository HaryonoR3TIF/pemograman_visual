Public Class Form1
    Private Sub Form1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form1ToolstripMenuItem.Click
        Dim F2 As New Form2
        F2.ShowDialog()
    End Sub

    Private Sub Form2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form2ToolStripMenuItem.Click
        Dim F3 As New Form3
        F3.ShowDialog()
    End Sub
End Class
