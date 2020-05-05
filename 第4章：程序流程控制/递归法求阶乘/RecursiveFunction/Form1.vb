Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num As Integer
        num = TextBox1.Text
        num = Recursive(num)
        MessageBox.Show("阶乘计算等于" & num)
    End Sub
    REM 递归方法
    Private Function Recursive(ByVal num As Integer)
        REM 当阶乘基数是0或者1直接返回结果1
        If (num = 0 Or num = 1) Then
            Recursive = 1
            REM 当阶乘基数大于0时开始递归
        ElseIf (num > 0) Then
            Recursive = num * Recursive(num - 1)
        Else
            Recursive = 1
        End If
    End Function
End Class