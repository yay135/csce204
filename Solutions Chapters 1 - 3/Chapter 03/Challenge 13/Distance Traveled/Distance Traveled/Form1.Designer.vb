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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lbl8HourDistance = New System.Windows.Forms.Label()
        Me.lbl12HourDistance = New System.Windows.Forms.Label()
        Me.txtSpeed = New System.Windows.Forms.TextBox()
        Me.lbl5HourDistance = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(322, 198)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 41)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(196, 198)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 41)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(73, 198)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 41)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lbl8HourDistance
        '
        Me.lbl8HourDistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl8HourDistance.Location = New System.Drawing.Point(243, 101)
        Me.lbl8HourDistance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl8HourDistance.Name = "lbl8HourDistance"
        Me.lbl8HourDistance.Size = New System.Drawing.Size(133, 25)
        Me.lbl8HourDistance.TabIndex = 8
        Me.lbl8HourDistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl12HourDistance
        '
        Me.lbl12HourDistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl12HourDistance.Location = New System.Drawing.Point(243, 134)
        Me.lbl12HourDistance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl12HourDistance.Name = "lbl12HourDistance"
        Me.lbl12HourDistance.Size = New System.Drawing.Size(133, 25)
        Me.lbl12HourDistance.TabIndex = 10
        Me.lbl12HourDistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSpeed
        '
        Me.txtSpeed.Location = New System.Drawing.Point(243, 29)
        Me.txtSpeed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.Size = New System.Drawing.Size(132, 23)
        Me.txtSpeed.TabIndex = 0
        '
        'lbl5HourDistance
        '
        Me.lbl5HourDistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl5HourDistance.Location = New System.Drawing.Point(243, 68)
        Me.lbl5HourDistance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl5HourDistance.Name = "lbl5HourDistance"
        Me.lbl5HourDistance.Size = New System.Drawing.Size(133, 25)
        Me.lbl5HourDistance.TabIndex = 6
        Me.lbl5HourDistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(111, 139)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "12 Hour Distance:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "8 Hour Distance:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "5 Hour Distance:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Vehicle Speed (MPH):"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 275)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(489, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 297)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lbl8HourDistance)
        Me.Controls.Add(Me.lbl12HourDistance)
        Me.Controls.Add(Me.txtSpeed)
        Me.Controls.Add(Me.lbl5HourDistance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Distance Calculator"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lbl8HourDistance As System.Windows.Forms.Label
    Friend WithEvents lbl12HourDistance As System.Windows.Forms.Label
    Friend WithEvents txtSpeed As System.Windows.Forms.TextBox
    Friend WithEvents lbl5HourDistance As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel

End Class
