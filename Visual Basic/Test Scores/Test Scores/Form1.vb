Public Class Form1

    Private Sub btnGetScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetScores.Click
    Dim input1 as Integer = CInt(testScore1.Text)
    Dim input2 as Integer = CInt(testScore2.Text)
    Dim input3 as Integer = CInt(testScore3.Text)
    Dim average = (input1 + input2 + input3) / 3

        lblAverage.Text = average.ToString


    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        testScore1.Text = ""
        testScore2.Text = ""
        testScore3.Text = ""
        lblAverage.Text = ""
    End Sub
End Class
