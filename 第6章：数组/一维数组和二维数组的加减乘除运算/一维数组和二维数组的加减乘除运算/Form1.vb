Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim num1() As Integer = {1, 2, 3, 4, 5}
        Dim num2(,) As Integer = {{1, 1}, {2, 2}, {3, 3}, {4, 4}, {5, 5}}
        Dim str As String = "", str1 As String = "一维数组{1, 2, 3, 4, 5}", str2 As String = "二维数组{{1, 1}, {2, 2}, {3, 3}, {4, 4}, {5, 5}}"
        str += str1 & "加运算=" & fun1D(num1, "+") & vbCrLf
        str += str1 & "减运算=" & fun1D(num1, "-") & vbCrLf
        str += str1 & "乘运算=" & fun1D(num1, "*") & vbCrLf
        str += str1 & "除运算=" & fun1D(num1, "/") & vbCrLf
        str += str2 & "加运算=" & fun2D(num2, "+") & vbCrLf
        str += str2 & "减运算=" & fun2D(num2, "-") & vbCrLf
        str += str2 & "乘运算=" & fun2D(num2, "*") & vbCrLf
        str += str2 & "除运算=" & fun2D(num2, "/") & vbCrLf
        MessageBox.Show(str)
    End Sub
    Private Function fun1D(ByVal num() As Integer, ByVal ch1 As Char)
        REM result默认值是第一个元素值，然后遍历从第二个元素开始
        Dim result As Double = num(0)
        Select Case ch1
            Case "+"
                For inti As Integer = 1 To UBound(num, 1)
                    REM 使用+=把每个元素相加
                    result += num(inti)
                Next
            Case "-"
                For inti As Integer = 1 To UBound(num, 1)
                    REM 使用-=把每个元素相减
                    result -= num(inti)
                Next
            Case "*"
                For inti As Integer = 1 To UBound(num, 1)
                    REM 使用*=把每个元素相乘
                    result *= num(inti)
                Next
            Case "/"
                For inti As Integer = 1 To UBound(num, 1)
                    REM 使用/=把每个元素相除
                    result /= num(inti)
                Next
        End Select
        Return result
    End Function
    Private Function fun2D(ByVal num(,) As Integer, ByVal ch2 As Char)
        Dim result As Double = 0
        Select Case ch2
            Case "+"
                REM 使用foreach循环遍历
                For Each Element As Double In num
                    result += Element
                Next
            Case "-"
                REM 使用forEach循环但是result初始值是0,会影响-=结果，所以采用计数器
                result = num(0, 0)
                Dim flag As Integer = 0
                For Each Element As Double In num
                    flag += 1
                    REM 第一次循环时直接跳过
                    If (flag = 1) Then
                        Continue For
                    End If
                    result -= Element
                Next
            Case "*"
                REM 令result
                result = 1
                For Each Element As Double In num
                    result *= Element
                Next
            Case "/"
                REM 采用计数器进行标记，同减法
                result = num(0, 0)
                Dim flag As Integer = 0
                For Each Element As Double In num
                    flag += 1
                    If (flag = 1) Then
                        Continue For
                    End If
                    result /= Element
                Next
        End Select
        Return result
    End Function
End Class
