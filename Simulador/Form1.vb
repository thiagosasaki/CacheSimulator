Public Class frmSimulador

    Public Sub Preencher()

        Dim i As Integer
        Dim NumerosMP(127) As Integer
        Dim NumerosAcesso(15) As Integer
        Dim lin As Integer
        Dim col As Integer
        Dim cont As Integer

        lin = 0
        col = 0
        cont = 0

        For i = 0 To 127
            Randomize()
            NumerosMP(i) = Int(999 * Rnd() + 1)
        Next

        i = 0
        Do While lin < 8
            col = 0
            Do While col < 16
                dtgPrincipal.Rows(lin).Cells(col).Value = NumerosMP(i)
                i = i + 1
                col = col + 1
            Loop
            lin = lin + 1
        Loop

        i = 0

    End Sub

    Public Sub frmSimulador_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtgPrincipal.ColumnCount = 16
        dtgPrincipal.RowCount = 8
        dtgPrincipal.ColumnHeadersVisible = False
        dtgPrincipal.RowHeadersVisible = False
        dtgPrincipal.ClearSelection()

        dtgCache.ColumnCount = 4
        dtgCache.RowCount = 4
        dtgCache.ColumnHeadersVisible = False
        dtgCache.RowHeadersVisible = False
        dtgCache.ClearSelection()

        dtgAcesso.ColumnCount = 2
        dtgAcesso.RowCount = 8
        dtgAcesso.ColumnHeadersVisible = False
        dtgAcesso.RowHeadersVisible = False
        dtgAcesso.ClearSelection()

    End Sub

    Private Sub btnRemoverMP_Click(sender As Object, e As EventArgs) Handles btnRemoverMP.Click

        If MsgBox("Deseja mesmo remover as cores?", vbYesNo, "Confirmar") = vbNo Then
            Exit Sub
        ElseIf vbYes Then
            Dim lin As Integer
            Dim col As Integer

            lin = 0
            col = 0

            Do While lin < 8
                col = 0
                Do While col < 16
                    dtgPrincipal.Rows(lin).Cells(col).Style.BackColor = Color.White
                    col = col + 1
                Loop
                lin = lin + 1
            Loop

            lin = 0
            col = 0

            Do While lin < 4
                col = 0
                Do While col < 4
                    dtgCache.Rows(lin).Cells(col).Style.BackColor = Color.White
                    col = col + 1
                Loop
                lin = lin + 1
            Loop

            lin = 0
            col = 0

            Do While lin < 8
                col = 0
                Do While col < 2
                    dtgAcesso.Rows(lin).Cells(col).Style.BackColor = Color.White
                    col = col + 1
                Loop
                lin = lin + 1
            Loop
        End If

    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click

        If MsgBox("Deseja mesmo reiniciar as memórias?", vbYesNo, "Atenção") = vbNo Then
            Exit Sub
        ElseIf vbYes Then
            dtgPrincipal.Rows.Clear()
            dtgCache.Rows.Clear()
            dtgAcesso.Rows.Clear()

            dtgPrincipal.ColumnCount = 16
            dtgPrincipal.RowCount = 8
            dtgPrincipal.ColumnHeadersVisible = False
            dtgPrincipal.RowHeadersVisible = False
            dtgPrincipal.ClearSelection()

            dtgCache.ColumnCount = 4
            dtgCache.RowCount = 4
            dtgCache.ColumnHeadersVisible = False
            dtgCache.RowHeadersVisible = False
            dtgCache.ClearSelection()

            dtgAcesso.ColumnCount = 2
            dtgAcesso.RowCount = 8
            dtgAcesso.ColumnHeadersVisible = False
            dtgAcesso.RowHeadersVisible = False
            dtgAcesso.ClearSelection()

        End If

    End Sub

    Public Sub btnAcesso_Click(sender As Object, e As EventArgs) Handles btnAcesso.Click

        If (dtgPrincipal.Rows(0).Cells(0).Value Is Nothing) Then
            MsgBox("Necessário preencher a Memória Principal antes!")
            Exit Sub
        End If

        Dim i As Integer
        Dim lin As Integer
        Dim col As Integer
        Dim NumerosAcesso(15) As Integer

        lin = 0
        col = 0
        i = 0

        dtgAcesso.ColumnCount = 2
        dtgAcesso.RowCount = 8
        dtgAcesso.ColumnHeadersVisible = False
        dtgAcesso.RowHeadersVisible = False
        dtgAcesso.ClearSelection()

        Do While lin < 8
            col = 0
            Do While col < 2
                dtgAcesso.Rows(lin).Cells(col).Style.BackColor = Color.White
                col = col + 1
            Loop
            lin = lin + 1
        Loop

        Do While i < 16
            Randomize()
            lin = Int((7 * Rnd()) + 0)
            col = Int((15 * Rnd()) + 0)
            NumerosAcesso(i) = dtgPrincipal.Rows(lin).Cells(col).Value
            i = i + 1
        Loop

        lin = 0
        col = 0
        i = 0

        Do While lin < 8
            col = 0
            Do While col < 2
                dtgAcesso.Rows(lin).Cells(col).Value = NumerosAcesso(i)
                i = i + 1
                col = col + 1
            Loop
            lin = lin + 1
        Loop

    End Sub

    Private Sub btnLer_Click(sender As Object, e As EventArgs) Handles btnLer.Click

        If (dtgPrincipal.Rows(0).Cells(0).Value Is Nothing) Then
            MsgBox("Necessário preencher a Memória Principal antes!")
            Exit Sub
        End If
        If (dtgAcesso.Rows(0).Cells(0).Value Is Nothing) Then
            MsgBox("Necessário preencher a Lista de Acesso antes!")
            Exit Sub
        End If

        Dim linAcesso As Integer
        Dim colAcesso As Integer

        Dim linMP As Integer
        Dim colMP As Integer

        Dim linMC As Integer
        Dim colMC As Integer

        Dim hit As Integer
        Dim miss As Integer
        Dim ver As Integer

        Dim linVer As Integer
        Dim colVer As Integer
        Dim Verificar As Integer

        Dim ms As Double

        linAcesso = 0
        colAcesso = 0
        linMP = 0
        colMP = 0
        linMC = 0
        colMC = 0
        linVer = 0
        colVer = 0

        hit = 0
        miss = 0

        GVal.val = 0
        GVal.looper = 0

        frmLeitura.ShowDialog()

        If GVal.val = 1 Then

            'Loop lista de acesso
            Do Until linAcesso = 8
                colAcesso = 0
                Do Until colAcesso = 2
                    dtgAcesso.Rows(linAcesso).Cells(colAcesso).Selected = True
                    'Verifica se o nº de acesso já está na Cache
                    Verificar = 0
                    linVer = 0
                    colVer = 0
                    Do While linVer < 4 And Verificar = 0
                        colVer = 0
                        Do While colVer < 4 And Verificar = 0
                            'Verifica se já é verde
                            If dtgCache.Rows(linVer).Cells(colVer).Style.BackColor = Color.Green Then
                                dtgCache.Rows(linVer).Cells(colVer).Style.BackColor = Color.Gold
                                If Not IsNumeric(txtMs.Text) Then
                                    ms = 30
                                Else
                                    ms = txtMs.Text
                                End If
                                Delay(ms)
                                dtgCache.Rows(linVer).Cells(colVer).Style.BackColor = Color.Green

                                If dtgCache.Rows(linVer).Cells(colVer).Value = dtgAcesso.Rows(linAcesso).Cells(colAcesso).Value Then
                                    dtgCache.Rows(linVer).Cells(colVer).Style.BackColor = Color.Green
                                    dtgAcesso.Rows(linAcesso).Cells(colAcesso).Style.BackColor = Color.LightCoral
                                    colAcesso = colAcesso + 1
                                    Verificar = 1
                                    hit = hit + 1
                                    Exit Do
                                End If

                                colVer = colVer + 1
                            Else
                                dtgCache.Rows(linVer).Cells(colVer).Style.BackColor = Color.Gold
                                If Not IsNumeric(txtMs.Text) Then
                                    ms = 30
                                Else
                                    ms = txtMs.Text
                                End If
                                Delay(ms)
                                If dtgCache.Rows(linVer).Cells(colVer).Value Is Nothing Then
                                    dtgCache.Rows(linVer).Cells(colVer).Style.BackColor = Color.White
                                Else
                                    dtgCache.Rows(linVer).Cells(colVer).Style.BackColor = Color.LightCoral
                                End If

                                'Procura valor de acesso repetido
                                If dtgCache.Rows(linVer).Cells(colVer).Value = dtgAcesso.Rows(linAcesso).Cells(colAcesso).Value Then
                                    dtgCache.Rows(linVer).Cells(colVer).Style.BackColor = Color.Green
                                    dtgAcesso.Rows(linAcesso).Cells(colAcesso).Style.BackColor = Color.LightCoral
                                    colAcesso = colAcesso + 1
                                    Verificar = 1
                                    hit = hit + 1
                                    Exit Do
                                End If
                                colVer = colVer + 1
                            End If
                        Loop
                        linVer = linVer + 1
                    Loop
                    If colAcesso < 2 And Verificar = 0 Then
                        'Inicia Leitura na MP
                        linMP = 0
                        miss = miss + 1
                        Do Until linMP = 8
                            colMP = 0
                            Do Until colMP = 16
                                If dtgPrincipal.Rows(linMP).Cells(colMP).Style.BackColor = Color.LightCoral Then
                                    colMP = colMP
                                Else
                                    dtgPrincipal.Rows(linMP).Cells(colMP).Style.BackColor = Color.LightCoral
                                    Delay(ms)
                                    dtgPrincipal.Rows(linMP).Cells(colMP).Style.BackColor = Color.White
                                    If dtgPrincipal.Rows(linMP).Cells(colMP).Value = dtgAcesso.Rows(linAcesso).Cells(colAcesso).Value Then
                                        dtgCache.Rows(linMC).Cells(colMC).Value = dtgPrincipal.Rows(linMP).Cells(colMP).Value
                                        dtgPrincipal.Rows(linMP).Cells(colMP).Style.BackColor = Color.LightCoral
                                        dtgCache.Rows(linMC).Cells(colMC).Style.BackColor = Color.LightCoral
                                        dtgAcesso.Rows(linAcesso).Cells(colAcesso).Style.BackColor = Color.LightCoral
                                        If colMC <> 3 And linMC < 4 Then
                                            colMC = colMC + 1
                                        ElseIf colMC = 3 And linMC < 4 Then
                                            colMC = 0
                                            linMC = linMC + 1
                                        End If
                                        colAcesso = colAcesso + 1
                                        ver = 1
                                        Exit Do
                                    End If
                                End If
                                colMP = colMP + 1
                            Loop
                            linMP = linMP + 1
                            If ver > 0 Then
                                ver = 0
                                Exit Do
                            End If
                        Loop
                    End If
                Loop
                linAcesso = linAcesso + 1
            Loop

        ElseIf GVal.val = 2 Then

            Do While GVal.looper < 3

                linAcesso = 0
                colAcesso = 0
                linMP = 0
                colMP = 0
                linMC = 0
                colMC = 0
                linVer = 0
                colVer = 0

                btnAcesso_Click(sender, e)

                'Loop lista de acesso
                Do Until linAcesso = 8 Or GVal.looper > 2
                    If GVal.looper = 2 Then
                        frmPausa.ShowDialog()
                    End If
                    colAcesso = 0
                    Do Until colAcesso = 2 Or GVal.looper > 2
                        If GVal.looper = 2 Then
                            frmPausa.ShowDialog()
                        End If
                        dtgAcesso.Rows(linAcesso).Cells(colAcesso).Selected = True
                        'Verifica se o nº de acesso já está na Cache
                        Verificar = 0
                        linVer = 0
                        colVer = 0
                        Do While linVer < 4 And Verificar = 0 And GVal.looper < 3
                            If GVal.looper = 2 Then
                                frmPausa.ShowDialog()
                            End If
                            colVer = 0
                            Do While colVer < 4 And Verificar = 0 And GVal.looper < 3
                                If GVal.looper = 2 Then
                                    frmPausa.ShowDialog()
                                End If
                                'Verifica se já é verde
                                If dtgCache.Rows(linVer).Cells(colVer).Style.BackColor = Color.Green Then
                                    dtgCache.Rows(linVer).Cells(colVer).Style.BackColor = Color.Gold
                                    If Not IsNumeric(txtMs.Text) Then
                                        ms = 30
                                    Else
                                        ms = txtMs.Text
                                    End If
                                    Delay(ms)
                                    dtgCache.Rows(linVer).Cells(colVer).Style.BackColor = Color.Green

                                    If dtgCache.Rows(linVer).Cells(colVer).Value = dtgAcesso.Rows(linAcesso).Cells(colAcesso).Value Then
                                        dtgCache.Rows(linVer).Cells(colVer).Style.BackColor = Color.Green
                                        dtgAcesso.Rows(linAcesso).Cells(colAcesso).Style.BackColor = Color.LightCoral
                                        colAcesso = colAcesso + 1
                                        Verificar = 1
                                        hit = hit + 1
                                        Exit Do
                                    End If

                                    colVer = colVer + 1
                                Else
                                    dtgCache.Rows(linVer).Cells(colVer).Style.BackColor = Color.Gold
                                    If Not IsNumeric(txtMs.Text) Then
                                        ms = 30
                                    Else
                                        ms = txtMs.Text
                                    End If
                                    Delay(ms)
                                    If dtgCache.Rows(linVer).Cells(colVer).Value Is Nothing Then
                                        dtgCache.Rows(linVer).Cells(colVer).Style.BackColor = Color.White
                                    Else
                                        dtgCache.Rows(linVer).Cells(colVer).Style.BackColor = Color.LightCoral
                                    End If

                                    'Procura valor de acesso repetido
                                    If dtgCache.Rows(linVer).Cells(colVer).Value = dtgAcesso.Rows(linAcesso).Cells(colAcesso).Value Then
                                        dtgCache.Rows(linVer).Cells(colVer).Style.BackColor = Color.Green
                                        dtgAcesso.Rows(linAcesso).Cells(colAcesso).Style.BackColor = Color.LightCoral
                                        colAcesso = colAcesso + 1
                                        Verificar = 1
                                        hit = hit + 1
                                        Exit Do
                                    End If
                                    colVer = colVer + 1
                                End If
                            Loop
                            linVer = linVer + 1
                        Loop
                        If colAcesso < 2 And Verificar = 0 And GVal.looper < 3 Then
                            If GVal.looper = 2 Then
                                frmPausa.ShowDialog()
                            End If
                            'Inicia Leitura na MP
                            linMP = 0
                            miss = miss + 1
                            Do Until linMP = 8 Or GVal.looper > 2
                                If GVal.looper = 2 Then
                                    frmPausa.ShowDialog()
                                End If
                                colMP = 0
                                Do Until colMP = 16 Or GVal.looper > 2
                                    If GVal.looper = 2 Then
                                        frmPausa.ShowDialog()
                                    End If
                                    If dtgPrincipal.Rows(linMP).Cells(colMP).Style.BackColor = Color.LightCoral Then
                                        'colMP = colMP
                                        If dtgPrincipal.Rows(linMP).Cells(colMP).Value = dtgAcesso.Rows(linAcesso).Cells(colAcesso).Value Then
                                            dtgCache.Rows(linMC).Cells(colMC).Value = dtgPrincipal.Rows(linMP).Cells(colMP).Value
                                            dtgPrincipal.Rows(linMP).Cells(colMP).Style.BackColor = Color.LightCoral
                                            dtgCache.Rows(linMC).Cells(colMC).Style.BackColor = Color.LightCoral
                                            dtgAcesso.Rows(linAcesso).Cells(colAcesso).Style.BackColor = Color.LightCoral
                                            If colMC <> 3 And linMC < 4 Then
                                                colMC = colMC + 1
                                            ElseIf colMC = 3 And linMC < 4 Then
                                                colMC = 0
                                                linMC = linMC + 1
                                            End If
                                            colAcesso = colAcesso + 1
                                            ver = 1
                                            Exit Do
                                        End If
                                    Else
                                        dtgPrincipal.Rows(linMP).Cells(colMP).Style.BackColor = Color.LightCoral
                                        Delay(ms)
                                        dtgPrincipal.Rows(linMP).Cells(colMP).Style.BackColor = Color.White
                                        If dtgPrincipal.Rows(linMP).Cells(colMP).Value = dtgAcesso.Rows(linAcesso).Cells(colAcesso).Value Then
                                            dtgCache.Rows(linMC).Cells(colMC).Value = dtgPrincipal.Rows(linMP).Cells(colMP).Value
                                            dtgPrincipal.Rows(linMP).Cells(colMP).Style.BackColor = Color.LightCoral
                                            dtgCache.Rows(linMC).Cells(colMC).Style.BackColor = Color.LightCoral
                                            dtgAcesso.Rows(linAcesso).Cells(colAcesso).Style.BackColor = Color.LightCoral
                                            If colMC <> 3 And linMC < 4 Then
                                                colMC = colMC + 1
                                            ElseIf colMC = 3 And linMC < 4 Then
                                                colMC = 0
                                                linMC = linMC + 1
                                            End If
                                            colAcesso = colAcesso + 1
                                            ver = 1
                                            Exit Do
                                        End If
                                    End If
                                    colMP = colMP + 1
                                Loop
                                linMP = linMP + 1
                                If ver > 0 Then
                                    ver = 0
                                    Exit Do
                                End If
                            Loop
                        End If
                    Loop
                    linAcesso = linAcesso + 1
                Loop
            Loop

        ElseIf GVal.val = 3 Then
            Exit Sub

        End If

        MsgBox("Leitura concluída! Hits: " & hit & " Misses: " & miss & ".")

    End Sub

    Public Sub Delay(ByVal ms As Double)

        Dim Delay As TimeSpan

        Dim NewTime As DateTime = DateTime.Now.AddMilliseconds(ms)

        Do
            Delay = NewTime.Subtract(DateTime.Now)
            Application.DoEvents()
        Loop While Delay.Milliseconds > 0

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        If MsgBox("Deseja mesmo encerrar o simulador?", vbYesNo, "Confirmar") = vbNo Then
            Exit Sub
        ElseIf vbYes Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnPreencher_Click_1(sender As Object, e As EventArgs) Handles btnPreencher.Click

        Preencher()

    End Sub

End Class
Public Class GVal
    Public Shared val As Integer
    Public Shared looper As Integer

End Class