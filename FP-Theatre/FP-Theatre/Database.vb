Module Database
    ' Database
    Private Const DATABASE_FILE = "Theatre.accdb"

    ' Database Connection
    Friend dbConnection As New OleDb.OleDbConnection

    ' Seating Data Adapter
    Friend dbSeatingDataAdapter As New OleDb.OleDbDataAdapter("SELECT * FROM seating", dbConnection)
    ' Seating Data Set
    Friend dbSeatingDataSet As New DataSet

    ' Performances Data Adapter
    Friend dbPerformancesDataAdapter As New OleDb.OleDbDataAdapter("SELECT * FROM performances", dbConnection)
    ' Performances Data Set
    Friend dbPerformancesDataSet As New DataSet

    Sub New()
        ' Connect to Database (Access File)
        dbConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\" & DATABASE_FILE & ";Persist Security Info=False"

        ' Open Database
        dbConnection.Open()

        ' Fill Data Adapter
        dbSeatingDataSet.Clear()
        dbSeatingDataAdapter.Fill(dbSeatingDataSet)

        ' Fill Data Adapter
        dbPerformancesDataSet.Clear()
        dbPerformancesDataAdapter.Fill(dbPerformancesDataSet)

    End Sub

    ' Determine if seat taken or not
    Public Function isSeatAvailable(seatNumber As Integer, performanceDate As String) As Boolean
        Dim available As Boolean = True

        ' Query table with seat number & date
        ' Set Select Command
        dbSeatingDataAdapter.SelectCommand.CommandText = "SELECT * FROM seating WHERE seat_no = " & seatNumber & " AND perf_date = '" & performanceDate & "'"
        ' Clear Previous Data
        dbSeatingDataSet.Clear()
        ' Fill Data
        dbSeatingDataAdapter.Fill(dbSeatingDataSet)

        ' if record found
        If dbSeatingDataSet.Tables(0).Rows.Count = 1 Then
            ' Seat Taken
            available = False
        End If

        Return available
    End Function

    ' Filter DataSet to just the performence on the given date
    Public Sub filterPerformance(performanceDate As String)
        ' Query table with date
        ' Set Select Command
        dbPerformancesDataAdapter.SelectCommand.CommandText = "SELECT * FROM Performances WHERE perf_date = '" & performanceDate & "'"
        ' Clear Previous Data
        dbPerformancesDataSet.Clear()
        ' Fill Data
        dbPerformancesDataAdapter.Fill(dbPerformancesDataSet)
    End Sub
End Module
