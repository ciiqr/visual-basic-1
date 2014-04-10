<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentDatagridForm
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
        Me.StudDataDataSet = New _3B_Student_Database.StudDataDataSet()
        Me.TblStudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblStudentsTableAdapter = New _3B_Student_Database.StudDataDataSetTableAdapters.tblStudentsTableAdapter()
        Me.TableAdapterManager = New _3B_Student_Database.StudDataDataSetTableAdapters.TableAdapterManager()
        Me.TblStudentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpSortBy = New System.Windows.Forms.GroupBox()
        Me.rdoSortByMajor = New System.Windows.Forms.RadioButton()
        Me.rdoSortByName = New System.Windows.Forms.RadioButton()
        Me.rdoSortByNumber = New System.Windows.Forms.RadioButton()
        CType(Me.StudDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStudentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSortBy.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.UpdateOrder = _3B_Student_Database.StudDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblStudentsDataGridView
        '
        Me.TblStudentsDataGridView.AllowUserToAddRows = False
        Me.TblStudentsDataGridView.AllowUserToDeleteRows = False
        Me.TblStudentsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblStudentsDataGridView.AutoGenerateColumns = False
        Me.TblStudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblStudentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TblStudentsDataGridView.DataSource = Me.TblStudentsBindingSource
        Me.TblStudentsDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.TblStudentsDataGridView.Name = "TblStudentsDataGridView"
        Me.TblStudentsDataGridView.ReadOnly = True
        Me.TblStudentsDataGridView.Size = New System.Drawing.Size(643, 307)
        Me.TblStudentsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StudentNumber"
        Me.DataGridViewTextBoxColumn1.HeaderText = "StudentNumber"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StudentName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StudentName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PhoneNumber"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PhoneNumber"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EnrollDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "EnrollDate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "StudentLoan"
        Me.DataGridViewTextBoxColumn5.HeaderText = "StudentLoan"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Major"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Major"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'btnGoBack
        '
        Me.btnGoBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGoBack.Location = New System.Drawing.Point(531, 325)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(124, 43)
        Me.btnGoBack.TabIndex = 2
        Me.btnGoBack.Text = "Go &Back"
        Me.toolTip.SetToolTip(Me.btnGoBack, "Go to the Navigation Form")
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'grpSortBy
        '
        Me.grpSortBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpSortBy.Controls.Add(Me.rdoSortByMajor)
        Me.grpSortBy.Controls.Add(Me.rdoSortByName)
        Me.grpSortBy.Controls.Add(Me.rdoSortByNumber)
        Me.grpSortBy.Location = New System.Drawing.Point(12, 325)
        Me.grpSortBy.Name = "grpSortBy"
        Me.grpSortBy.Size = New System.Drawing.Size(201, 43)
        Me.grpSortBy.TabIndex = 3
        Me.grpSortBy.TabStop = False
        Me.grpSortBy.Text = "Sort By"
        '
        'rdoSortByMajor
        '
        Me.rdoSortByMajor.AutoSize = True
        Me.rdoSortByMajor.Location = New System.Drawing.Point(142, 20)
        Me.rdoSortByMajor.Name = "rdoSortByMajor"
        Me.rdoSortByMajor.Size = New System.Drawing.Size(51, 17)
        Me.rdoSortByMajor.TabIndex = 2
        Me.rdoSortByMajor.Text = "Major"
        Me.rdoSortByMajor.UseVisualStyleBackColor = True
        '
        'rdoSortByName
        '
        Me.rdoSortByName.AutoSize = True
        Me.rdoSortByName.Location = New System.Drawing.Point(79, 20)
        Me.rdoSortByName.Name = "rdoSortByName"
        Me.rdoSortByName.Size = New System.Drawing.Size(53, 17)
        Me.rdoSortByName.TabIndex = 1
        Me.rdoSortByName.Text = "Name"
        Me.rdoSortByName.UseVisualStyleBackColor = True
        '
        'rdoSortByNumber
        '
        Me.rdoSortByNumber.AutoSize = True
        Me.rdoSortByNumber.Checked = True
        Me.rdoSortByNumber.Location = New System.Drawing.Point(7, 20)
        Me.rdoSortByNumber.Name = "rdoSortByNumber"
        Me.rdoSortByNumber.Size = New System.Drawing.Size(62, 17)
        Me.rdoSortByNumber.TabIndex = 0
        Me.rdoSortByNumber.TabStop = True
        Me.rdoSortByNumber.Text = "Number"
        Me.rdoSortByNumber.UseVisualStyleBackColor = True
        '
        'StudentDatagridForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 380)
        Me.Controls.Add(Me.grpSortBy)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.TblStudentsDataGridView)
        Me.Name = "StudentDatagridForm"
        Me.Text = "Display Records by Datagrid"
        CType(Me.StudDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStudentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSortBy.ResumeLayout(False)
        Me.grpSortBy.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StudDataDataSet As _3B_Student_Database.StudDataDataSet
    Friend WithEvents TblStudentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblStudentsTableAdapter As _3B_Student_Database.StudDataDataSetTableAdapters.tblStudentsTableAdapter
    Friend WithEvents TableAdapterManager As _3B_Student_Database.StudDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblStudentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents grpSortBy As System.Windows.Forms.GroupBox
    Friend WithEvents rdoSortByMajor As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSortByName As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSortByNumber As System.Windows.Forms.RadioButton
End Class
