Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim dollars As Decimal
        Dim Tip As Decimal
        Decimal.TryParse(tipbox.Text, dollars)
        If RadioButton1.Checked Then Me.BackColor = Color.Plum
        If RadioButton1.Checked Then Tip = dollars * 0.1
        If RadioButton2.Checked Then Me.BackColor = Color.Plum
        If RadioButton2.Checked Then Tip = dollars * 0.15
        If RadioButton3.Checked Then Me.BackColor = Color.Plum
        If RadioButton3.Checked Then Tip = dollars * 0.2
        If RadioButton4.Checked Then Me.BackColor = Color.Plum
        If RadioButton4.Checked Then Tip = dollars * 0.25
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dollars As Decimal
        Dim Tip As Decimal
        Decimal.TryParse(dollarbox.Text, dollars)
        If RadioButton1.Checked Then Me.BackColor = Color.Plum
        If RadioButton1.Checked Then Tip = dollars * 0.1
        If RadioButton2.Checked Then Me.BackColor = Color.Plum
        If RadioButton2.Checked Then Tip = dollars * 0.15
        If RadioButton3.Checked Then Me.BackColor = Color.Plum
        If RadioButton3.Checked Then Tip = dollars * 0.2
        If RadioButton4.Checked Then Me.BackColor = Color.Plum
        If RadioButton4.Checked Then Tip = dollars * 0.25
        tipbox.Text = Tip
        totalbox.Text = Tip + dollars
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
