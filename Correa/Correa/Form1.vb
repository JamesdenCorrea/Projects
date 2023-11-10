Imports System.Reflection.Emit

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case Label1.Text
            Case "Age"
                If TextBox1.Text = (18 - 20) Then
                    Label1.Text = "You are qualified for Course1"
                ElseIf TextBox1.Text = (21 - 23) Then
                    Label1.Text = "You are qualified for Course2"
                ElseIf TextBox1.Text = (24 - 26) Then
                    Label1.Text = "You are qualified for Course3"
                Else
                    Label1.Text = "Invalid Entry"
                End If
            Case "Gender"
                If TextBox2.Text = "M" Then
                    Label1.Text = "You are qualified for Course1"
                ElseIf TextBox2.Text = "F" Then
                    Label1.Text = "You are qualified for Course2"
                ElseIf TextBox2.Text = "M or F" Then
                    Label1.Text = "You are qualified for Course3"
                Else
                    Label1.Text = "Invalid Entry"
                End If
            Case "Score"
                If TextBox3.Text = (80 - 85) Then
                    Label1.Text = "You are qualified for Course1"
                ElseIf TextBox3.Text = (86 - 90) Then
                    Label1.Text = "You are qualified for Course2"
                ElseIf TextBox3.Text = (91 - 95) Then
                    Label1.Text = "You are qualified for Course3"
                Else
                    Label1.Text = "Invalid Entry"
                End If
        End Select
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
