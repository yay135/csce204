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
        Me.components = New System.ComponentModel.Container()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button4.Location = New System.Drawing.Point(122, 108)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 37)
        Me.Button4.TabIndex = 3
        Me.Button4.Tag = "66"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button1.Location = New System.Drawing.Point(39, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 37)
        Me.Button1.TabIndex = 4
        Me.Button1.Tag = "14"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button2.Location = New System.Drawing.Point(39, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 37)
        Me.Button2.TabIndex = 5
        Me.Button2.Tag = "5"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button3.Location = New System.Drawing.Point(122, 55)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 37)
        Me.Button3.TabIndex = 6
        Me.Button3.Tag = "14"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button5.Location = New System.Drawing.Point(209, 55)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 37)
        Me.Button5.TabIndex = 7
        Me.Button5.Tag = "21"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button6.Location = New System.Drawing.Point(209, 108)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(50, 37)
        Me.Button6.TabIndex = 8
        Me.Button6.Tag = "5"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button7.Location = New System.Drawing.Point(291, 55)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(50, 37)
        Me.Button7.TabIndex = 9
        Me.Button7.Tag = "66"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button8.Location = New System.Drawing.Point(291, 108)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(50, 37)
        Me.Button8.TabIndex = 10
        Me.Button8.Tag = "21"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(145, 175)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(94, 43)
        Me.btnCheck.TabIndex = 11
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(396, 243)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Memorization Game"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnCheck As System.Windows.Forms.Button

End Class
