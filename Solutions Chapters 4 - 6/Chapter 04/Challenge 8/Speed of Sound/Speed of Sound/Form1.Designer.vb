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
        Me.radWater = New System.Windows.Forms.RadioButton()
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.radSteel = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radAir = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'radWater
        '
        Me.radWater.AutoSize = True
        Me.radWater.Location = New System.Drawing.Point(112, 37)
        Me.radWater.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radWater.Name = "radWater"
        Me.radWater.Size = New System.Drawing.Size(64, 21)
        Me.radWater.TabIndex = 1
        Me.radWater.Text = "&Water"
        Me.radWater.UseVisualStyleBackColor = True
        '
        'txtDistance
        '
        Me.txtDistance.Location = New System.Drawing.Point(241, 24)
        Me.txtDistance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.Size = New System.Drawing.Size(132, 23)
        Me.txtDistance.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Enter a Distance ( in feet ):"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(173, 229)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 39)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'radSteel
        '
        Me.radSteel.AutoSize = True
        Me.radSteel.Location = New System.Drawing.Point(207, 37)
        Me.radSteel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radSteel.Name = "radSteel"
        Me.radSteel.Size = New System.Drawing.Size(58, 21)
        Me.radSteel.TabIndex = 2
        Me.radSteel.Text = "&Steel"
        Me.radSteel.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(40, 229)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 39)
        Me.btnCalculate.TabIndex = 18
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 177)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Total Time ( in seconds ):"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSteel)
        Me.GroupBox1.Controls.Add(Me.radWater)
        Me.GroupBox1.Controls.Add(Me.radAir)
        Me.GroupBox1.Location = New System.Drawing.Point(61, 64)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(313, 86)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Medium ( to determine speed )"
        '
        'radAir
        '
        Me.radAir.AutoSize = True
        Me.radAir.Checked = True
        Me.radAir.Location = New System.Drawing.Point(40, 37)
        Me.radAir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radAir.Name = "radAir"
        Me.radAir.Size = New System.Drawing.Size(43, 21)
        Me.radAir.TabIndex = 0
        Me.radAir.TabStop = True
        Me.radAir.Text = "&Air"
        Me.radAir.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(302, 229)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 39)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTime.Location = New System.Drawing.Point(243, 172)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(133, 25)
        Me.lblTime.TabIndex = 23
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 301)
        Me.Controls.Add(Me.txtDistance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTime)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Speed of Sound"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radWater As System.Windows.Forms.RadioButton
    Friend WithEvents txtDistance As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents radSteel As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radAir As System.Windows.Forms.RadioButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTime As System.Windows.Forms.Label

End Class
