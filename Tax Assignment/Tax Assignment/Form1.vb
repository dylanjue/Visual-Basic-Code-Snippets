Public Class Form1
    Private Sub calculatebtn_Click(sender As Object, e As EventArgs) Handles calculatebtn.Click
        Dim grossPay As Double
        Dim tax As Double = 0
        Dim netPay As Double

        grossPay = grosstaxtxt.Text

        If grossPay >= 500000 Then
            tax = grossPay * 0.4
        ElseIf grossPay >= 300000 Then
            tax = grossPay * 0.3
        ElseIf grossPay >= 200000 Then
            tax = grossPay * 0.2
        ElseIf grossPay >= 100000 Then
            tax = grossPay * 0.1
        ElseIf grossPay <= 50000 Then
            tax = 0
        End If

        netPay = grossPay - tax

        MessageBox.Show("Tax Implemented: " & tax)
        MessageBox.Show("Net Pay: " & netPay)
    End Sub
End Class
