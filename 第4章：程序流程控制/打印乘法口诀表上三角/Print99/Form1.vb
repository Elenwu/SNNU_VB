Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String = ""
        Dim row As Integer
        Dim column As Integer
        For row = 1 To 9
            For column = 1 To row
                str += row & "*" & column & "=" & row * column & vbTab
            Next
            str += vbCrLf
        Next
        TextBox1.Text = str
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
