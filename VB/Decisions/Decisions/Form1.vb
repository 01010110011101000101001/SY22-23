Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Age As Integer
        Integer.TryParse(TextBox1.Text, Age)
        Label1.Text = Age
        If Age > 17 Then
            Label1.Text = "You can vote."
            Me.BackColor = Color.Green


        Else
            Label1.Text = "You can't vote, lol."
            Me.BackColor = Color.Red

        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        If RadioButton1.Checked Then Me.BackColor = Color.Plum
        If RadioButton2.Checked Then Me.BackColor = Color.Wheat
        If RadioButton3.Checked Then Me.BackColor = Color.Fuchsia
    End Sub
End Class
