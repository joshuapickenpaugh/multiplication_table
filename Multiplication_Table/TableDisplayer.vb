Public Class TableDisplayer

    Private _decUserInput As Decimal

    Public Property UserInput As Decimal
        Get
            Return _decUserInput
        End Get
        Set(value As Decimal)
            If value > 0 Then
                _decUserInput = value
            Else
                _decUserInput = 0
            End If
        End Set
    End Property

    Public Sub New()

        _decUserInput = 0

    End Sub

    Public Function MakeTable()

        Dim decProduct As Decimal
        Dim strEquation As String
        Dim strDecProduct As String
        Dim str_decUserInput As String
        Dim strIntCounter As String

        For intCounter As Integer = 1 To 9
            decProduct = _decUserInput * intCounter
            strDecProduct = decProduct.ToString()
            str_decUserInput = _decUserInput.ToString()
            strIntCounter = intCounter.ToString()
            strEquation = str_decUserInput & " * " & strIntCounter & " = " & strDecProduct
        Next intCounter

        Return strEquation

    End Function

End Class
