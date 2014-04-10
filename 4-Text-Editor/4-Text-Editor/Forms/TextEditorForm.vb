' 
' Name:         Awesome Text Editor - 4
'
' Author:       William Villeneuve
' Date:         March 24, 2014
' 
' Description:  Windows forms application which allows the editing and creation of text files.
'               Keyboard shortcuts on the form allows easy navigation.
'               Some of the features include:
'                   - Printing
'                   - Cut/Copy/Paste
'                   - Help/About Dialogs.
'                   - Enabling / Disabling of Save & Print Menu Items When Not 
'                   - Menu Bar
'                   - Status Bar
'                   - Optional: Prompt to save current file when closing, exiting, or openning new files
'               Some of the additional features not required for the lab include:
'                   - Print Preview
'                   - Convert Case (UPPER, lower and Title Case)
'                   - Select All
'                   - Fullscreen Mode
'                   - Toggleable Word Wrapping
'                   - Font Selection
'                   - Toggleable Status Bar
'                   - Saving of sattings for Word Wrap, Font and Status Bar Visibility
'                   - Resetting Settings
'                   - Creation of Documents without first opening a file (Will prompt for file name when saved)
' 

'' Namespaces ''
Imports System.IO ' For File Streams
Imports System.Drawing.Printing ' For Printing Documents

Public Class TextEditorForm

#Region "Declarations"
#Region "Constants"
    ' File Type Filter for The Open & Save As Dialogs
    Const FILE_FILTER As String = "Text Files|*.txt|Batch Files|*.bat;*.cmd|Visual Basic Files|*.vb|Header Files|*.h;*.hpp|C++ Files|*.cpp;*.cc;|All Files|*"

    ' Whether to display header info on every page when printing
    ' - TODO: Future, Change to be a setting and add a menu item OR an option some other way
    Const PRINT_TITLE_ON_ALL_PAGES As Boolean = False
#End Region ' Constants

#Region "Variables"
    ' FileName - If Empty, File has not been opened, though if they've entered something, still allow saving (As)
    Dim filePath As String = ""

    ' Page Printing Offset
    Dim pagePrintingOffset As Integer = 0
#End Region ' Variables

#Region "Functions"
    ' A type of function that takes a string as a parameter & returns a string in return
    ' - Usually the same string just formatted
    Delegate Function StringFormatFunction(text As String) As String
#End Region ' Functions

#End Region ' Declarations

#Region "Functions"
    Public Function ToUpperCase(text As String) As String
        Return text.ToUpper()
    End Function

    Public Function ToLowerCase(text As String) As String
        Return text.ToLower()
    End Function

    Public Function ToTitleCase(text As String) As String
        ' TODO: Fix Bug, any selected word that is uppercase, doesnt get converted to title case, if it is lower or mixed then its fine

        ' Current Culture
        Dim curCulture As Globalization.CultureInfo = Threading.Thread.CurrentThread.CurrentCulture
        ' Text Info
        Dim tInfo As Globalization.TextInfo = curCulture.TextInfo()
        ' Return Converted String
        Return tInfo.ToTitleCase(text)
    End Function

    Private Function WordCount(text As String) As Integer
        ' Based on code borrowed from George Birbilis's C# Example on StackOverflow

        ' Index of the last character in the string
        Dim lastIndex As Integer = text.Length - 1
        ' Number of words calculated
        Dim numberOfWords As Integer = 0

        ' Itterate Characters
        For index As Integer = 0 To lastIndex
            ' Is a Letter/Digit AND one of: is last character, next character is whitespace or next character is punctuation
            If Char.IsLetterOrDigit(text(index)) AndAlso ((index = lastIndex) OrElse Char.IsWhiteSpace(text(index + 1)) OrElse Char.IsPunctuation(text(index + 1))) Then
                ' Found another Word, Increase Count
                numberOfWords += 1
            End If
        Next

        ' Return Number of Words
        Return numberOfWords
    End Function
#End Region ' Functions

