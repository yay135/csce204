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
        Me.lstValues = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstValues
        '
        Me.lstValues.FormattingEnabled = True
        Me.lstValues.ItemHeight = 16
        Me.lstValues.Location = New System.Drawing.Point(41, 66)
        Me.lstValues.MultiColumn = True
        Me.lstValues.Name = "lstValues"
        Me.lstValues.Size = New System.Drawing.Size(623, 244)
        Me.lstValues.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Displaying the first 100 Fibonacci numbers"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 356)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstValues)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Fibonacci Sequence"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstValues As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
