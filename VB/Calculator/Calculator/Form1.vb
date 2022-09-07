Public Class Form1
    Dim first As Decimal
    Dim second As Decimal
    Dim oper As String
    Dim mem As Decimal
    Private Sub b9_Click(sender As Object, e As EventArgs) Handles b9.Click, b8.Click, b7.Click, b6.Click, b5.Click, b4.Click, b3.Click, b2.Click, b1.Click, b0.Click
        displaybox.Text += sender.text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles displaybox.TextChanged

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles clearbox.Click
        displaybox.Clear()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles addbutton.Click
        Decimal.TryParse(displaybox.Text, first)
        oper = sender.text
        displaybox.Clear()

    End Sub

    Private Sub enterbutton_Click(sender As Object, e As EventArgs) Handles enterbutton.Click
        Decimal.TryParse(displaybox.Text, second)
        If oper = "+" Then
            displaybox.Text = first + second
        End If
        If oper = "*" Then
            displaybox.Text = first * second
        End If
        If oper = "÷" Then
            displaybox.Text = first / second
        End If
        If oper = "-" Then
            displaybox.Text = first - second
        End If
    End Sub

    Private Sub multiplybutton_Click(sender As Object, e As EventArgs) Handles multiplybutton.Click
        Decimal.TryParse(displaybox.Text, first)
        displaybox.Clear()
        oper = sender.text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles dividebox.Click
        Decimal.TryParse(displaybox.Text, first)
        displaybox.Clear()
        oper = sender.text

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Decimal.TryParse(displaybox.Text, first)
        displaybox.Clear()
        oper = sender.text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Decimal.TryParse(displaybox.Text, first)
        displaybox.Text = Math.Sqrt(first)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        displaybox.Text = Math.PI

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Decimal.TryParse(displaybox.Text, first)
        displaybox.Text = Math.Sin(first)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Decimal.TryParse(displaybox.Text, first)
        displaybox.Text = Math.Cos(first)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Decimal.TryParse(displaybox.Text, first)
        displaybox.Text = Math.Tan(first)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Decimal.TryParse(displaybox.Text, mem)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        mem = 0
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        displaybox.Text = mem
    End Sub
End Class
