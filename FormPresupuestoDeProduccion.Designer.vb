﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPresupuestoDeProduccion
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPresupuestoDeProduccion))
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
        Me.txtTotalUndVender = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregarColumn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInventarioFinal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtInventarioInicial = New System.Windows.Forms.TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtUnidadesProducir = New System.Windows.Forms.TextBox()
        Me.txtCostoTotalProduccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCostoTotalMOD = New System.Windows.Forms.TextBox()
        Me.txtCostoTotalCIF = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCostoTotalPlaneado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        CType(Me.dtgPresupuestoProducción, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgPresupuestoProducción
        '
        Me.dtgPresupuestoProducción.AllowUserToResizeColumns = False
        Me.dtgPresupuestoProducción.AllowUserToResizeRows = False
        Me.dtgPresupuestoProducción.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.dtgPresupuestoProducción.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgPresupuestoProducción.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgPresupuestoProducción.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPresupuestoProducción.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Unidades_a_Vender, Me.Inventario_Final, Me.Inventario_Inicial, Me.Costo_Unitario, Me.MOD_Unidad, Me.CIF_Unidad, Me.Unidades_a_Producir, Me.Costo_Total_Producción, Me.Costo_Total_MOD, Me.Costo_Total_CIF, Me.Costo_Total_Planeado})
        Me.dtgPresupuestoProducción.GridColor = System.Drawing.SystemColors.InfoText
        Me.dtgPresupuestoProducción.Location = New System.Drawing.Point(11, 45)
        Me.dtgPresupuestoProducción.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dtgPresupuestoProducción.Name = "dtgPresupuestoProducción"
        Me.dtgPresupuestoProducción.RowHeadersWidth = 62
        Me.dtgPresupuestoProducción.Size = New System.Drawing.Size(1636, 353)
        Me.dtgPresupuestoProducción.TabIndex = 1
        '
        'Producto
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Format = "N2"
        Me.Unidades_a_Vender.DefaultCellStyle = DataGridViewCellStyle3
        Me.Unidades_a_Vender.HeaderText = "Unidades a vender"
        Me.Unidades_a_Vender.MinimumWidth = 8
        Me.Unidades_a_Vender.Name = "Unidades_a_Vender"
        Me.Unidades_a_Vender.Width = 150
        '
        'Inventario_Final
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "N2"
        Me.Inventario_Final.DefaultCellStyle = DataGridViewCellStyle4
        Me.Inventario_Final.HeaderText = "Inventario Final"
        Me.Inventario_Final.MinimumWidth = 8
        Me.Inventario_Final.Name = "Inventario_Final"
        Me.Inventario_Final.Width = 150
        '
        'Inventario_Inicial
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "N2"
        Me.Inventario_Inicial.DefaultCellStyle = DataGridViewCellStyle5
        Me.Inventario_Inicial.HeaderText = "Inventario Inicial"
        Me.Inventario_Inicial.MinimumWidth = 8
        Me.Inventario_Inicial.Name = "Inventario_Inicial"
        Me.Inventario_Inicial.Width = 150
        '
        'Costo_Unitario
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "C2"
        Me.Costo_Unitario.DefaultCellStyle = DataGridViewCellStyle6
        Me.Costo_Unitario.HeaderText = "Costo Unitario"
        Me.Costo_Unitario.MinimumWidth = 8
        Me.Costo_Unitario.Name = "Costo_Unitario"
        Me.Costo_Unitario.Width = 150
        '
        'MOD_Unidad
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.Format = "C2"
        Me.MOD_Unidad.DefaultCellStyle = DataGridViewCellStyle7
        Me.MOD_Unidad.HeaderText = "MOD por Unidad"
        Me.MOD_Unidad.MinimumWidth = 8
        Me.MOD_Unidad.Name = "MOD_Unidad"
        Me.MOD_Unidad.Width = 150
        '
        'CIF_Unidad
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.Format = "C2"
        Me.CIF_Unidad.DefaultCellStyle = DataGridViewCellStyle8
        Me.CIF_Unidad.HeaderText = "CIF por Unidad"
        Me.CIF_Unidad.MinimumWidth = 8
        Me.CIF_Unidad.Name = "CIF_Unidad"
        Me.CIF_Unidad.Width = 150
        '
        'Unidades_a_Producir
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.Format = "N2"
        Me.Unidades_a_Producir.DefaultCellStyle = DataGridViewCellStyle9
        Me.Unidades_a_Producir.HeaderText = "Unidades a Producir"
        Me.Unidades_a_Producir.MinimumWidth = 8
        Me.Unidades_a_Producir.Name = "Unidades_a_Producir"
        Me.Unidades_a_Producir.Width = 150
        '
        'Costo_Total_Producción
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.Format = "C2"
        Me.Costo_Total_Producción.DefaultCellStyle = DataGridViewCellStyle10
        Me.Costo_Total_Producción.HeaderText = "Costo Total Producción"
        Me.Costo_Total_Producción.MinimumWidth = 8
        Me.Costo_Total_Producción.Name = "Costo_Total_Producción"
        Me.Costo_Total_Producción.Width = 150
        '
        'Costo_Total_MOD
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.Format = "C2"
        Me.Costo_Total_MOD.DefaultCellStyle = DataGridViewCellStyle11
        Me.Costo_Total_MOD.HeaderText = "Costo Total MOD"
        Me.Costo_Total_MOD.MinimumWidth = 8
        Me.Costo_Total_MOD.Name = "Costo_Total_MOD"
        Me.Costo_Total_MOD.Width = 150
        '
        'Costo_Total_CIF
        '
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.Format = "C2"
        Me.Costo_Total_CIF.DefaultCellStyle = DataGridViewCellStyle12
        Me.Costo_Total_CIF.HeaderText = "Costo Total CIF"
        Me.Costo_Total_CIF.MinimumWidth = 8
        Me.Costo_Total_CIF.Name = "Costo_Total_CIF"
        Me.Costo_Total_CIF.Width = 150
        '
        'Costo_Total_Planeado
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.Format = "C2"
        Me.Costo_Total_Planeado.DefaultCellStyle = DataGridViewCellStyle13
        Me.Costo_Total_Planeado.HeaderText = "Costo Total Planeado"
        Me.Costo_Total_Planeado.MinimumWidth = 8
        Me.Costo_Total_Planeado.Name = "Costo_Total_Planeado"
        Me.Costo_Total_Planeado.Width = 150
        '
        'txtTotalUndVender
        '
        Me.txtTotalUndVender.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtTotalUndVender.Font = New System.Drawing.Font("Montserrat Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalUndVender.Location = New System.Drawing.Point(187, 99)
        Me.txtTotalUndVender.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTotalUndVender.Name = "txtTotalUndVender"
        Me.txtTotalUndVender.ReadOnly = True
        Me.txtTotalUndVender.Size = New System.Drawing.Size(147, 28)
        Me.txtTotalUndVender.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 22)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Unidades a Vender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(37, 638)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 38)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Totales"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(1063, 421)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(112, 94)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.UseVisualStyleBackColor = True
        Me.btnEliminar.Visible = False
        '
        'btnAgregarColumn
        '
        Me.btnAgregarColumn.BackgroundImage = CType(resources.GetObject("btnAgregarColumn.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarColumn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarColumn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarColumn.FlatAppearance.BorderSize = 0
        Me.btnAgregarColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarColumn.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarColumn.Location = New System.Drawing.Point(548, 421)
        Me.btnAgregarColumn.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnAgregarColumn.Name = "btnAgregarColumn"
        Me.btnAgregarColumn.Size = New System.Drawing.Size(112, 94)
        Me.btnAgregarColumn.TabIndex = 7
        Me.btnAgregarColumn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(358, 101)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 22)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Inventario Final"
        '
        'txtInventarioFinal
        '
        Me.txtInventarioFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtInventarioFinal.Font = New System.Drawing.Font("Montserrat Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInventarioFinal.Location = New System.Drawing.Point(548, 101)
        Me.txtInventarioFinal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInventarioFinal.Name = "txtInventarioFinal"
        Me.txtInventarioFinal.ReadOnly = True
        Me.txtInventarioFinal.Size = New System.Drawing.Size(165, 28)
        Me.txtInventarioFinal.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(737, 102)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 22)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Inventario Inicial"
        '
        'txtInventarioInicial
        '
        Me.txtInventarioInicial.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtInventarioInicial.Font = New System.Drawing.Font("Montserrat Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInventarioInicial.Location = New System.Drawing.Point(880, 102)
        Me.txtInventarioInicial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInventarioInicial.Name = "txtInventarioInicial"
        Me.txtInventarioInicial.ReadOnly = True
        Me.txtInventarioInicial.Size = New System.Drawing.Size(169, 28)
        Me.txtInventarioInicial.TabIndex = 15
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.lbl.Location = New System.Drawing.Point(6, 147)
        Me.lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(160, 22)
        Me.lbl.TabIndex = 22
        Me.lbl.Text = "Unidades a Producir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtUnidadesProducir
        '
        Me.txtUnidadesProducir.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtUnidadesProducir.Font = New System.Drawing.Font("Montserrat Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidadesProducir.Location = New System.Drawing.Point(187, 146)
        Me.txtUnidadesProducir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUnidadesProducir.Name = "txtUnidadesProducir"
        Me.txtUnidadesProducir.ReadOnly = True
        Me.txtUnidadesProducir.Size = New System.Drawing.Size(147, 28)
        Me.txtUnidadesProducir.TabIndex = 26
        '
        'txtCostoTotalProduccion
        '
        Me.txtCostoTotalProduccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtCostoTotalProduccion.Font = New System.Drawing.Font("Montserrat Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoTotalProduccion.Location = New System.Drawing.Point(548, 146)
        Me.txtCostoTotalProduccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCostoTotalProduccion.Name = "txtCostoTotalProduccion"
        Me.txtCostoTotalProduccion.ReadOnly = True
        Me.txtCostoTotalProduccion.Size = New System.Drawing.Size(165, 28)
        Me.txtCostoTotalProduccion.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(358, 146)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 22)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Costo Total Producción"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(737, 146)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 22)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Costo Total MOD"
        '
        'txtCostoTotalMOD
        '
        Me.txtCostoTotalMOD.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtCostoTotalMOD.Font = New System.Drawing.Font("Montserrat Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoTotalMOD.Location = New System.Drawing.Point(879, 146)
        Me.txtCostoTotalMOD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCostoTotalMOD.Name = "txtCostoTotalMOD"
        Me.txtCostoTotalMOD.ReadOnly = True
        Me.txtCostoTotalMOD.Size = New System.Drawing.Size(170, 28)
        Me.txtCostoTotalMOD.TabIndex = 30
        '
        'txtCostoTotalCIF
        '
        Me.txtCostoTotalCIF.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtCostoTotalCIF.Font = New System.Drawing.Font("Montserrat Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoTotalCIF.Location = New System.Drawing.Point(1260, 102)
        Me.txtCostoTotalCIF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCostoTotalCIF.Name = "txtCostoTotalCIF"
        Me.txtCostoTotalCIF.ReadOnly = True
        Me.txtCostoTotalCIF.Size = New System.Drawing.Size(192, 28)
        Me.txtCostoTotalCIF.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(1084, 147)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 22)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Costo Total CIF"
        '
        'txtCostoTotalPlaneado
        '
        Me.txtCostoTotalPlaneado.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtCostoTotalPlaneado.Font = New System.Drawing.Font("Montserrat Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoTotalPlaneado.Location = New System.Drawing.Point(1260, 146)
        Me.txtCostoTotalPlaneado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCostoTotalPlaneado.Name = "txtCostoTotalPlaneado"
        Me.txtCostoTotalPlaneado.ReadOnly = True
        Me.txtCostoTotalPlaneado.Size = New System.Drawing.Size(192, 28)
        Me.txtCostoTotalPlaneado.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(1084, 102)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 22)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Costo Total Planeado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(652, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 38)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Presupuesto de Producción"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.dtgPresupuestoProducción)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnAgregarColumn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 31)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1689, 583)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1032, 530)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(173, 27)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Eliminar Producto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(518, 530)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(172, 27)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Agregar Producto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(416, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Nota: Por favor, ingrese primero el nombre del producto"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lbl)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.btnImprimir)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtCostoTotalPlaneado)
        Me.GroupBox2.Controls.Add(Me.txtTotalUndVender)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtInventarioFinal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtCostoTotalCIF)
        Me.GroupBox2.Controls.Add(Me.txtInventarioInicial)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtUnidadesProducir)
        Me.GroupBox2.Controls.Add(Me.txtCostoTotalMOD)
        Me.GroupBox2.Controls.Add(Me.txtCostoTotalProduccion)
        Me.GroupBox2.Location = New System.Drawing.Point(47, 634)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1689, 186)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1550, 142)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 27)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Imprimir"
        '
        'btnImprimir
        '
        Me.btnImprimir.BackgroundImage = CType(resources.GetObject("btnImprimir.BackgroundImage"), System.Drawing.Image)
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Location = New System.Drawing.Point(1533, 36)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(131, 95)
        Me.btnImprimir.TabIndex = 35
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'FormPresupuestoDeProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1710, 840)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormPresupuestoDeProduccion"
        Me.Text = "FormPresupuestoDeProduccion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtgPresupuestoProducción, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgPresupuestoProducción As DataGridView
    Friend WithEvents txtTotalUndVender As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregarColumn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtInventarioFinal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtInventarioInicial As TextBox
    Friend WithEvents lbl As Label
    Friend WithEvents txtUnidadesProducir As TextBox
    Friend WithEvents txtCostoTotalProduccion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCostoTotalMOD As TextBox
    Friend WithEvents txtCostoTotalCIF As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCostoTotalPlaneado As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
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
    Friend WithEvents btnImprimir As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
