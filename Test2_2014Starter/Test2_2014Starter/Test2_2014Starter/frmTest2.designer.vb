<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest2
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
        Dim Part_NoLabel As System.Windows.Forms.Label
        Dim Part_DescLabel As System.Windows.Forms.Label
        Dim QOHLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTest2))
        Me.btnSearchHi = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.Part_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Part_tabBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VB_Test2DataSet = New Test2_2013Starter.VB_Test2DataSet()
        Me.Part_DescTextBox = New System.Windows.Forms.TextBox()
        Me.QOHTextBox = New System.Windows.Forms.TextBox()
        Me.btnSearchLo = New System.Windows.Forms.Button()
        Me.Part_tabTableAdapter = New Test2_2013Starter.VB_Test2DataSetTableAdapters.part_tabTableAdapter()
        Me.TableAdapterManager = New Test2_2013Starter.VB_Test2DataSetTableAdapters.TableAdapterManager()
        Me.lblStatus = New System.Windows.Forms.Label()
        Part_NoLabel = New System.Windows.Forms.Label()
        Part_DescLabel = New System.Windows.Forms.Label()
        QOHLabel = New System.Windows.Forms.Label()
        Me.grpInfo.SuspendLayout()
        CType(Me.Part_tabBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VB_Test2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Part_NoLabel
        '
        Part_NoLabel.AutoSize = True
        Part_NoLabel.Location = New System.Drawing.Point(168, 32)
        Part_NoLabel.Name = "Part_NoLabel"
        Part_NoLabel.Size = New System.Drawing.Size(46, 13)
        Part_NoLabel.TabIndex = 5
        Part_NoLabel.Text = "Part No:"
        '
        'Part_DescLabel
        '
        Part_DescLabel.AutoSize = True
        Part_DescLabel.Location = New System.Drawing.Point(168, 58)
        Part_DescLabel.Name = "Part_DescLabel"
        Part_DescLabel.Size = New System.Drawing.Size(57, 13)
        Part_DescLabel.TabIndex = 7
        Part_DescLabel.Text = "Part Desc:"
        '
        'QOHLabel
        '
        QOHLabel.AutoSize = True
        QOHLabel.Location = New System.Drawing.Point(168, 84)
        QOHLabel.Name = "QOHLabel"
        QOHLabel.Size = New System.Drawing.Size(34, 13)
        QOHLabel.TabIndex = 9
        QOHLabel.Text = "QOH:"
        '
        'btnSearchHi
        '
        Me.btnSearchHi.Location = New System.Drawing.Point(308, 112)
        Me.btnSearchHi.Name = "btnSearchHi"
        Me.btnSearchHi.Size = New System.Drawing.Size(100, 24)
        Me.btnSearchHi.TabIndex = 34
        Me.btnSearchHi.Text = "Search Higher"
        Me.btnSearchHi.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Quantity to Compare:"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(263, 77)
        Me.txtsearch.MaxLength = 5
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(100, 20)
        Me.txtsearch.TabIndex = 32
        Me.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(130, 27)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(294, 25)
        Me.lblHeading.TabIndex = 31
        Me.lblHeading.Text = "Test #2 by William Villeneuve"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(244, 154)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 50)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Forward"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(446, 401)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 56)
        Me.btnExit.TabIndex = 37
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(343, 401)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 56)
        Me.btnDone.TabIndex = 36
        Me.btnDone.Text = "Reset"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnSub
        '
        Me.btnSub.Location = New System.Drawing.Point(136, 154)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(80, 50)
        Me.btnSub.TabIndex = 4
        Me.btnSub.Text = "Back"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Part_NoLabel)
        Me.grpInfo.Controls.Add(Me.Part_NoTextBox)
        Me.grpInfo.Controls.Add(Part_DescLabel)
        Me.grpInfo.Controls.Add(Me.Part_DescTextBox)
        Me.grpInfo.Controls.Add(QOHLabel)
        Me.grpInfo.Controls.Add(Me.QOHTextBox)
        Me.grpInfo.Controls.Add(Me.btnAdd)
        Me.grpInfo.Controls.Add(Me.btnSub)
        Me.grpInfo.Location = New System.Drawing.Point(38, 155)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(484, 224)
        Me.grpInfo.TabIndex = 35
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Parts Information"
        Me.grpInfo.Visible = False
        '
        'Part_NoTextBox
        '
        Me.Part_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Part_tabBindingSource, "Part_No", True))
        Me.Part_NoTextBox.Location = New System.Drawing.Point(231, 29)
        Me.Part_NoTextBox.Name = "Part_NoTextBox"
        Me.Part_NoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Part_NoTextBox.TabIndex = 6
        '
        'Part_tabBindingSource
        '
        Me.Part_tabBindingSource.DataMember = "part_tab"
        Me.Part_tabBindingSource.DataSource = Me.VB_Test2DataSet
        '
        'VB_Test2DataSet
        '
        Me.VB_Test2DataSet.DataSetName = "VB_Test2DataSet"
        Me.VB_Test2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Part_DescTextBox
        '
        Me.Part_DescTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Part_tabBindingSource, "Part_Desc", True))
        Me.Part_DescTextBox.Location = New System.Drawing.Point(231, 55)
        Me.Part_DescTextBox.Name = "Part_DescTextBox"
        Me.Part_DescTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Part_DescTextBox.TabIndex = 8
        '
        'QOHTextBox
        '
        Me.QOHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Part_tabBindingSource, "QOH", True))
        Me.QOHTextBox.Location = New System.Drawing.Point(231, 81)
        Me.QOHTextBox.Name = "QOHTextBox"
        Me.QOHTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QOHTextBox.TabIndex = 10
        '
        'btnSearchLo
        '
        Me.btnSearchLo.Location = New System.Drawing.Point(183, 112)
        Me.btnSearchLo.Name = "btnSearchLo"
        Me.btnSearchLo.Size = New System.Drawing.Size(100, 24)
        Me.btnSearchLo.TabIndex = 38
        Me.btnSearchLo.Text = "Search Lower"
        Me.btnSearchLo.UseVisualStyleBackColor = True
        '
        'Part_tabTableAdapter
        '
        Me.Part_tabTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.part_tabTableAdapter = Me.Part_tabTableAdapter
        Me.TableAdapterManager.UpdateOrder = Test2_2013Starter.VB_Test2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(38, 386)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 39
        '
        'frmTest2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 483)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnSearchLo)
        Me.Controls.Add(Me.btnSearchHi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.grpInfo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmTest2"
        Me.Text = "Test #2"
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        CType(Me.Part_tabBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VB_Test2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearchHi As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnSub As System.Windows.Forms.Button
    Friend WithEvents grpInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchLo As System.Windows.Forms.Button
    Friend WithEvents VB_Test2DataSet As Test2_2013Starter.VB_Test2DataSet
    Friend WithEvents Part_tabBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Part_tabTableAdapter As Test2_2013Starter.VB_Test2DataSetTableAdapters.part_tabTableAdapter
    Friend WithEvents TableAdapterManager As Test2_2013Starter.VB_Test2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Part_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Part_DescTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QOHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
End Class
