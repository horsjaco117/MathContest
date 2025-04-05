<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MathContest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        AddRadioButton = New RadioButton()
        SubtractRadioButton = New RadioButton()
        MultiplyRadioButton = New RadioButton()
        DivideRadioButton = New RadioButton()
        StudentInfoLabel = New Label()
        NameLabel = New Label()
        CurrentMathProblemLabel = New Label()
        FirstNumberLabel = New Label()
        SecondNumberLabel = New Label()
        StudentAnswerLabel = New Label()
        AgeLabel = New Label()
        GradeLabel = New Label()
        SubmitButton = New Button()
        ClearButton = New Button()
        SummaryButton = New Button()
        ExitButton = New Button()
        MathProblemTypeLabel = New Label()
        NameTextBox = New TextBox()
        AgeTextBox = New TextBox()
        GradeTextBox = New TextBox()
        FirstNumberTextBox = New TextBox()
        SecondNumberTextBox = New TextBox()
        StudentAnswerTextBox = New TextBox()
        SuspendLayout()
        ' 
        ' AddRadioButton
        ' 
        AddRadioButton.AutoSize = True
        AddRadioButton.Location = New Point(293, 238)
        AddRadioButton.Name = "AddRadioButton"
        AddRadioButton.Size = New Size(71, 29)
        AddRadioButton.TabIndex = 0
        AddRadioButton.TabStop = True
        AddRadioButton.Text = "Add"
        AddRadioButton.UseVisualStyleBackColor = True
        ' 
        ' SubtractRadioButton
        ' 
        SubtractRadioButton.AutoSize = True
        SubtractRadioButton.Location = New Point(293, 273)
        SubtractRadioButton.Name = "SubtractRadioButton"
        SubtractRadioButton.Size = New Size(103, 29)
        SubtractRadioButton.TabIndex = 1
        SubtractRadioButton.TabStop = True
        SubtractRadioButton.Text = "Subtract"
        SubtractRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MultiplyRadioButton
        ' 
        MultiplyRadioButton.AutoSize = True
        MultiplyRadioButton.Location = New Point(293, 308)
        MultiplyRadioButton.Name = "MultiplyRadioButton"
        MultiplyRadioButton.Size = New Size(101, 29)
        MultiplyRadioButton.TabIndex = 2
        MultiplyRadioButton.TabStop = True
        MultiplyRadioButton.Text = "Multiply"
        MultiplyRadioButton.UseVisualStyleBackColor = True
        ' 
        ' DivideRadioButton
        ' 
        DivideRadioButton.AutoSize = True
        DivideRadioButton.Location = New Point(293, 343)
        DivideRadioButton.Name = "DivideRadioButton"
        DivideRadioButton.Size = New Size(87, 29)
        DivideRadioButton.TabIndex = 3
        DivideRadioButton.TabStop = True
        DivideRadioButton.Text = "Divide"
        DivideRadioButton.UseVisualStyleBackColor = True
        ' 
        ' StudentInfoLabel
        ' 
        StudentInfoLabel.AutoSize = True
        StudentInfoLabel.Location = New Point(30, 9)
        StudentInfoLabel.Name = "StudentInfoLabel"
        StudentInfoLabel.Size = New Size(172, 25)
        StudentInfoLabel.TabIndex = 4
        StudentInfoLabel.Text = "Student Information"
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Location = New Point(30, 67)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(59, 25)
        NameLabel.TabIndex = 5
        NameLabel.Text = "Name"
        ' 
        ' CurrentMathProblemLabel
        ' 
        CurrentMathProblemLabel.AutoSize = True
        CurrentMathProblemLabel.Location = New Point(30, 273)
        CurrentMathProblemLabel.Name = "CurrentMathProblemLabel"
        CurrentMathProblemLabel.Size = New Size(188, 25)
        CurrentMathProblemLabel.TabIndex = 6
        CurrentMathProblemLabel.Text = "Current Math Problem"
        ' 
        ' FirstNumberLabel
        ' 
        FirstNumberLabel.AutoSize = True
        FirstNumberLabel.Location = New Point(30, 343)
        FirstNumberLabel.Name = "FirstNumberLabel"
        FirstNumberLabel.Size = New Size(106, 25)
        FirstNumberLabel.TabIndex = 7
        FirstNumberLabel.Text = "1st Number"
        ' 
        ' SecondNumberLabel
        ' 
        SecondNumberLabel.AutoSize = True
        SecondNumberLabel.Location = New Point(30, 417)
        SecondNumberLabel.Name = "SecondNumberLabel"
        SecondNumberLabel.Size = New Size(113, 25)
        SecondNumberLabel.TabIndex = 8
        SecondNumberLabel.Text = "2nd Number"
        ' 
        ' StudentAnswerLabel
        ' 
        StudentAnswerLabel.AutoSize = True
        StudentAnswerLabel.Location = New Point(30, 478)
        StudentAnswerLabel.Name = "StudentAnswerLabel"
        StudentAnswerLabel.Size = New Size(136, 25)
        StudentAnswerLabel.TabIndex = 9
        StudentAnswerLabel.Text = "Student Answer"
        ' 
        ' AgeLabel
        ' 
        AgeLabel.AutoSize = True
        AgeLabel.Location = New Point(228, 67)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New Size(44, 25)
        AgeLabel.TabIndex = 10
        AgeLabel.Text = "Age"
        ' 
        ' GradeLabel
        ' 
        GradeLabel.AutoSize = True
        GradeLabel.Location = New Point(390, 67)
        GradeLabel.Name = "GradeLabel"
        GradeLabel.Size = New Size(59, 25)
        GradeLabel.TabIndex = 11
        GradeLabel.Text = "Grade"
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Location = New Point(618, 82)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(112, 34)
        SubmitButton.TabIndex = 12
        SubmitButton.Text = "Submit"
        SubmitButton.UseVisualStyleBackColor = True
        ' 
        ' ClearButton
        ' 
        ClearButton.Location = New Point(618, 158)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(112, 34)
        ClearButton.TabIndex = 13
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' SummaryButton
        ' 
        SummaryButton.Location = New Point(618, 233)
        SummaryButton.Name = "SummaryButton"
        SummaryButton.Size = New Size(112, 34)
        SummaryButton.TabIndex = 14
        SummaryButton.Text = "Summary"
        SummaryButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(618, 303)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(112, 34)
        ExitButton.TabIndex = 15
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' MathProblemTypeLabel
        ' 
        MathProblemTypeLabel.AutoSize = True
        MathProblemTypeLabel.Location = New Point(293, 193)
        MathProblemTypeLabel.Name = "MathProblemTypeLabel"
        MathProblemTypeLabel.Size = New Size(167, 25)
        MathProblemTypeLabel.TabIndex = 16
        MathProblemTypeLabel.Text = "Math Problem Type"
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(30, 106)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(150, 31)
        NameTextBox.TabIndex = 17
        ' 
        ' AgeTextBox
        ' 
        AgeTextBox.Location = New Point(214, 106)
        AgeTextBox.Name = "AgeTextBox"
        AgeTextBox.Size = New Size(150, 31)
        AgeTextBox.TabIndex = 18
        ' 
        ' GradeTextBox
        ' 
        GradeTextBox.Location = New Point(390, 106)
        GradeTextBox.Name = "GradeTextBox"
        GradeTextBox.Size = New Size(150, 31)
        GradeTextBox.TabIndex = 19
        ' 
        ' FirstNumberTextBox
        ' 
        FirstNumberTextBox.Location = New Point(30, 383)
        FirstNumberTextBox.Name = "FirstNumberTextBox"
        FirstNumberTextBox.Size = New Size(150, 31)
        FirstNumberTextBox.TabIndex = 20
        ' 
        ' SecondNumberTextBox
        ' 
        SecondNumberTextBox.Location = New Point(30, 445)
        SecondNumberTextBox.Name = "SecondNumberTextBox"
        SecondNumberTextBox.Size = New Size(150, 31)
        SecondNumberTextBox.TabIndex = 21
        ' 
        ' StudentAnswerTextBox
        ' 
        StudentAnswerTextBox.Location = New Point(30, 506)
        StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        StudentAnswerTextBox.Size = New Size(150, 31)
        StudentAnswerTextBox.TabIndex = 22
        ' 
        ' MathContest
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(921, 575)
        Controls.Add(StudentAnswerTextBox)
        Controls.Add(SecondNumberTextBox)
        Controls.Add(FirstNumberTextBox)
        Controls.Add(GradeTextBox)
        Controls.Add(AgeTextBox)
        Controls.Add(NameTextBox)
        Controls.Add(MathProblemTypeLabel)
        Controls.Add(ExitButton)
        Controls.Add(SummaryButton)
        Controls.Add(ClearButton)
        Controls.Add(SubmitButton)
        Controls.Add(GradeLabel)
        Controls.Add(AgeLabel)
        Controls.Add(StudentAnswerLabel)
        Controls.Add(SecondNumberLabel)
        Controls.Add(FirstNumberLabel)
        Controls.Add(CurrentMathProblemLabel)
        Controls.Add(NameLabel)
        Controls.Add(StudentInfoLabel)
        Controls.Add(DivideRadioButton)
        Controls.Add(MultiplyRadioButton)
        Controls.Add(SubtractRadioButton)
        Controls.Add(AddRadioButton)
        Name = "MathContest"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents StudentInfoLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents CurrentMathProblemLabel As Label
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents GradeLabel As Label
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents MathProblemTypeLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents StudentAnswerTextBox As TextBox

End Class
