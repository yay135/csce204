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
        Me.txtSentence = New System.Windows.Forms.TextBox()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(46, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(603, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input a short sentence, with the first letter capitalized, and a period at the en" & _
    "d."
        '
        'txtSentence
        '
        Me.txtSentence.Location = New System.Drawing.Point(64, 66)
        Me.txtSentence.Name = "txtSentence"
        Me.txtSentence.Size = New System.Drawing.Size(554, 26)
        Me.txtSentence.TabIndex = 1
        Me.txtSentence.Text = "This is a simple sentence."
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(191, 121)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(275, 29)
        Me.btnMove.TabIndex = 2
        Me.btnMove.Text = "Move the First Word to the End"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 165)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.txtSentence)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Moving Words in a Sentence"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSentence As System.Windows.Forms.TextBox
    Friend WithEvents btnMove As System.Windows.Forms.Button

End Class
