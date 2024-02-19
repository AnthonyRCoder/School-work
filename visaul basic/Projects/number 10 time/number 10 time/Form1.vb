Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        REM enter name and display 10 times using listbox
        'AR
        '22/3/2017
        Dim name As Integer

        name = InputBox("enter number ")


        ListBox1.Items.Add("number is" & name)



    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
