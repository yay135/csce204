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
        Me.components = New System.ComponentModel.Container()
        Me.cboStartingNumber = New System.Windows.Forms.ComboBox()
        Me.lstOutputData = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboNumberDays = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAverageDailyIncrease = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDisplayTable = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboStartingNumber
        '
        Me.cboStartingNumber.FormattingEnabled = True
        Me.cboStartingNumber.Items.AddRange(New Object() {"2", "4", "6", "8", "10"})
        Me.cboStartingNumber.Location = New System.Drawing.Point(73, 47)
        Me.cboStartingNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboStartingNumber.Name = "cboStartingNumber"
        Me.cboStartingNumber.Size = New System.Drawing.Size(68, 24)
        Me.cboStartingNumber.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.cboStartingNumber, "Enter the starting number of organisms.")
        '
        'lstOutputData
        '
        Me.lstOutputData.FormattingEnabled = True
        Me.lstOutputData.HorizontalScrollbar = True
        Me.lstOutputData.ItemHeight = 16
        Me.lstOutputData.Location = New System.Drawing.Point(8, 23)
        Me.lstOutputData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstOutputData.Name = "lstOutputData"
        Me.lstOutputData.Size = New System.Drawing.Size(363, 308)
        Me.lstOutputData.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.lstOutputData, "Population data is displayed in this table.")
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(153, 393)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 41)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clears all data from the form.")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lstOutputData)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 17)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(613, 348)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Organism Population Data"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboNumberDays)
        Me.GroupBox3.Location = New System.Drawing.Point(380, 229)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(217, 103)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Number of Days to Multiply"
        '
        'cboNumberDays
        '
        Me.cboNumberDays.FormattingEnabled = True
        Me.cboNumberDays.Items.AddRange(New Object() {"10", "20", "40", "60", "80", "100"})
        Me.cboNumberDays.Location = New System.Drawing.Point(73, 46)
        Me.cboNumberDays.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboNumberDays.Name = "cboNumberDays"
        Me.cboNumberDays.Size = New System.Drawing.Size(67, 24)
        Me.cboNumberDays.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cboNumberDays, "Enter the number of days that the organisms will multiply.")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboStartingNumber)
        Me.GroupBox1.Location = New System.Drawing.Point(380, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(217, 97)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Starting Number of Organisms"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtAverageDailyIncrease)
        Me.GroupBox2.Location = New System.Drawing.Point(380, 128)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(217, 94)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Average Daily Increase"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(151, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "%"
        '
        'txtAverageDailyIncrease
        '
        Me.txtAverageDailyIncrease.Location = New System.Drawing.Point(73, 47)
        Me.txtAverageDailyIncrease.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAverageDailyIncrease.Name = "txtAverageDailyIncrease"
        Me.txtAverageDailyIncrease.Size = New System.Drawing.Size(68, 23)
        Me.txtAverageDailyIncrease.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtAverageDailyIncrease, "Enter the average daily increase percentage.")
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(265, 393)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(123, 41)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Closes the application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDisplayTable
        '
        Me.btnDisplayTable.Location = New System.Drawing.Point(24, 393)
        Me.btnDisplayTable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDisplayTable.Name = "btnDisplayTable"
        Me.btnDisplayTable.Size = New System.Drawing.Size(121, 41)
        Me.btnDisplayTable.TabIndex = 5
        Me.btnDisplayTable.Text = "Display Table"
        Me.ToolTip1.SetToolTip(Me.btnDisplayTable, "Displays information in the table.")
        Me.btnDisplayTable.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 448)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayTable)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Population Calculator"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboStartingNumber As System.Windows.Forms.ComboBox
    Friend WithEvents lstOutputData As System.Windows.Forms.ListBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboNumberDays As System.Windows.Forms.ComboBox
    Friend WithEvents btnDisplayTable As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAverageDailyIncrease As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
