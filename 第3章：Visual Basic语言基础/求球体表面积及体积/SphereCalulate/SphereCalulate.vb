Public Class SphereCalulate

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim r As Double
        Dim s As Double
        Dim v As Double
        r = TextBox1.Text
        s = 4 * 3.14 * r * r
        v = (4 / 3) * 3.14 * r * r * r
        MessageBox.Show("半径r为" & r & "的球体表面积是" & s & Chr(10) & "体积是" & v, "运算结果")
    End Sub
End Class
