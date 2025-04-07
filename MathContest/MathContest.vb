Option Explicit On
Option Strict On
'Jacob Horsley
'RCET0265
'Spring 2025
'Math Contest
'URL:https://github.com/horsjaco117/MathContest

Imports System.CodeDom.Compiler

Public Class MathContest

    Dim firstNumber As Integer 'Keeps track of the first number from random number gen
    Dim secondNumber As Integer 'Keeps track of the first number from random number gen
    Dim correctAnswer As Integer 'Keeps track of correct answers input by user
    Dim incorrectAnswer As Integer 'Keeps track of incorrect answers input by user
    Dim submitCountToFive As Integer = 0 'Tracks the amount of problems solved by user

    Sub SetDefaults() 'This ensures eveything is blank upon clear

        NameTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        StudentAnswerTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""

    End Sub

    'Everything below this checks to see if all the fields have an input from the user
    Private Sub DisableUntil_Load(sender As Object, e As EventArgs) Handles Me.Shown
        SubmitButton.Enabled = False 'This sub makes the buttons stay disabled until the required fields are input
        AddRadioButton.Enabled = False
        SubtractRadioButton.Enabled = False
        MultiplyRadioButton.Enabled = False
        DivideRadioButton.Enabled = False
    End Sub

    Private Sub ValidateInputs() 'Validates that there are answers in each field
        Dim nameValid As Boolean = Not String.IsNullOrWhiteSpace(NameTextBox.Text)
        Dim ageValid As Boolean = Integer.TryParse(AgeTextBox.Text, Nothing)
        Dim gradeValid As Boolean = Integer.TryParse(GradeTextBox.Text, Nothing)

        Dim allValid As Boolean = nameValid And ageValid And gradeValid

        'Once all values read valid the buttons are enabled
        SummaryButton.Enabled = allValid
        AddRadioButton.Enabled = allValid
        SubtractRadioButton.Enabled = allValid
        MultiplyRadioButton.Enabled = allValid
        DivideRadioButton.Enabled = allValid

    End Sub

    Private Sub SubmitAcivation() 'Code specifically that activates once an answer is written down. Prevents submitting without answer
        Dim answerWritten As Boolean = Integer.TryParse(StudentAnswerTextBox.Text, Nothing)
        Dim valid As Boolean = answerWritten
        SubmitButton.Enabled = valid
    End Sub

    'Following subs have this validation code------------------------------------------------------------
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
        SubmitAcivation() 'Extra code for the activation of the submit button once answer is in the box
    End Sub

    'Handling Extra features------------------------------------------
    Private Sub MathContest_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        NameTextBox.Focus() 'Focuses on the text box for the name
        NameTextBox.SelectAll()
        Me.AcceptButton = SubmitButton 'This code the Enter key to automatically use the submit button
        Me.CancelButton = ExitButton 'Ties the escape key to the exit button
        AddRadioButton.Checked = True 'Ensures the addition key is always selected on init
    End Sub

    'This stuff clears-----------------------------------------------

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        SubmitAcivation() 'Allows button to be pressed

        If ValidInputs() Then
            submitCountToFive += 1 ' Increase counter on every valid submission
            WasAnswerCorrect()
            StudentAnswerTextBox.Clear()
            GenerateAndShowNumbers()

            If submitCountToFive = 5 Then
                Dim resultMessage As String = $"{NameTextBox.Text} got {correctAnswer} correct out of 5"

                MsgBox(resultMessage, MsgBoxStyle.Information, "Results")

                ' Resets counter. Resets after 5 every time. Modifications could be made
                submitCountToFive = 0
                correctAnswer = 0
                incorrectAnswer = 0
            End If
        End If

        StudentAnswerTextBox.Clear()
    End Sub


    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click 'Allows the clear button to clear everything
        NameTextBox.Clear()
        FirstNumberTextBox.Clear()
        SecondNumberTextBox.Clear()
        AgeTextBox.Clear()
        GradeTextBox.Clear()
        AddRadioButton.Checked = True
        correctAnswer = 0
        incorrectAnswer = 0
    End Sub

    Sub AffirmCorrectAnswer() 'Shows message at correct answer

        MsgBox("Correct")

    End Sub

    'Number Generation------------------------------------------------
    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged
        If AddRadioButton.Checked Then
            GenerateAndShowNumbers() 'Generates number when button is pressed
        End If
    End Sub

    Private Sub SubtractRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractRadioButton.CheckedChanged
        If SubtractRadioButton.Checked Then
            GenerateAndShowNumbers() 'Generates number when button is pressed
        End If
    End Sub

    Private Sub MultiplyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplyRadioButton.CheckedChanged
        If MultiplyRadioButton.Checked Then
            GenerateAndShowNumbers() 'Generates number when button is pressed
        End If
    End Sub

    Private Sub DivideRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivideRadioButton.CheckedChanged
        If DivideRadioButton.Checked Then
            GenerateAndShowNumbers() 'Generates number when button is pressed
        End If
    End Sub

    ' This generates the numbers and actually matches what's shown on the form now
    Private Sub GenerateAndShowNumbers()
        firstNumber = RandomNumberBetween(1, 10)

        If DivideRadioButton.Checked Then
            secondNumber = SecondRandomNumberBetween(1, 10)
            Do While secondNumber = 0 'This prevents the crashing of the program DO NOT REMOVE. No zeroes
                secondNumber = SecondRandomNumberBetween(1, 10)
            Loop
        Else
            secondNumber = SecondRandomNumberBetween(1, 10)
        End If
        secondNumber = SecondRandomNumberBetween(1, 10)
        FirstNumberTextBox.Text = firstNumber.ToString()
        SecondNumberTextBox.Text = secondNumber.ToString()
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click 'Clicking of summary gives a summary
        Dim message As String = "Recorded answers:" & vbCrLf &
            "Correct:" & correctAnswer & vbCrLf &
            "Incorrect:" & incorrectAnswer
        MsgBox(message, MsgBoxStyle.Information, "Quiz Summary")
    End Sub

    'Closing of the program-----------------------------------------------
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


    'Only functions past this point---------------------------------------

    'Function in charge of the math
    Function AddingOfNumbers() As Integer 'adds the two random numbers
        Dim firstNumber = RandomNumberBetween(1, 10)
        Dim secondNumber = SecondRandomNumberBetween(1, 10)
        Dim answer As Integer

        answer = firstNumber + secondNumber

        Return answer
    End Function

    Function SubtractingOfNumbers() As Integer 'Subtracts the two random numbers
        Dim firstNumber = RandomNumberBetween(1, 10)
        Dim secondNumber = SecondRandomNumberBetween(1, 10)
        Dim answer As Integer

        answer = firstNumber - secondNumber

        Return answer
    End Function

    Function MultiplicationOfNumbers() As Integer 'Multiplies the two random numbers
        Dim firstNumber = RandomNumberBetween(1, 10)
        Dim secondNumber = SecondRandomNumberBetween(1, 10)
        Dim answer As Integer

        answer = firstNumber * secondNumber

        Return answer
    End Function

    Function DivisionOfNumbers() As Integer 'Divides the two random numbers
        Dim firstNumber = RandomNumberBetween(1, 10)
        Dim secondNumber = SecondRandomNumberBetween(1, 10)
        Dim answer As Integer

        answer = firstNumber \ secondNumber

        Return answer
    End Function

    'Function in charge of verifying answer
    Function WasAnswerCorrect() As Boolean 'Asks behind the scenes: Was the answer correct?
        Dim userNumber As Integer

        If Integer.TryParse(StudentAnswerTextBox.Text, userNumber) Then
            Dim actualAnswer As Integer

            If AddRadioButton.Checked Then 'This does all the math depending on which button was checked
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

            If userNumber = actualAnswer Then 'If the students number matches the answer or not. This checks that.
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


    Function RandomNumberBetween(max As Integer, min As Integer) As Integer 'this helps generate random first numbers
        Dim temp As Single 'The single type helps work with the randomize stuff
        Randomize()
        temp = Rnd()
        temp = temp * (max - min + 1) + min
        Return CInt(Math.Floor(temp)) 'min isn't included
    End Function

    Function SecondRandomNumberBetween(min As Integer, max As Integer) As Integer 'This helps generate second random numbers
        Dim rand As New Random() 'Different way to generate number because why not 
        Return rand.Next(min, max + 1) ' Includes max
    End Function


    Function ValidInputs() As Boolean 'Ensures valid inputs. No square pegs in triangular holes.
        Dim valid As Boolean = True
        Dim message As String
        Dim age As Integer
        Dim grade As Integer
        If NameTextBox.Text = "" Then 'code can't be empty. applies to all
            valid = False
            NameTextBox.Focus() ' Focuses on the box that doesn't have the info. Tab order should help in properties
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
        ElseIf age < 7 Or age > 11 Then 'There's a specific age range here hence extra code
            valid = False
            AgeTextBox.Focus()
            message &= "Please enter valid age between 7 through 11. _
                    otherwise participant is ineligible to participate."

        End If

        If Not Integer.TryParse(GradeTextBox.Text, grade) Then
            valid = False
            NameTextBox.Focus()
            message &= "Grade is required."
        ElseIf grade < 1 Or grade > 4 Then
            valid = False
            GradeTextBox.Focus() 'Specific grade range here
            message &= "Please enter a grade number between 1 through 4. _
                    Otherwise student is ineligible."
        End If

        If Not valid Then 'All the other bad inputs
            MsgBox(message, MsgBoxStyle.Exclamation, "User Input Fail!")
        End If

        Return valid

    End Function

End Class