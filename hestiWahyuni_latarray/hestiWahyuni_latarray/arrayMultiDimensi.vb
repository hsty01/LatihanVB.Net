Public Class arrayMultiDimensi

    Private Sub arrayMultiDimensi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextNama.Focus()
        Dim arr(1, 2) As String
        arr(0, 0) = "NIM"
        arr(0, 1) = "Nama"
        arr(0, 2) = "Jenis Kelamin"
        arr(1, 0) = "Status"
        ListView1.GridLines = True
        ListView1.View = View.Details
        For baris = 0 To 1
            For kolom = 0 To 2
                ListView1.Columns.Add(arr(baris, kolom), 115)
            Next
        Next
        TextNIM.ReadOnly = True
        TextNIM.Text = "1"

        ComboJenisKlmn.Items.Add("Pria")
        ComboJenisKlmn.Items.Add("Wanita")

        ComboStatus.Items.Add("Menikah")
        ComboStatus.Items.Add("Belum Menikah")
    End Sub

    Sub Kosong()
        TextNama.Clear()
        ComboJenisKlmn.SelectedIndex = -1
        ComboStatus.SelectedIndex = -1
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        End
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim arr(4) As String
        arr(0) = TextNIM.Text
        arr(1) = TextNama.Text
        arr(2) = ComboJenisKlmn.Text
        arr(3) = ComboStatus.Text
        Dim list As New ListViewItem
        list = ListView1.Items.Add(arr(0))
        list.SubItems.Add(arr(1))
        list.SubItems.Add(arr(2))
        list.SubItems.Add(arr(3))
        TextNIM.Text = Val(TextNIM.Text) + 1
        Kosong()
    End Sub
End Class