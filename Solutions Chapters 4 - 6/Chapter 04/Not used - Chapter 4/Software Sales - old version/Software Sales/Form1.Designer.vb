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
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnCalculate = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lblOutput = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtQuantitySoldPackageC = New System.Windows.Forms.TextBox()
		Me.txtQuantitySoldPackageB = New System.Windows.Forms.TextBox()
		Me.txtQuantitySoldPackageA = New System.Windows.Forms.TextBox()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(105, 231)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(75, 40)
		Me.btnClear.TabIndex = 8
		Me.btnClear.Text = "C&lear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnCalculate
		'
		Me.btnCalculate.Location = New System.Drawing.Point(24, 231)
		Me.btnCalculate.Name = "btnCalculate"
		Me.btnCalculate.Size = New System.Drawing.Size(75, 41)
		Me.btnCalculate.TabIndex = 7
		Me.btnCalculate.Text = "&Calculate"
		Me.btnCalculate.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(31, 75)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(63, 13)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Package C:"
		'
		'lblOutput
		'
		Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblOutput.Location = New System.Drawing.Point(24, 130)
		Me.lblOutput.Name = "lblOutput"
		Me.lblOutput.Size = New System.Drawing.Size(237, 76)
		Me.lblOutput.TabIndex = 6
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.txtQuantitySoldPackageC)
		Me.GroupBox1.Controls.Add(Me.txtQuantitySoldPackageB)
		Me.GroupBox1.Controls.Add(Me.txtQuantitySoldPackageA)
		Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(237, 97)
		Me.GroupBox1.TabIndex = 5
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Quantity Sold"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(31, 49)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(63, 13)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Package B:"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(31, 23)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(63, 13)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Package A:"
		'
		'txtQuantitySoldPackageC
		'
		Me.txtQuantitySoldPackageC.Location = New System.Drawing.Point(100, 71)
		Me.txtQuantitySoldPackageC.Name = "txtQuantitySoldPackageC"
		Me.txtQuantitySoldPackageC.Size = New System.Drawing.Size(100, 20)
		Me.txtQuantitySoldPackageC.TabIndex = 2
		'
		'txtQuantitySoldPackageB
		'
		Me.txtQuantitySoldPackageB.Location = New System.Drawing.Point(100, 45)
		Me.txtQuantitySoldPackageB.Name = "txtQuantitySoldPackageB"
		Me.txtQuantitySoldPackageB.Size = New System.Drawing.Size(100, 20)
		Me.txtQuantitySoldPackageB.TabIndex = 1
		'
		'txtQuantitySoldPackageA
		'
		Me.txtQuantitySoldPackageA.Location = New System.Drawing.Point(100, 19)
		Me.txtQuantitySoldPackageA.Name = "txtQuantitySoldPackageA"
		Me.txtQuantitySoldPackageA.Size = New System.Drawing.Size(100, 20)
		Me.txtQuantitySoldPackageA.TabIndex = 0
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(186, 231)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(75, 40)
		Me.btnExit.TabIndex = 9
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 284)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnCalculate)
		Me.Controls.Add(Me.lblOutput)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.btnExit)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.Text = "Software Sales"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQuantitySoldPackageC As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantitySoldPackageB As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantitySoldPackageA As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
