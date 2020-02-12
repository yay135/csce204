<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblProblem = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radDivision = New System.Windows.Forms.RadioButton()
        Me.radMultiplication = New System.Windows.Forms.RadioButton()
        Me.radSubtraction = New System.Windows.Forms.RadioButton()
        Me.radAddition = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblFeedback = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(578, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click the Next Problem button to begin"
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(157, 83)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(100, 24)
        Me.txtAnswer.TabIndex = 1
        '
        'lblProblem
        '
        Me.lblProblem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProblem.Location = New System.Drawing.Point(34, 86)
        Me.lblProblem.Name = "lblProblem"
        Me.lblProblem.Size = New System.Drawing.Size(115, 33)
        Me.lblProblem.TabIndex = 2
        Me.lblProblem.Text = "----"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.radDivision)
        Me.GroupBox1.Controls.Add(Me.radMultiplication)
        Me.GroupBox1.Controls.Add(Me.radSubtraction)
        Me.GroupBox1.Controls.Add(Me.radAddition)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 82)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose An Integer Operation"
        '
        'radDivision
        '
        Me.radDivision.AutoSize = True
        Me.radDivision.Location = New System.Drawing.Point(480, 35)
        Me.radDivision.Name = "radDivision"
        Me.radDivision.Size = New System.Drawing.Size(75, 21)
        Me.radDivision.TabIndex = 3
        Me.radDivision.TabStop = True
        Me.radDivision.Text = "Division"
        Me.radDivision.UseVisualStyleBackColor = True
        '
        'radMultiplication
        '
        Me.radMultiplication.AutoSize = True
        Me.radMultiplication.Location = New System.Drawing.Point(314, 35)
        Me.radMultiplication.Name = "radMultiplication"
        Me.radMultiplication.Size = New System.Drawing.Size(107, 21)
        Me.radMultiplication.TabIndex = 2
        Me.radMultiplication.TabStop = True
        Me.radMultiplication.Text = "Multiplication"
        Me.radMultiplication.UseVisualStyleBackColor = True
        '
        'radSubtraction
        '
        Me.radSubtraction.AutoSize = True
        Me.radSubtraction.Location = New System.Drawing.Point(157, 35)
        Me.radSubtraction.Name = "radSubtraction"
        Me.radSubtraction.Size = New System.Drawing.Size(98, 21)
        Me.radSubtraction.TabIndex = 1
        Me.radSubtraction.TabStop = True
        Me.radSubtraction.Text = "Subtraction"
        Me.radSubtraction.UseVisualStyleBackColor = True
        '
        'radAddition
        '
        Me.radAddition.AutoSize = True
        Me.radAddition.Checked = True
        Me.radAddition.Location = New System.Drawing.Point(24, 35)
        Me.radAddition.Name = "radAddition"
        Me.radAddition.Size = New System.Drawing.Size(77, 21)
        Me.radAddition.TabIndex = 0
        Me.radAddition.TabStop = True
        Me.radAddition.Text = "Addition"
        Me.radAddition.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.lblFeedback)
        Me.Panel1.Controls.Add(Me.btnCheck)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblProblem)
        Me.Panel1.Controls.Add(Me.txtAnswer)
        Me.Panel1.Location = New System.Drawing.Point(42, 127)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 169)
        Me.Panel1.TabIndex = 4
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(366, 114)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(186, 28)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next Problem"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblFeedback
        '
        Me.lblFeedback.Location = New System.Drawing.Point(34, 120)
        Me.lblFeedback.Name = "lblFeedback"
        Me.lblFeedback.Size = New System.Drawing.Size(298, 33)
        Me.lblFeedback.TabIndex = 4
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(366, 79)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(186, 29)
        Me.btnCheck.TabIndex = 3
        Me.btnCheck.Text = "Check Your Answer"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(733, 409)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Integer Math Tutor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents lblProblem As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radDivision As System.Windows.Forms.RadioButton
    Friend WithEvents radMultiplication As System.Windows.Forms.RadioButton
    Friend WithEvents radSubtraction As System.Windows.Forms.RadioButton
    Friend WithEvents radAddition As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblFeedback As System.Windows.Forms.Label
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button

End Class
