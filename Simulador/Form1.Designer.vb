<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSimulador
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSimulador))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtgPrincipal = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtgCache = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtgAcesso = New System.Windows.Forms.DataGridView()
        Me.btnRemoverMP = New System.Windows.Forms.Button()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.btnAcesso = New System.Windows.Forms.Button()
        Me.btnLer = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnPreencher = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.txtMs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgCache, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtgAcesso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtgPrincipal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(936, 270)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Memória Principal"
        '
        'dtgPrincipal
        '
        Me.dtgPrincipal.AllowUserToAddRows = False
        Me.dtgPrincipal.AllowUserToDeleteRows = False
        Me.dtgPrincipal.AllowUserToResizeColumns = False
        Me.dtgPrincipal.AllowUserToResizeRows = False
        Me.dtgPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgPrincipal.BackgroundColor = System.Drawing.Color.White
        Me.dtgPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgPrincipal.Enabled = False
        Me.dtgPrincipal.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dtgPrincipal.Location = New System.Drawing.Point(9, 21)
        Me.dtgPrincipal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtgPrincipal.MultiSelect = False
        Me.dtgPrincipal.Name = "dtgPrincipal"
        Me.dtgPrincipal.ReadOnly = True
        Me.dtgPrincipal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgPrincipal.RowTemplate.Height = 24
        Me.dtgPrincipal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dtgPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgPrincipal.Size = New System.Drawing.Size(917, 240)
        Me.dtgPrincipal.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtgCache)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 288)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(221, 151)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Memória Cache"
        '
        'dtgCache
        '
        Me.dtgCache.AllowUserToAddRows = False
        Me.dtgCache.AllowUserToDeleteRows = False
        Me.dtgCache.AllowUserToResizeColumns = False
        Me.dtgCache.AllowUserToResizeRows = False
        Me.dtgCache.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgCache.BackgroundColor = System.Drawing.Color.White
        Me.dtgCache.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCache.Enabled = False
        Me.dtgCache.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dtgCache.Location = New System.Drawing.Point(9, 21)
        Me.dtgCache.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtgCache.MultiSelect = False
        Me.dtgCache.Name = "dtgCache"
        Me.dtgCache.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgCache.RowTemplate.Height = 24
        Me.dtgCache.Size = New System.Drawing.Size(204, 122)
        Me.dtgCache.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtgAcesso)
        Me.GroupBox3.Location = New System.Drawing.Point(239, 288)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(175, 150)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lista de Acesso"
        '
        'dtgAcesso
        '
        Me.dtgAcesso.AllowUserToAddRows = False
        Me.dtgAcesso.AllowUserToDeleteRows = False
        Me.dtgAcesso.AllowUserToResizeColumns = False
        Me.dtgAcesso.AllowUserToResizeRows = False
        Me.dtgAcesso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgAcesso.BackgroundColor = System.Drawing.Color.White
        Me.dtgAcesso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgAcesso.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dtgAcesso.Location = New System.Drawing.Point(7, 22)
        Me.dtgAcesso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtgAcesso.MultiSelect = False
        Me.dtgAcesso.Name = "dtgAcesso"
        Me.dtgAcesso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgAcesso.RowTemplate.Height = 24
        Me.dtgAcesso.Size = New System.Drawing.Size(160, 121)
        Me.dtgAcesso.TabIndex = 0
        '
        'btnRemoverMP
        '
        Me.btnRemoverMP.BackgroundImage = CType(resources.GetObject("btnRemoverMP.BackgroundImage"), System.Drawing.Image)
        Me.btnRemoverMP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRemoverMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoverMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoverMP.Location = New System.Drawing.Point(127, 82)
        Me.btnRemoverMP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRemoverMP.Name = "btnRemoverMP"
        Me.btnRemoverMP.Size = New System.Drawing.Size(67, 62)
        Me.btnRemoverMP.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnRemoverMP, "Limpar cores")
        Me.btnRemoverMP.UseVisualStyleBackColor = True
        '
        'btnReiniciar
        '
        Me.btnReiniciar.AccessibleDescription = ""
        Me.btnReiniciar.BackgroundImage = CType(resources.GetObject("btnReiniciar.BackgroundImage"), System.Drawing.Image)
        Me.btnReiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReiniciar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnReiniciar.Location = New System.Drawing.Point(192, 22)
        Me.btnReiniciar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(67, 62)
        Me.btnReiniciar.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btnReiniciar, "Reiniciar simulador")
        Me.btnReiniciar.UseVisualStyleBackColor = True
        '
        'btnAcesso
        '
        Me.btnAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcesso.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcesso.Location = New System.Drawing.Point(11, 82)
        Me.btnAcesso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAcesso.Name = "btnAcesso"
        Me.btnAcesso.Size = New System.Drawing.Size(117, 62)
        Me.btnAcesso.TabIndex = 9
        Me.btnAcesso.Text = "Gerar Lista de Acesso"
        Me.btnAcesso.UseVisualStyleBackColor = True
        '
        'btnLer
        '
        Me.btnLer.BackgroundImage = CType(resources.GetObject("btnLer.BackgroundImage"), System.Drawing.Image)
        Me.btnLer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLer.Location = New System.Drawing.Point(127, 22)
        Me.btnLer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLer.Name = "btnLer"
        Me.btnLer.Size = New System.Drawing.Size(67, 62)
        Me.btnLer.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.btnLer, "Iniciar leitura")
        Me.btnLer.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnPreencher)
        Me.GroupBox4.Controls.Add(Me.btnSair)
        Me.GroupBox4.Controls.Add(Me.btnAcesso)
        Me.GroupBox4.Controls.Add(Me.btnRemoverMP)
        Me.GroupBox4.Controls.Add(Me.btnLer)
        Me.GroupBox4.Controls.Add(Me.btnReiniciar)
        Me.GroupBox4.Location = New System.Drawing.Point(677, 288)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(271, 150)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ações"
        '
        'btnPreencher
        '
        Me.btnPreencher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreencher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreencher.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPreencher.Location = New System.Drawing.Point(11, 22)
        Me.btnPreencher.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPreencher.Name = "btnPreencher"
        Me.btnPreencher.Size = New System.Drawing.Size(117, 62)
        Me.btnPreencher.TabIndex = 12
        Me.btnPreencher.Text = "Gerar MP"
        Me.btnPreencher.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = CType(resources.GetObject("btnSair.BackgroundImage"), System.Drawing.Image)
        Me.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Location = New System.Drawing.Point(192, 82)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(67, 62)
        Me.btnSair.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.btnSair, "Sair do simulador")
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'txtMs
        '
        Me.txtMs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMs.Location = New System.Drawing.Point(505, 355)
        Me.txtMs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMs.Name = "txtMs"
        Me.txtMs.Size = New System.Drawing.Size(68, 26)
        Me.txtMs.TabIndex = 12
        Me.txtMs.Text = "30"
        Me.txtMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(510, 331)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Delay:"
        '
        'frmSimulador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(965, 448)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMs)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmSimulador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simulador de Memória Cache - Thiago Sasaki"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtgPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dtgCache, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dtgAcesso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtgPrincipal As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtgCache As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnRemoverMP As Button
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents btnAcesso As Button
    Friend WithEvents btnLer As Button
    Friend WithEvents dtgAcesso As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnSair As Button
    Friend WithEvents btnPreencher As Button
    Friend WithEvents txtMs As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
