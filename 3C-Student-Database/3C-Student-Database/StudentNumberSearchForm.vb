' 
' Name:     Student Database Viewer - 3C
'
' Author:   William Villeneuve
' Date:     March 15, 2014
' 

Public Class StudentNumberSearchForm

    ''' <summary>
    ''' Tries to find the entry for the entered student number, displays it if it finds it, otherwise displays appropriate error messages
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim errorMessage = ""
        ' Hide Record Info (Reshown later if a record is found)
        panRecordInformation.Visible = False

        If DatabaseValidation.StudentNumber(txtStudentNumberSearch.Text, errorMessage) Then
            ' Filter the Table based on the entry
            TblStudentsBindingSource.Filter = "StudentNumber=" & txtStudentNumberSearch.Text.Trim()
            ' Check that a record is found (Can only ever be 0 or 1 since StudentNumber is primary key)
            If TblStudentsBindingSource.Count = 1 Then
                ' Show Record Info
                panRecordInformation.Visible = True

                ' Display Record Found Status
                lblStatus.Text = "Here is your record"
            Else ' Record not found
                ' Display Error Status
                lblStatus.Text = "Record Not Found"
            End If

        Else ' Not a valid Student Number
            ' Display Error Status with Specific Reason
            lblStatus.Text = errorMessage
        End If
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
    Private Sub StudentNumberSearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudDataDataSet.tblStudents' table. You can move, or remove it, as needed.
        Me.TblStudentsTableAdapter.Fill(Me.StudDataDataSet.tblStudents)

    End Sub
End Class