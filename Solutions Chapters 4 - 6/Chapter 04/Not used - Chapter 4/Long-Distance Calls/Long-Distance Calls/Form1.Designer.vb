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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radEvening = New System.Windows.Forms.RadioButton()
        Me.radOffPeak = New System.Windows.Forms.RadioButton()
        Me.radDaytime = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMinutes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalCharge = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radEvening)
        Me.GroupBox1.Controls.Add(Me.radOffPeak)
        Me.GroupBox1.Controls.Add(Me.radDaytime)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 69)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Rate Catagory"
        '
        'radEvening
        '
        Me.radEvening.AutoSize = True
        Me.radEvening.Location = New System.Drawing.Point(90, 28)
        Me.radEvening.Name = "radEvening"
        Me.radEvening.Size = New System.Drawing.Size(64, 17)
        Me.radEvening.TabIndex = 1
        Me.radEvening.Text = "Evening"
        Me.radEvening.UseVisualStyleBackColor = True
        '
        'radOffPeak
        '
        Me.radOffPeak.AutoSize = True
        Me.radOffPeak.Location = New System.Drawing.Point(160, 28)
        Me.radOffPeak.Name = "radOffPeak"
        Me.radOffPeak.Size = New System.Drawing.Size(67, 17)
        Me.radOffPeak.TabIndex = 2
        Me.radOffPeak.Text = "Off-Peak"
        Me.radOffPeak.UseVisualStyleBackColor = True
        '
        'radDaytime
        '
        Me.radDaytime.AutoSize = True
        Me.radDaytime.Checked = True
        Me.radDaytime.Location = New System.Drawing.Point(21, 28)
        Me.radDaytime.Name = "radDaytime"
        Me.radDaytime.Size = New System.Drawing.Size(63, 17)
        Me.radDaytime.TabIndex = 0
        Me.radDaytime.TabStop = True
        Me.radDaytime.Text = "Daytime"
        Me.radDaytime.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter the Number of Minutes:"
        '
        'txtMinutes
        '
        Me.txtMinutes.Location = New System.Drawing.Point(168, 87)
        Me.txtMinutes.Name = "txtMinutes"
        Me.txtMinutes.Size = New System.Drawing.Size(100, 20)
        Me.txtMinutes.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Total Charge for the Call:"
        '
        'lblTotalCharge
        '
        Me.lblTotalCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalCharge.Location = New System.Drawing.Point(168, 112)
        Me.lblTotalCharge.Name = "lblTotalCharge"
        Me.lblTotalCharge.Size = New System.Drawing.Size(100, 20)
        Me.lblTotalCharge.TabIndex = 7
        Me.lblTotalCharge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(24, 148)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 30)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(105, 148)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 30)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(186, 148)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 194)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalCharge)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMinutes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Long-Distance Calls"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radEvening As System.Windows.Forms.RadioButton
    Friend WithEvents radOffPeak As System.Windows.Forms.RadioButton
    Friend WithEvents radDaytime As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMinutes As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalCharge As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
