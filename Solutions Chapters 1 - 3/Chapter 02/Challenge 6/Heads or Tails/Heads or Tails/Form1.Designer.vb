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
        Me.picHeads = New System.Windows.Forms.PictureBox()
        Me.picTails = New System.Windows.Forms.PictureBox()
        Me.btnHeads = New System.Windows.Forms.Button()
        Me.btnTails = New System.Windows.Forms.Button()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picHeads
        '
        Me.picHeads.Image = CType(resources.GetObject("picHeads.Image"), System.Drawing.Image)
        Me.picHeads.Location = New System.Drawing.Point(53, 44)
        Me.picHeads.Name = "picHeads"
        Me.picHeads.Size = New System.Drawing.Size(191, 186)
        Me.picHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHeads.TabIndex = 0
        Me.picHeads.TabStop = False
        Me.picHeads.Visible = False
        '
        'picTails
        '
        Me.picTails.Image = CType(resources.GetObject("picTails.Image"), System.Drawing.Image)
        Me.picTails.Location = New System.Drawing.Point(282, 44)
        Me.picTails.Name = "picTails"
        Me.picTails.Size = New System.Drawing.Size(191, 186)
        Me.picTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTails.TabIndex = 1
        Me.picTails.TabStop = False
        Me.picTails.Visible = False
        '
        'btnHeads
        '
        Me.btnHeads.Location = New System.Drawing.Point(53, 273)
        Me.btnHeads.Name = "btnHeads"
        Me.btnHeads.Size = New System.Drawing.Size(191, 47)
        Me.btnHeads.TabIndex = 2
        Me.btnHeads.Text = "Show Heads"
        Me.btnHeads.UseVisualStyleBackColor = True
        '
        'btnTails
        '
        Me.btnTails.Location = New System.Drawing.Point(282, 273)
        Me.btnTails.Name = "btnTails"
        Me.btnTails.Size = New System.Drawing.Size(191, 47)
        Me.btnTails.TabIndex = 3
        Me.btnTails.Text = "Show Tails"
        Me.btnTails.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 348)
        Me.Controls.Add(Me.btnTails)
        Me.Controls.Add(Me.btnHeads)
        Me.Controls.Add(Me.picTails)
        Me.Controls.Add(Me.picHeads)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Heads or Tails"
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picHeads As PictureBox
    Friend WithEvents picTails As PictureBox
    Friend WithEvents btnHeads As Button
    Friend WithEvents btnTails As Button
End Class
