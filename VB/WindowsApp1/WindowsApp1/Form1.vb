Public Class Form1
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles zipbox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim amount As Decimal
        Decimal.TryParse(amountbox.Text, amount)
        Dim fee As Decimal
        fee = amount * 0.03
        namebox.Clear()
        ccbox.Clear()
        expbox.Clear()
        zipbox.Clear()
        amountbox.Clear()
        feebox.Text = fee.ToString("n2")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles feebox.TextChanged

    End Sub

    Private Sub amountbox_TextChanged(sender As Object, e As EventArgs) Handles amountbox.TextChanged

    End Sub
End Class
