'Joshua Hitchcock
'Assignment #3 Change
'Program to calculate correct change

Public Class frmChange

    'Calculates correct change when calculate is clicked

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim intChange As Integer

        lblChangeAmt.Text = FormatCurrency(Val(txtPaid.Text) - Val(txtOwed.Text))
        intChange = (Val(txtPaid.Text) - Val(txtOwed.Text)) * 100
        lblAmtDollar.Text = intChange \ 100
        intChange = intChange Mod 100
        lblAmtQuarter.Text = intChange \ 25
        intChange = intChange Mod 25
        lblAmtDime.Text = intChange \ 10
        intChange = intChange Mod 10
        lblAmtNickle.Text = intChange \ 5
        lblAmtPenny.Text = intChange Mod 5


    End Sub

    'Clears all information from the form on clear button click
    'Resets focus to top textbox on form

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtOwed.Text = " "
        txtPaid.Text = " "
        lblChangeAmt.Text = " "
        lblAmtDollar.Text = " "
        lblAmtQuarter.Text = " "
        lblAmtDime.Text = " "
        lblAmtNickle.Text = " "
        lblAmtPenny.Text = " "
        txtOwed.Focus()

    End Sub

    'Closes form on exit button click

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Sets the focus to the top textbox on the form

    Private Sub frmChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtOwed.Focus()
    End Sub
End Class
