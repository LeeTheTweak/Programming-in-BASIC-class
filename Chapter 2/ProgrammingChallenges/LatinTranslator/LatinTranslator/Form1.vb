Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTranslation.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnSinister_Click(sender As Object, e As EventArgs) Handles btnSinister.Click
        lblTranslation.Text = "left"
    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        lblTranslation.Text = "middle"
    End Sub

    Private Sub btnDexter_Click(sender As Object, e As EventArgs) Handles btnDexter.Click
        lblTranslation.Text = "right"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
