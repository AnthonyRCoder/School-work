Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim test_score As Integer
        Dim counter As Integer
        Dim noofpupils As Integer
        Dim subject As String

        counter = 0

        subject = InputBox("please type in the subject this test is for")

        ListBox1.Items.Add("Here are the test scores you entered for the 12 pupils")

        For noofpupils = 1 To 12
            test_score = InputBox("please enter the test score of pupil " & noofpupils)

            ListBox1.Items.Add("YOU HAVE ENTERRED THE TEST SCORE OF PUPIL " & noofpupils & " AS " & test_score)


            If test_score > 40 Then
                counter = counter + 1

            End If
            On Error Resume Next

            If counter <= 4 Then
                MsgBox("totel pass is " & counter)
            Else
                MsgBox(" totel fail is" & counter)


            End If






        Next
    End Sub
End Class
