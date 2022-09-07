<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.buybutton = New System.Windows.Forms.Button()
        Me.cancelbutton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CC#"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 157)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Exp. Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 207)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ZIP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 256)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Amount"
        '
        'namebox
        '
        Me.namebox.Location = New System.Drawing.Point(234, 46)
        Me.namebox.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.namebox.Name = "namebox"
        Me.namebox.Size = New System.Drawing.Size(177, 22)
        Me.namebox.TabIndex = 5
        '
        'ccbox
        '
        Me.ccbox.Location = New System.Drawing.Point(234, 98)
        Me.ccbox.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.ccbox.Name = "ccbox"
        Me.ccbox.Size = New System.Drawing.Size(177, 22)
        Me.ccbox.TabIndex = 6
        '
        'expbox
        '
        Me.expbox.Location = New System.Drawing.Point(234, 151)
        Me.expbox.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.expbox.Name = "expbox"
        Me.expbox.Size = New System.Drawing.Size(177, 22)
        Me.expbox.TabIndex = 7
        '
        'zipbox
        '
        Me.zipbox.Location = New System.Drawing.Point(234, 201)
        Me.zipbox.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.zipbox.Name = "zipbox"
        Me.zipbox.Size = New System.Drawing.Size(177, 22)
        Me.zipbox.TabIndex = 8
        '
        'amountbox
        '
        Me.amountbox.Location = New System.Drawing.Point(234, 249)
        Me.amountbox.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.amountbox.Name = "amountbox"
        Me.amountbox.Size = New System.Drawing.Size(177, 22)
        Me.amountbox.TabIndex = 9
        '
        'buybutton
        '
        Me.buybutton.Location = New System.Drawing.Point(106, 349)
        Me.buybutton.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.buybutton.Name = "buybutton"
        Me.buybutton.Size = New System.Drawing.Size(135, 22)
        Me.buybutton.TabIndex = 10
        Me.buybutton.Text = "Buy"
        Me.buybutton.UseVisualStyleBackColor = True
        '
        'cancelbutton
        '
        Me.cancelbutton.Location = New System.Drawing.Point(646, 349)
        Me.cancelbutton.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.cancelbutton.Name = "cancelbutton"
        Me.cancelbutton.Size = New System.Drawing.Size(135, 22)
        Me.cancelbutton.TabIndex = 11
        Me.cancelbutton.Text = "Cancel"
        Me.cancelbutton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.project.My.Resources.Resources.download
        Me.PictureBox1.Location = New System.Drawing.Point(630, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(900, 422)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cancelbutton)
        Me.Controls.Add(Me.buybutton)
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
        Me.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "My Application"
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
    Friend WithEvents buybutton As Button
    Friend WithEvents cancelbutton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
