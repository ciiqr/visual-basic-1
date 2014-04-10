<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentNumberSearchForm
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
        Me.StudentNumberLabel1 = New System.Windows.Forms.Label()
        Me.TblStudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudDataDataSet = New _3B_Student_Database.StudDataDataSet()
        Me.StudentNameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EnrollDateTextBox = New System.Windows.Forms.TextBox()
        Me.StudentLoanTextBox = New System.Windows.Forms.TextBox()
        Me.MajorTextBox = New System.Windows.Forms.TextBox()
        Me.txtStudentNumberSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.LabelStudentNumberSearch = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.TblStudentsTableAdapter = New _3B_Student_Database.StudDataDataSetTableAdapters.tblStudentsTableAdapter()
        Me.TableAdapterManager = New _3B_Student_Database.StudDataDataSetTableAdapters.TableAdapterManager()
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
        StudentNumberLabel.Location = New System.Drawing.Point(18, 12)
        StudentNumberLabel.Name = "StudentNumberLabel"
        StudentNumberLabel.Size = New System.Drawing.Size(87, 13)
        StudentNumberLabel.TabIndex = 0
        StudentNumberLabel.Text = "Student Number:"
        '
        'StudentNameLabel
        '
        StudentNameLabel.AutoSize = True
        StudentNameLabel.Location = New System.Drawing.Point(27, 43)
        StudentNameLabel.Name = "StudentNameLabel"
        StudentNameLabel.Size = New System.Drawing.Size(78, 13)
        StudentNameLabel.TabIndex = 2
        StudentNameLabel.Text = "Student Name:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(24, 72)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 4
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'EnrollDateLabel
        '
        EnrollDateLabel.AutoSize = True
        EnrollDateLabel.Location = New System.Drawing.Point(43, 101)
        EnrollDateLabel.Name = "EnrollDateLabel"
        EnrollDateLabel.Size = New System.Drawing.Size(62, 13)
        EnrollDateLabel.TabIndex = 6
        EnrollDateLabel.Text = "Enroll Date:"
        '
        'StudentLoanLabel
        '
        StudentLoanLabel.AutoSize = True
        StudentLoanLabel.Location = New System.Drawing.Point(31, 130)
        StudentLoanLabel.Name = "StudentLoanLabel"
        StudentLoanLabel.Size = New System.Drawing.Size(74, 13)
        StudentLoanLabel.TabIndex = 8
        StudentLoanLabel.Text = "Student Loan:"
        '
        'MajorLabel
        '
        MajorLabel.AutoSize = True
        MajorLabel.Location = New System.Drawing.Point(69, 159)
        MajorLabel.Name = "MajorLabel"
        MajorLabel.Size = New System.Drawing.Size(36, 13)
        MajorLabel.TabIndex = 10
        MajorLabel.Text = "Major:"
        '
        'panRecordInformation
        '
        Me.panRecordInformation.Controls.Add(StudentNumberLabel)
        Me.panRecordInformation.Controls.Add(Me.StudentNumberLabel1)
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
        Me.panRecordInformation.Location = New System.Drawing.Point(16, 41)
        Me.panRecordInformation.Name = "panRecordInformation"
        Me.panRecordInformation.Size = New System.Drawing.Size(336, 190)
        Me.panRecordInformation.TabIndex = 4
        Me.panRecordInformation.Visible = False
        '
        'StudentNumberLabel1
        '
        Me.StudentNumberLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "StudentNumber", True))
        Me.StudentNumberLabel1.Location = New System.Drawing.Point(111, 12)
        Me.StudentNumberLabel1.Name = "StudentNumberLabel1"
        Me.StudentNumberLabel1.Size = New System.Drawing.Size(100, 23)
        Me.StudentNumberLabel1.TabIndex = 1
        Me.StudentNumberLabel1.Text = "Label1"
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
        Me.StudentNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "StudentName", True))
        Me.StudentNameTextBox.Location = New System.Drawing.Point(111, 40)
        Me.StudentNameTextBox.Name = "StudentNameTextBox"
        Me.StudentNameTextBox.ReadOnly = True
        Me.StudentNameTextBox.Size = New System.Drawing.Size(163, 20)
        Me.StudentNameTextBox.TabIndex = 3
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(111, 69)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.ReadOnly = True
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(68, 20)
        Me.PhoneNumberTextBox.TabIndex = 5
        '
        'EnrollDateTextBox
        '
        Me.EnrollDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "EnrollDate", True))
        Me.EnrollDateTextBox.Location = New System.Drawing.Point(111, 98)
        Me.EnrollDateTextBox.Name = "EnrollDateTextBox"
        Me.EnrollDateTextBox.ReadOnly = True
        Me.EnrollDateTextBox.Size = New System.Drawing.Size(68, 20)
        Me.EnrollDateTextBox.TabIndex = 7
        '
        'StudentLoanTextBox
        '
        Me.StudentLoanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "StudentLoan", True))
        Me.StudentLoanTextBox.Location = New System.Drawing.Point(111, 127)
        Me.StudentLoanTextBox.Name = "StudentLoanTextBox"
        Me.StudentLoanTextBox.ReadOnly = True
        Me.StudentLoanTextBox.Size = New System.Drawing.Size(68, 20)
        Me.StudentLoanTextBox.TabIndex = 9
        '
        'MajorTextBox
        '
        Me.MajorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "Major", True))
        Me.MajorTextBox.Location = New System.Drawing.Point(111, 156)
        Me.MajorTextBox.Name = "MajorTextBox"
        Me.MajorTextBox.ReadOnly = True
        Me.MajorTextBox.Size = New System.Drawing.Size(53, 20)
        Me.MajorTextBox.TabIndex = 11
        '
        'txtStudentNumberSearch
        '
        Me.txtStudentNumberSearch.Location = New System.Drawing.Point(170, 12)
        Me.txtStudentNumberSearch.MaxLength = 5
        Me.txtStudentNumberSearch.Name = "txtStudentNumberSearch"
        Me.txtStudentNumberSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtStudentNumberSearch.TabIndex = 1
        Me.toolTip.SetToolTip(Me.txtStudentNumberSearch, "Enter Student Number")
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(277, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "&Search"
        Me.toolTip.SetToolTip(Me.btnSearch, "Search for Student Number")
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'LabelStudentNumberSearch
        '
        Me.LabelStudentNumberSearch.AutoSize = True
        Me.LabelStudentNumberSearch.Location = New System.Drawing.Point(13, 13)
        Me.LabelStudentNumberSearch.Name = "LabelStudentNumberSearch"
        Me.LabelStudentNumberSearch.Size = New System.Drawing.Size(151, 13)
        Me.LabelStudentNumberSearch.TabIndex = 0
        Me.LabelStudentNumberSearch.Text = "Student &Number to Search for:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(12, 234)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(196, 20)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Enter the Student Number"
        Me.toolTip.SetToolTip(Me.lblStatus, "Entry Status")
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(300, 237)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(59, 23)
        Me.btnGoBack.TabIndex = 3
        Me.btnGoBack.Text = "Go &Back"
        Me.toolTip.SetToolTip(Me.btnGoBack, "Go to the Navigation Form")
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'TblStudentsTableAdapter
        '
        Me.TblStudentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblStudentsTableAdapter = Me.TblStudentsTableAdapter
        Me.TableAdapterManager.UpdateOrder = _3B_Student_Database.StudDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StudentNumberSearchForm
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 268)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.LabelStudentNumberSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtStudentNumberSearch)
        Me.Controls.Add(Me.panRecordInformation)
        Me.Name = "StudentNumberSearchForm"
        Me.Text = "Record Search"
        Me.panRecordInformation.ResumeLayout(False)
        Me.panRecordInformation.PerformLayout()
        CType(Me.TblStudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panRecordInformation As System.Windows.Forms.Panel
    Friend WithEvents txtStudentNumberSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents LabelStudentNumberSearch As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
    Friend WithEvents StudDataDataSet As _3B_Student_Database.StudDataDataSet
    Friend WithEvents TblStudentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblStudentsTableAdapter As _3B_Student_Database.StudDataDataSetTableAdapters.tblStudentsTableAdapter
    Friend WithEvents TableAdapterManager As _3B_Student_Database.StudDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentNumberLabel1 As System.Windows.Forms.Label
    Friend WithEvents StudentNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnrollDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentLoanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MajorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
End Class