#Region "Methods"

    Private Sub promptSaveFileIfNeeded()
        ' Opened File has Changed and either an actual file is open OR there is actually content in the textbox
        If txtContent.Modified And (filePath.Length > 0 Or txtContent.Text.Length > 0) Then
            ' Promp whether to save changes
            Select Case MessageBox.Show("This file has changed since you last saved it.", "Save Changes?", MessageBoxButtons.YesNoCancel)
                Case DialogResult.Yes
                    ' Save Changes First
                    saveFile() ' Successful Save will set txtContent.Modified to false

                Case DialogResult.No
                    ' Don't Save Changes
                    txtContent.Modified = False

            End Select
        Else ' Really Nothing to Save
            txtContent.Modified = False
        End If
    End Sub

    Private Sub saveFile()
        If filePath.Length > 0 Then ' File is Open
            Try
                ' Create File Writer
                Dim fileWriter As New StreamWriter(filePath, False)
                ' Write Data
                fileWriter.Write(txtContent.Text)
                ' Close Stream
                fileWriter.Close()

                ' File is saved so it is no longer modified
                txtContent.Modified = False
            Catch ex As Exception
                ' Errors Occured
                MessageBox.Show("Failed to save the file, please try again.")
            End Try

        ElseIf txtContent.Text.Length > 0 Then ' User has entered something before opening a file & there is still something to save
            ' Prompt User to Save As
            saveFileAs()
        End If
    End Sub

    Private Sub saveFileAs()
        ' Create Save File Dialog
        Dim saveDialog As SaveFileDialog = New SaveFileDialog

        ' File Extension Filter
        saveDialog.Filter = FILE_FILTER

        ' If fileName is not set then this may fail
        Try
            ' Set Current File Path
            saveDialog.InitialDirectory = Path.GetDirectoryName(filePath)

        Catch ex As ArgumentException
            ' Problem Getting File Path from fileName
            ' Most Often Cause No File has been Opened
            ' We catch this exception because we do not want issues saving when a file has not been opened first
        End Try
        ' Set Current File Name
        saveDialog.FileName = Path.GetFileName(filePath)

        ' Show Save File Dialog
        Dim result = saveDialog.ShowDialog()

        ' See if OK was pressed.
        If result = DialogResult.OK Then
            ' Get New File Name
            filePath = saveDialog.FileName

            ' Save File
            saveFile()

            ' Display File Name
            statusLblFileName.Text = filePath
        End If
    End Sub

    Private Sub toggleFullscreen()
        If TopMost Then ' Fullscreen Already
            ' No Border
            FormBorderStyle = FormBorderStyle.Sizable

            ' Maximized
            WindowState = FormWindowState.Normal

            ' Top Most
            TopMost = False
        Else ' Make Fullscreen
            ' No Border
            FormBorderStyle = FormBorderStyle.None

            ' Maximized
            WindowState = FormWindowState.Maximized

            ' Top Most
            TopMost = True
        End If
    End Sub

    Private Sub loadSettings()
        ' Whether Status Bar is Visible
        Dim statusBarVisible As Boolean = TextEditorState.Default.StatusBarVisible
        ' Whether Word Wrap is Enabled
        Dim contentWordWrap As Boolean = TextEditorState.Default.ContentWordWrap

        ' Load

        ' Font
        txtContent.Font = TextEditorState.Default.ContentFont

        ' Status Bar Visibility
        mnuViewStatusBar.Checked = statusBarVisible
        statusBar.Visible = statusBarVisible

        ' Word Wrapping
        mnuViewWordWrap.Checked = contentWordWrap
        txtContent.WordWrap = contentWordWrap
    End Sub

    Private Sub printDocumentPage(sender As Object, e As PrintPageEventArgs)
        ' Constants
        Const SEPARATOR As Char = "="

        ' Local References
        ' Page Content
        Dim content As String = txtContent.Text.Substring(pagePrintingOffset)
        ' Page Font
        Dim font As Font = txtContent.Font
        ' Page Bounds
        Dim pageBounds As RectangleF = e.PageSettings.Bounds
        ' Page Margins
        Dim pageMargins As Margins = e.PageSettings.Margins

        ' Header Font
        Dim headerFont As Font = New Font(font, FontStyle.Italic)

        ' Content Offsets
        Dim contentX As Integer = pageMargins.Left
        Dim contentY As Integer = pageMargins.Top

        ' Page Dimensions
        Dim pageWidth As Single = pageBounds.Width - pageMargins.Left - pageMargins.Right
        Dim pageHeight As Single = pageBounds.Height - pageMargins.Top - pageMargins.Bottom

        ' Characters On Page, used to determine if there is any text that needs to be printed on a new page
        Dim charactersOnPage As Integer = 0

        ' Print Header if it is a saved file and either all page titles are enabled OR it is the first page
        If filePath.Length > 0 And (PRINT_TITLE_ON_ALL_PAGES Or pagePrintingOffset = 0) Then
            ' Determine How Many seperator characters are needed
            Dim separatorText As String = New String(SEPARATOR, pageBounds.Width / e.Graphics.MeasureString(SEPARATOR, headerFont).Width)
            ' File Name
            Dim headerText As String = Path.GetFileName(filePath) & vbCrLf & separatorText

            ' Determine header offset
            Dim headerHeight As Integer = font.Height * 2

            ' Draw header (Before contentY changes)
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, New RectangleF(contentX, contentY, pageWidth, pageHeight))

            ' Add Header Offset to content offset & subtract from page height
            contentY += headerHeight
            pageHeight -= headerHeight
        End If

        ' Calculates the number of Characters On the Page
        e.Graphics.MeasureString(content, font, New SizeF(pageWidth, pageHeight), StringFormat.GenericTypographic, charactersOnPage, vbNull)

        ' Draw Content
        e.Graphics.DrawString(content, font, Brushes.Black, New RectangleF(contentX, contentY, pageWidth, pageHeight), StringFormat.GenericTypographic)

        ' Set Printing Offset for next page (The characters on page is not percisly what I need here, add 3 cause that fixes problems)
        pagePrintingOffset += charactersOnPage

        ' Remove the portion of the string that has been printed.
        content = content.Substring(charactersOnPage)

        ' Check to see if more pages are to be printed.
        e.HasMorePages = content.Length > 0

        ' If the last page, reset the offset
        If Not e.HasMorePages Then
            ' Reset Starting offset (For Next Time)
            pagePrintingOffset = 0
        End If

    End Sub
