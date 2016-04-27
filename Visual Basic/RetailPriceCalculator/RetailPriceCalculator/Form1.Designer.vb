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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textCost = New System.Windows.Forms.TextBox()
        Me.textMarkup = New System.Windows.Forms.TextBox()
        Me.btnRetail = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.labelRetail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Wholesale Cost of Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Markup %"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(12, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Retail Price"
        '
        'textCost
        '
        Me.textCost.Location = New System.Drawing.Point(134, 21)
        Me.textCost.Name = "textCost"
        Me.textCost.Size = New System.Drawing.Size(100, 20)
        Me.textCost.TabIndex = 3
        '
        'textMarkup
        '
        Me.textMarkup.Location = New System.Drawing.Point(134, 61)
        Me.textMarkup.Name = "textMarkup"
        Me.textMarkup.Size = New System.Drawing.Size(100, 20)
        Me.textMarkup.TabIndex = 4
        '
        'btnRetail
        '
        Me.btnRetail.Location = New System.Drawing.Point(53, 156)
        Me.btnRetail.Name = "btnRetail"
        Me.btnRetail.Size = New System.Drawing.Size(75, 23)
        Me.btnRetail.TabIndex = 6
        Me.btnRetail.Text = "Get Retail"
        Me.btnRetail.UseVisualStyleBackColor = true
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(194, 156)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'labelRetail
        '
        Me.labelRetail.Location = New System.Drawing.Point(134, 103)
        Me.labelRetail.Name = "labelRetail"
        Me.labelRetail.Size = New System.Drawing.Size(100, 20)
        Me.labelRetail.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 213)
        Me.Controls.Add(Me.labelRetail)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRetail)
        Me.Controls.Add(Me.textMarkup)
        Me.Controls.Add(Me.textCost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents textCost As TextBox
    Friend WithEvents textMarkup As TextBox
    Friend WithEvents btnRetail As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents labelRetail As TextBox
End Class
