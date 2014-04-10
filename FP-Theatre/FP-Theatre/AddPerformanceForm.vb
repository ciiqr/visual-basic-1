Public Class AddPerformanceForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Date
        dtpDate.Value = DateTime.Today
    End Sub



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Go back to the main form
        Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Validate
        If txtTitle.TextLength = 0 Then ' Title Length
            MessageBox.Show("You MUST enter a name for the performance.")

        ElseIf txtBasePrice.TextLength = 0 Then ' Price Entered
            MessageBox.Show("You MUST enter a base price.")

        ElseIf Not IsNumeric(txtBasePrice.Text) Then ' Price Numeric
            MessageBox.Show("The base price MUST be numeric.")
        Else ' Valid
            Try
                ' Create Insert Command
                ' NOTE: Incredibly Insecure, even apostrophes mess it up so really should use commands parameters (insertCommand.Parameters.Add)
                Dim insertCommand As New OleDb.OleDbCommand(
                    "INSERT INTO Performances(perf_date, Show_title, base_ticket_price) VALUES( '" &
                    dtpDate.Value.ToShortDateString() & "', '" & txtTitle.Text & "', '" & txtBasePrice.Text & "')", dbConnection)

                ' Fill Data Set Before INSERT
                dbPerformancesDataAdapter.Fill(dbPerformancesDataSet)
                ' Load the INSERT Command
                dbPerformancesDataAdapter.InsertCommand = insertCommand
                ' Execute Command
                insertCommand.ExecuteNonQuery()

                ' Record Inserted, Close Form
                Close()
            Catch ex As Exception
                MessageBox.Show("Sorry there is already a performance on that date.")
            End Try

        End If
    End Sub
End Class