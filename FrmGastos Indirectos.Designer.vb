<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGastos_Indirectos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGastos_Indirectos))
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.LblMonto = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtConcepto = New System.Windows.Forms.TextBox()
        Me.LblConcepto = New System.Windows.Forms.Label()
        Me.DtgGastosIndirectos = New System.Windows.Forms.DataGridView()
        Me.ColConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        CType(Me.DtgGastosIndirectos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtMonto
        '
        Me.TxtMonto.Location = New System.Drawing.Point(92, 51)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(122, 22)
        Me.TxtMonto.TabIndex = 15
        '
        'LblMonto
        '
        Me.LblMonto.AutoSize = True
        Me.LblMonto.Location = New System.Drawing.Point(42, 57)
        Me.LblMonto.Name = "LblMonto"
        Me.LblMonto.Size = New System.Drawing.Size(44, 16)
        Me.LblMonto.TabIndex = 14
        Me.LblMonto.Text = "Monto"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(244, 12)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(191, 45)
        Me.BtnAgregar.TabIndex = 13
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TxtConcepto
        '
        Me.TxtConcepto.Location = New System.Drawing.Point(92, 12)
        Me.TxtConcepto.Name = "TxtConcepto"
        Me.TxtConcepto.Size = New System.Drawing.Size(122, 22)
        Me.TxtConcepto.TabIndex = 11
        '
        'LblConcepto
        '
        Me.LblConcepto.AutoSize = True
        Me.LblConcepto.Location = New System.Drawing.Point(21, 18)
        Me.LblConcepto.Name = "LblConcepto"
        Me.LblConcepto.Size = New System.Drawing.Size(65, 16)
        Me.LblConcepto.TabIndex = 10
        Me.LblConcepto.Text = "Concepto"
        '
        'DtgGastosIndirectos
        '
        Me.DtgGastosIndirectos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.DtgGastosIndirectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgGastosIndirectos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColConcepto, Me.ColMonto})
        Me.DtgGastosIndirectos.GridColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.DtgGastosIndirectos.Location = New System.Drawing.Point(488, 12)
        Me.DtgGastosIndirectos.Name = "DtgGastosIndirectos"
        Me.DtgGastosIndirectos.RowHeadersWidth = 51
        Me.DtgGastosIndirectos.RowTemplate.Height = 24
        Me.DtgGastosIndirectos.Size = New System.Drawing.Size(405, 221)
        Me.DtgGastosIndirectos.TabIndex = 16
        '
        'ColConcepto
        '
        Me.ColConcepto.HeaderText = "Concepto"
        Me.ColConcepto.MinimumWidth = 6
        Me.ColConcepto.Name = "ColConcepto"
        Me.ColConcepto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColConcepto.Width = 125
        '
        'ColMonto
        '
        Me.ColMonto.HeaderText = "Monto"
        Me.ColMonto.MinimumWidth = 6
        Me.ColMonto.Name = "ColMonto"
        Me.ColMonto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColMonto.Width = 125
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(244, 72)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(191, 45)
        Me.BtnEliminar.TabIndex = 17
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(92, 95)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(122, 22)
        Me.TxtTotal.TabIndex = 19
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(48, 101)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(38, 16)
        Me.LblTotal.TabIndex = 18
        Me.LblTotal.Text = "Total"
        '
        'FrmGastos_Indirectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(930, 272)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.DtgGastosIndirectos)
        Me.Controls.Add(Me.TxtMonto)
        Me.Controls.Add(Me.LblMonto)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.TxtConcepto)
        Me.Controls.Add(Me.LblConcepto)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmGastos_Indirectos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmGastos_Indirectos"
        CType(Me.DtgGastosIndirectos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtMonto As TextBox
    Friend WithEvents LblMonto As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtConcepto As TextBox
    Friend WithEvents LblConcepto As Label
    Friend WithEvents DtgGastosIndirectos As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents ColConcepto As DataGridViewTextBoxColumn
    Friend WithEvents ColMonto As DataGridViewTextBoxColumn
End Class
