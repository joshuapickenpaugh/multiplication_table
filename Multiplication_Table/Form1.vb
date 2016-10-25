Public Class frmMain

    Dim decUserInput As Decimal

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnDisplayTables_Click(sender As Object, e As EventArgs) Handles btnDisplayTables.Click

        decUserInput = txtUserInput.Text

        MakeTable()

    End Sub

    Public Sub MakeTable()

        Dim decProduct As Decimal
        Dim strEquation As String
        Dim strDecProduct As String
        Dim strDecUserInput As String
        Dim strIntCounter As String

        For intCounter As Integer = 1 To 9
            decProduct = decUserInput * intCounter
            strDecProduct = decProduct.ToString()
            strDecUserInput = decUserInput.ToString()
            strIntCounter = intCounter.ToString()
            strEquation = strDecUserInput & " * " & strIntCounter & " = " & strDecProduct
            lstNumbers.Items.Add(strEquation)
        Next intCounter

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtUserInput.Text = String.Empty
        lstNumbers.Items.Clear()

    End Sub
End Class
