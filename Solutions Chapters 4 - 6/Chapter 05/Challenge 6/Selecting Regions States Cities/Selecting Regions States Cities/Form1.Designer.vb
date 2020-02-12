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
        Me.cboRegion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboCity = New System.Windows.Forms.ComboBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboRegion
        '
        Me.cboRegion.FormattingEnabled = True
        Me.cboRegion.Items.AddRange(New Object() {"NorthEast", "SouthEast", "NorthWest"})
        Me.cboRegion.Location = New System.Drawing.Point(29, 65)
        Me.cboRegion.Name = "cboRegion"
        Me.cboRegion.Size = New System.Drawing.Size(176, 24)
        Me.cboRegion.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(25, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select a Region"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblCity)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cboCity)
        Me.Panel1.Controls.Add(Me.lblState)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cboState)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblRegion)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboRegion)
        Me.Panel1.Location = New System.Drawing.Point(33, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 280)
        Me.Panel1.TabIndex = 3
        '
        'lblCity
        '
        Me.lblCity.Location = New System.Drawing.Point(292, 202)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(152, 25)
        Me.lblCity.TabIndex = 10
        Me.lblCity.Text = "(none)"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(25, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Select a City"
        '
        'cboCity
        '
        Me.cboCity.FormattingEnabled = True
        Me.cboCity.Location = New System.Drawing.Point(29, 199)
        Me.cboCity.Name = "cboCity"
        Me.cboCity.Size = New System.Drawing.Size(176, 24)
        Me.cboCity.TabIndex = 8
        '
        'lblState
        '
        Me.lblState.Location = New System.Drawing.Point(292, 132)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(152, 25)
        Me.lblState.TabIndex = 7
        Me.lblState.Text = "(none)"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(25, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Select a State"
        '
        'cboState
        '
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(29, 129)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(176, 24)
        Me.cboState.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.Location = New System.Drawing.Point(245, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 241)
        Me.Panel2.TabIndex = 4
        '
        'lblRegion
        '
        Me.lblRegion.Location = New System.Drawing.Point(292, 68)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(152, 25)
        Me.lblRegion.TabIndex = 3
        Me.lblRegion.Text = "(none)"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(292, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Selections:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 338)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Selecting Regions, States, and Cities"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboRegion As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboCity As System.Windows.Forms.ComboBox
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblRegion As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
