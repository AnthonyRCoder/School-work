Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim savemoney As Integer
        Dim moneyout As Integer


        savemoney = TextBox1.Text
        moneyout = InputBox("how much you want ")




        MsgBox("you have this much  " & savemoney)


        If moneyout > savemoney Then
            MsgBox("sorry no had this much money")
        Else
            MsgBox("here you go " & savemoney - moneyout)


        End If









    End Sub
End Class
