<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPresupuestoCaja
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtgPresupuestoCaja = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtPagoSueldos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPagoProv = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIngresosPorVentas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOtrosPagos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFNM = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Mes = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Ingresos_por_Ventas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagos_Proveedores = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pago_de_Sueldos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Otros_Pagos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Flujo_Mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgPresupuestoCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgPresupuestoCaja
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgPresupuestoCaja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgPresupuestoCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPresupuestoCaja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Mes, Me.Ingresos_por_Ventas, Me.Pagos_Proveedores, Me.Pago_de_Sueldos, Me.Otros_Pagos, Me.Flujo_Mes})
        Me.dtgPresupuestoCaja.Location = New System.Drawing.Point(18, 114)
        Me.dtgPresupuestoCaja.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtgPresupuestoCaja.Name = "dtgPresupuestoCaja"
        Me.dtgPresupuestoCaja.RowHeadersWidth = 62
        Me.dtgPresupuestoCaja.Size = New System.Drawing.Size(1342, 423)
        Me.dtgPresupuestoCaja.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(558, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 41)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Presupuesto Caja"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Enabled = False
        Me.btnEliminarProducto.Location = New System.Drawing.Point(760, 572)
        Me.btnEliminarProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(266, 74)
        Me.btnEliminarProducto.TabIndex = 9
        Me.btnEliminarProducto.Text = "Eliminar"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(384, 572)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(266, 74)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtPagoSueldos
        '
        Me.txtPagoSueldos.Location = New System.Drawing.Point(1622, 380)
        Me.txtPagoSueldos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPagoSueldos.Name = "txtPagoSueldos"
        Me.txtPagoSueldos.ReadOnly = True
        Me.txtPagoSueldos.Size = New System.Drawing.Size(133, 26)
        Me.txtPagoSueldos.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1472, 391)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Pago de Sueldos"
        '
        'txtPagoProv
        '
        Me.txtPagoProv.Location = New System.Drawing.Point(1622, 326)
        Me.txtPagoProv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPagoProv.Name = "txtPagoProv"
        Me.txtPagoProv.ReadOnly = True
        Me.txtPagoProv.Size = New System.Drawing.Size(133, 26)
        Me.txtPagoProv.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1458, 337)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Pago a Proveedores"
        '
        'txtIngresosPorVentas
        '
        Me.txtIngresosPorVentas.Location = New System.Drawing.Point(1622, 263)
        Me.txtIngresosPorVentas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIngresosPorVentas.Name = "txtIngresosPorVentas"
        Me.txtIngresosPorVentas.ReadOnly = True
        Me.txtIngresosPorVentas.Size = New System.Drawing.Size(133, 26)
        Me.txtIngresosPorVentas.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1458, 274)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Ingresos por Ventas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1508, 146)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 59)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Totales"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1506, 446)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Otros Pagos"
        '
        'txtOtrosPagos
        '
        Me.txtOtrosPagos.Location = New System.Drawing.Point(1622, 435)
        Me.txtOtrosPagos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOtrosPagos.Name = "txtOtrosPagos"
        Me.txtOtrosPagos.ReadOnly = True
        Me.txtOtrosPagos.Size = New System.Drawing.Size(133, 26)
        Me.txtOtrosPagos.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(884, 337)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 20)
        Me.Label7.TabIndex = 27
        '
        'txtFNM
        '
        Me.txtFNM.Location = New System.Drawing.Point(1622, 492)
        Me.txtFNM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFNM.Name = "txtFNM"
        Me.txtFNM.ReadOnly = True
        Me.txtFNM.Size = New System.Drawing.Size(133, 26)
        Me.txtFNM.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1461, 503)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 20)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Flujo Neto del Mes"
        '
        'Mes
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mes.DefaultCellStyle = DataGridViewCellStyle2
        Me.Mes.HeaderText = "Mes"
        Me.Mes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.Mes.MinimumWidth = 8
        Me.Mes.Name = "Mes"
        Me.Mes.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Mes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Mes.Width = 150
        '
        'Ingresos_por_Ventas
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Format = "C2"
        Me.Ingresos_por_Ventas.DefaultCellStyle = DataGridViewCellStyle3
        Me.Ingresos_por_Ventas.HeaderText = "Ingresos Por Ventas"
        Me.Ingresos_por_Ventas.MinimumWidth = 8
        Me.Ingresos_por_Ventas.Name = "Ingresos_por_Ventas"
        Me.Ingresos_por_Ventas.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Ingresos_por_Ventas.Width = 150
        '
        'Pagos_Proveedores
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "C2"
        Me.Pagos_Proveedores.DefaultCellStyle = DataGridViewCellStyle4
        Me.Pagos_Proveedores.HeaderText = "Pagos a Proveedores"
        Me.Pagos_Proveedores.MinimumWidth = 8
        Me.Pagos_Proveedores.Name = "Pagos_Proveedores"
        Me.Pagos_Proveedores.Width = 150
        '
        'Pago_de_Sueldos
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "C2"
        Me.Pago_de_Sueldos.DefaultCellStyle = DataGridViewCellStyle5
        Me.Pago_de_Sueldos.HeaderText = "Pagos de Sueldos"
        Me.Pago_de_Sueldos.MinimumWidth = 8
        Me.Pago_de_Sueldos.Name = "Pago_de_Sueldos"
        Me.Pago_de_Sueldos.Width = 150
        '
        'Otros_Pagos
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "C2"
        Me.Otros_Pagos.DefaultCellStyle = DataGridViewCellStyle6
        Me.Otros_Pagos.HeaderText = "Otros Pagos"
        Me.Otros_Pagos.MinimumWidth = 8
        Me.Otros_Pagos.Name = "Otros_Pagos"
        Me.Otros_Pagos.Width = 150
        '
        'Flujo_Mes
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.Format = "C2"
        Me.Flujo_Mes.DefaultCellStyle = DataGridViewCellStyle7
        Me.Flujo_Mes.HeaderText = "Flujo Neto Del Mes"
        Me.Flujo_Mes.MinimumWidth = 8
        Me.Flujo_Mes.Name = "Flujo_Mes"
        Me.Flujo_Mes.Width = 150
        '
        'FormPresupuestoCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1864, 692)
        Me.Controls.Add(Me.txtFNM)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtOtrosPagos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPagoSueldos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPagoProv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtIngresosPorVentas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEliminarProducto)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtgPresupuestoCaja)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormPresupuestoCaja"
        Me.Text = "FormPresupuestoCaja"
        CType(Me.dtgPresupuestoCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgPresupuestoCaja As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtPagoSueldos As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPagoProv As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIngresosPorVentas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtOtrosPagos As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFNM As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Mes As DataGridViewComboBoxColumn
    Friend WithEvents Ingresos_por_Ventas As DataGridViewTextBoxColumn
    Friend WithEvents Pagos_Proveedores As DataGridViewTextBoxColumn
    Friend WithEvents Pago_de_Sueldos As DataGridViewTextBoxColumn
    Friend WithEvents Otros_Pagos As DataGridViewTextBoxColumn
    Friend WithEvents Flujo_Mes As DataGridViewTextBoxColumn
End Class
