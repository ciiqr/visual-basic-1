'' 
'' Name:    RainfallStats
'' Author:  William Villeneuve
''
'' Description: 
''

Public Class frmRainfallStats
    ' Number of Months
    Private Const NUMBER_OF_MONTHS = 12
    ' Current Month (1-12)
    Private currentMonth As Integer = 1
    ' Rain Fall Values for each month
    Private rainfallAmounts(NUMBER_OF_MONTHS - 1) As Double

    Private Sub btnInputAndDisplayStats_Click(sender As Object, e As EventArgs) Handles btnInputAndDisplayStats.Click
        ' Input
        Dim inputValue As Double

        ' Try to get Input
        Try
            ' Attempt to parse the input
            inputValue = Integer.Parse(txtDataEntry.Text)
            ' Number was Parsed properly

            ' Check Range of Number
            If inputValue < 0 Then
                ' Error, Cannot have a negative amount of rainfall
                MessageBox.Show("Invalid Input", "Please try again. Enter a value greater than or equal to 0.")

            Else ' Input is valid
                Dim averageRainFall As Double = 0
                Dim monthsWithoutRain As Integer = 0

                ' Store rainfall amount in array
                rainfallAmounts(currentMonth - 1) = inputValue



                ' Put Input into textbox
                txtDataDisplay.AppendText("Rain for month #" & currentMonth & ": " & inputValue & vbCrLf)

                If currentMonth = 12 Then
                    ' 
                    ' Go Through Each Rain Fall Amount
                    For monthIndex = 1 To NUMBER_OF_MONTHS
                        ' Get Amount
                        Dim rainfallAmount As Double = rainfallAmounts(monthIndex - 1)
                        ' Add it to Average
                        averageRainFall += rainfallAmount

                        ' If 0 THen Increment zero Counter
                        If rainfallAmount = 0 Then
                            monthsWithoutRain += 1
                        End If
                    Next
                    ' Dirplay Total
                    lblTotalAnnualRainfall.Text = "The total anual rainfall was " & averageRainFall

                    ' Caluclate Average
                    averageRainFall /= NUMBER_OF_MONTHS

                    ' Display Average 
                    lblAverageMonthlyRainfall.Text = "The average monthly rainfall was " & averageRainFall

                    ' Display Number with none
                    lblZeroCount.Text = "The number of months with no rain was " & monthsWithoutRain

                    ' Disable Inout Button
                    btnInputAndDisplayStats.Enabled = False

                    ' Accept Button uis clear
                    AcceptButton = btnClear

                Else ' Go To Next Month
                    ' Increment Month
                    currentMonth += 1

                    ' Increase Month Counter Label
                    lblMonthNum.Text = currentMonth
                End If

                End If

        Catch ex As FormatException ' Non-Numeric Input
            MessageBox.Show("Invalid Input", "Please try again. Enter a number.")
        Catch ex As OverflowException ' Number was too big
            MessageBox.Show("Invalid Input - Overflow", "This number is far too big. Please try again.")
        End Try
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Reset Rainfall Array vbalues to 0
        For monthIndex = 1 To NUMBER_OF_MONTHS
            rainfallAmounts(monthIndex - 1) = 0
        Next

        ' Reset Labels
        lblMonthNum.Text = 0
        lblTotalAnnualRainfall.ResetText()
        lblAverageMonthlyRainfall.ResetText()
        lblZeroCount.ResetText()
        ' Reset Data Display
        txtDataDisplay.ResetText()

        ' Reset Data Entry
        txtDataEntry.ResetText()

        btnInputAndDisplayStats.Enabled = True
        AcceptButton = btnInputAndDisplayStats

        ' Reset Month
        currentMonth = 1

        ' Set Focus Back to Data Entry
        txtDataEntry.Focus()
    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        ' Close the form, exiting the application
        Me.Close()

    End Sub
End Class
