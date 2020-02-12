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
		Me.btnCompare = New System.Windows.Forms.Button()
		Me.lblMessage = New System.Windows.Forms.Label()
		Me.txtIntegerB = New System.Windows.Forms.TextBox()
		Me.txtIntegerA = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(219, 153)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(100, 37)
		Me.btnExit.TabIndex = 3
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'btnCompare
		'
		Me.btnCompare.Location = New System.Drawing.Point(66, 153)
		Me.btnCompare.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnCompare.Name = "btnCompare"
		Me.btnCompare.Size = New System.Drawing.Size(100, 37)
		Me.btnCompare.TabIndex = 2
		Me.btnCompare.Text = "&Compare"
		Me.btnCompare.UseVisualStyleBackColor = True
		'
		'lblMessage
		'
		Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblMessage.Location = New System.Drawing.Point(17, 95)
		Me.lblMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblMessage.Name = "lblMessage"
		Me.lblMessage.Size = New System.Drawing.Size(349, 28)
		Me.lblMessage.TabIndex = 7
		Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtIntegerB
		'
		Me.txtIntegerB.Location = New System.Drawing.Point(233, 54)
		Me.txtIntegerB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtIntegerB.Name = "txtIntegerB"
		Me.txtIntegerB.Size = New System.Drawing.Size(86, 22)
		Me.txtIntegerB.TabIndex = 1
		'
		'txtIntegerA
		'
		Me.txtIntegerA.Location = New System.Drawing.Point(83, 56)
		Me.txtIntegerA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtIntegerA.Name = "txtIntegerA"
		Me.txtIntegerA.Size = New System.Drawing.Size(83, 22)
		Me.txtIntegerA.TabIndex = 0
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(205, 59)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(22, 16)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "B:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(58, 59)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(22, 16)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "A:"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(117, 20)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(162, 20)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Enter Two Integers"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(402, 213)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnCompare)
		Me.Controls.Add(Me.lblMessage)
		Me.Controls.Add(Me.txtIntegerB)
		Me.Controls.Add(Me.txtIntegerA)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "Larger and Smaller"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCompare As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents txtIntegerB As System.Windows.Forms.TextBox
    Friend WithEvents txtIntegerA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
