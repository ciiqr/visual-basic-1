<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IceCreamForm
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
        Me.grpExtras = New System.Windows.Forms.GroupBox()
        Me.chkNuts = New System.Windows.Forms.CheckBox()
        Me.chkWhippedCream = New System.Windows.Forms.CheckBox()
        Me.grpToppings = New System.Windows.Forms.GroupBox()
        Me.rdoThreeToppings = New System.Windows.Forms.RadioButton()
        Me.rdoTwoToppings = New System.Windows.Forms.RadioButton()
        Me.rdoOneTopping = New System.Windows.Forms.RadioButton()
        Me.rdoNoToppings = New System.Windows.Forms.RadioButton()
        Me.LabelFlavour = New System.Windows.Forms.Label()
        Me.LabelScoups = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.lstFlavours = New System.Windows.Forms.ListBox()
        Me.txtScoops = New System.Windows.Forms.TextBox()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.LabelSubTotal = New System.Windows.Forms.Label()
        Me.LabelHST = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblHST = New System.Windows.Forms.Label()
        Me.grpExtras.SuspendLayout()
        Me.grpToppings.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpExtras
        '
        Me.grpExtras.Controls.Add(Me.chkNuts)
        Me.grpExtras.Controls.Add(Me.chkWhippedCream)
        Me.grpExtras.Location = New System.Drawing.Point(236, 189)
        Me.grpExtras.Name = "grpExtras"
        Me.grpExtras.Size = New System.Drawing.Size(117, 64)
        Me.grpExtras.TabIndex = 6
        Me.grpExtras.TabStop = False
        Me.grpExtras.Text = "Extras"
        Me.toolTip.SetToolTip(Me.grpExtras, "Choose extras for the sundae.")
        '
        'chkNuts
        '
        Me.chkNuts.AutoSize = True
        Me.chkNuts.Location = New System.Drawing.Point(7, 44)
        Me.chkNuts.Name = "chkNuts"
        Me.chkNuts.Size = New System.Drawing.Size(48, 17)
        Me.chkNuts.TabIndex = 4
        Me.chkNuts.Text = "N&uts"
        Me.chkNuts.UseVisualStyleBackColor = True
        '
        'chkWhippedCream
        '
        Me.chkWhippedCream.AutoSize = True
        Me.chkWhippedCream.Location = New System.Drawing.Point(7, 21)
        Me.chkWhippedCream.Name = "chkWhippedCream"
        Me.chkWhippedCream.Size = New System.Drawing.Size(102, 17)
        Me.chkWhippedCream.TabIndex = 3
        Me.chkWhippedCream.Text = "&Whipped Cream"
        Me.chkWhippedCream.UseVisualStyleBackColor = True
        '
        'grpToppings
        '
        Me.grpToppings.Controls.Add(Me.rdoThreeToppings)
        Me.grpToppings.Controls.Add(Me.rdoTwoToppings)
        Me.grpToppings.Controls.Add(Me.rdoOneTopping)
        Me.grpToppings.Controls.Add(Me.rdoNoToppings)
        Me.grpToppings.Location = New System.Drawing.Point(236, 54)
        Me.grpToppings.Name = "grpToppings"
        Me.grpToppings.Size = New System.Drawing.Size(117, 113)
        Me.grpToppings.TabIndex = 5
        Me.grpToppings.TabStop = False
        Me.grpToppings.Text = "Toppings"
        Me.toolTip.SetToolTip(Me.grpToppings, "Choose the number of toppings.")
        '
        'rdoThreeToppings
        '
        Me.rdoThreeToppings.AutoSize = True
        Me.rdoThreeToppings.Location = New System.Drawing.Point(6, 88)
        Me.rdoThreeToppings.Name = "rdoThreeToppings"
        Me.rdoThreeToppings.Size = New System.Drawing.Size(78, 17)
        Me.rdoThreeToppings.TabIndex = 3
        Me.rdoThreeToppings.Text = "&3 Toppings"
        Me.rdoThreeToppings.UseVisualStyleBackColor = True
        '
        'rdoTwoToppings
        '
        Me.rdoTwoToppings.AutoSize = True
        Me.rdoTwoToppings.Location = New System.Drawing.Point(6, 65)
        Me.rdoTwoToppings.Name = "rdoTwoToppings"
        Me.rdoTwoToppings.Size = New System.Drawing.Size(78, 17)
        Me.rdoTwoToppings.TabIndex = 2
        Me.rdoTwoToppings.Text = "&2 Toppings"
        Me.rdoTwoToppings.UseVisualStyleBackColor = True
        '
        'rdoOneTopping
        '
        Me.rdoOneTopping.AutoSize = True
        Me.rdoOneTopping.Location = New System.Drawing.Point(6, 42)
        Me.rdoOneTopping.Name = "rdoOneTopping"
        Me.rdoOneTopping.Size = New System.Drawing.Size(73, 17)
        Me.rdoOneTopping.TabIndex = 1
        Me.rdoOneTopping.Text = "&1 Topping"
        Me.rdoOneTopping.UseVisualStyleBackColor = True
        '
        'rdoNoToppings
        '
        Me.rdoNoToppings.AutoSize = True
        Me.rdoNoToppings.Checked = True
        Me.rdoNoToppings.Location = New System.Drawing.Point(6, 19)
        Me.rdoNoToppings.Name = "rdoNoToppings"
        Me.rdoNoToppings.Size = New System.Drawing.Size(86, 17)
        Me.rdoNoToppings.TabIndex = 0
        Me.rdoNoToppings.TabStop = True
        Me.rdoNoToppings.Text = "&No Toppings"
        Me.rdoNoToppings.UseVisualStyleBackColor = True
        '
        'LabelFlavour
        '
        Me.LabelFlavour.AutoSize = True
        Me.LabelFlavour.Location = New System.Drawing.Point(15, 54)
        Me.LabelFlavour.Name = "LabelFlavour"
        Me.LabelFlavour.Size = New System.Drawing.Size(42, 13)
        Me.LabelFlavour.TabIndex = 3
        Me.LabelFlavour.Text = "&Flavour"
        Me.toolTip.SetToolTip(Me.LabelFlavour, "Choose a flavour.")
        '
        'LabelScoups
        '
        Me.LabelScoups.AutoSize = True
        Me.LabelScoups.Location = New System.Drawing.Point(15, 149)
        Me.LabelScoups.Name = "LabelScoups"
        Me.LabelScoups.Size = New System.Drawing.Size(43, 13)
        Me.LabelScoups.TabIndex = 1
        Me.LabelScoups.Text = "&Scoops"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(15, 235)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(66, 13)
        Me.LabelTotal.TabIndex = 10
        Me.LabelTotal.Text = "Grand Total:"
        '
        'lstFlavours
        '
        Me.lstFlavours.FormattingEnabled = True
        Me.lstFlavours.Location = New System.Drawing.Point(15, 70)
        Me.lstFlavours.Name = "lstFlavours"
        Me.lstFlavours.Size = New System.Drawing.Size(181, 69)
        Me.lstFlavours.TabIndex = 4
        '
        'txtScoops
        '
        Me.txtScoops.Location = New System.Drawing.Point(83, 145)
        Me.txtScoops.MaxLength = 1
        Me.txtScoops.Name = "txtScoops"
        Me.txtScoops.Size = New System.Drawing.Size(42, 20)
        Me.txtScoops.TabIndex = 2
        Me.txtScoops.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.toolTip.SetToolTip(Me.txtScoops, "Enter the number of scoops")
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrandTotal.Location = New System.Drawing.Point(83, 230)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(113, 23)
        Me.lblGrandTotal.TabIndex = 11
        Me.toolTip.SetToolTip(Me.lblGrandTotal, "Total cost of the sundae.")
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(10, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(353, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Will's Ice Cream Parlour"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(266, 266)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.toolTip.SetToolTip(Me.btnExit, "Exit the form.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(149, 266)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C&lear"
        Me.toolTip.SetToolTip(Me.btnClear, "Clear the form.")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(32, 266)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "&Calculate"
        Me.toolTip.SetToolTip(Me.btnCalculate, "Calculate the total cost.")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'LabelSubTotal
        '
        Me.LabelSubTotal.AutoSize = True
        Me.LabelSubTotal.Location = New System.Drawing.Point(15, 181)
        Me.LabelSubTotal.Name = "LabelSubTotal"
        Me.LabelSubTotal.Size = New System.Drawing.Size(56, 13)
        Me.LabelSubTotal.TabIndex = 12
        Me.LabelSubTotal.Text = "Sub-Total:"
        '
        'LabelHST
        '
        Me.LabelHST.AutoSize = True
        Me.LabelHST.Location = New System.Drawing.Point(15, 208)
        Me.LabelHST.Name = "LabelHST"
        Me.LabelHST.Size = New System.Drawing.Size(32, 13)
        Me.LabelHST.TabIndex = 13
        Me.LabelHST.Text = "HST:"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(83, 176)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(113, 23)
        Me.lblSubTotal.TabIndex = 14
        '
        'lblHST
        '
        Me.lblHST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHST.Location = New System.Drawing.Point(83, 203)
        Me.lblHST.Name = "lblHST"
        Me.lblHST.Size = New System.Drawing.Size(113, 23)
        Me.lblHST.TabIndex = 15
        '
        'IceCreamForm
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(372, 295)
        Me.Controls.Add(Me.lblHST)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.LabelHST)
        Me.Controls.Add(Me.LabelSubTotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.txtScoops)
        Me.Controls.Add(Me.lstFlavours)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.LabelScoups)
        Me.Controls.Add(Me.LabelFlavour)
        Me.Controls.Add(Me.grpToppings)
        Me.Controls.Add(Me.grpExtras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "IceCreamForm"
        Me.Text = "Will's Ice Cream Parlour - Lab 1B"
        Me.grpExtras.ResumeLayout(False)
        Me.grpExtras.PerformLayout()
        Me.grpToppings.ResumeLayout(False)
        Me.grpToppings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpExtras As System.Windows.Forms.GroupBox
    Friend WithEvents grpToppings As System.Windows.Forms.GroupBox
    Friend WithEvents chkNuts As System.Windows.Forms.CheckBox
    Friend WithEvents chkWhippedCream As System.Windows.Forms.CheckBox
    Friend WithEvents rdoThreeToppings As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTwoToppings As System.Windows.Forms.RadioButton
    Friend WithEvents rdoOneTopping As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNoToppings As System.Windows.Forms.RadioButton
    Friend WithEvents LabelFlavour As System.Windows.Forms.Label
    Friend WithEvents LabelScoups As System.Windows.Forms.Label
    Friend WithEvents LabelTotal As System.Windows.Forms.Label
    Friend WithEvents lstFlavours As System.Windows.Forms.ListBox
    Friend WithEvents txtScoops As System.Windows.Forms.TextBox
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents LabelSubTotal As System.Windows.Forms.Label
    Friend WithEvents LabelHST As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblHST As System.Windows.Forms.Label

End Class
