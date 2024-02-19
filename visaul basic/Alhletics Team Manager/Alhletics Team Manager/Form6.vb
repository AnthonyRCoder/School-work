Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Code to display 10 greetings on the screen
        'by a much better programmer
        'using a FOR..NEXT loop

        Dim counter As Integer


        For counter = 1 To 10
            lstMessage.Items.Add("Have a nice day!")
        Next
    End Sub
End Class