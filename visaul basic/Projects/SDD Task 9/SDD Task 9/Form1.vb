Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name As String 'declares a variable called name which will store the name entered by the user

        name = InputBox("Enter your name") 'An inputbox is used to allow the user to enter their name using an inputbox.
        'This string of characters is then stored in the Variable 'name'

        For counter = 1 To 5 'a counter is used to fix the number of times the following code will loop, 5 times in this program

            ListBox1.Items.Add(name) 'alistbox is used to disp;ay the name variable
        Next


    End Sub
End Class
