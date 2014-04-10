<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndexForm
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
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(13, 13)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(278, 13)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "Cut, Copy Paste, Select All and Case Changing:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Highlight the text wanted, or press select all in the edit menu to select it and " & _
    "under the Edit menu click the action you wish to perform, alternatively use the " & _
    "keyboard shortcuts."
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(112, 178)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(75, 23)
        Me.btnOkay.TabIndex = 2
        Me.btnOkay.Text = "Ok"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'IndexForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 219)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "IndexForm"
        Me.Text = "Help Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOkay As System.Windows.Forms.Button
End Class
