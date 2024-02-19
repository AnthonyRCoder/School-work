Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Anthony Rozario 
        '15/3/18
        'Task2


        'A program is required to display the five readings taken at the event and a signal pattern. 
        'The signal will show the show the strength of readings in the order the readings were taken(1 to 5) 

        Dim readings(4) As Single 'declare readings 1 to 3 as decimal number
        Dim counter As Integer 'declare counter as whole number
        Dim Sign(4) As Char 'declare Sign 5 variable as chareter 
        Dim message As String 'declare message as text
        Dim Round(4) As Single 'declare round 5 variable as decimal number


        For counter = 0 To 4 'count 5 times

            readings(counter) = InputBox("Enter the signal number") 'Input a Sign readings into variable called reading
            Do While readings(counter) > 100 Or readings(counter) < 0 'checking number is not less than 0 and not greater than 100
                readings(counter) = InputBox("Invalid number, please enter the signal number") 'ask for a another number because of the number is invalid 
            Loop
            Round(counter) = Math.Round(readings(counter), 0) 'round the reading to zero decimal place

            If readings(counter) > 80 Then 'if readings is greater than 80 display Strong
                Sign(counter) = "S"

            ElseIf readings(counter) < 30 Then 'if readings is less than 30 display Poor
                Sign(counter) = "P"

            Else
                Sign(counter) = "M" 'if the readings is between 30 and 80 display Medium

            End If
            message = Sign(0) + Sign(1) + Sign(2) + Sign(3) + Sign(4) '  all signals are gathered together to make a message
            MsgBox(message) 'Display the message

            ListBox1.Items.Add(readings(counter)) 'display the readings number
            ListBox2.Items.Add(Round(counter)) 'display the rounded number
        Next





    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class
