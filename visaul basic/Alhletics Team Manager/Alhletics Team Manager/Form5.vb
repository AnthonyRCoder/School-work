Public Class Form5

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim first_name, surname, display_name As String
        Dim max_mark, mark As Integer
        Dim grade, init As Char
        Dim percent As Single

        max_mark = txtMax.Text
        first_name = txtName.Text
        surname = txtSurname.Text
        mark = txtMark.Text

        percent = (mark / max_mark) * 100

        Select percent
            Case Is >= 80
                grade = "A+"
            Case Is >= 70
                grade = "A"
            Case Is >= 60
                grade = "B"
            Case Is >= 50
                grade = "C"
            Case Is >= 45
                grade = "D"
            Case Else
                grade = "fail"
        End Select

        init = Mid(first_name, 1, 1)

        display_name = init + "." + surname

        MsgBox(display_name & ", " & mark & "/" & max_mark & ", " & Format(percent, ".0" & "% " & " grade " & grade))


    End Sub
End Class