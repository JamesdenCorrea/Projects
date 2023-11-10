Public Class Form1
    Dim A As Double = 150
    Dim B As Double = 100
    Dim C As Double = 80
    Dim D As Double = 30
    Dim total As Double = 0
    Dim Qty1 As Double = 0
    Dim Qty2 As Double = 0
    Dim Qty3 As Double = 0
    Dim Qty4 As Double = 0
    Dim discountPercentage As Double = 10
    Dim allDiscount As Double = 0
    Dim totalWithDiscount As Double = 0

    Private Sub btnChickenPlus_Click(sender As Object, e As EventArgs) Handles btnChickenPlus.Click
        Int32.TryParse(lblQtyChicken.Text, Qty1)
        Qty1 = Qty1 + 1
        lblQtyChicken.Text = Qty1


        total = total + A
        Label6.Text = Val(Label6.Text) + A

        If total > 1000 Then
            allDiscount = ((total / 100) * discountPercentage)
            totalWithDiscount = total - allDiscount
            lblTotal.Text = totalWithDiscount
            lblDiscount.Text = allDiscount
        Else
            allDiscount = 0
            lblTotal.Text = total
            lblDiscount.Text = 0
        End If


    End Sub

    Private Sub btnChickenMinus_Click(sender As Object, e As EventArgs) Handles btnChickenMinus.Click
        Int32.TryParse(lblQtyChicken.Text, Qty1)
        Qty1 = Qty1 - 1
        If Qty1 < 0 Then
            Return
        End If
        lblQtyChicken.Text = Qty1


        total = total - A
        Label6.Text = Val(Label6.Text) - A

        If total > 1000 Then
            allDiscount = ((total / 100) * discountPercentage)
            totalWithDiscount = total - allDiscount
            lblTotal.Text = totalWithDiscount
            lblDiscount.Text = allDiscount
        Else
            allDiscount = 0
            lblTotal.Text = total
            lblDiscount.Text = 0
        End If


    End Sub

    Private Sub btnSpaghettiMinus_Click(sender As Object, e As EventArgs) Handles btnSpaghettiMinus.Click

        Int32.TryParse(lblQtySpaghetti.Text, Qty2)
        Qty2 = Qty2 - 1
        If Qty2 < 0 Then
            Return
        End If
        lblQtySpaghetti.Text = Qty2

        total = total - B
        Label6.Text = Val(Label6.Text) - B

        If total > 1000 Then
            allDiscount = ((total / 100) * discountPercentage)
            totalWithDiscount = total - allDiscount
            lblTotal.Text = totalWithDiscount
            lblDiscount.Text = allDiscount
        Else
            allDiscount = 0
            lblTotal.Text = total
            lblDiscount.Text = 0
        End If


    End Sub

    Private Sub btnBurgerMinus_Click(sender As Object, e As EventArgs) Handles btnBurgerMinus.Click

        Int32.TryParse(lblQtyBurger.Text, Qty3)
        Qty3 = Qty3 - 1
        If Qty3 < 0 Then
            Return
        End If
        lblQtyBurger.Text = Qty3
        total = total - C
        Label6.Text = Val(Label6.Text) - C

        If total > 1000 Then
            allDiscount = ((total / 100) * discountPercentage)
            totalWithDiscount = total - allDiscount
            lblTotal.Text = totalWithDiscount
            lblDiscount.Text = allDiscount
        Else
            allDiscount = 0
            lblTotal.Text = total
            lblDiscount.Text = 0
        End If


    End Sub

    Private Sub btnSodaMinus_Click(sender As Object, e As EventArgs) Handles btnSodaMinus.Click

        Int32.TryParse(lblQtySoda.Text, Qty4)
        Qty4 = Qty4 - 1
        If Qty4 < 0 Then
            Return
        End If
        lblQtySoda.Text = Qty4
        total = total - D
        Label6.Text = Val(Label6.Text) - D

        If total > 1000 Then
            allDiscount = ((total / 100) * discountPercentage)
            totalWithDiscount = total - allDiscount
            lblTotal.Text = totalWithDiscount
            lblDiscount.Text = allDiscount
        Else
            allDiscount = 0
            lblTotal.Text = total
            lblDiscount.Text = 0
        End If


    End Sub

    Private Sub btnSpaghettiPlus_Click(sender As Object, e As EventArgs) Handles btnSpaghettiPlus.Click

        Int32.TryParse(lblQtySpaghetti.Text, Qty2)
        Qty2 = Qty2 + 1
        lblQtySpaghetti.Text = Qty2

        total = total + B
        Label6.Text = Val(Label6.Text) + B

        If total > 1000 Then
            allDiscount = ((total / 100) * discountPercentage)
            totalWithDiscount = total - allDiscount
            lblTotal.Text = totalWithDiscount
            lblDiscount.Text = allDiscount
        Else
            allDiscount = 0
            lblTotal.Text = total
            lblDiscount.Text = 0
        End If

    End Sub

    Private Sub btnBurgerPlus_Click(sender As Object, e As EventArgs) Handles btnBurgerPlus.Click

        Int32.TryParse(lblQtyBurger.Text, Qty3)
        Qty3 = Qty3 + 1
        lblQtyBurger.Text = Qty3

        total = total + C
        Label6.Text = Val(Label6.Text) + C

        If total > 1000 Then
            allDiscount = ((total / 100) * discountPercentage)
            totalWithDiscount = total - allDiscount
            lblTotal.Text = totalWithDiscount
            lblDiscount.Text = allDiscount
        Else
            allDiscount = 0
            lblTotal.Text = total
            lblDiscount.Text = 0
        End If

    End Sub

    Private Sub btnSodaPlus_Click(sender As Object, e As EventArgs) Handles btnSodaPlus.Click

        Int32.TryParse(lblQtySoda.Text, Qty4)
        Qty4 = Qty4 + 1
        lblQtySoda.Text = Qty4

        total = total + D
        Label6.Text = Val(Label6.Text) + D

        If total > 1000 Then

            allDiscount = ((total / 100) * discountPercentage)
            totalWithDiscount = total - allDiscount
            lblTotal.Text = totalWithDiscount
            lblDiscount.Text = allDiscount
        Else
            allDiscount = 0
            lblTotal.Text = total
            lblDiscount.Text = 0
        End If
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblQtyChicken.Text = Qty1
        lblQtySpaghetti.Text = Qty2
        lblQtyBurger.Text = Qty3
        lblQtySoda.Text = Qty4
        lblDiscount.Text = 0
        lblTotal.Text = 0
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, lblTotalChicken.Click, lblSpaghettiTotal.Click, lblBurgerTotal.Click, lblSodaTotal.Click, Label3.Click, Label9.Click, Label8.Click, Label4.Click, Label10.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
