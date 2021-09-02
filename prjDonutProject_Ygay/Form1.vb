' Name:         Donut Solution
' Purpose:      Use Function
' Programmer:   <Jhonniel Ygay> on <Sep 14,2020>



Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1

    Private Function CostOfDoughnut() As Double
        Dim dblDonut As Double

        If RadioButton1.Checked Then
            dblDonut = 0.75
        End If
        If RadioButton2.Checked Then
            dblDonut = 0.75
        End If
        If RadioButton3.Checked Then
            dblDonut = 0.75
        End If
        If RadioButton4.Checked Then
            dblDonut = 0.95

        End If
        Return dblDonut
    End Function

    Private Function CostOfCoffee() As Double
        Dim DblCoff As Double
        If RadioButton5.Checked Then
            DblCoff = 0
        End If
        If RadioButton6.Checked Then
            DblCoff = 1.5
        End If
        If RadioButton7.Checked Then
            DblCoff = 2.75

        End If
        Return DblCoff

    End Function

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Function TotalwTax(ByVal dblTax As Double) As Double
        Dim totalTAx As Double
        totalTAx = dblTax * 0.045
        Return totalTAx
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Subtotal1, SubTotal2 As Double

        Subtotal1 = CostOfDoughnut() + CostOfCoffee()
        SubTotal2 = Subtotal1 + TotalwTax(Subtotal1)

        lblSub.Text = Subtotal1.ToString("n2")
        lblSale.Text = TotalwTax(Subtotal1).ToString("n2")
        lblTotal.Text = SubTotal2.ToString("n2")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
