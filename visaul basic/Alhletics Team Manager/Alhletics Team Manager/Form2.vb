Public Class Form2

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtEnter.Text = ""
        txtResult.Text = ""
    End Sub

    Private Sub btnFunction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFunction.Click
        Dim string_in As String
        Dim number_out As Integer
        string_in = txtEnter.Text
        number_out = Len(string_in)
        txtResult.Text = number_out
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class