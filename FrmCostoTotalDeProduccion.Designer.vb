<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCostoTotalDeProduccion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblProducto = New System.Windows.Forms.Label()
        Me.LblMPD = New System.Windows.Forms.Label()
        Me.LblMOD = New System.Windows.Forms.Label()
        Me.TxtProducto = New System.Windows.Forms.TextBox()
        Me.TxtMPD = New System.Windows.Forms.TextBox()
        Me.TxtMOD = New System.Windows.Forms.TextBox()
        Me.DtgCostoTotalDeProduccion = New System.Windows.Forms.DataGridView()
        Me.ColProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMPD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMOD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_GIF_Asignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCostoTotalDeProduccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCostoUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtGifAsignado = New System.Windows.Forms.TextBox()
        Me.LblGIFAsignados = New System.Windows.Forms.Label()
        CType(Me.DtgCostoTotalDeProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblProducto
        '
        Me.LblProducto.AutoSize = True
        Me.LblProducto.Location = New System.Drawing.Point(12, 48)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(61, 16)
        Me.LblProducto.TabIndex = 0
        Me.LblProducto.Text = "Producto"
        '
        'LblMPD
        '
        Me.LblMPD.AutoSize = True
        Me.LblMPD.Location = New System.Drawing.Point(12, 91)
        Me.LblMPD.Name = "LblMPD"
        Me.LblMPD.Size = New System.Drawing.Size(139, 16)
        Me.LblMPD.TabIndex = 1
        Me.LblMPD.Text = "Materia Prima Directa "
        '
        'LblMOD
        '
        Me.LblMOD.AutoSize = True
        Me.LblMOD.Location = New System.Drawing.Point(12, 143)
        Me.LblMOD.Name = "LblMOD"
        Me.LblMOD.Size = New System.Drawing.Size(139, 16)
        Me.LblMOD.TabIndex = 2
        Me.LblMOD.Text = "Mano de Obra Directa"
        '
        'TxtProducto
        '
        Me.TxtProducto.Location = New System.Drawing.Point(157, 45)
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.Size = New System.Drawing.Size(107, 22)
        Me.TxtProducto.TabIndex = 3
        '
        'TxtMPD
        '
        Me.TxtMPD.Location = New System.Drawing.Point(157, 91)
        Me.TxtMPD.Name = "TxtMPD"
        Me.TxtMPD.Size = New System.Drawing.Size(107, 22)
        Me.TxtMPD.TabIndex = 4
        '
        'TxtMOD
        '
        Me.TxtMOD.Location = New System.Drawing.Point(157, 143)
        Me.TxtMOD.Name = "TxtMOD"
        Me.TxtMOD.Size = New System.Drawing.Size(107, 22)
        Me.TxtMOD.TabIndex = 5
        '
        'DtgCostoTotalDeProduccion
        '
        Me.DtgCostoTotalDeProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgCostoTotalDeProduccion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColProducto, Me.ColMPD, Me.ColMOD, Me.Col_GIF_Asignado, Me.ColCostoTotalDeProduccion, Me.ColCostoUnitario})
        Me.DtgCostoTotalDeProduccion.Location = New System.Drawing.Point(333, 39)
        Me.DtgCostoTotalDeProduccion.Name = "DtgCostoTotalDeProduccion"
        Me.DtgCostoTotalDeProduccion.RowHeadersWidth = 51
        Me.DtgCostoTotalDeProduccion.RowTemplate.Height = 24
        Me.DtgCostoTotalDeProduccion.Size = New System.Drawing.Size(805, 120)
        Me.DtgCostoTotalDeProduccion.TabIndex = 6
        '
        'ColProducto
        '
        Me.ColProducto.HeaderText = "Producto"
        Me.ColProducto.MinimumWidth = 6
        Me.ColProducto.Name = "ColProducto"
        Me.ColProducto.Width = 125
        '
        'ColMPD
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "C$"
        Me.ColMPD.DefaultCellStyle = DataGridViewCellStyle1
        Me.ColMPD.HeaderText = "MPD (C$)"
        Me.ColMPD.MinimumWidth = 6
        Me.ColMPD.Name = "ColMPD"
        Me.ColMPD.Width = 125
        '
        'ColMOD
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "C$"
        Me.ColMOD.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColMOD.HeaderText = "MOD(C$)"
        Me.ColMOD.MinimumWidth = 6
        Me.ColMOD.Name = "ColMOD"
        Me.ColMOD.Width = 125
        '
        'Col_GIF_Asignado
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "C$"
        Me.Col_GIF_Asignado.DefaultCellStyle = DataGridViewCellStyle3
        Me.Col_GIF_Asignado.HeaderText = "GIF Asignado (C$)"
        Me.Col_GIF_Asignado.MinimumWidth = 6
        Me.Col_GIF_Asignado.Name = "Col_GIF_Asignado"
        Me.Col_GIF_Asignado.Width = 125
        '
        'ColCostoTotalDeProduccion
        '
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "C$"
        Me.ColCostoTotalDeProduccion.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColCostoTotalDeProduccion.HeaderText = "Costo Total De Produccion (C$)"
        Me.ColCostoTotalDeProduccion.MinimumWidth = 6
        Me.ColCostoTotalDeProduccion.Name = "ColCostoTotalDeProduccion"
        Me.ColCostoTotalDeProduccion.Width = 125
        '
        'ColCostoUnitario
        '
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = "C$"
        Me.ColCostoUnitario.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColCostoUnitario.HeaderText = "Costo Unitario"
        Me.ColCostoUnitario.MinimumWidth = 6
        Me.ColCostoUnitario.Name = "ColCostoUnitario"
        Me.ColCostoUnitario.Width = 125
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(157, 249)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(107, 45)
        Me.BtnAgregar.TabIndex = 7
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TxtGifAsignado
        '
        Me.TxtGifAsignado.Location = New System.Drawing.Point(157, 196)
        Me.TxtGifAsignado.Name = "TxtGifAsignado"
        Me.TxtGifAsignado.Size = New System.Drawing.Size(107, 22)
        Me.TxtGifAsignado.TabIndex = 9
        '
        'LblGIFAsignados
        '
        Me.LblGIFAsignados.AutoSize = True
        Me.LblGIFAsignados.Location = New System.Drawing.Point(12, 196)
        Me.LblGIFAsignados.Name = "LblGIFAsignados"
        Me.LblGIFAsignados.Size = New System.Drawing.Size(92, 16)
        Me.LblGIFAsignados.TabIndex = 8
        Me.LblGIFAsignados.Text = "GIF Asignado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FrmCostoTotalDeProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 341)
        Me.Controls.Add(Me.TxtGifAsignado)
        Me.Controls.Add(Me.LblGIFAsignados)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.DtgCostoTotalDeProduccion)
        Me.Controls.Add(Me.TxtMOD)
        Me.Controls.Add(Me.TxtMPD)
        Me.Controls.Add(Me.TxtProducto)
        Me.Controls.Add(Me.LblMOD)
        Me.Controls.Add(Me.LblMPD)
        Me.Controls.Add(Me.LblProducto)
        Me.Name = "FrmCostoTotalDeProduccion"
        Me.Text = "FrmCostoTotalDeProduccion"
        CType(Me.DtgCostoTotalDeProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblProducto As Label
    Friend WithEvents LblMPD As Label
    Friend WithEvents LblMOD As Label
    Friend WithEvents TxtProducto As TextBox
    Friend WithEvents TxtMPD As TextBox
    Friend WithEvents TxtMOD As TextBox
    Friend WithEvents DtgCostoTotalDeProduccion As DataGridView
    Friend WithEvents ColProducto As DataGridViewTextBoxColumn
    Friend WithEvents ColMPD As DataGridViewTextBoxColumn
    Friend WithEvents ColMOD As DataGridViewTextBoxColumn
    Friend WithEvents Col_GIF_Asignado As DataGridViewTextBoxColumn
    Friend WithEvents ColCostoTotalDeProduccion As DataGridViewTextBoxColumn
    Friend WithEvents ColCostoUnitario As DataGridViewTextBoxColumn
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtGifAsignado As TextBox
    Friend WithEvents LblGIFAsignados As Label
End Class
