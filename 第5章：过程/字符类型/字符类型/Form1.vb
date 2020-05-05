Public Class Form1

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim str As String
        str = TextBox1.Text
        Dim length As Integer = str.Length
        Dim str1 As String = "包含"
        Dim num As Integer
        Dim ch As Char
        For num = 1 To length
            ch = Mid(str, num, 1)
            If (str1.Contains(charType(ch))) Then
                Continue For
            End If
            str1 += charType(ch)
        Next
        MessageBox.Show(str1)

    End Sub
    Private Function charType(ByVal ch As Char)
        Select Case ch
            Case "a" To "z", "A" To "Z"
                Return "英文字母"
            Case "0" To "9"
                Return "数字"
            Case Else
                If Asc(ch) < 0 Then
                    Return "汉字"
                End If
                Return "特殊字符"
        End Select

    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
