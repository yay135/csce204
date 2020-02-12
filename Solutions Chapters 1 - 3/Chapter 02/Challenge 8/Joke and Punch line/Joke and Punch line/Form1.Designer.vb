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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPunchLine = New System.Windows.Forms.Button()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.lblJoke = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(249, 113)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPunchLine
        '
        Me.btnPunchLine.Location = New System.Drawing.Point(301, 78)
        Me.btnPunchLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPunchLine.Name = "btnPunchLine"
        Me.btnPunchLine.Size = New System.Drawing.Size(100, 28)
        Me.btnPunchLine.TabIndex = 6
        Me.btnPunchLine.Text = "Punch line"
        Me.btnPunchLine.UseVisualStyleBackColor = True
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(193, 78)
        Me.btnSetup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(100, 28)
        Me.btnSetup.TabIndex = 5
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'lblJoke
        '
        Me.lblJoke.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoke.Location = New System.Drawing.Point(20, 11)
        Me.lblJoke.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJoke.Name = "lblJoke"
        Me.lblJoke.Size = New System.Drawing.Size(540, 57)
        Me.lblJoke.TabIndex = 4
        Me.lblJoke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 153)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPunchLine)
        Me.Controls.Add(Me.btnSetup)
        Me.Controls.Add(Me.lblJoke)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Joke and Punch line"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPunchLine As System.Windows.Forms.Button
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents lblJoke As System.Windows.Forms.Label

End Class
