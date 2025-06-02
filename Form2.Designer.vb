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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtunidaesproyectadas = New System.Windows.Forms.TextBox()
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
        Me.DtgPresupuestodeventas.Size = New System.Drawing.Size(1129, 218)
        Me.DtgPresupuestodeventas.TabIndex = 1
        '
        'ColProducto
        '
        Me.ColProducto.HeaderText = "Producto"
        Me.ColProducto.Name = "ColProducto"
        '
        'ColUnidadesProyectadas
        '
        Me.ColUnidadesProyectadas.HeaderText = "Unidades Proyectadas"
        Me.ColUnidadesProyectadas.Name = "ColUnidadesProyectadas"
        '
        'ColPrecioUnitario
        '
        DataGridViewCellStyle1.Format = "C$"
        DataGridViewCellStyle1.NullValue = "0"
        Me.ColPrecioUnitario.DefaultCellStyle = DataGridViewCellStyle1
        Me.ColPrecioUnitario.HeaderText = "Precio Unitario (C$)"
        Me.ColPrecioUnitario.Name = "ColPrecioUnitario"
        '
        'ColIngresosBrutos
        '
        Me.ColIngresosBrutos.HeaderText = "Ingresos brutos (C$)"
        Me.ColIngresosBrutos.Name = "ColIngresosBrutos"
        '
        'ColDevoluciones
        '
        Me.ColDevoluciones.HeaderText = "Devoluciones (5%)"
        Me.ColDevoluciones.Name = "ColDevoluciones"
        '
        'ColIngresosnetos
        '
        Me.ColIngresosnetos.HeaderText = "Ingresos Netos"
        Me.ColIngresosnetos.Name = "ColIngresosnetos"
        '
        'ColCostoVentas
        '
        Me.ColCostoVentas.HeaderText = "Costo de ventas (40%)"
        Me.ColCostoVentas.Name = "ColCostoVentas"
        '
        'ColGastoVentas
        '
        Me.ColGastoVentas.HeaderText = "Gasto de ventas (C$)"
        Me.ColGastoVentas.Name = "ColGastoVentas"
        '
        'ColPublicidad
        '
        Me.ColPublicidad.HeaderText = "Publicidad (C$/unidad)"
        Me.ColPublicidad.Name = "ColPublicidad"
        '
        'ColGastopublicidad
        '
        Me.ColGastopublicidad.HeaderText = "Gasto de Publicidad"
        Me.ColGastopublicidad.Name = "ColGastopublicidad"
        '
        'ColUtilidadBruta
        '
        Me.ColUtilidadBruta.HeaderText = "Utilidad Bruta"
        Me.ColUtilidadBruta.Name = "ColUtilidadBruta"
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
        Me.TxtGastoVentas.Location = New System.Drawing.Point(664, 81)
        Me.TxtGastoVentas.Name = "TxtGastoVentas"
        Me.TxtGastoVentas.Size = New System.Drawing.Size(149, 20)
        Me.TxtGastoVentas.TabIndex = 9
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
        Me.LblIngresarDatos.Location = New System.Drawing.Point(189, 16)
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
        'txtunidaesproyectadas
        '
        Me.txtunidaesproyectadas.Location = New System.Drawing.Point(1022, 81)
        Me.txtunidaesproyectadas.Name = "txtunidaesproyectadas"
        Me.txtunidaesproyectadas.Size = New System.Drawing.Size(101, 20)
        Me.txtunidaesproyectadas.TabIndex = 13
        '
        'FrmPresupuestoVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 450)
        Me.Controls.Add(Me.GrpPresupuestodeventas)
        Me.Controls.Add(Me.DtgPresupuestodeventas)
        Me.Name = "FrmPresupuestoVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presupuesto de ventas"
        CType(Me.DtgPresupuestodeventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPresupuestodeventas.ResumeLayout(False)
        Me.GrpPresupuestodeventas.PerformLayout()
        Me.ResumeLayout(False)

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
End Class
