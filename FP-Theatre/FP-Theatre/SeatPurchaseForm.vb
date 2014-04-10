Public Class SeatPurchaseForm

    Public Sub New(performanceDate As String, seatNumber As Integer, performanceCost As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Date
        txtDate.Text = performanceDate
        ' Seat Number
        txtSeat.Text = seatNumber
        ' Performance Cost
        txtCost.Text = performanceCost
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Go back to the main form
        Close()
    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        ' Validate
        If txtName.TextLength = 0 Then
            MessageBox.Show("You MUST enter your name.")
        Else ' Valid
            Try
                ' Create Insert Command
                Dim insertCommand As New OleDb.OleDbCommand("INSERT INTO seating(Seat_no, Perf_Date, Patron) VALUES('" & txtSeat.Text & "','" & txtDate.Text & "','" & txtName.Text & "')", dbConnection)

                ' Fill Data Set Before INSERT
                dbSeatingDataAdapter.Fill(dbSeatingDataSet)
                ' Load the INSERT Command
                dbSeatingDataAdapter.InsertCommand = insertCommand
                ' Execute Command
                insertCommand.ExecuteNonQuery()

                ' Record Inserted, Close Form
                Close()
            Catch ex As Exception
                MessageBox.Show("Error Booking Seat")
            End Try
        End If

    End Sub
End Class