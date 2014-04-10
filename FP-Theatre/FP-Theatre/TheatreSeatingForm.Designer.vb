<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TheatreSeatingForm
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
        Me.seats = New _FP_Theatre.SeatingGroup()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAvailability = New System.Windows.Forms.Button()
        Me.lblStage = New System.Windows.Forms.Label()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lstDate = New System.Windows.Forms.ListBox()
        Me.btnAddPerformance = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'seats
        '
        Me.seats.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.seats.BackColor = System.Drawing.SystemColors.Control
        Me.seats.Location = New System.Drawing.Point(0, 38)
        Me.seats.Name = "seats"
        Me.seats.Size = New System.Drawing.Size(628, 337)
        Me.seats.TabIndex = 0
        Me.seats.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(541, 429)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.toolTip.SetToolTip(Me.btnExit, "Close the Application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAvailability
        '
        Me.btnAvailability.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAvailability.Location = New System.Drawing.Point(12, 429)
        Me.btnAvailability.Name = "btnAvailability"
        Me.btnAvailability.Size = New System.Drawing.Size(75, 23)
        Me.btnAvailability.TabIndex = 2
        Me.btnAvailability.Text = "&Available"
        Me.toolTip.SetToolTip(Me.btnAvailability, "View Seat Availability")
        Me.btnAvailability.UseVisualStyleBackColor = True
        '
        'lblStage
        '
        Me.lblStage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStage.BackColor = System.Drawing.Color.Linen
        Me.lblStage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStage.Font = New System.Drawing.Font("Minion Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStage.Location = New System.Drawing.Point(120, 399)
        Me.lblStage.Name = "lblStage"
        Me.lblStage.Size = New System.Drawing.Size(387, 56)
        Me.lblStage.TabIndex = 5
        Me.lblStage.Text = "Stage"
        Me.lblStage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.toolTip.SetToolTip(Me.lblStage, "Stage")
        '
        'lstDate
        '
        Me.lstDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstDate.FormattingEnabled = True
        Me.lstDate.IntegralHeight = False
        Me.lstDate.Location = New System.Drawing.Point(495, 13)
        Me.lstDate.Name = "lstDate"
        Me.lstDate.Size = New System.Drawing.Size(120, 17)
        Me.lstDate.TabIndex = 1
        Me.toolTip.SetToolTip(Me.lstDate, "Performance Date")
        '
        'btnAddPerformance
        '
        Me.btnAddPerformance.Location = New System.Drawing.Point(12, 12)
        Me.btnAddPerformance.Name = "btnAddPerformance"
        Me.btnAddPerformance.Size = New System.Drawing.Size(75, 23)
        Me.btnAddPerformance.TabIndex = 3
        Me.btnAddPerformance.Text = "Add Show"
        Me.btnAddPerformance.UseVisualStyleBackColor = True
        '
        'TheatreSeatingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 464)
        Me.Controls.Add(Me.btnAddPerformance)
        Me.Controls.Add(Me.lstDate)
        Me.Controls.Add(Me.lblStage)
        Me.Controls.Add(Me.btnAvailability)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.seats)
        Me.Name = "TheatreSeatingForm"
        Me.Text = "Theatre Seating"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents seats As _FP_Theatre.SeatingGroup
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAvailability As System.Windows.Forms.Button
    Friend WithEvents lblStage As System.Windows.Forms.Label
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lstDate As System.Windows.Forms.ListBox
    Friend WithEvents btnAddPerformance As System.Windows.Forms.Button

End Class
