Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Real_Number As Single ' declares a variable called number which will store a whole number (integer)

        Real_Number = InputBox("Please enter a Real number") 'An inputerBox is displayed showing a message and the real nuber the user enteres

        MsgBox("The number you entered is:" & Real_Number) ' A msgBox is displayed showing a message and the real number the user entered


    End Sub
End Class
