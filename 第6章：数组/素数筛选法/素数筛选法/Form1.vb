Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim t As Integer = TextBox1.Text
        Dim nums(t) As Integer, flag(t) As Boolean
        Dim len As Integer = 0, i As Integer, j As Integer, strOut As String = ""
        For i = 2 To t
            If (flag(i) = False) Then
                nums(len) = i
                len += 1
            End If
            For j = i + i To t Step i
                If (j Mod i = 0) Then
                    flag(j) = True
                End If
            Next
        Next
        Dim n As Integer
        For n = 0 To nums.Length - 1
            If (nums(n) = 0) Then
                Continue For
            End If
            If (strOut = "") Then
                strOut = nums(n)
            Else
                strOut = strOut & "," & nums(n)
            End If
        Next
        MessageBox.Show(strOut)
    End Sub
End Class
