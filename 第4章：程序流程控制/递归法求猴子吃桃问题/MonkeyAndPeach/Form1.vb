Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String = ""
        Dim day, peach As Integer
        peach = fun1(1)
        str &= "第1天猴子摘的桃子数量为" & peach
        TextBox1.Text = str
    End Sub
    REM 递归推出桃子数量
    Private Function fun1(ByVal day As Integer)
        REM 第七天时直接返回1
        If (day = 7) Then
            fun1 = 1
        Else
            REM 如果不是第7天递归开始
            fun1 = 2 * fun1(day + 1) + 2
        End If
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
