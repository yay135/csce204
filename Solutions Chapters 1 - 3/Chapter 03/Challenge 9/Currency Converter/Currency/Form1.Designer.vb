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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblYen = New System.Windows.Forms.Label()
        Me.lblEuros = New System.Windows.Forms.Label()
        Me.lblPounds = New System.Windows.Forms.Label()
        Me.txtDollars = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(111, 151)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Yen:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(100, 112)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Euros:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 73)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Pounds:"
        '
        'lblYen
        '
        Me.lblYen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYen.Location = New System.Drawing.Point(157, 146)
        Me.lblYen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYen.Name = "lblYen"
        Me.lblYen.Size = New System.Drawing.Size(133, 25)
        Me.lblYen.TabIndex = 10
        Me.lblYen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEuros
        '
        Me.lblEuros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEuros.Location = New System.Drawing.Point(157, 107)
        Me.lblEuros.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEuros.Name = "lblEuros"
        Me.lblEuros.Size = New System.Drawing.Size(133, 25)
        Me.lblEuros.TabIndex = 8
        Me.lblEuros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPounds
        '
        Me.lblPounds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPounds.Location = New System.Drawing.Point(157, 68)
        Me.lblPounds.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPounds.Name = "lblPounds"
        Me.lblPounds.Size = New System.Drawing.Size(133, 25)
        Me.lblPounds.TabIndex = 6
        Me.lblPounds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDollars
        '
        Me.txtDollars.Location = New System.Drawing.Point(157, 25)
        Me.txtDollars.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDollars.Name = "txtDollars"
        Me.txtDollars.Size = New System.Drawing.Size(132, 23)
        Me.txtDollars.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dollars:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(265, 203)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 36)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(148, 203)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 36)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(32, 203)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 36)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 270)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(419, 22)
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
        Me.ClientSize = New System.Drawing.Size(419, 292)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblYen)
        Me.Controls.Add(Me.lblEuros)
        Me.Controls.Add(Me.lblPounds)
        Me.Controls.Add(Me.txtDollars)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Currency Converter"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblYen As System.Windows.Forms.Label
    Friend WithEvents lblEuros As System.Windows.Forms.Label
    Friend WithEvents lblPounds As System.Windows.Forms.Label
    Friend WithEvents txtDollars As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
	Friend WithEvents btnCalculate As System.Windows.Forms.Button
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel

End Class
