Public Class Catering
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decCost As Decimal
        Dim decFinal As Decimal
        Dim cdecDiscount As Decimal = 5D
        Dim decPoints As Decimal
        Dim strOrder As String = ""
        Dim strPay As String = ""
        Dim strPoints As String = ""
        Dim intPoints As Integer

        If IsNumeric(txtLoyaltyPoints.Text) Then
            intPoints = Convert.ToInt32(txtLoyaltyPoints.Text)
            strPoints = " after discount of " & intPoints.ToString() & " loyalty points."

            If radCheese.Checked Then
                decCost = 49.99D
                strOrder = "Cheese"
            ElseIf radPinwheel.Checked Then
                decCost = 59.99D
                strOrder = "Wrap"
            ElseIf radVeggie.Checked Then
                decCost = 29.99D
                strOrder = "Veggie"
            ElseIf radSausage.Checked Then
                decCost = 49.99D
                strOrder = "Sausage and Cheese"
            ElseIf radFruit.Checked Then
                decCost = 29.99D
                strOrder = "Fruit"
            End If

            If radPrePay.Checked Then
                strPay = " using" & vbCrLf & "Pre-Pay"
            ElseIf radPickup.Checked Then
                strPay = " with Pay" & vbCrLf & "upon Pickup"
            End If

            intPoints = Convert.ToInt32(intPoints / 10I)
            decPoints = (intPoints * cdecDiscount) / 100

            If decPoints > 1 Then
                decPoints = 1
            End If

            decFinal = decCost * (1 - decPoints)

            lblPaymentOutput.Text = "Your order " & strOrder & " Platter costs " & decFinal.ToString("C") & strPay & strPoints
        Else
            MsgBox("Please enter a valid number of points.", , "Input Error")
            Me.btnClear.PerformClick()
        End If
    End Sub

    Private Sub Catering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnClear.PerformClick()
        txtLoyaltyPoints.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLoyaltyPoints.Text = ""
        txtLoyaltyPoints.Focus()
        lblPaymentOutput.Text = ""
        radCheese.Checked = True
        radPrePay.Checked = True
    End Sub
End Class
