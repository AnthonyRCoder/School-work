Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Name As String
        Name = TextBox1.Text

        MsgBox("Welcome" & Name & ",this is my first VB Program.")
    End Sub
End Class
