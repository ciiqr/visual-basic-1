<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentDatabaseForm
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
        Me.btnBrowseDataGrid = New System.Windows.Forms.Button()
        Me.btnBrowseRecordByRecord = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSearchStudentNumber = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBrowseDataGrid
        '
        Me.btnBrowseDataGrid.Location = New System.Drawing.Point(135, 66)
        Me.btnBrowseDataGrid.Name = "btnBrowseDataGrid"
        Me.btnBrowseDataGrid.Size = New System.Drawing.Size(124, 43)
        Me.btnBrowseDataGrid.TabIndex = 0
        Me.btnBrowseDataGrid.Text = "Browse &DataGrid"
        Me.toolTip.SetToolTip(Me.btnBrowseDataGrid, "View the Databse in a Table")
        Me.btnBrowseDataGrid.UseVisualStyleBackColor = True
        '
        'btnBrowseRecordByRecord
        '
        Me.btnBrowseRecordByRecord.Location = New System.Drawing.Point(135, 146)
        Me.btnBrowseRecordByRecord.Name = "btnBrowseRecordByRecord"
        Me.btnBrowseRecordByRecord.Size = New System.Drawing.Size(124, 43)
        Me.btnBrowseRecordByRecord.TabIndex = 1
        Me.btnBrowseRecordByRecord.Text = "Browse &Record by Record"
        Me.toolTip.SetToolTip(Me.btnBrowseRecordByRecord, "View the Databse One Record at a time")
        Me.btnBrowseRecordByRecord.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(135, 306)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 43)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "&Exit"
        Me.toolTip.SetToolTip(Me.btnExit, "Close the Application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSearchStudentNumber
        '
        Me.btnSearchStudentNumber.Location = New System.Drawing.Point(135, 226)
        Me.btnSearchStudentNumber.Name = "btnSearchStudentNumber"
        Me.btnSearchStudentNumber.Size = New System.Drawing.Size(124, 43)
        Me.btnSearchStudentNumber.TabIndex = 3
        Me.btnSearchStudentNumber.Text = "&Search by Student Number"
        Me.toolTip.SetToolTip(Me.btnSearchStudentNumber, "View the Databse One Record at a time")
        Me.btnSearchStudentNumber.UseVisualStyleBackColor = True
        '
        'StudentDatabaseForm
        '
        Me.AcceptButton = Me.btnBrowseDataGrid
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 414)
        Me.Controls.Add(Me.btnSearchStudentNumber)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBrowseRecordByRecord)
        Me.Controls.Add(Me.btnBrowseDataGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "StudentDatabaseForm"
        Me.Text = "3B - Student Database Viewer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBrowseDataGrid As System.Windows.Forms.Button
    Friend WithEvents btnBrowseRecordByRecord As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnSearchStudentNumber As System.Windows.Forms.Button

End Class
