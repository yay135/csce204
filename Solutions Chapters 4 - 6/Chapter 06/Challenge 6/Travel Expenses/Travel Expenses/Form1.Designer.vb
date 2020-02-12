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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotalSavings = New System.Windows.Forms.Label()
        Me.lblTotalExceedings = New System.Windows.Forms.Label()
        Me.lblTotalReimbursements = New System.Windows.Forms.Label()
        Me.lblTotalExpenses = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAirfair = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.txtMeals = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLodging = New System.Windows.Forms.TextBox()
        Me.txtRegistration = New System.Windows.Forms.TextBox()
        Me.txtTaxi = New System.Windows.Forms.TextBox()
        Me.txtParking = New System.Windows.Forms.TextBox()
        Me.txtCarRental = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Airfare     $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Car Rental Fees     $"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 153)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Parking Fees     $"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(55, 185)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Taxi Charges     $"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 217)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Registration Fees     $"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 249)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Lodging per Night     $"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotalSavings)
        Me.GroupBox1.Controls.Add(Me.lblTotalExceedings)
        Me.GroupBox1.Controls.Add(Me.lblTotalReimbursements)
        Me.GroupBox1.Controls.Add(Me.lblTotalExpenses)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(347, 22)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(320, 250)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Summary"
        '
        'lblTotalSavings
        '
        Me.lblTotalSavings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalSavings.Location = New System.Drawing.Point(169, 160)
        Me.lblTotalSavings.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalSavings.Name = "lblTotalSavings"
        Me.lblTotalSavings.Size = New System.Drawing.Size(107, 25)
        Me.lblTotalSavings.TabIndex = 7
        Me.lblTotalSavings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalExceedings
        '
        Me.lblTotalExceedings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalExceedings.Location = New System.Drawing.Point(169, 128)
        Me.lblTotalExceedings.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalExceedings.Name = "lblTotalExceedings"
        Me.lblTotalExceedings.Size = New System.Drawing.Size(107, 25)
        Me.lblTotalExceedings.TabIndex = 5
        Me.lblTotalExceedings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalReimbursements
        '
        Me.lblTotalReimbursements.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalReimbursements.Location = New System.Drawing.Point(169, 96)
        Me.lblTotalReimbursements.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalReimbursements.Name = "lblTotalReimbursements"
        Me.lblTotalReimbursements.Size = New System.Drawing.Size(107, 25)
        Me.lblTotalReimbursements.TabIndex = 3
        Me.lblTotalReimbursements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalExpenses
        '
        Me.lblTotalExpenses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalExpenses.Location = New System.Drawing.Point(169, 64)
        Me.lblTotalExpenses.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalExpenses.Name = "lblTotalExpenses"
        Me.lblTotalExpenses.Size = New System.Drawing.Size(107, 25)
        Me.lblTotalExpenses.TabIndex = 1
        Me.lblTotalExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(97, 165)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 17)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Savings:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(75, 133)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Exceedings:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(44, 101)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Reimbursements:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(87, 69)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Expenses:"
        '
        'txtAirfair
        '
        Me.txtAirfair.Location = New System.Drawing.Point(183, 84)
        Me.txtAirfair.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAirfair.Name = "txtAirfair"
        Me.txtAirfair.Size = New System.Drawing.Size(105, 23)
        Me.txtAirfair.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtMiles)
        Me.GroupBox2.Controls.Add(Me.txtMeals)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtDays)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtLodging)
        Me.GroupBox2.Controls.Add(Me.txtRegistration)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtTaxi)
        Me.GroupBox2.Controls.Add(Me.txtParking)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtCarRental)
        Me.GroupBox2.Controls.Add(Me.txtAirfair)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 21)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(320, 320)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 57)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Private Vehicle Miles"
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(183, 52)
        Me.txtMiles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(105, 23)
        Me.txtMiles.TabIndex = 3
        '
        'txtMeals
        '
        Me.txtMeals.Location = New System.Drawing.Point(183, 276)
        Me.txtMeals.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMeals.Name = "txtMeals"
        Me.txtMeals.Size = New System.Drawing.Size(105, 23)
        Me.txtMeals.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(100, 281)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 17)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Meals     $"
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(183, 20)
        Me.txtDays.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(105, 23)
        Me.txtDays.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Travel Days"
        '
        'txtLodging
        '
        Me.txtLodging.Location = New System.Drawing.Point(183, 244)
        Me.txtLodging.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLodging.Name = "txtLodging"
        Me.txtLodging.Size = New System.Drawing.Size(105, 23)
        Me.txtLodging.TabIndex = 15
        '
        'txtRegistration
        '
        Me.txtRegistration.Location = New System.Drawing.Point(183, 212)
        Me.txtRegistration.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRegistration.Name = "txtRegistration"
        Me.txtRegistration.Size = New System.Drawing.Size(105, 23)
        Me.txtRegistration.TabIndex = 13
        '
        'txtTaxi
        '
        Me.txtTaxi.Location = New System.Drawing.Point(183, 180)
        Me.txtTaxi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTaxi.Name = "txtTaxi"
        Me.txtTaxi.Size = New System.Drawing.Size(105, 23)
        Me.txtTaxi.TabIndex = 11
        '
        'txtParking
        '
        Me.txtParking.Location = New System.Drawing.Point(183, 148)
        Me.txtParking.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtParking.Name = "txtParking"
        Me.txtParking.Size = New System.Drawing.Size(105, 23)
        Me.txtParking.TabIndex = 9
        '
        'txtCarRental
        '
        Me.txtCarRental.Location = New System.Drawing.Point(183, 116)
        Me.txtCarRental.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCarRental.Name = "txtCarRental"
        Me.txtCarRental.Size = New System.Drawing.Size(105, 23)
        Me.txtCarRental.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(351, 293)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 48)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(459, 293)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 48)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(567, 293)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 48)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 362)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Travel Expenses Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalSavings As System.Windows.Forms.Label
    Friend WithEvents lblTotalExceedings As System.Windows.Forms.Label
    Friend WithEvents lblTotalReimbursements As System.Windows.Forms.Label
    Friend WithEvents lblTotalExpenses As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAirfair As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDays As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLodging As System.Windows.Forms.TextBox
    Friend WithEvents txtRegistration As System.Windows.Forms.TextBox
    Friend WithEvents txtTaxi As System.Windows.Forms.TextBox
    Friend WithEvents txtParking As System.Windows.Forms.TextBox
    Friend WithEvents txtCarRental As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtMeals As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMiles As System.Windows.Forms.TextBox

End Class
