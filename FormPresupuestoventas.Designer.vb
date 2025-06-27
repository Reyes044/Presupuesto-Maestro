<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPresupuestoVentas
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPresupuestoVentas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtgPresupuestodeventas = New System.Windows.Forms.DataGridView()
        Me.ColProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUnidadesProyectadas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIngresosBrutos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDevoluciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIngresosnetos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCostoVentas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColGastoVentas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPublicidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColGastopublicidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUtilidadBruta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrpPresupuestodeventas = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtunidaesproyectadas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.txtPublicidadCsUnidad = New System.Windows.Forms.TextBox()
        Me.TxtGastoVentas = New System.Windows.Forms.TextBox()
        Me.LblCordoba = New System.Windows.Forms.Label()
        Me.txtPreciounitario = New System.Windows.Forms.TextBox()
        Me.TxtNombreProducto = New System.Windows.Forms.TextBox()
        Me.LblProducto = New System.Windows.Forms.Label()
        Me.LblIngresarDatos = New System.Windows.Forms.Label()
        Me.LblPublicidad = New System.Windows.Forms.Label()
        Me.LblGastoventas = New System.Windows.Forms.Label()
        Me.LblPrecioUnitario = New System.Windows.Forms.Label()
        Me.LblUnidadesproyectadasTotal = New System.Windows.Forms.Label()
        Me.txtunidadesproyectadastotal = New System.Windows.Forms.TextBox()
        Me.txttotalpreciounitario = New System.Windows.Forms.TextBox()
        Me.lblTotalpreciounitario = New System.Windows.Forms.Label()
        Me.txtTotalingresosbrutos = New System.Windows.Forms.TextBox()
        Me.LblIngresosbrutostotales = New System.Windows.Forms.Label()
        Me.LblTotalDevoluciones = New System.Windows.Forms.Label()
        Me.txtTotaldevoluciones = New System.Windows.Forms.TextBox()
        Me.txtTotalingresosNetos = New System.Windows.Forms.TextBox()
        Me.LblTotalingresosNetos = New System.Windows.Forms.Label()
        Me.LblCostodeventas = New System.Windows.Forms.Label()
        Me.txtTotalCostodeventas = New System.Windows.Forms.TextBox()
        Me.LblTotalGastoVentas = New System.Windows.Forms.Label()
        Me.txtTotalgastoVentas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalPublicidad = New System.Windows.Forms.TextBox()
        Me.LblTotalgastopublicidad = New System.Windows.Forms.Label()
        Me.txtTotalgastoPublicidad = New System.Windows.Forms.TextBox()
        Me.LblTotalUtilidadBruta = New System.Windows.Forms.Label()
        Me.txtTotalUtilidadbruta = New System.Windows.Forms.TextBox()
        Me.BtnEliminarfila = New System.Windows.Forms.Button()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DtgPresupuestodeventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPresupuestodeventas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(461, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Presupuesto de ventas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DtgPresupuestodeventas
        '
        Me.DtgPresupuestodeventas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgPresupuestodeventas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgPresupuestodeventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgPresupuestodeventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColProducto, Me.ColUnidadesProyectadas, Me.ColPrecioUnitario, Me.ColIngresosBrutos, Me.ColDevoluciones, Me.ColIngresosnetos, Me.ColCostoVentas, Me.ColGastoVentas, Me.ColPublicidad, Me.ColGastopublicidad, Me.ColUtilidadBruta})
        Me.DtgPresupuestodeventas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DtgPresupuestodeventas.Location = New System.Drawing.Point(2, 208)
        Me.DtgPresupuestodeventas.Name = "DtgPresupuestodeventas"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgPresupuestodeventas.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DtgPresupuestodeventas.RowHeadersWidth = 51
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Montserrat Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtgPresupuestodeventas.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DtgPresupuestodeventas.Size = New System.Drawing.Size(1274, 262)
        Me.DtgPresupuestodeventas.TabIndex = 1
        '
        'ColProducto
        '
        Me.ColProducto.HeaderText = "Producto"
        Me.ColProducto.MinimumWidth = 6
        Me.ColProducto.Name = "ColProducto"
        Me.ColProducto.Width = 125
        '
        'ColUnidadesProyectadas
        '
        Me.ColUnidadesProyectadas.HeaderText = "Unidades Proyectadas"
        Me.ColUnidadesProyectadas.MinimumWidth = 6
        Me.ColUnidadesProyectadas.Name = "ColUnidadesProyectadas"
        Me.ColUnidadesProyectadas.Width = 125
        '
        'ColPrecioUnitario
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ColPrecioUnitario.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColPrecioUnitario.HeaderText = "Precio Unitario (C$)"
        Me.ColPrecioUnitario.MinimumWidth = 6
        Me.ColPrecioUnitario.Name = "ColPrecioUnitario"
        Me.ColPrecioUnitario.Width = 125
        '
        'ColIngresosBrutos
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ColIngresosBrutos.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColIngresosBrutos.HeaderText = "Ingresos brutos (C$)"
        Me.ColIngresosBrutos.MinimumWidth = 6
        Me.ColIngresosBrutos.Name = "ColIngresosBrutos"
        Me.ColIngresosBrutos.Width = 125
        '
        'ColDevoluciones
        '
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ColDevoluciones.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColDevoluciones.HeaderText = "Devoluciones (5%)"
        Me.ColDevoluciones.MinimumWidth = 6
        Me.ColDevoluciones.Name = "ColDevoluciones"
        Me.ColDevoluciones.Width = 125
        '
        'ColIngresosnetos
        '
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.ColIngresosnetos.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColIngresosnetos.HeaderText = "Ingresos Netos"
        Me.ColIngresosnetos.MinimumWidth = 6
        Me.ColIngresosnetos.Name = "ColIngresosnetos"
        Me.ColIngresosnetos.Width = 125
        '
        'ColCostoVentas
        '
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.ColCostoVentas.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColCostoVentas.HeaderText = "Costo de ventas (40%)"
        Me.ColCostoVentas.MinimumWidth = 6
        Me.ColCostoVentas.Name = "ColCostoVentas"
        Me.ColCostoVentas.Width = 125
        '
        'ColGastoVentas
        '
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.ColGastoVentas.DefaultCellStyle = DataGridViewCellStyle7
        Me.ColGastoVentas.HeaderText = "Gasto de ventas (C$)"
        Me.ColGastoVentas.MinimumWidth = 6
        Me.ColGastoVentas.Name = "ColGastoVentas"
        Me.ColGastoVentas.Width = 125
        '
        'ColPublicidad
        '
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.ColPublicidad.DefaultCellStyle = DataGridViewCellStyle8
        Me.ColPublicidad.HeaderText = "Publicidad (C$/unidad)"
        Me.ColPublicidad.MinimumWidth = 6
        Me.ColPublicidad.Name = "ColPublicidad"
        Me.ColPublicidad.Width = 125
        '
        'ColGastopublicidad
        '
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.ColGastopublicidad.DefaultCellStyle = DataGridViewCellStyle9
        Me.ColGastopublicidad.HeaderText = "Gasto de Publicidad"
        Me.ColGastopublicidad.MinimumWidth = 6
        Me.ColGastopublicidad.Name = "ColGastopublicidad"
        Me.ColGastopublicidad.Width = 125
        '
        'ColUtilidadBruta
        '
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.ColUtilidadBruta.DefaultCellStyle = DataGridViewCellStyle10
        Me.ColUtilidadBruta.HeaderText = "Utilidad Bruta"
        Me.ColUtilidadBruta.MinimumWidth = 6
        Me.ColUtilidadBruta.Name = "ColUtilidadBruta"
        Me.ColUtilidadBruta.Width = 125
        '
        'GrpPresupuestodeventas
        '
        Me.GrpPresupuestodeventas.Controls.Add(Me.PictureBox1)
        Me.GrpPresupuestodeventas.Controls.Add(Me.Label4)
        Me.GrpPresupuestodeventas.Controls.Add(Me.txtunidaesproyectadas)
        Me.GrpPresupuestodeventas.Controls.Add(Me.Label2)
        Me.GrpPresupuestodeventas.Controls.Add(Me.BtnAgregar)
        Me.GrpPresupuestodeventas.Controls.Add(Me.txtPublicidadCsUnidad)
        Me.GrpPresupuestodeventas.Controls.Add(Me.TxtGastoVentas)
        Me.GrpPresupuestodeventas.Controls.Add(Me.LblCordoba)
        Me.GrpPresupuestodeventas.Controls.Add(Me.txtPreciounitario)
        Me.GrpPresupuestodeventas.Controls.Add(Me.TxtNombreProducto)
        Me.GrpPresupuestodeventas.Controls.Add(Me.LblProducto)
        Me.GrpPresupuestodeventas.Controls.Add(Me.LblIngresarDatos)
        Me.GrpPresupuestodeventas.Controls.Add(Me.LblPublicidad)
        Me.GrpPresupuestodeventas.Controls.Add(Me.LblGastoventas)
        Me.GrpPresupuestodeventas.Controls.Add(Me.LblPrecioUnitario)
        Me.GrpPresupuestodeventas.Controls.Add(Me.Label1)
        Me.GrpPresupuestodeventas.Location = New System.Drawing.Point(2, -4)
        Me.GrpPresupuestodeventas.Name = "GrpPresupuestodeventas"
        Me.GrpPresupuestodeventas.Size = New System.Drawing.Size(1274, 206)
        Me.GrpPresupuestodeventas.TabIndex = 2
        Me.GrpPresupuestodeventas.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1148, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Agregar"
        '
        'txtunidaesproyectadas
        '
        Me.txtunidaesproyectadas.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtunidaesproyectadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunidaesproyectadas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtunidaesproyectadas.Location = New System.Drawing.Point(190, 146)
        Me.txtunidaesproyectadas.Name = "txtunidaesproyectadas"
        Me.txtunidaesproyectadas.Size = New System.Drawing.Size(187, 20)
        Me.txtunidaesproyectadas.TabIndex = 13
        Me.txtunidaesproyectadas.Text = "Ingrese las unidades proyectadas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(17, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Unidades proyectadas:"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregar.Enabled = False
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.Location = New System.Drawing.Point(1127, 121)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(100, 64)
        Me.BtnAgregar.TabIndex = 11
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'txtPublicidadCsUnidad
        '
        Me.txtPublicidadCsUnidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtPublicidadCsUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublicidadCsUnidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtPublicidadCsUnidad.Location = New System.Drawing.Point(1106, 95)
        Me.txtPublicidadCsUnidad.Name = "txtPublicidadCsUnidad"
        Me.txtPublicidadCsUnidad.Size = New System.Drawing.Size(149, 20)
        Me.txtPublicidadCsUnidad.TabIndex = 10
        Me.txtPublicidadCsUnidad.Text = "Ingrese publicidad/unidad"
        '
        'TxtGastoVentas
        '
        Me.TxtGastoVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtGastoVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGastoVentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TxtGastoVentas.Location = New System.Drawing.Point(707, 97)
        Me.TxtGastoVentas.Name = "TxtGastoVentas"
        Me.TxtGastoVentas.Size = New System.Drawing.Size(149, 20)
        Me.TxtGastoVentas.TabIndex = 9
        Me.TxtGastoVentas.Text = "Ingrese el gasto de ventas"
        '
        'LblCordoba
        '
        Me.LblCordoba.AutoSize = True
        Me.LblCordoba.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCordoba.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblCordoba.Location = New System.Drawing.Point(756, 132)
        Me.LblCordoba.Name = "LblCordoba"
        Me.LblCordoba.Size = New System.Drawing.Size(26, 20)
        Me.LblCordoba.TabIndex = 8
        Me.LblCordoba.Text = "C$"
        '
        'txtPreciounitario
        '
        Me.txtPreciounitario.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtPreciounitario.Enabled = False
        Me.txtPreciounitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreciounitario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtPreciounitario.Location = New System.Drawing.Point(656, 148)
        Me.txtPreciounitario.Name = "txtPreciounitario"
        Me.txtPreciounitario.Size = New System.Drawing.Size(92, 20)
        Me.txtPreciounitario.TabIndex = 7
        Me.txtPreciounitario.Text = "Ingrese el precio"
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TxtNombreProducto.Location = New System.Drawing.Point(186, 98)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(292, 20)
        Me.TxtNombreProducto.TabIndex = 6
        Me.TxtNombreProducto.Text = "Ingrese el nombre del producto"
        '
        'LblProducto
        '
        Me.LblProducto.AutoSize = True
        Me.LblProducto.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblProducto.Location = New System.Drawing.Point(17, 98)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(163, 20)
        Me.LblProducto.TabIndex = 5
        Me.LblProducto.Text = "Nombre del producto:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblIngresarDatos
        '
        Me.LblIngresarDatos.AutoSize = True
        Me.LblIngresarDatos.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIngresarDatos.Location = New System.Drawing.Point(183, 44)
        Me.LblIngresarDatos.Name = "LblIngresarDatos"
        Me.LblIngresarDatos.Size = New System.Drawing.Size(181, 18)
        Me.LblIngresarDatos.TabIndex = 4
        Me.LblIngresarDatos.Text = "Ingrese los siguientes datos"
        '
        'LblPublicidad
        '
        Me.LblPublicidad.AutoSize = True
        Me.LblPublicidad.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPublicidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblPublicidad.Location = New System.Drawing.Point(929, 93)
        Me.LblPublicidad.Name = "LblPublicidad"
        Me.LblPublicidad.Size = New System.Drawing.Size(170, 20)
        Me.LblPublicidad.TabIndex = 3
        Me.LblPublicidad.Text = "Publicidad (C$/unidad):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblGastoventas
        '
        Me.LblGastoventas.AutoSize = True
        Me.LblGastoventas.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGastoventas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblGastoventas.Location = New System.Drawing.Point(537, 95)
        Me.LblGastoventas.Name = "LblGastoventas"
        Me.LblGastoventas.Size = New System.Drawing.Size(155, 20)
        Me.LblGastoventas.TabIndex = 2
        Me.LblGastoventas.Text = "Gasto de ventas (C$):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblPrecioUnitario
        '
        Me.LblPrecioUnitario.AutoSize = True
        Me.LblPrecioUnitario.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecioUnitario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblPrecioUnitario.Location = New System.Drawing.Point(537, 150)
        Me.LblPrecioUnitario.Name = "LblPrecioUnitario"
        Me.LblPrecioUnitario.Size = New System.Drawing.Size(117, 20)
        Me.LblPrecioUnitario.TabIndex = 1
        Me.LblPrecioUnitario.Text = "Precio unitario:"
        '
        'LblUnidadesproyectadasTotal
        '
        Me.LblUnidadesproyectadasTotal.AutoSize = True
        Me.LblUnidadesproyectadasTotal.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUnidadesproyectadasTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblUnidadesproyectadasTotal.Location = New System.Drawing.Point(9, 499)
        Me.LblUnidadesproyectadasTotal.Name = "LblUnidadesproyectadasTotal"
        Me.LblUnidadesproyectadasTotal.Size = New System.Drawing.Size(204, 60)
        Me.LblUnidadesproyectadasTotal.TabIndex = 3
        Me.LblUnidadesproyectadasTotal.Text = "Unidades proyectadas total:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtunidadesproyectadastotal
        '
        Me.txtunidadesproyectadastotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtunidadesproyectadastotal.Enabled = False
        Me.txtunidadesproyectadastotal.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunidadesproyectadastotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtunidadesproyectadastotal.Location = New System.Drawing.Point(222, 501)
        Me.txtunidadesproyectadastotal.Name = "txtunidadesproyectadastotal"
        Me.txtunidadesproyectadastotal.Size = New System.Drawing.Size(159, 23)
        Me.txtunidadesproyectadastotal.TabIndex = 4
        '
        'txttotalpreciounitario
        '
        Me.txttotalpreciounitario.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txttotalpreciounitario.Enabled = False
        Me.txttotalpreciounitario.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalpreciounitario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txttotalpreciounitario.Location = New System.Drawing.Point(222, 546)
        Me.txttotalpreciounitario.Name = "txttotalpreciounitario"
        Me.txttotalpreciounitario.Size = New System.Drawing.Size(159, 23)
        Me.txttotalpreciounitario.TabIndex = 7
        '
        'lblTotalpreciounitario
        '
        Me.lblTotalpreciounitario.AutoSize = True
        Me.lblTotalpreciounitario.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalpreciounitario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.lblTotalpreciounitario.Location = New System.Drawing.Point(64, 544)
        Me.lblTotalpreciounitario.Name = "lblTotalpreciounitario"
        Me.lblTotalpreciounitario.Size = New System.Drawing.Size(155, 20)
        Me.lblTotalpreciounitario.TabIndex = 8
        Me.lblTotalpreciounitario.Text = "Total predio unitario:"
        '
        'txtTotalingresosbrutos
        '
        Me.txtTotalingresosbrutos.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtTotalingresosbrutos.Enabled = False
        Me.txtTotalingresosbrutos.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalingresosbrutos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtTotalingresosbrutos.Location = New System.Drawing.Point(222, 584)
        Me.txtTotalingresosbrutos.Name = "txtTotalingresosbrutos"
        Me.txtTotalingresosbrutos.Size = New System.Drawing.Size(159, 23)
        Me.txtTotalingresosbrutos.TabIndex = 9
        '
        'LblIngresosbrutostotales
        '
        Me.LblIngresosbrutostotales.AutoSize = True
        Me.LblIngresosbrutostotales.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIngresosbrutostotales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblIngresosbrutostotales.Location = New System.Drawing.Point(55, 584)
        Me.LblIngresosbrutostotales.Name = "LblIngresosbrutostotales"
        Me.LblIngresosbrutostotales.Size = New System.Drawing.Size(160, 20)
        Me.LblIngresosbrutostotales.TabIndex = 10
        Me.LblIngresosbrutostotales.Text = "Total ingresos brutos:"
        '
        'LblTotalDevoluciones
        '
        Me.LblTotalDevoluciones.AutoSize = True
        Me.LblTotalDevoluciones.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalDevoluciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblTotalDevoluciones.Location = New System.Drawing.Point(72, 620)
        Me.LblTotalDevoluciones.Name = "LblTotalDevoluciones"
        Me.LblTotalDevoluciones.Size = New System.Drawing.Size(143, 20)
        Me.LblTotalDevoluciones.TabIndex = 11
        Me.LblTotalDevoluciones.Text = "Total devoluciones:"
        '
        'txtTotaldevoluciones
        '
        Me.txtTotaldevoluciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtTotaldevoluciones.Enabled = False
        Me.txtTotaldevoluciones.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotaldevoluciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtTotaldevoluciones.Location = New System.Drawing.Point(222, 622)
        Me.txtTotaldevoluciones.Name = "txtTotaldevoluciones"
        Me.txtTotaldevoluciones.Size = New System.Drawing.Size(159, 23)
        Me.txtTotaldevoluciones.TabIndex = 12
        '
        'txtTotalingresosNetos
        '
        Me.txtTotalingresosNetos.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtTotalingresosNetos.Enabled = False
        Me.txtTotalingresosNetos.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalingresosNetos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtTotalingresosNetos.Location = New System.Drawing.Point(222, 658)
        Me.txtTotalingresosNetos.Name = "txtTotalingresosNetos"
        Me.txtTotalingresosNetos.Size = New System.Drawing.Size(159, 23)
        Me.txtTotalingresosNetos.TabIndex = 13
        '
        'LblTotalingresosNetos
        '
        Me.LblTotalingresosNetos.AutoSize = True
        Me.LblTotalingresosNetos.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalingresosNetos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblTotalingresosNetos.Location = New System.Drawing.Point(58, 658)
        Me.LblTotalingresosNetos.Name = "LblTotalingresosNetos"
        Me.LblTotalingresosNetos.Size = New System.Drawing.Size(153, 20)
        Me.LblTotalingresosNetos.TabIndex = 14
        Me.LblTotalingresosNetos.Text = "Total Ingresos netos:"
        '
        'LblCostodeventas
        '
        Me.LblCostodeventas.AutoSize = True
        Me.LblCostodeventas.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCostodeventas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblCostodeventas.Location = New System.Drawing.Point(476, 499)
        Me.LblCostodeventas.Name = "LblCostodeventas"
        Me.LblCostodeventas.Size = New System.Drawing.Size(161, 20)
        Me.LblCostodeventas.TabIndex = 15
        Me.LblCostodeventas.Text = "Total costo de ventas:"
        '
        'txtTotalCostodeventas
        '
        Me.txtTotalCostodeventas.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtTotalCostodeventas.Enabled = False
        Me.txtTotalCostodeventas.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCostodeventas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtTotalCostodeventas.Location = New System.Drawing.Point(646, 501)
        Me.txtTotalCostodeventas.Name = "txtTotalCostodeventas"
        Me.txtTotalCostodeventas.Size = New System.Drawing.Size(159, 23)
        Me.txtTotalCostodeventas.TabIndex = 16
        '
        'LblTotalGastoVentas
        '
        Me.LblTotalGastoVentas.AutoSize = True
        Me.LblTotalGastoVentas.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalGastoVentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblTotalGastoVentas.Location = New System.Drawing.Point(476, 544)
        Me.LblTotalGastoVentas.Name = "LblTotalGastoVentas"
        Me.LblTotalGastoVentas.Size = New System.Drawing.Size(161, 20)
        Me.LblTotalGastoVentas.TabIndex = 17
        Me.LblTotalGastoVentas.Text = "Total gasto de ventas:"
        '
        'txtTotalgastoVentas
        '
        Me.txtTotalgastoVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtTotalgastoVentas.Enabled = False
        Me.txtTotalgastoVentas.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalgastoVentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtTotalgastoVentas.Location = New System.Drawing.Point(646, 544)
        Me.txtTotalgastoVentas.Name = "txtTotalgastoVentas"
        Me.txtTotalgastoVentas.Size = New System.Drawing.Size(159, 23)
        Me.txtTotalgastoVentas.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(476, 584)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 40)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Total Publicidad: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(C$/Unidad)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtTotalPublicidad
        '
        Me.txtTotalPublicidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtTotalPublicidad.Enabled = False
        Me.txtTotalPublicidad.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPublicidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtTotalPublicidad.Location = New System.Drawing.Point(646, 586)
        Me.txtTotalPublicidad.Name = "txtTotalPublicidad"
        Me.txtTotalPublicidad.Size = New System.Drawing.Size(159, 23)
        Me.txtTotalPublicidad.TabIndex = 20
        '
        'LblTotalgastopublicidad
        '
        Me.LblTotalgastopublicidad.AutoSize = True
        Me.LblTotalgastopublicidad.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalgastopublicidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblTotalgastopublicidad.Location = New System.Drawing.Point(476, 638)
        Me.LblTotalgastopublicidad.Name = "LblTotalgastopublicidad"
        Me.LblTotalgastopublicidad.Size = New System.Drawing.Size(111, 60)
        Me.LblTotalgastopublicidad.TabIndex = 21
        Me.LblTotalgastopublicidad.Text = "Total gasto de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "publicidad:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtTotalgastoPublicidad
        '
        Me.txtTotalgastoPublicidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtTotalgastoPublicidad.Enabled = False
        Me.txtTotalgastoPublicidad.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalgastoPublicidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtTotalgastoPublicidad.Location = New System.Drawing.Point(646, 638)
        Me.txtTotalgastoPublicidad.Name = "txtTotalgastoPublicidad"
        Me.txtTotalgastoPublicidad.Size = New System.Drawing.Size(159, 23)
        Me.txtTotalgastoPublicidad.TabIndex = 22
        '
        'LblTotalUtilidadBruta
        '
        Me.LblTotalUtilidadBruta.AutoSize = True
        Me.LblTotalUtilidadBruta.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalUtilidadBruta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblTotalUtilidadBruta.Location = New System.Drawing.Point(859, 501)
        Me.LblTotalUtilidadBruta.Name = "LblTotalUtilidadBruta"
        Me.LblTotalUtilidadBruta.Size = New System.Drawing.Size(146, 20)
        Me.LblTotalUtilidadBruta.TabIndex = 23
        Me.LblTotalUtilidadBruta.Text = "Total utilidad bruta:"
        '
        'txtTotalUtilidadbruta
        '
        Me.txtTotalUtilidadbruta.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtTotalUtilidadbruta.Enabled = False
        Me.txtTotalUtilidadbruta.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalUtilidadbruta.Location = New System.Drawing.Point(1011, 499)
        Me.txtTotalUtilidadbruta.Name = "txtTotalUtilidadbruta"
        Me.txtTotalUtilidadbruta.Size = New System.Drawing.Size(144, 23)
        Me.txtTotalUtilidadbruta.TabIndex = 24
        '
        'BtnEliminarfila
        '
        Me.BtnEliminarfila.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminarfila.FlatAppearance.BorderSize = 0
        Me.BtnEliminarfila.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarfila.Image = CType(resources.GetObject("BtnEliminarfila.Image"), System.Drawing.Image)
        Me.BtnEliminarfila.Location = New System.Drawing.Point(991, 582)
        Me.BtnEliminarfila.Name = "BtnEliminarfila"
        Me.BtnEliminarfila.Size = New System.Drawing.Size(67, 58)
        Me.BtnEliminarfila.TabIndex = 25
        Me.BtnEliminarfila.UseVisualStyleBackColor = True
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnImprimir.FlatAppearance.BorderSize = 0
        Me.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImprimir.Image = CType(resources.GetObject("BtnImprimir.Image"), System.Drawing.Image)
        Me.BtnImprimir.Location = New System.Drawing.Point(1165, 582)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(80, 58)
        Me.BtnImprimir.TabIndex = 26
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(985, 643)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Eliminar fila"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(1175, 643)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Imprimir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(861, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'FrmPresupuestoVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1278, 719)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.BtnEliminarfila)
        Me.Controls.Add(Me.txtTotalUtilidadbruta)
        Me.Controls.Add(Me.LblTotalUtilidadBruta)
        Me.Controls.Add(Me.txtTotalgastoPublicidad)
        Me.Controls.Add(Me.LblTotalgastopublicidad)
        Me.Controls.Add(Me.txtTotalPublicidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTotalgastoVentas)
        Me.Controls.Add(Me.LblTotalGastoVentas)
        Me.Controls.Add(Me.txtTotalCostodeventas)
        Me.Controls.Add(Me.LblCostodeventas)
        Me.Controls.Add(Me.LblTotalingresosNetos)
        Me.Controls.Add(Me.txtTotalingresosNetos)
        Me.Controls.Add(Me.txtTotaldevoluciones)
        Me.Controls.Add(Me.LblTotalDevoluciones)
        Me.Controls.Add(Me.LblIngresosbrutostotales)
        Me.Controls.Add(Me.txtTotalingresosbrutos)
        Me.Controls.Add(Me.lblTotalpreciounitario)
        Me.Controls.Add(Me.txttotalpreciounitario)
        Me.Controls.Add(Me.txtunidadesproyectadastotal)
        Me.Controls.Add(Me.LblUnidadesproyectadasTotal)
        Me.Controls.Add(Me.GrpPresupuestodeventas)
        Me.Controls.Add(Me.DtgPresupuestodeventas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPresupuestoVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presupuesto de ventas:"
        CType(Me.DtgPresupuestodeventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPresupuestodeventas.ResumeLayout(False)
        Me.GrpPresupuestodeventas.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DtgPresupuestodeventas As DataGridView
    Friend WithEvents GrpPresupuestodeventas As GroupBox
    Friend WithEvents LblPublicidad As Label
    Friend WithEvents LblGastoventas As Label
    Friend WithEvents LblPrecioUnitario As Label
    Friend WithEvents TxtNombreProducto As TextBox
    Friend WithEvents LblProducto As Label
    Friend WithEvents LblIngresarDatos As Label
    Friend WithEvents LblCordoba As Label
    Friend WithEvents txtPreciounitario As TextBox
    Friend WithEvents txtPublicidadCsUnidad As TextBox
    Friend WithEvents TxtGastoVentas As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents txtunidaesproyectadas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LblUnidadesproyectadasTotal As Label
    Friend WithEvents txtunidadesproyectadastotal As TextBox
    Friend WithEvents txttotalpreciounitario As TextBox
    Friend WithEvents lblTotalpreciounitario As Label
    Friend WithEvents txtTotalingresosbrutos As TextBox
    Friend WithEvents LblIngresosbrutostotales As Label
    Friend WithEvents LblTotalDevoluciones As Label
    Friend WithEvents txtTotaldevoluciones As TextBox
    Friend WithEvents txtTotalingresosNetos As TextBox
    Friend WithEvents LblTotalingresosNetos As Label
    Friend WithEvents LblCostodeventas As Label
    Friend WithEvents txtTotalCostodeventas As TextBox
    Friend WithEvents LblTotalGastoVentas As Label
    Friend WithEvents txtTotalgastoVentas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotalPublicidad As TextBox
    Friend WithEvents LblTotalgastopublicidad As Label
    Friend WithEvents txtTotalgastoPublicidad As TextBox
    Friend WithEvents LblTotalUtilidadBruta As Label
    Friend WithEvents txtTotalUtilidadbruta As TextBox
    Friend WithEvents BtnEliminarfila As Button
    Friend WithEvents ColProducto As DataGridViewTextBoxColumn
    Friend WithEvents ColUnidadesProyectadas As DataGridViewTextBoxColumn
    Friend WithEvents ColPrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents ColIngresosBrutos As DataGridViewTextBoxColumn
    Friend WithEvents ColDevoluciones As DataGridViewTextBoxColumn
    Friend WithEvents ColIngresosnetos As DataGridViewTextBoxColumn
    Friend WithEvents ColCostoVentas As DataGridViewTextBoxColumn
    Friend WithEvents ColGastoVentas As DataGridViewTextBoxColumn
    Friend WithEvents ColPublicidad As DataGridViewTextBoxColumn
    Friend WithEvents ColGastopublicidad As DataGridViewTextBoxColumn
    Friend WithEvents ColUtilidadBruta As DataGridViewTextBoxColumn
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
