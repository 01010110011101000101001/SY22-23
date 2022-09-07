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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.namebox = New System.Windows.Forms.TextBox()
        Me.ccbox = New System.Windows.Forms.TextBox()
        Me.expbox = New System.Windows.Forms.TextBox()
        Me.zipbox = New System.Windows.Forms.TextBox()
        Me.amountbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.feebox = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CC#"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Exp. Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ZIP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Amount"
        '
        'namebox
        '
        Me.namebox.Location = New System.Drawing.Point(162, 41)
        Me.namebox.Name = "namebox"
        Me.namebox.Size = New System.Drawing.Size(100, 22)
        Me.namebox.TabIndex = 5
        '
        'ccbox
        '
        Me.ccbox.Location = New System.Drawing.Point(162, 95)
        Me.ccbox.Name = "ccbox"
        Me.ccbox.Size = New System.Drawing.Size(100, 22)
        Me.ccbox.TabIndex = 6
        '
        'expbox
        '
        Me.expbox.Location = New System.Drawing.Point(162, 157)
        Me.expbox.Name = "expbox"
        Me.expbox.Size = New System.Drawing.Size(100, 22)
        Me.expbox.TabIndex = 7
        '
        'zipbox
        '
        Me.zipbox.Location = New System.Drawing.Point(162, 216)
        Me.zipbox.Name = "zipbox"
        Me.zipbox.Size = New System.Drawing.Size(100, 22)
        Me.zipbox.TabIndex = 8
        '
        'amountbox
        '
        Me.amountbox.Location = New System.Drawing.Point(162, 276)
        Me.amountbox.Name = "amountbox"
        Me.amountbox.Size = New System.Drawing.Size(100, 22)
        Me.amountbox.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(187, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Buy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(525, 357)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.download
        Me.PictureBox1.Location = New System.Drawing.Point(500, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(412, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Fee"
        '
        'feebox
        '
        Me.feebox.Location = New System.Drawing.Point(479, 185)
        Me.feebox.Name = "feebox"
        Me.feebox.Size = New System.Drawing.Size(100, 22)
        Me.feebox.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.feebox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.amountbox)
        Me.Controls.Add(Me.zipbox)
        Me.Controls.Add(Me.expbox)
        Me.Controls.Add(Me.ccbox)
        Me.Controls.Add(Me.namebox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents namebox As TextBox
    Friend WithEvents ccbox As TextBox
    Friend WithEvents expbox As TextBox
    Friend WithEvents zipbox As TextBox
    Friend WithEvents amountbox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents feebox As TextBox
End Class
