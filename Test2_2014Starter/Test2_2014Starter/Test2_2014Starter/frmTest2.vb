Public Class frmTest2

    Private Sub search(searchHigher As Boolean)
        Dim quantity As String = txtsearch.Text.Trim()
        Dim comparCharacter As Char
        If searchHigher Then
            comparCharacter = ">"
        Else
            comparCharacter = "<"
        End If

        If Not IsNumeric(quantity) Then
            MessageBox.Show("Quantity must be numeric", "Search Error")
            txtsearch.Text = ""
            txtsearch.Focus()
            grpInfo.Visible = False
            Exit Sub
        End If

        ' OK the search text is OK, code your check higher filter here..
        Part_tabBindingSource.Filter = "QOH" & comparCharacter & quantity

        If Part_tabBindingSource.Count > 0 Then ' Theres Multiple Records
            ' Display Group
            grpInfo.Visible = True

            ' Buttons Appropriatly
            PositionChanged()

            ' 
            If Part_tabBindingSource.Count = 1 Then ' 1 Item
                lblStatus.Text = "Here is your requested part"
            Else ' Multiple Items
                lblStatus.Text = Part_tabBindingSource.Count & " Records match your criteria"
            End If

        Else ' No Records Found
            lblStatus.Text = "There are no products with Quantity " & comparCharacter & " than " & quantity
        End If
    End Sub

    Private Sub btnSearchHi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchHi.Click
        search(True)
    End Sub

    Private Sub btnSearchLo_Click(sender As Object, e As EventArgs) Handles btnSearchLo.Click
        search(False)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close The form
        Me.Close()
    End Sub

    Private Sub Part_tabBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Part_tabBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VB_Test2DataSet)

    End Sub

    Private Sub frmTest2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VB_Test2DataSet.part_tab' table. You can move, or remove it, as needed.
        Me.Part_tabTableAdapter.Fill(Me.VB_Test2DataSet.part_tab)

    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        ' Go Back a Record
        Part_tabBindingSource.MovePrevious()

        ' Change Label & Buttons Enabled Status
        PositionChanged()

        ' Position Label
        lblStatus.Text = "Record #" & (Part_tabBindingSource.Position + 1)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Go Forward a record
        Part_tabBindingSource.MoveNext()

        ' Change Label & Buttons Enabled Status
        PositionChanged()

        ' Position Label
        lblStatus.Text = "Record #" & (Part_tabBindingSource.Position + 1)
    End Sub

    Private Sub PositionChanged()
        ' 
        If Part_tabBindingSource.Position = 0 Then ' At the Start
            ' Enable / Disable Buttons
            btnSub.Enabled = False
        Else
            btnSub.Enabled = True
        End If

        If Part_tabBindingSource.Position = (Part_tabBindingSource.Count - 1) Then ' At The End
            ' Enable / Disable Buttons
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        ' Hide Info
        grpInfo.Visible = False

        ' Focus Search Box
        txtsearch.Focus()

        ' 
        lblStatus.ResetText()
    End Sub
End Class