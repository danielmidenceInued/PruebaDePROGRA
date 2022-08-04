Public Class Form1

    Private Sub BtnRojo_Click(sender As Object, e As EventArgs) Handles BtnRojo.Click
        TxtColores.BackColor = Color.Red
    End Sub

    Private Sub BtnAmarillo_Click(sender As Object, e As EventArgs) Handles BtnAmarillo.Click
        TxtColores.BackColor = Color.Yellow
    End Sub

    Private Sub BtnAzul_Click(sender As Object, e As EventArgs) Handles BtnAzul.Click
        TxtColores.BackColor = Color.Blue
    End Sub

    Private Sub BtnVerde_Click(sender As Object, e As EventArgs) Handles BtnVerde.Click
        TxtColores.BackColor = Color.Green
    End Sub

    Private Sub BtnGris_Click(sender As Object, e As EventArgs) Handles BtnGris.Click
        TxtColores.BackColor = Color.DarkGray
    End Sub
End Class
