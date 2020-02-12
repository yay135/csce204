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
        Me.txtVelocity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculateKineticEnergy = New System.Windows.Forms.Button()
        Me.lblKineticEnergy = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtVelocity
        '
        Me.txtVelocity.Location = New System.Drawing.Point(232, 50)
        Me.txtVelocity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtVelocity.Name = "txtVelocity"
        Me.txtVelocity.Size = New System.Drawing.Size(132, 23)
        Me.txtVelocity.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Velocity ( in meters per second )"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(269, 142)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 46)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(171, 142)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 46)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculateKineticEnergy
        '
        Me.btnCalculateKineticEnergy.Location = New System.Drawing.Point(17, 142)
        Me.btnCalculateKineticEnergy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalculateKineticEnergy.Name = "btnCalculateKineticEnergy"
        Me.btnCalculateKineticEnergy.Size = New System.Drawing.Size(145, 46)
        Me.btnCalculateKineticEnergy.TabIndex = 2
        Me.btnCalculateKineticEnergy.Text = "&Calculate Kinetic Energy"
        Me.btnCalculateKineticEnergy.UseVisualStyleBackColor = True
        '
        'lblKineticEnergy
        '
        Me.lblKineticEnergy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKineticEnergy.Location = New System.Drawing.Point(232, 86)
        Me.lblKineticEnergy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKineticEnergy.Name = "lblKineticEnergy"
        Me.lblKineticEnergy.Size = New System.Drawing.Size(133, 25)
        Me.lblKineticEnergy.TabIndex = 8
        Me.lblKineticEnergy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Kinetic Energy"
        '
        'txtMass
        '
        Me.txtMass.Location = New System.Drawing.Point(232, 18)
        Me.txtMass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMass.Name = "txtMass"
        Me.txtMass.Size = New System.Drawing.Size(132, 23)
        Me.txtMass.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mass ( in kilograms )"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 202)
        Me.Controls.Add(Me.txtVelocity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateKineticEnergy)
        Me.Controls.Add(Me.lblKineticEnergy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMass)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Kinetic Energy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtVelocity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculateKineticEnergy As System.Windows.Forms.Button
    Friend WithEvents lblKineticEnergy As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
