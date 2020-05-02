Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num As Integer = TextBox1.Text
        MessageBox.Show(fun1(num))
    End Sub
    Private Function fun1(ByVal num As Integer)
        Dim result As Integer
        If (num Mod 2 = 0) Then
            result = OuShu(num)
            Return fun1(result)
        Else
            If (num = 1) Then
                Return 1
            End If
            result = jiShu(num)
            Return fun1(result)
        End If
    End Function
    Private Function OuShu(ByVal num As Integer)
        Return num / 2
    End Function
    Private Function jiShu(ByVal num As Integer)
        Return num * 3 + 1
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
