Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Txtbox1.Text = "" Then
            MessageBox.Show("KULANG KAPA SA PRACTICE TOTOY")
        End If
        Try
            Dim a, b As Integer
            a = Txtbox1.Text
            b = Txtbox2.Text

            Txtbox3.Text = a / b

        Catch ex As Exception
        End Try
    End Sub
End Class
