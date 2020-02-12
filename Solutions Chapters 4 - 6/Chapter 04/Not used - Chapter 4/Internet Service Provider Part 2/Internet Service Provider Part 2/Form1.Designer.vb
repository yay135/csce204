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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkNonprofitOrganization = New System.Windows.Forms.CheckBox()
        Me.radPackageC = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.radPackageB = New System.Windows.Forms.RadioButton()
        Me.radPackageA = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTotalAmountDue = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHoursUsed = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkDisplayPotentialSavings = New System.Windows.Forms.CheckBox()
        Me.lblPotentialSavings = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkNonprofitOrganization)
        Me.GroupBox2.Location = New System.Drawing.Point(106, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(154, 56)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select a Discount"
        '
        'chkNonprofitOrganization
        '
        Me.chkNonprofitOrganization.AutoSize = True
        Me.chkNonprofitOrganization.Location = New System.Drawing.Point(6, 24)
        Me.chkNonprofitOrganization.Name = "chkNonprofitOrganization"
        Me.chkNonprofitOrganization.Size = New System.Drawing.Size(131, 17)
        Me.chkNonprofitOrganization.TabIndex = 0
        Me.chkNonprofitOrganization.Text = "Nonprofit Organization"
        Me.chkNonprofitOrganization.UseVisualStyleBackColor = True
        '
        'radPackageC
        '
        Me.radPackageC.AutoSize = True
        Me.radPackageC.Location = New System.Drawing.Point(8, 67)
        Me.radPackageC.Name = "radPackageC"
        Me.radPackageC.Size = New System.Drawing.Size(78, 17)
        Me.radPackageC.TabIndex = 2
        Me.radPackageC.Text = "Package C"
        Me.radPackageC.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(186, 237)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 35)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'radPackageB
        '
        Me.radPackageB.AutoSize = True
        Me.radPackageB.Location = New System.Drawing.Point(8, 44)
        Me.radPackageB.Name = "radPackageB"
        Me.radPackageB.Size = New System.Drawing.Size(78, 17)
        Me.radPackageB.TabIndex = 1
        Me.radPackageB.Text = "Package B"
        Me.radPackageB.UseVisualStyleBackColor = True
        '
        'radPackageA
        '
        Me.radPackageA.AutoSize = True
        Me.radPackageA.Checked = True
        Me.radPackageA.Location = New System.Drawing.Point(8, 21)
        Me.radPackageA.Name = "radPackageA"
        Me.radPackageA.Size = New System.Drawing.Size(78, 17)
        Me.radPackageA.TabIndex = 0
        Me.radPackageA.TabStop = True
        Me.radPackageA.Text = "Package A"
        Me.radPackageA.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(105, 237)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 35)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(24, 237)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 35)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTotalAmountDue
        '
        Me.lblTotalAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAmountDue.Location = New System.Drawing.Point(187, 153)
        Me.lblTotalAmountDue.Name = "lblTotalAmountDue"
        Me.lblTotalAmountDue.Size = New System.Drawing.Size(80, 20)
        Me.lblTotalAmountDue.TabIndex = 7
        Me.lblTotalAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Total Amount Due:"
        '
        'txtHoursUsed
        '
        Me.txtHoursUsed.Location = New System.Drawing.Point(187, 122)
        Me.txtHoursUsed.Name = "txtHoursUsed"
        Me.txtHoursUsed.Size = New System.Drawing.Size(80, 20)
        Me.txtHoursUsed.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter the Number of Hours Used:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkDisplayPotentialSavings)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.radPackageC)
        Me.GroupBox1.Controls.Add(Me.radPackageB)
        Me.GroupBox1.Controls.Add(Me.radPackageA)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Subscription Package"
        '
        'chkDisplayPotentialSavings
        '
        Me.chkDisplayPotentialSavings.AutoSize = True
        Me.chkDisplayPotentialSavings.Location = New System.Drawing.Point(112, 19)
        Me.chkDisplayPotentialSavings.Name = "chkDisplayPotentialSavings"
        Me.chkDisplayPotentialSavings.Size = New System.Drawing.Size(145, 17)
        Me.chkDisplayPotentialSavings.TabIndex = 3
        Me.chkDisplayPotentialSavings.Text = "Display Potential Savings"
        Me.chkDisplayPotentialSavings.UseVisualStyleBackColor = True
        '
        'lblPotentialSavings
        '
        Me.lblPotentialSavings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPotentialSavings.Location = New System.Drawing.Point(21, 180)
        Me.lblPotentialSavings.Name = "lblPotentialSavings"
        Me.lblPotentialSavings.Size = New System.Drawing.Size(246, 54)
        Me.lblPotentialSavings.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 284)
        Me.Controls.Add(Me.lblPotentialSavings)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalAmountDue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHoursUsed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Internet Service Provider Part 2"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkNonprofitOrganization As System.Windows.Forms.CheckBox
    Friend WithEvents radPackageC As System.Windows.Forms.RadioButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents radPackageB As System.Windows.Forms.RadioButton
    Friend WithEvents radPackageA As System.Windows.Forms.RadioButton
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblTotalAmountDue As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHoursUsed As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkDisplayPotentialSavings As System.Windows.Forms.CheckBox
    Friend WithEvents lblPotentialSavings As System.Windows.Forms.Label

End Class
