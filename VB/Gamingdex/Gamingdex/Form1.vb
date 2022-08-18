Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        displaypicturebox.Image = pacman.Image
        namebox.Text = "Pacman"
        datebox.Text = "5/22/1980"
        rankbox.Text = "E For Everyone"
        purchasesbox.Text = "400,000 cabinets sold"
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        displaypicturebox.Image = donkeykong.Image
        namebox.Text = "Donkey Kong"
        datebox.Text = "7/9/1981"
        rankbox.Text = "E For Everyone"
        purchasesbox.Text = "65,000 cabinets sold"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        displaypicturebox.Image = asteroids.Image
        namebox.Text = "Asteroids"
        datebox.Text = "1/11/1979"
        rankbox.Text = "E For Everyone"
        purchasesbox.Text = "70,000 cabinets sold"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        displaypicturebox.Image = tetris.Image
        namebox.Text = "Tetris"
        datebox.Text = "6/6/1984"
        rankbox.Text = "E for Everyone"
        purchasesbox.Text = "43 million COPIES, not cabinets."
    End Sub

    Private Sub pacman_Click(sender As Object, e As EventArgs) Handles pacman.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        displaypicturebox.Image = qbert.Image
        namebox.Text = "Q*bert"
        datebox.Text = "1/10/1982"
        rankbox.Text = "E For Everyone"
        purchasesbox.Text = "25,000 cabinets sold"
    End Sub
End Class
