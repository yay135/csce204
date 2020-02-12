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
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.btnCalculate = New System.Windows.Forms.Button()
		Me.txtSoldA = New System.Windows.Forms.TextBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.lblRevenueC = New System.Windows.Forms.Label()
		Me.lblRevenueB = New System.Windows.Forms.Label()
		Me.lblRevenueA = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtSoldC = New System.Windows.Forms.TextBox()
		Me.txtSoldB = New System.Windows.Forms.TextBox()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(275, 239)
		Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(93, 37)
		Me.btnClear.TabIndex = 8
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'lblTotal
		'
		Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblTotal.Location = New System.Drawing.Point(139, 162)
		Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(106, 25)
		Me.lblTotal.TabIndex = 14
		Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btnCalculate
		'
		Me.btnCalculate.Location = New System.Drawing.Point(102, 239)
		Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnCalculate.Name = "btnCalculate"
		Me.btnCalculate.Size = New System.Drawing.Size(150, 35)
		Me.btnCalculate.TabIndex = 7
		Me.btnCalculate.Text = "Calculate Revenue"
		Me.btnCalculate.UseVisualStyleBackColor = True
		'
		'txtSoldA
		'
		Me.txtSoldA.Location = New System.Drawing.Point(117, 81)
		Me.txtSoldA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtSoldA.Name = "txtSoldA"
		Me.txtSoldA.Size = New System.Drawing.Size(57, 22)
		Me.txtSoldA.TabIndex = 0
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.lblTotal)
		Me.GroupBox2.Controls.Add(Me.lblRevenueC)
		Me.GroupBox2.Controls.Add(Me.lblRevenueB)
		Me.GroupBox2.Controls.Add(Me.lblRevenueA)
		Me.GroupBox2.Controls.Add(Me.Label8)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Controls.Add(Me.Label7)
		Me.GroupBox2.Location = New System.Drawing.Point(287, 15)
		Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox2.Size = New System.Drawing.Size(271, 203)
		Me.GroupBox2.TabIndex = 6
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Revenue Generated"
		'
		'lblRevenueC
		'
		Me.lblRevenueC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblRevenueC.Location = New System.Drawing.Point(139, 111)
		Me.lblRevenueC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblRevenueC.Name = "lblRevenueC"
		Me.lblRevenueC.Size = New System.Drawing.Size(106, 25)
		Me.lblRevenueC.TabIndex = 13
		Me.lblRevenueC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblRevenueB
		'
		Me.lblRevenueB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblRevenueB.Location = New System.Drawing.Point(139, 73)
		Me.lblRevenueB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblRevenueB.Name = "lblRevenueB"
		Me.lblRevenueB.Size = New System.Drawing.Size(106, 25)
		Me.lblRevenueB.TabIndex = 12
		Me.lblRevenueB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblRevenueA
		'
		Me.lblRevenueA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblRevenueA.Location = New System.Drawing.Point(139, 34)
		Me.lblRevenueA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblRevenueA.Name = "lblRevenueA"
		Me.lblRevenueA.Size = New System.Drawing.Size(106, 25)
		Me.lblRevenueA.TabIndex = 11
		Me.lblRevenueA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(23, 167)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(100, 16)
		Me.Label8.TabIndex = 10
		Me.Label8.Text = "Total Revenue:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(71, 116)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(57, 16)
		Me.Label5.TabIndex = 9
		Me.Label5.Text = "Class C:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(71, 78)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(57, 16)
		Me.Label6.TabIndex = 8
		Me.Label6.Text = "Class B:"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(71, 39)
		Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(57, 16)
		Me.Label7.TabIndex = 7
		Me.Label7.Text = "Class A:"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.txtSoldC)
		Me.GroupBox1.Controls.Add(Me.txtSoldB)
		Me.GroupBox1.Controls.Add(Me.txtSoldA)
		Me.GroupBox1.Location = New System.Drawing.Point(17, 15)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Size = New System.Drawing.Size(247, 203)
		Me.GroupBox1.TabIndex = 5
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Tickets Sold"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(44, 167)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(57, 16)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Class C:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(44, 127)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(57, 16)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Class B:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(44, 86)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(57, 16)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Class A:"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(41, 34)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(195, 32)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Enter the number of tickets sold " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for each class of seats"
		'
		'txtSoldC
		'
		Me.txtSoldC.Location = New System.Drawing.Point(117, 162)
		Me.txtSoldC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtSoldC.Name = "txtSoldC"
		Me.txtSoldC.Size = New System.Drawing.Size(57, 22)
		Me.txtSoldC.TabIndex = 2
		'
		'txtSoldB
		'
		Me.txtSoldB.Location = New System.Drawing.Point(117, 122)
		Me.txtSoldB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtSoldB.Name = "txtSoldB"
		Me.txtSoldB.Size = New System.Drawing.Size(57, 22)
		Me.txtSoldB.TabIndex = 1
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(395, 241)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(82, 35)
		Me.btnExit.TabIndex = 9
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 293)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
		Me.StatusStrip1.Size = New System.Drawing.Size(579, 22)
		Me.StatusStrip1.TabIndex = 10
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
		Me.ClientSize = New System.Drawing.Size(579, 315)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnCalculate)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.btnExit)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "Form1"
		Me.Text = "Stadium Seating"
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtSoldA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRevenueC As System.Windows.Forms.Label
    Friend WithEvents lblRevenueB As System.Windows.Forms.Label
    Friend WithEvents lblRevenueA As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSoldC As System.Windows.Forms.TextBox
    Friend WithEvents txtSoldB As System.Windows.Forms.TextBox
	Friend WithEvents btnExit As System.Windows.Forms.Button
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel

End Class
