' 
' Name:         Ice Cream - 1A
'
' Author:       William Villeneuve
' Date:         January 10, 2014
' 
' Description:  Windows forms application which calculates the price of an ice cream sundae at "Will's Ice Cream Parlour".
'               Users must select a flavour of ice cream (Chocolate, Vanilla, Mint Chocolate, etc.),
'                       the number of scoops (1-9),
'                       the number of toppings (0-3),
'                       and optionally any extras (Whipped Cream or Nuts).
'               Then they click the calculate button to display the total cost.
'               Hot keys are available to easy data entry.
'               Tooltips display helpful tips on certain controls.
' 

Public Class IceCreamForm

    '' Constants ''
    '''''''''''''''

    ' Flavour Prices
    Const STANDARD_FLAVOUR_PRICE As Double = 0.75 ' Price of a scoop of the Standard Flavours (Vanilla, Chocolate or Strawberry)
    Const PREMIUM_FLAVOUR_PRICE As Double = 0.85 '  Price of a scoop of the Premium  Flavours (Mint Chocolate, Napolean, Bubble Gum, Moose Tracks)
    ' Topping Price
    Const TOPPING_PRICE As Double = 0.75 '      Price of toppings
    ' Extras' Prices
    Const NUTS_PRICE As Double = 0.6 '          Price of Nuts
    Const WHIPPED_CREAM_PRICE As Double = 0.8 ' Price of Whipped Cream


    '' Functions ''
    '''''''''''''''

    ''' <summary>
    ''' Trys to retrieve the Number of Scoops
    ''' </summary>
    ''' <param name="scoops"></param>
    ''' <returns>Whether a value was recieved</returns>
    ''' <remarks></remarks>
    Private Function tryGetNumberOfScoops(ByRef scoops As Integer) As Boolean
        ' Return value indicating whether we retrieved a value & Stored it in scoops
        Dim success As Boolean = True

        ' Try Parsing Number of Scoops
        If Not Integer.TryParse(txtScoops.Text, scoops) Then
            ' Failed to retrieve a value
            success = False
        End If

        ' Return indicates if we successfully recieved a value
        Return success
    End Function

    ''' <summary>
    ''' Trys to retrieve the Number of Toppings
    ''' </summary>
    ''' <param name="toppings"></param>
    ''' <returns>Whether a value was recieved</returns>
    ''' <remarks></remarks>
    Private Function tryGetNumberOfToppings(ByRef toppings As Integer) As Boolean
        ' Return value indicating whether we retrieved a value & Stored it in toppings
        Dim success As Boolean = True

        ' Select Number of Toppings
        If rdoNoToppings.Checked Then ' None
            toppings = 0

        ElseIf rdoOneTopping.Checked Then ' One
            toppings = 1

        ElseIf rdoTwoToppings.Checked Then ' Two
            toppings = 2

        ElseIf rdoThreeToppings.Checked Then ' Three
            toppings = 3

        Else ' No Checkboxes Selected
            success = False
        End If

        ' Return indicates if we successfully recieved a value
        Return success
    End Function

    ''' <summary>
    ''' Trys to retrieve the Flavour
    ''' </summary>
    ''' <param name="flavour"></param>
    ''' <returns>Whether a value was recieved</returns>
    ''' <remarks></remarks>
    Private Function tryGetFlavour(ByRef flavour As Integer) As Boolean
        ' Return value indicating whether we retrieved a value & Stored it in flavour
        Dim success As Boolean = False

        ' Check if an item is selected
        If Not lstFlavours.SelectedIndex = -1 Then
            ' An Item is Selected
            flavour = lstFlavours.SelectedIndex
            ' Successfully Retrieved a flavour
            success = True
        End If

        ' Return indicates if we successfully recieved a value
        Return success
    End Function

    '' Methods ''
    '''''''''''''

    ''' <summary>
    ''' Calculates the price with the current options, if a required option is not set then a MessageBox displays an error
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Handles the btnCalculate Click Event</remarks>
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        '' Variables ''
        ' Set with tryRetrieving functions
        Dim numOfScoops As Integer '   Number of Scoops   (1-9)
        Dim numOfToppings As Integer ' Number of Toppings (0-3)
        Dim flavour As Integer '       Flavour of Ice Cream (0-6) (0-2 Standard, 3-6 Premium)

        ' Total Amount Due
        Dim totalDue As Double = 0.0


        '' Processing ''

        If (Not tryGetNumberOfScoops(numOfScoops)) Or (numOfScoops = 0) Then ' Attempt to retrieve the number of scoops
            ' Number of Scoops Not Set OR set to 0
            ' Notify User of Error
            MessageBox.Show("The number of scoops must be a number between 1 and 9.", "Invalid Entry")

            ' Set focus to scoops text box & select all text
            txtScoops.Focus()
            txtScoops.SelectAll()

        ElseIf Not tryGetNumberOfToppings(numOfToppings) Then ' Attempt to retrieve the number of toppings
            ' Number of Toppings Not Set
            ' Notify User of Error
            MessageBox.Show("Must select the number of toppings.", "Invalid Entry")

        ElseIf Not tryGetFlavour(flavour) Then ' Attempt to retrieve the flavour
            ' Number of Toppings Not Set
            ' Notify User of Error
            MessageBox.Show("You must select a flavour.", "Invalid Entry")

        Else ' Retrieved all user input, Calculate Total

            ' Add price for scoops to the totalDue
            Select Case flavour
                Case 0 To 2 ' Standard Flavours
                    ' Multiply the Standard Flavour Price by the number of scoops
                    totalDue += numOfScoops * STANDARD_FLAVOUR_PRICE

                Case 3 To (lstFlavours.Items.Count - 1)  ' Premium Flavours
                    ' Multiply the Premium Flavour Price by the number of scoops
                    totalDue += numOfScoops * PREMIUM_FLAVOUR_PRICE
            End Select

            ' Add price for toppings
            totalDue += numOfToppings * TOPPING_PRICE

            ' Add price for Extras (If Set)
            ' Nuts
            If chkNuts.Checked Then
                totalDue += NUTS_PRICE
            End If
            ' Whipped Cream
            If chkWhippedCream.Checked Then
                totalDue += WHIPPED_CREAM_PRICE
            End If

            ' Display Total in Result Label
            lblResultTotal.Text = String.Format("{0:c}", totalDue)
        End If
    End Sub

    ''' <summary>
    ''' Sets the form to its initial state and returns focus to the Scoops TextBox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Handles the btnClear Click Event</remarks>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Deselect Flavour
        lstFlavours.ClearSelected()

        ' UnCheck Topping (Only one can be checked at a time so if one is found then we uncheck it and move on)
        If rdoNoToppings.Checked Then ' None
            rdoNoToppings.Checked = False

        ElseIf rdoOneTopping.Checked Then ' One
            rdoOneTopping.Checked = False

        ElseIf rdoTwoToppings.Checked Then ' Two
            rdoTwoToppings.Checked = False

        ElseIf rdoThreeToppings.Checked Then ' Three
            rdoThreeToppings.Checked = False
        End If

        ' UnCheck Extras
        chkNuts.Checked = False
        chkWhippedCream.Checked = False

        ' Clear TotalDue
        lblResultTotal.ResetText()

        ' Clear Scoops
        txtScoops.ResetText()

        ' Return Focus to Scoops
        txtScoops.Focus()
    End Sub

    ''' <summary>
    ''' Close the Form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Handles the btnExit Click Event</remarks>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the Form, Thus Exiting the Application
        Close()
    End Sub

End Class '' IceCreamForm