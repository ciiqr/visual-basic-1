<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BowlingAverageForm
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
        Me.components = New System.ComponentModel.Container()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtGameScores = New System.Windows.Forms.TextBox()
        Me.btnEnterScore = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.lblGameScorePrompt = New System.Windows.Forms.Label()
        Me.lblGameAverage = New System.Windows.Forms.Label()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(261, 150)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.toolTip.SetToolTip(Me.btnExit, "Exit the form.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtGameScores
        '
        Me.txtGameScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGameScores.Location = New System.Drawing.Point(12, 85)
        Me.txtGameScores.Multiline = True
        Me.txtGameScores.Name = "txtGameScores"
        Me.txtGameScores.ReadOnly = True
        Me.txtGameScores.Size = New System.Drawing.Size(96, 88)
        Me.txtGameScores.TabIndex = 2
        Me.txtGameScores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.toolTip.SetToolTip(Me.txtGameScores, "Currently entered game scores.")
        '
        'btnEnterScore
        '
        Me.btnEnterScore.Location = New System.Drawing.Point(261, 92)
        Me.btnEnterScore.Name = "btnEnterScore"
        Me.btnEnterScore.Size = New System.Drawing.Size(75, 23)
        Me.btnEnterScore.TabIndex = 3
        Me.btnEnterScore.Text = "Enter &Score"
        Me.toolTip.SetToolTip(Me.btnEnterScore, "Input the entered score/")
        Me.btnEnterScore.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(261, 121)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "&Reset"
        Me.toolTip.SetToolTip(Me.btnReset, "Reset the form.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(236, 56)
        Me.txtScore.MaxLength = 3
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(100, 20)
        Me.txtScore.TabIndex = 1
        Me.toolTip.SetToolTip(Me.txtScore, "Enter game scores here")
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(2, 9)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(332, 33)
        Me.LabelTitle.TabIndex = 6
        Me.LabelTitle.Text = "Will's Bowling Average"
        '
        'lblGameScorePrompt
        '
        Me.lblGameScorePrompt.AutoSize = True
        Me.lblGameScorePrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameScorePrompt.Location = New System.Drawing.Point(17, 57)
        Me.lblGameScorePrompt.Name = "lblGameScorePrompt"
        Me.lblGameScorePrompt.Size = New System.Drawing.Size(198, 16)
        Me.lblGameScorePrompt.TabIndex = 0
        Me.lblGameScorePrompt.Text = "&Enter bowling score for game #1"
        '
        'lblGameAverage
        '
        Me.lblGameAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameAverage.Location = New System.Drawing.Point(111, 121)
        Me.lblGameAverage.Name = "lblGameAverage"
        Me.lblGameAverage.Size = New System.Drawing.Size(148, 23)
        Me.lblGameAverage.TabIndex = 7
        '
        'BowlingAverageForm
        '
        Me.AcceptButton = Me.btnEnterScore
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(348, 185)
        Me.Controls.Add(Me.lblGameAverage)
        Me.Controls.Add(Me.lblGameScorePrompt)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnterScore)
        Me.Controls.Add(Me.txtGameScores)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "BowlingAverageForm"
        Me.Text = "Will's Bowling Average - Lab 2A"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGameScores As System.Windows.Forms.TextBox
    Friend WithEvents btnEnterScore As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents lblGameScorePrompt As System.Windows.Forms.Label
    Friend WithEvents lblGameAverage As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip

End Class
