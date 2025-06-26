<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGastosAdmyVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGastosAdmyVentas))
        Me.Gpbgastoadmventas = New System.Windows.Forms.GroupBox()
        Me.Btnayuda1 = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.LblProducto = New System.Windows.Forms.Label()
        Me.TxtConcepto = New System.Windows.Forms.TextBox()
        Me.LblConcepto = New System.Windows.Forms.Label()
        Me.LblCambioConcepto = New System.Windows.Forms.Label()
        Me.CmbCambiodeconcepto = New System.Windows.Forms.ComboBox()
        Me.DtgGastoAdmyVentas = New System.Windows.Forms.DataGridView()
        Me.ColConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAgregarconcepto = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btnayuda = New System.Windows.Forms.Button()
        Me.LblGastosadmventas = New System.Windows.Forms.Label()
        Me.Gpbgastoadmventas.SuspendLayout()
        CType(Me.DtgGastoAdmyVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gpbgastoadmventas
        '
        Me.Gpbgastoadmventas.Controls.Add(Me.Btnayuda1)
        Me.Gpbgastoadmventas.Controls.Add(Me.BtnAgregar)
        Me.Gpbgastoadmventas.Controls.Add(Me.txtcantidad)
        Me.Gpbgastoadmventas.Controls.Add(Me.LblCantidad)
        Me.Gpbgastoadmventas.Controls.Add(Me.txtProducto)
        Me.Gpbgastoadmventas.Controls.Add(Me.LblProducto)
        Me.Gpbgastoadmventas.Location = New System.Drawing.Point(6, 88)
        Me.Gpbgastoadmventas.Name = "Gpbgastoadmventas"
        Me.Gpbgastoadmventas.Size = New System.Drawing.Size(445, 104)
        Me.Gpbgastoadmventas.TabIndex = 0
        Me.Gpbgastoadmventas.TabStop = False
        '
        'Btnayuda1
        '
        Me.Btnayuda1.Cursor = System.Windows.Forms.Cursors.Help
        Me.Btnayuda1.Image = CType(resources.GetObject("Btnayuda1.Image"), System.Drawing.Image)
        Me.Btnayuda1.Location = New System.Drawing.Point(412, 10)
        Me.Btnayuda1.Name = "Btnayuda1"
        Me.Btnayuda1.Size = New System.Drawing.Size(27, 29)
        Me.Btnayuda1.TabIndex = 10
        Me.Btnayuda1.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(245, 24)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(123, 50)
        Me.BtnAgregar.TabIndex = 8
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(76, 65)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(142, 20)
        Me.txtcantidad.TabIndex = 7
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantidad.Location = New System.Drawing.Point(6, 65)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(64, 16)
        Me.LblCantidad.TabIndex = 6
        Me.LblCantidad.Text = "Cantidad:"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(76, 19)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(142, 20)
        Me.txtProducto.TabIndex = 3
        '
        'LblProducto
        '
        Me.LblProducto.AutoSize = True
        Me.LblProducto.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProducto.Location = New System.Drawing.Point(6, 20)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(79, 20)
        Me.LblProducto.TabIndex = 2
        Me.LblProducto.Text = "Producto:"
        '
        'TxtConcepto
        '
        Me.TxtConcepto.Location = New System.Drawing.Point(80, 16)
        Me.TxtConcepto.Name = "TxtConcepto"
        Me.TxtConcepto.Size = New System.Drawing.Size(142, 20)
        Me.TxtConcepto.TabIndex = 1
        '
        'LblConcepto
        '
        Me.LblConcepto.AutoSize = True
        Me.LblConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConcepto.Location = New System.Drawing.Point(6, 20)
        Me.LblConcepto.Name = "LblConcepto"
        Me.LblConcepto.Size = New System.Drawing.Size(68, 16)
        Me.LblConcepto.TabIndex = 0
        Me.LblConcepto.Text = "Concepto:"
        '
        'LblCambioConcepto
        '
        Me.LblCambioConcepto.AutoSize = True
        Me.LblCambioConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCambioConcepto.Location = New System.Drawing.Point(234, 23)
        Me.LblCambioConcepto.Name = "LblCambioConcepto"
        Me.LblCambioConcepto.Size = New System.Drawing.Size(136, 16)
        Me.LblCambioConcepto.TabIndex = 5
        Me.LblCambioConcepto.Text = "Cambiar de concepto"
        '
        'CmbCambiodeconcepto
        '
        Me.CmbCambiodeconcepto.FormattingEnabled = True
        Me.CmbCambiodeconcepto.Location = New System.Drawing.Point(383, 18)
        Me.CmbCambiodeconcepto.Name = "CmbCambiodeconcepto"
        Me.CmbCambiodeconcepto.Size = New System.Drawing.Size(159, 21)
        Me.CmbCambiodeconcepto.TabIndex = 4
        '
        'DtgGastoAdmyVentas
        '
        Me.DtgGastoAdmyVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgGastoAdmyVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColConcepto, Me.ColTotal})
        Me.DtgGastoAdmyVentas.Location = New System.Drawing.Point(6, 198)
        Me.DtgGastoAdmyVentas.Name = "DtgGastoAdmyVentas"
        Me.DtgGastoAdmyVentas.Size = New System.Drawing.Size(1022, 240)
        Me.DtgGastoAdmyVentas.TabIndex = 1
        '
        'ColConcepto
        '
        Me.ColConcepto.HeaderText = "Concepto"
        Me.ColConcepto.Name = "ColConcepto"
        Me.ColConcepto.Width = 200
        '
        'ColTotal
        '
        Me.ColTotal.HeaderText = "Total "
        Me.ColTotal.Name = "ColTotal"
        '
        'BtnAgregarconcepto
        '
        Me.BtnAgregarconcepto.Location = New System.Drawing.Point(399, 45)
        Me.BtnAgregarconcepto.Name = "BtnAgregarconcepto"
        Me.BtnAgregarconcepto.Size = New System.Drawing.Size(143, 53)
        Me.BtnAgregarconcepto.TabIndex = 9
        Me.BtnAgregarconcepto.Text = "Agregar concepto"
        Me.BtnAgregarconcepto.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btnayuda)
        Me.GroupBox1.Controls.Add(Me.LblCambioConcepto)
        Me.GroupBox1.Controls.Add(Me.BtnAgregarconcepto)
        Me.GroupBox1.Controls.Add(Me.CmbCambiodeconcepto)
        Me.GroupBox1.Controls.Add(Me.TxtConcepto)
        Me.GroupBox1.Controls.Add(Me.LblConcepto)
        Me.GroupBox1.Location = New System.Drawing.Point(457, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 104)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Btnayuda
        '
        Me.Btnayuda.Cursor = System.Windows.Forms.Cursors.Help
        Me.Btnayuda.Image = CType(resources.GetObject("Btnayuda.Image"), System.Drawing.Image)
        Me.Btnayuda.Location = New System.Drawing.Point(9, 69)
        Me.Btnayuda.Name = "Btnayuda"
        Me.Btnayuda.Size = New System.Drawing.Size(27, 29)
        Me.Btnayuda.TabIndex = 9
        Me.Btnayuda.UseVisualStyleBackColor = True
        '
        'LblGastosadmventas
        '
        Me.LblGastosadmventas.AutoSize = True
        Me.LblGastosadmventas.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGastosadmventas.Location = New System.Drawing.Point(329, 9)
        Me.LblGastosadmventas.Name = "LblGastosadmventas"
        Me.LblGastosadmventas.Size = New System.Drawing.Size(392, 27)
        Me.LblGastosadmventas.TabIndex = 11
        Me.LblGastosadmventas.Text = "Gastos de administración y ventas"
        '
        'FormGastosAdmyVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 450)
        Me.Controls.Add(Me.LblGastosadmventas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtgGastoAdmyVentas)
        Me.Controls.Add(Me.Gpbgastoadmventas)
        Me.Name = "FormGastosAdmyVentas"
        Me.Text = "FormGastosAdmyVentas"
        Me.Gpbgastoadmventas.ResumeLayout(False)
        Me.Gpbgastoadmventas.PerformLayout()
        CType(Me.DtgGastoAdmyVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Gpbgastoadmventas As GroupBox
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents LblProducto As Label
    Friend WithEvents TxtConcepto As TextBox
    Friend WithEvents LblConcepto As Label
    Friend WithEvents LblCambioConcepto As Label
    Friend WithEvents CmbCambiodeconcepto As ComboBox
    Friend WithEvents DtgGastoAdmyVentas As DataGridView
    Friend WithEvents ColConcepto As DataGridViewTextBoxColumn
    Friend WithEvents ColTotal As DataGridViewTextBoxColumn
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents LblCantidad As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnAgregarconcepto As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblGastosadmventas As Label
    Friend WithEvents Btnayuda As Button
    Friend WithEvents Btnayuda1 As Button
End Class
