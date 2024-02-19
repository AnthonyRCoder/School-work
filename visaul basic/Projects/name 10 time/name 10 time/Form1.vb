Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        REM enter name for ten times

        Dim name As Integer



        For name = 1 To 10
            ListBox1.Items.Add("Anthony Rozario")

        Next




    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
