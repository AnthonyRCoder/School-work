Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name As String
        Dim number As Integer
        name = InputBox("enter name")
        number = InputBox("enter age")

        MsgBox(" my name is " & name &" my age is " & number)

    End Sub
End Class
