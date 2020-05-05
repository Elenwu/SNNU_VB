Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String = TextBox1.Text
        Dim charList() As Char = str.ToCharArray
        Dim strOut As String = ""
        Dim i As Integer
        Dim j As Integer
        REM 开始外层循环,取出字符数组的每一个元素
        For i = 0 To charList.Length - 1
            REM 初始出现次数为0
            Dim count As Integer = 0
            REM 开始内层循环，把外层循环取出的元素与字符数组每个元素作比较
            For j = i To charList.Length - 1
                If (charList(i) = charList(j)) Then
                    REM 且当不是与自身相比较时，如两元素相等则count+1，再将相等元素置空，避免下次循环重新比较
                    count += 1
                    If (i <> j) Then
                        charList(j) = ""
                    End If
                End If
            Next
            REM 将字符元素及count拼接
            If strOut <> "" Then
                strOut = strOut & "," & charList(i) & "出现了" & count & "次"
            Else
                strOut = charList(i) & "出现了" & count & "次"
            End If
            Continue For
        Next
        MessageBox.Show(strOut)
    End Sub
End Class
