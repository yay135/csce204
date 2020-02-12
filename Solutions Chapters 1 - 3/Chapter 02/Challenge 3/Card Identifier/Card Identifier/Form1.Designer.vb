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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picEight = New System.Windows.Forms.PictureBox()
        Me.picTwo = New System.Windows.Forms.PictureBox()
        Me.picKing = New System.Windows.Forms.PictureBox()
        Me.picAce = New System.Windows.Forms.PictureBox()
        Me.picJoker = New System.Windows.Forms.PictureBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picEight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJoker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click a Card to See Its Name"
        '
        'picEight
        '
        Me.picEight.Image = CType(resources.GetObject("picEight.Image"), System.Drawing.Image)
        Me.picEight.Location = New System.Drawing.Point(27, 100)
        Me.picEight.Name = "picEight"
        Me.picEight.Size = New System.Drawing.Size(87, 126)
        Me.picEight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEight.TabIndex = 1
        Me.picEight.TabStop = False
        '
        'picTwo
        '
        Me.picTwo.ErrorImage = Nothing
        Me.picTwo.Image = CType(resources.GetObject("picTwo.Image"), System.Drawing.Image)
        Me.picTwo.Location = New System.Drawing.Point(136, 100)
        Me.picTwo.Name = "picTwo"
        Me.picTwo.Size = New System.Drawing.Size(87, 126)
        Me.picTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTwo.TabIndex = 2
        Me.picTwo.TabStop = False
        '
        'picKing
        '
        Me.picKing.Image = CType(resources.GetObject("picKing.Image"), System.Drawing.Image)
        Me.picKing.Location = New System.Drawing.Point(241, 100)
        Me.picKing.Name = "picKing"
        Me.picKing.Size = New System.Drawing.Size(87, 126)
        Me.picKing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picKing.TabIndex = 3
        Me.picKing.TabStop = False
        '
        'picAce
        '
        Me.picAce.Image = CType(resources.GetObject("picAce.Image"), System.Drawing.Image)
        Me.picAce.Location = New System.Drawing.Point(345, 100)
        Me.picAce.Name = "picAce"
        Me.picAce.Size = New System.Drawing.Size(87, 126)
        Me.picAce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAce.TabIndex = 4
        Me.picAce.TabStop = False
        '
        'picJoker
        '
        Me.picJoker.Image = CType(resources.GetObject("picJoker.Image"), System.Drawing.Image)
        Me.picJoker.Location = New System.Drawing.Point(453, 100)
        Me.picJoker.Name = "picJoker"
        Me.picJoker.Size = New System.Drawing.Size(87, 126)
        Me.picJoker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picJoker.TabIndex = 5
        Me.picJoker.TabStop = False
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(49, 252)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(471, 51)
        Me.lblResult.TabIndex = 6
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(215, 319)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 36)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 378)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.picJoker)
        Me.Controls.Add(Me.picAce)
        Me.Controls.Add(Me.picKing)
        Me.Controls.Add(Me.picTwo)
        Me.Controls.Add(Me.picEight)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picEight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJoker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents picEight As PictureBox
    Friend WithEvents picTwo As PictureBox
    Friend WithEvents picKing As PictureBox
    Friend WithEvents picAce As PictureBox
    Friend WithEvents picJoker As PictureBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnExit As Button
End Class
