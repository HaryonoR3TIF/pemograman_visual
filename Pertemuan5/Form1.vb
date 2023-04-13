Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(TxtMasaKerja.Text) >= 20) Then
            TxtKeterangan.Text = "Anda mendapat bonus Rumah "

        ElseIf (TxtMasaKerja.Text >= 15) Then
            TxtKeterangan.Text = "Anda mendapat bonus Mobil"

        ElseIf (TxtMasaKerja.Text >= 10) Then
            TxtKeterangan.Text = "Anda mendapat bonus Motor"

        ElseIf (TxtMasaKerja.Text >= 5) Then
            TxtKeterangan.Text = "Anda mendapat bonus istri Sholehah"

        Else
            TxtKeterangan.Text = "Maaf anda belum layak dapat bonus"
        End If
    End Sub
End Class
