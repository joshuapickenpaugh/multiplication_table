Public Class frmMain

    Dim tblDisp As New TableDisplayer()

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnDisplayTables_Click(sender As Object, e As EventArgs) Handles btnDisplayTables.Click

        'Gets user input, sets it to variable in TableDisplayer class:
        tblDisp.UserInput = txtUserInput.Text

        lstNumbers.Items.Add(tblDisp.MakeTable())

    End Sub
End Class
