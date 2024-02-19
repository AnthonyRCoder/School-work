Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim password As Integer 'declares a variable called password which will store a numerical password
        Dim user_input As Integer 'declares a variable called user_input which will store the input from the user

        password = 2134  'assigns the value 2134 to the variable password
        user_input = InputBox("Please enter Password") 'An inputbox is used to allow the user to enter a numerical password using an inputbox.
        'This integer is then stored in the variable 'user_input'.

        Do While user_input <> password 'the user

            MsgBox("ACCESS DENIED")
            user_input = InputBox("Please Re-enter password")



        Loop
        MsgBox("ACCESS GRANTED")


    End Sub
End Class
