Public Class frmPausa
    Private Sub BtnRetomar_Click(sender As Object, e As EventArgs) Handles btnRetomar.Click
        GVal.looper = 1
        frmToolbox.Show()
        Me.Close()
    End Sub

    Private Sub BtnEncerrar_Click(sender As Object, e As EventArgs) Handles btnEncerrar.Click
        GVal.looper = 3
        Me.Close()
    End Sub
End Class