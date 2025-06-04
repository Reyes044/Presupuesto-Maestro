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
        CType(Me.DtgPresupuestodeventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPresupuestodeventas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(656, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Presupuesto de ventas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DtgPresupuestodeventas
        '
        Me.DtgPresupuestodeventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgPresupuestodeventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColProducto, Me.ColUnidadesProyectadas, Me.ColPrecioUnitario, Me.ColIngresosBrutos, Me.ColDevoluciones, Me.ColIngresosnetos, Me.ColCostoVentas, Me.ColGastoVentas, Me.ColPublicidad, Me.ColGastopublicidad, Me.ColUtilidadBruta})
        Me.DtgPresupuestodeventas.Location = New System.Drawing.Point(3, 241)
        Me.DtgPresupuestodeventas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.DtgPresupuestodeventas.Size = New System.Drawing.Size(1505, 268)
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
        Me.GrpPresupuestodeventas.Location = New System.Drawing.Point(3, 1)
        Me.GrpPresupuestodeventas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GrpPresupuestodeventas.Name = "GrpPresupuestodeventas"
        Me.GrpPresupuestodeventas.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GrpPresupuestodeventas.Size = New System.Drawing.Size(1505, 233)
        Me.GrpPresupuestodeventas.TabIndex = 2
        Me.GrpPresupuestodeventas.TabStop = False
        '
        'txtunidaesproyectadas
        '
        Me.txtunidaesproyectadas.Location = New System.Drawing.Point(1363, 100)
        Me.txtunidaesproyectadas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtunidaesproyectadas.Name = "txtunidaesproyectadas"
        Me.txtunidaesproyectadas.Size = New System.Drawing.Size(133, 22)
        Me.txtunidaesproyectadas.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1123, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Unidades proyectadas"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(1332, 150)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(165, 52)
        Me.BtnAgregar.TabIndex = 11
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'txtPublicidadCsUnidad
        '
        Me.txtPublicidadCsUnidad.Location = New System.Drawing.Point(885, 158)
        Me.txtPublicidadCsUnidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPublicidadCsUnidad.Name = "txtPublicidadCsUnidad"
        Me.txtPublicidadCsUnidad.Size = New System.Drawing.Size(197, 22)
        Me.txtPublicidadCsUnidad.TabIndex = 10
        '
        'TxtGastoVentas
        '
        Me.TxtGastoVentas.Location = New System.Drawing.Point(885, 100)
        Me.TxtGastoVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtGastoVentas.Name = "TxtGastoVentas"
        Me.TxtGastoVentas.Size = New System.Drawing.Size(197, 22)
        Me.TxtGastoVentas.TabIndex = 9
        '
        'LblCordoba
        '
        Me.LblCordoba.AutoSize = True
        Me.LblCordoba.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCordoba.Location = New System.Drawing.Point(303, 150)
        Me.LblCordoba.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCordoba.Name = "LblCordoba"
        Me.LblCordoba.Size = New System.Drawing.Size(38, 25)
        Me.LblCordoba.TabIndex = 8
        Me.LblCordoba.Text = "C$"
        '
        'txtPreciounitario
        '
        Me.txtPreciounitario.Enabled = False
        Me.txtPreciounitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreciounitario.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtPreciounitario.Location = New System.Drawing.Point(172, 153)
        Me.txtPreciounitario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPreciounitario.Name = "txtPreciounitario"
        Me.txtPreciounitario.Size = New System.Drawing.Size(121, 23)
        Me.txtPreciounitario.TabIndex = 7
        Me.txtPreciounitario.Text = "Ingrese el precio"
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreProducto.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.TxtNombreProducto.Location = New System.Drawing.Point(236, 100)
        Me.TxtNombreProducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(388, 23)
        Me.TxtNombreProducto.TabIndex = 6
        Me.TxtNombreProducto.Text = "Ingrese el nombre del producto"
        '
        'LblProducto
        '
        Me.LblProducto.AutoSize = True
        Me.LblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProducto.Location = New System.Drawing.Point(13, 97)
        Me.LblProducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(199, 25)
        Me.LblProducto.TabIndex = 5
        Me.LblProducto.Text = "Nombre del producto:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblIngresarDatos
        '
        Me.LblIngresarDatos.AutoSize = True
        Me.LblIngresarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIngresarDatos.Location = New System.Drawing.Point(231, 18)
        Me.LblIngresarDatos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblIngresarDatos.Name = "LblIngresarDatos"
        Me.LblIngresarDatos.Size = New System.Drawing.Size(281, 25)
        Me.LblIngresarDatos.TabIndex = 4
        Me.LblIngresarDatos.Text = "Ingrese los siguientes datos"
        '
        'LblPublicidad
        '
        Me.LblPublicidad.AutoSize = True
        Me.LblPublicidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPublicidad.Location = New System.Drawing.Point(649, 155)
        Me.LblPublicidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPublicidad.Name = "LblPublicidad"
        Me.LblPublicidad.Size = New System.Drawing.Size(218, 25)
        Me.LblPublicidad.TabIndex = 3
        Me.LblPublicidad.Text = "Publicidad (C$/unidad):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblGastoventas
        '
        Me.LblGastoventas.AutoSize = True
        Me.LblGastoventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGastoventas.Location = New System.Drawing.Point(659, 97)
        Me.LblGastoventas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblGastoventas.Name = "LblGastoventas"
        Me.LblGastoventas.Size = New System.Drawing.Size(205, 25)
        Me.LblGastoventas.TabIndex = 2
        Me.LblGastoventas.Text = "Gasto de ventas (C$):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblPrecioUnitario
        '
        Me.LblPrecioUnitario.AutoSize = True
        Me.LblPrecioUnitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecioUnitario.Location = New System.Drawing.Point(13, 155)
        Me.LblPrecioUnitario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPrecioUnitario.Name = "LblPrecioUnitario"
        Me.LblPrecioUnitario.Size = New System.Drawing.Size(141, 25)
        Me.LblPrecioUnitario.TabIndex = 1
        Me.LblPrecioUnitario.Text = "Precio unitario:"
        '
        'FrmPresupuestoVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1537, 554)
        Me.Controls.Add(Me.GrpPresupuestodeventas)
        Me.Controls.Add(Me.DtgPresupuestodeventas)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
