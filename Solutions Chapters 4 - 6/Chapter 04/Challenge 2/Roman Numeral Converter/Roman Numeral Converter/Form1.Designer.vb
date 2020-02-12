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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.lblRomanNumeral = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDecimalInteger = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(238, 145)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 37)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(87, 145)
        Me.btnConvert.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(100, 37)
        Me.btnConvert.TabIndex = 1
        Me.btnConvert.Text = "&Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'lblRomanNumeral
        '
        Me.lblRomanNumeral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRomanNumeral.Location = New System.Drawing.Point(206, 88)
        Me.lblRomanNumeral.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRomanNumeral.Name = "lblRomanNumeral"
        Me.lblRomanNumeral.Size = New System.Drawing.Size(133, 25)
        Me.lblRomanNumeral.TabIndex = 5
        Me.lblRomanNumeral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Equivalent Roman " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Numeral:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDecimalInteger
        '
        Me.txtDecimalInteger.Location = New System.Drawing.Point(206, 34)
        Me.txtDecimalInteger.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDecimalInteger.Name = "txtDecimalInteger"
        Me.txtDecimalInteger.Size = New System.Drawing.Size(132, 22)
        Me.txtDecimalInteger.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter a decimal integer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " in the range 1 - 10:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 224)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblRomanNumeral)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDecimalInteger)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Roman Numeral Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents lblRomanNumeral As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDecimalInteger As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
