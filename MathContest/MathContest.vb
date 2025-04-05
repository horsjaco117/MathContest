'Jacob Horsley
'RCET0265
'Spring 2025
'Math Contest
'URL:

Option Explicit On
Option Strict On

Public Class MathContest
    Private Sub MathContest_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        NameTextBox.Focus()
        NameTextBox.SelectAll()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
