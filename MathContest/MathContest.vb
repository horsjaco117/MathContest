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
'[ ] Have correct answer shown when incorrect input is recieved
'[ ]  Keep track of the right and wrong values
Public Class MathContest

    Dim firstNumber As Integer
    Dim secondNumber As Integer
    Dim correctAnswer As Integer
    Dim incorrectAnswer As Integer

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
        'Dim answerValid As Boolean = Integer.TryParse(StudentAnswerTextBox.Text, Nothing)

        Dim allValid As Boolean = nameValid And ageValid And gradeValid

        'SubmitButton.Enabled = allValid
        SummaryButton.Enabled = allValid
        AddRadioButton.Enabled = allValid
        SubtractRadioButton.Enabled = allValid
        MultiplyRadioButton.Enabled = allValid
        DivideRadioButton.Enabled = allValid

    End Sub

    Private Sub SubmitAcivation()
        Dim answerWritten As Boolean = Integer.TryParse(StudentAnswerTextBox.Text, Nothing)
        Dim valid As Boolean = answerWritten
        SubmitButton.Enabled = valid
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
        SubmitAcivation()
    End Sub



    'Handling of the focus------------------------------------------
    Private Sub MathContest_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        NameTextBox.Focus()
        NameTextBox.SelectAll()
        Me.AcceptButton = SubmitButton
        Me.CancelButton = ExitButton
    End Sub

    'This stuff clears-----------------------------------------------

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        SubmitAcivation()
        If ValidInputs() Then
            WasAnswerCorrect()
            StudentAnswerTextBox.Clear()
            GenerateAndShowNumbers()
        End If
        StudentAnswerTextBox.Clear()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Clear()
        FirstNumberTextBox.Clear()
        SecondNumberTextBox.Clear()
        AgeTextBox.Clear()
        GradeTextBox.Clear()
        correctAnswer = 0
        incorrectAnswer = 0
    End Sub
    'The Math Stuff-----------------------------------------------------
    'Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged
    '    AddingofNumbers()

    'End Sub

    'For Correct or Wrong Answers--------------------------------------
    Sub AffirmCorrectAnswer()
        Dim result As Integer

        MsgBox("Hooray")

    End Sub

    'Number Generation------------------------------------------------
    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged
        If AddRadioButton.Checked Then
            GenerateAndShowNumbers()
        End If
    End Sub

    Private Sub SubtractRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractRadioButton.CheckedChanged
        If SubtractRadioButton.Checked Then
            GenerateAndShowNumbers()
        End If
    End Sub

    Private Sub MultiplyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplyRadioButton.CheckedChanged
        If MultiplyRadioButton.Checked Then
            GenerateAndShowNumbers()
        End If
    End Sub

    Private Sub DivideRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivideRadioButton.CheckedChanged
        If DivideRadioButton.Checked Then
            GenerateAndShowNumbers()
        End If
    End Sub

    ' Add this helper method:
    Private Sub GenerateAndShowNumbers()
        firstNumber = RandomNumberBetween(1, 100)

        If DivideRadioButton.Checked Then
            secondNumber = SecondRandomNumberBetween(1, 100)
            Do While secondNumber = 0 'This prevents the crashing of the program DO NOT REMOVE
                secondNumber = SecondRandomNumberBetween(1, 100)
            Loop
        Else
            secondNumber = SecondRandomNumberBetween(1, 100)
        End If
        secondNumber = SecondRandomNumberBetween(1, 100)
        FirstNumberTextBox.Text = firstNumber.ToString()
        SecondNumberTextBox.Text = secondNumber.ToString()
    End Sub


    'Closing of the program-----------------------------------------------
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


    'Functions past this point---------------------------------------

    'Function in charge of the math
    Function AddingOfNumbers() As Integer
        Dim firstNumber = RandomNumberBetween(1, 100)
        Dim secondNumber = SecondRandomNumberBetween(1, 100)
        Dim answer As Integer

        answer = firstNumber + secondNumber

        Return answer
    End Function

    Function SubtractingOfNumbers() As Integer
        Dim firstNumber = RandomNumberBetween(1, 100)
        Dim secondNumber = SecondRandomNumberBetween(1, 100)
        Dim answer As Integer

        answer = firstNumber - secondNumber

        Return answer
    End Function

    Function MultiplicationOfNumbers() As Integer
        Dim firstNumber = RandomNumberBetween(1, 100)
        Dim secondNumber = SecondRandomNumberBetween(1, 100)
        Dim answer As Integer

        answer = firstNumber * secondNumber

        Return answer
    End Function

    Function DivisionOfNumbers() As Integer
        Dim firstNumber = RandomNumberBetween(1, 100)
        Dim secondNumber = SecondRandomNumberBetween(1, 100)
        Dim answer As Integer

        answer = firstNumber \ secondNumber

        Return answer
    End Function

    'Function in charge of verifying answer
    Function WasAnswerCorrect() As Boolean
        Dim userNumber As Integer

        If Integer.TryParse(StudentAnswerTextBox.Text, userNumber) Then
            Dim actualAnswer As Integer

            If AddRadioButton.Checked Then
                actualAnswer = firstNumber + secondNumber
            ElseIf SubtractRadioButton.Checked Then
                actualAnswer = firstNumber - secondNumber
            ElseIf MultiplyRadioButton.Checked Then
                actualAnswer = firstNumber * secondNumber
            ElseIf DivideRadioButton.Checked Then
                If secondNumber <> 0 Then
                    actualAnswer = firstNumber \ secondNumber
                Else
                    Return False
                End If
            Else
                Return False
            End If

            If userNumber = actualAnswer Then
                correctAnswer += 1
                AffirmCorrectAnswer()
                Return True
            Else
                incorrectAnswer += 1
                MsgBox("Oops! That's not correct. The correct answer was " & actualAnswer)
                Return False
            End If
        Else
            MsgBox("Please enter a valid number.")
            Return False
        End If
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
        Dim age As Integer
        Dim grade As Integer
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

        If Not Integer.TryParse(AgeTextBox.Text, age) Then
            valid = False
            NameTextBox.Focus()
            message &= "Age is required."
        ElseIf age < 7 Or age > 11 Then
            valid = False
            AgeTextBox.Focus()
            message &= "Please enter valid age between 7 through 11"

        End If

        If Not Integer.TryParse(GradeTextBox.Text, grade) Then
            valid = False
            NameTextBox.Focus()
            message &= "Grade is required."
        ElseIf grade < 1 Or grade > 4 Then
            valid = False
            GradeTextBox.Focus()
            message &= "Please enter a grade number between 1 through 4. Otherwise student is ineligible."
        End If

        If Not valid Then
            MsgBox(message, MsgBoxStyle.Exclamation, "User Input Fail!")
        End If

        Return valid

    End Function

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        Dim message As String = "Recorded answers:" & vbCrLf &
            "Correct:" & correctAnswer & vbCrLf &
            "Incorrect:" & incorrectAnswer
        MsgBox(message, MsgBoxStyle.Information, "Quiz Summary")
    End Sub
End Class