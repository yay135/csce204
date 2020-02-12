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
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.lblNetRevenue = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.lblNetChildSales = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.lblNetAdultSales = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.lblGrossRevenue = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.lblGrossChildSales = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.lblGrossAdultSales = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.txtChildSold = New System.Windows.Forms.TextBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.txtChildPrice = New System.Windows.Forms.TextBox()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.txtAdultSold = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtAdultPrice = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblStatus = New System.Windows.Forms.Label()
		Me.GroupBox4.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(434, 321)
		Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(133, 41)
		Me.btnExit.TabIndex = 4
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(272, 321)
		Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(133, 41)
		Me.btnClear.TabIndex = 3
		Me.btnClear.Text = "Cl&ear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnCalculate
		'
		Me.btnCalculate.Location = New System.Drawing.Point(43, 321)
		Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnCalculate.Name = "btnCalculate"
		Me.btnCalculate.Size = New System.Drawing.Size(201, 41)
		Me.btnCalculate.TabIndex = 2
		Me.btnCalculate.Text = "&Calculate Ticket Revenue"
		Me.btnCalculate.UseVisualStyleBackColor = True
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.lblNetRevenue)
		Me.GroupBox4.Controls.Add(Me.Label4)
		Me.GroupBox4.Controls.Add(Me.lblNetChildSales)
		Me.GroupBox4.Controls.Add(Me.Label12)
		Me.GroupBox4.Controls.Add(Me.lblNetAdultSales)
		Me.GroupBox4.Controls.Add(Me.Label14)
		Me.GroupBox4.Location = New System.Drawing.Point(321, 140)
		Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox4.Size = New System.Drawing.Size(295, 160)
		Me.GroupBox4.TabIndex = 6
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Net Ticket Revenue"
		'
		'lblNetRevenue
		'
		Me.lblNetRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblNetRevenue.Location = New System.Drawing.Point(175, 111)
		Me.lblNetRevenue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblNetRevenue.Name = "lblNetRevenue"
		Me.lblNetRevenue.Size = New System.Drawing.Size(88, 28)
		Me.lblNetRevenue.TabIndex = 5
		Me.lblNetRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(39, 108)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(121, 32)
		Me.Label4.TabIndex = 4
		Me.Label4.Text = "Total Net Revenue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Ticket Sales:"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblNetChildSales
		'
		Me.lblNetChildSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblNetChildSales.Location = New System.Drawing.Point(175, 63)
		Me.lblNetChildSales.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblNetChildSales.Name = "lblNetChildSales"
		Me.lblNetChildSales.Size = New System.Drawing.Size(88, 28)
		Me.lblNetChildSales.TabIndex = 3
		Me.lblNetChildSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(43, 69)
		Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(119, 16)
		Me.Label12.TabIndex = 2
		Me.Label12.Text = "Child Ticket Sales:"
		'
		'lblNetAdultSales
		'
		Me.lblNetAdultSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblNetAdultSales.Location = New System.Drawing.Point(175, 20)
		Me.lblNetAdultSales.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblNetAdultSales.Name = "lblNetAdultSales"
		Me.lblNetAdultSales.Size = New System.Drawing.Size(88, 28)
		Me.lblNetAdultSales.TabIndex = 1
		Me.lblNetAdultSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(41, 26)
		Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(119, 16)
		Me.Label14.TabIndex = 0
		Me.Label14.Text = "Adult Ticket Sales:"
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.lblGrossRevenue)
		Me.GroupBox3.Controls.Add(Me.Label10)
		Me.GroupBox3.Controls.Add(Me.lblGrossChildSales)
		Me.GroupBox3.Controls.Add(Me.Label8)
		Me.GroupBox3.Controls.Add(Me.lblGrossAdultSales)
		Me.GroupBox3.Controls.Add(Me.Label5)
		Me.GroupBox3.Location = New System.Drawing.Point(16, 140)
		Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox3.Size = New System.Drawing.Size(287, 160)
		Me.GroupBox3.TabIndex = 5
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Gross Ticket Revenue"
		'
		'lblGrossRevenue
		'
		Me.lblGrossRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblGrossRevenue.Location = New System.Drawing.Point(172, 111)
		Me.lblGrossRevenue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblGrossRevenue.Name = "lblGrossRevenue"
		Me.lblGrossRevenue.Size = New System.Drawing.Size(89, 28)
		Me.lblGrossRevenue.TabIndex = 5
		Me.lblGrossRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(23, 108)
		Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(136, 32)
		Me.Label10.TabIndex = 4
		Me.Label10.Text = "Total Gross Revenue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Ticket Sales:"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'lblGrossChildSales
		'
		Me.lblGrossChildSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblGrossChildSales.Location = New System.Drawing.Point(172, 63)
		Me.lblGrossChildSales.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblGrossChildSales.Name = "lblGrossChildSales"
		Me.lblGrossChildSales.Size = New System.Drawing.Size(89, 28)
		Me.lblGrossChildSales.TabIndex = 3
		Me.lblGrossChildSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(40, 69)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(119, 16)
		Me.Label8.TabIndex = 2
		Me.Label8.Text = "Child Ticket Sales:"
		'
		'lblGrossAdultSales
		'
		Me.lblGrossAdultSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblGrossAdultSales.Location = New System.Drawing.Point(172, 20)
		Me.lblGrossAdultSales.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblGrossAdultSales.Name = "lblGrossAdultSales"
		Me.lblGrossAdultSales.Size = New System.Drawing.Size(89, 28)
		Me.lblGrossAdultSales.TabIndex = 1
		Me.lblGrossAdultSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(39, 26)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(119, 16)
		Me.Label5.TabIndex = 0
		Me.Label5.Text = "Adult Ticket Sales:"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.txtChildSold)
		Me.GroupBox2.Controls.Add(Me.Label15)
		Me.GroupBox2.Controls.Add(Me.txtChildPrice)
		Me.GroupBox2.Controls.Add(Me.Label16)
		Me.GroupBox2.Location = New System.Drawing.Point(321, 10)
		Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox2.Size = New System.Drawing.Size(295, 123)
		Me.GroupBox2.TabIndex = 1
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Child Ticket Sales"
		'
		'txtChildSold
		'
		Me.txtChildSold.Location = New System.Drawing.Point(175, 65)
		Me.txtChildSold.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtChildSold.Name = "txtChildSold"
		Me.txtChildSold.Size = New System.Drawing.Size(88, 22)
		Me.txtChildSold.TabIndex = 3
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Location = New System.Drawing.Point(77, 70)
		Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(86, 16)
		Me.Label15.TabIndex = 2
		Me.Label15.Text = "Tickets Sold:"
		'
		'txtChildPrice
		'
		Me.txtChildPrice.Location = New System.Drawing.Point(175, 33)
		Me.txtChildPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtChildPrice.Name = "txtChildPrice"
		Me.txtChildPrice.Size = New System.Drawing.Size(88, 22)
		Me.txtChildPrice.TabIndex = 1
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Location = New System.Drawing.Point(56, 38)
		Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(105, 16)
		Me.Label16.TabIndex = 0
		Me.Label16.Text = "Price per Ticket:"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.txtAdultSold)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.txtAdultPrice)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(16, 10)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox1.Size = New System.Drawing.Size(287, 123)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Adult Ticket Sales"
		'
		'txtAdultSold
		'
		Me.txtAdultSold.Location = New System.Drawing.Point(172, 65)
		Me.txtAdultSold.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtAdultSold.Name = "txtAdultSold"
		Me.txtAdultSold.Size = New System.Drawing.Size(89, 22)
		Me.txtAdultSold.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(75, 70)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(86, 16)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Tickets Sold:"
		'
		'txtAdultPrice
		'
		Me.txtAdultPrice.Location = New System.Drawing.Point(172, 33)
		Me.txtAdultPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtAdultPrice.Name = "txtAdultPrice"
		Me.txtAdultPrice.Size = New System.Drawing.Size(89, 22)
		Me.txtAdultPrice.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(53, 38)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(105, 16)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Price per Ticket:"
		'
		'lblStatus
		'
		Me.lblStatus.AutoSize = True
		Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStatus.ForeColor = System.Drawing.Color.Red
		Me.lblStatus.Location = New System.Drawing.Point(59, 310)
		Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(0, 15)
		Me.lblStatus.TabIndex = 7
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(632, 383)
		Me.Controls.Add(Me.lblStatus)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnCalculate)
		Me.Controls.Add(Me.GroupBox4)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Name = "Form1"
		Me.Text = "Theater Revenue"
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox4.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnExit As System.Windows.Forms.Button
	Friend WithEvents btnClear As System.Windows.Forms.Button
	Friend WithEvents btnCalculate As System.Windows.Forms.Button
	Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
	Friend WithEvents lblNetRevenue As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents lblNetChildSales As System.Windows.Forms.Label
	Friend WithEvents Label12 As System.Windows.Forms.Label
	Friend WithEvents lblNetAdultSales As System.Windows.Forms.Label
	Friend WithEvents Label14 As System.Windows.Forms.Label
	Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
	Friend WithEvents lblGrossRevenue As System.Windows.Forms.Label
	Friend WithEvents Label10 As System.Windows.Forms.Label
	Friend WithEvents lblGrossChildSales As System.Windows.Forms.Label
	Friend WithEvents Label8 As System.Windows.Forms.Label
	Friend WithEvents lblGrossAdultSales As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents txtChildSold As System.Windows.Forms.TextBox
	Friend WithEvents Label15 As System.Windows.Forms.Label
	Friend WithEvents txtChildPrice As System.Windows.Forms.TextBox
	Friend WithEvents Label16 As System.Windows.Forms.Label
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents txtAdultSold As System.Windows.Forms.TextBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents txtAdultPrice As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents lblStatus As System.Windows.Forms.Label

End Class
