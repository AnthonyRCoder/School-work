Public Class Form1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim firstnumber As Integer
        Dim secondnumber As Integer
        Dim Answer As Integer
        firstnumber = TextBox1.Text
        secondnumber = TextBox2.Text
        Answer = firstnumber * secondnumber
        MsgBox(" Answer is " & Answer)

    End Sub
End Class
