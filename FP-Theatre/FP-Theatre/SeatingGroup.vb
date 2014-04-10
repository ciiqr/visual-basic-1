Public Class SeatingGroup
    ' TODO: Configurable Settings for these?
    Private Const SEAT_X_SPACING = 8
    Private Const SEAT_Y_SPACING = 24
    Private Const SEAT_WIDTH = 60
    Private Const SEAT_HEIGHT = 34
    Private Const FONT_SIZE = 14

    ' Seat Properties
    Private numberOfSeats As Integer = 1
    Private numberOfRows As Integer = 1


    ' Events
    ' Notify of Mouse Entering a seat control
    Public Event SeatMouseEnter(ByRef seatControl As Control, seatNumber As Integer)
    ' Notify of Mouse Leaving a seat control
    Public Event SeatMouseLeave(ByRef seatControl As Control, seatNumber As Integer)
    ' Notify of Clicking a seat control
    Public Event SeatMouseClick(ByRef seatControl As Control, seatNumber As Integer)

    ' Return the controls for all seats
    ' Public Function SeatControls() As ControlCollection
    ' ' Currently all sub controls but could be changed so that it is only a specific type (ie. only a sub-class of Label, SeatLabel)
    '     Return Me.Controls
    ' End Function

    ' Get the control for the seat number
    Public Function getSeatControl(seatNumber As Integer) As Control
        ' Arrays are indexed on 0 seats are indexed on 1
        Return Me.Controls(seatNumber - 1)
    End Function

    ' Initialize all the Seats
    Public Sub setupSeats(numberOfSeats As Integer, numberOfRows As Integer)
        ' Initialize Settings
        Me.numberOfRows = numberOfRows
        Me.numberOfSeats = numberOfSeats
        ' Font fot the seat labels
        Dim font As New Font(New FontFamily("Georgia"), FONT_SIZE, FontStyle.Regular, GraphicsUnit.Pixel)

        ' If There Are Already Controls Then Remove All
        ' TODO: Make more efficient, keep controls & just add/remove to adjust to the new settings
        '       - Also have seperate properties which adjust these instead of this method
        For Each subControl As Control In Controls
            Controls.Remove(subControl)
        Next

        ' Initialize Seats
        For seatNumber = 1 To numberOfSeats
            ' Create Seat
            Dim seat As New Label
            ' Set Label
            seat.Text = "Seat " & seatNumber
            ' Font
            seat.Font = font
            ' Text Align
            seat.TextAlign = ContentAlignment.MiddleCenter
            ' Set Color
            seat.BackColor = Color.White
            seat.BorderStyle = BorderStyle.FixedSingle
            ' Set Tag for later use
            seat.Tag = seatNumber

            ' Add Handlers to Seat
            AddHandler seat.MouseEnter, AddressOf Me.SeatingPanel_Seat_MouseEnter
            AddHandler seat.MouseLeave, AddressOf Me.SeatingPanel_Seat_MouseLeave
            AddHandler seat.MouseClick, AddressOf Me.SeatingPanel_Seat_MouseClick

            ' Add Seat to Panel
            Controls.Add(seat)
        Next

        PerformLayout()
    End Sub

    ' Constructor for a new SeatingGroup
    Sub New()
        ' Initialize Controls
        InitializeComponent()
    End Sub

    ' Send Seat Mouse Enter Event
    Private Sub SeatingPanel_Seat_MouseEnter(sender As Label, e As EventArgs)
        ' Call SeatMouseEnter Event
        RaiseEvent SeatMouseEnter(sender, sender.Tag)
    End Sub

    ' Send Seat Mouse Leave Event
    Private Sub SeatingPanel_Seat_MouseLeave(sender As Label, e As EventArgs)
        ' Call SeatMouseLeave Event
        RaiseEvent SeatMouseLeave(sender, sender.Tag)
    End Sub

    ' Send Seat Mouse Click Event
    Private Sub SeatingPanel_Seat_MouseClick(sender As Label, e As EventArgs)
        ' Call SeatMouseClick Event
        RaiseEvent SeatMouseClick(sender, sender.Tag)
    End Sub

    ' Lays out each seat, with numbers ascending from left to right
    Private Sub SeatingPanel_LayoutLeftToRight(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles MyBase.Layout
        ' TODO: Modify so that it lays out the seats the same way Bill has in his example
        '   - The easiest way will probably be go from right to left instead of left to right like I currently do

        ' Dont Layout Until All Controls Are Added
        If Not Controls.Count < numberOfSeats Then

            ' Figure Out How Many Seats Per Row
            Dim numberOfSeatsInRow As Integer = (Controls.Count / numberOfRows)

            ' Spacing for Center
            Dim centreXSpacing = (Width - ((numberOfSeatsInRow * (SEAT_WIDTH + SEAT_X_SPACING)) - SEAT_X_SPACING)) / 2 + SEAT_WIDTH
            Dim centreYSpacing = (Height - ((numberOfRows * (SEAT_HEIGHT + SEAT_Y_SPACING)) - SEAT_Y_SPACING)) / 2

            Dim xOffset As Integer = Width - centreXSpacing
            Dim yOffset As Integer = centreYSpacing

            ' Go Through Each Control (Backwards) & Lay Them Out
            For index = (Controls.Count - 1) To 0 Step -1
                Dim subControl As Control = Controls(index)

                ' Position Control
                subControl.SetBounds(xOffset, yOffset, SEAT_WIDTH, SEAT_HEIGHT)

                ' Adjust Offsets
                ' If End of Row, Reset X, Increace Y
                If (index Mod numberOfSeatsInRow = 0) Then
                    xOffset = Width - centreXSpacing ' Reset X
                    yOffset += SEAT_HEIGHT + SEAT_Y_SPACING
                Else ' Increase X Offset
                    xOffset -= SEAT_WIDTH + SEAT_X_SPACING
                End If

            Next

        End If
    End Sub

    ' Lays out each seat, with numbers ascending from right to left
    'Private Sub SeatingPanel_LayoutRightToLeft(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles MyBase.Layout
    '    ' TODO: Modify so that it lays out the seats the same way Bill has in his example
    '    '   - The easiest way will probably be go from right to left instead of left to right like I currently do

    '    ' Dont Layout Until All Controls Are Added
    '    If Not Controls.Count < numberOfSeats Then
    '        ' Figure Out How Many Seats Per Row
    '        Dim numberOfSeatsInRow As Integer = (Controls.Count / numberOfRows)

    '        ' Spacing for Center
    '        Dim centreXSpacing = (Width - ((numberOfSeatsInRow * (SEAT_WIDTH + SEAT_X_SPACING)) - SEAT_X_SPACING)) / 2
    '        Dim centreYSpacing = (Height - ((numberOfRows * (SEAT_HEIGHT + SEAT_Y_SPACING)) - SEAT_Y_SPACING)) / 2

    '        Dim xOffset As Integer = centreXSpacing
    '        Dim yOffset As Integer = centreYSpacing

    '        ' Go Through Each Control (Backwards) & Lay Them Out
    '        For index = (Controls.Count - 1) To 0 Step -1
    '            Dim subControl As Control = Controls(index)

    '            ' Position Control
    '            subControl.SetBounds(xOffset, yOffset, SEAT_WIDTH, SEAT_HEIGHT)

    '            ' Adjust Offsets
    '            ' If End of Row, Reset X, Increace Y
    '            If (index Mod numberOfSeatsInRow = 0) Then
    '                xOffset = centreXSpacing
    '                yOffset += SEAT_HEIGHT + SEAT_Y_SPACING
    '            Else ' Increase X Offset
    '                xOffset += SEAT_WIDTH + SEAT_X_SPACING
    '            End If

    '        Next
    '    End If
    'End Sub
End Class
