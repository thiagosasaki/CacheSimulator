Public Class frmLeitura
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        GVal.val = 1
        Me.Close()
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        GVal.val = 2
        frmToolbox.Show()
        Me.Close()
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        GVal.val = 3
        Me.Close()
    End Sub
End Class