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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtgPresupuestoCaja = New System.Windows.Forms.DataGridView()
        Me.Mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ingresos_por_Ventas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagos_Proveedores = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pago_de_Sueldos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Otros_Pagos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Flujo_Mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.dtgPresupuestoCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgPresupuestoCaja
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgPresupuestoCaja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dtgPresupuestoCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPresupuestoCaja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Mes, Me.Ingresos_por_Ventas, Me.Pagos_Proveedores, Me.Pago_de_Sueldos, Me.Otros_Pagos, Me.Flujo_Mes})
        Me.dtgPresupuestoCaja.Location = New System.Drawing.Point(12, 74)
        Me.dtgPresupuestoCaja.Name = "dtgPresupuestoCaja"
        Me.dtgPresupuestoCaja.Size = New System.Drawing.Size(895, 275)
        Me.dtgPresupuestoCaja.TabIndex = 5
        '
        'Mes
        '
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mes.DefaultCellStyle = DataGridViewCellStyle9
        Me.Mes.HeaderText = "Mes"
        Me.Mes.Name = "Mes"
        Me.Mes.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Ingresos_por_Ventas
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = "0"
        Me.Ingresos_por_Ventas.DefaultCellStyle = DataGridViewCellStyle10
        Me.Ingresos_por_Ventas.HeaderText = "Ingresos Por Ventas"
        Me.Ingresos_por_Ventas.Name = "Ingresos_por_Ventas"
        Me.Ingresos_por_Ventas.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Ingresos_por_Ventas.Width = 150
        '
        'Pagos_Proveedores
        '
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.Format = "C2"
        DataGridViewCellStyle11.NullValue = "0"
        Me.Pagos_Proveedores.DefaultCellStyle = DataGridViewCellStyle11
        Me.Pagos_Proveedores.HeaderText = "Pagos a Proveedores"
        Me.Pagos_Proveedores.Name = "Pagos_Proveedores"
        Me.Pagos_Proveedores.Width = 150
        '
        'Pago_de_Sueldos
        '
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = "0"
        Me.Pago_de_Sueldos.DefaultCellStyle = DataGridViewCellStyle12
        Me.Pago_de_Sueldos.HeaderText = "Pagos de Sueldos"
        Me.Pago_de_Sueldos.Name = "Pago_de_Sueldos"
        Me.Pago_de_Sueldos.Width = 150
        '
        'Otros_Pagos
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.Format = "C2"
        DataGridViewCellStyle13.NullValue = "0"
        Me.Otros_Pagos.DefaultCellStyle = DataGridViewCellStyle13
        Me.Otros_Pagos.HeaderText = "Otros Pagos"
        Me.Otros_Pagos.Name = "Otros_Pagos"
        Me.Otros_Pagos.Width = 150
        '
        'Flujo_Mes
        '
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.Format = "C2"
        DataGridViewCellStyle14.NullValue = "0"
        Me.Flujo_Mes.DefaultCellStyle = DataGridViewCellStyle14
        Me.Flujo_Mes.HeaderText = "Flujo Neto Del Mes"
        Me.Flujo_Mes.Name = "Flujo_Mes"
        Me.Flujo_Mes.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(372, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Presupuesto Caja"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Enabled = False
        Me.btnEliminarProducto.Location = New System.Drawing.Point(507, 372)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(177, 48)
        Me.btnEliminarProducto.TabIndex = 9
        Me.btnEliminarProducto.Text = "Eliminar"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(256, 372)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(177, 48)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtPagoSueldos
        '
        Me.txtPagoSueldos.Enabled = False
        Me.txtPagoSueldos.Location = New System.Drawing.Point(1081, 247)
        Me.txtPagoSueldos.Name = "txtPagoSueldos"
        Me.txtPagoSueldos.Size = New System.Drawing.Size(90, 20)
        Me.txtPagoSueldos.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(981, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Pago de Sueldos"
        '
        'txtPagoProv
        '
        Me.txtPagoProv.Enabled = False
        Me.txtPagoProv.Location = New System.Drawing.Point(1081, 212)
        Me.txtPagoProv.Name = "txtPagoProv"
        Me.txtPagoProv.Size = New System.Drawing.Size(90, 20)
        Me.txtPagoProv.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(972, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Pago a Proveedores"
        '
        'txtIngresosPorVentas
        '
        Me.txtIngresosPorVentas.Enabled = False
        Me.txtIngresosPorVentas.Location = New System.Drawing.Point(1081, 171)
        Me.txtIngresosPorVentas.Name = "txtIngresosPorVentas"
        Me.txtIngresosPorVentas.Size = New System.Drawing.Size(90, 20)
        Me.txtIngresosPorVentas.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(972, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Ingresos por Ventas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1005, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 39)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Totales"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1004, 290)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Otros Pagos"
        '
        'txtOtrosPagos
        '
        Me.txtOtrosPagos.Enabled = False
        Me.txtOtrosPagos.Location = New System.Drawing.Point(1081, 283)
        Me.txtOtrosPagos.Name = "txtOtrosPagos"
        Me.txtOtrosPagos.Size = New System.Drawing.Size(90, 20)
        Me.txtOtrosPagos.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(589, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 27
        '
        'txtFNM
        '
        Me.txtFNM.Enabled = False
        Me.txtFNM.Location = New System.Drawing.Point(1081, 320)
        Me.txtFNM.Name = "txtFNM"
        Me.txtFNM.Size = New System.Drawing.Size(90, 20)
        Me.txtFNM.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(974, 327)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Flujo Neto del Mes"
        '
        'FormPresupuestoCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 450)
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
    Friend WithEvents Mes As DataGridViewTextBoxColumn
    Friend WithEvents Ingresos_por_Ventas As DataGridViewTextBoxColumn
    Friend WithEvents Pagos_Proveedores As DataGridViewTextBoxColumn
    Friend WithEvents Pago_de_Sueldos As DataGridViewTextBoxColumn
    Friend WithEvents Otros_Pagos As DataGridViewTextBoxColumn
    Friend WithEvents Flujo_Mes As DataGridViewTextBoxColumn
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
End Class
