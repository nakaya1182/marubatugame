Public Class Form1
    ' 整数2次元配列変数の初期化
    Dim status(,) As Integer = {
        {7, 8, 9},
        {4, 5, 6},
        {1, 2, 3}
    }
    Dim turn As Integer = TurnEnum.maru
    Dim turnCount As Integer = 0
    Public Enum TurnEnum
        maru
        batu
    End Enum
    Private Sub Button(button, num1, num2)
        button.Font = New Font("ＭＳ Ｐゴシック", 50, FontStyle.Bold)
        If status(num1, num2) < 10 Then
            If turn = TurnEnum.maru Then
                button.Text = "〇"
                status(num1, num2) = 10
                turn = TurnEnum.batu
            Else
                button.Text = "×"
                status(num1, num2) = 20
                turn = TurnEnum.maru
            End If
            turnCount += 1
            Check()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button(Button1, 2, 0)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button(Button2, 2, 1)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button(Button3, 2, 2)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button(Button4, 1, 0)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button(Button5, 1, 1)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button(Button6, 1, 2)
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button(Button7, 0, 0)
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button(Button8, 0, 1)
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Button(Button9, 0, 2)
    End Sub
    Private Sub ButtonR_Click(sender As Object, e As EventArgs) Handles ButtonR.Click
        Reset()
    End Sub
    Private Sub Check()
        Dim i As Integer
        For i = 0 To 2
            If (status(i, 0) = status(i, 1) And status(i, 1) = status(i, 2)) Or
                (status(0, i) = status(1, i) And status(1, i) = status(2, i)) Or
                (status(0, 0) = status(1, 1) And status(1, 1) = status(2, 2)) Or
                (status(0, 2) = status(1, 1) And status(1, 1) = status(2, 0)) Then
                If turn = TurnEnum.batu Then
                    MessageBox.Show("〇の勝ちデース",
                    "終了",
                    MessageBoxButtons.OK)
                    Reset()
                Else
                    MessageBox.Show("×の勝ちデース",
                    "終了",
                    MessageBoxButtons.OK)
                    Reset()
                End If
            End If
        Next
        If turnCount >= 9 Then
            MessageBox.Show("引き分けです。",
                    "終了",
                    MessageBoxButtons.OK)
            Reset()
        End If
    End Sub

    Private Sub Reset()
        turn = TurnEnum.maru
        turnCount = 0
        status = {
        {7, 8, 9},
        {4, 5, 6},
        {1, 2, 3}
    }
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
    End Sub
End Class

