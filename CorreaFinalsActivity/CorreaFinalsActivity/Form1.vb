Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = (Val(Label1.Text)) + 1
        Dim x As Integer = Val(Label1.Text)
        total1(x)
        disc1(x)
        pay1(x)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = (Val(Label2.Text)) + 1
        Dim x As Integer = Val(Label1.Text)
        total1(x)
        disc1(x)
        pay1(x)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label3.Text = (Val(Label3.Text)) + 1
        Dim x As Integer = Val(Label1.Text)
        total1(x)
        disc1(x)
        pay1(x)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label4.Text = (Val(Label4.Text)) + 1
        Dim x As Integer = Val(Label1.Text)
        total1(x)
        disc1(x)
        pay1(x)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Val(Label1.Text) > 0 Then
            Label1.Text = Val(Label1.Text) - 1
        Else
            Label1.Text = 0
        End If
        Dim x As Integer = Val(Label1.Text)
        total1(x)
        disc1(x)
        pay1(x)


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Val(Label2.Text) > 0 Then
            Label2.Text = Val(Label2.Text) - 1
        Else
            Label2.Text = 0
        End If
        Dim x As Integer = Val(Label2.Text)
        total1(x)
        disc1(x)
        pay1(x)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Val(Label3.Text) > 0 Then
            Label3.Text = Val(Label3.Text) - 1
        Else
            Label3.Text = 0
        End If
        Dim x As Integer = Val(Label3.Text)
        total1(x)
        disc1(x)
        pay1(x)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Val(Label4.Text) > 0 Then
            Label4.Text = Val(Label4.Text) - 1
        Else
            Label5.Text = 0
        End If
        Dim x As Integer = Val(Label5.Text)
        total1(x)
        disc1(x)
        pay1(x)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
    End Sub
    Sub total1(ByVal t As Integer)
        Dim a As Integer = (Val(Label1.Text * 150))
        Dim b As Integer = (Val(Label2.Text * 300))
        Dim c As Integer = (Val(Label3.Text * 80))
        Dim d As Integer = (Val(Label4.Text * 30))
        Label5.Text = (a + b + c + d)
    End Sub
    Sub disc1(ByVal t As Integer)
        If Label5.Text > 1000 Then
            Label6.Text = (Val(Label5.Text) * 0.1)
        Else
            Label6.Text = 0
        End If
    End Sub
    Sub pay1(ByVal t As Integer)
        Label7.Text = Val(Label5.Text) - Val(Label6.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
