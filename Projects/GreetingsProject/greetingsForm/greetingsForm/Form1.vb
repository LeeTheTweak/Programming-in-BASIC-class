Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblPromptBox_Click(sender As Object, e As EventArgs) Handles lblPromptBox.Click

    End Sub

    Private Sub txtNameBox_TextChanged(sender As Object, e As EventArgs) Handles txtNameBox.TextChanged

    End Sub

    Private Sub btnShowGreeting_Click(sender As Object, e As EventArgs) Handles btnShowGreeting.Click
        lblGreeting.Text = "Hello, " + txtNameBox.Text
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub lblGreeting_Click(sender As Object, e As EventArgs) Handles lblGreeting.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNameBox.Clear()
    End Sub
End Class
