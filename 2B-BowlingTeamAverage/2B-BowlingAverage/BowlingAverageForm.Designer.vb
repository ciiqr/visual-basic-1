<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BowlingTeamAverageForm
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
        Me.txtGameScores1 = New System.Windows.Forms.TextBox()
        Me.btnEnterScore = New System.Windows.Forms.Button()
        Me.btnResetPlayer = New System.Windows.Forms.Button()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.lblGameScorePrompt = New System.Windows.Forms.Label()
        Me.lblTeamAverage = New System.Windows.Forms.Label()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnResetTeam = New System.Windows.Forms.Button()
        Me.txtGameScores2 = New System.Windows.Forms.TextBox()
        Me.txtGameScores3 = New System.Windows.Forms.TextBox()
        Me.txtGameScores4 = New System.Windows.Forms.TextBox()
        Me.lblGameAverage = New System.Windows.Forms.Label()
        Me.lblGameAverage1 = New System.Windows.Forms.Label()
        Me.lblGameAverage2 = New System.Windows.Forms.Label()
        Me.lblGameAverage3 = New System.Windows.Forms.Label()
        Me.lblGameAverage4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(347, 152)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.toolTip.SetToolTip(Me.btnExit, "Exit the form.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtGameScores1
        '
        Me.txtGameScores1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGameScores1.Location = New System.Drawing.Point(97, 86)
        Me.txtGameScores1.Multiline = True
        Me.txtGameScores1.Name = "txtGameScores1"
        Me.txtGameScores1.ReadOnly = True
        Me.txtGameScores1.Size = New System.Drawing.Size(41, 88)
        Me.txtGameScores1.TabIndex = 2
        Me.txtGameScores1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.toolTip.SetToolTip(Me.txtGameScores1, "Currently entered game scores.")
        '
        'btnEnterScore
        '
        Me.btnEnterScore.Location = New System.Drawing.Point(347, 55)
        Me.btnEnterScore.Name = "btnEnterScore"
        Me.btnEnterScore.Size = New System.Drawing.Size(75, 23)
        Me.btnEnterScore.TabIndex = 3
        Me.btnEnterScore.Text = "Enter &Score"
        Me.toolTip.SetToolTip(Me.btnEnterScore, "Input the entered score/")
        Me.btnEnterScore.UseVisualStyleBackColor = True
        '
        'btnResetPlayer
        '
        Me.btnResetPlayer.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnResetPlayer.Location = New System.Drawing.Point(347, 87)
        Me.btnResetPlayer.Name = "btnResetPlayer"
        Me.btnResetPlayer.Size = New System.Drawing.Size(75, 23)
        Me.btnResetPlayer.TabIndex = 4
        Me.btnResetPlayer.Text = "Reset &Player"
        Me.toolTip.SetToolTip(Me.btnResetPlayer, "Reset the current player.")
        Me.btnResetPlayer.UseVisualStyleBackColor = True
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
        Me.LabelTitle.Size = New System.Drawing.Size(420, 33)
        Me.LabelTitle.TabIndex = 6
        Me.LabelTitle.Text = "Will's Bowling Team Average"
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
        'lblTeamAverage
        '
        Me.lblTeamAverage.BackColor = System.Drawing.SystemColors.Control
        Me.lblTeamAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeamAverage.Location = New System.Drawing.Point(5, 209)
        Me.lblTeamAverage.Name = "lblTeamAverage"
        Me.lblTeamAverage.Size = New System.Drawing.Size(148, 23)
        Me.lblTeamAverage.TabIndex = 7
        Me.lblTeamAverage.Text = "Team Average : "
        Me.toolTip.SetToolTip(Me.lblTeamAverage, "Average of 4 Players Each Playing 5 Games")
        Me.lblTeamAverage.Visible = False
        '
        'btnResetTeam
        '
        Me.btnResetTeam.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnResetTeam.Location = New System.Drawing.Point(347, 120)
        Me.btnResetTeam.Name = "btnResetTeam"
        Me.btnResetTeam.Size = New System.Drawing.Size(75, 23)
        Me.btnResetTeam.TabIndex = 8
        Me.btnResetTeam.Text = "Reset &Team"
        Me.toolTip.SetToolTip(Me.btnResetTeam, "Reset the form.")
        Me.btnResetTeam.UseVisualStyleBackColor = True
        '
        'txtGameScores2
        '
        Me.txtGameScores2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGameScores2.Location = New System.Drawing.Point(163, 86)
        Me.txtGameScores2.Multiline = True
        Me.txtGameScores2.Name = "txtGameScores2"
        Me.txtGameScores2.ReadOnly = True
        Me.txtGameScores2.Size = New System.Drawing.Size(41, 88)
        Me.txtGameScores2.TabIndex = 9
        Me.txtGameScores2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.toolTip.SetToolTip(Me.txtGameScores2, "Currently entered game scores.")
        '
        'txtGameScores3
        '
        Me.txtGameScores3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGameScores3.Location = New System.Drawing.Point(229, 86)
        Me.txtGameScores3.Multiline = True
        Me.txtGameScores3.Name = "txtGameScores3"
        Me.txtGameScores3.ReadOnly = True
        Me.txtGameScores3.Size = New System.Drawing.Size(41, 88)
        Me.txtGameScores3.TabIndex = 10
        Me.txtGameScores3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.toolTip.SetToolTip(Me.txtGameScores3, "Currently entered game scores.")
        '
        'txtGameScores4
        '
        Me.txtGameScores4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGameScores4.Location = New System.Drawing.Point(295, 86)
        Me.txtGameScores4.Multiline = True
        Me.txtGameScores4.Name = "txtGameScores4"
        Me.txtGameScores4.ReadOnly = True
        Me.txtGameScores4.Size = New System.Drawing.Size(41, 88)
        Me.txtGameScores4.TabIndex = 11
        Me.txtGameScores4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.toolTip.SetToolTip(Me.txtGameScores4, "Currently entered game scores.")
        '
        'lblGameAverage
        '
        Me.lblGameAverage.BackColor = System.Drawing.SystemColors.Control
        Me.lblGameAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameAverage.Location = New System.Drawing.Point(5, 177)
        Me.lblGameAverage.Name = "lblGameAverage"
        Me.lblGameAverage.Size = New System.Drawing.Size(86, 23)
        Me.lblGameAverage.TabIndex = 12
        Me.lblGameAverage.Text = "5 Game Avg :"
        Me.toolTip.SetToolTip(Me.lblGameAverage, "Average of each players 5 games")
        Me.lblGameAverage.Visible = False
        '
        'lblGameAverage1
        '
        Me.lblGameAverage1.BackColor = System.Drawing.SystemColors.Control
        Me.lblGameAverage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameAverage1.Location = New System.Drawing.Point(97, 177)
        Me.lblGameAverage1.Name = "lblGameAverage1"
        Me.lblGameAverage1.Size = New System.Drawing.Size(41, 23)
        Me.lblGameAverage1.TabIndex = 13
        Me.lblGameAverage1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTip.SetToolTip(Me.lblGameAverage1, "Player Average")
        '
        'lblGameAverage2
        '
        Me.lblGameAverage2.BackColor = System.Drawing.SystemColors.Control
        Me.lblGameAverage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameAverage2.Location = New System.Drawing.Point(163, 177)
        Me.lblGameAverage2.Name = "lblGameAverage2"
        Me.lblGameAverage2.Size = New System.Drawing.Size(41, 23)
        Me.lblGameAverage2.TabIndex = 14
        Me.lblGameAverage2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTip.SetToolTip(Me.lblGameAverage2, "Player Average")
        '
        'lblGameAverage3
        '
        Me.lblGameAverage3.BackColor = System.Drawing.SystemColors.Control
        Me.lblGameAverage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameAverage3.Location = New System.Drawing.Point(229, 177)
        Me.lblGameAverage3.Name = "lblGameAverage3"
        Me.lblGameAverage3.Size = New System.Drawing.Size(41, 23)
        Me.lblGameAverage3.TabIndex = 15
        Me.lblGameAverage3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTip.SetToolTip(Me.lblGameAverage3, "Player Average")
        '
        'lblGameAverage4
        '
        Me.lblGameAverage4.BackColor = System.Drawing.SystemColors.Control
        Me.lblGameAverage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameAverage4.Location = New System.Drawing.Point(295, 177)
        Me.lblGameAverage4.Name = "lblGameAverage4"
        Me.lblGameAverage4.Size = New System.Drawing.Size(41, 23)
        Me.lblGameAverage4.TabIndex = 16
        Me.lblGameAverage4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.toolTip.SetToolTip(Me.lblGameAverage4, "Player Average")
        '
        'BowlingTeamAverageForm
        '
        Me.AcceptButton = Me.btnEnterScore
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnResetPlayer
        Me.ClientSize = New System.Drawing.Size(436, 239)
        Me.Controls.Add(Me.lblGameAverage4)
        Me.Controls.Add(Me.lblGameAverage3)
        Me.Controls.Add(Me.lblGameAverage2)
        Me.Controls.Add(Me.lblGameAverage1)
        Me.Controls.Add(Me.lblGameAverage)
        Me.Controls.Add(Me.txtGameScores4)
        Me.Controls.Add(Me.txtGameScores3)
        Me.Controls.Add(Me.txtGameScores2)
        Me.Controls.Add(Me.btnResetTeam)
        Me.Controls.Add(Me.lblTeamAverage)
        Me.Controls.Add(Me.lblGameScorePrompt)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.btnResetPlayer)
        Me.Controls.Add(Me.btnEnterScore)
        Me.Controls.Add(Me.txtGameScores1)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "BowlingTeamAverageForm"
        Me.Text = "Will's Bowling Team Average - Lab 2B"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGameScores1 As System.Windows.Forms.TextBox
    Friend WithEvents btnEnterScore As System.Windows.Forms.Button
    Friend WithEvents btnResetPlayer As System.Windows.Forms.Button
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents lblGameScorePrompt As System.Windows.Forms.Label
    Friend WithEvents lblTeamAverage As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnResetTeam As System.Windows.Forms.Button
    Friend WithEvents txtGameScores2 As System.Windows.Forms.TextBox
    Friend WithEvents txtGameScores3 As System.Windows.Forms.TextBox
    Friend WithEvents txtGameScores4 As System.Windows.Forms.TextBox
    Friend WithEvents lblGameAverage As System.Windows.Forms.Label
    Friend WithEvents lblGameAverage1 As System.Windows.Forms.Label
    Friend WithEvents lblGameAverage2 As System.Windows.Forms.Label
    Friend WithEvents lblGameAverage3 As System.Windows.Forms.Label
    Friend WithEvents lblGameAverage4 As System.Windows.Forms.Label

End Class
