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
        components = New ComponentModel.Container()
        AddRadioButton = New RadioButton()
        SubtractRadioButton = New RadioButton()
        MultiplyRadioButton = New RadioButton()
        DivideRadioButton = New RadioButton()
        NameLabel = New Label()
        FirstNumberLabel = New Label()
        SecondNumberLabel = New Label()
        StudentAnswerLabel = New Label()
        AgeLabel = New Label()
        GradeLabel = New Label()
        SubmitButton = New Button()
        ClearButton = New Button()
        SummaryButton = New Button()
        ExitButton = New Button()
        NameTextBox = New TextBox()
        AgeTextBox = New TextBox()
        GradeTextBox = New TextBox()
        FirstNumberTextBox = New TextBox()
        SecondNumberTextBox = New TextBox()
        StudentAnswerTextBox = New TextBox()
        CurrentMathProblemGroupBox = New GroupBox()
        StudentInformationGroupBox = New GroupBox()
        ButtonClusterGroupBox = New GroupBox()
        MathProblemTypeGroupBox = New GroupBox()
        ToolTip1 = New ToolTip(components)
        CurrentMathProblemGroupBox.SuspendLayout()
        StudentInformationGroupBox.SuspendLayout()
        ButtonClusterGroupBox.SuspendLayout()
        MathProblemTypeGroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' AddRadioButton
        ' 
        AddRadioButton.AutoSize = True
        AddRadioButton.Location = New Point(34, 67)
        AddRadioButton.Name = "AddRadioButton"
        AddRadioButton.Size = New Size(71, 29)
        AddRadioButton.TabIndex = 4
        AddRadioButton.TabStop = True
        AddRadioButton.Text = "Add"
        ToolTip1.SetToolTip(AddRadioButton, "Addition math problem")
        AddRadioButton.UseVisualStyleBackColor = True
        ' 
        ' SubtractRadioButton
        ' 
        SubtractRadioButton.AutoSize = True
        SubtractRadioButton.Location = New Point(34, 118)
        SubtractRadioButton.Name = "SubtractRadioButton"
        SubtractRadioButton.Size = New Size(103, 29)
        SubtractRadioButton.TabIndex = 5
        SubtractRadioButton.TabStop = True
        SubtractRadioButton.Text = "Subtract"
        ToolTip1.SetToolTip(SubtractRadioButton, "Subtraction math problem type")
        SubtractRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MultiplyRadioButton
        ' 
        MultiplyRadioButton.AutoSize = True
        MultiplyRadioButton.Location = New Point(34, 171)
        MultiplyRadioButton.Name = "MultiplyRadioButton"
        MultiplyRadioButton.Size = New Size(101, 29)
        MultiplyRadioButton.TabIndex = 6
        MultiplyRadioButton.TabStop = True
        MultiplyRadioButton.Text = "Multiply"
        ToolTip1.SetToolTip(MultiplyRadioButton, "Multiplication math problem type")
        MultiplyRadioButton.UseVisualStyleBackColor = True
        ' 
        ' DivideRadioButton
        ' 
        DivideRadioButton.AutoSize = True
        DivideRadioButton.Location = New Point(34, 231)
        DivideRadioButton.Name = "DivideRadioButton"
        DivideRadioButton.Size = New Size(87, 29)
        DivideRadioButton.TabIndex = 7
        DivideRadioButton.TabStop = True
        DivideRadioButton.Text = "Divide"
        ToolTip1.SetToolTip(DivideRadioButton, "Division math problem type")
        DivideRadioButton.UseVisualStyleBackColor = True
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.Location = New Point(6, 50)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(59, 25)
        NameLabel.TabIndex = 5
        NameLabel.Text = "Name"
        ' 
        ' FirstNumberLabel
        ' 
        FirstNumberLabel.AutoSize = True
        FirstNumberLabel.Location = New Point(6, 40)
        FirstNumberLabel.Name = "FirstNumberLabel"
        FirstNumberLabel.Size = New Size(106, 25)
        FirstNumberLabel.TabIndex = 7
        FirstNumberLabel.Text = "1st Number"
        ' 
        ' SecondNumberLabel
        ' 
        SecondNumberLabel.AutoSize = True
        SecondNumberLabel.Location = New Point(6, 108)
        SecondNumberLabel.Name = "SecondNumberLabel"
        SecondNumberLabel.Size = New Size(113, 25)
        SecondNumberLabel.TabIndex = 8
        SecondNumberLabel.Text = "2nd Number"
        ' 
        ' StudentAnswerLabel
        ' 
        StudentAnswerLabel.AutoSize = True
        StudentAnswerLabel.Location = New Point(6, 180)
        StudentAnswerLabel.Name = "StudentAnswerLabel"
        StudentAnswerLabel.Size = New Size(136, 25)
        StudentAnswerLabel.TabIndex = 9
        StudentAnswerLabel.Text = "Student Answer"
        ' 
        ' AgeLabel
        ' 
        AgeLabel.AutoSize = True
        AgeLabel.Location = New Point(187, 50)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New Size(44, 25)
        AgeLabel.TabIndex = 10
        AgeLabel.Text = "Age"
        ' 
        ' GradeLabel
        ' 
        GradeLabel.AutoSize = True
        GradeLabel.Location = New Point(366, 50)
        GradeLabel.Name = "GradeLabel"
        GradeLabel.Size = New Size(59, 25)
        GradeLabel.TabIndex = 11
        GradeLabel.Text = "Grade"
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Location = New Point(24, 53)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(112, 34)
        SubmitButton.TabIndex = 9
        SubmitButton.Text = "&Submit"
        ToolTip1.SetToolTip(SubmitButton, "Submits the answer from the student")
        SubmitButton.UseVisualStyleBackColor = True
        ' 
        ' ClearButton
        ' 
        ClearButton.Location = New Point(24, 137)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(112, 34)
        ClearButton.TabIndex = 10
        ClearButton.Text = "&Clear"
        ToolTip1.SetToolTip(ClearButton, "Clears all the information on the screen")
        ClearButton.UseVisualStyleBackColor = True
        ' 
        ' SummaryButton
        ' 
        SummaryButton.Location = New Point(24, 220)
        SummaryButton.Name = "SummaryButton"
        SummaryButton.Size = New Size(112, 34)
        SummaryButton.TabIndex = 11
        SummaryButton.Text = "S&ummary"
        ToolTip1.SetToolTip(SummaryButton, "Gives a summary of what the ")
        SummaryButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(24, 281)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(112, 34)
        ExitButton.TabIndex = 12
        ExitButton.Text = "&Exit"
        ToolTip1.SetToolTip(ExitButton, "Exits the program")
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(0, 87)
        NameTextBox.MaxLength = 50
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(150, 31)
        NameTextBox.TabIndex = 1
        ToolTip1.SetToolTip(NameTextBox, "Name of the student")
        ' 
        ' AgeTextBox
        ' 
        AgeTextBox.Location = New Point(187, 87)
        AgeTextBox.MaxLength = 2
        AgeTextBox.Name = "AgeTextBox"
        AgeTextBox.Size = New Size(150, 31)
        AgeTextBox.TabIndex = 2
        ToolTip1.SetToolTip(AgeTextBox, "Age of the student (7-11 Years of age)")
        ' 
        ' GradeTextBox
        ' 
        GradeTextBox.Location = New Point(366, 87)
        GradeTextBox.MaxLength = 1
        GradeTextBox.MinimumSize = New Size(7, 11)
        GradeTextBox.Name = "GradeTextBox"
        GradeTextBox.Size = New Size(150, 31)
        GradeTextBox.TabIndex = 3
        ToolTip1.SetToolTip(GradeTextBox, "Grade year of the student (1-4)")
        ' 
        ' FirstNumberTextBox
        ' 
        FirstNumberTextBox.Location = New Point(6, 71)
        FirstNumberTextBox.Name = "FirstNumberTextBox"
        FirstNumberTextBox.ReadOnly = True
        FirstNumberTextBox.Size = New Size(150, 31)
        FirstNumberTextBox.TabIndex = 20
        ToolTip1.SetToolTip(FirstNumberTextBox, "First Number of the math problem")
        ' 
        ' SecondNumberTextBox
        ' 
        SecondNumberTextBox.Location = New Point(6, 136)
        SecondNumberTextBox.Name = "SecondNumberTextBox"
        SecondNumberTextBox.ReadOnly = True
        SecondNumberTextBox.Size = New Size(150, 31)
        SecondNumberTextBox.TabIndex = 21
        ToolTip1.SetToolTip(SecondNumberTextBox, "Second Number of the math problem")
        ' 
        ' StudentAnswerTextBox
        ' 
        StudentAnswerTextBox.Location = New Point(6, 208)
        StudentAnswerTextBox.MaxLength = 3
        StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        StudentAnswerTextBox.Size = New Size(150, 31)
        StudentAnswerTextBox.TabIndex = 8
        ToolTip1.SetToolTip(StudentAnswerTextBox, "Student enters their answer here")
        ' 
        ' CurrentMathProblemGroupBox
        ' 
        CurrentMathProblemGroupBox.Controls.Add(FirstNumberLabel)
        CurrentMathProblemGroupBox.Controls.Add(StudentAnswerTextBox)
        CurrentMathProblemGroupBox.Controls.Add(FirstNumberTextBox)
        CurrentMathProblemGroupBox.Controls.Add(SecondNumberTextBox)
        CurrentMathProblemGroupBox.Controls.Add(SecondNumberLabel)
        CurrentMathProblemGroupBox.Controls.Add(StudentAnswerLabel)
        CurrentMathProblemGroupBox.Location = New Point(30, 206)
        CurrentMathProblemGroupBox.Name = "CurrentMathProblemGroupBox"
        CurrentMathProblemGroupBox.Size = New Size(201, 262)
        CurrentMathProblemGroupBox.TabIndex = 23
        CurrentMathProblemGroupBox.TabStop = False
        CurrentMathProblemGroupBox.Text = "Current MathProblem"
        ' 
        ' StudentInformationGroupBox
        ' 
        StudentInformationGroupBox.Controls.Add(NameLabel)
        StudentInformationGroupBox.Controls.Add(NameTextBox)
        StudentInformationGroupBox.Controls.Add(GradeTextBox)
        StudentInformationGroupBox.Controls.Add(AgeLabel)
        StudentInformationGroupBox.Controls.Add(AgeTextBox)
        StudentInformationGroupBox.Controls.Add(GradeLabel)
        StudentInformationGroupBox.Location = New Point(36, 24)
        StudentInformationGroupBox.Name = "StudentInformationGroupBox"
        StudentInformationGroupBox.Size = New Size(555, 144)
        StudentInformationGroupBox.TabIndex = 24
        StudentInformationGroupBox.TabStop = False
        StudentInformationGroupBox.Text = "Student Information"
        ' 
        ' ButtonClusterGroupBox
        ' 
        ButtonClusterGroupBox.Controls.Add(SubmitButton)
        ButtonClusterGroupBox.Controls.Add(ClearButton)
        ButtonClusterGroupBox.Controls.Add(SummaryButton)
        ButtonClusterGroupBox.Controls.Add(ExitButton)
        ButtonClusterGroupBox.Location = New Point(664, 24)
        ButtonClusterGroupBox.Name = "ButtonClusterGroupBox"
        ButtonClusterGroupBox.Size = New Size(334, 374)
        ButtonClusterGroupBox.TabIndex = 25
        ButtonClusterGroupBox.TabStop = False
        ' 
        ' MathProblemTypeGroupBox
        ' 
        MathProblemTypeGroupBox.Controls.Add(AddRadioButton)
        MathProblemTypeGroupBox.Controls.Add(SubtractRadioButton)
        MathProblemTypeGroupBox.Controls.Add(MultiplyRadioButton)
        MathProblemTypeGroupBox.Controls.Add(DivideRadioButton)
        MathProblemTypeGroupBox.Location = New Point(286, 206)
        MathProblemTypeGroupBox.Name = "MathProblemTypeGroupBox"
        MathProblemTypeGroupBox.Size = New Size(202, 290)
        MathProblemTypeGroupBox.TabIndex = 26
        MathProblemTypeGroupBox.TabStop = False
        MathProblemTypeGroupBox.Text = "Math Problem Type"
        ' 
        ' MathContest
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1097, 872)
        Controls.Add(MathProblemTypeGroupBox)
        Controls.Add(ButtonClusterGroupBox)
        Controls.Add(StudentInformationGroupBox)
        Controls.Add(CurrentMathProblemGroupBox)
        Name = "MathContest"
        Text = "Math Contest"
        CurrentMathProblemGroupBox.ResumeLayout(False)
        CurrentMathProblemGroupBox.PerformLayout()
        StudentInformationGroupBox.ResumeLayout(False)
        StudentInformationGroupBox.PerformLayout()
        ButtonClusterGroupBox.ResumeLayout(False)
        MathProblemTypeGroupBox.ResumeLayout(False)
        MathProblemTypeGroupBox.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents NameLabel As Label
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents GradeLabel As Label
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents CurrentMathProblemGroupBox As GroupBox
    Friend WithEvents StudentInformationGroupBox As GroupBox
    Friend WithEvents ButtonClusterGroupBox As GroupBox
    Friend WithEvents MathProblemTypeGroupBox As GroupBox
    Friend WithEvents ToolTip1 As ToolTip

End Class
