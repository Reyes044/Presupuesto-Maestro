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
        Dim DataGridViewCellStyle57 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle58 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle59 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle60 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle61 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle62 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle63 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPresupuestoCaja))
        Me.dtgPresupuestoCaja = New System.Windows.Forms.DataGridView()
        Me.Mes = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Ingresos_por_Ventas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagos_Proveedores = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pago_de_Sueldos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Otros_Pagos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Flujo_Mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        CType(Me.dtgPresupuestoCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgPresupuestoCaja
        '
        Me.dtgPresupuestoCaja.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle57.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle57.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle57.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle57.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle57.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgPresupuestoCaja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle57
        Me.dtgPresupuestoCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPresupuestoCaja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Mes, Me.Ingresos_por_Ventas, Me.Pagos_Proveedores, Me.Pago_de_Sueldos, Me.Otros_Pagos, Me.Flujo_Mes})
        Me.dtgPresupuestoCaja.GridColor = System.Drawing.Color.Black
        Me.dtgPresupuestoCaja.Location = New System.Drawing.Point(18, 114)
        Me.dtgPresupuestoCaja.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtgPresupuestoCaja.Name = "dtgPresupuestoCaja"
        Me.dtgPresupuestoCaja.RowHeadersWidth = 62
        Me.dtgPresupuestoCaja.Size = New System.Drawing.Size(1342, 363)
        Me.dtgPresupuestoCaja.TabIndex = 5
        '
        'Mes
        '
        DataGridViewCellStyle58.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mes.DefaultCellStyle = DataGridViewCellStyle58
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
        DataGridViewCellStyle59.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle59.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle59.Format = "C2"
        Me.Ingresos_por_Ventas.DefaultCellStyle = DataGridViewCellStyle59
        Me.Ingresos_por_Ventas.HeaderText = "Ingresos Por Ventas"
        Me.Ingresos_por_Ventas.MinimumWidth = 8
        Me.Ingresos_por_Ventas.Name = "Ingresos_por_Ventas"
        Me.Ingresos_por_Ventas.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Ingresos_por_Ventas.Width = 150
        '
        'Pagos_Proveedores
        '
        DataGridViewCellStyle60.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle60.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle60.Format = "C2"
        Me.Pagos_Proveedores.DefaultCellStyle = DataGridViewCellStyle60
        Me.Pagos_Proveedores.HeaderText = "Pagos a Proveedores"
        Me.Pagos_Proveedores.MinimumWidth = 8
        Me.Pagos_Proveedores.Name = "Pagos_Proveedores"
        Me.Pagos_Proveedores.Width = 150
        '
        'Pago_de_Sueldos
        '
        DataGridViewCellStyle61.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle61.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle61.Format = "C2"
        Me.Pago_de_Sueldos.DefaultCellStyle = DataGridViewCellStyle61
        Me.Pago_de_Sueldos.HeaderText = "Pagos de Sueldos"
        Me.Pago_de_Sueldos.MinimumWidth = 8
        Me.Pago_de_Sueldos.Name = "Pago_de_Sueldos"
        Me.Pago_de_Sueldos.Width = 150
        '
        'Otros_Pagos
        '
        DataGridViewCellStyle62.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle62.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle62.Format = "C2"
        Me.Otros_Pagos.DefaultCellStyle = DataGridViewCellStyle62
        Me.Otros_Pagos.HeaderText = "Otros Pagos"
        Me.Otros_Pagos.MinimumWidth = 8
        Me.Otros_Pagos.Name = "Otros_Pagos"
        Me.Otros_Pagos.Width = 150
        '
        'Flujo_Mes
        '
        DataGridViewCellStyle63.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle63.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle63.Format = "C2"
        Me.Flujo_Mes.DefaultCellStyle = DataGridViewCellStyle63
        Me.Flujo_Mes.HeaderText = "Flujo Neto Del Mes"
        Me.Flujo_Mes.MinimumWidth = 8
        Me.Flujo_Mes.Name = "Flujo_Mes"
        Me.Flujo_Mes.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(558, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 44)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Presupuesto Caja"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPagoSueldos
        '
        Me.txtPagoSueldos.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtPagoSueldos.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagoSueldos.Location = New System.Drawing.Point(1631, 325)
        Me.txtPagoSueldos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPagoSueldos.Name = "txtPagoSueldos"
        Me.txtPagoSueldos.ReadOnly = True
        Me.txtPagoSueldos.Size = New System.Drawing.Size(156, 29)
        Me.txtPagoSueldos.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(1456, 328)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 28)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Pago de Sueldos"
        '
        'txtPagoProv
        '
        Me.txtPagoProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtPagoProv.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagoProv.Location = New System.Drawing.Point(1631, 269)
        Me.txtPagoProv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPagoProv.Name = "txtPagoProv"
        Me.txtPagoProv.ReadOnly = True
        Me.txtPagoProv.Size = New System.Drawing.Size(156, 29)
        Me.txtPagoProv.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1423, 272)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 28)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Pago a Proveedores"
        '
        'txtIngresosPorVentas
        '
        Me.txtIngresosPorVentas.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngresosPorVentas.Location = New System.Drawing.Point(1631, 208)
        Me.txtIngresosPorVentas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIngresosPorVentas.Name = "txtIngresosPorVentas"
        Me.txtIngresosPorVentas.ReadOnly = True
        Me.txtIngresosPorVentas.Size = New System.Drawing.Size(156, 29)
        Me.txtIngresosPorVentas.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(1423, 209)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 28)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Ingresos por Ventas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1516, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 66)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Totales"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(1494, 383)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 28)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Otros Pagos"
        '
        'txtOtrosPagos
        '
        Me.txtOtrosPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtOtrosPagos.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtrosPagos.Location = New System.Drawing.Point(1631, 380)
        Me.txtOtrosPagos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOtrosPagos.Name = "txtOtrosPagos"
        Me.txtOtrosPagos.ReadOnly = True
        Me.txtOtrosPagos.Size = New System.Drawing.Size(156, 29)
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
        Me.txtFNM.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtFNM.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFNM.Location = New System.Drawing.Point(1631, 437)
        Me.txtFNM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFNM.Name = "txtFNM"
        Me.txtFNM.ReadOnly = True
        Me.txtFNM.Size = New System.Drawing.Size(156, 29)
        Me.txtFNM.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(1437, 440)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(186, 28)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Flujo Neto del Mes"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(323, 666)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(202, 31)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Agregar Producto"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackgroundImage = CType(resources.GetObject("btnAgregar.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(352, 528)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(126, 118)
        Me.btnAgregar.TabIndex = 39
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(844, 665)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(205, 31)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Eliminar Producto"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(879, 528)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(126, 118)
        Me.btnEliminar.TabIndex = 41
        Me.btnEliminar.UseVisualStyleBackColor = True
        Me.btnEliminar.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1741, 649)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 31)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Imprimir"
        '
        'btnImprimir
        '
        Me.btnImprimir.BackgroundImage = CType(resources.GetObject("btnImprimir.BackgroundImage"), System.Drawing.Image)
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Location = New System.Drawing.Point(1735, 550)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(119, 96)
        Me.btnImprimir.TabIndex = 43
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'FormPresupuestoCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 744)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnAgregar)
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtgPresupuestoCaja)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormPresupuestoCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPresupuestoCaja"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtgPresupuestoCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgPresupuestoCaja As DataGridView
    Friend WithEvents Label1 As Label
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
    Friend WithEvents Label11 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents btnImprimir As Button
End Class
