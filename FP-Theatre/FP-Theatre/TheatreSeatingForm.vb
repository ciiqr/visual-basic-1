' 
' Name:         Theatre - FP
'
' Author:       William Villeneuve
' Date:         April 1, 2014
' 
' Description:  Windows forms application which allows the viewing of available seating in a small 18 seat theatre
'               Moving your mouse over a seat changes the background colour based on the availability of the given seat with the price
'               Availability button displays the availability colours for all seats in the theatre
'               Availability continues to be shown as the performance changes
'               Performance name is shown at the button on the "stage"
'               Clicking available seats allows you to purchase them
'               Button for adding performances
'               Seats are dynamically created & laid out
'               Keyboard shortcuts allow easy navigation.
'               Tooltips display the name of the patron in a seat or available
' 

Public Class TheatreSeatingForm

    ' Constants '

    ' Seats
    Private Const NUMBER_OF_SEATS As Integer = 18
    Private Const NUMBER_OF_ROWS As Integer = 3

    ' Prices
    Friend Const FRONT_ROW_PREMIUM As Integer = 10

    ' Button Titles
    Private Const BUTTON_TITLE_AVAILABLE As String = "&Available"
    Private Const BUTTON_TITLE_RESET As String = "&Reset"

    ' Seat Colours
    ' (ReadOnly because it cannot be const)
    Private ReadOnly SEAT_COLOUR_AVAILABLE As Color = Color.Green
    Private ReadOnly SEAT_COLOUR_UNAVAILABLE As Color = Color.Red
    Private ReadOnly SEAT_COLOUR_DEFAULT As Color = Color.White


    ' Methods '

    ' Initialize Seats, Database Objects, and List Box
    Private Sub TheatreSeatingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup Number of seats in the seats control
        seats.setupSeats(NUMBER_OF_SEATS, NUMBER_OF_ROWS)

        ' Get List of Dates With Performances

        ' Load Dates From Returned Data
        ' NOTE: Scroll Bars on the list box are barely visible when there are multiple items because of the height of the control
        For Each performance As DataRow In dbPerformancesDataSet.Tables(0).Rows
            ' Get Date & Add to the Date List box
            lstDate.Items.Add(performance("perf_date"))
        Next

        ' Force first item selected on start
        lstDate.SelectedIndex = 0
    End Sub

    Private Sub btnAddPerformance_Click(sender As Object, e As EventArgs) Handles btnAddPerformance.Click
        ' Add Performance
        Dim frmAddPerformance As New AddPerformanceForm

        ' Show Form
        frmAddPerformance.ShowDialog()

        ' Reload All Data
        ' Set Select Command
        dbPerformancesDataAdapter.SelectCommand.CommandText = "SELECT * FROM Performances"
        ' Clear Previous Data
        dbPerformancesDataSet.Clear()
        ' Fill Data
        dbPerformancesDataAdapter.Fill(dbPerformancesDataSet)

        ' Clear Current Options
        ' NOTE: Will be brought back to the first item
        lstDate.Items.Clear()

        ' Load Dates From Returned Data
        ' NOTE: Scroll Bars on the list box are barely visible when there are multiple items because of the height of the control
        For Each performance As DataRow In dbPerformancesDataSet.Tables(0).Rows
            ' Get Date & Add to the Date List box
            lstDate.Items.Add(performance("perf_date"))
        Next

        ' Select First Item
        lstDate.SelectedIndex = 0
    End Sub

    ' Shows Availabilities of All Seats OR resets back to normal
    Private Sub btnAvailability_Click(sender As Object, e As EventArgs) Handles btnAvailability.Click
        ' Check Which button it is representing
        If btnAvailability.Text.Equals(BUTTON_TITLE_AVAILABLE) Then

            ' Show Availability of seats
            showAllSeatAvailabilities()

            ' Switch to Reset Button
            btnAvailability.Text = BUTTON_TITLE_RESET

        Else ' Currently Reset Button
            ' Go Through Each & Set to White
            For seatIndex = 1 To NUMBER_OF_SEATS
                ' Reset seats back colour
                seats.getSeatControl(seatIndex).BackColor = SEAT_COLOUR_DEFAULT
            Next

            ' Switch To Available Button
            btnAvailability.Text = BUTTON_TITLE_AVAILABLE

        End If
    End Sub

    Private Sub showAllSeatAvailabilities()
        ' Go Through Each Seat & set background colour based on availability
        For seatIndex = 1 To NUMBER_OF_SEATS
            ' Get Control for seat
            Dim seatControl As Control = seats.getSeatControl(seatIndex)

            ' Decide if available
            If isSeatAvailable(seatIndex, lstDate.SelectedItem) Then ' Seat Available
                ' Change to Green
                seatControl.BackColor = SEAT_COLOUR_AVAILABLE
            Else ' Seat NOT Available
                ' Change to Red
                seatControl.BackColor = SEAT_COLOUR_UNAVAILABLE
            End If

        Next
    End Sub

    ' Displays an error for seats that are already taken
    Private Sub panSeats_SeatMouseClick(ByRef seatControl As Control, seatNumber As Integer) Handles seats.SeatMouseClick
        ' Seat is Available
        If isSeatAvailable(seatNumber, lstDate.SelectedItem) Then

            ' Get Performance Cost
            If dbPerformancesDataSet.Tables(0).Rows.Count = 1 Then
                ' Get Price
                Dim price As Double = dbPerformancesDataSet.Tables(0).Rows(0)("base_ticket_price")

                ' Front Row Pays a Premium
                If (seatNumber <= (NUMBER_OF_SEATS / NUMBER_OF_ROWS)) Then
                    price += FRONT_ROW_PREMIUM
                End If

                ' Booking Seats
                Dim frmSeatPurchase As New SeatPurchaseForm(lstDate.SelectedItem, seatNumber, price)

                ' Show Form
                frmSeatPurchase.ShowDialog()

                ' If Was Previously Displaying Availability, change seat background accordingly
                If btnAvailability.Text.Equals(BUTTON_TITLE_RESET) Then
                    ' Decide if available
                    If isSeatAvailable(seatNumber, lstDate.SelectedItem) Then ' Seat Available
                        ' Change to Green
                        seatControl.BackColor = SEAT_COLOUR_AVAILABLE
                    Else ' Seat NOT Available
                        ' Change to Red
                        seatControl.BackColor = SEAT_COLOUR_UNAVAILABLE
                    End If
                End If
            End If

        Else ' UnAvailable
            MessageBox.Show("This seat is not vacant", "Unavailable")
        End If

    End Sub

    ' Shows Seat Availability & Patron Name Or "Available"
    Private Sub panSeats_SeatMouseEnter(ByRef seatControl As Control, seatNumber As Integer) Handles seats.SeatMouseEnter
        ' Decide if available
        If isSeatAvailable(seatNumber, lstDate.SelectedItem) Then ' Seat Available
            Dim toolTipText As String = ""

            ' Change to Green
            seatControl.BackColor = SEAT_COLOUR_AVAILABLE

            ' Filter DataSet Based on Current Date
            filterPerformance(lstDate.SelectedItem)
            ' Get Performance Cost
            If dbPerformancesDataSet.Tables(0).Rows.Count = 1 Then
                ' Get Price
                Dim price As Double = dbPerformancesDataSet.Tables(0).Rows(0)("base_ticket_price")

                ' Front Row Pays a Premium
                If (seatNumber <= (NUMBER_OF_SEATS / NUMBER_OF_ROWS)) Then
                    price += FRONT_ROW_PREMIUM
                End If

                ' Get Performance Name
                toolTipText = "Available for: $" & price
            End If


            ' Set toolip to available
            toolTip.SetToolTip(seatControl, toolTipText)
        Else ' Seat NOT Available
            ' Change to Red
            seatControl.BackColor = SEAT_COLOUR_UNAVAILABLE

            ' Set Tool tip to Patron Name
            toolTip.SetToolTip(seatControl, dbSeatingDataSet.Tables(0).Rows(0)("patron"))
        End If
    End Sub

    ' Reset Visibile Availability
    Private Sub panSeats_SeatMouseLeave(ByRef seatControl As Control, seatNumber As Integer) Handles seats.SeatMouseLeave
        ' Only Reset Background colour if not in show all mode
        If btnAvailability.Text.Equals(BUTTON_TITLE_AVAILABLE) Then
            ' Change background colour back to white
            seatControl.BackColor = SEAT_COLOUR_DEFAULT
        End If
    End Sub

    Private Sub lstDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDate.SelectedIndexChanged
        ' Ensure an item is selected
        If True Or Not lstDate.SelectedIndex < 0 Then

            ' Filter DataSet Based on Current Date
            filterPerformance(lstDate.SelectedItem)
            ' Display Performance Name
            If dbPerformancesDataSet.Tables(0).Rows.Count = 1 Then
                ' Get Performance Name
                lblStage.Text = dbPerformancesDataSet.Tables(0).Rows(0)("Show_title")
            End If

            ' Check Which button it is representing
            If btnAvailability.Text.Equals(BUTTON_TITLE_RESET) Then
                ' Display Seating Availability
                showAllSeatAvailabilities()
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close form, thus exiting the application
        Close()
    End Sub
End Class
