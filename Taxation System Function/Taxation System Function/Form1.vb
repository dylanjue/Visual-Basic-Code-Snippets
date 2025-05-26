Public Class Form1
    Dim netPay As Double
    Private Sub calculatebtn_Click(sender As Object, e As EventArgs) Handles calculatebtn.Click
        Dim grossPay As Double
        Dim tax As Double
        Dim eligibleForLoan As Double

        grossPay = InputBox("Enter the Gross Pay: ")

        tax = tax_calculate(grossPay)
        netPay = netPay_Calculate(grossPay, tax)
        eligibleForLoan = loan_eligibility(netPay)

    End Sub

    Private Function tax_calculate(ByVal grossPay As Double) As Double
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

        MessageBox.Show("The Tax Implemented is: " & tax)
        Return tax
    End Function

    Private Function netPay_Calculate(ByVal grossPay As Double, ByVal tax As Double) As Double
        Dim netPay As Integer

        netPay = grossPay - tax
        MessageBox.Show("The Net Pay is: " & netPay)
        Return netPay
    End Function

    Private Function loan_eligibility(ByVal netPay) As Double
        Dim loan_netPay = netPay
        If loan_netPay >= 350000 Then
            MessageBox.Show("Your net pay is " & netPay & " ,which makes you eligible for a loan.")
        Else
            MessageBox.Show("Your net pay is " & netPay & " ,which makes you ineligible for a loan.")
        End If
        Return loan_netPay
    End Function
End Class
