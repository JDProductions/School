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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click Button to Display Number"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.SystemColors.Highlight
        Me.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl2.Location = New System.Drawing.Point(143, 293)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(424, 46)
        Me.lbl2.TabIndex = 1
        '
        'btn1
        '
        Me.btn1.AutoSize = True
        Me.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn1.Image = CType(resources.GetObject("btn1.Image"), System.Drawing.Image)
        Me.btn1.Location = New System.Drawing.Point(92, 46)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(95, 150)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn2.Image = CType(resources.GetObject("btn2.Image"), System.Drawing.Image)
        Me.btn2.Location = New System.Drawing.Point(184, 46)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(95, 150)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Image = CType(resources.GetObject("btn3.Image"), System.Drawing.Image)
        Me.btn3.Location = New System.Drawing.Point(300, 46)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(95, 150)
        Me.btn3.TabIndex = 4
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Image = CType(resources.GetObject("btn4.Image"), System.Drawing.Image)
        Me.btn4.Location = New System.Drawing.Point(397, 46)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(95, 150)
        Me.btn4.TabIndex = 5
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Image = CType(resources.GetObject("btn5.Image"), System.Drawing.Image)
        Me.btn5.Location = New System.Drawing.Point(501, 46)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(95, 150)
        Me.btn5.TabIndex = 6
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(296, 380)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(75, 23)
        Me.btn6.TabIndex = 7
        Me.btn6.Text = "Exit"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 415)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Display Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
End Class
