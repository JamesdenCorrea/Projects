Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case Label4.Text
            Case "Age"

                If Val(TextBox1.Text) = (18 - 20) Then
                    Label4.Text = "You are Qualified to Course1"

                ElseIf Val(TextBox1.Text) = (21 - 23) Then
                    Label4.Text = "You are Qualified to Course2"

                ElseIf Val(TextBox1.Text) = (24 - 26) Then
                    Label4.Text = "You are Qualified to Course3"

                Else
                    Label4.Text = "Invalid Entry!"
                End If
            Case "Gender"
                If Val(TextBox2.Text) = "M" Then
                    Label4.Text = "You are Qualified to Course1"
                ElseIf Val(TextBox2.Text) = "F" Then
                    Label4.Text = "You are Qualified to Course2"
                ElseIf Val(TextBox2.Text) = "M or F" Then
                    Label4.Text = "You are Qualified to Course3"
                Else
                    Label4.Text = "Invalid Entry!"
                End If
            Case "Score"
                If Val(TextBox3.Text) = (80 - 85) Then
                    Label4.Text = "You are Qualified to Course1"
                ElseIf Val(TextBox3.Text) = (86 - 90) Then
                    Label4.Text = "You are Qualified to Course2"
                ElseIf Val(TextBox3.Text) = (91 - 95) Then
                    Label4.Text = "You are Qualified to Course3"
                Else
                    Label4.Text = "Invalid Entry!"
                End If
        End Select
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
