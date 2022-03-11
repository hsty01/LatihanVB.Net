<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class programIndomart
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
        Me.TextFood = New System.Windows.Forms.TextBox()
        Me.TextHarga = New System.Windows.Forms.TextBox()
        Me.ComboStok = New System.Windows.Forms.ComboBox()
        Me.ComboJML = New System.Windows.Forms.ComboBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(191, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROGRAM INDOMART"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Makanan/Minuman"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah"
        '
        'TextFood
        '
        Me.TextFood.Location = New System.Drawing.Point(168, 53)
        Me.TextFood.Name = "TextFood"
        Me.TextFood.Size = New System.Drawing.Size(186, 20)
        Me.TextFood.TabIndex = 5
        '
        'TextHarga
        '
        Me.TextHarga.Location = New System.Drawing.Point(168, 89)
        Me.TextHarga.Name = "TextHarga"
        Me.TextHarga.Size = New System.Drawing.Size(186, 20)
        Me.TextHarga.TabIndex = 6
        '
        'ComboStok
        '
        Me.ComboStok.FormattingEnabled = True
        Me.ComboStok.Location = New System.Drawing.Point(168, 125)
        Me.ComboStok.Name = "ComboStok"
        Me.ComboStok.Size = New System.Drawing.Size(186, 21)
        Me.ComboStok.TabIndex = 7
        '
        'ComboJML
        '
        Me.ComboJML.FormattingEnabled = True
        Me.ComboJML.Location = New System.Drawing.Point(168, 161)
        Me.ComboJML.Name = "ComboJML"
        Me.ComboJML.Size = New System.Drawing.Size(186, 21)
        Me.ComboJML.TabIndex = 8
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(372, 56)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(132, 53)
        Me.BtnSimpan.TabIndex = 9
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(372, 124)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(132, 53)
        Me.BtnKeluar.TabIndex = 10
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 193)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(492, 114)
        Me.ListView1.TabIndex = 11
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'programIndomart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 319)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.ComboJML)
        Me.Controls.Add(Me.ComboStok)
        Me.Controls.Add(Me.TextHarga)
        Me.Controls.Add(Me.TextFood)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "programIndomart"
        Me.Text = "programIndomart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextFood As TextBox
    Friend WithEvents TextHarga As TextBox
    Friend WithEvents ComboStok As ComboBox
    Friend WithEvents ComboJML As ComboBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents ListView1 As ListView
End Class
