' 
' Name:     Student Database Viewer - 3A
'
' Author:   William Villeneuve
' Date:     February 16, 2014
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
End Class