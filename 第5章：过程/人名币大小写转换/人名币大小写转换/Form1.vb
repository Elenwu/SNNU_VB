Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim money As Integer = TextBox1.Text
        MessageBox.Show(fun(money))
    End Sub
    Private Function fun(ByVal money As Integer)
        Dim data() As Char = {"零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖"}
        Dim units() As Char = {"元", "拾", "佰", "仟", "万", "拾", "佰", "仟", "亿"}
        Dim sbf As String = ""
        Dim unit As Integer = 0
        Do While (money <> 0)
            Dim number As Integer = money Mod 10
            If (data(number) = "零") Then
                REM 如果数字是零而且单位是万或者元那我保留单位不要数字
                If (units(unit) = "万" Or units(unit) = "元") Then
                    sbf = sbf.Insert(0, units(unit))
                    money = money / 10
                    unit += 1
                    Continue Do
                Else
                    REM 如果数字是零而且单位不是万那我保留数字不要单位
                    sbf = sbf.Insert(0, data(number))
                    money = money / 10
                    unit += 1
                    Continue Do
                End If
            End If
            sbf = sbf.Insert(0, units(unit))
            sbf = sbf.Insert(0, data(number))
            money = money / 10
            unit += 1
        Loop
        Return sbf
    End Function

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
