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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtWeek1 = New System.Windows.Forms.TextBox()
        Me.txtWeek2 = New System.Windows.Forms.TextBox()
        Me.txtWeek3 = New System.Windows.Forms.TextBox()
        Me.txtWeek4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblRevenue1 = New System.Windows.Forms.Label()
        Me.lblRevenue2 = New System.Windows.Forms.Label()
        Me.lblRevenue3 = New System.Windows.Forms.Label()
        Me.lblRevenue4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAdvertisingCost = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(42, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(426, 76)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "This application calculates the amount of advertising revenue paid to a Web site " &
    "that displays links to a selected vendor."
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(50, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 202)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Number of Ad Clicks during the past 4 weekly periods"
        '
        'txtWeek1
        '
        Me.txtWeek1.Location = New System.Drawing.Point(232, 211)
        Me.txtWeek1.Name = "txtWeek1"
        Me.txtWeek1.Size = New System.Drawing.Size(76, 23)
        Me.txtWeek1.TabIndex = 9
        Me.txtWeek1.Text = "0"
        Me.txtWeek1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWeek2
        '
        Me.txtWeek2.Location = New System.Drawing.Point(232, 256)
        Me.txtWeek2.Name = "txtWeek2"
        Me.txtWeek2.Size = New System.Drawing.Size(76, 23)
        Me.txtWeek2.TabIndex = 10
        Me.txtWeek2.Text = "0"
        Me.txtWeek2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWeek3
        '
        Me.txtWeek3.Location = New System.Drawing.Point(232, 296)
        Me.txtWeek3.Name = "txtWeek3"
        Me.txtWeek3.Size = New System.Drawing.Size(76, 23)
        Me.txtWeek3.TabIndex = 11
        Me.txtWeek3.Text = "0"
        Me.txtWeek3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWeek4
        '
        Me.txtWeek4.Location = New System.Drawing.Point(232, 341)
        Me.txtWeek4.Name = "txtWeek4"
        Me.txtWeek4.Size = New System.Drawing.Size(76, 23)
        Me.txtWeek4.TabIndex = 12
        Me.txtWeek4.Text = "0"
        Me.txtWeek4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(208, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(208, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(208, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "3"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(208, 345)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "4"
        '
        'lblRevenue1
        '
        Me.lblRevenue1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRevenue1.Location = New System.Drawing.Point(329, 212)
        Me.lblRevenue1.Name = "lblRevenue1"
        Me.lblRevenue1.Size = New System.Drawing.Size(95, 28)
        Me.lblRevenue1.TabIndex = 18
        Me.lblRevenue1.Text = "0"
        Me.lblRevenue1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRevenue2
        '
        Me.lblRevenue2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRevenue2.Location = New System.Drawing.Point(329, 256)
        Me.lblRevenue2.Name = "lblRevenue2"
        Me.lblRevenue2.Size = New System.Drawing.Size(95, 28)
        Me.lblRevenue2.TabIndex = 19
        Me.lblRevenue2.Text = "0"
        Me.lblRevenue2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRevenue3
        '
        Me.lblRevenue3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRevenue3.Location = New System.Drawing.Point(329, 297)
        Me.lblRevenue3.Name = "lblRevenue3"
        Me.lblRevenue3.Size = New System.Drawing.Size(95, 28)
        Me.lblRevenue3.TabIndex = 20
        Me.lblRevenue3.Text = "0"
        Me.lblRevenue3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRevenue4
        '
        Me.lblRevenue4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRevenue4.Location = New System.Drawing.Point(329, 343)
        Me.lblRevenue4.Name = "lblRevenue4"
        Me.lblRevenue4.Size = New System.Drawing.Size(95, 28)
        Me.lblRevenue4.TabIndex = 21
        Me.lblRevenue4.Text = "0"
        Me.lblRevenue4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(334, 183)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 17)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Revenue"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(53, 406)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(107, 31)
        Me.btnCalculate.TabIndex = 24
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(209, 406)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(89, 31)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(350, 406)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(85, 31)
        Me.btnClose.TabIndex = 26
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 472)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(517, 22)
        Me.StatusStrip1.TabIndex = 27
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 17)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Advertising cost per week:"
        '
        'txtAdvertisingCost
        '
        Me.txtAdvertisingCost.Location = New System.Drawing.Point(254, 107)
        Me.txtAdvertisingCost.Name = "txtAdvertisingCost"
        Me.txtAdvertisingCost.Size = New System.Drawing.Size(91, 23)
        Me.txtAdvertisingCost.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.Location = New System.Drawing.Point(41, 154)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 10)
        Me.Panel1.TabIndex = 30
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 494)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAdvertisingCost)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblRevenue4)
        Me.Controls.Add(Me.lblRevenue3)
        Me.Controls.Add(Me.lblRevenue2)
        Me.Controls.Add(Me.lblRevenue1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtWeek4)
        Me.Controls.Add(Me.txtWeek3)
        Me.Controls.Add(Me.txtWeek2)
        Me.Controls.Add(Me.txtWeek1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Pay Per Click Advertising Revenue"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtWeek1 As System.Windows.Forms.TextBox
    Friend WithEvents txtWeek2 As System.Windows.Forms.TextBox
    Friend WithEvents txtWeek3 As System.Windows.Forms.TextBox
    Friend WithEvents txtWeek4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblRevenue1 As System.Windows.Forms.Label
    Friend WithEvents lblRevenue2 As System.Windows.Forms.Label
    Friend WithEvents lblRevenue3 As System.Windows.Forms.Label
    Friend WithEvents lblRevenue4 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAdvertisingCost As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
