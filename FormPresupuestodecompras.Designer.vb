<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPresupuestodecompras
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIngreselosDatos = New System.Windows.Forms.Label()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.GrpPresupuestodecompras = New System.Windows.Forms.GroupBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.LblCostounitariototal = New System.Windows.Forms.Label()
        Me.txtCostounitariototal = New System.Windows.Forms.TextBox()
        Me.LblCostosAdicionales = New System.Windows.Forms.Label()
        Me.txtCostosAdicionales = New System.Windows.Forms.TextBox()
        Me.LblInventarioInicial = New System.Windows.Forms.Label()
        Me.txtInventarioInicial = New System.Windows.Forms.TextBox()
        Me.LblCostoUnidad = New System.Windows.Forms.Label()
        Me.txtCostoUnidad = New System.Windows.Forms.TextBox()
        Me.LblInventarioFinalDeseado = New System.Windows.Forms.Label()
        Me.txtInventarioFinalDeseado = New System.Windows.Forms.TextBox()
        Me.LblUnidadesNecesarias = New System.Windows.Forms.Label()
        Me.txtUnidadesNecesarias = New System.Windows.Forms.TextBox()
        Me.LblMaterial = New System.Windows.Forms.Label()
        Me.DtgPresupuestoCompras = New System.Windows.Forms.DataGridView()
        Me.ColMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUnidadesnecesarias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColInventariofinaldeseado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colinventarioinicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUnidadescomprar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCostoporunidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colcostototaldecompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCostoAdicionales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colcostounitariototal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPagototal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrpPresupuestodecompras.SuspendLayout()
        CType(Me.DtgPresupuestoCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(374, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Presupuesto de compras"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblIngreselosDatos
        '
        Me.lblIngreselosDatos.AutoSize = True
        Me.lblIngreselosDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreselosDatos.Location = New System.Drawing.Point(78, 16)
        Me.lblIngreselosDatos.Name = "lblIngreselosDatos"
        Me.lblIngreselosDatos.Size = New System.Drawing.Size(125, 18)
        Me.lblIngreselosDatos.TabIndex = 2
        Me.lblIngreselosDatos.Text = "Ingrese los datos:"
        '
        'txtMaterial
        '
        Me.txtMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterial.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtMaterial.Location = New System.Drawing.Point(78, 72)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(125, 20)
        Me.txtMaterial.TabIndex = 3
        Me.txtMaterial.Text = "Escriba el material"
        '
        'GrpPresupuestodecompras
        '
        Me.GrpPresupuestodecompras.Controls.Add(Me.BtnAgregar)
        Me.GrpPresupuestodecompras.Controls.Add(Me.LblCostounitariototal)
        Me.GrpPresupuestodecompras.Controls.Add(Me.txtCostounitariototal)
        Me.GrpPresupuestodecompras.Controls.Add(Me.LblCostosAdicionales)
        Me.GrpPresupuestodecompras.Controls.Add(Me.txtCostosAdicionales)
        Me.GrpPresupuestodecompras.Controls.Add(Me.LblInventarioInicial)
        Me.GrpPresupuestodecompras.Controls.Add(Me.txtInventarioInicial)
        Me.GrpPresupuestodecompras.Controls.Add(Me.LblCostoUnidad)
        Me.GrpPresupuestodecompras.Controls.Add(Me.txtCostoUnidad)
        Me.GrpPresupuestodecompras.Controls.Add(Me.LblInventarioFinalDeseado)
        Me.GrpPresupuestodecompras.Controls.Add(Me.txtInventarioFinalDeseado)
        Me.GrpPresupuestodecompras.Controls.Add(Me.LblUnidadesNecesarias)
        Me.GrpPresupuestodecompras.Controls.Add(Me.txtUnidadesNecesarias)
        Me.GrpPresupuestodecompras.Controls.Add(Me.LblMaterial)
        Me.GrpPresupuestodecompras.Controls.Add(Me.Label1)
        Me.GrpPresupuestodecompras.Controls.Add(Me.txtMaterial)
        Me.GrpPresupuestodecompras.Controls.Add(Me.lblIngreselosDatos)
        Me.GrpPresupuestodecompras.Location = New System.Drawing.Point(3, 4)
        Me.GrpPresupuestodecompras.Name = "GrpPresupuestodecompras"
        Me.GrpPresupuestodecompras.Size = New System.Drawing.Size(1090, 205)
        Me.GrpPresupuestodecompras.TabIndex = 4
        Me.GrpPresupuestodecompras.TabStop = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(915, 123)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(105, 55)
        Me.BtnAgregar.TabIndex = 17
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'LblCostounitariototal
        '
        Me.LblCostounitariototal.AutoSize = True
        Me.LblCostounitariototal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCostounitariototal.Location = New System.Drawing.Point(761, 72)
        Me.LblCostounitariototal.Name = "LblCostounitariototal"
        Me.LblCostounitariototal.Size = New System.Drawing.Size(166, 18)
        Me.LblCostounitariototal.TabIndex = 16
        Me.LblCostounitariototal.Text = "Costo unitario total (C$)"
        '
        'txtCostounitariototal
        '
        Me.txtCostounitariototal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostounitariototal.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtCostounitariototal.Location = New System.Drawing.Point(928, 73)
        Me.txtCostounitariototal.Name = "txtCostounitariototal"
        Me.txtCostounitariototal.Size = New System.Drawing.Size(156, 20)
        Me.txtCostounitariototal.TabIndex = 15
        Me.txtCostounitariototal.Text = "Ingrese el costo unitario total"
        '
        'LblCostosAdicionales
        '
        Me.LblCostosAdicionales.AutoSize = True
        Me.LblCostosAdicionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCostosAdicionales.Location = New System.Drawing.Point(404, 157)
        Me.LblCostosAdicionales.Name = "LblCostosAdicionales"
        Me.LblCostosAdicionales.Size = New System.Drawing.Size(219, 18)
        Me.LblCostosAdicionales.TabIndex = 14
        Me.LblCostosAdicionales.Text = "Costos adicionales (C$/unidad):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtCostosAdicionales
        '
        Me.txtCostosAdicionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostosAdicionales.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtCostosAdicionales.Location = New System.Drawing.Point(629, 158)
        Me.txtCostosAdicionales.Name = "txtCostosAdicionales"
        Me.txtCostosAdicionales.Size = New System.Drawing.Size(153, 20)
        Me.txtCostosAdicionales.TabIndex = 13
        Me.txtCostosAdicionales.Text = "Ingrese los costos adicionales"
        '
        'LblInventarioInicial
        '
        Me.LblInventarioInicial.AutoSize = True
        Me.LblInventarioInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInventarioInicial.Location = New System.Drawing.Point(404, 72)
        Me.LblInventarioInicial.Name = "LblInventarioInicial"
        Me.LblInventarioInicial.Size = New System.Drawing.Size(115, 18)
        Me.LblInventarioInicial.TabIndex = 12
        Me.LblInventarioInicial.Text = "Inventario inicial:"
        '
        'txtInventarioInicial
        '
        Me.txtInventarioInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInventarioInicial.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtInventarioInicial.Location = New System.Drawing.Point(525, 73)
        Me.txtInventarioInicial.Name = "txtInventarioInicial"
        Me.txtInventarioInicial.Size = New System.Drawing.Size(125, 20)
        Me.txtInventarioInicial.TabIndex = 11
        Me.txtInventarioInicial.Text = "Ingrese inventario inicial"
        '
        'LblCostoUnidad
        '
        Me.LblCostoUnidad.AutoSize = True
        Me.LblCostoUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCostoUnidad.Location = New System.Drawing.Point(404, 116)
        Me.LblCostoUnidad.Name = "LblCostoUnidad"
        Me.LblCostoUnidad.Size = New System.Drawing.Size(159, 18)
        Me.LblCostoUnidad.TabIndex = 10
        Me.LblCostoUnidad.Text = "Costo por unidad (C$):"
        '
        'txtCostoUnidad
        '
        Me.txtCostoUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoUnidad.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtCostoUnidad.Location = New System.Drawing.Point(569, 117)
        Me.txtCostoUnidad.Name = "txtCostoUnidad"
        Me.txtCostoUnidad.Size = New System.Drawing.Size(125, 20)
        Me.txtCostoUnidad.TabIndex = 9
        Me.txtCostoUnidad.Text = "Ingrese costo por unidad"
        '
        'LblInventarioFinalDeseado
        '
        Me.LblInventarioFinalDeseado.AutoSize = True
        Me.LblInventarioFinalDeseado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInventarioFinalDeseado.Location = New System.Drawing.Point(11, 157)
        Me.LblInventarioFinalDeseado.Name = "LblInventarioFinalDeseado"
        Me.LblInventarioFinalDeseado.Size = New System.Drawing.Size(166, 18)
        Me.LblInventarioFinalDeseado.TabIndex = 8
        Me.LblInventarioFinalDeseado.Text = "Inventario final deseado:"
        '
        'txtInventarioFinalDeseado
        '
        Me.txtInventarioFinalDeseado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInventarioFinalDeseado.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtInventarioFinalDeseado.Location = New System.Drawing.Point(183, 158)
        Me.txtInventarioFinalDeseado.Name = "txtInventarioFinalDeseado"
        Me.txtInventarioFinalDeseado.Size = New System.Drawing.Size(125, 20)
        Me.txtInventarioFinalDeseado.TabIndex = 7
        Me.txtInventarioFinalDeseado.Text = "Ingrese inventario final"
        '
        'LblUnidadesNecesarias
        '
        Me.LblUnidadesNecesarias.AutoSize = True
        Me.LblUnidadesNecesarias.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUnidadesNecesarias.Location = New System.Drawing.Point(9, 113)
        Me.LblUnidadesNecesarias.Name = "LblUnidadesNecesarias"
        Me.LblUnidadesNecesarias.Size = New System.Drawing.Size(153, 18)
        Me.LblUnidadesNecesarias.TabIndex = 6
        Me.LblUnidadesNecesarias.Text = "Unidades Necesarias:"
        '
        'txtUnidadesNecesarias
        '
        Me.txtUnidadesNecesarias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidadesNecesarias.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtUnidadesNecesarias.Location = New System.Drawing.Point(168, 114)
        Me.txtUnidadesNecesarias.Name = "txtUnidadesNecesarias"
        Me.txtUnidadesNecesarias.Size = New System.Drawing.Size(149, 20)
        Me.txtUnidadesNecesarias.TabIndex = 5
        Me.txtUnidadesNecesarias.Text = "Ingrese unidades necesarias"
        '
        'LblMaterial
        '
        Me.LblMaterial.AutoSize = True
        Me.LblMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMaterial.Location = New System.Drawing.Point(8, 71)
        Me.LblMaterial.Name = "LblMaterial"
        Me.LblMaterial.Size = New System.Drawing.Size(64, 18)
        Me.LblMaterial.TabIndex = 4
        Me.LblMaterial.Text = "Material:"
        '
        'DtgPresupuestoCompras
        '
        Me.DtgPresupuestoCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgPresupuestoCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColMaterial, Me.ColUnidadesnecesarias, Me.ColInventariofinaldeseado, Me.Colinventarioinicial, Me.ColUnidadescomprar, Me.ColCostoporunidad, Me.Colcostototaldecompra, Me.ColCostoAdicionales, Me.Colcostounitariototal, Me.ColPagototal})
        Me.DtgPresupuestoCompras.Location = New System.Drawing.Point(3, 215)
        Me.DtgPresupuestoCompras.Name = "DtgPresupuestoCompras"
        Me.DtgPresupuestoCompras.Size = New System.Drawing.Size(1090, 191)
        Me.DtgPresupuestoCompras.TabIndex = 5
        '
        'ColMaterial
        '
        Me.ColMaterial.HeaderText = "Material"
        Me.ColMaterial.Name = "ColMaterial"
        '
        'ColUnidadesnecesarias
        '
        Me.ColUnidadesnecesarias.HeaderText = "Unidades necesarias"
        Me.ColUnidadesnecesarias.Name = "ColUnidadesnecesarias"
        Me.ColUnidadesnecesarias.Width = 150
        '
        'ColInventariofinaldeseado
        '
        Me.ColInventariofinaldeseado.HeaderText = "Inventario final deseado"
        Me.ColInventariofinaldeseado.Name = "ColInventariofinaldeseado"
        Me.ColInventariofinaldeseado.Width = 120
        '
        'Colinventarioinicial
        '
        Me.Colinventarioinicial.HeaderText = "Inventario inicial"
        Me.Colinventarioinicial.Name = "Colinventarioinicial"
        Me.Colinventarioinicial.Width = 120
        '
        'ColUnidadescomprar
        '
        Me.ColUnidadescomprar.HeaderText = "Unidades a comprar"
        Me.ColUnidadescomprar.Name = "ColUnidadescomprar"
        Me.ColUnidadescomprar.Width = 120
        '
        'ColCostoporunidad
        '
        Me.ColCostoporunidad.HeaderText = "Costo por unidad (C$)"
        Me.ColCostoporunidad.Name = "ColCostoporunidad"
        Me.ColCostoporunidad.Width = 120
        '
        'Colcostototaldecompra
        '
        Me.Colcostototaldecompra.HeaderText = "Costo total de compra (C$)"
        Me.Colcostototaldecompra.Name = "Colcostototaldecompra"
        Me.Colcostototaldecompra.Width = 120
        '
        'ColCostoAdicionales
        '
        Me.ColCostoAdicionales.HeaderText = "Costos adicionales (C$/unidad)"
        Me.ColCostoAdicionales.Name = "ColCostoAdicionales"
        Me.ColCostoAdicionales.Width = 120
        '
        'Colcostounitariototal
        '
        Me.Colcostounitariototal.HeaderText = "Costo unitario total (C$)"
        Me.Colcostounitariototal.Name = "Colcostounitariototal"
        Me.Colcostounitariototal.Width = 120
        '
        'ColPagototal
        '
        Me.ColPagototal.HeaderText = "Pago total (C$)"
        Me.ColPagototal.Name = "ColPagototal"
        Me.ColPagototal.Width = 120
        '
        'FormPresupuestodecompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 487)
        Me.Controls.Add(Me.DtgPresupuestoCompras)
        Me.Controls.Add(Me.GrpPresupuestodecompras)
        Me.Name = "FormPresupuestodecompras"
        Me.Text = "FormPresupuestodecompras"
        Me.GrpPresupuestodecompras.ResumeLayout(False)
        Me.GrpPresupuestodecompras.PerformLayout()
        CType(Me.DtgPresupuestoCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblIngreselosDatos As Label
    Friend WithEvents txtMaterial As TextBox
    Friend WithEvents GrpPresupuestodecompras As GroupBox
    Friend WithEvents LblMaterial As Label
    Friend WithEvents LblInventarioFinalDeseado As Label
    Friend WithEvents txtInventarioFinalDeseado As TextBox
    Friend WithEvents LblUnidadesNecesarias As Label
    Friend WithEvents txtUnidadesNecesarias As TextBox
    Friend WithEvents LblCostoUnidad As Label
    Friend WithEvents txtCostoUnidad As TextBox
    Friend WithEvents LblCostosAdicionales As Label
    Friend WithEvents txtCostosAdicionales As TextBox
    Friend WithEvents LblInventarioInicial As Label
    Friend WithEvents txtInventarioInicial As TextBox
    Friend WithEvents LblCostounitariototal As Label
    Friend WithEvents txtCostounitariototal As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents DtgPresupuestoCompras As DataGridView
    Friend WithEvents ColMaterial As DataGridViewTextBoxColumn
    Friend WithEvents ColUnidadesnecesarias As DataGridViewTextBoxColumn
    Friend WithEvents ColInventariofinaldeseado As DataGridViewTextBoxColumn
    Friend WithEvents Colinventarioinicial As DataGridViewTextBoxColumn
    Friend WithEvents ColUnidadescomprar As DataGridViewTextBoxColumn
    Friend WithEvents ColCostoporunidad As DataGridViewTextBoxColumn
    Friend WithEvents Colcostototaldecompra As DataGridViewTextBoxColumn
    Friend WithEvents ColCostoAdicionales As DataGridViewTextBoxColumn
    Friend WithEvents Colcostounitariototal As DataGridViewTextBoxColumn
    Friend WithEvents ColPagototal As DataGridViewTextBoxColumn
End Class
