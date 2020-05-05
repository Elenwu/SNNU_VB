Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num1 As Integer = TextBox1.Text
        Dim num2 As Integer = TextBox2.Text
        Dim oa As Integer = num1
        Dim ob As Integer = num2
        REM 判断除数不得为0进行while迭代
        Do While (num2 <> 0)
            Dim i = num1 Mod num2
            num1 = num2
            num2 = i
        Loop
        MessageBox.Show(oa & "和" & ob & "最大公约数为" & num1)
    End Sub
End Class
