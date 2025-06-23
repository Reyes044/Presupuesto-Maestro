<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPresupuestodecompras
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIngreselosDatos = New System.Windows.Forms.Label()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.GrpPresupuestodecompras = New System.Windows.Forms.GroupBox()
        Me.BtnAgregarC = New System.Windows.Forms.Button()
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
        Me.Lblunidadesnec = New System.Windows.Forms.Label()
        Me.LblTotalInventarioFinal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblTotalInventinicial = New System.Windows.Forms.Label()
        Me.LblUnidadescomprar = New System.Windows.Forms.Label()
        Me.LblTotalCostoporunidad = New System.Windows.Forms.Label()
        Me.LblCostoTotalCOmpra = New System.Windows.Forms.Label()
        Me.LblCostoadicionales = New System.Windows.Forms.Label()
        Me.LblCostounto = New System.Windows.Forms.Label()
        Me.LblPagototal = New System.Windows.Forms.Label()
        Me.txtTotalunidadesNecesarias = New System.Windows.Forms.TextBox()
        Me.txtTotalInventariofinal = New System.Windows.Forms.TextBox()
        Me.txtTotalInventarioinic = New System.Windows.Forms.TextBox()
        Me.txtTotalUnidadesComprar = New System.Windows.Forms.TextBox()
        Me.txtTotalCostounidad = New System.Windows.Forms.TextBox()
        Me.txtTotalCostoTotalCompra = New System.Windows.Forms.TextBox()
        Me.txtTotalCostoAdicionales = New System.Windows.Forms.TextBox()
        Me.txtTotalCostounitarioTotal = New System.Windows.Forms.TextBox()
        Me.txtTotaldepagoTotal = New System.Windows.Forms.TextBox()
        Me.BtnEliminarfila = New System.Windows.Forms.Button()
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
        Me.GrpPresupuestodecompras.Controls.Add(Me.BtnAgregarC)
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
        Me.GrpPresupuestodecompras.Size = New System.Drawing.Size(1186, 205)
        Me.GrpPresupuestodecompras.TabIndex = 4
        Me.GrpPresupuestodecompras.TabStop = False
        '
        'BtnAgregarC
        '
        Me.BtnAgregarC.Location = New System.Drawing.Point(915, 123)
        Me.BtnAgregarC.Name = "BtnAgregarC"
        Me.BtnAgregarC.Size = New System.Drawing.Size(105, 55)
        Me.BtnAgregarC.TabIndex = 17
        Me.BtnAgregarC.Text = "Agregar"
        Me.BtnAgregarC.UseVisualStyleBackColor = True
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
        Me.DtgPresupuestoCompras.Size = New System.Drawing.Size(1186, 191)
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
        'Lblunidadesnec
        '
        Me.Lblunidadesnec.AutoSize = True
        Me.Lblunidadesnec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblunidadesnec.Location = New System.Drawing.Point(6, 428)
        Me.Lblunidadesnec.Name = "Lblunidadesnec"
        Me.Lblunidadesnec.Size = New System.Drawing.Size(198, 20)
        Me.Lblunidadesnec.TabIndex = 6
        Me.Lblunidadesnec.Text = "Total unidades necesarias:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblTotalInventarioFinal
        '
        Me.LblTotalInventarioFinal.AutoSize = True
        Me.LblTotalInventarioFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalInventarioFinal.Location = New System.Drawing.Point(6, 475)
        Me.LblTotalInventarioFinal.Name = "LblTotalInventarioFinal"
        Me.LblTotalInventarioFinal.Size = New System.Drawing.Size(153, 20)
        Me.LblTotalInventarioFinal.TabIndex = 7
        Me.LblTotalInventarioFinal.Text = "Total inventario final:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(572, 437)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 8
        '
        'LblTotalInventinicial
        '
        Me.LblTotalInventinicial.AutoSize = True
        Me.LblTotalInventinicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalInventinicial.Location = New System.Drawing.Point(6, 524)
        Me.LblTotalInventinicial.Name = "LblTotalInventinicial"
        Me.LblTotalInventinicial.Size = New System.Drawing.Size(162, 20)
        Me.LblTotalInventinicial.TabIndex = 9
        Me.LblTotalInventinicial.Text = "Total inventario inicial:"
        '
        'LblUnidadescomprar
        '
        Me.LblUnidadescomprar.AutoSize = True
        Me.LblUnidadescomprar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUnidadescomprar.Location = New System.Drawing.Point(6, 571)
        Me.LblUnidadescomprar.Name = "LblUnidadescomprar"
        Me.LblUnidadescomprar.Size = New System.Drawing.Size(192, 20)
        Me.LblUnidadescomprar.TabIndex = 10
        Me.LblUnidadescomprar.Text = "Total unidades a comprar:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblTotalCostoporunidad
        '
        Me.LblTotalCostoporunidad.AutoSize = True
        Me.LblTotalCostoporunidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalCostoporunidad.Location = New System.Drawing.Point(467, 428)
        Me.LblTotalCostoporunidad.Name = "LblTotalCostoporunidad"
        Me.LblTotalCostoporunidad.Size = New System.Drawing.Size(170, 20)
        Me.LblTotalCostoporunidad.TabIndex = 11
        Me.LblTotalCostoporunidad.Text = "Total costo por unidad:"
        '
        'LblCostoTotalCOmpra
        '
        Me.LblCostoTotalCOmpra.AutoSize = True
        Me.LblCostoTotalCOmpra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCostoTotalCOmpra.Location = New System.Drawing.Point(467, 475)
        Me.LblCostoTotalCOmpra.Name = "LblCostoTotalCOmpra"
        Me.LblCostoTotalCOmpra.Size = New System.Drawing.Size(264, 20)
        Me.LblCostoTotalCOmpra.TabIndex = 12
        Me.LblCostoTotalCOmpra.Text = "Total del costo total de compra (C$):"
        '
        'LblCostoadicionales
        '
        Me.LblCostoadicionales.AutoSize = True
        Me.LblCostoadicionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCostoadicionales.Location = New System.Drawing.Point(467, 524)
        Me.LblCostoadicionales.Name = "LblCostoadicionales"
        Me.LblCostoadicionales.Size = New System.Drawing.Size(268, 20)
        Me.LblCostoadicionales.TabIndex = 13
        Me.LblCostoadicionales.Text = "Total costos adicionales (C$/unidad):"
        '
        'LblCostounto
        '
        Me.LblCostounto.AutoSize = True
        Me.LblCostounto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCostounto.Location = New System.Drawing.Point(467, 571)
        Me.LblCostounto.Name = "LblCostounto"
        Me.LblCostounto.Size = New System.Drawing.Size(216, 20)
        Me.LblCostounto.TabIndex = 14
        Me.LblCostounto.Text = "Total costo unitario total (C$):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblPagototal
        '
        Me.LblPagototal.AutoSize = True
        Me.LblPagototal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPagototal.Location = New System.Drawing.Point(1007, 428)
        Me.LblPagototal.Name = "LblPagototal"
        Me.LblPagototal.Size = New System.Drawing.Size(182, 20)
        Me.LblPagototal.TabIndex = 15
        Me.LblPagototal.Text = "Total del pago total (C$):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtTotalunidadesNecesarias
        '
        Me.txtTotalunidadesNecesarias.Enabled = False
        Me.txtTotalunidadesNecesarias.Location = New System.Drawing.Point(210, 428)
        Me.txtTotalunidadesNecesarias.Name = "txtTotalunidadesNecesarias"
        Me.txtTotalunidadesNecesarias.Size = New System.Drawing.Size(198, 20)
        Me.txtTotalunidadesNecesarias.TabIndex = 16
        '
        'txtTotalInventariofinal
        '
        Me.txtTotalInventariofinal.Enabled = False
        Me.txtTotalInventariofinal.Location = New System.Drawing.Point(165, 477)
        Me.txtTotalInventariofinal.Name = "txtTotalInventariofinal"
        Me.txtTotalInventariofinal.Size = New System.Drawing.Size(200, 20)
        Me.txtTotalInventariofinal.TabIndex = 17
        '
        'txtTotalInventarioinic
        '
        Me.txtTotalInventarioinic.Enabled = False
        Me.txtTotalInventarioinic.Location = New System.Drawing.Point(174, 526)
        Me.txtTotalInventarioinic.Name = "txtTotalInventarioinic"
        Me.txtTotalInventarioinic.Size = New System.Drawing.Size(191, 20)
        Me.txtTotalInventarioinic.TabIndex = 18
        '
        'txtTotalUnidadesComprar
        '
        Me.txtTotalUnidadesComprar.Enabled = False
        Me.txtTotalUnidadesComprar.Location = New System.Drawing.Point(204, 573)
        Me.txtTotalUnidadesComprar.Name = "txtTotalUnidadesComprar"
        Me.txtTotalUnidadesComprar.Size = New System.Drawing.Size(204, 20)
        Me.txtTotalUnidadesComprar.TabIndex = 19
        '
        'txtTotalCostounidad
        '
        Me.txtTotalCostounidad.Enabled = False
        Me.txtTotalCostounidad.Location = New System.Drawing.Point(643, 428)
        Me.txtTotalCostounidad.Name = "txtTotalCostounidad"
        Me.txtTotalCostounidad.Size = New System.Drawing.Size(201, 20)
        Me.txtTotalCostounidad.TabIndex = 20
        '
        'txtTotalCostoTotalCompra
        '
        Me.txtTotalCostoTotalCompra.Enabled = False
        Me.txtTotalCostoTotalCompra.Location = New System.Drawing.Point(737, 475)
        Me.txtTotalCostoTotalCompra.Name = "txtTotalCostoTotalCompra"
        Me.txtTotalCostoTotalCompra.Size = New System.Drawing.Size(193, 20)
        Me.txtTotalCostoTotalCompra.TabIndex = 21
        '
        'txtTotalCostoAdicionales
        '
        Me.txtTotalCostoAdicionales.Enabled = False
        Me.txtTotalCostoAdicionales.Location = New System.Drawing.Point(741, 524)
        Me.txtTotalCostoAdicionales.Name = "txtTotalCostoAdicionales"
        Me.txtTotalCostoAdicionales.Size = New System.Drawing.Size(204, 20)
        Me.txtTotalCostoAdicionales.TabIndex = 22
        '
        'txtTotalCostounitarioTotal
        '
        Me.txtTotalCostounitarioTotal.Enabled = False
        Me.txtTotalCostounitarioTotal.Location = New System.Drawing.Point(689, 573)
        Me.txtTotalCostounitarioTotal.Name = "txtTotalCostounitarioTotal"
        Me.txtTotalCostounitarioTotal.Size = New System.Drawing.Size(204, 20)
        Me.txtTotalCostounitarioTotal.TabIndex = 23
        '
        'txtTotaldepagoTotal
        '
        Me.txtTotaldepagoTotal.Enabled = False
        Me.txtTotaldepagoTotal.Location = New System.Drawing.Point(1011, 462)
        Me.txtTotaldepagoTotal.Name = "txtTotaldepagoTotal"
        Me.txtTotaldepagoTotal.Size = New System.Drawing.Size(172, 20)
        Me.txtTotaldepagoTotal.TabIndex = 24
        '
        'BtnEliminarfila
        '
        Me.BtnEliminarfila.Location = New System.Drawing.Point(1011, 550)
        Me.BtnEliminarfila.Name = "BtnEliminarfila"
        Me.BtnEliminarfila.Size = New System.Drawing.Size(115, 64)
        Me.BtnEliminarfila.TabIndex = 25
        Me.BtnEliminarfila.Text = "Eliminar"
        Me.BtnEliminarfila.UseVisualStyleBackColor = True
        '
        'FormPresupuestodecompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 650)
        Me.Controls.Add(Me.BtnEliminarfila)
        Me.Controls.Add(Me.txtTotaldepagoTotal)
        Me.Controls.Add(Me.txtTotalCostounitarioTotal)
        Me.Controls.Add(Me.txtTotalCostoAdicionales)
        Me.Controls.Add(Me.txtTotalCostoTotalCompra)
        Me.Controls.Add(Me.txtTotalCostounidad)
        Me.Controls.Add(Me.txtTotalUnidadesComprar)
        Me.Controls.Add(Me.txtTotalInventarioinic)
        Me.Controls.Add(Me.txtTotalInventariofinal)
        Me.Controls.Add(Me.txtTotalunidadesNecesarias)
        Me.Controls.Add(Me.LblPagototal)
        Me.Controls.Add(Me.LblCostounto)
        Me.Controls.Add(Me.LblCostoadicionales)
        Me.Controls.Add(Me.LblCostoTotalCOmpra)
        Me.Controls.Add(Me.LblTotalCostoporunidad)
        Me.Controls.Add(Me.LblUnidadescomprar)
        Me.Controls.Add(Me.LblTotalInventinicial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblTotalInventarioFinal)
        Me.Controls.Add(Me.Lblunidadesnec)
        Me.Controls.Add(Me.DtgPresupuestoCompras)
        Me.Controls.Add(Me.GrpPresupuestodecompras)
        Me.Name = "FormPresupuestodecompras"
        Me.Text = "FormPresupuestodecompras"
        Me.GrpPresupuestodecompras.ResumeLayout(False)
        Me.GrpPresupuestodecompras.PerformLayout()
        CType(Me.DtgPresupuestoCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents BtnAgregarC As Button
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
    Friend WithEvents Lblunidadesnec As Label
    Friend WithEvents LblTotalInventarioFinal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblTotalInventinicial As Label
    Friend WithEvents LblUnidadescomprar As Label
    Friend WithEvents LblTotalCostoporunidad As Label
    Friend WithEvents LblCostoTotalCOmpra As Label
    Friend WithEvents LblCostoadicionales As Label
    Friend WithEvents LblCostounto As Label
    Friend WithEvents LblPagototal As Label
    Friend WithEvents txtTotalunidadesNecesarias As TextBox
    Friend WithEvents txtTotalInventariofinal As TextBox
    Friend WithEvents txtTotalInventarioinic As TextBox
    Friend WithEvents txtTotalUnidadesComprar As TextBox
    Friend WithEvents txtTotalCostounidad As TextBox
    Friend WithEvents txtTotalCostoTotalCompra As TextBox
    Friend WithEvents txtTotalCostoAdicionales As TextBox
    Friend WithEvents txtTotalCostounitarioTotal As TextBox
    Friend WithEvents txtTotaldepagoTotal As TextBox
    Friend WithEvents BtnEliminarfila As Button
End Class
