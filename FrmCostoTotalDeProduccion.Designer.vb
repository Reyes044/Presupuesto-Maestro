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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAgregarCtp = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TxtTotalGIF = New System.Windows.Forms.TextBox()
        Me.LblTotalGIF = New System.Windows.Forms.Label()
        Me.TxtTotalMPD = New System.Windows.Forms.TextBox()
        Me.LbltotalMPD = New System.Windows.Forms.Label()
        Me.TxtTotalMOD = New System.Windows.Forms.TextBox()
        Me.LblTotalMOD = New System.Windows.Forms.Label()
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
        Me.ColProducto.ReadOnly = True
        Me.ColProducto.Width = 125
        '
        'ColMPD
        '
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = "C$"
        Me.ColMPD.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColMPD.HeaderText = "MPD (C$)"
        Me.ColMPD.MinimumWidth = 6
        Me.ColMPD.Name = "ColMPD"
        Me.ColMPD.ReadOnly = True
        Me.ColMPD.Width = 125
        '
        'ColMOD
        '
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = "C$"
        Me.ColMOD.DefaultCellStyle = DataGridViewCellStyle7
        Me.ColMOD.HeaderText = "MOD(C$)"
        Me.ColMOD.MinimumWidth = 6
        Me.ColMOD.Name = "ColMOD"
        Me.ColMOD.ReadOnly = True
        Me.ColMOD.Width = 125
        '
        'Col_GIF_Asignado
        '
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = "C$"
        Me.Col_GIF_Asignado.DefaultCellStyle = DataGridViewCellStyle8
        Me.Col_GIF_Asignado.HeaderText = "GIF Asignado (C$)"
        Me.Col_GIF_Asignado.MinimumWidth = 6
        Me.Col_GIF_Asignado.Name = "Col_GIF_Asignado"
        Me.Col_GIF_Asignado.ReadOnly = True
        Me.Col_GIF_Asignado.Width = 125
        '
        'ColCostoTotalDeProduccion
        '
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = "C$"
        Me.ColCostoTotalDeProduccion.DefaultCellStyle = DataGridViewCellStyle9
        Me.ColCostoTotalDeProduccion.HeaderText = "Costo Total De Produccion (C$)"
        Me.ColCostoTotalDeProduccion.MinimumWidth = 6
        Me.ColCostoTotalDeProduccion.Name = "ColCostoTotalDeProduccion"
        Me.ColCostoTotalDeProduccion.ReadOnly = True
        Me.ColCostoTotalDeProduccion.Width = 125
        '
        'ColCostoUnitario
        '
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = "C$"
        Me.ColCostoUnitario.DefaultCellStyle = DataGridViewCellStyle10
        Me.ColCostoUnitario.HeaderText = "Costo Unitario"
        Me.ColCostoUnitario.MinimumWidth = 6
        Me.ColCostoUnitario.Name = "ColCostoUnitario"
        Me.ColCostoUnitario.ReadOnly = True
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mano de Obra Directa"
        '
        'BtnAgregarCtp
        '
        Me.BtnAgregarCtp.Location = New System.Drawing.Point(12, 249)
        Me.BtnAgregarCtp.Name = "BtnAgregarCtp"
        Me.BtnAgregarCtp.Size = New System.Drawing.Size(252, 62)
        Me.BtnAgregarCtp.TabIndex = 7
        Me.BtnAgregarCtp.Text = "Agregar"
        Me.BtnAgregarCtp.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "GIF Asignado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(281, 249)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(252, 62)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'TxtTotalGIF
        '
        Me.TxtTotalGIF.Location = New System.Drawing.Point(864, 269)
        Me.TxtTotalGIF.Name = "TxtTotalGIF"
        Me.TxtTotalGIF.Size = New System.Drawing.Size(107, 22)
        Me.TxtTotalGIF.TabIndex = 12
        '
        'LblTotalGIF
        '
        Me.LblTotalGIF.AutoSize = True
        Me.LblTotalGIF.Location = New System.Drawing.Point(601, 272)
        Me.LblTotalGIF.Name = "LblTotalGIF"
        Me.LblTotalGIF.Size = New System.Drawing.Size(257, 16)
        Me.LblTotalGIF.TabIndex = 11
        Me.LblTotalGIF.Text = "Total de Gastos Indirectos de Fabricacion"
        '
        'TxtTotalMPD
        '
        Me.TxtTotalMPD.Location = New System.Drawing.Point(864, 175)
        Me.TxtTotalMPD.Name = "TxtTotalMPD"
        Me.TxtTotalMPD.Size = New System.Drawing.Size(107, 22)
        Me.TxtTotalMPD.TabIndex = 14
        '
        'LbltotalMPD
        '
        Me.LbltotalMPD.AutoSize = True
        Me.LbltotalMPD.Location = New System.Drawing.Point(601, 181)
        Me.LbltotalMPD.Name = "LbltotalMPD"
        Me.LbltotalMPD.Size = New System.Drawing.Size(189, 16)
        Me.LbltotalMPD.TabIndex = 13
        Me.LbltotalMPD.Text = "Total de Materia Prima Directa"
        '
        'TxtTotalMOD
        '
        Me.TxtTotalMOD.Location = New System.Drawing.Point(864, 221)
        Me.TxtTotalMOD.Name = "TxtTotalMOD"
        Me.TxtTotalMOD.Size = New System.Drawing.Size(107, 22)
        Me.TxtTotalMOD.TabIndex = 16
        '
        'LblTotalMOD
        '
        Me.LblTotalMOD.AutoSize = True
        Me.LblTotalMOD.Location = New System.Drawing.Point(601, 221)
        Me.LblTotalMOD.Name = "LblTotalMOD"
        Me.LblTotalMOD.Size = New System.Drawing.Size(192, 16)
        Me.LblTotalMOD.TabIndex = 15
        Me.LblTotalMOD.Text = "Total de Mano de Obra Directa"
        '
        'FrmCostoTotalDeProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 341)
        Me.Controls.Add(Me.TxtTotalMOD)
        Me.Controls.Add(Me.LblTotalMOD)
        Me.Controls.Add(Me.TxtTotalMPD)
        Me.Controls.Add(Me.LbltotalMPD)
        Me.Controls.Add(Me.TxtTotalGIF)
        Me.Controls.Add(Me.LblTotalGIF)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.TxtGifAsignado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblGIFAsignados)
        Me.Controls.Add(Me.BtnAgregarCtp)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.DtgCostoTotalDeProduccion)
        Me.Controls.Add(Me.TxtMOD)
        Me.Controls.Add(Me.TxtMPD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtProducto)
        Me.Controls.Add(Me.LblMOD)
        Me.Controls.Add(Me.LblMPD)
        Me.Controls.Add(Me.LblProducto)
        Me.MaximizeBox = False
        Me.Name = "FrmCostoTotalDeProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents LblGIFAsignados As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAgregarCtp As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtGifAsignado As TextBox
    Friend WithEvents ColProducto As DataGridViewTextBoxColumn
    Friend WithEvents ColMPD As DataGridViewTextBoxColumn
    Friend WithEvents ColMOD As DataGridViewTextBoxColumn
    Friend WithEvents Col_GIF_Asignado As DataGridViewTextBoxColumn
    Friend WithEvents ColCostoTotalDeProduccion As DataGridViewTextBoxColumn
    Friend WithEvents ColCostoUnitario As DataGridViewTextBoxColumn
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TxtTotalGIF As TextBox
    Friend WithEvents LblTotalGIF As Label
    Friend WithEvents TxtTotalMPD As TextBox
    Friend WithEvents LbltotalMPD As Label
    Friend WithEvents TxtTotalMOD As TextBox
    Friend WithEvents LblTotalMOD As Label
End Class
