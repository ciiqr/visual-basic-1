' 
' Name:         Theatre Seating - 5
'
' Author:       William Villeneuve
' Date:         April 1, 2014
' 
' Description:  Windows forms application which allows the viewing of available seating in a small 18 seat theatre
'               Moving your mouse over a seat changes the background colour based on the availability of the given seat
'               Availability button displays the availability colours for all seats in the theatre
'               Keyboard shortcuts allow easy navigation.
'               Tooltips display the name of the patron in a seat or available
' 

Public Class TheatreSeatingForm

    ' Constants '

    ' Database
    Private Const DATABASE_FILE = "Theatre.accdb"

    ' Seats
    Private Const NUMBER_OF_SEATS As Integer = 18
    Private Const NUMBER_OF_ROWS As Integer = 3

    ' Button Titles
    Private Const BUTTON_TITLE_AVAILABLE As String = "&Available"
    Private Const BUTTON_TITLE_RESET As String = "&Reset"

    ' Seat Colours
    ' (ReadOnly because it cannot be const)
    Private ReadOnly SEAT_COLOUR_AVAILABLE As Color = Color.Green
    Private ReadOnly SEAT_COLOUR_UNAVAILABLE As Color = Color.Red
    Private ReadOnly SEAT_COLOUR_DEFAULT As Color = Color.White


    ' Variables '

    ' Database Connection
    Private dbConnection As New OleDb.OleDbConnection
    ' Data Adapter
    Private dbDataAdapter As OleDb.OleDbDataAdapter
    ' Data Set
    Private dbDataSet As New DataSet


    ' Methods '

    ' Initialize Seats, Database Objects, and List Box
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup Number of seats in the seats control
        seats.setupSeats(NUMBER_OF_SEATS, NUMBER_OF_ROWS)

        ' Connect to Database (Access File)
        dbConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\" & DATABASE_FILE & ";Persist Security Info=False"
        ' Create Data Adapter
        dbDataAdapter = New OleDb.OleDbDataAdapter("SELECT * FROM seating", dbConnection)

        ' Open Database
        dbConnection.Open()
        ' Fill Data Adapter
        dbDataAdapter.Fill(dbDataSet)


        ' Get List of Dates With Performances
        ' Set Select Command
        dbDataAdapter.SelectCommand.CommandText = "SELECT DISTINCT perf_date FROM Performances"
        ' Clear Previous Data
        dbDataSet.Clear()
        ' Fill Data
        dbDataAdapter.Fill(dbDataSet)

        ' Load Dates From Returned Data
        ' NOTE: Scroll Bars on the list box are barely visible when there are multiple items because of the height of the control
        For Each performance As DataRow In dbDataSet.Tables(0).Rows
            ' Get Date & Add to the Date List box
            lstDate.Items.Add(performance("perf_date"))
        Next

        ' Force first item selected on start
        lstDate.SelectedIndex = 0
    End Sub

    ' Determine if seat taken or not
    Private Function isSeatAvailable(seatNumber As Integer) As Boolean
        Dim available As Boolean = True

        ' Query table with seat number & date (Optional)
        ' Set Select Command
        dbDataAdapter.SelectCommand.CommandText = "SELECT * FROM seating WHERE seat_no = " & seatNumber & " AND perf_date = '" & lstDate.SelectedItem & "'"
        ' Clear Previous Data
        dbDataSet.Clear()
        ' Fill Data
        dbDataAdapter.Fill(dbDataSet)

        ' if record found
        If dbDataSet.Tables(0).Rows.Count = 1 Then
            ' Seat Taken
            available = False
        End If

        Return available
    End Function

    ' Shows Availabilities of All Seats OR resets back to normal
    Private Sub btnAvailability_Click(sender As Object, e As EventArgs) Handles btnAvailability.Click
        ' Check Which button it is representing
        If btnAvailability.Text.Equals(BUTTON_TITLE_AVAILABLE) Then

            ' Go Through Each Seat & set background colour based on availability
            For seatIndex = 1 To NUMBER_OF_SEATS
                ' Get Control for seat
                Dim seatControl As Control = seats.getSeatControl(seatIndex)

                ' Decide if available
                If isSeatAvailable(seatIndex) Then ' Seat Available
                    ' Change to Green
                    seatControl.BackColor = SEAT_COLOUR_AVAILABLE
                Else ' Seat NOT Available
                    ' Change to Red
                    seatControl.BackColor = SEAT_COLOUR_UNAVAILABLE
                End If

            Next

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

    ' Displays an error for seats that are already taken
    Private Sub panSeats_SeatMouseClick(ByRef seatControl As Control, seatNumber As Integer) Handles seats.SeatMouseClick
        ' Seat is Available
        If isSeatAvailable(seatNumber) Then
            ' TODO: Allow Booking (INSERT ... seat_no = XX, patron = NAME)
        Else ' UnAvailable
            MessageBox.Show("This seat is not vacant", "Unavailable")
        End If
    End Sub

    ' Shows Seat Availability & Patron Name Or "Available"
    Private Sub panSeats_SeatMouseEnter(ByRef seatControl As Control, seatNumber As Integer) Handles seats.SeatMouseEnter
        ' Decide if available
        If isSeatAvailable(seatNumber) Then ' Seat Available
            ' Change to Green
            seatControl.BackColor = SEAT_COLOUR_AVAILABLE
            
            ' Set toolip to available
            toolTip.SetToolTip(seatControl, "Available")
        Else ' Seat NOT Available
            ' Change to Red
            seatControl.BackColor = SEAT_COLOUR_UNAVAILABLE
            
            ' Set Tool tip to Patron Name
            toolTip.SetToolTip(seatControl, dbDataSet.Tables(0).Rows(0)("patron"))
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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close form, thus exiting the application
        Close()
    End Sub
End Class
