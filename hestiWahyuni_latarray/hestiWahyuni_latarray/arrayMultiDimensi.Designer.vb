<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class arrayMultiDimensi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextNIM = New System.Windows.Forms.TextBox()
        Me.TextNama = New System.Windows.Forms.TextBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ComboJenisKlmn = New System.Windows.Forms.ComboBox()
        Me.ComboStatus = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(168, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROGRAM ARRAY MULTI DIMENSI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Status"
        '
        'TextNIM
        '
        Me.TextNIM.Location = New System.Drawing.Point(145, 65)
        Me.TextNIM.Name = "TextNIM"
        Me.TextNIM.Size = New System.Drawing.Size(225, 20)
        Me.TextNIM.TabIndex = 5
        '
        'TextNama
        '
        Me.TextNama.Location = New System.Drawing.Point(145, 102)
        Me.TextNama.Name = "TextNama"
        Me.TextNama.Size = New System.Drawing.Size(225, 20)
        Me.TextNama.TabIndex = 6
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(399, 59)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(106, 59)
        Me.BtnSimpan.TabIndex = 9
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(399, 135)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(106, 58)
        Me.BtnKeluar.TabIndex = 10
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(12, 219)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(493, 149)
        Me.ListView1.TabIndex = 11
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ComboJenisKlmn
        '
        Me.ComboJenisKlmn.FormattingEnabled = True
        Me.ComboJenisKlmn.Location = New System.Drawing.Point(145, 139)
        Me.ComboJenisKlmn.Name = "ComboJenisKlmn"
        Me.ComboJenisKlmn.Size = New System.Drawing.Size(225, 21)
        Me.ComboJenisKlmn.TabIndex = 12
        '
        'ComboStatus
        '
        Me.ComboStatus.FormattingEnabled = True
        Me.ComboStatus.Location = New System.Drawing.Point(145, 173)
        Me.ComboStatus.Name = "ComboStatus"
        Me.ComboStatus.Size = New System.Drawing.Size(225, 21)
        Me.ComboStatus.TabIndex = 13
        '
        'arrayMultiDimensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 380)
        Me.Controls.Add(Me.ComboStatus)
        Me.Controls.Add(Me.ComboJenisKlmn)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.TextNama)
        Me.Controls.Add(Me.TextNIM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "arrayMultiDimensi"
        Me.Text = "arrayMultiDimensi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextNIM As TextBox
    Friend WithEvents TextNama As TextBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ComboJenisKlmn As ComboBox
    Friend WithEvents ComboStatus As ComboBox
End Class
