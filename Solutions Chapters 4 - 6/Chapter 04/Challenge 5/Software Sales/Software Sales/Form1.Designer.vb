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
        Me.radOneTime = New System.Windows.Forms.RadioButton()
        Me.radYearly = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkBackup = New System.Windows.Forms.CheckBox()
        Me.chkTraining = New System.Windows.Forms.CheckBox()
        Me.chkLevel3Support = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblOptionalFeatures = New System.Windows.Forms.Label()
        Me.lblSoftwareLicense = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.radOneTime)
        Me.GroupBox1.Controls.Add(Me.radYearly)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 183)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Licensing Options"
        '
        'radOneTime
        '
        Me.radOneTime.AutoSize = True
        Me.radOneTime.Location = New System.Drawing.Point(25, 108)
        Me.radOneTime.Name = "radOneTime"
        Me.radOneTime.Size = New System.Drawing.Size(153, 21)
        Me.radOneTime.TabIndex = 2
        Me.radOneTime.TabStop = True
        Me.radOneTime.Text = "One-Time Purchase"
        Me.radOneTime.UseVisualStyleBackColor = True
        '
        'radYearly
        '
        Me.radYearly.AutoSize = True
        Me.radYearly.Location = New System.Drawing.Point(25, 56)
        Me.radYearly.Name = "radYearly"
        Me.radYearly.Size = New System.Drawing.Size(114, 21)
        Me.radYearly.TabIndex = 0
        Me.radYearly.TabStop = True
        Me.radYearly.Text = "Yearly license"
        Me.radYearly.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.chkBackup)
        Me.GroupBox2.Controls.Add(Me.chkTraining)
        Me.GroupBox2.Controls.Add(Me.chkLevel3Support)
        Me.GroupBox2.Location = New System.Drawing.Point(310, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 183)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Optional Features (yearly)"
        '
        'chkBackup
        '
        Me.chkBackup.AutoSize = True
        Me.chkBackup.Location = New System.Drawing.Point(32, 129)
        Me.chkBackup.Name = "chkBackup"
        Me.chkBackup.Size = New System.Drawing.Size(114, 21)
        Me.chkBackup.TabIndex = 2
        Me.chkBackup.Text = "Cloud Backup"
        Me.chkBackup.UseVisualStyleBackColor = True
        '
        'chkTraining
        '
        Me.chkTraining.AutoSize = True
        Me.chkTraining.Location = New System.Drawing.Point(32, 80)
        Me.chkTraining.Name = "chkTraining"
        Me.chkTraining.Size = New System.Drawing.Size(129, 21)
        Me.chkTraining.TabIndex = 1
        Me.chkTraining.Text = "On-site Training"
        Me.chkTraining.UseVisualStyleBackColor = True
        '
        'chkLevel3Support
        '
        Me.chkLevel3Support.AutoSize = True
        Me.chkLevel3Support.Location = New System.Drawing.Point(32, 38)
        Me.chkLevel3Support.Name = "chkLevel3Support"
        Me.chkLevel3Support.Size = New System.Drawing.Size(193, 21)
        Me.chkLevel3Support.TabIndex = 0
        Me.chkLevel3Support.Text = "Level-3 Technical Support"
        Me.chkLevel3Support.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblOptionalFeatures)
        Me.Panel1.Controls.Add(Me.lblSoftwareLicense)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(38, 258)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 113)
        Me.Panel1.TabIndex = 2
        '
        'lblOptionalFeatures
        '
        Me.lblOptionalFeatures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOptionalFeatures.Location = New System.Drawing.Point(261, 66)
        Me.lblOptionalFeatures.Name = "lblOptionalFeatures"
        Me.lblOptionalFeatures.Size = New System.Drawing.Size(95, 26)
        Me.lblOptionalFeatures.TabIndex = 3
        '
        'lblSoftwareLicense
        '
        Me.lblSoftwareLicense.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSoftwareLicense.Location = New System.Drawing.Point(261, 15)
        Me.lblSoftwareLicense.Name = "lblSoftwareLicense"
        Me.lblSoftwareLicense.Size = New System.Drawing.Size(95, 26)
        Me.lblSoftwareLicense.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cost of optional features:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cost of software licensing:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(132, 406)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(114, 33)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(310, 406)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 33)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(455, 406)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(98, 33)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(656, 478)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Software Sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radOneTime As System.Windows.Forms.RadioButton
    Friend WithEvents radYearly As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkBackup As System.Windows.Forms.CheckBox
    Friend WithEvents chkTraining As System.Windows.Forms.CheckBox
    Friend WithEvents chkLevel3Support As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblOptionalFeatures As System.Windows.Forms.Label
    Friend WithEvents lblSoftwareLicense As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
