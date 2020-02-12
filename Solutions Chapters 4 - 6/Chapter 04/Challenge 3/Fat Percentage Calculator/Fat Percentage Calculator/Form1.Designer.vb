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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtGramsOfFat = New System.Windows.Forms.TextBox()
        Me.txtCaloriesInFood = New System.Windows.Forms.TextBox()
        Me.lblCaloriesFromFat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(283, 179)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 35)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(175, 179)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 35)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(50, 179)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 35)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtGramsOfFat
        '
        Me.txtGramsOfFat.Location = New System.Drawing.Point(300, 67)
        Me.txtGramsOfFat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGramsOfFat.Name = "txtGramsOfFat"
        Me.txtGramsOfFat.Size = New System.Drawing.Size(79, 22)
        Me.txtGramsOfFat.TabIndex = 1
        '
        'txtCaloriesInFood
        '
        Me.txtCaloriesInFood.Location = New System.Drawing.Point(300, 25)
        Me.txtCaloriesInFood.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCaloriesInFood.Name = "txtCaloriesInFood"
        Me.txtCaloriesInFood.Size = New System.Drawing.Size(79, 22)
        Me.txtCaloriesInFood.TabIndex = 0
        '
        'lblCaloriesFromFat
        '
        Me.lblCaloriesFromFat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCaloriesFromFat.Location = New System.Drawing.Point(300, 112)
        Me.lblCaloriesFromFat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCaloriesFromFat.Name = "lblCaloriesFromFat"
        Me.lblCaloriesFromFat.Size = New System.Drawing.Size(80, 25)
        Me.lblCaloriesFromFat.TabIndex = 8
        Me.lblCaloriesFromFat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 116)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(253, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Percentage of calories that come from fat:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter the number of fat grams in the food:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter the number of calories in the food:"
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(45, 149)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(333, 21)
        Me.lblMessage.TabIndex = 9
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 251)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtGramsOfFat)
        Me.Controls.Add(Me.txtCaloriesInFood)
        Me.Controls.Add(Me.lblCaloriesFromFat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Fat Percentage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtGramsOfFat As System.Windows.Forms.TextBox
    Friend WithEvents txtCaloriesInFood As System.Windows.Forms.TextBox
    Friend WithEvents lblCaloriesFromFat As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label

End Class
