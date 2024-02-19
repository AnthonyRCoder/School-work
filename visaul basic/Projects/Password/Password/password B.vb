Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim password As Integer 'declares a variable called password which will store a numerical password
        Dim user_input As Integer 'declares a variable called user_input which will store the input from the user

        password = 144  'assigns the value 2017 to the variable password
        user_input = InputBox("what is answer to 12*12?") 'An inputbox is used to allow the user to enter a numerical password using an inputbox.
        'This integer is then stored in the variable 'user_input'.

        If user_input = password Then 'the user_input is compared to the password. If the values in the variables are equal the condition is true.
            MsgBox("Right") 'A msgbox is displayed showing a message.
        End If

        If user_input <> password Then 'the user_input is compared is to the password. If the  values in the variables are NOT equal then the condition is true.
            MsgBox("wrong") 'A msgbox is displayed showing a message
        End If



    End Sub
End Class
