﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim I As Integer
        For I = 0 To 10
            MessageBox.Show("Value = " & I)
        Next
    End Sub
End Class
