<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dtgPresupuestoProducción, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgPresupuestoProducción
        '
        Me.dtgPresupuestoProducción.AllowUserToResizeColumns = False
        Me.dtgPresupuestoProducción.AllowUserToResizeRows = False
        Me.dtgPresupuestoProducción.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgPresupuestoProducción.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgPresupuestoProducción.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dtgPresupuestoProducción.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPresupuestoProducción.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Unidades_a_Vender, Me.Inventario_Final, Me.Inventario_Inicial, Me.Costo_Unitario, Me.MOD_Unidad, Me.CIF_Unidad, Me.Unidades_a_Producir, Me.Costo_Total_Producción, Me.Costo_Total_MOD, Me.Costo_Total_CIF, Me.Costo_Total_Planeado})
        Me.dtgPresupuestoProducción.GridColor = System.Drawing.SystemColors.InfoText
        Me.dtgPresupuestoProducción.Location = New System.Drawing.Point(44, 75)
        Me.dtgPresupuestoProducción.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtgPresupuestoProducción.Name = "dtgPresupuestoProducción"
        Me.dtgPresupuestoProducción.RowHeadersWidth = 62
        Me.dtgPresupuestoProducción.Size = New System.Drawing.Size(1840, 569)
        Me.dtgPresupuestoProducción.TabIndex = 1
        '
        'Producto
        '
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.Producto.DefaultCellStyle = DataGridViewCellStyle15
        Me.Producto.HeaderText = "Producto"
        Me.Producto.MinimumWidth = 8
        Me.Producto.Name = "Producto"
        Me.Producto.Width = 150
        '
        'Unidades_a_Vender
        '
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.Format = "N2"
        Me.Unidades_a_Vender.DefaultCellStyle = DataGridViewCellStyle16
        Me.Unidades_a_Vender.HeaderText = "Unidades a vender"
        Me.Unidades_a_Vender.MinimumWidth = 8
        Me.Unidades_a_Vender.Name = "Unidades_a_Vender"
        Me.Unidades_a_Vender.Width = 150
        '
        'Inventario_Final
        '
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.Format = "N2"
        Me.Inventario_Final.DefaultCellStyle = DataGridViewCellStyle17
        Me.Inventario_Final.HeaderText = "Inventario Final"
        Me.Inventario_Final.MinimumWidth = 8
        Me.Inventario_Final.Name = "Inventario_Final"
        Me.Inventario_Final.Width = 150
        '
        'Inventario_Inicial
        '
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.Format = "N2"
        Me.Inventario_Inicial.DefaultCellStyle = DataGridViewCellStyle18
        Me.Inventario_Inicial.HeaderText = "Inventario Inicial"
        Me.Inventario_Inicial.MinimumWidth = 8
        Me.Inventario_Inicial.Name = "Inventario_Inicial"
        Me.Inventario_Inicial.Width = 150
        '
        'Costo_Unitario
        '
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.Format = "C2"
        Me.Costo_Unitario.DefaultCellStyle = DataGridViewCellStyle19
        Me.Costo_Unitario.HeaderText = "Costo Unitario"
        Me.Costo_Unitario.MinimumWidth = 8
        Me.Costo_Unitario.Name = "Costo_Unitario"
        Me.Costo_Unitario.Width = 150
        '
        'MOD_Unidad
        '
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.Format = "C2"
        Me.MOD_Unidad.DefaultCellStyle = DataGridViewCellStyle20
        Me.MOD_Unidad.HeaderText = "MOD por Unidad"
        Me.MOD_Unidad.MinimumWidth = 8
        Me.MOD_Unidad.Name = "MOD_Unidad"
        Me.MOD_Unidad.Width = 150
        '
        'CIF_Unidad
        '
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.Format = "C2"
        Me.CIF_Unidad.DefaultCellStyle = DataGridViewCellStyle21
        Me.CIF_Unidad.HeaderText = "CIF por Unidad"
        Me.CIF_Unidad.MinimumWidth = 8
        Me.CIF_Unidad.Name = "CIF_Unidad"
        Me.CIF_Unidad.Width = 150
        '
        'Unidades_a_Producir
        '
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.Format = "N2"
        Me.Unidades_a_Producir.DefaultCellStyle = DataGridViewCellStyle22
        Me.Unidades_a_Producir.HeaderText = "Unidades a Producir"
        Me.Unidades_a_Producir.MinimumWidth = 8
        Me.Unidades_a_Producir.Name = "Unidades_a_Producir"
        Me.Unidades_a_Producir.Width = 150
        '
        'Costo_Total_Producción
        '
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.Format = "C2"
        Me.Costo_Total_Producción.DefaultCellStyle = DataGridViewCellStyle23
        Me.Costo_Total_Producción.HeaderText = "Costo Total Producción"
        Me.Costo_Total_Producción.MinimumWidth = 8
        Me.Costo_Total_Producción.Name = "Costo_Total_Producción"
        Me.Costo_Total_Producción.Width = 150
        '
        'Costo_Total_MOD
        '
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.Format = "C2"
        Me.Costo_Total_MOD.DefaultCellStyle = DataGridViewCellStyle24
        Me.Costo_Total_MOD.HeaderText = "Costo Total MOD"
        Me.Costo_Total_MOD.MinimumWidth = 8
        Me.Costo_Total_MOD.Name = "Costo_Total_MOD"
        Me.Costo_Total_MOD.Width = 150
        '
        'Costo_Total_CIF
        '
        DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.Format = "C2"
        Me.Costo_Total_CIF.DefaultCellStyle = DataGridViewCellStyle25
        Me.Costo_Total_CIF.HeaderText = "Costo Total CIF"
        Me.Costo_Total_CIF.MinimumWidth = 8
        Me.Costo_Total_CIF.Name = "Costo_Total_CIF"
        Me.Costo_Total_CIF.Width = 150
        '
        'Costo_Total_Planeado
        '
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.Format = "C2"
        Me.Costo_Total_Planeado.DefaultCellStyle = DataGridViewCellStyle26
        Me.Costo_Total_Planeado.HeaderText = "Costo Total Planeado"
        Me.Costo_Total_Planeado.MinimumWidth = 8
        Me.Costo_Total_Planeado.Name = "Costo_Total_Planeado"
        Me.Costo_Total_Planeado.Width = 150
        '
        'txtTotalUndVender
        '
        Me.txtTotalUndVender.Location = New System.Drawing.Point(200, 871)
        Me.txtTotalUndVender.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotalUndVender.Name = "txtTotalUndVender"
        Me.txtTotalUndVender.ReadOnly = True
        Me.txtTotalUndVender.Size = New System.Drawing.Size(133, 26)
        Me.txtTotalUndVender.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 878)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Unidades a Vender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 797)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 41)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Totales"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(1046, 652)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(333, 57)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar Producto"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregarColumn
        '
        Me.btnAgregarColumn.Location = New System.Drawing.Point(454, 652)
        Me.btnAgregarColumn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAgregarColumn.Name = "btnAgregarColumn"
        Me.btnAgregarColumn.Size = New System.Drawing.Size(333, 57)
        Me.btnAgregarColumn.TabIndex = 7
        Me.btnAgregarColumn.Text = "Agregar Producto"
        Me.btnAgregarColumn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(363, 878)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Inventario Final"
        '
        'txtInventarioFinal
        '
        Me.txtInventarioFinal.Location = New System.Drawing.Point(488, 872)
        Me.txtInventarioFinal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtInventarioFinal.Name = "txtInventarioFinal"
        Me.txtInventarioFinal.ReadOnly = True
        Me.txtInventarioFinal.Size = New System.Drawing.Size(133, 26)
        Me.txtInventarioFinal.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(652, 878)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Inventario Inicial"
        '
        'txtInventarioInicial
        '
        Me.txtInventarioInicial.Location = New System.Drawing.Point(784, 871)
        Me.txtInventarioInicial.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtInventarioInicial.Name = "txtInventarioInicial"
        Me.txtInventarioInicial.ReadOnly = True
        Me.txtInventarioInicial.Size = New System.Drawing.Size(133, 26)
        Me.txtInventarioInicial.TabIndex = 15
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(40, 935)
        Me.lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(152, 20)
        Me.lbl.TabIndex = 22
        Me.lbl.Text = "Unidades a Producir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtUnidadesProducir
        '
        Me.txtUnidadesProducir.Location = New System.Drawing.Point(200, 929)
        Me.txtUnidadesProducir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUnidadesProducir.Name = "txtUnidadesProducir"
        Me.txtUnidadesProducir.ReadOnly = True
        Me.txtUnidadesProducir.Size = New System.Drawing.Size(133, 26)
        Me.txtUnidadesProducir.TabIndex = 26
        '
        'txtCostoTotalProduccion
        '
        Me.txtCostoTotalProduccion.Location = New System.Drawing.Point(532, 929)
        Me.txtCostoTotalProduccion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCostoTotalProduccion.Name = "txtCostoTotalProduccion"
        Me.txtCostoTotalProduccion.ReadOnly = True
        Me.txtCostoTotalProduccion.Size = New System.Drawing.Size(133, 26)
        Me.txtCostoTotalProduccion.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(351, 935)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Costo Total Producción"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(687, 935)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 20)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Costo Total MOD"
        '
        'txtCostoTotalMOD
        '
        Me.txtCostoTotalMOD.Location = New System.Drawing.Point(826, 929)
        Me.txtCostoTotalMOD.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCostoTotalMOD.Name = "txtCostoTotalMOD"
        Me.txtCostoTotalMOD.ReadOnly = True
        Me.txtCostoTotalMOD.Size = New System.Drawing.Size(133, 26)
        Me.txtCostoTotalMOD.TabIndex = 30
        '
        'txtCostoTotalCIF
        '
        Me.txtCostoTotalCIF.Location = New System.Drawing.Point(1112, 929)
        Me.txtCostoTotalCIF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCostoTotalCIF.Name = "txtCostoTotalCIF"
        Me.txtCostoTotalCIF.ReadOnly = True
        Me.txtCostoTotalCIF.Size = New System.Drawing.Size(133, 26)
        Me.txtCostoTotalCIF.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(984, 935)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 20)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Costo Total CIF"
        '
        'txtCostoTotalPlaneado
        '
        Me.txtCostoTotalPlaneado.Location = New System.Drawing.Point(1446, 932)
        Me.txtCostoTotalPlaneado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCostoTotalPlaneado.Name = "txtCostoTotalPlaneado"
        Me.txtCostoTotalPlaneado.ReadOnly = True
        Me.txtCostoTotalPlaneado.Size = New System.Drawing.Size(133, 26)
        Me.txtCostoTotalPlaneado.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1276, 935)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 20)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Costo Total Planeado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(734, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(476, 41)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Presupuesto de Producción"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnAgregarColumn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1900, 729)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(12, 752)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1900, 232)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(34, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(397, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Nota: Por favor, ingrese primero el nombre del producto"
        '
        'FormPresupuestoDeProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1678, 1050)
        Me.Controls.Add(Me.txtCostoTotalPlaneado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCostoTotalCIF)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCostoTotalMOD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCostoTotalProduccion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtUnidadesProducir)
        Me.Controls.Add(Me.txtInventarioInicial)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtInventarioFinal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalUndVender)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtgPresupuestoProducción)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormPresupuestoDeProduccion"
        Me.Text = "FormPresupuestoDeProduccion"
        CType(Me.dtgPresupuestoProducción, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents Label10 As Label
End Class
