Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim readings(4) As Integer
        Dim counter As Integer
        Dim Sign(4) As Char
        Dim message As String

       
        For counter = 0 To 4
            readings(counter) = InputBox("Enter the signal number")
            Do While readings(counter) >= 100 And readings(counter) <= 0
                readings(counter) = InputBox("Invalid number, please enter the signal number")
            Loop
                If readings(counter) > 80 Then
                Sign(counter) = "S"

            ElseIf readings(counter) < 30 Then
                Sign(counter) = "P"

            Else
                Sign(counter) = "M"


                End If
            Next

        message = Sign(0) + Sign(1) + Sign(2) + Sign(3) + Sign(4)
        MsgBox(message)


    End Sub
End Class
