Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim number As Integer ' declares a varible called number which will store a whole number (integer)

        number = InputBox("Please enter a number") ' An InputerBox is used to allow the user to enter a number. This is then stored in the varlable "number"

        MsgBox(" the number you entered is: " & number) ' A msgBox is displayed shooting a message and the number the user entered 




    End Sub
End Class
