Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim name1 As String
        Dim name2 As String
        Dim year As String
        Dim colour As String
        Dim street As String
        Dim shoe_size As String
        Dim password As String

        name1 = InputBox("Enter your first name")
        name1 = Mid(name1, 1, 1)

        name2 = InputBox("Enter your second name")
        name2 = Mid(name2, 1, 2)

        year = InputBox("Enter your birth year (e.g. 1993)")
        year = Mid(year, 3, 3)

        colour = InputBox("Enter your favourite colour")
        colour = Mid(colour, 2, 2)

        street = InputBox("Enter the name of the street where you live")
        street = Mid(street, 1, 3)

        shoe_size = InputBox("Enter youe shoe size")

        password = name1 + name2 + year + colour + street + shoe_size

        MsgBox("Your password is " & password)

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form5.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub
End Class