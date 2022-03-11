

Public Class Form2
    Dim x, y, r As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        r = x + y
        TextBox3.Text = r
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        r = x - y
        TextBox3.Text = r
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        r = x * y
        TextBox3.Text = r
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        r = x / y
        TextBox3.Text = r
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class