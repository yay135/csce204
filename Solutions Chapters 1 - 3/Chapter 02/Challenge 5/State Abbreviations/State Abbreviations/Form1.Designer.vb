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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAbbreviation = New System.Windows.Forms.Label()
        Me.btnFlorida = New System.Windows.Forms.Button()
        Me.btnAlabama = New System.Windows.Forms.Button()
        Me.btnGeorgia = New System.Windows.Forms.Button()
        Me.btnSouthCarolina = New System.Windows.Forms.Button()
        Me.btnNorthCarolina = New System.Windows.Forms.Button()
        Me.btnVirginia = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(177, 233)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 28)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAbbreviation
        '
        Me.lblAbbreviation.AutoSize = True
        Me.lblAbbreviation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbbreviation.Location = New System.Drawing.Point(16, 15)
        Me.lblAbbreviation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAbbreviation.Name = "lblAbbreviation"
        Me.lblAbbreviation.Size = New System.Drawing.Size(191, 24)
        Me.lblAbbreviation.TabIndex = 14
        Me.lblAbbreviation.Text = "State Abbreviation: "
        Me.lblAbbreviation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFlorida
        '
        Me.btnFlorida.Location = New System.Drawing.Point(16, 233)
        Me.btnFlorida.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFlorida.Name = "btnFlorida"
        Me.btnFlorida.Size = New System.Drawing.Size(127, 28)
        Me.btnFlorida.TabIndex = 13
        Me.btnFlorida.Text = "Florida"
        Me.btnFlorida.UseVisualStyleBackColor = True
        '
        'btnAlabama
        '
        Me.btnAlabama.Location = New System.Drawing.Point(16, 197)
        Me.btnAlabama.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAlabama.Name = "btnAlabama"
        Me.btnAlabama.Size = New System.Drawing.Size(127, 28)
        Me.btnAlabama.TabIndex = 12
        Me.btnAlabama.Text = "Alabama"
        Me.btnAlabama.UseVisualStyleBackColor = True
        '
        'btnGeorgia
        '
        Me.btnGeorgia.Location = New System.Drawing.Point(16, 161)
        Me.btnGeorgia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGeorgia.Name = "btnGeorgia"
        Me.btnGeorgia.Size = New System.Drawing.Size(127, 28)
        Me.btnGeorgia.TabIndex = 11
        Me.btnGeorgia.Text = "Georgia"
        Me.btnGeorgia.UseVisualStyleBackColor = True
        '
        'btnSouthCarolina
        '
        Me.btnSouthCarolina.Location = New System.Drawing.Point(16, 126)
        Me.btnSouthCarolina.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSouthCarolina.Name = "btnSouthCarolina"
        Me.btnSouthCarolina.Size = New System.Drawing.Size(127, 28)
        Me.btnSouthCarolina.TabIndex = 10
        Me.btnSouthCarolina.Text = "South Carolina"
        Me.btnSouthCarolina.UseVisualStyleBackColor = True
        '
        'btnNorthCarolina
        '
        Me.btnNorthCarolina.Location = New System.Drawing.Point(16, 90)
        Me.btnNorthCarolina.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNorthCarolina.Name = "btnNorthCarolina"
        Me.btnNorthCarolina.Size = New System.Drawing.Size(127, 28)
        Me.btnNorthCarolina.TabIndex = 9
        Me.btnNorthCarolina.Text = "North Carolina"
        Me.btnNorthCarolina.UseVisualStyleBackColor = True
        '
        'btnVirginia
        '
        Me.btnVirginia.Location = New System.Drawing.Point(16, 54)
        Me.btnVirginia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVirginia.Name = "btnVirginia"
        Me.btnVirginia.Size = New System.Drawing.Size(127, 28)
        Me.btnVirginia.TabIndex = 8
        Me.btnVirginia.Text = "Virginia"
        Me.btnVirginia.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 276)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblAbbreviation)
        Me.Controls.Add(Me.btnFlorida)
        Me.Controls.Add(Me.btnAlabama)
        Me.Controls.Add(Me.btnGeorgia)
        Me.Controls.Add(Me.btnSouthCarolina)
        Me.Controls.Add(Me.btnNorthCarolina)
        Me.Controls.Add(Me.btnVirginia)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "State Abbreviations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblAbbreviation As System.Windows.Forms.Label
    Friend WithEvents btnFlorida As System.Windows.Forms.Button
    Friend WithEvents btnAlabama As System.Windows.Forms.Button
    Friend WithEvents btnGeorgia As System.Windows.Forms.Button
    Friend WithEvents btnSouthCarolina As System.Windows.Forms.Button
    Friend WithEvents btnNorthCarolina As System.Windows.Forms.Button
    Friend WithEvents btnVirginia As System.Windows.Forms.Button

End Class
