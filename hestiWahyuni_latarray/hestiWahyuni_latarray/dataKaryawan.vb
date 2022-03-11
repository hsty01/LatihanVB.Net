Public Class dataKaryawan
    Private Sub dataKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextNama.Focus()
        Dim arr(1, 3) As String
        arr(0, 0) = "NIM"
        arr(0, 1) = "NAMA"
        arr(0, 2) = "JENIS KELAMIN"
        arr(0, 3) = "JABATAN"
        arr(1, 0) = "ALAMAT"
        arr(1, 1) = "TANGGAL LAHIR"
        arr(1, 2) = "TELP"
        arr(1, 3) = "E-MAIL"
        ListView1.GridLines = True
        ListView1.View = View.Details
        For baris = 0 To 1
            For kolom = 0 To 3
                ListView1.Columns.Add(arr(baris, kolom), 120)
            Next
        Next

        ComboKelamin.Items.Add("Pria")
        ComboKelamin.Items.Add("Wanita")
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        End
    End Sub

    Sub Kosong()
        TextID.Clear()
        TextNama.Clear()
        ComboKelamin.SelectedIndex = -1
        TextJabatan.Clear()
        TextAlamat.Clear()
        TextTGLlhr.Clear()
        TextTLP.Clear()
        TextEMail.Clear()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim arr(8) As String
        arr(0) = TextID.Text
        arr(1) = TextNama.Text
        arr(2) = ComboKelamin.Text
        arr(3) = TextJabatan.Text
        arr(4) = TextAlamat.Text
        arr(5) = TextTGLlhr.Text
        arr(6) = TextTLP.Text
        arr(7) = TextEMail.Text
        Dim list As New ListViewItem
        list = ListView1.Items.Add(arr(0))
        list.SubItems.Add(arr(1))
        list.SubItems.Add(arr(2))
        list.SubItems.Add(arr(3))
        list.SubItems.Add(arr(4))
        list.SubItems.Add(arr(5))
        list.SubItems.Add(arr(6))
        list.SubItems.Add(arr(7))
        list.SubItems.Add(arr(8))
        Kosong()
    End Sub
End Class