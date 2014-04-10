<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentAddChangeForm
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
        Me.panRecordInformation = New System.Windows.Forms.Panel()
        Me.StudentNumberTextBox = New System.Windows.Forms.TextBox()
        Me.TblStudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudDataDataSet = New _3C_Student_Database.StudDataDataSet()
        Me.StudentNameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EnrollDateTextBox = New System.Windows.Forms.TextBox()
        Me.StudentLoanTextBox = New System.Windows.Forms.TextBox()
        Me.MajorTextBox = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.txtStudentNumberSearch = New System.Windows.Forms.TextBox()
        Me.LabelOR = New System.Windows.Forms.Label()
        Me.TblStudentsTableAdapter = New _3C_Student_Database.StudDataDataSetTableAdapters.tblStudentsTableAdapter()
        Me.TableAdapterManager = New _3C_Student_Database.StudDataDataSetTableAdapters.TableAdapterManager()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        StudentNumberLabel = New System.Windows.Forms.Label()
        StudentNameLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        EnrollDateLabel = New System.Windows.Forms.Label()
        StudentLoanLabel = New System.Windows.Forms.Label()
        MajorLabel = New System.Windows.Forms.Label()
        Me.panRecordInformation.SuspendLayout()
        CType(Me.TblStudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentNumberLabel
        '
        StudentNumberLabel.AutoSize = True
        StudentNumberLabel.Location = New System.Drawing.Point(5, 17)
        StudentNumberLabel.Name = "StudentNumberLabel"
        StudentNumberLabel.Size = New System.Drawing.Size(87, 13)
        StudentNumberLabel.TabIndex = 0
        StudentNumberLabel.Text = "Student Number:"
        '
        'StudentNameLabel
        '
        StudentNameLabel.AutoSize = True
        StudentNameLabel.Location = New System.Drawing.Point(14, 43)
        StudentNameLabel.Name = "StudentNameLabel"
        StudentNameLabel.Size = New System.Drawing.Size(78, 13)
        StudentNameLabel.TabIndex = 2
        StudentNameLabel.Text = "Student Name:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(11, 69)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 4
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'EnrollDateLabel
        '
        EnrollDateLabel.AutoSize = True
        EnrollDateLabel.Location = New System.Drawing.Point(30, 95)
        EnrollDateLabel.Name = "EnrollDateLabel"
        EnrollDateLabel.Size = New System.Drawing.Size(62, 13)
        EnrollDateLabel.TabIndex = 6
        EnrollDateLabel.Text = "Enroll Date:"
        '
        'StudentLoanLabel
        '
        StudentLoanLabel.AutoSize = True
        StudentLoanLabel.Location = New System.Drawing.Point(18, 121)
        StudentLoanLabel.Name = "StudentLoanLabel"
        StudentLoanLabel.Size = New System.Drawing.Size(74, 13)
        StudentLoanLabel.TabIndex = 8
        StudentLoanLabel.Text = "Student Loan:"
        '
        'MajorLabel
        '
        MajorLabel.AutoSize = True
        MajorLabel.Location = New System.Drawing.Point(56, 147)
        MajorLabel.Name = "MajorLabel"
        MajorLabel.Size = New System.Drawing.Size(36, 13)
        MajorLabel.TabIndex = 10
        MajorLabel.Text = "Major:"
        '
        'panRecordInformation
        '
        Me.panRecordInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panRecordInformation.Controls.Add(StudentNumberLabel)
        Me.panRecordInformation.Controls.Add(Me.StudentNumberTextBox)
        Me.panRecordInformation.Controls.Add(StudentNameLabel)
        Me.panRecordInformation.Controls.Add(Me.StudentNameTextBox)
        Me.panRecordInformation.Controls.Add(PhoneNumberLabel)
        Me.panRecordInformation.Controls.Add(Me.PhoneNumberTextBox)
        Me.panRecordInformation.Controls.Add(EnrollDateLabel)
        Me.panRecordInformation.Controls.Add(Me.EnrollDateTextBox)
        Me.panRecordInformation.Controls.Add(StudentLoanLabel)
        Me.panRecordInformation.Controls.Add(Me.StudentLoanTextBox)
        Me.panRecordInformation.Controls.Add(MajorLabel)
        Me.panRecordInformation.Controls.Add(Me.MajorTextBox)
        Me.panRecordInformation.Controls.Add(Me.btnSave)
        Me.panRecordInformation.Controls.Add(Me.btnCancel)
        Me.panRecordInformation.Location = New System.Drawing.Point(12, 42)
        Me.panRecordInformation.Name = "panRecordInformation"
        Me.panRecordInformation.Size = New System.Drawing.Size(202, 223)
        Me.panRecordInformation.TabIndex = 0
        Me.panRecordInformation.Visible = False
        '
        'StudentNumberTextBox
        '
        Me.StudentNumberTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StudentNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "StudentNumber", True))
        Me.StudentNumberTextBox.Location = New System.Drawing.Point(98, 14)
        Me.StudentNumberTextBox.MaxLength = 5
        Me.StudentNumberTextBox.Name = "StudentNumberTextBox"
        Me.StudentNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentNumberTextBox.TabIndex = 1
        '
        'TblStudentsBindingSource
        '
        Me.TblStudentsBindingSource.DataMember = "tblStudents"
        Me.TblStudentsBindingSource.DataSource = Me.StudDataDataSet
        '
        'StudDataDataSet
        '
        Me.StudDataDataSet.DataSetName = "StudDataDataSet"
        Me.StudDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentNameTextBox
        '
        Me.StudentNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StudentNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "StudentName", True))
        Me.StudentNameTextBox.Location = New System.Drawing.Point(98, 40)
        Me.StudentNameTextBox.MaxLength = 50
        Me.StudentNameTextBox.Name = "StudentNameTextBox"
        Me.StudentNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentNameTextBox.TabIndex = 3
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(98, 66)
        Me.PhoneNumberTextBox.MaxLength = 10
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneNumberTextBox.TabIndex = 5
        '
        'EnrollDateTextBox
        '
        Me.EnrollDateTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnrollDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "EnrollDate", True))
        Me.EnrollDateTextBox.Location = New System.Drawing.Point(98, 92)
        Me.EnrollDateTextBox.Name = "EnrollDateTextBox"
        Me.EnrollDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EnrollDateTextBox.TabIndex = 7
        '
        'StudentLoanTextBox
        '
        Me.StudentLoanTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StudentLoanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "StudentLoan", True))
        Me.StudentLoanTextBox.Location = New System.Drawing.Point(98, 118)
        Me.StudentLoanTextBox.Name = "StudentLoanTextBox"
        Me.StudentLoanTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentLoanTextBox.TabIndex = 9
        '
        'MajorTextBox
        '
        Me.MajorTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MajorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "Major", True))
        Me.MajorTextBox.Location = New System.Drawing.Point(98, 144)
        Me.MajorTextBox.MaxLength = 3
        Me.MajorTextBox.Name = "MajorTextBox"
        Me.MajorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MajorTextBox.TabIndex = 11
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(43, 196)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(124, 196)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnGoBack
        '
        Me.btnGoBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGoBack.Location = New System.Drawing.Point(220, 238)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(75, 23)
        Me.btnGoBack.TabIndex = 5
        Me.btnGoBack.Text = "Go back"
        Me.toolTip.SetToolTip(Me.btnGoBack, "Go Back to the Navigation Form")
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(220, 11)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.toolTip.SetToolTip(Me.btnSearch, "Search for a Record")
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddNew.Location = New System.Drawing.Point(220, 73)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(75, 37)
        Me.btnAddNew.TabIndex = 3
        Me.btnAddNew.Text = "Add New Student"
        Me.toolTip.SetToolTip(Me.btnAddNew, "Add a New Student Record.")
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'txtStudentNumberSearch
        '
        Me.txtStudentNumberSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStudentNumberSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNumberSearch.Location = New System.Drawing.Point(12, 12)
        Me.txtStudentNumberSearch.MaxLength = 5
        Me.txtStudentNumberSearch.Name = "txtStudentNumberSearch"
        Me.txtStudentNumberSearch.Size = New System.Drawing.Size(202, 21)
        Me.txtStudentNumberSearch.TabIndex = 0
        Me.txtStudentNumberSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.toolTip.SetToolTip(Me.txtStudentNumberSearch, "Enter a Student Number.")
        '
        'LabelOR
        '
        Me.LabelOR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOR.Location = New System.Drawing.Point(220, 42)
        Me.LabelOR.Name = "LabelOR"
        Me.LabelOR.Size = New System.Drawing.Size(75, 23)
        Me.LabelOR.TabIndex = 2
        Me.LabelOR.Text = "OR"
        Me.LabelOR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(12, 42)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(202, 223)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Enter the Student Number to Update OR Click Add New"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.toolTip.SetToolTip(Me.lblStatus, "Current Status")
        '
        'StudentAddChangeForm
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 273)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.LabelOR)
        Me.Controls.Add(Me.txtStudentNumberSearch)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.panRecordInformation)
        Me.MinimumSize = New System.Drawing.Size(8, 304)
        Me.Name = "StudentAddChangeForm"
        Me.Text = "Add or Change Record"
        Me.panRecordInformation.ResumeLayout(False)
        Me.panRecordInformation.PerformLayout()
        CType(Me.TblStudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panRecordInformation As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents txtStudentNumberSearch As System.Windows.Forms.TextBox
    Friend WithEvents LabelOR As System.Windows.Forms.Label
    Friend WithEvents StudDataDataSet As _3C_Student_Database.StudDataDataSet
    Friend WithEvents TblStudentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblStudentsTableAdapter As _3C_Student_Database.StudDataDataSetTableAdapters.tblStudentsTableAdapter
    Friend WithEvents TableAdapterManager As _3C_Student_Database.StudDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnrollDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentLoanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MajorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
End Class
