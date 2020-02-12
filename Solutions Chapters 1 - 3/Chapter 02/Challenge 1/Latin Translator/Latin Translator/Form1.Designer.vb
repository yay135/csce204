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
        Me.lblEnglishTranslation = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDexter = New System.Windows.Forms.Button()
        Me.btnMedium = New System.Windows.Forms.Button()
        Me.btnSinister = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnglishTranslation
        '
        Me.lblEnglishTranslation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnglishTranslation.Location = New System.Drawing.Point(15, 15)
        Me.lblEnglishTranslation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEnglishTranslation.Name = "lblEnglishTranslation"
        Me.lblEnglishTranslation.Size = New System.Drawing.Size(324, 47)
        Me.lblEnglishTranslation.TabIndex = 9
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(123, 134)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDexter
        '
        Me.btnDexter.Location = New System.Drawing.Point(231, 98)
        Me.btnDexter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDexter.Name = "btnDexter"
        Me.btnDexter.Size = New System.Drawing.Size(100, 28)
        Me.btnDexter.TabIndex = 7
        Me.btnDexter.Text = "Dexter"
        Me.btnDexter.UseVisualStyleBackColor = True
        '
        'btnMedium
        '
        Me.btnMedium.Location = New System.Drawing.Point(123, 98)
        Me.btnMedium.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMedium.Name = "btnMedium"
        Me.btnMedium.Size = New System.Drawing.Size(100, 28)
        Me.btnMedium.TabIndex = 6
        Me.btnMedium.Text = "Medium"
        Me.btnMedium.UseVisualStyleBackColor = True
        '
        'btnSinister
        '
        Me.btnSinister.Location = New System.Drawing.Point(15, 98)
        Me.btnSinister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSinister.Name = "btnSinister"
        Me.btnSinister.Size = New System.Drawing.Size(100, 28)
        Me.btnSinister.TabIndex = 5
        Me.btnSinister.Text = "Sinister"
        Me.btnSinister.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 177)
        Me.Controls.Add(Me.lblEnglishTranslation)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDexter)
        Me.Controls.Add(Me.btnMedium)
        Me.Controls.Add(Me.btnSinister)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Latin Translator"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblEnglishTranslation As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDexter As System.Windows.Forms.Button
    Friend WithEvents btnMedium As System.Windows.Forms.Button
    Friend WithEvents btnSinister As System.Windows.Forms.Button

End Class
