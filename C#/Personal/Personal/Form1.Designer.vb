<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.ExitNow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(128, 29)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(151, 25)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "James DuBois"
        Me.lblName.Visible = False
        '
        'lblAddress
        '
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(96, 71)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(242, 23)
        Me.lblAddress.TabIndex = 1
        Me.lblAddress.Text = "123 Whocares Avenue"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAddress.Visible = False
        '
        'lblState
        '
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(160, 120)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(100, 23)
        Me.lblState.TabIndex = 2
        Me.lblState.Text = "Ohio"
        Me.lblState.Visible = False
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(69, 199)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 3
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'ExitNow
        '
        Me.ExitNow.Location = New System.Drawing.Point(285, 199)
        Me.ExitNow.Name = "ExitNow"
        Me.ExitNow.Size = New System.Drawing.Size(75, 23)
        Me.ExitNow.TabIndex = 4
        Me.ExitNow.Text = "Exit"
        Me.ExitNow.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 255)
        Me.Controls.Add(Me.ExitNow)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "Personal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblState As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents ExitNow As Button
End Class
