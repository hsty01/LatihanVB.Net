<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TokoHesti
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
        Me.pembelian = New System.Windows.Forms.TextBox()
        Me.bonus = New System.Windows.Forms.TextBox()
        Me.hadiah = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jumlah Pembelian"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bonus"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hadiah"
        '
        'pembelian
        '
        Me.pembelian.Location = New System.Drawing.Point(126, 51)
        Me.pembelian.Name = "pembelian"
        Me.pembelian.Size = New System.Drawing.Size(133, 20)
        Me.pembelian.TabIndex = 3
        '
        'bonus
        '
        Me.bonus.Location = New System.Drawing.Point(126, 128)
        Me.bonus.Name = "bonus"
        Me.bonus.Size = New System.Drawing.Size(133, 20)
        Me.bonus.TabIndex = 4
        '
        'hadiah
        '
        Me.hadiah.Location = New System.Drawing.Point(126, 170)
        Me.hadiah.Name = "hadiah"
        Me.hadiah.Size = New System.Drawing.Size(133, 20)
        Me.hadiah.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(157, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TokoHesti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.hadiah)
        Me.Controls.Add(Me.bonus)
        Me.Controls.Add(Me.pembelian)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TokoHesti"
        Me.Text = "TokoHesti"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pembelian As TextBox
    Friend WithEvents bonus As TextBox
    Friend WithEvents hadiah As TextBox
    Friend WithEvents Button1 As Button
End Class
