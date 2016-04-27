
Public Class Form1
 
    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnRetail.Click
        If Not IsNumeric(textCost.Text & textMarkup.Text) Then
            MessageBox.Show("Numeric Only")
            Return
        End If
        If CDbl(textCost.Text & textMarkup.Text) < 1 Then
            MessageBox.Show("Positive Number Only")
            Return
        End If
        labelRetail.Text = CStr((CDbl(textCost.Text) + (CDbl(textCost.Text) * (CDbl(textMarkup.Text) * 0.01))))
        'Focus
        textCost.Focus()
        textCost.SelectionStart = 0
        textCost.SelectionLength =
            textCost.TextLength
    End Sub
 
    Private Sub CalculateRetail()
        Dim answer As Double
        answer = CDbl(CStr((CDbl(textCost.Text) + (CDbl(textCost.Text) * (CDbl(textMarkup.Text) * 0.01)))))
        Return
    End Sub
 
 
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class