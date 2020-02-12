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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radChinese = New System.Windows.Forms.RadioButton()
        Me.radGerman = New System.Windows.Forms.RadioButton()
        Me.radFrench = New System.Windows.Forms.RadioButton()
        Me.radEnglish = New System.Windows.Forms.RadioButton()
        Me.radArabic = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkMedievalEurope = New System.Windows.Forms.CheckBox()
        Me.chkMeso = New System.Windows.Forms.CheckBox()
        Me.chkEgypt = New System.Windows.Forms.CheckBox()
        Me.chkAncientEurope = New System.Windows.Forms.CheckBox()
        Me.chkChina = New System.Windows.Forms.CheckBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(26, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(425, 63)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "This application lets the user select various options for tours at our museum. Wh" &
    "en you click the Calculate Cost button, it will calculate and display the tour c" &
    "ost."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.radChinese)
        Me.GroupBox1.Controls.Add(Me.radGerman)
        Me.GroupBox1.Controls.Add(Me.radFrench)
        Me.GroupBox1.Controls.Add(Me.radEnglish)
        Me.GroupBox1.Controls.Add(Me.radArabic)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(163, 211)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Language"
        '
        'radChinese
        '
        Me.radChinese.AutoSize = True
        Me.radChinese.Location = New System.Drawing.Point(16, 69)
        Me.radChinese.Name = "radChinese"
        Me.radChinese.Size = New System.Drawing.Size(77, 21)
        Me.radChinese.TabIndex = 4
        Me.radChinese.TabStop = True
        Me.radChinese.Text = "Chinese"
        Me.radChinese.UseVisualStyleBackColor = True
        '
        'radGerman
        '
        Me.radGerman.AutoSize = True
        Me.radGerman.Location = New System.Drawing.Point(16, 160)
        Me.radGerman.Name = "radGerman"
        Me.radGerman.Size = New System.Drawing.Size(77, 21)
        Me.radGerman.TabIndex = 3
        Me.radGerman.TabStop = True
        Me.radGerman.Text = "German"
        Me.radGerman.UseVisualStyleBackColor = True
        '
        'radFrench
        '
        Me.radFrench.AutoSize = True
        Me.radFrench.Location = New System.Drawing.Point(16, 128)
        Me.radFrench.Name = "radFrench"
        Me.radFrench.Size = New System.Drawing.Size(70, 21)
        Me.radFrench.TabIndex = 2
        Me.radFrench.TabStop = True
        Me.radFrench.Text = "French"
        Me.radFrench.UseVisualStyleBackColor = True
        '
        'radEnglish
        '
        Me.radEnglish.AutoSize = True
        Me.radEnglish.Location = New System.Drawing.Point(16, 98)
        Me.radEnglish.Name = "radEnglish"
        Me.radEnglish.Size = New System.Drawing.Size(72, 21)
        Me.radEnglish.TabIndex = 1
        Me.radEnglish.TabStop = True
        Me.radEnglish.Text = "English"
        Me.radEnglish.UseVisualStyleBackColor = True
        '
        'radArabic
        '
        Me.radArabic.AutoSize = True
        Me.radArabic.Location = New System.Drawing.Point(16, 40)
        Me.radArabic.Name = "radArabic"
        Me.radArabic.Size = New System.Drawing.Size(66, 21)
        Me.radArabic.TabIndex = 0
        Me.radArabic.TabStop = True
        Me.radArabic.Text = "Arabic"
        Me.radArabic.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.chkMedievalEurope)
        Me.GroupBox2.Controls.Add(Me.chkMeso)
        Me.GroupBox2.Controls.Add(Me.chkEgypt)
        Me.GroupBox2.Controls.Add(Me.chkAncientEurope)
        Me.GroupBox2.Controls.Add(Me.chkChina)
        Me.GroupBox2.Location = New System.Drawing.Point(249, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(197, 211)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Featured Sections"
        '
        'chkMedievalEurope
        '
        Me.chkMedievalEurope.AutoSize = True
        Me.chkMedievalEurope.Location = New System.Drawing.Point(28, 161)
        Me.chkMedievalEurope.Name = "chkMedievalEurope"
        Me.chkMedievalEurope.Size = New System.Drawing.Size(133, 21)
        Me.chkMedievalEurope.TabIndex = 4
        Me.chkMedievalEurope.Text = "Medieval Europe"
        Me.chkMedievalEurope.UseVisualStyleBackColor = True
        '
        'chkMeso
        '
        Me.chkMeso.AutoSize = True
        Me.chkMeso.Location = New System.Drawing.Point(28, 131)
        Me.chkMeso.Name = "chkMeso"
        Me.chkMeso.Size = New System.Drawing.Size(111, 21)
        Me.chkMeso.TabIndex = 3
        Me.chkMeso.Text = "Mesopotamia"
        Me.chkMeso.UseVisualStyleBackColor = True
        '
        'chkEgypt
        '
        Me.chkEgypt.AutoSize = True
        Me.chkEgypt.Location = New System.Drawing.Point(28, 101)
        Me.chkEgypt.Name = "chkEgypt"
        Me.chkEgypt.Size = New System.Drawing.Size(114, 21)
        Me.chkEgypt.TabIndex = 2
        Me.chkEgypt.Text = "Ancient Egypt"
        Me.chkEgypt.UseVisualStyleBackColor = True
        '
        'chkAncientEurope
        '
        Me.chkAncientEurope.AutoSize = True
        Me.chkAncientEurope.Location = New System.Drawing.Point(28, 71)
        Me.chkAncientEurope.Name = "chkAncientEurope"
        Me.chkAncientEurope.Size = New System.Drawing.Size(124, 21)
        Me.chkAncientEurope.TabIndex = 1
        Me.chkAncientEurope.Text = "Ancient Europe"
        Me.chkAncientEurope.UseVisualStyleBackColor = True
        '
        'chkChina
        '
        Me.chkChina.AutoSize = True
        Me.chkChina.Location = New System.Drawing.Point(28, 40)
        Me.chkChina.Name = "chkChina"
        Me.chkChina.Size = New System.Drawing.Size(114, 21)
        Me.chkChina.TabIndex = 0
        Me.chkChina.Text = "Ancient China"
        Me.chkChina.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(59, 375)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(143, 32)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(254, 375)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(143, 32)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close Window"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Location = New System.Drawing.Point(21, 351)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(445, 5)
        Me.Panel1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(488, 431)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Museum Tours"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radChinese As System.Windows.Forms.RadioButton
    Friend WithEvents radGerman As System.Windows.Forms.RadioButton
    Friend WithEvents radFrench As System.Windows.Forms.RadioButton
    Friend WithEvents radEnglish As System.Windows.Forms.RadioButton
    Friend WithEvents radArabic As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkMedievalEurope As System.Windows.Forms.CheckBox
    Friend WithEvents chkMeso As System.Windows.Forms.CheckBox
    Friend WithEvents chkEgypt As System.Windows.Forms.CheckBox
    Friend WithEvents chkAncientEurope As System.Windows.Forms.CheckBox
    Friend WithEvents chkChina As System.Windows.Forms.CheckBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
