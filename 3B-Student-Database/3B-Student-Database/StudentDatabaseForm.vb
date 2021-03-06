﻿' 
' Name:         Student Database Viewer - 3B
'
' Author:       William Villeneuve
' Date:         February 23, 2014
' 
' Description:  Windows forms application which allows the viewing of student information in a table 
'                   with multiple records, a regular form style, one record at a time, or one record
'                   at a time through a searchable student number.
'               For these 3 different points of view there are 3 forms, seperate from the main form
'                   which is just for navigation to these forms.
'               Keyboard shortcuts on all forms to easy navigation (and future data entry).
'               Tooltips display helpful tips on certain controls.
' 

Public Class StudentDatabaseForm

    ''' <summary>
    ''' Displays the Student Database in a DataGrid within a seperate Form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnBrowseDataGrid_Click(sender As Object, e As EventArgs) Handles btnBrowseDataGrid.Click
        ' Display Student DataGrid Form
        StudentDatagridForm.ShowDialog()
    End Sub

    ''' <summary>
    ''' Displays the Student Database one record at a time within a seperate Form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnBrowseRecordByRecord_Click(sender As Object, e As EventArgs) Handles btnBrowseRecordByRecord.Click
        ' Display Student Record Form
        StudentRecordForm.ShowDialog()
    End Sub

    ''' <summary>
    ''' Display Student Number Search within a seperate Form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSearchStudentNumber_Click(sender As Object, e As EventArgs) Handles btnSearchStudentNumber.Click
        ' Display Student Number Search Form
        StudentNumberSearchForm.ShowDialog()
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
