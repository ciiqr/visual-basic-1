<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentRecordForm
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
        Dim StudentNumberLabel As System.Windows.Forms.Label
        Dim StudentNameLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim EnrollDateLabel As System.Windows.Forms.Label
        Dim StudentLoanLabel As System.Windows.Forms.Label
        Dim MajorLabel As System.Windows.Forms.Label
        Me.StudDataDataSet = New _3C_Student_Database.StudDataDataSet()
        Me.TblStudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblStudentsTableAdapter = New _3C_Student_Database.StudDataDataSetTableAdapters.tblStudentsTableAdapter()
        Me.TableAdapterManager = New _3C_Student_Database.StudDataDataSetTableAdapters.TableAdapterManager()
        Me.StudentNumberLabel1 = New System.Windows.Forms.Label()
        Me.StudentNameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EnrollDateTextBox = New System.Windows.Forms.TextBox()
        Me.StudentLoanTextBox = New System.Windows.Forms.TextBox()
        Me.MajorTextBox = New System.Windows.Forms.TextBox()
        Me.btnGoToStart = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.btnGoToPrevious = New System.Windows.Forms.Button()
        Me.btnGoToNext = New System.Windows.Forms.Button()
        Me.btnGoToEnd = New System.Windows.Forms.Button()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblRecordPositionIndicator = New System.Windows.Forms.Label()
        StudentNumberLabel = New System.Windows.Forms.Label()
        StudentNameLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        EnrollDateLabel = New System.Windows.Forms.Label()
        StudentLoanLabel = New System.Windows.Forms.Label()
        MajorLabel = New System.Windows.Forms.Label()
        CType(Me.StudDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentNumberLabel
        '
        StudentNumberLabel.AutoSize = True
        StudentNumberLabel.Location = New System.Drawing.Point(22, 29)
        StudentNumberLabel.Name = "StudentNumberLabel"
        StudentNumberLabel.Size = New System.Drawing.Size(87, 13)
        StudentNumberLabel.TabIndex = 0
        StudentNumberLabel.Text = "Student Number:"
        '
        'StudentNameLabel
        '
        StudentNameLabel.AutoSize = True
        StudentNameLabel.Location = New System.Drawing.Point(31, 61)
        StudentNameLabel.Name = "StudentNameLabel"
        StudentNameLabel.Size = New System.Drawing.Size(78, 13)
        StudentNameLabel.TabIndex = 2
        StudentNameLabel.Text = "Student N&ame:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(28, 90)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 4
        PhoneNumberLabel.Text = "&Phone Number:"
        '
        'EnrollDateLabel
        '
        EnrollDateLabel.AutoSize = True
        EnrollDateLabel.Location = New System.Drawing.Point(47, 119)
        EnrollDateLabel.Name = "EnrollDateLabel"
        EnrollDateLabel.Size = New System.Drawing.Size(62, 13)
        EnrollDateLabel.TabIndex = 6
        EnrollDateLabel.Text = "Enroll &Date:"
        '
        'StudentLoanLabel
        '
        StudentLoanLabel.AutoSize = True
        StudentLoanLabel.Location = New System.Drawing.Point(35, 148)
        StudentLoanLabel.Name = "StudentLoanLabel"
        StudentLoanLabel.Size = New System.Drawing.Size(74, 13)
        StudentLoanLabel.TabIndex = 8
        StudentLoanLabel.Text = "Student &Loan:"
        '
        'MajorLabel
        '
        MajorLabel.AutoSize = True
        MajorLabel.Location = New System.Drawing.Point(73, 177)
        MajorLabel.Name = "MajorLabel"
        MajorLabel.Size = New System.Drawing.Size(36, 13)
        MajorLabel.TabIndex = 10
        MajorLabel.Text = "&Major:"
        '
        'StudDataDataSet
        '
        Me.StudDataDataSet.DataSetName = "StudDataDataSet"
        Me.StudDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblStudentsBindingSource
        '
        Me.TblStudentsBindingSource.DataMember = "tblStudents"
        Me.TblStudentsBindingSource.DataSource = Me.StudDataDataSet
        '
        'TblStudentsTableAdapter
        '
        Me.TblStudentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblStudentsTableAdapter = Me.TblStudentsTableAdapter
        Me.TableAdapterManager.UpdateOrder = _3C_Student_Database.StudDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StudentNumberLabel1
        '
        Me.StudentNumberLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "StudentNumber", True))
        Me.StudentNumberLabel1.Location = New System.Drawing.Point(115, 29)
        Me.StudentNumberLabel1.Name = "StudentNumberLabel1"
        Me.StudentNumberLabel1.Size = New System.Drawing.Size(100, 23)
        Me.StudentNumberLabel1.TabIndex = 1
        Me.StudentNumberLabel1.Text = "Label1"
        '
        'StudentNameTextBox
        '
        Me.StudentNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "StudentName", True))
        Me.StudentNameTextBox.Location = New System.Drawing.Point(115, 58)
        Me.StudentNameTextBox.Name = "StudentNameTextBox"
        Me.StudentNameTextBox.ReadOnly = True
        Me.StudentNameTextBox.Size = New System.Drawing.Size(163, 20)
        Me.StudentNameTextBox.TabIndex = 3
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(115, 87)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.ReadOnly = True
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(68, 20)
        Me.PhoneNumberTextBox.TabIndex = 5
        '
        'EnrollDateTextBox
        '
        Me.EnrollDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "EnrollDate", True))
        Me.EnrollDateTextBox.Location = New System.Drawing.Point(115, 116)
        Me.EnrollDateTextBox.Name = "EnrollDateTextBox"
        Me.EnrollDateTextBox.ReadOnly = True
        Me.EnrollDateTextBox.Size = New System.Drawing.Size(68, 20)
        Me.EnrollDateTextBox.TabIndex = 7
        '
        'StudentLoanTextBox
        '
        Me.StudentLoanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "StudentLoan", True))
        Me.StudentLoanTextBox.Location = New System.Drawing.Point(115, 145)
        Me.StudentLoanTextBox.Name = "StudentLoanTextBox"
        Me.StudentLoanTextBox.ReadOnly = True
        Me.StudentLoanTextBox.Size = New System.Drawing.Size(68, 20)
        Me.StudentLoanTextBox.TabIndex = 9
        '
        'MajorTextBox
        '
        Me.MajorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "Major", True))
        Me.MajorTextBox.Location = New System.Drawing.Point(115, 174)
        Me.MajorTextBox.Name = "MajorTextBox"
        Me.MajorTextBox.ReadOnly = True
        Me.MajorTextBox.Size = New System.Drawing.Size(53, 20)
        Me.MajorTextBox.TabIndex = 11
        '
        'btnGoToStart
        '
        Me.btnGoToStart.Enabled = False
        Me.btnGoToStart.Location = New System.Drawing.Point(24, 225)
        Me.btnGoToStart.Name = "btnGoToStart"
        Me.btnGoToStart.Size = New System.Drawing.Size(59, 23)
        Me.btnGoToStart.TabIndex = 12
        Me.btnGoToStart.Text = "&Start"
        Me.toolTip.SetToolTip(Me.btnGoToStart, "Go to the First Record")
        Me.btnGoToStart.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(94, 225)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Previous"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(159, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(55, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Start"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(230, 254)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(59, 23)
        Me.btnGoBack.TabIndex = 16
        Me.btnGoBack.Text = "Go &Back"
        Me.toolTip.SetToolTip(Me.btnGoBack, "Go to the Navigation Form")
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'btnGoToPrevious
        '
        Me.btnGoToPrevious.Enabled = False
        Me.btnGoToPrevious.Location = New System.Drawing.Point(95, 225)
        Me.btnGoToPrevious.Name = "btnGoToPrevious"
        Me.btnGoToPrevious.Size = New System.Drawing.Size(59, 23)
        Me.btnGoToPrevious.TabIndex = 13
        Me.btnGoToPrevious.Text = "P&revious"
        Me.toolTip.SetToolTip(Me.btnGoToPrevious, "Go to the Previous Record")
        Me.btnGoToPrevious.UseVisualStyleBackColor = True
        '
        'btnGoToNext
        '
        Me.btnGoToNext.Location = New System.Drawing.Point(159, 225)
        Me.btnGoToNext.Name = "btnGoToNext"
        Me.btnGoToNext.Size = New System.Drawing.Size(59, 23)
        Me.btnGoToNext.TabIndex = 14
        Me.btnGoToNext.Text = "&Next"
        Me.toolTip.SetToolTip(Me.btnGoToNext, "Go to the Next Record")
        Me.btnGoToNext.UseVisualStyleBackColor = True
        '
        'btnGoToEnd
        '
        Me.btnGoToEnd.Location = New System.Drawing.Point(230, 225)
        Me.btnGoToEnd.Name = "btnGoToEnd"
        Me.btnGoToEnd.Size = New System.Drawing.Size(59, 23)
        Me.btnGoToEnd.TabIndex = 15
        Me.btnGoToEnd.Text = "&End"
        Me.toolTip.SetToolTip(Me.btnGoToEnd, "Go to the Last Record")
        Me.btnGoToEnd.UseVisualStyleBackColor = True
        '
        'lblRecordPositionIndicator
        '
        Me.lblRecordPositionIndicator.AutoSize = True
        Me.lblRecordPositionIndicator.Location = New System.Drawing.Point(24, 264)
        Me.lblRecordPositionIndicator.Name = "lblRecordPositionIndicator"
        Me.lblRecordPositionIndicator.Size = New System.Drawing.Size(0, 13)
        Me.lblRecordPositionIndicator.TabIndex = 17
        '
        'StudentRecordForm
        '
        Me.AcceptButton = Me.btnGoToNext
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 292)
        Me.Controls.Add(Me.lblRecordPositionIndicator)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.btnGoToEnd)
        Me.Controls.Add(Me.btnGoToNext)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnGoToPrevious)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnGoToStart)
        Me.Controls.Add(StudentNumberLabel)
        Me.Controls.Add(Me.StudentNumberLabel1)
        Me.Controls.Add(StudentNameLabel)
        Me.Controls.Add(Me.StudentNameTextBox)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(EnrollDateLabel)
        Me.Controls.Add(Me.EnrollDateTextBox)
        Me.Controls.Add(StudentLoanLabel)
        Me.Controls.Add(Me.StudentLoanTextBox)
        Me.Controls.Add(MajorLabel)
        Me.Controls.Add(Me.MajorTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "StudentRecordForm"
        Me.Text = "Display One Record"
        CType(Me.StudDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudDataDataSet As _3C_Student_Database.StudDataDataSet
    Friend WithEvents TblStudentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblStudentsTableAdapter As _3C_Student_Database.StudDataDataSetTableAdapters.tblStudentsTableAdapter
    Friend WithEvents TableAdapterManager As _3C_Student_Database.StudDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentNumberLabel1 As System.Windows.Forms.Label
    Friend WithEvents StudentNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnrollDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentLoanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MajorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnGoToStart As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
    Friend WithEvents btnGoToPrevious As System.Windows.Forms.Button
    Friend WithEvents btnGoToNext As System.Windows.Forms.Button
    Friend WithEvents btnGoToEnd As System.Windows.Forms.Button
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lblRecordPositionIndicator As System.Windows.Forms.Label
End Class
