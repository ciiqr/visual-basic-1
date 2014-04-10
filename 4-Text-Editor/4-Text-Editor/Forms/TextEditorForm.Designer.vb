<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextEditorForm
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
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFilePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEditSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEditToUppercase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditToLowercase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditToTitlecase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewWordWrap = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuViewFullscreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuViewStatusBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpIndex = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHelpResetSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusBar = New System.Windows.Forms.StatusStrip()
        Me.statusLblFileName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusLblContentInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.mnuStrip.SuspendLayout()
        Me.statusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuView, Me.mnuHelp})
        Me.mnuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(829, 23)
        Me.mnuStrip.TabIndex = 0
        Me.mnuStrip.Text = "MenuStrip"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileOpen, Me.ToolStripSeparator1, Me.mnuFileSave, Me.mnuFileSaveAs, Me.ToolStripSeparator2, Me.mnuFilePrint, Me.ToolStripSeparator8, Me.mnuFileClose, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 19)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileOpen.Size = New System.Drawing.Size(186, 22)
        Me.mnuFileOpen.Text = "Open"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(183, 6)
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Enabled = False
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(186, 22)
        Me.mnuFileSave.Text = "Save"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(186, 22)
        Me.mnuFileSaveAs.Text = "Save As"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(183, 6)
        '
        'mnuFilePrint
        '
        Me.mnuFilePrint.Enabled = False
        Me.mnuFilePrint.Name = "mnuFilePrint"
        Me.mnuFilePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuFilePrint.Size = New System.Drawing.Size(186, 22)
        Me.mnuFilePrint.Text = "Print"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(183, 6)
        '
        'mnuFileClose
        '
        Me.mnuFileClose.Name = "mnuFileClose"
        Me.mnuFileClose.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.mnuFileClose.Size = New System.Drawing.Size(186, 22)
        Me.mnuFileClose.Text = "Close"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(186, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditCut, Me.mnuEditCopy, Me.mnuEditPaste, Me.ToolStripSeparator5, Me.mnuEditSelectAll, Me.ToolStripSeparator3, Me.mnuEditToUppercase, Me.mnuEditToLowercase, Me.mnuEditToTitlecase})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 19)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEditCut.Size = New System.Drawing.Size(194, 22)
        Me.mnuEditCut.Text = "Cut"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEditCopy.Size = New System.Drawing.Size(194, 22)
        Me.mnuEditCopy.Text = "Copy"
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEditPaste.Size = New System.Drawing.Size(194, 22)
        Me.mnuEditPaste.Text = "Paste"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(191, 6)
        '
        'mnuEditSelectAll
        '
        Me.mnuEditSelectAll.Name = "mnuEditSelectAll"
        Me.mnuEditSelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuEditSelectAll.Size = New System.Drawing.Size(194, 22)
        Me.mnuEditSelectAll.Text = "Select All"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(191, 6)
        '
        'mnuEditToUppercase
        '
        Me.mnuEditToUppercase.Name = "mnuEditToUppercase"
        Me.mnuEditToUppercase.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.mnuEditToUppercase.Size = New System.Drawing.Size(194, 22)
        Me.mnuEditToUppercase.Text = "TO UPPERCASE"
        '
        'mnuEditToLowercase
        '
        Me.mnuEditToLowercase.Name = "mnuEditToLowercase"
        Me.mnuEditToLowercase.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mnuEditToLowercase.Size = New System.Drawing.Size(194, 22)
        Me.mnuEditToLowercase.Text = "to lowercase"
        '
        'mnuEditToTitlecase
        '
        Me.mnuEditToTitlecase.Name = "mnuEditToTitlecase"
        Me.mnuEditToTitlecase.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.mnuEditToTitlecase.Size = New System.Drawing.Size(194, 22)
        Me.mnuEditToTitlecase.Text = "To Titlecase"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewWordWrap, Me.mnuViewFont, Me.ToolStripSeparator4, Me.mnuViewFullscreen, Me.ToolStripSeparator6, Me.mnuViewStatusBar})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(44, 19)
        Me.mnuView.Text = "&View"
        '
        'mnuViewWordWrap
        '
        Me.mnuViewWordWrap.CheckOnClick = True
        Me.mnuViewWordWrap.Name = "mnuViewWordWrap"
        Me.mnuViewWordWrap.Size = New System.Drawing.Size(152, 22)
        Me.mnuViewWordWrap.Text = "Word Wrap"
        '
        'mnuViewFont
        '
        Me.mnuViewFont.Name = "mnuViewFont"
        Me.mnuViewFont.Size = New System.Drawing.Size(152, 22)
        Me.mnuViewFont.Text = "Font"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'mnuViewFullscreen
        '
        Me.mnuViewFullscreen.Name = "mnuViewFullscreen"
        Me.mnuViewFullscreen.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.mnuViewFullscreen.Size = New System.Drawing.Size(152, 22)
        Me.mnuViewFullscreen.Text = "Fullscreen"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(149, 6)
        '
        'mnuViewStatusBar
        '
        Me.mnuViewStatusBar.CheckOnClick = True
        Me.mnuViewStatusBar.Name = "mnuViewStatusBar"
        Me.mnuViewStatusBar.Size = New System.Drawing.Size(152, 22)
        Me.mnuViewStatusBar.Text = "Status Bar"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpIndex, Me.mnuHelpAbout, Me.ToolStripSeparator7, Me.mnuHelpResetSettings})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 19)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpIndex
        '
        Me.mnuHelpIndex.Name = "mnuHelpIndex"
        Me.mnuHelpIndex.Size = New System.Drawing.Size(152, 22)
        Me.mnuHelpIndex.Text = "Index"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(152, 22)
        Me.mnuHelpAbout.Text = "About"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(149, 6)
        '
        'mnuHelpResetSettings
        '
        Me.mnuHelpResetSettings.Name = "mnuHelpResetSettings"
        Me.mnuHelpResetSettings.Size = New System.Drawing.Size(152, 22)
        Me.mnuHelpResetSettings.Text = "Reset Settings"
        '
        'statusBar
        '
        Me.statusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLblFileName, Me.statusLblContentInfo})
        Me.statusBar.Location = New System.Drawing.Point(0, 525)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Size = New System.Drawing.Size(829, 22)
        Me.statusBar.TabIndex = 1
        Me.statusBar.Text = "StatusStrip"
        '
        'statusLblFileName
        '
        Me.statusLblFileName.Name = "statusLblFileName"
        Me.statusLblFileName.Size = New System.Drawing.Size(662, 17)
        Me.statusLblFileName.Spring = True
        Me.statusLblFileName.Text = "Open a File"
        Me.statusLblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'statusLblContentInfo
        '
        Me.statusLblContentInfo.Name = "statusLblContentInfo"
        Me.statusLblContentInfo.Size = New System.Drawing.Size(121, 17)
        Me.statusLblContentInfo.Text = "0 Characters, 0 Words"
        '
        'txtContent
        '
        Me.txtContent.AcceptsTab = True
        Me.txtContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent.Location = New System.Drawing.Point(0, 23)
        Me.txtContent.MaxLength = 2147483647
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtContent.Size = New System.Drawing.Size(829, 502)
        Me.txtContent.TabIndex = 2
        '
        'TextEditorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 547)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.statusBar)
        Me.Controls.Add(Me.mnuStrip)
        Me.MainMenuStrip = Me.mnuStrip
        Me.Name = "TextEditorForm"
        Me.Text = "William's Text Editor - Lab 4"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.statusBar.ResumeLayout(False)
        Me.statusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFileClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuEditToUppercase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditToLowercase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditToTitlecase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewFont As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewStatusBar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpIndex As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents statusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents statusLblFileName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuEditSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewWordWrap As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents statusLblContentInfo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuViewFullscreen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuHelpResetSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFilePrint As System.Windows.Forms.ToolStripMenuItem

End Class
