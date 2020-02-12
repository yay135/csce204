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
        Me.chkLatin = New System.Windows.Forms.CheckBox()
        Me.chkSacre = New System.Windows.Forms.CheckBox()
        Me.chkChamps = New System.Windows.Forms.CheckBox()
        Me.chkLesHalles = New System.Windows.Forms.CheckBox()
        Me.chkBastille = New System.Windows.Forms.CheckBox()
        Me.chkMarais = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkTwoBed = New System.Windows.Forms.CheckBox()
        Me.chkOneBed = New System.Windows.Forms.CheckBox()
        Me.chkStudio = New System.Windows.Forms.CheckBox()
        Me.chkLargeHotel = New System.Windows.Forms.CheckBox()
        Me.chkBoutique = New System.Windows.Forms.CheckBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblSelections = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.chkLatin)
        Me.GroupBox1.Controls.Add(Me.chkSacre)
        Me.GroupBox1.Controls.Add(Me.chkChamps)
        Me.GroupBox1.Controls.Add(Me.chkLesHalles)
        Me.GroupBox1.Controls.Add(Me.chkBastille)
        Me.GroupBox1.Controls.Add(Me.chkMarais)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 125)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Neighborhoods"
        '
        'chkLatin
        '
        Me.chkLatin.AutoSize = True
        Me.chkLatin.Location = New System.Drawing.Point(168, 81)
        Me.chkLatin.Name = "chkLatin"
        Me.chkLatin.Size = New System.Drawing.Size(114, 21)
        Me.chkLatin.TabIndex = 5
        Me.chkLatin.Text = "Latin Quartier"
        Me.chkLatin.UseVisualStyleBackColor = True
        '
        'chkSacre
        '
        Me.chkSacre.AutoSize = True
        Me.chkSacre.Location = New System.Drawing.Point(168, 54)
        Me.chkSacre.Name = "chkSacre"
        Me.chkSacre.Size = New System.Drawing.Size(107, 21)
        Me.chkSacre.TabIndex = 4
        Me.chkSacre.Text = "Sacre-Coeur"
        Me.chkSacre.UseVisualStyleBackColor = True
        '
        'chkChamps
        '
        Me.chkChamps.AutoSize = True
        Me.chkChamps.Location = New System.Drawing.Point(168, 27)
        Me.chkChamps.Name = "chkChamps"
        Me.chkChamps.Size = New System.Drawing.Size(132, 21)
        Me.chkChamps.TabIndex = 3
        Me.chkChamps.Text = "Champs-Elysees"
        Me.chkChamps.UseVisualStyleBackColor = True
        '
        'chkLesHalles
        '
        Me.chkLesHalles.AutoSize = True
        Me.chkLesHalles.Location = New System.Drawing.Point(24, 81)
        Me.chkLesHalles.Name = "chkLesHalles"
        Me.chkLesHalles.Size = New System.Drawing.Size(93, 21)
        Me.chkLesHalles.TabIndex = 2
        Me.chkLesHalles.Text = "Les Halles"
        Me.chkLesHalles.UseVisualStyleBackColor = True
        '
        'chkBastille
        '
        Me.chkBastille.AutoSize = True
        Me.chkBastille.Location = New System.Drawing.Point(24, 54)
        Me.chkBastille.Name = "chkBastille"
        Me.chkBastille.Size = New System.Drawing.Size(72, 21)
        Me.chkBastille.TabIndex = 1
        Me.chkBastille.Text = "Bastille"
        Me.chkBastille.UseVisualStyleBackColor = True
        '
        'chkMarais
        '
        Me.chkMarais.AutoSize = True
        Me.chkMarais.Location = New System.Drawing.Point(24, 27)
        Me.chkMarais.Name = "chkMarais"
        Me.chkMarais.Size = New System.Drawing.Size(69, 21)
        Me.chkMarais.TabIndex = 0
        Me.chkMarais.Text = "Marais"
        Me.chkMarais.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.chkTwoBed)
        Me.GroupBox2.Controls.Add(Me.chkOneBed)
        Me.GroupBox2.Controls.Add(Me.chkStudio)
        Me.GroupBox2.Controls.Add(Me.chkLargeHotel)
        Me.GroupBox2.Controls.Add(Me.chkBoutique)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 149)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 125)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Types of Rentals"
        '
        'chkTwoBed
        '
        Me.chkTwoBed.AutoSize = True
        Me.chkTwoBed.Location = New System.Drawing.Point(167, 71)
        Me.chkTwoBed.Name = "chkTwoBed"
        Me.chkTwoBed.Size = New System.Drawing.Size(152, 21)
        Me.chkTwoBed.TabIndex = 7
        Me.chkTwoBed.Text = "Two-Bed Apartment"
        Me.chkTwoBed.UseVisualStyleBackColor = True
        '
        'chkOneBed
        '
        Me.chkOneBed.AutoSize = True
        Me.chkOneBed.Location = New System.Drawing.Point(167, 33)
        Me.chkOneBed.Name = "chkOneBed"
        Me.chkOneBed.Size = New System.Drawing.Size(153, 21)
        Me.chkOneBed.TabIndex = 6
        Me.chkOneBed.Text = "One-Bed Apartment"
        Me.chkOneBed.UseVisualStyleBackColor = True
        '
        'chkStudio
        '
        Me.chkStudio.AutoSize = True
        Me.chkStudio.Location = New System.Drawing.Point(24, 87)
        Me.chkStudio.Name = "chkStudio"
        Me.chkStudio.Size = New System.Drawing.Size(67, 21)
        Me.chkStudio.TabIndex = 5
        Me.chkStudio.Text = "Studio"
        Me.chkStudio.UseVisualStyleBackColor = True
        '
        'chkLargeHotel
        '
        Me.chkLargeHotel.AutoSize = True
        Me.chkLargeHotel.Location = New System.Drawing.Point(24, 60)
        Me.chkLargeHotel.Name = "chkLargeHotel"
        Me.chkLargeHotel.Size = New System.Drawing.Size(101, 21)
        Me.chkLargeHotel.TabIndex = 4
        Me.chkLargeHotel.Text = "Large Hotel"
        Me.chkLargeHotel.UseVisualStyleBackColor = True
        '
        'chkBoutique
        '
        Me.chkBoutique.AutoSize = True
        Me.chkBoutique.Location = New System.Drawing.Point(24, 33)
        Me.chkBoutique.Name = "chkBoutique"
        Me.chkBoutique.Size = New System.Drawing.Size(120, 21)
        Me.chkBoutique.TabIndex = 3
        Me.chkBoutique.Text = "Boutique Hotel"
        Me.chkBoutique.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(386, 149)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(88, 66)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Show Selections"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(386, 249)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 25)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblSelections
        '
        Me.lblSelections.BackColor = System.Drawing.SystemColors.Control
        Me.lblSelections.Location = New System.Drawing.Point(8, 292)
        Me.lblSelections.Name = "lblSelections"
        Me.lblSelections.Size = New System.Drawing.Size(480, 83)
        Me.lblSelections.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(500, 388)
        Me.Controls.Add(Me.lblSelections)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Searching for Vacation Rentals in Paris"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkLatin As CheckBox
    Friend WithEvents chkSacre As CheckBox
    Friend WithEvents chkChamps As CheckBox
    Friend WithEvents chkLesHalles As CheckBox
    Friend WithEvents chkBastille As CheckBox
    Friend WithEvents chkMarais As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkTwoBed As CheckBox
    Friend WithEvents chkOneBed As CheckBox
    Friend WithEvents chkStudio As CheckBox
    Friend WithEvents chkLargeHotel As CheckBox
    Friend WithEvents chkBoutique As CheckBox
    Friend WithEvents btnShow As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblSelections As Label
End Class
