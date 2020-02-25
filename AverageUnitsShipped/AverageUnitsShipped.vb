' Author:       Scott Alton
' Date:         January 26, 2020
' File Name:    AverageUnitsShipped.vb
' Description:  This application takes in the daily number of units shipped from a user. Once a week's worth
'               of data is entered, this application calculates and displays the average number of units 
'               shipped per day for that week. 

Option Strict On

Public Class frmAverageUnitsShipped

    Dim currentDay As Integer = 1
    Dim totalUnitsShipped As Double = 0

    ''' <summary>
    ''' Event handler for Exit Button - close the application 
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Event handler for Reset Button - reset variables, input and output fields to default state.
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Reset variables to default state
        currentDay = 1
        totalUnitsShipped = 0

        'Reset fields to opening state
        lblAverageOutput.Text = ""
        txtEnteredUnits.Clear()
        txtUnitsInput.Clear()
        lblDay.Text = "Day 1"

        'Re-enble potentially disable controls
        txtUnitsInput.Enabled = True
        btnEnter.Enabled = True

        'Set focus back to input textbox
        txtUnitsInput.Focus()

    End Sub

    ''' <summary>
    ''' Validates the user's input and adds it to list of units shipped, then increments the total accordingly, 
    ''' and finally displays the average units shipped before disabling Enter button
    ''' </summary>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Const DaysInWeek = 7
        Dim averageUnitsShipped As Double
        Dim currentUnitsShipped As Double

        If Double.TryParse(txtUnitsInput.Text, currentUnitsShipped) Then

            ' The entered units value is validated as a number between 0 and 5000
            If currentUnitsShipped <= 5000 And currentUnitsShipped >= 0 Then

                ' Increment the day and total units shipped
                currentDay += 1
                totalUnitsShipped += currentUnitsShipped

                ' Add units shipped for that day to the list
                txtEnteredUnits.Text &= currentUnitsShipped & vbCrLf
                txtUnitsInput.Clear()

                ' If 7 days worth of data entered, disable Enter button and units input field and process
                If currentDay > DaysInWeek Then
                    txtUnitsInput.Enabled = False
                    btnEnter.Enabled = False

                    ' Calculate average units and display to user
                    averageUnitsShipped = totalUnitsShipped / DaysInWeek
                    lblAverageOutput.Text = "Average Units Per Day: " & Math.Round(averageUnitsShipped, 2)
                    btnEnter.Focus()

                Else

                    lblDay.Text = "Day " & currentDay
                    txtUnitsInput.Focus()

                End If

            Else

                ' The entered number is not within the acceptable range.
                MessageBox.Show("Please enter a total between 0 and 5000.")
                txtUnitsInput.SelectAll()
                txtUnitsInput.Focus()

            End If

        Else

            ' The entered number of units is NOT a number
            MessageBox.Show("That's not a number. Please try again.")
            txtUnitsInput.SelectAll()
            txtUnitsInput.Focus()

        End If

    End Sub

End Class
