Public Class Form1
    'Author : James DuBois
    Private random As New Random

    Private icons = New List(Of String) From {"a", "a", "B", "B", "C", "C", "d", "d", "E", "E", "f", "f"}

    Private Sub AssignIconsToSquares()
            For Each control In TableLayoutPanel1.Controls
        Dim iconLabel = TryCast(control, Label)
        If iconLabel IsNot Nothing Then
            Dim randomNumber = random.Next(icons.Count)
            iconLabel.Text = icons(randomNumber)
            iconLabel.ForeColor = iconLabel.BackColor
            icons.RemoveAt(randomNumber)
        End If
    Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AssignIconsToSquares()
    End Sub

    Private Sub label_Click(sender As Object, e As EventArgs) Handles Label9.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, Label3.Click, Label2.Click, Label12.Click, Label11.Click, Label10.Click, Label1.Click
       If Timer1.Enabled Then Exit Sub

    Dim clickedLabel = TryCast(sender, Label)

    If clickedLabel IsNot Nothing Then

        If clickedLabel.ForeColor = Color.Black Then Exit Sub

        If firstClicked Is Nothing Then
            firstClicked = clickedLabel
            firstClicked.ForeColor = Color.Black
            Exit Sub
        End If

        secondClicked = clickedLabel
        secondClicked.ForeColor = Color.Black

    CheckForWinner()

If firstClicked.Text = secondClicked.Text Then
    firstClicked = Nothing
    secondClicked = Nothing
    Exit Sub
End If


        Timer1.Start()
    End If
    End Sub

        Private firstClicked As Label = Nothing

        Private secondClicked As Label = Nothing

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()

    firstClicked.ForeColor = firstClicked.BackColor
    secondClicked.ForeColor = secondClicked.BackColor

    firstClicked = Nothing
    secondClicked = Nothing
    End Sub

    Private Sub CheckForWinner()

    For Each control In TableLayoutPanel1.Controls
        Dim iconLabel = TryCast(control, Label)
        If iconLabel IsNot Nothing AndAlso 
           iconLabel.ForeColor = iconLabel.BackColor Then Exit Sub
    Next

    MessageBox.Show("Congratulations! You matched all the Icons!")
    Close()

End Sub
End Class
