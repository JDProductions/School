'Author: James DuBois
Public Class Form1
    Private Sub btnSwitchLight_Click(sender As Object, e As EventArgs) Handles btnSwitchLight.Click
 If lblLightState.Text = "Off" Then
            lblLightState.Text = "On"
            picLightOn.Visible = True
            picLightOff.Visible = False
        Else
            lblLightState.Text = "Off"
            picLightOn.Visible = False
            picLightOff.Visible = True
        End If
        
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
