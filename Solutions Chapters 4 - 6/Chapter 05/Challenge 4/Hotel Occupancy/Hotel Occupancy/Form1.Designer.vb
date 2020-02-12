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
        Me.lstFloorOccupancyData = New System.Windows.Forms.ListBox()
        Me.lblTotalRoomsOccupied = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblOverallOccupancyRate = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtOccupied = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboFloor = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.lstFloorOccupancyData)
        Me.GroupBox1.Controls.Add(Me.lblTotalRoomsOccupied)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblOverallOccupancyRate)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 185)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(599, 278)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Floor Occupancy Data"
        '
        'lstFloorOccupancyData
        '
        Me.lstFloorOccupancyData.FormattingEnabled = True
        Me.lstFloorOccupancyData.ItemHeight = 16
        Me.lstFloorOccupancyData.Location = New System.Drawing.Point(28, 29)
        Me.lstFloorOccupancyData.Margin = New System.Windows.Forms.Padding(5)
        Me.lstFloorOccupancyData.Name = "lstFloorOccupancyData"
        Me.lstFloorOccupancyData.Size = New System.Drawing.Size(547, 180)
        Me.lstFloorOccupancyData.TabIndex = 0
        '
        'lblTotalRoomsOccupied
        '
        Me.lblTotalRoomsOccupied.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalRoomsOccupied.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalRoomsOccupied.Location = New System.Drawing.Point(214, 225)
        Me.lblTotalRoomsOccupied.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTotalRoomsOccupied.Name = "lblTotalRoomsOccupied"
        Me.lblTotalRoomsOccupied.Size = New System.Drawing.Size(59, 35)
        Me.lblTotalRoomsOccupied.TabIndex = 5
        Me.lblTotalRoomsOccupied.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(24, 232)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Rooms Occupied"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(299, 232)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Overall Occupancy Rate"
        '
        'lblOverallOccupancyRate
        '
        Me.lblOverallOccupancyRate.BackColor = System.Drawing.SystemColors.Control
        Me.lblOverallOccupancyRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOverallOccupancyRate.Location = New System.Drawing.Point(497, 225)
        Me.lblOverallOccupancyRate.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblOverallOccupancyRate.Name = "lblOverallOccupancyRate"
        Me.lblOverallOccupancyRate.Size = New System.Drawing.Size(78, 35)
        Me.lblOverallOccupancyRate.TabIndex = 7
        Me.lblOverallOccupancyRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(195, 481)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 44)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Restart"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(340, 481)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 44)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(26, 463)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 5)
        Me.Panel1.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.txtOccupied)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cboFloor)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(599, 145)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enter the occupancy rate for each floor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Number of rooms = 30"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(380, 97)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 28)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtOccupied
        '
        Me.txtOccupied.Location = New System.Drawing.Point(393, 57)
        Me.txtOccupied.Name = "txtOccupied"
        Me.txtOccupied.Size = New System.Drawing.Size(56, 23)
        Me.txtOccupied.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(254, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 51)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Number of occupied rooms:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Select the floor:"
        '
        'cboFloor
        '
        Me.cboFloor.FormattingEnabled = True
        Me.cboFloor.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cboFloor.Location = New System.Drawing.Point(176, 54)
        Me.cboFloor.Name = "cboFloor"
        Me.cboFloor.Size = New System.Drawing.Size(58, 24)
        Me.cboFloor.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(651, 539)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Hotel Occupancy"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstFloorOccupancyData As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalRoomsOccupied As System.Windows.Forms.Label
    Friend WithEvents lblOverallOccupancyRate As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOccupied As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboFloor As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
