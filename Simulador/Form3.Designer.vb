<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmToolbox
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmToolbox))
        Me.btnPausar = New System.Windows.Forms.Button()
        Me.btnParar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnPausar
        '
        Me.btnPausar.BackgroundImage = CType(resources.GetObject("btnPausar.BackgroundImage"), System.Drawing.Image)
        Me.btnPausar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPausar.Location = New System.Drawing.Point(15, 14)
        Me.btnPausar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPausar.Name = "btnPausar"
        Me.btnPausar.Size = New System.Drawing.Size(67, 62)
        Me.btnPausar.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.btnPausar, "Continuar/Pausar execução")
        Me.btnPausar.UseVisualStyleBackColor = True
        '
        'btnParar
        '
        Me.btnParar.BackgroundImage = CType(resources.GetObject("btnParar.BackgroundImage"), System.Drawing.Image)
        Me.btnParar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParar.Location = New System.Drawing.Point(99, 14)
        Me.btnParar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnParar.Name = "btnParar"
        Me.btnParar.Size = New System.Drawing.Size(67, 62)
        Me.btnParar.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.btnParar, "Parar execução")
        Me.btnParar.UseVisualStyleBackColor = True
        '
        'frmToolbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(181, 89)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnParar)
        Me.Controls.Add(Me.btnPausar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmToolbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Controle"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPausar As Button
    Friend WithEvents btnParar As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
