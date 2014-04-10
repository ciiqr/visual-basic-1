' 
' Name:     Student Database Viewer - 3B
'
' Author:   William Villeneuve
' Date:     February 23, 2014
' 

Public Class StudentDatagridForm

    ''' <summary>
    ''' Sends changed data to the database, Irrelevant in Revision 3A due to the fact that nothing is editable
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TblStudentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblStudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudDataDataSet)
    End Sub

    ''' <summary>
    ''' Loads data into the table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub StudentDatagridForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudDataDataSet.tblStudents' table. You can move, or remove it, as needed.
        Me.TblStudentsTableAdapter.Fill(Me.StudDataDataSet.tblStudents)

    End Sub

    ''' <summary>
    ''' Closes the current form, Thus going back to the calling form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        ' Closes the current form, Thus going back to the calling form
        Close()
    End Sub

    ''' <summary>
    ''' Changes the datagrid sort order to Student Number
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rdoSortByNumber_CheckedChanged(sender As RadioButton, e As EventArgs) Handles rdoSortByNumber.CheckedChanged
        ' If This button is now checked
        If sender.Checked Then
            ' Sort by Student Number
            TblStudentsBindingSource.Sort = "StudentNumber"
        End If
    End Sub

    ''' <summary>
    ''' Changes the datagrid sort order to Student Name
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rdoSortByName_CheckedChanged(sender As RadioButton, e As EventArgs) Handles rdoSortByName.CheckedChanged
        ' If This button is now checked
        If sender.Checked Then
            ' Sort by Student Name
            TblStudentsBindingSource.Sort = "StudentName"
        End If
    End Sub

    ''' <summary>
    ''' Changes the datagrid sort order to Student Major
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rdoSortByMajor_CheckedChanged(sender As RadioButton, e As EventArgs) Handles rdoSortByMajor.CheckedChanged
        ' If This button is now checked
        If sender.Checked Then
            ' Sort by Student Major
            TblStudentsBindingSource.Sort = "Major"
        End If
    End Sub
End Class