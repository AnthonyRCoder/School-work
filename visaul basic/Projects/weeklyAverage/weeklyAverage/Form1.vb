Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim eachday As Integer
        Dim wage(eachday) As Integer
        Dim totalWage As Integer
        Dim weeklyAverage As Integer




        For eachday = 1 To 7
            wage(eachday) = InputBox("Enter")
            totalWage = totalWage + wage(eachday)
        Next
        weeklyAverage = totalWage / 7

        MsgBox(weeklyAverage)




    End Sub
End Class
