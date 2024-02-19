Public Class Form3

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHowMany.TextChanged

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnFuncton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFuncton.Click
        Dim string_in As String
        Dim string_out As String
        Dim first, how_many As Integer

        string_in = txtEnter.Text()
        first = txtFirst.Text
        how_many = txtHowMany.Text

        string_out = Mid$(string_in, first, how_many)

        txtResult.Text = string_out
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        label1.Text = ""
        txtFirst.Text = ""
        txtHowMany.Text = ""
        txtResult.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form4.Show()
    End Sub
End Class