#Region "ContentTextBox"
    Private Sub markupSelectionWithFunction(markupFunction As StringFormatFunction)
        ' Store Selection Position
        Dim selectionStartingPosition As Integer = txtContent.SelectionStart
        Dim selectionLength As Integer = txtContent.SelectionLength

        ' Set Text to be Current Text Up To Selection, Selected Text to Uppered, current text after selection
        txtContent.Text = txtContent.Text.Substring(0, txtContent.SelectionStart) & markupFunction(txtContent.SelectedText()) & txtContent.Text.Substring(txtContent.SelectionStart + txtContent.SelectionLength)

        ' ReStore Selection
        txtContent.Select(selectionStartingPosition, selectionLength)

        ' Scroll Selection Visible
        txtContent.ScrollToCaret()

        ' Text is Modified
        '  - For some reason is not set to true when marking up text, maybe it case insensitively compares the old & new text?
        txtContent.Modified = True
    End Sub

    Private Sub txtContent_TextChanged(sender As Object, e As EventArgs) Handles txtContent.TextChanged
        ' User has mad changes to the current file
        txtContent.Modified = True

        ' Display Character Count & Word Count
        ' - ToString("N0") is so that commas are displayed (ie. 123,456)
        statusLblContentInfo.Text = txtContent.TextLength.ToString("N0") & " Characters, " & WordCount(txtContent.Text).ToString("N0") & " Words"

        ' When file is open, save/print are always available
        ' When file is closed, save is only available when some text is entered
        If (filePath.Length > 0) Or (txtContent.Text.Length > 0) Then
            ' Enable Save & Print Items
            mnuFileSave.Enabled = True
            mnuFilePrint.Enabled = True
        Else ' File is not open & There is no text
            ' Disable Save & Print Items
            mnuFileSave.Enabled = False
            mnuFilePrint.Enabled = False
        End If
    End Sub
