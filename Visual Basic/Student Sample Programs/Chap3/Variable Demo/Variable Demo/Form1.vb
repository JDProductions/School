Public Class Form1
    Private Sub btnShowName_Click(sender As Object, e As EventArgs) Handles btnShowName.Click
        Dim strFullName As String
        ' Combine the first and last names and assign the
        ' result to strFullName.
        strFullName = txtFirstName.Text & " " & txtLastName.Text
        ' Display the full name in the lblFullName
        lblFullName.Text = strFullName
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear TextBox controls and the Label.
        txtFirstName.Clear()
        txtLastName.Clear()
        lblFullName.Text = String.Empty
        ' Set focus to txtfirstName.
        txtFirstName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged

    End Sub

    Private Sub lblFullName_Click(sender As Object, e As EventArgs) Handles lblFullName.Click

    End Sub
End Class
