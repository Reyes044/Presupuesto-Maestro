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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgPresupuestoMOD = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidades_a_Producir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Horas_por_Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_de_Horas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo_por_Horas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo_Total_MOD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUnidadesProducir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalHoras = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalMOD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dtgPresupuestoMOD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(789, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 41)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Presupuesto MOD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtgPresupuestoMOD
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgPresupuestoMOD.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgPresupuestoMOD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPresupuestoMOD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Unidades_a_Producir, Me.Horas_por_Unidad, Me.Total_de_Horas, Me.Costo_por_Horas, Me.Costo_Total_MOD})
        Me.dtgPresupuestoMOD.Location = New System.Drawing.Point(128, 94)
        Me.dtgPresupuestoMOD.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtgPresupuestoMOD.Name = "dtgPresupuestoMOD"
        Me.dtgPresupuestoMOD.RowHeadersWidth = 62
        Me.dtgPresupuestoMOD.Size = New System.Drawing.Size(1546, 423)
        Me.dtgPresupuestoMOD.TabIndex = 5
        '
        'Producto
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Producto.DefaultCellStyle = DataGridViewCellStyle2
        Me.Producto.HeaderText = "Producto"
        Me.Producto.MinimumWidth = 8
        Me.Producto.Name = "Producto"
        Me.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Producto.Width = 387
        '
        'Unidades_a_Producir
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Unidades_a_Producir.DefaultCellStyle = DataGridViewCellStyle3
        Me.Unidades_a_Producir.HeaderText = "Unidades a Producir"
        Me.Unidades_a_Producir.MinimumWidth = 8
        Me.Unidades_a_Producir.Name = "Unidades_a_Producir"
        Me.Unidades_a_Producir.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Unidades_a_Producir.Width = 120
        '
        'Horas_por_Unidad
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.Horas_por_Unidad.DefaultCellStyle = DataGridViewCellStyle4
        Me.Horas_por_Unidad.HeaderText = "Horas por Unidad"
        Me.Horas_por_Unidad.MinimumWidth = 8
        Me.Horas_por_Unidad.Name = "Horas_por_Unidad"
        Me.Horas_por_Unidad.Width = 120
        '
        'Total_de_Horas
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.Total_de_Horas.DefaultCellStyle = DataGridViewCellStyle5
        Me.Total_de_Horas.HeaderText = "Total de Horas"
        Me.Total_de_Horas.MinimumWidth = 8
        Me.Total_de_Horas.Name = "Total_de_Horas"
        Me.Total_de_Horas.Width = 120
        '
        'Costo_por_Horas
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.Costo_por_Horas.DefaultCellStyle = DataGridViewCellStyle6
        Me.Costo_por_Horas.HeaderText = "Costo por horas"
        Me.Costo_por_Horas.MinimumWidth = 8
        Me.Costo_por_Horas.Name = "Costo_por_Horas"
        Me.Costo_por_Horas.Width = 120
        '
        'Costo_Total_MOD
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.Costo_Total_MOD.DefaultCellStyle = DataGridViewCellStyle7
        Me.Costo_Total_MOD.HeaderText = "Costo Total MOD"
        Me.Costo_Total_MOD.MinimumWidth = 8
        Me.Costo_Total_MOD.Name = "Costo_Total_MOD"
        Me.Costo_Total_MOD.Width = 120
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(626, 575)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(266, 74)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar un Producto"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Enabled = False
        Me.btnEliminarProducto.Location = New System.Drawing.Point(1002, 575)
        Me.btnEliminarProducto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(266, 74)
        Me.btnEliminarProducto.TabIndex = 7
        Me.btnEliminarProducto.Text = "Eliminar un Producto"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtgPresupuestoMOD)
        Me.GroupBox1.Location = New System.Drawing.Point(74, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1776, 666)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 726)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 59)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Totales"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtUnidadesProducir
        '
        Me.txtUnidadesProducir.Enabled = False
        Me.txtUnidadesProducir.Location = New System.Drawing.Point(225, 802)
        Me.txtUnidadesProducir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUnidadesProducir.Name = "txtUnidadesProducir"
        Me.txtUnidadesProducir.Size = New System.Drawing.Size(133, 26)
        Me.txtUnidadesProducir.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 812)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Unidades a Producir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtTotalHoras
        '
        Me.txtTotalHoras.Enabled = False
        Me.txtTotalHoras.Location = New System.Drawing.Point(225, 865)
        Me.txtTotalHoras.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotalHoras.Name = "txtTotalHoras"
        Me.txtTotalHoras.Size = New System.Drawing.Size(133, 26)
        Me.txtTotalHoras.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 869)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Total De Horas"
        '
        'txtTotalMOD
        '
        Me.txtTotalMOD.Enabled = False
        Me.txtTotalMOD.Location = New System.Drawing.Point(225, 918)
        Me.txtTotalMOD.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotalMOD.Name = "txtTotalMOD"
        Me.txtTotalMOD.Size = New System.Drawing.Size(133, 26)
        Me.txtTotalMOD.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 929)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Costo Total MOD"
        '
        'FormPresupuestoMOD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1868, 1012)
        Me.Controls.Add(Me.txtTotalMOD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotalHoras)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUnidadesProducir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEliminarProducto)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.GroupBox1)
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
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Unidades_a_Producir As DataGridViewTextBoxColumn
    Friend WithEvents Horas_por_Unidad As DataGridViewTextBoxColumn
    Friend WithEvents Total_de_Horas As DataGridViewTextBoxColumn
    Friend WithEvents Costo_por_Horas As DataGridViewTextBoxColumn
    Friend WithEvents Costo_Total_MOD As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUnidadesProducir As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotalHoras As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalMOD As TextBox
    Friend WithEvents Label5 As Label
End Class
