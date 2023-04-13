Public Class Form1
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles Btnsubmit.Click
        Select Case txtKodeJabatan.Text
            Case "MGR" : txtKeterangan.Text = "Manager"

            Case "SKR" : txtKeterangan.Text = "Sekretaris"

            Case "BDH" : txtKeterangan.Text = "Bendahara"

            Case Else : txtKeterangan.Text = "Staff"
        End Select
    End Sub
End Class
