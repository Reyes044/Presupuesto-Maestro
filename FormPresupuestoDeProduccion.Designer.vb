<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPresupuestoDeProduccion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtgPresupuestoProducción = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidades_a_Vender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inventario_Final = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inventario_Inicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo_Unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOD_Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIF_Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidades_a_Producir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo_Total_Producción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo_Total_MOD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo_Total_CIF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo_Total_Planeado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalUndVender = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregarColumn = New System.Windows.Forms.Button()
        CType(Me.dtgPresupuestoProducción, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgPresupuestoProducción
        '
        Me.dtgPresupuestoProducción.AllowUserToResizeColumns = False
        Me.dtgPresupuestoProducción.AllowUserToResizeRows = False
        Me.dtgPresupuestoProducción.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgPresupuestoProducción.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgPresupuestoProducción.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgPresupuestoProducción.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPresupuestoProducción.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Unidades_a_Vender, Me.Inventario_Final, Me.Inventario_Inicial, Me.Costo_Unitario, Me.MOD_Unidad, Me.CIF_Unidad, Me.Unidades_a_Producir, Me.Costo_Total_Producción, Me.Costo_Total_MOD, Me.Costo_Total_CIF, Me.Costo_Total_Planeado})
        Me.dtgPresupuestoProducción.GridColor = System.Drawing.SystemColors.InfoText
        Me.dtgPresupuestoProducción.Location = New System.Drawing.Point(12, 77)
        Me.dtgPresupuestoProducción.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtgPresupuestoProducción.Name = "dtgPresupuestoProducción"
        Me.dtgPresupuestoProducción.RowHeadersWidth = 62
        Me.dtgPresupuestoProducción.Size = New System.Drawing.Size(1262, 368)
        Me.dtgPresupuestoProducción.TabIndex = 1
        '
        'Producto
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.Producto.DefaultCellStyle = DataGridViewCellStyle2
        Me.Producto.HeaderText = "Producto"
        Me.Producto.MinimumWidth = 8
        Me.Producto.Name = "Producto"
        Me.Producto.Width = 150
        '
        'Unidades_a_Vender
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Unidades_a_Vender.DefaultCellStyle = DataGridViewCellStyle3
        Me.Unidades_a_Vender.HeaderText = "Unidades a vender"
        Me.Unidades_a_Vender.MinimumWidth = 8
        Me.Unidades_a_Vender.Name = "Unidades_a_Vender"
        Me.Unidades_a_Vender.Width = 150
        '
        'Inventario_Final
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.Inventario_Final.DefaultCellStyle = DataGridViewCellStyle4
        Me.Inventario_Final.HeaderText = "Inventario Final"
        Me.Inventario_Final.MinimumWidth = 8
        Me.Inventario_Final.Name = "Inventario_Final"
        Me.Inventario_Final.Width = 150
        '
        'Inventario_Inicial
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.Inventario_Inicial.DefaultCellStyle = DataGridViewCellStyle5
        Me.Inventario_Inicial.HeaderText = "Inventario Inicial"
        Me.Inventario_Inicial.MinimumWidth = 8
        Me.Inventario_Inicial.Name = "Inventario_Inicial"
        Me.Inventario_Inicial.Width = 150
        '
        'Costo_Unitario
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.Costo_Unitario.DefaultCellStyle = DataGridViewCellStyle6
        Me.Costo_Unitario.HeaderText = "Costo Unitario"
        Me.Costo_Unitario.MinimumWidth = 8
        Me.Costo_Unitario.Name = "Costo_Unitario"
        Me.Costo_Unitario.Width = 150
        '
        'MOD_Unidad
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.MOD_Unidad.DefaultCellStyle = DataGridViewCellStyle7
        Me.MOD_Unidad.HeaderText = "MOD por Unidad"
        Me.MOD_Unidad.MinimumWidth = 8
        Me.MOD_Unidad.Name = "MOD_Unidad"
        Me.MOD_Unidad.Width = 150
        '
        'CIF_Unidad
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.CIF_Unidad.DefaultCellStyle = DataGridViewCellStyle8
        Me.CIF_Unidad.HeaderText = "CIF por Unidad"
        Me.CIF_Unidad.MinimumWidth = 8
        Me.CIF_Unidad.Name = "CIF_Unidad"
        Me.CIF_Unidad.Width = 150
        '
        'Unidades_a_Producir
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0"
        Me.Unidades_a_Producir.DefaultCellStyle = DataGridViewCellStyle9
        Me.Unidades_a_Producir.HeaderText = "Unidades a Producir"
        Me.Unidades_a_Producir.MinimumWidth = 8
        Me.Unidades_a_Producir.Name = "Unidades_a_Producir"
        Me.Unidades_a_Producir.Width = 150
        '
        'Costo_Total_Producción
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = "0"
        Me.Costo_Total_Producción.DefaultCellStyle = DataGridViewCellStyle10
        Me.Costo_Total_Producción.HeaderText = "Costo Total Producción"
        Me.Costo_Total_Producción.MinimumWidth = 8
        Me.Costo_Total_Producción.Name = "Costo_Total_Producción"
        Me.Costo_Total_Producción.Width = 150
        '
        'Costo_Total_MOD
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.Format = "C2"
        DataGridViewCellStyle11.NullValue = "0"
        Me.Costo_Total_MOD.DefaultCellStyle = DataGridViewCellStyle11
        Me.Costo_Total_MOD.HeaderText = "Costo Total MOD"
        Me.Costo_Total_MOD.MinimumWidth = 8
        Me.Costo_Total_MOD.Name = "Costo_Total_MOD"
        Me.Costo_Total_MOD.Width = 150
        '
        'Costo_Total_CIF
        '
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = "0"
        Me.Costo_Total_CIF.DefaultCellStyle = DataGridViewCellStyle12
        Me.Costo_Total_CIF.HeaderText = "Costo Total CIF"
        Me.Costo_Total_CIF.MinimumWidth = 8
        Me.Costo_Total_CIF.Name = "Costo_Total_CIF"
        Me.Costo_Total_CIF.Width = 150
        '
        'Costo_Total_Planeado
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.Format = "C2"
        DataGridViewCellStyle13.NullValue = "0"
        Me.Costo_Total_Planeado.DefaultCellStyle = DataGridViewCellStyle13
        Me.Costo_Total_Planeado.HeaderText = "Costo Total Planeado"
        Me.Costo_Total_Planeado.MinimumWidth = 8
        Me.Costo_Total_Planeado.Name = "Costo_Total_Planeado"
        Me.Costo_Total_Planeado.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(398, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Presupuesto de Producción"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTotalUndVender
        '
        Me.txtTotalUndVender.Enabled = False
        Me.txtTotalUndVender.Location = New System.Drawing.Point(192, 598)
        Me.txtTotalUndVender.Name = "txtTotalUndVender"
        Me.txtTotalUndVender.Size = New System.Drawing.Size(159, 20)
        Me.txtTotalUndVender.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 598)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Unidades a Vender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 530)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 27)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Totales"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(705, 453)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(222, 37)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar Producto"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregarColumn
        '
        Me.btnAgregarColumn.Location = New System.Drawing.Point(312, 453)
        Me.btnAgregarColumn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAgregarColumn.Name = "btnAgregarColumn"
        Me.btnAgregarColumn.Size = New System.Drawing.Size(222, 37)
        Me.btnAgregarColumn.TabIndex = 7
        Me.btnAgregarColumn.Text = "Agregar Producto"
        Me.btnAgregarColumn.UseVisualStyleBackColor = True
        '
        'FormPresupuestoDeProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 630)
        Me.Controls.Add(Me.txtTotalUndVender)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregarColumn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtgPresupuestoProducción)
        Me.Name = "FormPresupuestoDeProduccion"
        Me.Text = "FormPresupuestoDeProduccion"
        CType(Me.dtgPresupuestoProducción, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgPresupuestoProducción As DataGridView
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Unidades_a_Vender As DataGridViewTextBoxColumn
    Friend WithEvents Inventario_Final As DataGridViewTextBoxColumn
    Friend WithEvents Inventario_Inicial As DataGridViewTextBoxColumn
    Friend WithEvents Costo_Unitario As DataGridViewTextBoxColumn
    Friend WithEvents MOD_Unidad As DataGridViewTextBoxColumn
    Friend WithEvents CIF_Unidad As DataGridViewTextBoxColumn
    Friend WithEvents Unidades_a_Producir As DataGridViewTextBoxColumn
    Friend WithEvents Costo_Total_Producción As DataGridViewTextBoxColumn
    Friend WithEvents Costo_Total_MOD As DataGridViewTextBoxColumn
    Friend WithEvents Costo_Total_CIF As DataGridViewTextBoxColumn
    Friend WithEvents Costo_Total_Planeado As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalUndVender As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregarColumn As Button
End Class
