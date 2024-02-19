Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FirstNumber As Integer
        Dim SecondNumber As Integer
        Dim Sum As Integer
        FirstNumber = TextBox1.Text
        SecondNumber = TextBox2.Text

        Sum = FirstNumber + SecondNumber

        MsgBox("Total is " & Sum)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
