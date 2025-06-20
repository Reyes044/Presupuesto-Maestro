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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        CType(Me.DtgPresupuestodeventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPresupuestodeventas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(492, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Presupuesto de ventas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DtgPresupuestodeventas
        '
        Me.DtgPresupuestodeventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgPresupuestodeventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColProducto, Me.ColUnidadesProyectadas, Me.ColPrecioUnitario, Me.ColIngresosBrutos, Me.ColDevoluciones, Me.ColIngresosnetos, Me.ColCostoVentas, Me.ColGastoVentas, Me.ColPublicidad, Me.ColGastopublicidad, Me.ColUtilidadBruta})
        Me.DtgPresupuestodeventas.Location = New System.Drawing.Point(2, 196)
        Me.DtgPresupuestodeventas.Name = "DtgPresupuestodeventas"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgPresupuestodeventas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DtgPresupuestodeventas.RowHeadersWidth = 51
        Me.DtgPresupuestodeventas.Size = New System.Drawing.Size(1129, 218)
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
        DataGridViewCellStyle1.Format = "C$"
        DataGridViewCellStyle1.NullValue = "0"
        Me.ColPrecioUnitario.DefaultCellStyle = DataGridViewCellStyle1
        Me.ColPrecioUnitario.HeaderText = "Precio Unitario (C$)"
        Me.ColPrecioUnitario.MinimumWidth = 6
        Me.ColPrecioUnitario.Name = "ColPrecioUnitario"
        Me.ColPrecioUnitario.Width = 125
        '
        'ColIngresosBrutos
        '
        Me.ColIngresosBrutos.HeaderText = "Ingresos brutos (C$)"
        Me.ColIngresosBrutos.MinimumWidth = 6
        Me.ColIngresosBrutos.Name = "ColIngresosBrutos"
        Me.ColIngresosBrutos.Width = 125
        '
        'ColDevoluciones
        '
        Me.ColDevoluciones.HeaderText = "Devoluciones (5%)"
        Me.ColDevoluciones.MinimumWidth = 6
        Me.ColDevoluciones.Name = "ColDevoluciones"
        Me.ColDevoluciones.Width = 125
        '
        'ColIngresosnetos
        '
        Me.ColIngresosnetos.HeaderText = "Ingresos Netos"
        Me.ColIngresosnetos.MinimumWidth = 6
        Me.ColIngresosnetos.Name = "ColIngresosnetos"
        Me.ColIngresosnetos.Width = 125
        '
        'ColCostoVentas
        '
        Me.ColCostoVentas.HeaderText = "Costo de ventas (40%)"
        Me.ColCostoVentas.MinimumWidth = 6
        Me.ColCostoVentas.Name = "ColCostoVentas"
        Me.ColCostoVentas.Width = 125
        '
        'ColGastoVentas
        '
        Me.ColGastoVentas.HeaderText = "Gasto de ventas (C$)"
        Me.ColGastoVentas.MinimumWidth = 6
        Me.ColGastoVentas.Name = "ColGastoVentas"
        Me.ColGastoVentas.Width = 125
        '
        'ColPublicidad
        '
        Me.ColPublicidad.HeaderText = "Publicidad (C$/unidad)"
        Me.ColPublicidad.MinimumWidth = 6
        Me.ColPublicidad.Name = "ColPublicidad"
        Me.ColPublicidad.Width = 125
        '
        'ColGastopublicidad
        '
        Me.ColGastopublicidad.HeaderText = "Gasto de Publicidad"
        Me.ColGastopublicidad.MinimumWidth = 6
        Me.ColGastopublicidad.Name = "ColGastopublicidad"
        Me.ColGastopublicidad.Width = 125
        '
        'ColUtilidadBruta
        '
        Me.ColUtilidadBruta.HeaderText = "Utilidad Bruta"
        Me.ColUtilidadBruta.MinimumWidth = 6
        Me.ColUtilidadBruta.Name = "ColUtilidadBruta"
        Me.ColUtilidadBruta.Width = 125
        '
        'GrpPresupuestodeventas
        '
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
        Me.GrpPresupuestodeventas.Location = New System.Drawing.Point(2, 1)
        Me.GrpPresupuestodeventas.Name = "GrpPresupuestodeventas"
        Me.GrpPresupuestodeventas.Size = New System.Drawing.Size(1129, 189)
        Me.GrpPresupuestodeventas.TabIndex = 2
        Me.GrpPresupuestodeventas.TabStop = False
        '
        'txtunidaesproyectadas
        '
        Me.txtunidaesproyectadas.Location = New System.Drawing.Point(1022, 81)
        Me.txtunidaesproyectadas.Name = "txtunidaesproyectadas"
        Me.txtunidaesproyectadas.Size = New System.Drawing.Size(101, 20)
        Me.txtunidaesproyectadas.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(842, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Unidades proyectadas"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(999, 122)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(124, 42)
        Me.BtnAgregar.TabIndex = 11
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'txtPublicidadCsUnidad
        '
        Me.txtPublicidadCsUnidad.Location = New System.Drawing.Point(664, 128)
        Me.txtPublicidadCsUnidad.Name = "txtPublicidadCsUnidad"
        Me.txtPublicidadCsUnidad.Size = New System.Drawing.Size(149, 20)
        Me.txtPublicidadCsUnidad.TabIndex = 10
        '
        'TxtGastoVentas
        '
        Me.TxtGastoVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGastoVentas.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtGastoVentas.Location = New System.Drawing.Point(664, 81)
        Me.TxtGastoVentas.Name = "TxtGastoVentas"
        Me.TxtGastoVentas.Size = New System.Drawing.Size(149, 20)
        Me.TxtGastoVentas.TabIndex = 9
        Me.TxtGastoVentas.Text = "Ingrese el gasto de ventas"
        '
        'LblCordoba
        '
        Me.LblCordoba.AutoSize = True
        Me.LblCordoba.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCordoba.Location = New System.Drawing.Point(227, 122)
        Me.LblCordoba.Name = "LblCordoba"
        Me.LblCordoba.Size = New System.Drawing.Size(29, 20)
        Me.LblCordoba.TabIndex = 8
        Me.LblCordoba.Text = "C$"
        '
        'txtPreciounitario
        '
        Me.txtPreciounitario.Enabled = False
        Me.txtPreciounitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreciounitario.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtPreciounitario.Location = New System.Drawing.Point(129, 124)
        Me.txtPreciounitario.Name = "txtPreciounitario"
        Me.txtPreciounitario.Size = New System.Drawing.Size(92, 20)
        Me.txtPreciounitario.TabIndex = 7
        Me.txtPreciounitario.Text = "Ingrese el precio"
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreProducto.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.TxtNombreProducto.Location = New System.Drawing.Point(177, 81)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(292, 20)
        Me.TxtNombreProducto.TabIndex = 6
        Me.TxtNombreProducto.Text = "Ingrese el nombre del producto"
        '
        'LblProducto
        '
        Me.LblProducto.AutoSize = True
        Me.LblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProducto.Location = New System.Drawing.Point(10, 79)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(161, 20)
        Me.LblProducto.TabIndex = 5
        Me.LblProducto.Text = "Nombre del producto:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblIngresarDatos
        '
        Me.LblIngresarDatos.AutoSize = True
        Me.LblIngresarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIngresarDatos.Location = New System.Drawing.Point(173, 15)
        Me.LblIngresarDatos.Name = "LblIngresarDatos"
        Me.LblIngresarDatos.Size = New System.Drawing.Size(235, 20)
        Me.LblIngresarDatos.TabIndex = 4
        Me.LblIngresarDatos.Text = "Ingrese los siguientes datos"
        '
        'LblPublicidad
        '
        Me.LblPublicidad.AutoSize = True
        Me.LblPublicidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPublicidad.Location = New System.Drawing.Point(487, 126)
        Me.LblPublicidad.Name = "LblPublicidad"
        Me.LblPublicidad.Size = New System.Drawing.Size(171, 20)
        Me.LblPublicidad.TabIndex = 3
        Me.LblPublicidad.Text = "Publicidad (C$/unidad):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblGastoventas
        '
        Me.LblGastoventas.AutoSize = True
        Me.LblGastoventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGastoventas.Location = New System.Drawing.Point(494, 79)
        Me.LblGastoventas.Name = "LblGastoventas"
        Me.LblGastoventas.Size = New System.Drawing.Size(164, 20)
        Me.LblGastoventas.TabIndex = 2
        Me.LblGastoventas.Text = "Gasto de ventas (C$):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblPrecioUnitario
        '
        Me.LblPrecioUnitario.AutoSize = True
        Me.LblPrecioUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecioUnitario.Location = New System.Drawing.Point(10, 126)
        Me.LblPrecioUnitario.Name = "LblPrecioUnitario"
        Me.LblPrecioUnitario.Size = New System.Drawing.Size(113, 20)
        Me.LblPrecioUnitario.TabIndex = 1
        Me.LblPrecioUnitario.Text = "Precio unitario:"
        '
        'LblUnidadesproyectadasTotal
        '
        Me.LblUnidadesproyectadasTotal.AutoSize = True
        Me.LblUnidadesproyectadasTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUnidadesproyectadasTotal.Location = New System.Drawing.Point(-2, 439)
        Me.LblUnidadesproyectadasTotal.Name = "LblUnidadesproyectadasTotal"
        Me.LblUnidadesproyectadasTotal.Size = New System.Drawing.Size(207, 60)
        Me.LblUnidadesproyectadasTotal.TabIndex = 3
        Me.LblUnidadesproyectadasTotal.Text = "Unidades proyectadas total:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtunidadesproyectadastotal
        '
        Me.txtunidadesproyectadastotal.Location = New System.Drawing.Point(211, 441)
        Me.txtunidadesproyectadastotal.Name = "txtunidadesproyectadastotal"
        Me.txtunidadesproyectadastotal.Size = New System.Drawing.Size(159, 20)
        Me.txtunidadesproyectadastotal.TabIndex = 4
        '
        'txttotalpreciounitario
        '
        Me.txttotalpreciounitario.Location = New System.Drawing.Point(211, 486)
        Me.txttotalpreciounitario.Name = "txttotalpreciounitario"
        Me.txttotalpreciounitario.Size = New System.Drawing.Size(159, 20)
        Me.txttotalpreciounitario.TabIndex = 7
        '
        'lblTotalpreciounitario
        '
        Me.lblTotalpreciounitario.AutoSize = True
        Me.lblTotalpreciounitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalpreciounitario.Location = New System.Drawing.Point(53, 484)
        Me.lblTotalpreciounitario.Name = "lblTotalpreciounitario"
        Me.lblTotalpreciounitario.Size = New System.Drawing.Size(152, 20)
        Me.lblTotalpreciounitario.TabIndex = 8
        Me.lblTotalpreciounitario.Text = "Total predio unitario:"
        '
        'txtTotalingresosbrutos
        '
        Me.txtTotalingresosbrutos.Location = New System.Drawing.Point(211, 524)
        Me.txtTotalingresosbrutos.Name = "txtTotalingresosbrutos"
        Me.txtTotalingresosbrutos.Size = New System.Drawing.Size(159, 20)
        Me.txtTotalingresosbrutos.TabIndex = 9
        '
        'LblIngresosbrutostotales
        '
        Me.LblIngresosbrutostotales.AutoSize = True
        Me.LblIngresosbrutostotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIngresosbrutostotales.Location = New System.Drawing.Point(44, 524)
        Me.LblIngresosbrutostotales.Name = "LblIngresosbrutostotales"
        Me.LblIngresosbrutostotales.Size = New System.Drawing.Size(161, 20)
        Me.LblIngresosbrutostotales.TabIndex = 10
        Me.LblIngresosbrutostotales.Text = "Total ingresos brutos:"
        '
        'LblTotalDevoluciones
        '
        Me.LblTotalDevoluciones.AutoSize = True
        Me.LblTotalDevoluciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalDevoluciones.Location = New System.Drawing.Point(61, 560)
        Me.LblTotalDevoluciones.Name = "LblTotalDevoluciones"
        Me.LblTotalDevoluciones.Size = New System.Drawing.Size(144, 20)
        Me.LblTotalDevoluciones.TabIndex = 11
        Me.LblTotalDevoluciones.Text = "Total devoluciones:"
        '
        'txtTotaldevoluciones
        '
        Me.txtTotaldevoluciones.Location = New System.Drawing.Point(211, 562)
        Me.txtTotaldevoluciones.Name = "txtTotaldevoluciones"
        Me.txtTotaldevoluciones.Size = New System.Drawing.Size(159, 20)
        Me.txtTotaldevoluciones.TabIndex = 12
        '
        'txtTotalingresosNetos
        '
        Me.txtTotalingresosNetos.Location = New System.Drawing.Point(211, 598)
        Me.txtTotalingresosNetos.Name = "txtTotalingresosNetos"
        Me.txtTotalingresosNetos.Size = New System.Drawing.Size(159, 20)
        Me.txtTotalingresosNetos.TabIndex = 13
        '
        'LblTotalingresosNetos
        '
        Me.LblTotalingresosNetos.AutoSize = True
        Me.LblTotalingresosNetos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalingresosNetos.Location = New System.Drawing.Point(47, 598)
        Me.LblTotalingresosNetos.Name = "LblTotalingresosNetos"
        Me.LblTotalingresosNetos.Size = New System.Drawing.Size(158, 20)
        Me.LblTotalingresosNetos.TabIndex = 14
        Me.LblTotalingresosNetos.Text = "Total Ingresos netos:"
        '
        'LblCostodeventas
        '
        Me.LblCostodeventas.AutoSize = True
        Me.LblCostodeventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCostodeventas.Location = New System.Drawing.Point(465, 439)
        Me.LblCostodeventas.Name = "LblCostodeventas"
        Me.LblCostodeventas.Size = New System.Drawing.Size(164, 20)
        Me.LblCostodeventas.TabIndex = 15
        Me.LblCostodeventas.Text = "Total costo de ventas:"
        '
        'txtTotalCostodeventas
        '
        Me.txtTotalCostodeventas.Location = New System.Drawing.Point(635, 441)
        Me.txtTotalCostodeventas.Name = "txtTotalCostodeventas"
        Me.txtTotalCostodeventas.Size = New System.Drawing.Size(159, 20)
        Me.txtTotalCostodeventas.TabIndex = 16
        '
        'LblTotalGastoVentas
        '
        Me.LblTotalGastoVentas.AutoSize = True
        Me.LblTotalGastoVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalGastoVentas.Location = New System.Drawing.Point(465, 484)
        Me.LblTotalGastoVentas.Name = "LblTotalGastoVentas"
        Me.LblTotalGastoVentas.Size = New System.Drawing.Size(165, 20)
        Me.LblTotalGastoVentas.TabIndex = 17
        Me.LblTotalGastoVentas.Text = "Total gasto de ventas:"
        '
        'txtTotalgastoVentas
        '
        Me.txtTotalgastoVentas.Location = New System.Drawing.Point(635, 484)
        Me.txtTotalgastoVentas.Name = "txtTotalgastoVentas"
        Me.txtTotalgastoVentas.Size = New System.Drawing.Size(159, 20)
        Me.txtTotalgastoVentas.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(465, 524)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 40)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Total Publicidad: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(C$/Unidad)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtTotalPublicidad
        '
        Me.txtTotalPublicidad.Location = New System.Drawing.Point(635, 526)
        Me.txtTotalPublicidad.Name = "txtTotalPublicidad"
        Me.txtTotalPublicidad.Size = New System.Drawing.Size(159, 20)
        Me.txtTotalPublicidad.TabIndex = 20
        '
        'LblTotalgastopublicidad
        '
        Me.LblTotalgastopublicidad.AutoSize = True
        Me.LblTotalgastopublicidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalgastopublicidad.Location = New System.Drawing.Point(465, 578)
        Me.LblTotalgastopublicidad.Name = "LblTotalgastopublicidad"
        Me.LblTotalgastopublicidad.Size = New System.Drawing.Size(114, 60)
        Me.LblTotalgastopublicidad.TabIndex = 21
        Me.LblTotalgastopublicidad.Text = "Total gasto de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "publicidad:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtTotalgastoPublicidad
        '
        Me.txtTotalgastoPublicidad.Location = New System.Drawing.Point(635, 578)
        Me.txtTotalgastoPublicidad.Name = "txtTotalgastoPublicidad"
        Me.txtTotalgastoPublicidad.Size = New System.Drawing.Size(159, 20)
        Me.txtTotalgastoPublicidad.TabIndex = 22
        '
        'LblTotalUtilidadBruta
        '
        Me.LblTotalUtilidadBruta.AutoSize = True
        Me.LblTotalUtilidadBruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalUtilidadBruta.Location = New System.Drawing.Point(848, 441)
        Me.LblTotalUtilidadBruta.Name = "LblTotalUtilidadBruta"
        Me.LblTotalUtilidadBruta.Size = New System.Drawing.Size(143, 20)
        Me.LblTotalUtilidadBruta.TabIndex = 23
        Me.LblTotalUtilidadBruta.Text = "Total utilidad bruta:"
        '
        'txtTotalUtilidadbruta
        '
        Me.txtTotalUtilidadbruta.Location = New System.Drawing.Point(987, 439)
        Me.txtTotalUtilidadbruta.Name = "txtTotalUtilidadbruta"
        Me.txtTotalUtilidadbruta.Size = New System.Drawing.Size(144, 20)
        Me.txtTotalUtilidadbruta.TabIndex = 24
        '
        'BtnEliminarfila
        '
        Me.BtnEliminarfila.Location = New System.Drawing.Point(986, 560)
        Me.BtnEliminarfila.Name = "BtnEliminarfila"
        Me.BtnEliminarfila.Size = New System.Drawing.Size(139, 48)
        Me.BtnEliminarfila.TabIndex = 25
        Me.BtnEliminarfila.Text = "Eliminar fila"
        Me.BtnEliminarfila.UseVisualStyleBackColor = True
        '
        'FrmPresupuestoVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1318, 644)
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
        Me.Name = "FrmPresupuestoVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presupuesto de ventas:"
        CType(Me.DtgPresupuestodeventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPresupuestodeventas.ResumeLayout(False)
        Me.GrpPresupuestodeventas.PerformLayout()
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
End Class
