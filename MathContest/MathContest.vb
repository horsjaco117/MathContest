'Jacob Horsley
'RCET0265
'Spring 2025
'Math Contest
'URL:

Option Explicit On
Option Strict On


'[ ] have the focus change to the field that isn't completed
'[ ] Gray out stuff with information ingresado
'[ ] 
Public Class MathContest
    Sub SetDefaults()

        NameTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""

    End Sub

    Private Sub DisableUntil_Load(sender As Object, e As EventArgs) Handles Me.Shown
        SubmitButton.Enabled = False
        SummaryButton.Enabled = False
        AddRadioButton.Enabled = False
        SubtractRadioButton.Enabled = False
        MultiplyRadioButton.Enabled = False
        DivideRadioButton.Enabled = False
    End Sub


    Private Sub MathContest_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        NameTextBox.Focus()
        NameTextBox.SelectAll()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'Functions past this point---------------------------------------

    Function ValidInputs() As Boolean
        Dim valid As Boolean = True
        Dim message As String

        If NameTextBox.Text = "" Then
            valid = False
            NameTextBox.Focus()
            message &= "First name is required."
        End If

        If FirstNumberTextBox.Text = "" Then
            valid = False
            NameTextBox.Focus()
            message &= "First number is required."
        End If

        If SecondNumberTextBox.Text = "" Then
            valid = False
            NameTextBox.Focus()
            message &= "Second Number is required."
        End If

        If StudentAnswerTextBox.Text = "" Then
            valid = False
            NameTextBox.Focus()
            message &= "Answer is required."
        End If

        If AgeTextBox.Text = "" Then
            valid = False
            NameTextBox.Focus()
            message &= "Age is required."
        End If

        If GradeTextBox.Text = "" Then
            valid = False
            NameTextBox.Focus()
            message &= "Grade is required."
        End If

        If Not valid Then
            MsgBox(message, MsgBoxStyle.Exclamation, "User Input Fail!")
        End If

        Return valid

    End Function

End Class