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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.namebox = New System.Windows.Forms.TextBox()
        Me.datebox = New System.Windows.Forms.TextBox()
        Me.rankbox = New System.Windows.Forms.TextBox()
        Me.purchasesbox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tetris = New System.Windows.Forms.PictureBox()
        Me.donkeykong = New System.Windows.Forms.PictureBox()
        Me.asteroids = New System.Windows.Forms.PictureBox()
        Me.qbert = New System.Windows.Forms.PictureBox()
        Me.pacman = New System.Windows.Forms.PictureBox()
        Me.displaypicturebox = New System.Windows.Forms.PictureBox()
        CType(Me.tetris, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.donkeykong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.asteroids, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qbert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pacman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.displaypicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(359, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Name:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(359, 76)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "Release Date:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(359, 130)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "Rank:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(359, 189)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = "Purchases:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Pacman"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(254, 328)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Asteroids"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(369, 328)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Q*bert"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(486, 328)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Tetris"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'namebox
        '
        Me.namebox.Location = New System.Drawing.Point(486, 24)
        Me.namebox.Name = "namebox"
        Me.namebox.Size = New System.Drawing.Size(275, 22)
        Me.namebox.TabIndex = 15
        '
        'datebox
        '
        Me.datebox.Location = New System.Drawing.Point(486, 76)
        Me.datebox.Name = "datebox"
        Me.datebox.Size = New System.Drawing.Size(275, 22)
        Me.datebox.TabIndex = 16
        '
        'rankbox
        '
        Me.rankbox.Location = New System.Drawing.Point(486, 130)
        Me.rankbox.Name = "rankbox"
        Me.rankbox.Size = New System.Drawing.Size(275, 22)
        Me.rankbox.TabIndex = 17
        '
        'purchasesbox
        '
        Me.purchasesbox.Location = New System.Drawing.Point(486, 188)
        Me.purchasesbox.Name = "purchasesbox"
        Me.purchasesbox.Size = New System.Drawing.Size(275, 22)
        Me.purchasesbox.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(136, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Donkey Kong"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tetris
        '
        Me.tetris.Image = Global.Gamingdex.My.Resources.Resources.tetris
        Me.tetris.Location = New System.Drawing.Point(486, 367)
        Me.tetris.Name = "tetris"
        Me.tetris.Size = New System.Drawing.Size(98, 50)
        Me.tetris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.tetris.TabIndex = 14
        Me.tetris.TabStop = False
        '
        'donkeykong
        '
        Me.donkeykong.Image = Global.Gamingdex.My.Resources.Resources.p088zq9j
        Me.donkeykong.Location = New System.Drawing.Point(136, 367)
        Me.donkeykong.Name = "donkeykong"
        Me.donkeykong.Size = New System.Drawing.Size(100, 50)
        Me.donkeykong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.donkeykong.TabIndex = 13
        Me.donkeykong.TabStop = False
        '
        'asteroids
        '
        Me.asteroids.Image = Global.Gamingdex.My.Resources.Resources.asteroids
        Me.asteroids.Location = New System.Drawing.Point(254, 367)
        Me.asteroids.Name = "asteroids"
        Me.asteroids.Size = New System.Drawing.Size(99, 50)
        Me.asteroids.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.asteroids.TabIndex = 12
        Me.asteroids.TabStop = False
        '
        'qbert
        '
        Me.qbert.Image = Global.Gamingdex.My.Resources.Resources.unnamed
        Me.qbert.Location = New System.Drawing.Point(369, 367)
        Me.qbert.Name = "qbert"
        Me.qbert.Size = New System.Drawing.Size(100, 50)
        Me.qbert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.qbert.TabIndex = 11
        Me.qbert.TabStop = False
        '
        'pacman
        '
        Me.pacman.Image = Global.Gamingdex.My.Resources.Resources.pacman
        Me.pacman.Location = New System.Drawing.Point(12, 367)
        Me.pacman.Name = "pacman"
        Me.pacman.Size = New System.Drawing.Size(108, 50)
        Me.pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pacman.TabIndex = 10
        Me.pacman.TabStop = False
        '
        'displaypicturebox
        '
        Me.displaypicturebox.Image = Global.Gamingdex.My.Resources.Resources._96724106_gettyimages_157437668
        Me.displaypicturebox.Location = New System.Drawing.Point(12, 13)
        Me.displaypicturebox.Name = "displaypicturebox"
        Me.displaypicturebox.Size = New System.Drawing.Size(329, 198)
        Me.displaypicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.displaypicturebox.TabIndex = 5
        Me.displaypicturebox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.purchasesbox)
        Me.Controls.Add(Me.rankbox)
        Me.Controls.Add(Me.datebox)
        Me.Controls.Add(Me.namebox)
        Me.Controls.Add(Me.tetris)
        Me.Controls.Add(Me.donkeykong)
        Me.Controls.Add(Me.asteroids)
        Me.Controls.Add(Me.qbert)
        Me.Controls.Add(Me.pacman)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.displaypicturebox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        CType(Me.tetris, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.donkeykong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.asteroids, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qbert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pacman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.displaypicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents displaypicturebox As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents pacman As PictureBox
    Friend WithEvents qbert As PictureBox
    Friend WithEvents asteroids As PictureBox
    Friend WithEvents donkeykong As PictureBox
    Friend WithEvents tetris As PictureBox
    Friend WithEvents namebox As TextBox
    Friend WithEvents datebox As TextBox
    Friend WithEvents rankbox As TextBox
    Friend WithEvents purchasesbox As TextBox
    Friend WithEvents Button2 As Button
End Class
