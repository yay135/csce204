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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalculateTotal = New System.Windows.Forms.Button()
        Me.btnAddWorkshop = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstWorkshop = New System.Windows.Forms.ListBox()
        Me.lstCosts = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstLocation = New System.Windows.Forms.ListBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(187, 202)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Total Cost:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(449, 254)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 48)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(312, 254)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(117, 48)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCalculateTotal
        '
        Me.btnCalculateTotal.Location = New System.Drawing.Point(175, 254)
        Me.btnCalculateTotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalculateTotal.Name = "btnCalculateTotal"
        Me.btnCalculateTotal.Size = New System.Drawing.Size(117, 48)
        Me.btnCalculateTotal.TabIndex = 3
        Me.btnCalculateTotal.Text = "&Calculate Total"
        Me.btnCalculateTotal.UseVisualStyleBackColor = True
        '
        'btnAddWorkshop
        '
        Me.btnAddWorkshop.Location = New System.Drawing.Point(36, 254)
        Me.btnAddWorkshop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddWorkshop.Name = "btnAddWorkshop"
        Me.btnAddWorkshop.Size = New System.Drawing.Size(117, 48)
        Me.btnAddWorkshop.TabIndex = 2
        Me.btnAddWorkshop.Text = "&Add Workshop"
        Me.btnAddWorkshop.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstWorkshop)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(181, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pick a Workshop"
        '
        'lstWorkshop
        '
        Me.lstWorkshop.FormattingEnabled = True
        Me.lstWorkshop.ItemHeight = 16
        Me.lstWorkshop.Items.AddRange(New Object() {"Handling Stress", "Time Management", "Supervision Skills", "Negotiation", "How to Interview"})
        Me.lstWorkshop.Location = New System.Drawing.Point(13, 23)
        Me.lstWorkshop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstWorkshop.Name = "lstWorkshop"
        Me.lstWorkshop.Size = New System.Drawing.Size(159, 116)
        Me.lstWorkshop.TabIndex = 0
        '
        'lstCosts
        '
        Me.lstCosts.FormattingEnabled = True
        Me.lstCosts.ItemHeight = 16
        Me.lstCosts.Location = New System.Drawing.Point(13, 23)
        Me.lstCosts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstCosts.Name = "lstCosts"
        Me.lstCosts.Size = New System.Drawing.Size(159, 116)
        Me.lstCosts.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstLocation)
        Me.GroupBox2.Location = New System.Drawing.Point(205, 23)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(181, 149)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pick a Location"
        '
        'lstLocation
        '
        Me.lstLocation.FormattingEnabled = True
        Me.lstLocation.ItemHeight = 16
        Me.lstLocation.Items.AddRange(New Object() {"Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh"})
        Me.lstLocation.Location = New System.Drawing.Point(13, 23)
        Me.lstLocation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstLocation.Name = "lstLocation"
        Me.lstLocation.Size = New System.Drawing.Size(159, 116)
        Me.lstLocation.TabIndex = 0
        '
        'lblTotalCost
        '
        Me.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalCost.Location = New System.Drawing.Point(272, 196)
        Me.lblTotalCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(133, 28)
        Me.lblTotalCost.TabIndex = 8
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lstCosts)
        Me.GroupBox3.Location = New System.Drawing.Point(395, 23)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(181, 149)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "List of Costs"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 325)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculateTotal)
        Me.Controls.Add(Me.btnAddWorkshop)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Workshop Selector"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnCalculateTotal As System.Windows.Forms.Button
    Friend WithEvents btnAddWorkshop As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstWorkshop As System.Windows.Forms.ListBox
    Friend WithEvents lstCosts As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstLocation As System.Windows.Forms.ListBox
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox

End Class
