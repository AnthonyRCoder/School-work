Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name, votes As String
        Dim times, yesvote As Integer

        For times = 1 To 3
            yesvote = 0

            name = InputBox("please enter candidate name")

            For judgevote = 1 To 4
                votes = InputBox("Judges, please vote, Y for yes or N for No")
                If votes = "y" Then
                    yesvote = yesvote + 1
                End If
            Next
            If yesvote >= 2 Then
                MsgBox("Well done " & name & " you have " & yesvote & " yes votes. you are through to the next round")
            Else
                MsgBox("sorry " & name & " you have " & yesvote & " yes votes. you are not going through to the next round")

            End If
        Next
    End Sub
End Class
