Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name As String
        Dim target_Average As Integer
        Dim miles_cycled1 As Integer
        Dim miles_cycled As Integer
        Dim Total As Integer
        Dim total1 As Integer

        'Anthony Rozario
        '9/2/2018
        'first input the name,target average of miles and number of miles cycled each week for four weeks
        'then calculates and displays the average number of miles cycled over the four weeks then checks if he/she has reached the target.
        'then display the message "Congratulation you have met your target" or there not reached the target then display the message 
        '" Sorry you have not met your target"

        name = InputBox("Enter Cyclist name?") 'ask for name

        target_Average = InputBox("Enter target average?") 'ask for target average

        For miles_cycled1 = 1 To 4 'count 4 times
            miles_cycled = InputBox("Enter the miles cycled?") 'ask for miles cycled 
            Total = Total + miles_cycled 'add together
        Next

        total1 = Total / 4 'calculates the average

        If target_Average < total1 Then 'check that you have met your target and displays a message on the screen
            MsgBox(name & " you have averaged " & total1 & " miles per week" & vbCrLf & " Congratulation you have met your target")
        Else
            MsgBox(name & " you have averaged " & total1 & " miles per week" & vbCrLf & " Sorry you have not met your target")





        End If




       











    End Sub
End Class
