<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListArch
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TlpMensaje = New System.Windows.Forms.TableLayoutPanel()
        Me.LbTitulo = New System.Windows.Forms.Label()
        Me.TlpPrincipal = New System.Windows.Forms.TableLayoutPanel()
        Me.GbFiltro = New System.Windows.Forms.GroupBox()
        Me.BtExtensiones = New System.Windows.Forms.Button()
        Me.TbExtensiones = New System.Windows.Forms.TextBox()
        Me.RbExtdeterminada = New System.Windows.Forms.RadioButton()
        Me.RbExtGeneral = New System.Windows.Forms.RadioButton()
        Me.PbBarra = New System.Windows.Forms.PictureBox()
        Me.BtCarpeta = New System.Windows.Forms.Button()
        Me.TbCarpeta = New System.Windows.Forms.TextBox()
        Me.CheckBoxSubcarpetas = New System.Windows.Forms.CheckBox()
        Me.TlpMensaje.SuspendLayout()
        Me.TlpPrincipal.SuspendLayout()
        Me.GbFiltro.SuspendLayout()
        CType(Me.PbBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TlpMensaje
        '
        Me.TlpMensaje.AutoSize = True
        Me.TlpMensaje.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TlpMensaje.BackColor = System.Drawing.Color.Gold
        Me.TlpMensaje.ColumnCount = 1
        Me.TlpMensaje.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TlpMensaje.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMensaje.Controls.Add(Me.LbTitulo, 0, 0)
        Me.TlpMensaje.Dock = System.Windows.Forms.DockStyle.Top
        Me.TlpMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TlpMensaje.Location = New System.Drawing.Point(0, 0)
        Me.TlpMensaje.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpMensaje.Name = "TlpMensaje"
        Me.TlpMensaje.RowCount = 1
        Me.TlpMensaje.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpMensaje.Size = New System.Drawing.Size(419, 38)
        Me.TlpMensaje.TabIndex = 23
        Me.TlpMensaje.TabStop = True
        '
        'LbTitulo
        '
        Me.LbTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LbTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTitulo.Location = New System.Drawing.Point(0, 0)
        Me.LbTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.LbTitulo.Name = "LbTitulo"
        Me.LbTitulo.Padding = New System.Windows.Forms.Padding(8, 6, 0, 6)
        Me.LbTitulo.Size = New System.Drawing.Size(233, 38)
        Me.LbTitulo.TabIndex = 0
        Me.LbTitulo.Text = "Listado De Archivos"
        '
        'TlpPrincipal
        '
        Me.TlpPrincipal.AutoSize = True
        Me.TlpPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TlpPrincipal.BackColor = System.Drawing.Color.DarkOrange
        Me.TlpPrincipal.ColumnCount = 2
        Me.TlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TlpPrincipal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TlpPrincipal.Controls.Add(Me.GbFiltro, 0, 2)
        Me.TlpPrincipal.Controls.Add(Me.PbBarra, 0, 3)
        Me.TlpPrincipal.Controls.Add(Me.BtCarpeta, 0, 0)
        Me.TlpPrincipal.Controls.Add(Me.TbCarpeta, 1, 0)
        Me.TlpPrincipal.Controls.Add(Me.CheckBoxSubcarpetas, 0, 1)
        Me.TlpPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TlpPrincipal.Location = New System.Drawing.Point(20, 53)
        Me.TlpPrincipal.Margin = New System.Windows.Forms.Padding(20)
        Me.TlpPrincipal.Name = "TlpPrincipal"
        Me.TlpPrincipal.RowCount = 4
        Me.TlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpPrincipal.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpPrincipal.Size = New System.Drawing.Size(380, 421)
        Me.TlpPrincipal.TabIndex = 28
        Me.TlpPrincipal.TabStop = True
        '
        'GbFiltro
        '
        Me.GbFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GbFiltro.AutoSize = True
        Me.GbFiltro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TlpPrincipal.SetColumnSpan(Me.GbFiltro, 2)
        Me.GbFiltro.Controls.Add(Me.BtExtensiones)
        Me.GbFiltro.Controls.Add(Me.TbExtensiones)
        Me.GbFiltro.Controls.Add(Me.RbExtdeterminada)
        Me.GbFiltro.Controls.Add(Me.RbExtGeneral)
        Me.GbFiltro.Location = New System.Drawing.Point(11, 98)
        Me.GbFiltro.Margin = New System.Windows.Forms.Padding(10)
        Me.GbFiltro.Name = "GbFiltro"
        Me.GbFiltro.Padding = New System.Windows.Forms.Padding(0)
        Me.GbFiltro.Size = New System.Drawing.Size(357, 133)
        Me.GbFiltro.TabIndex = 1
        Me.GbFiltro.TabStop = False
        Me.GbFiltro.Text = "Filtros"
        '
        'BtExtensiones
        '
        Me.BtExtensiones.AutoSize = True
        Me.BtExtensiones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtExtensiones.BackColor = System.Drawing.Color.YellowGreen
        Me.BtExtensiones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtExtensiones.Location = New System.Drawing.Point(181, 16)
        Me.BtExtensiones.Margin = New System.Windows.Forms.Padding(10)
        Me.BtExtensiones.Name = "BtExtensiones"
        Me.BtExtensiones.Size = New System.Drawing.Size(163, 27)
        Me.BtExtensiones.TabIndex = 3
        Me.BtExtensiones.Text = "Limpiar Extensiones"
        Me.BtExtensiones.UseVisualStyleBackColor = False
        '
        'TbExtensiones
        '
        Me.TbExtensiones.Location = New System.Drawing.Point(13, 94)
        Me.TbExtensiones.Margin = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.TbExtensiones.Name = "TbExtensiones"
        Me.TbExtensiones.Size = New System.Drawing.Size(334, 23)
        Me.TbExtensiones.TabIndex = 2
        '
        'RbExtdeterminada
        '
        Me.RbExtdeterminada.AutoSize = True
        Me.RbExtdeterminada.Location = New System.Drawing.Point(10, 47)
        Me.RbExtdeterminada.Margin = New System.Windows.Forms.Padding(10)
        Me.RbExtdeterminada.Name = "RbExtdeterminada"
        Me.RbExtdeterminada.Size = New System.Drawing.Size(285, 38)
        Me.RbExtdeterminada.TabIndex = 1
        Me.RbExtdeterminada.Text = "Extensiones Personalizadas." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Indicarlas Separadas Por Comas ','."
        Me.RbExtdeterminada.UseVisualStyleBackColor = True
        '
        'RbExtGeneral
        '
        Me.RbExtGeneral.AutoSize = True
        Me.RbExtGeneral.Checked = True
        Me.RbExtGeneral.Location = New System.Drawing.Point(10, 19)
        Me.RbExtGeneral.Margin = New System.Windows.Forms.Padding(10)
        Me.RbExtGeneral.Name = "RbExtGeneral"
        Me.RbExtGeneral.Size = New System.Drawing.Size(169, 21)
        Me.RbExtGeneral.TabIndex = 0
        Me.RbExtGeneral.TabStop = True
        Me.RbExtGeneral.Tag = "Act"
        Me.RbExtGeneral.Text = "Todos Los Archivos"
        Me.RbExtGeneral.UseVisualStyleBackColor = True
        '
        'PbBarra
        '
        Me.PbBarra.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PbBarra.BackColor = System.Drawing.Color.Transparent
        Me.TlpPrincipal.SetColumnSpan(Me.PbBarra, 2)
        Me.PbBarra.Location = New System.Drawing.Point(10, 251)
        Me.PbBarra.Margin = New System.Windows.Forms.Padding(10)
        Me.PbBarra.Name = "PbBarra"
        Me.PbBarra.Size = New System.Drawing.Size(360, 160)
        Me.PbBarra.TabIndex = 30
        Me.PbBarra.TabStop = False
        '
        'BtCarpeta
        '
        Me.BtCarpeta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtCarpeta.AutoSize = True
        Me.BtCarpeta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtCarpeta.BackColor = System.Drawing.Color.YellowGreen
        Me.BtCarpeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCarpeta.Location = New System.Drawing.Point(10, 10)
        Me.BtCarpeta.Margin = New System.Windows.Forms.Padding(10)
        Me.BtCarpeta.Name = "BtCarpeta"
        Me.BtCarpeta.Size = New System.Drawing.Size(33, 27)
        Me.BtCarpeta.TabIndex = 2
        Me.BtCarpeta.Text = "..."
        Me.BtCarpeta.UseVisualStyleBackColor = False
        '
        'TbCarpeta
        '
        Me.TbCarpeta.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TbCarpeta.Enabled = False
        Me.TbCarpeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCarpeta.Location = New System.Drawing.Point(63, 12)
        Me.TbCarpeta.Margin = New System.Windows.Forms.Padding(10)
        Me.TbCarpeta.Name = "TbCarpeta"
        Me.TbCarpeta.ReadOnly = True
        Me.TbCarpeta.Size = New System.Drawing.Size(150, 23)
        Me.TbCarpeta.TabIndex = 3
        Me.TbCarpeta.TabStop = False
        Me.TbCarpeta.Text = "Seleccione Carpeta"
        '
        'CheckBoxSubcarpetas
        '
        Me.CheckBoxSubcarpetas.AutoSize = True
        Me.TlpPrincipal.SetColumnSpan(Me.CheckBoxSubcarpetas, 2)
        Me.CheckBoxSubcarpetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSubcarpetas.Location = New System.Drawing.Point(10, 57)
        Me.CheckBoxSubcarpetas.Margin = New System.Windows.Forms.Padding(10)
        Me.CheckBoxSubcarpetas.Name = "CheckBoxSubcarpetas"
        Me.CheckBoxSubcarpetas.Size = New System.Drawing.Size(118, 21)
        Me.CheckBoxSubcarpetas.TabIndex = 0
        Me.CheckBoxSubcarpetas.Text = "Subcarpetas"
        Me.CheckBoxSubcarpetas.UseVisualStyleBackColor = True
        '
        'FrmListArch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(419, 498)
        Me.Controls.Add(Me.TlpMensaje)
        Me.Controls.Add(Me.TlpPrincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmListArch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TlpMensaje.ResumeLayout(False)
        Me.TlpPrincipal.ResumeLayout(False)
        Me.TlpPrincipal.PerformLayout()
        Me.GbFiltro.ResumeLayout(False)
        Me.GbFiltro.PerformLayout()
        CType(Me.PbBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TlpMensaje As TableLayoutPanel
    Friend WithEvents LbTitulo As Label
    Friend WithEvents TlpPrincipal As TableLayoutPanel
    Friend WithEvents BtCarpeta As Button
    Friend WithEvents TbCarpeta As TextBox
    Friend WithEvents CheckBoxSubcarpetas As CheckBox
    Friend WithEvents PbBarra As PictureBox
    Friend WithEvents GbFiltro As GroupBox
    Friend WithEvents TbExtensiones As TextBox
    Friend WithEvents RbExtdeterminada As RadioButton
    Friend WithEvents RbExtGeneral As RadioButton
    Friend WithEvents BtExtensiones As Button
End Class
