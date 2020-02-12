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
        Me.gbxCharges = New System.Windows.Forms.GroupBox()
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblBalanceDue = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblAdditionalPanelCost = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.chkExpress = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNumPanels = New System.Windows.Forms.TextBox()
        Me.pnlChargesBorder = New System.Windows.Forms.Panel()
        Me.gbxCharges.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxCharges
        '
        Me.gbxCharges.BackColor = System.Drawing.SystemColors.Control
        Me.gbxCharges.Controls.Add(Me.lblDeposit)
        Me.gbxCharges.Controls.Add(Me.Label4)
        Me.gbxCharges.Controls.Add(Me.lblBalanceDue)
        Me.gbxCharges.Controls.Add(Me.btnClose)
        Me.gbxCharges.Controls.Add(Me.Label11)
        Me.gbxCharges.Controls.Add(Me.btnClear)
        Me.gbxCharges.Controls.Add(Me.Label8)
        Me.gbxCharges.Controls.Add(Me.lblTotalCost)
        Me.gbxCharges.Controls.Add(Me.lblAdditionalPanelCost)
        Me.gbxCharges.Controls.Add(Me.Label3)
        Me.gbxCharges.Controls.Add(Me.Label2)
        Me.gbxCharges.Controls.Add(Me.Label1)
        Me.gbxCharges.Location = New System.Drawing.Point(28, 345)
        Me.gbxCharges.Name = "gbxCharges"
        Me.gbxCharges.Size = New System.Drawing.Size(565, 261)
        Me.gbxCharges.TabIndex = 1
        Me.gbxCharges.TabStop = False
        Me.gbxCharges.Text = "Charges"
        Me.gbxCharges.Visible = False
        '
        'lblDeposit
        '
        Me.lblDeposit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDeposit.Location = New System.Drawing.Point(214, 165)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(79, 29)
        Me.lblDeposit.TabIndex = 12
        Me.lblDeposit.Text = "0.00"
        Me.lblDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Total cost:"
        '
        'lblBalanceDue
        '
        Me.lblBalanceDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBalanceDue.Location = New System.Drawing.Point(213, 207)
        Me.lblBalanceDue.Name = "lblBalanceDue"
        Me.lblBalanceDue.Size = New System.Drawing.Size(79, 29)
        Me.lblBalanceDue.TabIndex = 10
        Me.lblBalanceDue.Text = "0.00"
        Me.lblBalanceDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(344, 152)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(175, 60)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(102, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Balance due:"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(344, 47)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(175, 60)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(77, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Deposit amount:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalCost.Location = New System.Drawing.Point(213, 121)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(79, 29)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.Text = "0.00"
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAdditionalPanelCost
        '
        Me.lblAdditionalPanelCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdditionalPanelCost.Location = New System.Drawing.Point(213, 78)
        Me.lblAdditionalPanelCost.Name = "lblAdditionalPanelCost"
        Me.lblAdditionalPanelCost.Size = New System.Drawing.Size(79, 29)
        Me.lblAdditionalPanelCost.TabIndex = 4
        Me.lblAdditionalPanelCost.Text = "0.00"
        Me.lblAdditionalPanelCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(213, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "2,000.00"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Additional panels:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Base charge for 2 panels:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.txtPhone)
        Me.GroupBox2.Controls.Add(Me.txtLastName)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtFirstName)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(565, 133)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Information"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(344, 75)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(202, 26)
        Me.txtPhone.TabIndex = 6
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(123, 72)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(204, 26)
        Me.txtLastName.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Last Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(123, 36)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(204, 26)
        Me.txtFirstName.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(340, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Phone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "First Name:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(401, 214)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(192, 66)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate Charges"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtDeposit)
        Me.GroupBox3.Controls.Add(Me.chkExpress)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtNumPanels)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 177)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(332, 153)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Installation Options"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Deposit amount:"
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(203, 65)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(79, 26)
        Me.txtDeposit.TabIndex = 8
        '
        'chkExpress
        '
        Me.chkExpress.AutoSize = True
        Me.chkExpress.Location = New System.Drawing.Point(55, 112)
        Me.chkExpress.Name = "chkExpress"
        Me.chkExpress.Size = New System.Drawing.Size(218, 24)
        Me.chkExpress.TabIndex = 6
        Me.chkExpress.Text = "Express installation (5%)"
        Me.chkExpress.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(51, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 20)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Number of panels:"
        '
        'txtNumPanels
        '
        Me.txtNumPanels.Location = New System.Drawing.Point(203, 30)
        Me.txtNumPanels.Name = "txtNumPanels"
        Me.txtNumPanels.Size = New System.Drawing.Size(70, 26)
        Me.txtNumPanels.TabIndex = 3
        Me.txtNumPanels.Text = "2"
        '
        'pnlChargesBorder
        '
        Me.pnlChargesBorder.BackColor = System.Drawing.SystemColors.ControlText
        Me.pnlChargesBorder.Location = New System.Drawing.Point(28, 608)
        Me.pnlChargesBorder.Name = "pnlChargesBorder"
        Me.pnlChargesBorder.Size = New System.Drawing.Size(565, 5)
        Me.pnlChargesBorder.TabIndex = 8
        Me.pnlChargesBorder.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(623, 633)
        Me.Controls.Add(Me.pnlChargesBorder)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbxCharges)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Megawatt Solar Panels, Inc."
        Me.gbxCharges.ResumeLayout(False)
        Me.gbxCharges.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxCharges As System.Windows.Forms.GroupBox
    Friend WithEvents lblAdditionalPanelCost As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblBalanceDue As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkExpress As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNumPanels As System.Windows.Forms.TextBox
    Friend WithEvents pnlChargesBorder As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDeposit As System.Windows.Forms.TextBox
    Friend WithEvents lblDeposit As System.Windows.Forms.Label

End Class
