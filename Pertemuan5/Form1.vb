
Public Class Form1
        Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
            If (Val(txtNilaiAkhir.Text) >= 60) Then
            txtKeterangan2.Text = "Anda Lulus"
        Else
            txtKeterangan2.Text = "Anda tidak Lulus, Silahkan mengulang semester depan"
        End If
        End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
