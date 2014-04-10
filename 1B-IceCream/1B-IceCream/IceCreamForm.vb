' 
' Name:         Ice Cream - 1B
'
' Author:       William Villeneuve
' Date:         January 20, 2014
' 
' Description:  Windows forms application which calculates the price of an ice cream sundae at "Will's Ice Cream Parlour".
'               Users must select a flavour of ice cream (Chocolate, Vanilla, Mint Chocolate, etc.),
'                       the number of scoops (1-9),
'                       the number of toppings (0-3),
'                       and optionally any extras (Whipped Cream or Nuts).
'               Then they click the calculate button to display the total cost.
'               Hot keys are available to easy data entry.
'               Tooltips display helpful tips on certain controls.
'               Upon trying to select options other without properly setting a number of scoops,
'                       a message is displayed nofifying the user that they need to enter the number of scoops
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
    ' HST
    Const TAX_HST As Double = 0.13 ' Tax amount to be calculated for the subTotal


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

        ' If 0 Then Failed
        If scoops = 0 Then
            ' Can't have 0 scoops of ice cream
            success = False
        End If

        ' Return indicates if we successfully recieved a value
        Return success
    End Function

    ''' <summary>
    ''' Retrieves the Number of Toppings
    ''' </summary>
    ''' <returns>The selected number of toppings</returns>
    ''' <remarks></remarks>
    Private Function getNumberOfToppings() As Integer
        ' Return value (number of toppings)
        Dim toppings As Integer

        ' Select Number of Toppings
        If rdoNoToppings.Checked Then ' None
            toppings = 0

        ElseIf rdoOneTopping.Checked Then ' One
            toppings = 1

        ElseIf rdoTwoToppings.Checked Then ' Two
            toppings = 2

        ElseIf rdoThreeToppings.Checked Then ' Three
            toppings = 3
        End If

        ' Return value
        Return toppings
    End Function

    ''' <summary>
    ''' Calculates the HST on the price
    ''' </summary>
    ''' <param name="price"></param>
    ''' <returns>The HST on the price</returns>
    ''' <remarks></remarks>
    Private Function HST(ByVal price As Double) As Double
        ' Determine the hst for the price
        Return TAX_HST * price
    End Function

    '' Methods ''
    '''''''''''''

    ''' <summary>
    ''' Initialize Form Properties
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub IceCreamForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load Flavours into Flavours List
        lstFlavours.Items.Add("Vanilla")
        lstFlavours.Items.Add("Chocolate")
        lstFlavours.Items.Add("Strawberry")
        lstFlavours.Items.Add("Mint Chocolate")
        lstFlavours.Items.Add("Napolean")
        lstFlavours.Items.Add("Bubble Gum")
        lstFlavours.Items.Add("Moose Tracks")
        lstFlavours.Items.Add("Raspberry Twist")

        ' Have First Flavour Selected by Default
        lstFlavours.SetSelected(0, True)
    End Sub

    ''' <summary>
    ''' Calculates the price with the current options, if a required option is not set then a MessageBox displays an error
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Handles the btnCalculate Click Event</remarks>
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        '' Variables ''
        ' Possibly not set
        Dim numOfScoops As Integer ' Number of Scoops   (1-9)
        ' Will always have a value
        Dim flavour As Integer ' Flavour of Ice Cream (0-6) (0-2 Standard, 3-6 Premium)
        Dim numOfToppings As Integer ' Number of Toppings (0-3)

        ' Sub-Total before Taxes
        Dim subTotal As Double = 0.0
        ' Taxes of subTotal
        Dim taxes As Double
        ' Total Amount Due
        Dim grandTotal As Double


        '' Processing ''

        ' Change Focus to sender (btnCalculate)
        ' -  Without this, when using keyboard short cuts to activate the calculate button,
        ' -     the focus is not set to the button before calculating
        ' -  Therefore when the focus is on txtScoops and we use the shortcut for the calculate button
        ' -     it will display the MessageBox then display the MessageBox again from this method
        CType(sender, Button).Focus() ' Cast sender to Button, Set focus to button

        If Not tryGetNumberOfScoops(numOfScoops) Then ' Attempt to retrieve the number of scoops
            ' Number of Scoops Not Set
            ' Notify User of Error
            MessageBox.Show("The number of scoops must be a number between 1 and 9.", "Invalid Entry")

        Else ' Retrieved the number of scoops, Calculate Totals & Taxes

            ' Retrieve the number of toppings
            numOfToppings = getNumberOfToppings()

            ' Retrieve the selected flavour
            flavour = lstFlavours.SelectedIndex

            ' Add price for scoops to the totalDue
            If flavour <= 2 Then ' Standard Flavours
                ' Multiply the Standard Flavour Price by the number of scoops
                subTotal += numOfScoops * STANDARD_FLAVOUR_PRICE
            Else ' Premium Flavours
                ' Multiply the Premium Flavour Price by the number of scoops
                subTotal += numOfScoops * PREMIUM_FLAVOUR_PRICE
            End If

            ' Add price for toppings
            subTotal += numOfToppings * TOPPING_PRICE

            ' Add price for Extras (If Set)
            ' Nuts
            If chkNuts.Checked Then
                subTotal += NUTS_PRICE
            End If
            ' Whipped Cream
            If chkWhippedCream.Checked Then
                subTotal += WHIPPED_CREAM_PRICE
            End If

            ' Calculate the Taxes
            taxes = HST(subTotal)

            ' Add Taxes to Subtotal for Grand Total
            grandTotal = subTotal + taxes


            ' Display Sub-Total
            lblSubTotal.Text = FormatCurrency(subTotal)

            ' Display Taxes
            lblHST.Text = FormatCurrency(taxes)

            ' Display Total in Result Label
            lblGrandTotal.Text = FormatCurrency(grandTotal)
        End If
    End Sub

    ''' <summary>
    ''' Sets the form to its initial state and returns focus to the Scoops TextBox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Handles the btnClear Click Event</remarks>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Select First Flavour
        lstFlavours.SetSelected(0, True)

        ' Reset Toppings to No Toppings
        rdoNoToppings.Checked = True

        ' UnCheck Extras
        chkNuts.Checked = False
        chkWhippedCream.Checked = False

        ' Clear GrandTotal
        lblGrandTotal.ResetText()

        ' Clear SubTotal
        lblSubTotal.ResetText()

        ' Clear HST
        lblHST.ResetText()

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
        ' Change Focus to sender (btnExit)
        ' -  Without this, when using keyboard short cuts to activate the exit button,
        ' -     the focus is not set to the button before closing the form
        ' -  Therefore when the focus is on txtScoops and we use the shortcut for the exit button
        ' -     it will close the form then display the MessageBox
        CType(sender, Button).Focus() ' Cast sender to Button, Set focus to button

        ' Close the Form, Thus Exiting the Application
        Close()
    End Sub

    ''' <summary>
    ''' Validates scoops input, displays a message if not valid (Except for special cases, ie. btnExit)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtScoops_LostFocus(sender As Object, e As EventArgs) Handles txtScoops.LostFocus
        ' If Trying to Click one of the buttons don't display the error, let the user clear or exit
        ' Also don't display for the calculate button becuase it will itself display the error
        If btnExit.Focused Or btnClear.Focused Or btnCalculate.Focused Then
            Exit Sub
        Else
            Dim tempScoops As Integer
            ' Try Getting the number of scoops
            ' If it fails then the input was not valid
            If Not tryGetNumberOfScoops(tempScoops) Then
                ' Number of Scoops Not Set
                ' Notify User of Error
                MessageBox.Show("The number of scoops must be a number between 1 and 9.", "Invalid Entry")
            End If
        End If
    End Sub

    ''' <summary>
    ''' When the User changes any of the options we clear any previous output
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Handles changes of scoops, flavour, number of toppings, extras(nuts and whipped cream)</remarks>
    Private Sub inputChanged(sender As Object, e As EventArgs) Handles txtScoops.TextChanged, lstFlavours.SelectedIndexChanged,
        rdoNoToppings.CheckedChanged, rdoOneTopping.CheckedChanged, rdoTwoToppings.CheckedChanged, rdoThreeToppings.CheckedChanged,
        chkNuts.CheckedChanged, chkWhippedCream.CheckedChanged

        ' Clear Any Previuos Results When any Input Chnges

        ' Clear Grand Total
        lblGrandTotal.ResetText()
        ' Clear Sub Total
        lblSubTotal.ResetText()
        ' Clear HST
        lblHST.ResetText()
    End Sub

End Class '' IceCreamForm