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
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExitNow = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDay
        '
        Me.txtDay.Location = New System.Drawing.Point(466, 38)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(100, 22)
        Me.txtDay.TabIndex = 0
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(477, 98)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(100, 22)
        Me.txtMonth.TabIndex = 1
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(466, 153)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 22)
        Me.txtYear.TabIndex = 2
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(32, 281)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 3
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(259, 283)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExitNow
        '
        Me.btnExitNow.Location = New System.Drawing.Point(491, 283)
        Me.btnExitNow.Name = "btnExitNow"
        Me.btnExitNow.Size = New System.Drawing.Size(75, 23)
        Me.btnExitNow.TabIndex = 5
        Me.btnExitNow.Text = "Exit"
        Me.btnExitNow.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(332, 38)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(71, 17)
        Me.lbl1.TabIndex = 6
        Me.lbl1.Text = "Enter Day"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(332, 101)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(85, 17)
        Me.lbl2.TabIndex = 7
        Me.lbl2.Text = "Enter Month"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(332, 158)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(76, 17)
        Me.lbl3.TabIndex = 8
        Me.lbl3.Text = "Enter Year"
        '
        'lbl4
        '
        Me.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl4.Location = New System.Drawing.Point(201, 213)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(414, 23)
        Me.lbl4.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 348)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnExitNow)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtDay)
        Me.Name = "Form1"
        Me.Text = "Calendar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDay As TextBox
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExitNow As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl4 As Label
End Class
