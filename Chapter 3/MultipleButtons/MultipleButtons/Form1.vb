Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblGreeting.Click

    End Sub

    Private Sub btnJapanese_Click(sender As Object, e As EventArgs) Handles btnJapanese.Click
        lblTranslate.Text = "おはようございます"
    End Sub

    Private Sub btnChinese_Click(sender As Object, e As EventArgs) Handles btnChinese.Click
        lblTranslate.Text = "早上好"
    End Sub

    Private Sub btnSpanish_Click(sender As Object, e As EventArgs) Handles btnSpanish.Click
        lblTranslate.Text = "Buenos días"
    End Sub

    Private Sub lblTranslate_Click(sender As Object, e As EventArgs) Handles lblTranslate.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
