Public Class Form1
    Private Sub btnExitNow_Click(sender As Object, e As EventArgs) Handles btnExitNow.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDay.Clear()
        txtMonth.Clear()
        txtYear.Clear()

        lbl4.Text = String.Empty
    End Sub
End Class
