Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer = TextBox1.Text
        MessageBox.Show("前" & n & "项和为" & fun(n))
    End Sub
    Private Function fun(ByVal n As Integer)
        Dim x As Double = 2.0
        Dim y As Double = 1.0
        Dim sum As Double = x / y
        Dim flag As Double = 0.0
        Dim i As Integer
        For i = 1 To n - 1
            flag = x
            x = x + y
            y = flag
            sum += x / y
        Next
        Return sum
    End Function

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
