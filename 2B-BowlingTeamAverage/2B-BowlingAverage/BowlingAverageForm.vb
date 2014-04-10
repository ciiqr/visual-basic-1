' 
' Name:         Bowling Average - 2B
'
' Author:       William Villeneuve
' Date:         February 02, 2014
' 
' Description:  Windows forms application which calculates average bowling score of each player and the whole team.
'                   Users enter 5 scores from 1-300 and upon entering the 5th score the average is
'                   automatically calculated and displayed. Then they move on to the next player.
'                   Once the last score of the last player is entered the team average is calculated and displayed.
'                   Also the Enter Scores button is disabled & the forms accept button is set to the Reset Team button.
'               Users can reset the scores for the current player.
'               Hot keys are available to easy data entry.
'               Tooltips display helpful tips on certain controls.
' 

Public Class BowlingTeamAverageForm
    '' Constants ''
    '''''''''''''''

    ' The number of game scores that can be entered
    Private Const NUMBER_OF_GAMES As Integer = 5
    ' The number of players on the team
    Private Const NUMBER_OF_PLAYERS As Integer = 4

    ' Lowest Bowling Score (Or so Bill thinks)
    Private Const LOWEST_SCORE As Integer = 1
    ' Highest Possible Bowling Score
    Private Const HIGHEST_SCORE As Integer = 300

    ' Template text for lblGameScorePrompt
    Private Const GAME_SCORE_PROMPT As String = "&Enter bowling score for game #"
    ' Template text for Game Average
    Private Const TEAM_AVERAGE_RESULT As String = "Team average: "


    '' Variables ''
    '''''''''''''''

    ' Array of txtGameScores's
    Private txtGameScoresArray(NUMBER_OF_PLAYERS - 1) As TextBox
    ' Array of lblGameAverage's
    Private lblGameAverageArray(NUMBER_OF_PLAYERS - 1) As Label

    ' The game scores
    Private teamScores(NUMBER_OF_PLAYERS - 1, NUMBER_OF_GAMES - 1) As Integer
    ' Current Game
    Private currentGame As Integer = 1
    ' Current Player
    Private currentPlayer As Integer = 0


    '' Methods ''
    '''''''''''''

    ''' <summary>
    ''' Initalizes Some Properties
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BowlingTeamAverageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize Game Average Label Array
        lblGameAverageArray(0) = lblGameAverage1
        lblGameAverageArray(1) = lblGameAverage2
        lblGameAverageArray(2) = lblGameAverage3
        lblGameAverageArray(3) = lblGameAverage4

        ' Initialize Game Scores Textbox Array
        txtGameScoresArray(0) = txtGameScores1
        txtGameScoresArray(1) = txtGameScores2
        txtGameScoresArray(2) = txtGameScores3
        txtGameScoresArray(3) = txtGameScores4
    End Sub

    ''' <summary>
    ''' Attempts to enter a game score, if it is the last score(5th) it and calculates the average of the bowler and moves on to the next (If the last bowler then displayes the team average)
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
            teamScores(currentPlayer, currentGame - 1) = score

            ' Append score to game scores text box
            '  - When Not that last score, Change prompt label to next game number
            ' Also if added the last score then,
            '  - Calculate average & display
            If currentGame < NUMBER_OF_GAMES Then
                txtGameScoresArray(currentPlayer).AppendText(score & vbCrLf) ' Append score with newline

                ' Increment Game Number
                currentGame += 1

                ' Change prompt label to next game number
                lblGameScorePrompt.Text = GAME_SCORE_PROMPT & currentGame

                ' Clear Score 
                ' txtScore.ResetText()

            Else
                ' Average of the entered Games
                Dim average As Double = 0

                ' The last score is appended without a newlineg
                txtGameScoresArray(currentPlayer).AppendText(score)

                ' Calculate Average
                ' Itterate Scores for current Player
                For gameIndex = 0 To (NUMBER_OF_GAMES - 1)
                    ' Add score to average
                    average += teamScores(currentPlayer, gameIndex)
                Next
                ' Divide Summed Scores
                average /= NUMBER_OF_GAMES


                ' Entered Last Score of Last Player
                If Not currentPlayer < (NUMBER_OF_PLAYERS - 1) Then

                    Dim teamAverage As Double = 0

                    ' Itterate Array & Calulate Team Average
                    ' Itterate Each Player
                    For playerIndex = 0 To (NUMBER_OF_PLAYERS - 1)
                        ' Itterate Each Score
                        For gameIndex = 0 To (NUMBER_OF_GAMES - 1)
                            ' Add Score to team Average
                            teamAverage += teamScores(playerIndex, gameIndex)
                        Next
                    Next

                    ' Divide summed scores
                    teamAverage /= NUMBER_OF_PLAYERS * NUMBER_OF_GAMES


                    ' Display Team Average
                    lblTeamAverage.Text = TEAM_AVERAGE_RESULT & teamAverage


                    ' Make Team Average Label Visible
                    lblTeamAverage.Visible = True

                    ' Disable Reset Player Button
                    btnResetPlayer.Enabled = False

                    ' Disable Enter Score Button
                    btnEnterScore.Enabled = False

                    ' Change Accept Button to Team Reset
                    AcceptButton = btnResetTeam

                End If

                ' Display Average
                lblGameAverageArray(currentPlayer).Text = average

                ' Make Game Average Visible
                lblGameAverage.Visible = True


                ' Increment Player
                currentPlayer += 1

                ' Reset Current Game to 1 (For Next Player)
                currentGame = 1

                ' Change prompt label to next game number
                lblGameScorePrompt.Text = GAME_SCORE_PROMPT & currentGame

            End If
            ' Clear Score 
            txtScore.ResetText()
        End If
    End Sub

    ''' <summary>
    ''' Clears the scores of the current player
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnResetPlayer_Click(sender As Object, e As EventArgs) Handles btnResetPlayer.Click
        ' At least 1 score has been entered for the current player
        If Not currentGame = 1 Then
            ' Reset Game Scores for Current Player
            txtGameScoresArray(currentPlayer).ResetText()
            ' Reset Gamme Counter
            currentGame = 1
            ' Change prompt label to game number 1
            lblGameScorePrompt.Text = GAME_SCORE_PROMPT & currentGame

        Else ' No Scores have been entered yet for this player
            MessageBox.Show("Nothing to Clear!")
        End If
    End Sub

    ''' <summary>
    ''' Reset the form to it's original state
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnResetTeam_Click(sender As Object, e As EventArgs) Handles btnResetTeam.Click
        ' Reset Score
        txtScore.ResetText()
        ' Set Focus to Score
        txtScore.Focus()

        ' Reset Scores & Averages (Only for the players that have been entered)
        For playerIndex = 0 To (currentPlayer - 1)
            ' Reset Player Scores List
            txtGameScoresArray(playerIndex).ResetText()

            ' Reset Player Average Label
            lblGameAverageArray(playerIndex).ResetText()
        Next

        ' Reset Average Label
        lblTeamAverage.ResetText()


        ' Reset Accept Button to Enter Score
        AcceptButton = btnEnterScore


        ' Re-enable Enter Score Button
        btnEnterScore.Enabled = True

        ' Re-enable Reset Player Button
        btnResetPlayer.Enabled = True


        ' Hide Team Average Label
        lblTeamAverage.Visible = False

        ' Make Game Average Visible
        lblGameAverage.Visible = False


        ' Reset Gamme Counter
        currentGame = 1

        ' Reset Player Counter
        currentPlayer = 0

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
