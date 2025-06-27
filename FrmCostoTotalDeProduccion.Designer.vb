<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCostoTotalDeProduccion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCostoTotalDeProduccion))
        Me.LblProducto = New System.Windows.Forms.Label()
        Me.LblMPD = New System.Windows.Forms.Label()
        Me.LblMOD = New System.Windows.Forms.Label()
        Me.TxtProducto = New System.Windows.Forms.TextBox()
        Me.TxtMPD = New System.Windows.Forms.TextBox()
        Me.TxtMOD = New System.Windows.Forms.TextBox()
        Me.DtgCostoTotalDeProduccion = New System.Windows.Forms.DataGridView()
        Me.ColProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMPD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMOD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_GIF_Asignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCostoTotalDeProduccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCostoUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtGifAsignado = New System.Windows.Forms.TextBox()
        Me.LblGIFAsignados = New System.Windows.Forms.Label()
        Me.TxtTotalGIF = New System.Windows.Forms.TextBox()
        Me.LblTotalGIF = New System.Windows.Forms.Label()
        Me.TxtTotalMPD = New System.Windows.Forms.TextBox()
        Me.LbltotalMPD = New System.Windows.Forms.Label()
        Me.TxtTotalMOD = New System.Windows.Forms.TextBox()
        Me.LblTotalMOD = New System.Windows.Forms.Label()
        Me.TxtTotalCTP = New System.Windows.Forms.TextBox()
        Me.LblCTP = New System.Windows.Forms.Label()
        Me.TxtCU = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregarCtp = New System.Windows.Forms.Button()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DtgCostoTotalDeProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblProducto
        '
        Me.LblProducto.AutoSize = True
        Me.LblProducto.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProducto.Location = New System.Drawing.Point(43, 133)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(96, 27)
        Me.LblProducto.TabIndex = 0
        Me.LblProducto.Text = "Producto"
        '
        'LblMPD
        '
        Me.LblMPD.AutoSize = True
        Me.LblMPD.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMPD.Location = New System.Drawing.Point(43, 192)
        Me.LblMPD.Name = "LblMPD"
        Me.LblMPD.Size = New System.Drawing.Size(218, 27)
        Me.LblMPD.TabIndex = 1
        Me.LblMPD.Text = "Materia Prima Directa "
        '
        'LblMOD
        '
        Me.LblMOD.AutoSize = True
        Me.LblMOD.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMOD.Location = New System.Drawing.Point(438, 136)
        Me.LblMOD.Name = "LblMOD"
        Me.LblMOD.Size = New System.Drawing.Size(211, 27)
        Me.LblMOD.TabIndex = 2
        Me.LblMOD.Text = "Mano de Obra Directa"
        '
        'TxtProducto
        '
        Me.TxtProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtProducto.Font = New System.Drawing.Font("Montserrat Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProducto.Location = New System.Drawing.Point(295, 133)
        Me.TxtProducto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtProducto.Name = "TxtProducto"
        Me.TxtProducto.Size = New System.Drawing.Size(120, 28)
        Me.TxtProducto.TabIndex = 3
        '
        'TxtMPD
        '
        Me.TxtMPD.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtMPD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMPD.Font = New System.Drawing.Font("Montserrat Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMPD.Location = New System.Drawing.Point(295, 192)
        Me.TxtMPD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtMPD.Name = "TxtMPD"
        Me.TxtMPD.Size = New System.Drawing.Size(120, 28)
        Me.TxtMPD.TabIndex = 4
        '
        'TxtMOD
        '
        Me.TxtMOD.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtMOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMOD.Font = New System.Drawing.Font("Montserrat Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMOD.Location = New System.Drawing.Point(700, 135)
        Me.TxtMOD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtMOD.Name = "TxtMOD"
        Me.TxtMOD.Size = New System.Drawing.Size(120, 28)
        Me.TxtMOD.TabIndex = 5
        '
        'DtgCostoTotalDeProduccion
        '
        Me.DtgCostoTotalDeProduccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtgCostoTotalDeProduccion.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DtgCostoTotalDeProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgCostoTotalDeProduccion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColProducto, Me.ColMPD, Me.ColMOD, Me.Col_GIF_Asignado, Me.ColCostoTotalDeProduccion, Me.ColCostoUnitario})
        Me.DtgCostoTotalDeProduccion.GridColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.DtgCostoTotalDeProduccion.Location = New System.Drawing.Point(48, 250)
        Me.DtgCostoTotalDeProduccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DtgCostoTotalDeProduccion.Name = "DtgCostoTotalDeProduccion"
        Me.DtgCostoTotalDeProduccion.ReadOnly = True
        Me.DtgCostoTotalDeProduccion.RowHeadersWidth = 51
        Me.DtgCostoTotalDeProduccion.RowTemplate.Height = 24
        Me.DtgCostoTotalDeProduccion.Size = New System.Drawing.Size(1095, 279)
        Me.DtgCostoTotalDeProduccion.TabIndex = 6
        '
        'ColProducto
        '
        Me.ColProducto.HeaderText = "Producto"
        Me.ColProducto.MinimumWidth = 6
        Me.ColProducto.Name = "ColProducto"
        Me.ColProducto.ReadOnly = True
        Me.ColProducto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ColMPD
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "C$"
        Me.ColMPD.DefaultCellStyle = DataGridViewCellStyle1
        Me.ColMPD.HeaderText = "MPD (C$)"
        Me.ColMPD.MinimumWidth = 6
        Me.ColMPD.Name = "ColMPD"
        Me.ColMPD.ReadOnly = True
        Me.ColMPD.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ColMOD
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "C$"
        Me.ColMOD.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColMOD.HeaderText = "MOD(C$)"
        Me.ColMOD.MinimumWidth = 6
        Me.ColMOD.Name = "ColMOD"
        Me.ColMOD.ReadOnly = True
        Me.ColMOD.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Col_GIF_Asignado
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "C$"
        Me.Col_GIF_Asignado.DefaultCellStyle = DataGridViewCellStyle3
        Me.Col_GIF_Asignado.HeaderText = "GIF Asignado (C$)"
        Me.Col_GIF_Asignado.MinimumWidth = 6
        Me.Col_GIF_Asignado.Name = "Col_GIF_Asignado"
        Me.Col_GIF_Asignado.ReadOnly = True
        Me.Col_GIF_Asignado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ColCostoTotalDeProduccion
        '
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "C$"
        Me.ColCostoTotalDeProduccion.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColCostoTotalDeProduccion.HeaderText = "Costo Total De Produccion (C$)"
        Me.ColCostoTotalDeProduccion.MinimumWidth = 6
        Me.ColCostoTotalDeProduccion.Name = "ColCostoTotalDeProduccion"
        Me.ColCostoTotalDeProduccion.ReadOnly = True
        Me.ColCostoTotalDeProduccion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ColCostoUnitario
        '
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = "C$"
        Me.ColCostoUnitario.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColCostoUnitario.HeaderText = "Costo Unitario"
        Me.ColCostoUnitario.MinimumWidth = 6
        Me.ColCostoUnitario.Name = "ColCostoUnitario"
        Me.ColCostoUnitario.ReadOnly = True
        Me.ColCostoUnitario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'TxtGifAsignado
        '
        Me.TxtGifAsignado.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtGifAsignado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGifAsignado.Font = New System.Drawing.Font("Montserrat Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGifAsignado.Location = New System.Drawing.Point(700, 190)
        Me.TxtGifAsignado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtGifAsignado.Name = "TxtGifAsignado"
        Me.TxtGifAsignado.Size = New System.Drawing.Size(120, 28)
        Me.TxtGifAsignado.TabIndex = 9
        '
        'LblGIFAsignados
        '
        Me.LblGIFAsignados.AutoSize = True
        Me.LblGIFAsignados.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGIFAsignados.Location = New System.Drawing.Point(438, 192)
        Me.LblGIFAsignados.Name = "LblGIFAsignados"
        Me.LblGIFAsignados.Size = New System.Drawing.Size(137, 27)
        Me.LblGIFAsignados.TabIndex = 8
        Me.LblGIFAsignados.Text = "GIF Asignado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtTotalGIF
        '
        Me.TxtTotalGIF.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtTotalGIF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalGIF.Enabled = False
        Me.TxtTotalGIF.Font = New System.Drawing.Font("Montserrat Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalGIF.Location = New System.Drawing.Point(866, 561)
        Me.TxtTotalGIF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtTotalGIF.Name = "TxtTotalGIF"
        Me.TxtTotalGIF.Size = New System.Drawing.Size(120, 28)
        Me.TxtTotalGIF.TabIndex = 12
        '
        'LblTotalGIF
        '
        Me.LblTotalGIF.AutoSize = True
        Me.LblTotalGIF.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalGIF.Location = New System.Drawing.Point(473, 564)
        Me.LblTotalGIF.Name = "LblTotalGIF"
        Me.LblTotalGIF.Size = New System.Drawing.Size(387, 27)
        Me.LblTotalGIF.TabIndex = 11
        Me.LblTotalGIF.Text = "Total de Gastos Indirectos de Fabricacion"
        '
        'TxtTotalMPD
        '
        Me.TxtTotalMPD.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtTotalMPD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalMPD.Enabled = False
        Me.TxtTotalMPD.Font = New System.Drawing.Font("Montserrat Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalMPD.Location = New System.Drawing.Point(337, 563)
        Me.TxtTotalMPD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtTotalMPD.Name = "TxtTotalMPD"
        Me.TxtTotalMPD.Size = New System.Drawing.Size(120, 28)
        Me.TxtTotalMPD.TabIndex = 14
        '
        'LbltotalMPD
        '
        Me.LbltotalMPD.AutoSize = True
        Me.LbltotalMPD.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbltotalMPD.Location = New System.Drawing.Point(40, 563)
        Me.LbltotalMPD.Name = "LbltotalMPD"
        Me.LbltotalMPD.Size = New System.Drawing.Size(291, 27)
        Me.LbltotalMPD.TabIndex = 13
        Me.LbltotalMPD.Text = "Total de Materia Prima Directa"
        '
        'TxtTotalMOD
        '
        Me.TxtTotalMOD.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtTotalMOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalMOD.Enabled = False
        Me.TxtTotalMOD.Font = New System.Drawing.Font("Montserrat Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalMOD.Location = New System.Drawing.Point(338, 635)
        Me.TxtTotalMOD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtTotalMOD.Name = "TxtTotalMOD"
        Me.TxtTotalMOD.Size = New System.Drawing.Size(120, 28)
        Me.TxtTotalMOD.TabIndex = 16
        '
        'LblTotalMOD
        '
        Me.LblTotalMOD.AutoSize = True
        Me.LblTotalMOD.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalMOD.Location = New System.Drawing.Point(43, 638)
        Me.LblTotalMOD.Name = "LblTotalMOD"
        Me.LblTotalMOD.Size = New System.Drawing.Size(289, 27)
        Me.LblTotalMOD.TabIndex = 15
        Me.LblTotalMOD.Text = "Total de Mano de Obra Directa"
        '
        'TxtTotalCTP
        '
        Me.TxtTotalCTP.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtTotalCTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalCTP.Enabled = False
        Me.TxtTotalCTP.Font = New System.Drawing.Font("Montserrat Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalCTP.Location = New System.Drawing.Point(728, 638)
        Me.TxtTotalCTP.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtTotalCTP.Name = "TxtTotalCTP"
        Me.TxtTotalCTP.Size = New System.Drawing.Size(120, 28)
        Me.TxtTotalCTP.TabIndex = 18
        '
        'LblCTP
        '
        Me.LblCTP.AutoSize = True
        Me.LblCTP.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCTP.Location = New System.Drawing.Point(473, 636)
        Me.LblCTP.Name = "LblCTP"
        Me.LblCTP.Size = New System.Drawing.Size(249, 27)
        Me.LblCTP.TabIndex = 17
        Me.LblCTP.Text = "Costo Total de Produccion"
        '
        'TxtCU
        '
        Me.TxtCU.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtCU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCU.Enabled = False
        Me.TxtCU.Font = New System.Drawing.Font("Montserrat Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCU.Location = New System.Drawing.Point(1023, 634)
        Me.TxtCU.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtCU.Name = "TxtCU"
        Me.TxtCU.Size = New System.Drawing.Size(120, 28)
        Me.TxtCU.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(876, 636)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 27)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Costo Unitario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(846, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 27)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Agregar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(952, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 27)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Eliminar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(471, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(419, 37)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Costo Total de Produccion"
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
        Me.BtnEliminar.Location = New System.Drawing.Point(966, 133)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(60, 60)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnAgregarCtp
        '
        Me.BtnAgregarCtp.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BtnAgregarCtp.BackgroundImage = Global.Presupuesto_Maestro.My.Resources.Resources._1486564407_plus_green_81521
        Me.BtnAgregarCtp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnAgregarCtp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarCtp.FlatAppearance.BorderSize = 0
        Me.BtnAgregarCtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarCtp.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarCtp.Location = New System.Drawing.Point(851, 136)
        Me.BtnAgregarCtp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAgregarCtp.Name = "BtnAgregarCtp"
        Me.BtnAgregarCtp.Size = New System.Drawing.Size(60, 60)
        Me.BtnAgregarCtp.TabIndex = 7
        Me.BtnAgregarCtp.UseVisualStyleBackColor = False
        '
        'BtnImprimir
        '
        Me.BtnImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BtnImprimir.BackgroundImage = Global.Presupuesto_Maestro.My.Resources.Resources.printer_print_machine_office_business_icon_192561
        Me.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnImprimir.FlatAppearance.BorderSize = 0
        Me.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImprimir.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimir.Location = New System.Drawing.Point(1070, 135)
        Me.BtnImprimir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(60, 60)
        Me.BtnImprimir.TabIndex = 24
        Me.BtnImprimir.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1056, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 27)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Imprimir"
        '
        'FrmCostoTotalDeProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1194, 699)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCU)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTotalCTP)
        Me.Controls.Add(Me.LblCTP)
        Me.Controls.Add(Me.TxtTotalMOD)
        Me.Controls.Add(Me.LblTotalMOD)
        Me.Controls.Add(Me.TxtTotalMPD)
        Me.Controls.Add(Me.LbltotalMPD)
        Me.Controls.Add(Me.TxtTotalGIF)
        Me.Controls.Add(Me.LblTotalGIF)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.TxtGifAsignado)
        Me.Controls.Add(Me.LblGIFAsignados)
        Me.Controls.Add(Me.BtnAgregarCtp)
        Me.Controls.Add(Me.DtgCostoTotalDeProduccion)
        Me.Controls.Add(Me.TxtMOD)
        Me.Controls.Add(Me.TxtMPD)
        Me.Controls.Add(Me.TxtProducto)
        Me.Controls.Add(Me.LblMOD)
        Me.Controls.Add(Me.LblMPD)
        Me.Controls.Add(Me.LblProducto)
        Me.Font = New System.Drawing.Font("Montserrat", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCostoTotalDeProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Costo Total de Produccion"
        CType(Me.DtgCostoTotalDeProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblProducto As Label
    Friend WithEvents LblMPD As Label
    Friend WithEvents LblMOD As Label
    Friend WithEvents TxtProducto As TextBox
    Friend WithEvents TxtMPD As TextBox
    Friend WithEvents TxtMOD As TextBox
    Friend WithEvents DtgCostoTotalDeProduccion As DataGridView
    Friend WithEvents LblGIFAsignados As Label
    Friend WithEvents BtnAgregarCtp As Button
    Friend WithEvents TxtGifAsignado As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TxtTotalGIF As TextBox
    Friend WithEvents LblTotalGIF As Label
    Friend WithEvents TxtTotalMPD As TextBox
    Friend WithEvents LbltotalMPD As Label
    Friend WithEvents TxtTotalMOD As TextBox
    Friend WithEvents LblTotalMOD As Label
    Friend WithEvents TxtTotalCTP As TextBox
    Friend WithEvents LblCTP As Label
    Friend WithEvents ColProducto As DataGridViewTextBoxColumn
    Friend WithEvents ColMPD As DataGridViewTextBoxColumn
    Friend WithEvents ColMOD As DataGridViewTextBoxColumn
    Friend WithEvents Col_GIF_Asignado As DataGridViewTextBoxColumn
    Friend WithEvents ColCostoTotalDeProduccion As DataGridViewTextBoxColumn
    Friend WithEvents ColCostoUnitario As DataGridViewTextBoxColumn
    Friend WithEvents TxtCU As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents Label5 As Label
End Class
