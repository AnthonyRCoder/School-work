Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim length As Integer
        Dim breadth As Integer
        Dim Area As Integer


        length = TextBox1.Text
        breadth = TextBox2.Text
        Area = length * breadth

        MsgBox("Area is " & Area)

    End Sub
End Class
