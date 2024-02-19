Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        REM prog to calculate milage
        'Anthony
        '17/3/17

        Dim mile As Integer
        Dim gallon As Integer
        Dim answer As Integer


        mile = InputBox("enter mile")
        gallon = InputBox("enter gallon")
        answer = mile / gallon

        MsgBox("answer is " & answer)




    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
