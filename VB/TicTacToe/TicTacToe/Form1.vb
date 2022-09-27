Public Class Form1
    Dim turn As String = "X"
    Dim score1 As Integer
    Dim score2 As Integer

    Sub reset()
        Me.BackColor = Color.White
        b1.Text = ""
        b2.Text = ""
        b3.Text = ""
        b4.Text = ""
        b5.Text = ""
        b6.Text = ""
        b7.Text = ""
        b8.Text = ""
        b9.Text = ""
        p1score.Text = score1
        p2score.Text = score2
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs)
        pick(sender)
    End Sub
    Sub pick(b As Button)
        b.Text = turn
        If turn = "X" Then
            turn = "O"
        Else
            turn = "X"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
    End Sub

    Private Sub b2_Click_1(sender As Object, e As EventArgs) Handles b9.Click, b8.Click, b7.Click, b6.Click, b5.Click, b4.Click, b3.Click, b2.Click, b1.Click
        pick(sender)
        If Iswinner() Then
            Me.BackColor = Color.Green
            If turn = "O" Then
                score1 = score1 + 1
            Else
                score2 = score2 + 1
            End If
            p1score.Text = score1
            p2score.Text = score2
            MsgBox("winner")
            reset()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reset()
    End Sub

    Function Iswinner() As Boolean
        If b1.Text = b2.Text And b2.Text = b3.Text And b1.Text <> "" Then Return True
        If b1.Text = b4.Text And b4.Text = b7.Text And b1.Text <> "" Then Return True
        If b1.Text = b5.Text And b5.Text = b9.Text And b1.Text <> "" Then Return True
        If b2.Text = b5.Text And b5.Text = b8.Text And b2.Text <> "" Then Return True
        If b3.Text = b6.Text And b6.Text = b9.Text And b3.Text <> "" Then Return True
        If b7.Text = b8.Text And b8.Text = b9.Text And b7.Text <> "" Then Return True
        If b3.Text = b5.Text And b5.Text = b7.Text And b3.Text <> "" Then Return True
        If b4.Text = b5.Text And b5.Text = b6.Text And b4.Text <> "" Then Return True

        Return False
    End Function
End Class
