' 
' Name:         Bowling Average - 1A
'
' Author:       William Villeneuve
' Date:         January 23, 2014
' 
' Description:  Windows forms application which calculates average score of set of bowling scores.
'                   Users enter 5 scores from 1-300 and upon entering the 5th score the average is
'                   automatically calculated and displayed. Also the Enter Scores button is disabled &
'                   the forms accept button is set to the Reset button.
'               Hot keys are available to easy data entry.
'               Tooltips display helpful tips on certain controls.
' 

Public Class BowlingAverageForm
    '' Constants ''
    '''''''''''''''

    ' The number of game scores that can be entered
    Private Const NUMBER_OF_GAMES As Integer = 5
    ' Lowest Bowling Score (Or so Bill thinks)
    Private Const LOWEST_SCORE As Integer = 1
    ' Highest Possible Bowling Score
    Private Const HIGHEST_SCORE As Integer = 300

    ' Template text for lblGameScorePrompt
    Private Const GAME_SCORE_PROMPT As String = "&Enter bowling score for game #"
    ' Template text for Game Average
    Private Const GAME_AVERAGE_RESULT As String = "Five game average: "


    '' Variables ''
    '''''''''''''''

    ' The game scores
    Private scores(NUMBER_OF_GAMES - 1) As Integer
    ' Current Game
    Private currentGame As Integer = 1


    '' Methods ''
    '''''''''''''

    ''' <summary>
    ''' Attempts to enter a game score, if it is the last score(5th) it and calculates the average
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnEnterScore_Click(sender As Object, e As EventArgs) Handles btnEnterScore.Click
        ' Entered Game Score
        Dim score As Integer

        ' Try parsing the user input into an integer
        If Not Integer.TryParse(txtScore.Text, score) Then
            ' Display non numeric error
            MessageBox.Show("Please enter a numeric score")

        ElseIf (score < LOWEST_SCORE) Or (score > HIGHEST_SCORE) Then ' Check that score isn't out of range
            ' Display Out of Range Error
            MessageBox.Show("Please enter a score between " & LOWEST_SCORE & " and " & HIGHEST_SCORE)

        Else ' Recieved a proper score

            ' Add score to scores array
            scores(currentGame - 1) = score

            ' Append score to game scores text box
            '  - When Not that last score, Change prompt label to next game number
            ' Also if added the last score then,
            '  - Calculate average & display
            If currentGame < NUMBER_OF_GAMES Then
                txtGameScores.AppendText(score & vbCrLf) ' Append score with newline

                ' Change prompt label to next game number
                lblGameScorePrompt.Text = GAME_SCORE_PROMPT & (currentGame + 1)

                ' Clear Score 
                txtScore.ResetText()
            Else
                ' Average of the entered Games
                Dim average As Double

                ' The last score is appended without a newlineg
                txtGameScores.AppendText(score)

                ' Calculate Average
                average = scores.Sum / NUMBER_OF_GAMES


                ' Change Accept Button to Reset
                AcceptButton = btnReset

                ' Disable Enter Score Button
                btnEnterScore.Enabled = False


                ' Display Average
                lblGameAverage.Text = GAME_AVERAGE_RESULT & average

            End If

            ' Increment Game Number
            currentGame += 1
        End If
    End Sub

    ''' <summary>
    ''' Reset the form to it's original state
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Reset Score
        txtScore.ResetText()
        ' Set Focus to Score
        txtScore.Focus()

        ' Reset Scores
        txtGameScores.ResetText()

        ' Reset Accept Button to Enter Score
        AcceptButton = btnEnterScore

        ' Re-enable Enter Score Button
        btnEnterScore.Enabled = True

        ' Reset Average Label
        lblGameAverage.ResetText()

        ' Reset Gamme Counter
        currentGame = 1

        ' Change prompt label to game number 1
        lblGameScorePrompt.Text = GAME_SCORE_PROMPT & currentGame

    End Sub

    ''' <summary>
    ''' Closes this form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes this form, thus exitiing the application
        Close()
    End Sub
End Class
