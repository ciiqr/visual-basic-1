<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRainfallStats
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRainfallStats))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTotalAnnualRainfall = New System.Windows.Forms.Label()
        Me.lblAverageMonthlyRainfall = New System.Windows.Forms.Label()
        Me.btnInputAndDisplayStats = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtDataDisplay = New System.Windows.Forms.TextBox()
        Me.txtDataEntry = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMonthNum = New System.Windows.Forms.Label()
        Me.lblZeroCount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(338, 7)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(185, 16)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Monthly Rainfall Statistics"
        '
        'lblTotalAnnualRainfall
        '
        Me.lblTotalAnnualRainfall.AutoSize = True
        Me.lblTotalAnnualRainfall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAnnualRainfall.Location = New System.Drawing.Point(448, 63)
        Me.lblTotalAnnualRainfall.Name = "lblTotalAnnualRainfall"
        Me.lblTotalAnnualRainfall.Size = New System.Drawing.Size(0, 16)
        Me.lblTotalAnnualRainfall.TabIndex = 2
        '
        'lblAverageMonthlyRainfall
        '
        Me.lblAverageMonthlyRainfall.AutoSize = True
        Me.lblAverageMonthlyRainfall.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageMonthlyRainfall.Location = New System.Drawing.Point(448, 124)
        Me.lblAverageMonthlyRainfall.Name = "lblAverageMonthlyRainfall"
        Me.lblAverageMonthlyRainfall.Size = New System.Drawing.Size(0, 16)
        Me.lblAverageMonthlyRainfall.TabIndex = 3
        '
        'btnInputAndDisplayStats
        '
        Me.btnInputAndDisplayStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInputAndDisplayStats.Location = New System.Drawing.Point(252, 293)
        Me.btnInputAndDisplayStats.Name = "btnInputAndDisplayStats"
        Me.btnInputAndDisplayStats.Size = New System.Drawing.Size(259, 38)
        Me.btnInputAndDisplayStats.TabIndex = 5
        Me.btnInputAndDisplayStats.Text = "&Input Monthly Rainfall and Display Stats"
        Me.btnInputAndDisplayStats.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(550, 293)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(108, 38)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(680, 293)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 38)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtDataDisplay
        '
        Me.txtDataDisplay.Location = New System.Drawing.Point(120, 36)
        Me.txtDataDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDataDisplay.Multiline = True
        Me.txtDataDisplay.Name = "txtDataDisplay"
        Me.txtDataDisplay.Size = New System.Drawing.Size(204, 224)
        Me.txtDataDisplay.TabIndex = 8
        '
        'txtDataEntry
        '
        Me.txtDataEntry.Location = New System.Drawing.Point(16, 304)
        Me.txtDataEntry.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDataEntry.Name = "txtDataEntry"
        Me.txtDataEntry.Size = New System.Drawing.Size(171, 20)
        Me.txtDataEntry.TabIndex = 0
        Me.txtDataEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 274)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Enter Amount for Month#:"
        '
        'lblMonthNum
        '
        Me.lblMonthNum.AutoSize = True
        Me.lblMonthNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthNum.Location = New System.Drawing.Point(172, 274)
        Me.lblMonthNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMonthNum.Name = "lblMonthNum"
        Me.lblMonthNum.Size = New System.Drawing.Size(24, 17)
        Me.lblMonthNum.TabIndex = 10
        Me.lblMonthNum.Text = "01"
        '
        'lblZeroCount
        '
        Me.lblZeroCount.AutoSize = True
        Me.lblZeroCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZeroCount.Location = New System.Drawing.Point(448, 192)
        Me.lblZeroCount.Name = "lblZeroCount"
        Me.lblZeroCount.Size = New System.Drawing.Size(0, 16)
        Me.lblZeroCount.TabIndex = 11
        '
        'frmRainfallStats
        '
        Me.AcceptButton = Me.btnInputAndDisplayStats
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(805, 350)
        Me.Controls.Add(Me.lblZeroCount)
        Me.Controls.Add(Me.lblMonthNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDataEntry)
        Me.Controls.Add(Me.txtDataDisplay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnInputAndDisplayStats)
        Me.Controls.Add(Me.lblAverageMonthlyRainfall)
        Me.Controls.Add(Me.lblTotalAnnualRainfall)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRainfallStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test #1 Sample Executable - William Villeneuve"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblTotalAnnualRainfall As System.Windows.Forms.Label
    Friend WithEvents lblAverageMonthlyRainfall As System.Windows.Forms.Label
    Friend WithEvents btnInputAndDisplayStats As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtDataDisplay As System.Windows.Forms.TextBox
    Friend WithEvents txtDataEntry As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMonthNum As System.Windows.Forms.Label
    Friend WithEvents lblZeroCount As System.Windows.Forms.Label

End Class
