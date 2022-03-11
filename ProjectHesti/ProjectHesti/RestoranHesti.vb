Public Class RestoranHesti
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nomor, dharga As Integer
        Dim nama As String
        nomor = TextBox1.Text
        nama = ""
        Select Case nomor
            Case 1
                nama = "Soto Ayam"
                dharga = 4000
            Case 2
                nama = "Soto Daging"
                dharga = 5000
            Case 3
                nama = "Sate Ayam"
                dharga = 6000
            Case 4
                nama = "Nasi Ayam+Telor"
                dharga = 5000
            Case 5
                nama = "Rawon"
                dharga = 5000
        End Select
        namaMenu.Text = nama
        harga.Text = dharga
    End Sub
End Class