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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.picScissors = New System.Windows.Forms.PictureBox()
        Me.picPaper = New System.Windows.Forms.PictureBox()
        Me.picRock = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblComputer = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.picScissors)
        Me.GroupBox1.Controls.Add(Me.picPaper)
        Me.GroupBox1.Controls.Add(Me.picRock)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(347, 138)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Make Your Selection"
        '
        'picScissors
        '
        Me.picScissors.Image = CType(resources.GetObject("picScissors.Image"), System.Drawing.Image)
        Me.picScissors.Location = New System.Drawing.Point(237, 37)
        Me.picScissors.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picScissors.Name = "picScissors"
        Me.picScissors.Size = New System.Drawing.Size(85, 79)
        Me.picScissors.TabIndex = 2
        Me.picScissors.TabStop = False
        '
        'picPaper
        '
        Me.picPaper.Image = CType(resources.GetObject("picPaper.Image"), System.Drawing.Image)
        Me.picPaper.Location = New System.Drawing.Point(131, 37)
        Me.picPaper.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picPaper.Name = "picPaper"
        Me.picPaper.Size = New System.Drawing.Size(85, 79)
        Me.picPaper.TabIndex = 1
        Me.picPaper.TabStop = False
        '
        'picRock
        '
        Me.picRock.Image = CType(resources.GetObject("picRock.Image"), System.Drawing.Image)
        Me.picRock.Location = New System.Drawing.Point(25, 37)
        Me.picRock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picRock.Name = "picRock"
        Me.picRock.Size = New System.Drawing.Size(85, 79)
        Me.picRock.TabIndex = 0
        Me.picRock.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblUser)
        Me.GroupBox2.Controls.Add(Me.lblComputer)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 160)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(347, 123)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUser.Location = New System.Drawing.Point(178, 74)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(133, 28)
        Me.lblUser.TabIndex = 3
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblComputer
        '
        Me.lblComputer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComputer.Location = New System.Drawing.Point(178, 30)
        Me.lblComputer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComputer.Name = "lblComputer"
        Me.lblComputer.Size = New System.Drawing.Size(133, 28)
        Me.lblComputer.TabIndex = 2
        Me.lblComputer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Your Selection:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Computer's Selection:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(136, 298)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 49)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 362)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Rock, Paper, Scissors Game"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.picScissors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents picScissors As System.Windows.Forms.PictureBox
    Friend WithEvents picPaper As System.Windows.Forms.PictureBox
    Friend WithEvents picRock As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblComputer As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
