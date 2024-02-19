Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'code for the start command button
        'by Anthony on 21/6/19

        Dim runners_name As String
        Dim which_event As String
        Dim squad_number As Single
        Dim time_1 As Single
        Dim time_2 As Single
        Dim time_3 As Single
        Dim average As Integer

        runners_name = InputBox("Enter the runner's name")
        squad_number = InputBox("Enter the runner's number")
        which_event = InputBox("Which event?")
        time_1 = InputBox("Time in 1st race")
        time_2 = InputBox("Time in 2nd race")
        time_3 = InputBox("Time in 3rd race")

        average = CInt((time_1 + time_2 + time_3) / 3)

        txtDetails.Text = " Name: " & runners_name & vbCrLf & "Number:" & squad_number & vbCrLf & "Event:" & which_event
        txtAverage.Text = average



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Show()

    End Sub
End Class
