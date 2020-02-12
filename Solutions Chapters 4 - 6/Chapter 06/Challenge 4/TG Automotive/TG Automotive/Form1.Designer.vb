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
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.lblTotalFees = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblTaxOnParts = New System.Windows.Forms.Label()
        Me.lblServicesAndLabor = New System.Windows.Forms.Label()
        Me.lblParts = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculateTotal = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkInspection = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkTransmissionFlush = New System.Windows.Forms.CheckBox()
        Me.chkRadiatorFlush = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkLubeJob = New System.Windows.Forms.CheckBox()
        Me.chkOilChange = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkTireRotation = New System.Windows.Forms.CheckBox()
        Me.chkReplaceMuffler = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(440, 438)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 42)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(75, 76)
        Me.txtLabor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(65, 25)
        Me.txtLabor.TabIndex = 1
        '
        'lblTotalFees
        '
        Me.lblTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalFees.Location = New System.Drawing.Point(434, 72)
        Me.lblTotalFees.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalFees.Name = "lblTotalFees"
        Me.lblTotalFees.Size = New System.Drawing.Size(104, 25)
        Me.lblTotalFees.TabIndex = 7
        Me.lblTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.lblTotalFees)
        Me.GroupBox5.Controls.Add(Me.lblTaxOnParts)
        Me.GroupBox5.Controls.Add(Me.lblServicesAndLabor)
        Me.GroupBox5.Controls.Add(Me.lblParts)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Location = New System.Drawing.Point(23, 303)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(583, 118)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Summary of Charges"
        '
        'lblTaxOnParts
        '
        Me.lblTaxOnParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTaxOnParts.Location = New System.Drawing.Point(434, 36)
        Me.lblTaxOnParts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTaxOnParts.Name = "lblTaxOnParts"
        Me.lblTaxOnParts.Size = New System.Drawing.Size(104, 25)
        Me.lblTaxOnParts.TabIndex = 5
        Me.lblTaxOnParts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblServicesAndLabor
        '
        Me.lblServicesAndLabor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblServicesAndLabor.Location = New System.Drawing.Point(170, 36)
        Me.lblServicesAndLabor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServicesAndLabor.Name = "lblServicesAndLabor"
        Me.lblServicesAndLabor.Size = New System.Drawing.Size(104, 25)
        Me.lblServicesAndLabor.TabIndex = 1
        Me.lblServicesAndLabor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblParts
        '
        Me.lblParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblParts.Location = New System.Drawing.Point(170, 69)
        Me.lblParts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblParts.Name = "lblParts"
        Me.lblParts.Size = New System.Drawing.Size(104, 25)
        Me.lblParts.TabIndex = 3
        Me.lblParts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(334, 75)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 20)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Total Fees"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(314, 38)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 20)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Tax ( on parts )"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(112, 70)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 20)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Parts"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 41)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Services and Labor"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(75, 37)
        Me.txtParts.Margin = New System.Windows.Forms.Padding(4)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(65, 25)
        Me.txtParts.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 79)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 20)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Labor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 40)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Parts"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(281, 438)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 42)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculateTotal
        '
        Me.btnCalculateTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateTotal.Location = New System.Drawing.Point(63, 438)
        Me.btnCalculateTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalculateTotal.Name = "btnCalculateTotal"
        Me.btnCalculateTotal.Size = New System.Drawing.Size(176, 42)
        Me.btnCalculateTotal.TabIndex = 4
        Me.btnCalculateTotal.Text = "&Calculate Total"
        Me.btnCalculateTotal.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(148, 79)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "minutes"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtLabor)
        Me.GroupBox4.Controls.Add(Me.txtParts)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(322, 143)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(284, 129)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Parts and Labor"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(148, 42)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 20)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "dollars"
        '
        'chkInspection
        '
        Me.chkInspection.AutoSize = True
        Me.chkInspection.Location = New System.Drawing.Point(28, 25)
        Me.chkInspection.Margin = New System.Windows.Forms.Padding(4)
        Me.chkInspection.Name = "chkInspection"
        Me.chkInspection.Size = New System.Drawing.Size(105, 24)
        Me.chkInspection.TabIndex = 0
        Me.chkInspection.Text = "Inspection"
        Me.chkInspection.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(215, 31)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "50.00"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.chkTransmissionFlush)
        Me.GroupBox2.Controls.Add(Me.chkRadiatorFlush)
        Me.GroupBox2.Location = New System.Drawing.Point(320, 20)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(286, 102)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Radiator and Transmission"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(206, 64)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "120.00"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkTransmissionFlush
        '
        Me.chkTransmissionFlush.AutoSize = True
        Me.chkTransmissionFlush.Location = New System.Drawing.Point(21, 64)
        Me.chkTransmissionFlush.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTransmissionFlush.Name = "chkTransmissionFlush"
        Me.chkTransmissionFlush.Size = New System.Drawing.Size(167, 24)
        Me.chkTransmissionFlush.TabIndex = 1
        Me.chkTransmissionFlush.Text = "Transmission Flush"
        Me.chkTransmissionFlush.UseVisualStyleBackColor = True
        '
        'chkRadiatorFlush
        '
        Me.chkRadiatorFlush.AutoSize = True
        Me.chkRadiatorFlush.Location = New System.Drawing.Point(21, 30)
        Me.chkRadiatorFlush.Margin = New System.Windows.Forms.Padding(4)
        Me.chkRadiatorFlush.Name = "chkRadiatorFlush"
        Me.chkRadiatorFlush.Size = New System.Drawing.Size(135, 24)
        Me.chkRadiatorFlush.TabIndex = 0
        Me.chkRadiatorFlush.Text = "Radiator Flush"
        Me.chkRadiatorFlush.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "36.00"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkLubeJob
        '
        Me.chkLubeJob.AutoSize = True
        Me.chkLubeJob.Location = New System.Drawing.Point(28, 64)
        Me.chkLubeJob.Margin = New System.Windows.Forms.Padding(4)
        Me.chkLubeJob.Name = "chkLubeJob"
        Me.chkLubeJob.Size = New System.Drawing.Size(97, 24)
        Me.chkLubeJob.TabIndex = 1
        Me.chkLubeJob.Text = "Lube Job"
        Me.chkLubeJob.UseVisualStyleBackColor = True
        '
        'chkOilChange
        '
        Me.chkOilChange.AutoSize = True
        Me.chkOilChange.Location = New System.Drawing.Point(27, 32)
        Me.chkOilChange.Margin = New System.Windows.Forms.Padding(4)
        Me.chkOilChange.Name = "chkOilChange"
        Me.chkOilChange.Size = New System.Drawing.Size(109, 24)
        Me.chkOilChange.TabIndex = 0
        Me.chkOilChange.Text = "Oil Change"
        Me.chkOilChange.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(199, 82)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "20.00"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(199, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "15.00"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "200.00"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.chkTireRotation)
        Me.GroupBox3.Controls.Add(Me.chkReplaceMuffler)
        Me.GroupBox3.Controls.Add(Me.chkInspection)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 143)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(273, 129)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Miscellaneous"
        '
        'chkTireRotation
        '
        Me.chkTireRotation.AutoSize = True
        Me.chkTireRotation.Location = New System.Drawing.Point(28, 81)
        Me.chkTireRotation.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTireRotation.Name = "chkTireRotation"
        Me.chkTireRotation.Size = New System.Drawing.Size(122, 24)
        Me.chkTireRotation.TabIndex = 2
        Me.chkTireRotation.Text = "Tire Rotation"
        Me.chkTireRotation.UseVisualStyleBackColor = True
        '
        'chkReplaceMuffler
        '
        Me.chkReplaceMuffler.AutoSize = True
        Me.chkReplaceMuffler.Location = New System.Drawing.Point(28, 53)
        Me.chkReplaceMuffler.Margin = New System.Windows.Forms.Padding(4)
        Me.chkReplaceMuffler.Name = "chkReplaceMuffler"
        Me.chkReplaceMuffler.Size = New System.Drawing.Size(143, 24)
        Me.chkReplaceMuffler.TabIndex = 1
        Me.chkReplaceMuffler.Text = "Replace Muffler"
        Me.chkReplaceMuffler.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkLubeJob)
        Me.GroupBox1.Controls.Add(Me.chkOilChange)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 21)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(273, 102)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Oil and Lubrication"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "28.00"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel1.Location = New System.Drawing.Point(23, 287)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(583, 5)
        Me.Panel1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(634, 497)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateTotal)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "TG Automotive"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtLabor As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalFees As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTaxOnParts As System.Windows.Forms.Label
    Friend WithEvents lblServicesAndLabor As System.Windows.Forms.Label
    Friend WithEvents lblParts As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtParts As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculateTotal As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkInspection As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkTransmissionFlush As System.Windows.Forms.CheckBox
    Friend WithEvents chkRadiatorFlush As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkLubeJob As System.Windows.Forms.CheckBox
    Friend WithEvents chkOilChange As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTireRotation As System.Windows.Forms.CheckBox
    Friend WithEvents chkReplaceMuffler As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label

End Class
