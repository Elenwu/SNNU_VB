Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim str1 As String
        str1 = "★◇■"
        Label1.Text = str1 + "使用Len计算的长度为" & Len(str1)
        Label2.Text = str1 + "使用.length的长度为" & str1.Length
        str1 = "123"
        Label3.Text = str1 + "使用Len计算的长度为" & Len(str1)
        Label4.Text = str1 + "使用.length的长度为" & str1.Length
        str1 = "陜西師範大學"
        Label5.Text = str1 + "使用Len计算的长度为" & Len(str1)
        Label6.Text = str1 + "使用.length的长度为" & str1.Length
        str1 = "陕西师范大学"
        Label7.Text = str1 + "使用Len计算的长度为" & Len(str1)
        Label8.Text = str1 + "使用.length的长度为" & str1.Length
        str1 = "11/11/2016"
        Label9.Text = str1 + "使用Len计算的长度为" & Len(str1)
        Label10.Text = str1 + "使用.length的长度为" & str1.Length
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        
    End Sub
End Class
