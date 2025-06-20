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
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.LblMonto = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtConcepto = New System.Windows.Forms.TextBox()
        Me.LblConcepto = New System.Windows.Forms.Label()
        Me.DtgGastosIndirectos = New System.Windows.Forms.DataGridView()
        Me.ColConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        CType(Me.DtgGastosIndirectos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtMonto
        '
        Me.TxtMonto.Location = New System.Drawing.Point(87, 95)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(122, 22)
        Me.TxtMonto.TabIndex = 15
        '
        'LblMonto
        '
        Me.LblMonto.AutoSize = True
        Me.LblMonto.Location = New System.Drawing.Point(15, 98)
        Me.LblMonto.Name = "LblMonto"
        Me.LblMonto.Size = New System.Drawing.Size(44, 16)
        Me.LblMonto.TabIndex = 14
        Me.LblMonto.Text = "Monto"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(18, 161)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(191, 45)
        Me.BtnAgregar.TabIndex = 13
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TxtConcepto
        '
        Me.TxtConcepto.Location = New System.Drawing.Point(87, 36)
        Me.TxtConcepto.Name = "TxtConcepto"
        Me.TxtConcepto.Size = New System.Drawing.Size(122, 22)
        Me.TxtConcepto.TabIndex = 11
        '
        'LblConcepto
        '
        Me.LblConcepto.AutoSize = True
        Me.LblConcepto.Location = New System.Drawing.Point(15, 36)
        Me.LblConcepto.Name = "LblConcepto"
        Me.LblConcepto.Size = New System.Drawing.Size(65, 16)
        Me.LblConcepto.TabIndex = 10
        Me.LblConcepto.Text = "Concepto"
        '
        'DtgGastosIndirectos
        '
        Me.DtgGastosIndirectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgGastosIndirectos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColConcepto, Me.ColMonto})
        Me.DtgGastosIndirectos.Location = New System.Drawing.Point(238, 36)
        Me.DtgGastosIndirectos.Name = "DtgGastosIndirectos"
        Me.DtgGastosIndirectos.RowHeadersWidth = 51
        Me.DtgGastosIndirectos.RowTemplate.Height = 24
        Me.DtgGastosIndirectos.Size = New System.Drawing.Size(361, 221)
        Me.DtgGastosIndirectos.TabIndex = 16
        '
        'ColConcepto
        '
        Me.ColConcepto.HeaderText = "Concepto"
        Me.ColConcepto.MinimumWidth = 6
        Me.ColConcepto.Name = "ColConcepto"
        Me.ColConcepto.Width = 125
        '
        'ColMonto
        '
        Me.ColMonto.HeaderText = "Monto"
        Me.ColMonto.MinimumWidth = 6
        Me.ColMonto.Name = "ColMonto"
        Me.ColMonto.Width = 125
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(18, 212)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(191, 45)
        Me.BtnEliminar.TabIndex = 17
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'FrmGastos_Indirectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 323)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.DtgGastosIndirectos)
        Me.Controls.Add(Me.TxtMonto)
        Me.Controls.Add(Me.LblMonto)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.TxtConcepto)
        Me.Controls.Add(Me.LblConcepto)
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
    Friend WithEvents ColConcepto As DataGridViewTextBoxColumn
    Friend WithEvents ColMonto As DataGridViewTextBoxColumn
    Friend WithEvents BtnEliminar As Button
End Class
