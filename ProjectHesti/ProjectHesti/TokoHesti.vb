Public Class TokoHesti

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim jumlah, dbonus, sisa As Integer
        Dim dhadiah As String
        jumlah = pembelian.Text
        dbonus = 0
        dhadiah = ""
        If jumlah > 200000 Then
            sisa = jumlah - 200000
            dbonus = (15 / 100) * sisa
            dhadiah = "gelas cantik"
        Else
            dhadiah = "gelas cantik"
        End If
        hadiah.Text = dhadiah
        bonus.Text = dbonus
    End Sub
End Class