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
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radBaltic = New System.Windows.Forms.RadioButton()
        Me.radMed = New System.Windows.Forms.RadioButton()
        Me.radCarib = New System.Windows.Forms.RadioButton()
        Me.radAlaska = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkBalcony = New System.Windows.Forms.CheckBox()
        Me.chkBroad = New System.Windows.Forms.CheckBox()
        Me.chkArt = New System.Windows.Forms.CheckBox()
        Me.chkWine = New System.Windows.Forms.CheckBox()
        Me.chkInternet = New System.Windows.Forms.CheckBox()
        Me.chkExcur = New System.Windows.Forms.CheckBox()
        Me.chkFreeChoice = New System.Windows.Forms.CheckBox()
        Me.txtDate1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMinDays = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDate2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaxDays = New System.Windows.Forms.TextBox()
        Me.chkDatesFlexible = New System.Windows.Forms.CheckBox()
        Me.btnShowSummary = New System.Windows.Forms.Button()
        Me.btnCloseWindow = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.radLarge)
        Me.GroupBox1.Controls.Add(Me.radMedium)
        Me.GroupBox1.Controls.Add(Me.radSmall)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 139)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ship Size"
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(34, 97)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(73, 24)
        Me.radLarge.TabIndex = 2
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(34, 67)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(89, 24)
        Me.radMedium.TabIndex = 1
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Location = New System.Drawing.Point(35, 37)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(72, 24)
        Me.radSmall.TabIndex = 0
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.radBaltic)
        Me.GroupBox2.Controls.Add(Me.radMed)
        Me.GroupBox2.Controls.Add(Me.radCarib)
        Me.GroupBox2.Controls.Add(Me.radAlaska)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 261)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(183, 176)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Region"
        '
        'radBaltic
        '
        Me.radBaltic.AutoSize = True
        Me.radBaltic.Location = New System.Drawing.Point(33, 67)
        Me.radBaltic.Name = "radBaltic"
        Me.radBaltic.Size = New System.Drawing.Size(73, 24)
        Me.radBaltic.TabIndex = 3
        Me.radBaltic.TabStop = True
        Me.radBaltic.Text = "Baltic"
        Me.radBaltic.UseVisualStyleBackColor = True
        '
        'radMed
        '
        Me.radMed.AutoSize = True
        Me.radMed.Location = New System.Drawing.Point(32, 127)
        Me.radMed.Name = "radMed"
        Me.radMed.Size = New System.Drawing.Size(137, 24)
        Me.radMed.TabIndex = 2
        Me.radMed.TabStop = True
        Me.radMed.Text = "Mediterranean"
        Me.radMed.UseVisualStyleBackColor = True
        '
        'radCarib
        '
        Me.radCarib.AutoSize = True
        Me.radCarib.Location = New System.Drawing.Point(32, 97)
        Me.radCarib.Name = "radCarib"
        Me.radCarib.Size = New System.Drawing.Size(106, 24)
        Me.radCarib.TabIndex = 1
        Me.radCarib.TabStop = True
        Me.radCarib.Text = "Caribbean"
        Me.radCarib.UseVisualStyleBackColor = True
        '
        'radAlaska
        '
        Me.radAlaska.AutoSize = True
        Me.radAlaska.Location = New System.Drawing.Point(33, 37)
        Me.radAlaska.Name = "radAlaska"
        Me.radAlaska.Size = New System.Drawing.Size(80, 24)
        Me.radAlaska.TabIndex = 0
        Me.radAlaska.TabStop = True
        Me.radAlaska.Text = "Alaska"
        Me.radAlaska.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(28, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(650, 51)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "The Cruise Selector application helps you choose the ideal cruise, based on your " & _
    "personal preferences."
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.chkBalcony)
        Me.GroupBox3.Controls.Add(Me.chkBroad)
        Me.GroupBox3.Controls.Add(Me.chkArt)
        Me.GroupBox3.Controls.Add(Me.chkWine)
        Me.GroupBox3.Controls.Add(Me.chkInternet)
        Me.GroupBox3.Controls.Add(Me.chkExcur)
        Me.GroupBox3.Controls.Add(Me.chkFreeChoice)
        Me.GroupBox3.Location = New System.Drawing.Point(227, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 339)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Amenities"
        '
        'chkBalcony
        '
        Me.chkBalcony.AutoSize = True
        Me.chkBalcony.Location = New System.Drawing.Point(35, 75)
        Me.chkBalcony.Name = "chkBalcony"
        Me.chkBalcony.Size = New System.Drawing.Size(145, 24)
        Me.chkBalcony.TabIndex = 6
        Me.chkBalcony.Text = "Balcony cabins"
        Me.chkBalcony.UseVisualStyleBackColor = True
        '
        'chkBroad
        '
        Me.chkBroad.AutoSize = True
        Me.chkBroad.Location = New System.Drawing.Point(35, 113)
        Me.chkBroad.Name = "chkBroad"
        Me.chkBroad.Size = New System.Drawing.Size(177, 24)
        Me.chkBroad.TabIndex = 5
        Me.chkBroad.Text = "Broadway musicals"
        Me.chkBroad.UseVisualStyleBackColor = True
        '
        'chkArt
        '
        Me.chkArt.AutoSize = True
        Me.chkArt.Location = New System.Drawing.Point(35, 37)
        Me.chkArt.Name = "chkArt"
        Me.chkArt.Size = New System.Drawing.Size(97, 24)
        Me.chkArt.TabIndex = 4
        Me.chkArt.Text = "Art show"
        Me.chkArt.UseVisualStyleBackColor = True
        '
        'chkWine
        '
        Me.chkWine.AutoSize = True
        Me.chkWine.Location = New System.Drawing.Point(35, 267)
        Me.chkWine.Name = "chkWine"
        Me.chkWine.Size = New System.Drawing.Size(124, 24)
        Me.chkWine.TabIndex = 3
        Me.chkWine.Text = "Wine tasting"
        Me.chkWine.UseVisualStyleBackColor = True
        '
        'chkInternet
        '
        Me.chkInternet.AutoSize = True
        Me.chkInternet.Location = New System.Drawing.Point(35, 226)
        Me.chkInternet.Name = "chkInternet"
        Me.chkInternet.Size = New System.Drawing.Size(154, 24)
        Me.chkInternet.TabIndex = 2
        Me.chkInternet.Text = "Internet included"
        Me.chkInternet.UseVisualStyleBackColor = True
        '
        'chkExcur
        '
        Me.chkExcur.AutoSize = True
        Me.chkExcur.Location = New System.Drawing.Point(35, 149)
        Me.chkExcur.Name = "chkExcur"
        Me.chkExcur.Size = New System.Drawing.Size(181, 24)
        Me.chkExcur.TabIndex = 1
        Me.chkExcur.Text = "Excursions included"
        Me.chkExcur.UseVisualStyleBackColor = True
        '
        'chkFreeChoice
        '
        Me.chkFreeChoice.AutoSize = True
        Me.chkFreeChoice.Location = New System.Drawing.Point(35, 187)
        Me.chkFreeChoice.Name = "chkFreeChoice"
        Me.chkFreeChoice.Size = New System.Drawing.Size(168, 24)
        Me.chkFreeChoice.TabIndex = 0
        Me.chkFreeChoice.Text = "Free choice dining"
        Me.chkFreeChoice.UseVisualStyleBackColor = True
        '
        'txtDate1
        '
        Me.txtDate1.Location = New System.Drawing.Point(33, 66)
        Me.txtDate1.Name = "txtDate1"
        Me.txtDate1.Size = New System.Drawing.Size(100, 26)
        Me.txtDate1.TabIndex = 4
        Me.txtDate1.Text = "05/01/2016"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(29, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 43)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Earliest Date (mm/dd/yyyy)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Min/Max Days"
        '
        'txtMinDays
        '
        Me.txtMinDays.Location = New System.Drawing.Point(36, 215)
        Me.txtMinDays.Name = "txtMinDays"
        Me.txtMinDays.Size = New System.Drawing.Size(37, 26)
        Me.txtMinDays.TabIndex = 8
        Me.txtMinDays.Text = "5"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtDate2)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtMaxDays)
        Me.GroupBox4.Controls.Add(Me.chkDatesFlexible)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtMinDays)
        Me.GroupBox4.Controls.Add(Me.txtDate1)
        Me.GroupBox4.Location = New System.Drawing.Point(484, 98)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(194, 339)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 43)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Latest Date (mm/dd/yyyy)"
        '
        'txtDate2
        '
        Me.txtDate2.Location = New System.Drawing.Point(36, 147)
        Me.txtDate2.Name = "txtDate2"
        Me.txtDate2.Size = New System.Drawing.Size(100, 26)
        Me.txtDate2.TabIndex = 13
        Me.txtDate2.Text = "07/31/2016"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "to"
        '
        'txtMaxDays
        '
        Me.txtMaxDays.Location = New System.Drawing.Point(109, 215)
        Me.txtMaxDays.Name = "txtMaxDays"
        Me.txtMaxDays.Size = New System.Drawing.Size(37, 26)
        Me.txtMaxDays.TabIndex = 11
        Me.txtMaxDays.Text = "15"
        '
        'chkDatesFlexible
        '
        Me.chkDatesFlexible.Checked = True
        Me.chkDatesFlexible.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDatesFlexible.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDatesFlexible.Location = New System.Drawing.Point(33, 260)
        Me.chkDatesFlexible.Name = "chkDatesFlexible"
        Me.chkDatesFlexible.Size = New System.Drawing.Size(152, 52)
        Me.chkDatesFlexible.TabIndex = 10
        Me.chkDatesFlexible.Text = "My dates are flexible"
        Me.chkDatesFlexible.UseVisualStyleBackColor = True
        '
        'btnShowSummary
        '
        Me.btnShowSummary.Location = New System.Drawing.Point(174, 456)
        Me.btnShowSummary.Name = "btnShowSummary"
        Me.btnShowSummary.Size = New System.Drawing.Size(170, 49)
        Me.btnShowSummary.TabIndex = 8
        Me.btnShowSummary.Text = "Show Summary"
        Me.btnShowSummary.UseVisualStyleBackColor = True
        '
        'btnCloseWindow
        '
        Me.btnCloseWindow.Location = New System.Drawing.Point(379, 456)
        Me.btnCloseWindow.Name = "btnCloseWindow"
        Me.btnCloseWindow.Size = New System.Drawing.Size(163, 49)
        Me.btnCloseWindow.TabIndex = 9
        Me.btnCloseWindow.Text = "Close Window"
        Me.btnCloseWindow.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 523)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(720, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(720, 545)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnCloseWindow)
        Me.Controls.Add(Me.btnShowSummary)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Cruise Selector 1.0"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radLarge As System.Windows.Forms.RadioButton
    Friend WithEvents radMedium As System.Windows.Forms.RadioButton
    Friend WithEvents radSmall As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radBaltic As System.Windows.Forms.RadioButton
    Friend WithEvents radMed As System.Windows.Forms.RadioButton
    Friend WithEvents radCarib As System.Windows.Forms.RadioButton
    Friend WithEvents radAlaska As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkBroad As System.Windows.Forms.CheckBox
    Friend WithEvents chkArt As System.Windows.Forms.CheckBox
    Friend WithEvents chkWine As System.Windows.Forms.CheckBox
    Friend WithEvents chkInternet As System.Windows.Forms.CheckBox
    Friend WithEvents chkExcur As System.Windows.Forms.CheckBox
    Friend WithEvents chkFreeChoice As System.Windows.Forms.CheckBox
    Friend WithEvents txtDate1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMinDays As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnShowSummary As System.Windows.Forms.Button
    Friend WithEvents chkBalcony As System.Windows.Forms.CheckBox
    Friend WithEvents chkDatesFlexible As System.Windows.Forms.CheckBox
    Friend WithEvents btnCloseWindow As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMaxDays As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDate2 As System.Windows.Forms.TextBox

End Class
