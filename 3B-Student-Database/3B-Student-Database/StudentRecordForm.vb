' 
' Name:     Student Database Viewer - 3B
'
' Author:   William Villeneuve
' Date:     February 23, 2014
' 

Public Class StudentRecordForm

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
    Private Sub StudentRecordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    ''' Navigates to the first record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGoToStart_Click(sender As Object, e As EventArgs) Handles btnGoToStart.Click
        ' Navigates to the first record
        TblStudentsBindingSource.MoveFirst()

        ' Update Buttons & Record Position Indicator
        PositionChanged()
    End Sub

    ''' <summary>
    ''' Navigates to the previous record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGoToPrevious_Click(sender As Object, e As EventArgs) Handles btnGoToPrevious.Click
        ' Navigates to the previous record
        TblStudentsBindingSource.MovePrevious()

        ' Update Buttons & Record Position Indicator
        PositionChanged()
    End Sub

    ''' <summary>
    ''' Navigates to the next record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGoToNext_Click(sender As Object, e As EventArgs) Handles btnGoToNext.Click
        ' Navigates to the next record
        TblStudentsBindingSource.MoveNext()

        ' Update Buttons & Record Position Indicator
        PositionChanged()
    End Sub

    ''' <summary>
    ''' Navigates to the last record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGoToEnd_Click(sender As Object, e As EventArgs) Handles btnGoToEnd.Click
        ' Navigates to the last record
        TblStudentsBindingSource.MoveLast()

        ' Update Buttons & Record Position Indicator
        PositionChanged()
    End Sub

    ''' <summary>
    ''' Enable/Disable all applicable buttons, display the current record number &amp; total number of records, to conform to the current navigated state
    ''' </summary>
    ''' <remarks>Called when the navigation buttons are pressed</remarks>
    Private Sub PositionChanged()

        ' Indicate the current record & the total number of records
        lblRecordPositionIndicator.Text = "Record " & (TblStudentsBindingSource.Position + 1) & " of " & TblStudentsBindingSource.Count

        ' Determine the current state (Start/End/Middle) and (En/Dis)able all applicable buttons to conform to that state
        If TblStudentsBindingSource.Position = 0 Then ' At the Start
            ' Disable Start & Previous Buttons
            btnGoToStart.Enabled = False
            btnGoToPrevious.Enabled = False
            ' Make Sure Next & End Buttons Are Enabled
            btnGoToNext.Enabled = True
            btnGoToEnd.Enabled = True

        ElseIf TblStudentsBindingSource.Position = (TblStudentsBindingSource.Count - 1) Then ' At the End
            ' Make Sure Start & Previous Buttons Are Enabled
            btnGoToStart.Enabled = True
            btnGoToPrevious.Enabled = True
            ' Disable Next & End Buttons
            btnGoToNext.Enabled = False
            btnGoToEnd.Enabled = False

        Else ' In The Middle Somewhere

            ' Make Sure All Buttons Are Enabled
            btnGoToStart.Enabled = True
            btnGoToPrevious.Enabled = True
            btnGoToNext.Enabled = True
            btnGoToEnd.Enabled = True
        End If
    End Sub
End Class