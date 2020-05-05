Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num As Integer = TextBox1.Text
        Dim i As Integer = 1
        Dim strOut As String = num & "="
        Do While i < num
            If (num Mod i = 0 And i <> 1) Then
                strOut &= i & "x"
                num = num / i
                Continue Do
            End If
            i = i + 1
        Loop
        strOut = strOut & i
        MessageBox.Show(strOut)
    End Sub
End Class
