Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Player_Hits(5), Total_Hits, Average_Hits As Single

        Player_Hits(0) = TextBox1.Text
        Player_Hits(1) = TextBox2.Text
        Player_Hits(2) = TextBox3.Text
        Player_Hits(3) = TextBox4.Text
        Player_Hits(4) = TextBox5.Text
        Player_Hits(5) = TextBox6.Text


        Total_Hits = Player_Hits(0) + Player_Hits(1) + Player_Hits(2) + Player_Hits(3) + Player_Hits(4) + Player_Hits(5)


        Average_Hits = Total_Hits / 6

        MsgBox("total score " & Total_Hits & vbLf & "average number of hit " & Average_Hits)

        If Total_Hits > 50 Then
            MsgBox("one point for getting greater than 50 total score " & Total_Hits)
        Else
            MsgBox("no point")

        End If

        If Average_Hits >= 10 Then
            MsgBox("one point for getting greater/equal than 10 average score " & Average_Hits)
        Else
            MsgBox("not point")
        End If




    End Sub
End Class