#End Region ' ContentTextBox

#Region "Form"
    Private Sub TextEditorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Form Settings
        loadSettings()
    End Sub

    Private Sub TextEditorForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Prompt Save if Needed
        promptSaveFileIfNeeded()
        ' Save Wasn't Successful or Canceled
        If txtContent.Modified Then
            ' Prevent Closing
            e.Cancel = True
        End If
    End Sub
#End Region ' Form

#Region "Menu"
    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        ' Promp whether to save changes if needed
        promptSaveFileIfNeeded()

        ' Only if file is not open
        If Not txtContent.Modified Then
            ' Create Open File Dialog
            Dim openDialog As OpenFileDialog = New OpenFileDialog

            ' File Extension Filter
            openDialog.Filter = FILE_FILTER

            ' Show Open File Dialog
            Dim result = openDialog.ShowDialog()

            ' See if OK was pressed.
            If result = DialogResult.OK Then
                ' Get File Name
                filePath = openDialog.FileName

                Try
                    ' Open File
                    Dim fileReader As StreamReader = New StreamReader(filePath)

                    ' Read Data
                    txtContent.Text = fileReader.ReadToEnd()

                    ' Close Stream
                    fileReader.Close()

                    ' Display File Name
                    statusLblFileName.Text = filePath
                Catch ex As Exception
                    ' Display Error, Could Not Open File
                    MessageBox.Show("Could Not Open File")
                End Try

            End If
        End If
    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        ' Save File (Saves file As if no file is openned)
        saveFile()
    End Sub

    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        ' Save file As
        saveFileAs()
    End Sub

    Private Sub mnuFilePrint_Click(sender As Object, e As EventArgs) Handles mnuFilePrint.Click
        ' Printer Settings Dialog
        Dim printDialog As PrintDialog = New PrintDialog
        ' Print Document
        Dim printDocument As New PrintDocument
        ' Add Draw Page Handler (Done this way so that printDocument doesn't need to be a class wide variable)
        AddHandler printDocument.PrintPage, AddressOf printDocumentPage

        ' Set Initial Printer Settigns
        printDialog.PrinterSettings = printDocument.PrinterSettings

        ' Get Info
        If printDialog.ShowDialog() = DialogResult.OK Then ' Printer Selected
            ' Get Printer Settings
            printDocument.PrinterSettings = printDialog.PrinterSettings

            ' Print Preview Dialog
            Dim printPreviewDialog As New PrintPreviewDialog

            ' Set its Document
            printPreviewDialog.Document = printDocument

            ' Display Print Preview Dialog
            printPreviewDialog.ShowDialog()

            ' Reset Starting offset (For Next Time)
            ' Cannot be here because printDocumentPage is called for the preview & when actually printing, this must be reset within printDocumentPage
            ' pagePrintingOffset = 0
        End If
    End Sub

    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        ' Prompt Save if Needed
        promptSaveFileIfNeeded()

        ' Changes are Saved
        If Not txtContent.Modified Then
            ' Clear Out Textbox
            txtContent.Clear()

            ' Reset File Name
            filePath = ""

            ' Reset Status
            statusLblFileName.Text = "Open a File"
        End If
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        ' Exits the Application
        ' Potentially Canceled in Event Handlers
        Close()
    End Sub


    Private Sub mnuEditCut_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click
        ' Cut selected text from textbox
        txtContent.Cut()
    End Sub

    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click
        ' Copy text from textbox
        txtContent.Copy()
    End Sub

    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click
        ' Paste text into textbox
        txtContent.Paste()
    End Sub

    Private Sub mnuEditSelectAll_Click(sender As Object, e As EventArgs) Handles mnuEditSelectAll.Click
        ' Select all text
        txtContent.SelectAll()
    End Sub

    Private Sub mnuEditToUppercase_Click(sender As Object, e As EventArgs) Handles mnuEditToUppercase.Click
        ' Markup Selected Text With Uppercase Characters
        markupSelectionWithFunction(AddressOf ToUpperCase)
    End Sub

    Private Sub mnuEditToLowercase_Click(sender As Object, e As EventArgs) Handles mnuEditToLowercase.Click
        ' Markup Selected Text With Lowercase Characters
        markupSelectionWithFunction(AddressOf ToLowerCase)
    End Sub

    Private Sub mnuEditToTitlecase_Click(sender As Object, e As EventArgs) Handles mnuEditToTitlecase.Click
        ' Markup Selected Text With Title Characters
        markupSelectionWithFunction(AddressOf ToTitleCase)
    End Sub


    Private Sub mnuViewWordWrap_CheckedChanged(sender As Object, e As EventArgs) Handles mnuViewWordWrap.CheckedChanged
        ' Whether Word Wrap is Enabled
        Dim contentWordWrap As Boolean = mnuViewWordWrap.Checked

        ' (En/Dis)able Word Wrapping
        txtContent.WordWrap = contentWordWrap

        ' Save Font in Setting
        TextEditorState.Default.ContentWordWrap = contentWordWrap
        ' Save Settings
        TextEditorState.Default.Save()
    End Sub

    Private Sub mnuViewFont_Click(sender As Object, e As EventArgs) Handles mnuViewFont.Click
        ' Create Font Dialog
        Dim fontDialog As FontDialog = New FontDialog

        ' Start Font at Current Font
        fontDialog.Font = txtContent.Font

        ' Show Font Dialog
        Dim result = fontDialog.ShowDialog()

        ' See if OK was pressed.
        If result = DialogResult.OK Then
            ' Get Font.
            Dim font As Font = fontDialog.Font
            ' Set TextBox Font
            txtContent.Font = font

            ' Save Font in Setting
            TextEditorState.Default.ContentFont = font
            ' Save Settings
            TextEditorState.Default.Save()
        End If

    End Sub

    Private Sub mnuViewFullscreen_Click(sender As Object, e As EventArgs) Handles mnuViewFullscreen.Click
        ' Toggle the fullscreen state of the window
        toggleFullscreen()
    End Sub

    Private Sub mnuViewStatusBar_CheckedChanged(sender As Object, e As EventArgs) Handles mnuViewStatusBar.CheckedChanged
        ' Whether the status bar is visibly or not
        Dim statusBarVisible As Boolean = mnuViewStatusBar.Checked
        ' Toggle Status Bar
        statusBar.Visible = statusBarVisible

        ' Save Status Visibility in Setting
        TextEditorState.Default.StatusBarVisible = statusBarVisible
        ' Save Settings
        TextEditorState.Default.Save()
    End Sub


    Private Sub mnuHelpIndex_Click(sender As Object, e As EventArgs) Handles mnuHelpIndex.Click
        ' Create Index Form
        Dim frmIndex As IndexForm = New IndexForm

        ' Display Index Form
        frmIndex.ShowDialog()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        ' Create Index Form
        Dim frmAbout As AboutForm = New AboutForm

        ' Display About Form
        frmAbout.ShowDialog()
    End Sub

    Private Sub mnuHelpResetSettings_Click(sender As Object, e As EventArgs) Handles mnuHelpResetSettings.Click
        ' Confirm Reset
        If MessageBox.Show("Are you sure you want to restore settings to their default values?.", "Reset Settings", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then
            ' Reset Actual Settings
            TextEditorState.Default.Reset()
            ' Make Changes to Form
            loadSettings()
        End If
    End Sub

#End Region ' Menu
#End Region ' Methods
End Class