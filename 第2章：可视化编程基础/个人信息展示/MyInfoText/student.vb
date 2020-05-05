Public Class student

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = "123456"        TextBox1.ReadOnly = True        TextBox2.Text = "张三"        TextBox2.ReadOnly = True        TextBox3.Text = "18"        TextBox3.ReadOnly = True        TextBox4.Text = "123456789@qq.com"        TextBox4.ReadOnly = True        TextBox1.Show()        TextBox2.Show()        TextBox3.Show()        TextBox4.Show()
        Label1.show()
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
    End Sub

    Private Sub student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Hide()        TextBox2.Hide()        TextBox3.Hide()        TextBox4.Hide()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
    End Sub
End Class
