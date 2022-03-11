Public Class frm_array

    Dim mMin As Double
    Dim mMax As Double
    Dim mJml As Double = 0
    Dim mRata As Double = 0
    Dim mJmlKolom As Integer

    Private Sub frm_array_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtNama.Focus()
        Dim arr(1, 2) As String
        arr(0, 0) = "NIS"
        arr(0, 1) = "Nama Siswa"
        arr(0, 2) = "Jumlah"
        arr(1, 0) = "Rata-rata"
        arr(1, 1) = "Grade"
        arr(1, 2) = "Keterangan"
        ListView1.GridLines = True
        ListView1.View = View.Details
        For baris = 0 To 1
            For kolom = 0 To 2
                ListView1.Columns.Add(arr(baris, kolom), 110)
            Next
        Next

        TxtNIS.ReadOnly = True
        TxtNIS.Text = "171801"

    End Sub

    Private Sub TxtBIND_TextChanged(sender As Object, e As EventArgs) Handles TxtBIND.TextChanged
        TxtJML.Text = Val(TxtBIND.Text) + Val(TxtMAT.Text) + Val(TxtIPA.Text)
        TxtRata.Text = FormatNumber((TxtJML.Text) / 3)
    End Sub

    Private Sub TxtMAT_TextChanged(sender As Object, e As EventArgs) Handles TxtMAT.TextChanged
        TxtJML.Text = Val(TxtBIND.Text) + Val(TxtMAT.Text) + Val(TxtIPA.Text)
        TxtRata.Text = FormatNumber((TxtJML.Text) / 3)
    End Sub

    Private Sub TxtIPA_TextChanged(sender As Object, e As EventArgs) Handles TxtIPA.TextChanged
        TxtJML.Text = Val(TxtBIND.Text) + Val(TxtMAT.Text) + Val(TxtIPA.Text)
        TxtRata.Text = FormatNumber((TxtJML.Text) / 3)
    End Sub

    Private Sub TxtRata_TextChanged(sender As Object, e As EventArgs) Handles TxtRata.TextChanged
        If TxtRata.Text >= 90 Then
            TxtGrade.Text = "A"
        ElseIf TxtRata.Text >= 80 Then
            TxtGrade.Text = "B"
        ElseIf TxtRata.Text >= 70 Then
            TxtGrade.Text = "C"
        ElseIf TxtRata.Text < 70 Then
            TxtGrade.Text = "D"
        End If
    End Sub

    Private Sub TxtGrade_TextChanged(sender As Object, e As EventArgs) Handles TxtGrade.TextChanged
        If TxtGrade.Text = "A" Then
            TxtKET.Text = "LULUS"
        ElseIf TxtGrade.Text = "B" Then
            TxtKET.Text = "LULUS"
        ElseIf TxtGrade.Text = "C" Then
            TxtKET.Text = "LULUS"
        Else
            TxtKET.Text = "BELUM LULUS"
        End If
    End Sub

    Sub Kosong()
        TxtNama.Clear()
        TxtBIND.Clear()
        TxtMAT.Clear()
        TxtIPA.Clear()
        TxtJML.Clear()
        TxtGrade.Clear()
        TxtNama.Focus()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click

        mJmlKolom += 1
        mJml = Val(TxtRata.Text)
        mRata = mJml / mJmlKolom

        If Val(TxtRata.Text) > mMax Then
            mMax = Val(TxtRata.Text)
        End If
        If Val(TxtRata.Text) < mMin Then
            mMin = Val(TxtRata.Text)
        ElseIf mJmlKolom = 1 Then
            mMin = Val(TxtRata.Text)
        End If

        TxtMin.Text = mMin
        TxtMax.Text = mMax
        TxtAvg.Text = mRata
        TxtJmlData.Text = mJmlKolom

        Dim arr(5) As String
        arr(0) = TxtNIS.Text
        arr(1) = TxtNama.Text
        arr(2) = TxtJML.Text
        arr(3) = TxtRata.Text
        arr(4) = TxtGrade.Text
        arr(5) = TxtKET.Text
        Dim list As New ListViewItem
        list = ListView1.Items.Add(arr(0))
        list.SubItems.Add(arr(1))
        list.SubItems.Add(arr(2))
        list.SubItems.Add(arr(3))
        list.SubItems.Add(arr(4))
        list.SubItems.Add(arr(5))
        TxtNIS.Text = Val(TxtNIS.Text) + 1
        Kosong()

    End Sub

End Class
