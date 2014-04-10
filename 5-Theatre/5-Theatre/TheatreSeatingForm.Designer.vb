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
        Me.seats = New _5_Theatre.SeatingGroup()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAvailability = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lstDate = New System.Windows.Forms.ListBox()
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
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(541, 429)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
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
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Linen
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Minion Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 399)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 56)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Stage"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.toolTip.SetToolTip(Me.Label1, "Stage")
        '
        'lstDate
        '
        Me.lstDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstDate.FormattingEnabled = True
        Me.lstDate.IntegralHeight = False
        Me.lstDate.Location = New System.Drawing.Point(495, 13)
        Me.lstDate.Name = "lstDate"
        Me.lstDate.Size = New System.Drawing.Size(120, 17)
        Me.lstDate.TabIndex = 4
        Me.toolTip.SetToolTip(Me.lstDate, "Performance Date")
        '
        'TheatreSeatingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 464)
        Me.Controls.Add(Me.lstDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAvailability)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.seats)
        Me.Name = "TheatreSeatingForm"
        Me.Text = "Theatre Seating"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents seats As _5_Theatre.SeatingGroup
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAvailability As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lstDate As System.Windows.Forms.ListBox

End Class
