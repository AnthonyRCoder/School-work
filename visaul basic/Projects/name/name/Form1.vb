

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name As String
        Dim numbe As Integer
        Dim number1 As Integer
        Dim number2 As Integer
        Dim number3 As Integer
        Dim Answer As Integer

        numbe = InputBox("what is your age ?" & numbe)
        name = TextBox1.Text
        number1 = TextBox2.Text
        number2 = TextBox3.Text
        number3 = TextBox4.Text
        Answer = MsgBox(" here your number " & number1 + number2 + number3)

        MsgBox("My name " & name & " my age is " & numbe)




    End Sub
End Class