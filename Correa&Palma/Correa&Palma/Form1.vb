Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Menu

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedNumber As Integer = CInt(ComboBox1.SelectedItem)
        Dim radioButtonFlag1 As Boolean = RadioButton1.Checked
        Dim radioButtonFlag2 As Boolean = RadioButton2.Checked

        ListBox1.Items.Clear()

        For i As Integer = 1 To selectedNumber
            Dim asterisk As String = New String("*"c, i)

            If i Mod 2 = 0 And radioButtonFlag1 Then
                ListBox1.Items.Add("Skipped - " & i.ToString())
            ElseIf i Mod 3 = 0 And radioButtonFlag2 Then
                ListBox1.Items.Add("Skipped - " & i.ToString())
            Else
                ListBox1.Items.Add(asterisk & "-" & i.ToString())
            End If
        Next

    End Sub

    Private Sub UpdateDropdownOptions()
        ' Clear existing items in the dropdown
        ComboBox1.Items.Clear()

        ' Add items based on the checked checkboxes
        If CheckBox1.Checked Then
            AddRangeToDropdown(1, 5)
        End If

        If CheckBox2.Checked Then
            AddRangeToDropdown(6, 10)
        End If

        If CheckBox3.Checked Then
            AddRangeToDropdown(11, 20)
        End If
    End Sub

    Private Sub AddRangeToDropdown(startNumber As Integer, endNumber As Integer)
        ' Add items to the dropdown based on the given range
        For i As Integer = startNumber To endNumber
            ComboBox1.Items.Add(i)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        UpdateDropdownOptions()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        UpdateDropdownOptions()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        UpdateDropdownOptions()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
