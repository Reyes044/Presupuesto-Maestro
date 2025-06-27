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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.BtnAgregarconcepto = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btnayuda = New System.Windows.Forms.Button()
        Me.LblGastosadmventas = New System.Windows.Forms.Label()
        Me.Lblagregar = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.ColTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtgGastoAdmyVentas = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Gpbgastoadmventas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgGastoAdmyVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gpbgastoadmventas
        '
        Me.Gpbgastoadmventas.Controls.Add(Me.Lblagregar)
        Me.Gpbgastoadmventas.Controls.Add(Me.Btnayuda1)
        Me.Gpbgastoadmventas.Controls.Add(Me.BtnAgregar)
        Me.Gpbgastoadmventas.Controls.Add(Me.txtcantidad)
        Me.Gpbgastoadmventas.Controls.Add(Me.LblCantidad)
        Me.Gpbgastoadmventas.Controls.Add(Me.txtProducto)
        Me.Gpbgastoadmventas.Controls.Add(Me.LblProducto)
        Me.Gpbgastoadmventas.Location = New System.Drawing.Point(6, 88)
        Me.Gpbgastoadmventas.Name = "Gpbgastoadmventas"
        Me.Gpbgastoadmventas.Size = New System.Drawing.Size(445, 126)
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
        Me.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Montserrat ExtraBold", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.Location = New System.Drawing.Point(353, 11)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(53, 57)
        Me.BtnAgregar.TabIndex = 8
        Me.BtnAgregar.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtcantidad.Font = New System.Drawing.Font("Montserrat Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtcantidad.Location = New System.Drawing.Point(90, 65)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(142, 23)
        Me.txtcantidad.TabIndex = 7
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblCantidad.Location = New System.Drawing.Point(6, 65)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(75, 20)
        Me.LblCantidad.TabIndex = 6
        Me.LblCantidad.Text = "Cantidad:"
        '
        'txtProducto
        '
        Me.txtProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.txtProducto.Font = New System.Drawing.Font("Montserrat Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.txtProducto.Location = New System.Drawing.Point(90, 22)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(142, 23)
        Me.txtProducto.TabIndex = 3
        '
        'LblProducto
        '
        Me.LblProducto.AutoSize = True
        Me.LblProducto.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblProducto.Location = New System.Drawing.Point(5, 23)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(79, 20)
        Me.LblProducto.TabIndex = 2
        Me.LblProducto.Text = "Producto:"
        '
        'TxtConcepto
        '
        Me.TxtConcepto.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtConcepto.Font = New System.Drawing.Font("Montserrat Medium", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConcepto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.TxtConcepto.Location = New System.Drawing.Point(92, 19)
        Me.TxtConcepto.Name = "TxtConcepto"
        Me.TxtConcepto.Size = New System.Drawing.Size(142, 23)
        Me.TxtConcepto.TabIndex = 1
        '
        'LblConcepto
        '
        Me.LblConcepto.AutoSize = True
        Me.LblConcepto.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConcepto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblConcepto.Location = New System.Drawing.Point(6, 20)
        Me.LblConcepto.Name = "LblConcepto"
        Me.LblConcepto.Size = New System.Drawing.Size(80, 20)
        Me.LblConcepto.TabIndex = 0
        Me.LblConcepto.Text = "Concepto:"
        '
        'LblCambioConcepto
        '
        Me.LblCambioConcepto.AutoSize = True
        Me.LblCambioConcepto.Font = New System.Drawing.Font("Montserrat ExtraBold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCambioConcepto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblCambioConcepto.Location = New System.Drawing.Point(252, 20)
        Me.LblCambioConcepto.Name = "LblCambioConcepto"
        Me.LblCambioConcepto.Size = New System.Drawing.Size(162, 20)
        Me.LblCambioConcepto.TabIndex = 5
        Me.LblCambioConcepto.Text = "Cambiar de concepto:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CmbCambiodeconcepto
        '
        Me.CmbCambiodeconcepto.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.CmbCambiodeconcepto.FormattingEnabled = True
        Me.CmbCambiodeconcepto.Location = New System.Drawing.Point(420, 20)
        Me.CmbCambiodeconcepto.Name = "CmbCambiodeconcepto"
        Me.CmbCambiodeconcepto.Size = New System.Drawing.Size(159, 21)
        Me.CmbCambiodeconcepto.TabIndex = 4
        '
        'BtnAgregarconcepto
        '
        Me.BtnAgregarconcepto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarconcepto.FlatAppearance.BorderSize = 0
        Me.BtnAgregarconcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarconcepto.Image = CType(resources.GetObject("BtnAgregarconcepto.Image"), System.Drawing.Image)
        Me.BtnAgregarconcepto.Location = New System.Drawing.Point(479, 46)
        Me.BtnAgregarconcepto.Name = "BtnAgregarconcepto"
        Me.BtnAgregarconcepto.Size = New System.Drawing.Size(64, 51)
        Me.BtnAgregarconcepto.TabIndex = 9
        Me.BtnAgregarconcepto.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Btnayuda)
        Me.GroupBox1.Controls.Add(Me.LblCambioConcepto)
        Me.GroupBox1.Controls.Add(Me.BtnAgregarconcepto)
        Me.GroupBox1.Controls.Add(Me.CmbCambiodeconcepto)
        Me.GroupBox1.Controls.Add(Me.TxtConcepto)
        Me.GroupBox1.Controls.Add(Me.LblConcepto)
        Me.GroupBox1.Location = New System.Drawing.Point(457, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(585, 126)
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
        Me.LblGastosadmventas.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGastosadmventas.Location = New System.Drawing.Point(297, 9)
        Me.LblGastosadmventas.Name = "LblGastosadmventas"
        Me.LblGastosadmventas.Size = New System.Drawing.Size(476, 33)
        Me.LblGastosadmventas.TabIndex = 11
        Me.LblGastosadmventas.Text = "Gastos de administración y ventas"
        '
        'Lblagregar
        '
        Me.Lblagregar.AutoSize = True
        Me.Lblagregar.Font = New System.Drawing.Font("Montserrat ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblagregar.Location = New System.Drawing.Point(349, 65)
        Me.Lblagregar.Name = "Lblagregar"
        Me.Lblagregar.Size = New System.Drawing.Size(77, 24)
        Me.Lblagregar.TabIndex = 11
        Me.Lblagregar.Text = "Agregar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(790, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(423, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Agregar concepto"
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnImprimir.FlatAppearance.BorderSize = 0
        Me.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImprimir.Image = CType(resources.GetObject("BtnImprimir.Image"), System.Drawing.Image)
        Me.BtnImprimir.Location = New System.Drawing.Point(942, 495)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(94, 60)
        Me.BtnImprimir.TabIndex = 13
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'ColTotal
        '
        Me.ColTotal.HeaderText = "Total "
        Me.ColTotal.Name = "ColTotal"
        Me.ColTotal.ReadOnly = True
        '
        'ColConcepto
        '
        Me.ColConcepto.HeaderText = "Concepto"
        Me.ColConcepto.Name = "ColConcepto"
        Me.ColConcepto.ReadOnly = True
        Me.ColConcepto.Width = 200
        '
        'DtgGastoAdmyVentas
        '
        Me.DtgGastoAdmyVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtgGastoAdmyVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DtgGastoAdmyVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgGastoAdmyVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColConcepto, Me.ColTotal})
        Me.DtgGastoAdmyVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DtgGastoAdmyVentas.Location = New System.Drawing.Point(6, 220)
        Me.DtgGastoAdmyVentas.Name = "DtgGastoAdmyVentas"
        Me.DtgGastoAdmyVentas.ReadOnly = True
        Me.DtgGastoAdmyVentas.Size = New System.Drawing.Size(1036, 269)
        Me.DtgGastoAdmyVentas.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(950, 558)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Imprimir"
        '
        'FormGastosAdmyVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1056, 591)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblGastosadmventas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtgGastoAdmyVentas)
        Me.Controls.Add(Me.Gpbgastoadmventas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormGastosAdmyVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gastos de Adm. y Ventas."
        Me.Gpbgastoadmventas.ResumeLayout(False)
        Me.Gpbgastoadmventas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgGastoAdmyVentas, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents LblCantidad As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnAgregarconcepto As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblGastosadmventas As Label
    Friend WithEvents Btnayuda As Button
    Friend WithEvents Btnayuda1 As Button
    Friend WithEvents Lblagregar As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents ColTotal As DataGridViewTextBoxColumn
    Friend WithEvents ColConcepto As DataGridViewTextBoxColumn
    Friend WithEvents DtgGastoAdmyVentas As DataGridView
    Friend WithEvents Label2 As Label
End Class
