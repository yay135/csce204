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
        Me.btnDisplayResults = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblFreezingWater = New System.Windows.Forms.Label()
        Me.lblFreezingOxygen = New System.Windows.Forms.Label()
        Me.lblFreezingMercury = New System.Windows.Forms.Label()
        Me.lblFreezingEthylAlcohol = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblBoilingWater = New System.Windows.Forms.Label()
        Me.lblBoilingOxygen = New System.Windows.Forms.Label()
        Me.lblBoilingMercury = New System.Windows.Forms.Label()
        Me.lblBoilingEthylAlcohol = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(178, 300)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 44)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDisplayResults
        '
        Me.btnDisplayResults.Location = New System.Drawing.Point(40, 300)
        Me.btnDisplayResults.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDisplayResults.Name = "btnDisplayResults"
        Me.btnDisplayResults.Size = New System.Drawing.Size(129, 44)
        Me.btnDisplayResults.TabIndex = 1
        Me.btnDisplayResults.Text = "&Display Results"
        Me.btnDisplayResults.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(286, 300)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 44)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtTemperature
        '
        Me.txtTemperature.Location = New System.Drawing.Point(259, 23)
        Me.txtTemperature.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(71, 23)
        Me.txtTemperature.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Temperature in Degrees Fahrenheit:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTemperature)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 24)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(345, 55)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblFreezingWater)
        Me.GroupBox2.Controls.Add(Me.lblFreezingOxygen)
        Me.GroupBox2.Controls.Add(Me.lblFreezingMercury)
        Me.GroupBox2.Controls.Add(Me.lblFreezingEthylAlcohol)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.lblBoilingWater)
        Me.GroupBox2.Controls.Add(Me.lblBoilingOxygen)
        Me.GroupBox2.Controls.Add(Me.lblBoilingMercury)
        Me.GroupBox2.Controls.Add(Me.lblBoilingEthylAlcohol)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 98)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(345, 185)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'lblFreezingWater
        '
        Me.lblFreezingWater.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFreezingWater.Location = New System.Drawing.Point(251, 138)
        Me.lblFreezingWater.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFreezingWater.Name = "lblFreezingWater"
        Me.lblFreezingWater.Size = New System.Drawing.Size(67, 25)
        Me.lblFreezingWater.TabIndex = 14
        Me.lblFreezingWater.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFreezingOxygen
        '
        Me.lblFreezingOxygen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFreezingOxygen.Location = New System.Drawing.Point(251, 112)
        Me.lblFreezingOxygen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFreezingOxygen.Name = "lblFreezingOxygen"
        Me.lblFreezingOxygen.Size = New System.Drawing.Size(67, 25)
        Me.lblFreezingOxygen.TabIndex = 11
        Me.lblFreezingOxygen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFreezingMercury
        '
        Me.lblFreezingMercury.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFreezingMercury.Location = New System.Drawing.Point(251, 86)
        Me.lblFreezingMercury.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFreezingMercury.Name = "lblFreezingMercury"
        Me.lblFreezingMercury.Size = New System.Drawing.Size(67, 25)
        Me.lblFreezingMercury.TabIndex = 8
        Me.lblFreezingMercury.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFreezingEthylAlcohol
        '
        Me.lblFreezingEthylAlcohol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFreezingEthylAlcohol.Location = New System.Drawing.Point(251, 60)
        Me.lblFreezingEthylAlcohol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFreezingEthylAlcohol.Name = "lblFreezingEthylAlcohol"
        Me.lblFreezingEthylAlcohol.Size = New System.Drawing.Size(67, 25)
        Me.lblFreezingEthylAlcohol.TabIndex = 5
        Me.lblFreezingEthylAlcohol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(247, 33)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 17)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Freezing"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(160, 33)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 17)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Boiling"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(28, 33)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Substance"
        '
        'lblBoilingWater
        '
        Me.lblBoilingWater.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBoilingWater.Location = New System.Drawing.Point(164, 138)
        Me.lblBoilingWater.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBoilingWater.Name = "lblBoilingWater"
        Me.lblBoilingWater.Size = New System.Drawing.Size(67, 25)
        Me.lblBoilingWater.TabIndex = 13
        Me.lblBoilingWater.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBoilingOxygen
        '
        Me.lblBoilingOxygen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBoilingOxygen.Location = New System.Drawing.Point(164, 112)
        Me.lblBoilingOxygen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBoilingOxygen.Name = "lblBoilingOxygen"
        Me.lblBoilingOxygen.Size = New System.Drawing.Size(67, 25)
        Me.lblBoilingOxygen.TabIndex = 10
        Me.lblBoilingOxygen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBoilingMercury
        '
        Me.lblBoilingMercury.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBoilingMercury.Location = New System.Drawing.Point(164, 86)
        Me.lblBoilingMercury.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBoilingMercury.Name = "lblBoilingMercury"
        Me.lblBoilingMercury.Size = New System.Drawing.Size(67, 25)
        Me.lblBoilingMercury.TabIndex = 7
        Me.lblBoilingMercury.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBoilingEthylAlcohol
        '
        Me.lblBoilingEthylAlcohol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBoilingEthylAlcohol.Location = New System.Drawing.Point(164, 60)
        Me.lblBoilingEthylAlcohol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBoilingEthylAlcohol.Name = "lblBoilingEthylAlcohol"
        Me.lblBoilingEthylAlcohol.Size = New System.Drawing.Size(67, 25)
        Me.lblBoilingEthylAlcohol.TabIndex = 4
        Me.lblBoilingEthylAlcohol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 143)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Water"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 117)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Oxygen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mercury"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ethyl Alcohol"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 372)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayResults)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Freezing and Boiling Points"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDisplayResults As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtTemperature As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFreezingWater As System.Windows.Forms.Label
    Friend WithEvents lblFreezingOxygen As System.Windows.Forms.Label
    Friend WithEvents lblFreezingMercury As System.Windows.Forms.Label
    Friend WithEvents lblFreezingEthylAlcohol As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblBoilingWater As System.Windows.Forms.Label
    Friend WithEvents lblBoilingOxygen As System.Windows.Forms.Label
    Friend WithEvents lblBoilingMercury As System.Windows.Forms.Label
    Friend WithEvents lblBoilingEthylAlcohol As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
