Option Explicit On
Option Strict On
'Jacob Horsley
'RCET0265
'Spring 2025
'Math Contest
'URL:

Imports System.CodeDom.Compiler




'[ ] have the focus change to the field that isn't completed
'[x] Gray out stuff with information ingresado
'[ ] Create code that does math stuff for everything
'[ ] Fix the problem of not being able to select button option
Public Class MathContest
    Sub SetDefaults()

        NameTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""

    End Sub

    'Everything below this checks to see if everything is put in correctly
    Private Sub DisableUntil_Load(sender As Object, e As EventArgs) Handles Me.Shown
        SubmitButton.Enabled = False
        SummaryButton.Enabled = False
        AddRadioButton.Enabled = False
        SubtractRadioButton.Enabled = False
        MultiplyRadioButton.Enabled = False
        DivideRadioButton.Enabled = False
    End Sub

    Private Sub ValidateInputs()
        Dim nameValid As Boolean = Not String.IsNullOrWhiteSpace(NameTextBox.Text)
        Dim ageValid As Boolean = Integer.TryParse(AgeTextBox.Text, Nothing)
        Dim gradeValid As Boolean = Integer.TryParse(GradeTextBox.Text, Nothing)
        Dim answerValid As Boolean = Integer.TryParse(StudentAnswerTextBox.Text, Nothing)

        Dim allValid As Boolean = nameValid And ageValid And gradeValid And answerValid

        SubmitButton.Enabled = allValid
        SummaryButton.Enabled = allValid
        AddRadioButton.Enabled = allValid
        SubtractRadioButton.Enabled = allValid
        MultiplyRadioButton.Enabled = allValid
        DivideRadioButton.Enabled = allValid

    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        ValidateInputs()
    End Sub

    Private Sub AgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.TextChanged
        ValidateInputs()
    End Sub

    Private Sub GradeTextBox_TextChanged(sender As Object, e As EventArgs) Handles GradeTextBox.TextChanged
        ValidateInputs()
    End Sub

    Private Sub StudentAnswerTextBox_TextChanged(sender As Object, e As EventArgs) Handles StudentAnswerTextBox.TextChanged
        ValidateInputs()
    End Sub

    Private Sub FirstNumberTextBox_Move(sender As Object, e As EventArgs) Handles MyBase.Load, SubmitButton.Click
        Dim result As Integer = randomNumberBetween(1, 100)
        FirstNumberTextBox.Text = result.ToString()

    End Sub

    Private Sub SecondNumberTextBox_Move(sender As Object, e As EventArgs) Handles MyBase.Load, SubmitButton.Click
        Dim result As Integer = secondRandomNumberBetween(1, 100)
        SecondNumberTextBox.Text = result.ToString()

    End Sub

    'Handling of the focus------------------------------------------
    Private Sub MathContest_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        NameTextBox.Focus()
        NameTextBox.SelectAll()
    End Sub

    'This stuff clears-----------------------------------------------

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        AffirmCorrectAnswer()
        StudentAnswerTextBox.Clear()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Clear()
        FirstNumberTextBox.Clear()
        SecondNumberTextBox.Clear()
        AgeTextBox.Clear()
        GradeTextBox.Clear()
    End Sub
    'The Math Stuff-----------------------------------------------------
    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged
        AddingofNumbers()

    End Sub

    'For Correct or Wrong Answers--------------------------------------
    Sub AffirmCorrectAnswer()

        MsgBox("Hooray")

    End Sub

    'Closing of the program-----------------------------------------------
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


    'Functions past this point---------------------------------------

    'Function in charge of adding
    Function AddingofNumbers() As Integer
        Dim firstNumber = RandomNumberBetween(1, 100)
        Dim secondNumber = SecondRandomNumberBetween(1, 100)
        Dim answer As Integer

        answer = firstNumber + secondNumber

        Return answer
    End Function

    'Function in charge of verifying answer
    Function WasAnswerCorrect() As Boolean
        Dim correctAnswer As Boolean
        'Dim incorrect As Boolean
        Dim computedNumber = AddingofNumbers()
        Dim userNumber As Integer

        If computedNumber = userNumber Then
            correctAnswer = True

        End If

        Return correctAnswer
    End Function

    Function RandomNumberBetween(max As Integer, min As Integer) As Integer
        Dim temp As Single 'The single type helps work with the randomize stuff
        Randomize()
        temp = Rnd()
        temp = temp * (max - min + 1) + min
        Return CInt(Math.Floor(temp)) 'min isn't included
    End Function

    Function SecondRandomNumberBetween(min As Integer, max As Integer) As Integer
        Dim rand As New Random()
        Return rand.Next(min, max + 1) ' Includes max
    End Function


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