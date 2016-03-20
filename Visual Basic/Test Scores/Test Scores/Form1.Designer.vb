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
        Me.btnGetScores = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.testScore1 = New System.Windows.Forms.TextBox()
        Me.testScore3 = New System.Windows.Forms.TextBox()
        Me.testScore2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(36, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Average:"
        '
        'btnGetScores
        '
        Me.btnGetScores.Location = New System.Drawing.Point(19, 243)
        Me.btnGetScores.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGetScores.Name = "btnGetScores"
        Me.btnGetScores.Size = New System.Drawing.Size(110, 37)
        Me.btnGetScores.TabIndex = 2
        Me.btnGetScores.Text = "&Get Scores"
        Me.btnGetScores.UseVisualStyleBackColor = true
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(298, 243)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 37)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(137, 35)
        Me.lblAverage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(100, 28)
        Me.lblAverage.TabIndex = 1
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'testScore1
        '
        Me.testScore1.Location = New System.Drawing.Point(137, 78)
        Me.testScore1.Name = "testScore1"
        Me.testScore1.Size = New System.Drawing.Size(100, 22)
        Me.testScore1.TabIndex = 4
        '
        'testScore3
        '
        Me.testScore3.Location = New System.Drawing.Point(137, 139)
        Me.testScore3.Name = "testScore3"
        Me.testScore3.Size = New System.Drawing.Size(100, 22)
        Me.testScore3.TabIndex = 5
        '
        'testScore2
        '
        Me.testScore2.Location = New System.Drawing.Point(137, 107)
        Me.testScore2.Name = "testScore2"
        Me.testScore2.Size = New System.Drawing.Size(100, 22)
        Me.testScore2.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(39, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Score 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(39, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Score 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(39, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Score 3"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(153, 243)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 37)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 307)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.testScore2)
        Me.Controls.Add(Me.testScore3)
        Me.Controls.Add(Me.testScore1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGetScores)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Form1"
        Me.Text = "Test Score Average"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGetScores As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblAverage As Label
    Friend WithEvents testScore1 As TextBox
    Friend WithEvents testScore3 As TextBox
    Friend WithEvents testScore2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClear As Button
End Class
