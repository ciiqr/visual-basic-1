' 
' Name:     Student Database Viewer - 3C
'
' Author:   William Villeneuve
' Date:     March 15, 2014
' 

Public Class StudentAddChangeForm

    Private Sub TblStudentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblStudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudDataDataSet)

    End Sub

    Private Sub StudentAddChangeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudDataDataSet.tblStudents' table. You can move, or remove it, as needed.
        Me.TblStudentsTableAdapter.Fill(Me.StudDataDataSet.tblStudents)

    End Sub

    ''' <summary>
    ''' Restores the form to it's default state
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub restoreToDefaultState()
        ' Hide Record Info
        panRecordInformation.Visible = False
        ' Show Status Label
        lblStatus.Visible = True

        ' Update Status Label with Starting Prompt (ResetText didn't want to work for me...)
        lblStatus.Text = "Enter the Student Number to Update OR Click Add New"

        ' Enable Buttons
        btnSearch.Enabled = True
        btnAddNew.Enabled = True

        ' Accept Button
        AcceptButton = btnSearch
    End Sub

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
        ' Show Status Label (Hidden later if a record is found)
        lblStatus.Visible = True

        ' Validate Entered Student Number
        If DatabaseValidation.StudentNumber(txtStudentNumberSearch.Text, errorMessage) Then
            ' Filter the Table based on the entry
            TblStudentsBindingSource.Filter = "StudentNumber=" & txtStudentNumberSearch.Text.Trim()
            ' Check that a record is found (Can only ever be 0 or 1 since StudentNumber is primary key)
            If TblStudentsBindingSource.Count = 1 Then
                ' Show Record Info
                panRecordInformation.Visible = True
                ' Hide Status Label
                lblStatus.Visible = False

                ' Cannot Change the Student Number of Already Entered Students
                StudentNumberTextBox.ReadOnly = True

                ' Disable Buttons
                btnSearch.Enabled = False
                btnAddNew.Enabled = False

                ' Accept Button
                AcceptButton = btnSave

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
    ''' Allows the user to enter in a new record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        ' Position to New Record
        TblStudentsBindingSource.AddNew()

        ' Show Record Info
        panRecordInformation.Visible = True
        ' Hide Status Label
        lblStatus.Visible = False

        ' Disable Buttons
        btnSearch.Enabled = False
        btnAddNew.Enabled = False

        ' Accept Button
        AcceptButton = btnSave

        ' Allow Editing of Student Number
        StudentNumberTextBox.ReadOnly = False
        ' Focus Student Number
        StudentNumberTextBox.Focus()
    End Sub

    ''' <summary>
    ''' Saves new record OR changes to existing record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim errorMessage = ""

        ' Validate All Info
        If Not DatabaseValidation.StudentNumber(StudentNumberTextBox.Text, errorMessage) Then ' Student Number
            MessageBox.Show(errorMessage)
            StudentNumberTextBox.Focus()

        ElseIf Not DatabaseValidation.StudentName(StudentNameTextBox.Text, errorMessage) Then ' Student Name
            MessageBox.Show(errorMessage)
            StudentNameTextBox.Focus()

        ElseIf Not DatabaseValidation.PhoneNumber(PhoneNumberTextBox.Text, errorMessage) Then ' Phone Number
            MessageBox.Show(errorMessage)
            PhoneNumberTextBox.Focus()

        ElseIf Not DatabaseValidation.EnrollDate(EnrollDateTextBox.Text, errorMessage) Then ' Enroll Date
            MessageBox.Show(errorMessage)
            EnrollDateTextBox.Focus()

        ElseIf Not DatabaseValidation.StudentLoan(StudentLoanTextBox.Text, errorMessage) Then ' Student Loan
            MessageBox.Show(errorMessage)
            StudentLoanTextBox.Focus()

        ElseIf Not DatabaseValidation.Major(MajorTextBox.Text, errorMessage) Then ' Student Major
            MessageBox.Show(errorMessage)
            MajorTextBox.Focus()

        Else ' All Info Is Valid
            Try
                ' End Editing
                TblStudentsBindingSource.EndEdit()

                ' Update Info
                TableAdapterManager.UpdateAll(StudDataDataSet)

                ' Restore to Default
                restoreToDefaultState()

                ' Display Update Succeeded
                lblStatus.Text = "Record Updated Successfully."

            Catch ex As ConstraintException ' Duplicate Student Number
                MessageBox.Show(ex.Message, "Student Number Already Exists")
            Catch ex As Exception
                ' Debug Info
                MessageBox.Show(ex.Message, "Errors Occured While Saving Data")
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Cancels changes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Cancel Any Changes
        TblStudentsBindingSource.CancelEdit()

        ' Restore to Default
        restoreToDefaultState()
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