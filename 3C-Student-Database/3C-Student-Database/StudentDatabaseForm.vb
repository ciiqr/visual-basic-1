' 
' Name:         Student Database Viewer - 3C
'
' Author:       William Villeneuve
' Date:         March 15, 2014
' 
' Description:  Windows forms application which allows the viewing of student information in a table 
'                   with multiple records, a regular form style, one record at a time, one record
'                   at a time through a searchable student number, or one at a time by search new,
'                   with the ability to make & save changes.
'               For these 3 different points of view there are 4 forms, seperate from the main form
'                   which is just for navigation to these forms.
'               Keyboard shortcuts on all forms to easy navigation (and future data entry).
'               Tooltips display helpful tips on certain controls.
' 

Public Class StudentDatabaseForm

    ' Variables
    ' Forms, class variables so that their state is saved between opening & closing them
    Dim frmBrowseDataGrid As StudentDatagridForm
    Dim frmBrowseRecordByRecord As StudentRecordForm
    Dim frmSearchStudentNumber As StudentNumberSearchForm
    Dim frmNewChangeStudent As StudentAddChangeForm

    ''' <summary>
    ''' Displays the Student Database in a DataGrid within a seperate Form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnBrowseDataGrid_Click(sender As Object, e As EventArgs) Handles btnBrowseDataGrid.Click
        ' Lazily Create Form
        If frmBrowseDataGrid Is Nothing Then
            frmBrowseDataGrid = New StudentDatagridForm
        End If
        ' Display Student DataGrid Form
        frmBrowseDataGrid.ShowDialog()
    End Sub

    ''' <summary>
    ''' Displays the Student Database one record at a time within a seperate Form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnBrowseRecordByRecord_Click(sender As Object, e As EventArgs) Handles btnBrowseRecordByRecord.Click
        ' Lazily Create Form
        If frmBrowseRecordByRecord Is Nothing Then
            frmBrowseRecordByRecord = New StudentRecordForm
        End If
        ' Display Student Record Form
        frmBrowseRecordByRecord.ShowDialog()
    End Sub

    ''' <summary>
    ''' Display Student Number Search within a seperate Form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSearchStudentNumber_Click(sender As Object, e As EventArgs) Handles btnSearchStudentNumber.Click
        ' Lazily Create Form
        If frmSearchStudentNumber Is Nothing Then
            frmSearchStudentNumber = New StudentNumberSearchForm
        End If
        ' Display Student Record Form
        frmSearchStudentNumber.ShowDialog()
    End Sub

    ''' <summary>
    ''' Display Add/Change Student within a seperate Form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnNewChangeStudent_Click(sender As Object, e As EventArgs) Handles btnNewChangeStudent.Click
        ' Lazily Create Form
        If frmNewChangeStudent Is Nothing Then
            frmNewChangeStudent = New StudentAddChangeForm
        End If
        ' Display Student Record Form
        frmNewChangeStudent.ShowDialog()
    End Sub

    ''' <summary>
    ''' Closes this Form, Thus Exiting the Application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes this Form, Thus Exiting the Application
        Close()
    End Sub
End Class
