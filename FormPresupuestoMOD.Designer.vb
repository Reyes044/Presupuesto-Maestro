<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPresupuestoMOD
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPresupuestoMOD))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgPresupuestoMOD = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidades_a_Producir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Horas_por_Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_de_Horas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo_por_Horas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo_Total_MOD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUnidadesProducir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalHoras = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalMOD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        CType(Me.dtgPresupuestoMOD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(789, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 44)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Presupuesto MOD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtgPresupuestoMOD
        '
        Me.dtgPresupuestoMOD.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgPresupuestoMOD.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgPresupuestoMOD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPresupuestoMOD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Unidades_a_Producir, Me.Horas_por_Unidad, Me.Total_de_Horas, Me.Costo_por_Horas, Me.Costo_Total_MOD})
        Me.dtgPresupuestoMOD.GridColor = System.Drawing.Color.Black
        Me.dtgPresupuestoMOD.Location = New System.Drawing.Point(128, 94)
        Me.dtgPresupuestoMOD.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtgPresupuestoMOD.Name = "dtgPresupuestoMOD"
        Me.dtgPresupuestoMOD.RowHeadersWidth = 62
        Me.dtgPresupuestoMOD.Size = New System.Drawing.Size(1546, 355)
        Me.dtgPresupuestoMOD.TabIndex = 5
        '
        'Producto
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Producto.DefaultCellStyle = DataGridViewCellStyle2
        Me.Producto.HeaderText = "Producto"
        Me.Producto.MinimumWidth = 8
        Me.Producto.Name = "Producto"
        Me.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Producto.Width = 350
        '
        'Unidades_a_Producir
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Format = "N2"
        Me.Unidades_a_Producir.DefaultCellStyle = DataGridViewCellStyle3
        Me.Unidades_a_Producir.HeaderText = "Unidades a Producir"
        Me.Unidades_a_Producir.MinimumWidth = 8
        Me.Unidades_a_Producir.Name = "Unidades_a_Producir"
        Me.Unidades_a_Producir.ReadOnly = True
        Me.Unidades_a_Producir.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Unidades_a_Producir.Width = 120
        '
        'Horas_por_Unidad
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "N2"
        Me.Horas_por_Unidad.DefaultCellStyle = DataGridViewCellStyle4
        Me.Horas_por_Unidad.HeaderText = "Horas por Unidad"
        Me.Horas_por_Unidad.MinimumWidth = 8
        Me.Horas_por_Unidad.Name = "Horas_por_Unidad"
        Me.Horas_por_Unidad.ReadOnly = True
        Me.Horas_por_Unidad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Horas_por_Unidad.Width = 120
        '
        'Total_de_Horas
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "N2"
        Me.Total_de_Horas.DefaultCellStyle = DataGridViewCellStyle5
        Me.Total_de_Horas.HeaderText = "Total de Horas"
        Me.Total_de_Horas.MinimumWidth = 8
        Me.Total_de_Horas.Name = "Total_de_Horas"
        Me.Total_de_Horas.ReadOnly = True
        Me.Total_de_Horas.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Total_de_Horas.Width = 120
        '
        'Costo_por_Horas
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "C2"
        Me.Costo_por_Horas.DefaultCellStyle = DataGridViewCellStyle6
        Me.Costo_por_Horas.HeaderText = "Costo por horas"
        Me.Costo_por_Horas.MinimumWidth = 8
        Me.Costo_por_Horas.Name = "Costo_por_Horas"
        Me.Costo_por_Horas.ReadOnly = True
        Me.Costo_por_Horas.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Costo_por_Horas.Width = 128
        '
        'Costo_Total_MOD
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.Format = "C2"
        Me.Costo_Total_MOD.DefaultCellStyle = DataGridViewCellStyle7
        Me.Costo_Total_MOD.HeaderText = "Costo Total MOD"
        Me.Costo_Total_MOD.MinimumWidth = 8
        Me.Costo_Total_MOD.Name = "Costo_Total_MOD"
        Me.Costo_Total_MOD.ReadOnly = True
        Me.Costo_Total_MOD.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Costo_Total_MOD.Width = 128
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnEliminarProducto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.dtgPresupuestoMOD)
        Me.GroupBox1.Location = New System.Drawing.Point(74, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1776, 670)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(947, 615)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(205, 31)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Eliminar Producto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(597, 615)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(202, 31)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Agregar Producto"
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.BackgroundImage = CType(resources.GetObject("btnEliminarProducto.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarProducto.FlatAppearance.BorderSize = 0
        Me.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarProducto.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProducto.Location = New System.Drawing.Point(982, 478)
        Me.btnEliminarProducto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(126, 118)
        Me.btnEliminarProducto.TabIndex = 37
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        Me.btnEliminarProducto.Visible = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackgroundImage = CType(resources.GetObject("btnAgregar.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Montserrat SemiBold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(630, 478)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(126, 118)
        Me.btnAgregar.TabIndex = 37
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(57, 726)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 66)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Totales"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtUnidadesProducir
        '
        Me.txtUnidadesProducir.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txtUnidadesProducir.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidadesProducir.Location = New System.Drawing.Point(298, 811)
        Me.txtUnidadesProducir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUnidadesProducir.Name = "txtUnidadesProducir"
        Me.txtUnidadesProducir.ReadOnly = True
        Me.txtUnidadesProducir.Size = New System.Drawing.Size(241, 29)
        Me.txtUnidadesProducir.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(61, 814)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 31)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Unidades a Producir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtTotalHoras
        '
        Me.txtTotalHoras.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txtTotalHoras.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalHoras.Location = New System.Drawing.Point(756, 811)
        Me.txtTotalHoras.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotalHoras.Name = "txtTotalHoras"
        Me.txtTotalHoras.ReadOnly = True
        Me.txtTotalHoras.Size = New System.Drawing.Size(241, 29)
        Me.txtTotalHoras.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(581, 814)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 31)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Total De Horas"
        '
        'txtTotalMOD
        '
        Me.txtTotalMOD.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.txtTotalMOD.Font = New System.Drawing.Font("Montserrat Medium", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalMOD.Location = New System.Drawing.Point(1250, 811)
        Me.txtTotalMOD.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotalMOD.Name = "txtTotalMOD"
        Me.txtTotalMOD.ReadOnly = True
        Me.txtTotalMOD.Size = New System.Drawing.Size(241, 29)
        Me.txtTotalMOD.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(1052, 814)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 31)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Costo Total MOD"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1611, 901)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 31)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Imprimir"
        '
        'btnImprimir
        '
        Me.btnImprimir.BackgroundImage = CType(resources.GetObject("btnImprimir.BackgroundImage"), System.Drawing.Image)
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Location = New System.Drawing.Point(1586, 769)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(147, 119)
        Me.btnImprimir.TabIndex = 38
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'FormPresupuestoMOD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1868, 1012)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.txtTotalMOD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotalHoras)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUnidadesProducir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormPresupuestoMOD"
        Me.Text = "FormPresupuestoMOD"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtgPresupuestoMOD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtgPresupuestoMOD As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUnidadesProducir As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotalHoras As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalMOD As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Unidades_a_Producir As DataGridViewTextBoxColumn
    Friend WithEvents Horas_por_Unidad As DataGridViewTextBoxColumn
    Friend WithEvents Total_de_Horas As DataGridViewTextBoxColumn
    Friend WithEvents Costo_por_Horas As DataGridViewTextBoxColumn
    Friend WithEvents Costo_Total_MOD As DataGridViewTextBoxColumn
    Friend WithEvents Label11 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents btnImprimir As Button
End Class
