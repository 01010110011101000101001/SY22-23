Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dollars As Decimal
        Decimal.TryParse(dollarbox.Text, dollars)
        Dim Pesos As Decimal
        Pesos = dollars * 20
        pesobox.Text = Pesos.ToString("n2")
        Dim Yen As Decimal
        Yen = dollars * 137
        yenbox.Text = Yen.ToString("n2")
        Dim Pounds As Decimal
        Pounds = dollars * 0.84
        poundbox.Text = Pounds.ToString("n2")
        Dim hryvnia As Decimal
        hryvnia = dollars * 0.027
        hryvniabox.Text = hryvnia.ToString("n2")
        Dim Renminbi As Decimal
        Renminbi = dollars * 6.25
        renbox.Text = Renminbi.ToString("n2")
        Dim Rubles As Decimal
        Rubles = dollars * 60.88
        rublebox.Text = Rubles.ToString("n2")
    End Sub
End Class
