<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGastos_Indirectos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGastos_Indirectos))
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.LblMonto = New System.Windows.Forms.Label()
        Me.TxtConcepto = New System.Windows.Forms.TextBox()
        Me.LblConcepto = New System.Windows.Forms.Label()
        Me.DtgGastosIndirectos = New System.Windows.Forms.DataGridView()
        Me.ColConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DtgGastosIndirectos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtMonto
        '
        Me.TxtMonto.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMonto.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMonto.Location = New System.Drawing.Point(158, 218)
        Me.TxtMonto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(220, 28)
        Me.TxtMonto.TabIndex = 15
        '
        'LblMonto
        '
        Me.LblMonto.AutoSize = True
        Me.LblMonto.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMonto.Location = New System.Drawing.Point(59, 218)
        Me.LblMonto.Name = "LblMonto"
        Me.LblMonto.Size = New System.Drawing.Size(70, 27)
        Me.LblMonto.TabIndex = 14
        Me.LblMonto.Text = "Monto"
        '
        'TxtConcepto
        '
        Me.TxtConcepto.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtConcepto.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConcepto.Location = New System.Drawing.Point(158, 133)
        Me.TxtConcepto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtConcepto.Name = "TxtConcepto"
        Me.TxtConcepto.Size = New System.Drawing.Size(220, 28)
        Me.TxtConcepto.TabIndex = 11
        '
        'LblConcepto
        '
        Me.LblConcepto.AutoSize = True
        Me.LblConcepto.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConcepto.Location = New System.Drawing.Point(53, 133)
        Me.LblConcepto.Name = "LblConcepto"
        Me.LblConcepto.Size = New System.Drawing.Size(99, 27)
        Me.LblConcepto.TabIndex = 10
        Me.LblConcepto.Text = "Concepto"
        '
        'DtgGastosIndirectos
        '
        Me.DtgGastosIndirectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtgGastosIndirectos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DtgGastosIndirectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgGastosIndirectos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColConcepto, Me.ColMonto})
        Me.DtgGastosIndirectos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DtgGastosIndirectos.GridColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.DtgGastosIndirectos.Location = New System.Drawing.Point(551, 126)
        Me.DtgGastosIndirectos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DtgGastosIndirectos.Name = "DtgGastosIndirectos"
        Me.DtgGastosIndirectos.ReadOnly = True
        Me.DtgGastosIndirectos.RowHeadersWidth = 51
        Me.DtgGastosIndirectos.RowTemplate.Height = 24
        Me.DtgGastosIndirectos.Size = New System.Drawing.Size(308, 276)
        Me.DtgGastosIndirectos.TabIndex = 16
        '
        'ColConcepto
        '
        Me.ColConcepto.HeaderText = "Concepto"
        Me.ColConcepto.MinimumWidth = 6
        Me.ColConcepto.Name = "ColConcepto"
        Me.ColConcepto.ReadOnly = True
        Me.ColConcepto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ColMonto
        '
        Me.ColMonto.HeaderText = "Monto"
        Me.ColMonto.MinimumWidth = 6
        Me.ColMonto.Name = "ColMonto"
        Me.ColMonto.ReadOnly = True
        Me.ColMonto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(158, 303)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(220, 28)
        Me.TxtTotal.TabIndex = 19
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(59, 303)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(57, 27)
        Me.LblTotal.TabIndex = 18
        Me.LblTotal.Text = "Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(401, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 27)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Agregar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(401, 299)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 27)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Eliminar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(325, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(289, 38)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Gastos Indirectos"
        '
        'BtnImprimir
        '
        Me.BtnImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BtnImprimir.BackgroundImage = Global.Presupuesto_Maestro.My.Resources.Resources.printer_print_machine_office_business_icon_1925611
        Me.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnImprimir.FlatAppearance.BorderSize = 0
        Me.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImprimir.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimir.Location = New System.Drawing.Point(412, 342)
        Me.BtnImprimir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(60, 60)
        Me.BtnImprimir.TabIndex = 23
        Me.BtnImprimir.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BtnEliminar.BackgroundImage = Global.Presupuesto_Maestro.My.Resources.Resources._1486564399_close_81512
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(412, 235)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(60, 60)
        Me.BtnEliminar.TabIndex = 17
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BtnAgregar.BackgroundImage = Global.Presupuesto_Maestro.My.Resources.Resources._1486564407_plus_green_81521
        Me.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(412, 116)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(60, 60)
        Me.BtnAgregar.TabIndex = 13
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(396, 406)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 27)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Imprimir"
        '
        'FrmGastos_Indirectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(929, 453)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.DtgGastosIndirectos)
        Me.Controls.Add(Me.TxtMonto)
        Me.Controls.Add(Me.LblMonto)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.TxtConcepto)
        Me.Controls.Add(Me.LblConcepto)
        Me.Font = New System.Drawing.Font("Montserrat ExtraBold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGastos_Indirectos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gastos Indirectos"
        CType(Me.DtgGastosIndirectos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtMonto As TextBox
    Friend WithEvents LblMonto As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtConcepto As TextBox
    Friend WithEvents LblConcepto As Label
    Friend WithEvents DtgGastosIndirectos As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents ColConcepto As DataGridViewTextBoxColumn
    Friend WithEvents ColMonto As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents Label4 As Label
End Class
