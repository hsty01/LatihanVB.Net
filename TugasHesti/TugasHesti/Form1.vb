Imports System.Data.Odbc
Public Class Form1
    Dim CONN As OdbcConnection
    Dim CMD As OdbcCommand
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim RD As OdbcDataReader
    Dim LokasiData As String
    Sub Koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver};Database=db_siswabrantas;server=localhost;uid=root"
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Sub TampilGrid()
        Call Koneksi()
        DA = New OdbcDataAdapter("select * From tbl_siswasmkbrantas ", CONN)
        DS = New DataSet
        DA.Fill(DS, "tbl_siswasmkbrantas")
        DataGridView1.DataSource = DS.Tables("tbl_siswasmkbrantas")
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilGrid()
        MunculCombo()
    End Sub
    Sub MunculCombo()
        ComboBox1.Items.Add("Teknik Instalasi Tenaga Listrik (TITL)")
        ComboBox1.Items.Add("Teknik Pembangkit Tenaga Listrik (TPTL)")
        ComboBox1.Items.Add("Teknik Permesinan (TPM)")
        ComboBox1.Items.Add("Teknik dan Bisnis Sepeda Motor (TBSM)")
        ComboBox1.Items.Add("Teknik Kendaraan Ringan Otomotif (TKRO)")
        ComboBox1.Items.Add("Rekayasa Perangkat Lunak (RPL)")
        ComboBox1.Items.Add("Multimedia (MM)")
        ComboBox1.Items.Add("Tata Boga (TBG)")
        ComboBox1.Items.Add("Tata Busana (TBS)")

    End Sub
    Sub KosongkanData()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.SelectedIndex = -1
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Silahkan Isi Semua Form yang tersedia!")
        Else
            Call Koneksi()
            Dim simpan As String = "insert into tbl_siswasmkbrantas values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & "')"
            CMD = New OdbcCommand(simpan, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Input data berhasil dibuat")
            Call TampilGrid()
            Call KosongkanData()
        End If
    End Sub
    Private Sub TextBox1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox1.MaxLength = 6
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            CMD = New OdbcCommand("Select * From tbl_siswasmkbrantas  where no_absen='" & TextBox1.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                MsgBox("NOMOR ABSEN Tidak Ada, Silahkan coba lagi!")
                TextBox1.Focus()
            Else
                TextBox2.Text = RD.Item("namasiswa")
                TextBox3.Text = RD.Item("alamatsiswa")
                TextBox4.Text = RD.Item("teleponsiswa")
                ComboBox1.Text = RD.Item("jurusan")
                TextBox2.Focus()
            End If
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call Koneksi()
        Dim edit As String = "update tbl_siswasmkbrantas set namasiswa='" & TextBox2.Text & "',alamatsiswa='" & TextBox3.Text & "',teleponsiswa='" & TextBox4.Text & "',jurusan='" & ComboBox1.Text & "' where no_absen='" & TextBox1.Text & "'"
        CMD = New OdbcCommand(edit, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Data Kamu Berhasil DiUpdate")
        Call TampilGrid()
        Call KosongkanData()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Silahkan Pilih Data yang akan di hapus dengan Masukan NOMOR ABSEN dan ENTER")
        Else
            If MessageBox.Show("Yakin data akan dihapus ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call Koneksi()
                Dim hapus As String = "delete From tbl_siswasmkbrantas  where no_absen='" & TextBox1.Text & "'"
                CMD = New OdbcCommand(hapus, CONN)
                CMD.ExecuteNonQuery()
                Call TampilGrid()
                Call KosongkanData()
            End If
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class
