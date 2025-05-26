Public Class Form1
    Private Sub calculatebtn_Click(sender As Object, e As EventArgs) Handles calculatebtn.Click
        Dim grossPay As Double

        grossPay = InputBox("Enter the gross pay: ")

        taxAndnetPay_Calculate(grossPay)
    End Sub

    Private Sub taxAndnetPay_Calculate(ByVal grossPay As Double)
        Dim tax As Double
        If grossPay >= 500000 Then
            tax = grossPay * 0.4
        ElseIf grossPay >= 300000 Then
            tax = grossPay * 0.3
        ElseIf grossPay >= 200000 Then
            tax = grossPay * 0.2
        ElseIf grossPay >= 100000 Then
            tax = grossPay * 0.1
        Else
            tax = 0
        End If

        Dim netPay As Double
        netPay = grossPay - tax

        MessageBox.Show("Tax Implemented: " & tax)
        MessageBox.Show("Net Pay: " & netPay)
    End Sub

End Class
