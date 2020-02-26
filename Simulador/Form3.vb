Public Class frmToolbox
    Private Sub BtnParar_Click(sender As Object, e As EventArgs) Handles btnParar.Click
        GVal.looper = 3
        Me.Close()
    End Sub

    Private Sub BtnPausar_Click(sender As Object, e As EventArgs) Handles btnPausar.Click
        GVal.looper = 2
        Me.Close()
    End Sub
End Class