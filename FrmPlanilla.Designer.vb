<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlanilla
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPlanilla))
        Me.DtgPlanilla = New System.Windows.Forms.DataGridView()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtCargo = New System.Windows.Forms.TextBox()
        Me.LblCargo = New System.Windows.Forms.Label()
        Me.TxtSalarioMensual = New System.Windows.Forms.TextBox()
        Me.LblSalMen = New System.Windows.Forms.Label()
        Me.TxtPrestamos = New System.Windows.Forms.TextBox()
        Me.LblPrestamos = New System.Windows.Forms.Label()
        Me.TxtFeriados = New System.Windows.Forms.TextBox()
        Me.LblFeriados = New System.Windows.Forms.Label()
        Me.TxtSubsidios = New System.Windows.Forms.TextBox()
        Me.LblSubsidios = New System.Windows.Forms.Label()
        Me.TxtDiasTrab = New System.Windows.Forms.TextBox()
        Me.LblDiaTrab = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TxtVacaciones1 = New System.Windows.Forms.TextBox()
        Me.LblVac1 = New System.Windows.Forms.Label()
        Me.TxtFirmas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MskCedula = New System.Windows.Forms.MaskedTextBox()
        Me.ColCedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSalMen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSalDia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTrab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColHExtra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSalBasic = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSubcidios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFeriados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColReajuste = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDevengado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColINSSLab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPrestamos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTdeduccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColApagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFirma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColINNSPAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColInatec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVac2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAguinaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DtgPlanilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtgPlanilla
        '
        Me.DtgPlanilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DtgPlanilla.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DtgPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgPlanilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColCedula, Me.ColNombre, Me.ColCargo, Me.ColSalMen, Me.ColSalDia, Me.ColTrab, Me.ColHExtra, Me.ColSalBasic, Me.ColSubcidios, Me.ColFeriados, Me.ColVac, Me.ColReajuste, Me.ColDevengado, Me.ColINSSLab, Me.ColPrestamos, Me.ColIR, Me.ColTdeduccion, Me.ColApagar, Me.ColFirma, Me.ColINNSPAT, Me.ColInatec, Me.ColVac2, Me.ColAguinaldo})
        Me.DtgPlanilla.GridColor = System.Drawing.Color.Black
        Me.DtgPlanilla.Location = New System.Drawing.Point(14, 321)
        Me.DtgPlanilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DtgPlanilla.Name = "DtgPlanilla"
        Me.DtgPlanilla.RowHeadersWidth = 51
        Me.DtgPlanilla.RowTemplate.Height = 24
        Me.DtgPlanilla.Size = New System.Drawing.Size(1304, 302)
        Me.DtgPlanilla.TabIndex = 0
        '
        'LblCedula
        '
        Me.LblCedula.AutoSize = True
        Me.LblCedula.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCedula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblCedula.Location = New System.Drawing.Point(43, 127)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(75, 27)
        Me.LblCedula.TabIndex = 1
        Me.LblCedula.Text = "Cedula"
        '
        'TxtNombres
        '
        Me.TxtNombres.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombres.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombres.ForeColor = System.Drawing.Color.Black
        Me.TxtNombres.Location = New System.Drawing.Point(254, 174)
        Me.TxtNombres.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(139, 28)
        Me.TxtNombres.TabIndex = 4
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblNombre.Location = New System.Drawing.Point(43, 174)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(202, 27)
        Me.LblNombre.TabIndex = 3
        Me.LblNombre.Text = "Nombres y apellidos "
        '
        'TxtCargo
        '
        Me.TxtCargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCargo.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCargo.ForeColor = System.Drawing.Color.Black
        Me.TxtCargo.Location = New System.Drawing.Point(254, 219)
        Me.TxtCargo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtCargo.Name = "TxtCargo"
        Me.TxtCargo.Size = New System.Drawing.Size(139, 28)
        Me.TxtCargo.TabIndex = 6
        '
        'LblCargo
        '
        Me.LblCargo.AutoSize = True
        Me.LblCargo.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCargo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblCargo.Location = New System.Drawing.Point(43, 219)
        Me.LblCargo.Name = "LblCargo"
        Me.LblCargo.Size = New System.Drawing.Size(66, 27)
        Me.LblCargo.TabIndex = 5
        Me.LblCargo.Text = "Cargo"
        '
        'TxtSalarioMensual
        '
        Me.TxtSalarioMensual.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtSalarioMensual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSalarioMensual.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSalarioMensual.ForeColor = System.Drawing.Color.Black
        Me.TxtSalarioMensual.Location = New System.Drawing.Point(254, 268)
        Me.TxtSalarioMensual.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtSalarioMensual.Name = "TxtSalarioMensual"
        Me.TxtSalarioMensual.Size = New System.Drawing.Size(139, 28)
        Me.TxtSalarioMensual.TabIndex = 8
        '
        'LblSalMen
        '
        Me.LblSalMen.AutoSize = True
        Me.LblSalMen.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSalMen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblSalMen.Location = New System.Drawing.Point(43, 268)
        Me.LblSalMen.Name = "LblSalMen"
        Me.LblSalMen.Size = New System.Drawing.Size(155, 27)
        Me.LblSalMen.TabIndex = 7
        Me.LblSalMen.Text = "Salario Mensual"
        '
        'TxtPrestamos
        '
        Me.TxtPrestamos.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrestamos.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrestamos.ForeColor = System.Drawing.Color.Black
        Me.TxtPrestamos.Location = New System.Drawing.Point(879, 126)
        Me.TxtPrestamos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtPrestamos.Name = "TxtPrestamos"
        Me.TxtPrestamos.Size = New System.Drawing.Size(139, 28)
        Me.TxtPrestamos.TabIndex = 16
        '
        'LblPrestamos
        '
        Me.LblPrestamos.AutoSize = True
        Me.LblPrestamos.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrestamos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblPrestamos.Location = New System.Drawing.Point(759, 128)
        Me.LblPrestamos.Name = "LblPrestamos"
        Me.LblPrestamos.Size = New System.Drawing.Size(114, 27)
        Me.LblPrestamos.TabIndex = 15
        Me.LblPrestamos.Text = "Prestamos "
        '
        'TxtFeriados
        '
        Me.TxtFeriados.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtFeriados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFeriados.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFeriados.ForeColor = System.Drawing.Color.Black
        Me.TxtFeriados.Location = New System.Drawing.Point(601, 219)
        Me.TxtFeriados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtFeriados.Name = "TxtFeriados"
        Me.TxtFeriados.Size = New System.Drawing.Size(139, 28)
        Me.TxtFeriados.TabIndex = 14
        '
        'LblFeriados
        '
        Me.LblFeriados.AutoSize = True
        Me.LblFeriados.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFeriados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblFeriados.Location = New System.Drawing.Point(432, 219)
        Me.LblFeriados.Name = "LblFeriados"
        Me.LblFeriados.Size = New System.Drawing.Size(90, 27)
        Me.LblFeriados.TabIndex = 13
        Me.LblFeriados.Text = "Feriados"
        '
        'TxtSubsidios
        '
        Me.TxtSubsidios.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtSubsidios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSubsidios.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubsidios.ForeColor = System.Drawing.Color.Black
        Me.TxtSubsidios.Location = New System.Drawing.Point(601, 174)
        Me.TxtSubsidios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtSubsidios.Name = "TxtSubsidios"
        Me.TxtSubsidios.Size = New System.Drawing.Size(139, 28)
        Me.TxtSubsidios.TabIndex = 12
        '
        'LblSubsidios
        '
        Me.LblSubsidios.AutoSize = True
        Me.LblSubsidios.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubsidios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblSubsidios.Location = New System.Drawing.Point(432, 174)
        Me.LblSubsidios.Name = "LblSubsidios"
        Me.LblSubsidios.Size = New System.Drawing.Size(99, 27)
        Me.LblSubsidios.TabIndex = 11
        Me.LblSubsidios.Text = "Subcidios"
        '
        'TxtDiasTrab
        '
        Me.TxtDiasTrab.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtDiasTrab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDiasTrab.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiasTrab.ForeColor = System.Drawing.Color.Black
        Me.TxtDiasTrab.Location = New System.Drawing.Point(601, 126)
        Me.TxtDiasTrab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtDiasTrab.Name = "TxtDiasTrab"
        Me.TxtDiasTrab.Size = New System.Drawing.Size(139, 28)
        Me.TxtDiasTrab.TabIndex = 10
        '
        'LblDiaTrab
        '
        Me.LblDiaTrab.AutoSize = True
        Me.LblDiaTrab.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDiaTrab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblDiaTrab.Location = New System.Drawing.Point(432, 127)
        Me.LblDiaTrab.Name = "LblDiaTrab"
        Me.LblDiaTrab.Size = New System.Drawing.Size(156, 27)
        Me.LblDiaTrab.TabIndex = 9
        Me.LblDiaTrab.Text = "Dias Trabajados"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BtnAgregar.BackgroundImage = Global.Presupuesto_Maestro.My.Resources.Resources._1486564407_plus_green_81521
        Me.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnAgregar.Location = New System.Drawing.Point(1096, 104)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 75)
        Me.BtnAgregar.TabIndex = 17
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BtnEliminar.BackgroundImage = Global.Presupuesto_Maestro.My.Resources.Resources._1486564399_close_81512
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BtnEliminar.Location = New System.Drawing.Point(1096, 221)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 75)
        Me.BtnEliminar.TabIndex = 18
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'TxtVacaciones1
        '
        Me.TxtVacaciones1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtVacaciones1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVacaciones1.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVacaciones1.ForeColor = System.Drawing.Color.Black
        Me.TxtVacaciones1.Location = New System.Drawing.Point(601, 268)
        Me.TxtVacaciones1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtVacaciones1.Name = "TxtVacaciones1"
        Me.TxtVacaciones1.Size = New System.Drawing.Size(139, 28)
        Me.TxtVacaciones1.TabIndex = 20
        '
        'LblVac1
        '
        Me.LblVac1.AutoSize = True
        Me.LblVac1.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVac1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.LblVac1.Location = New System.Drawing.Point(432, 268)
        Me.LblVac1.Name = "LblVac1"
        Me.LblVac1.Size = New System.Drawing.Size(114, 27)
        Me.LblVac1.TabIndex = 19
        Me.LblVac1.Text = "Vacaciones"
        '
        'TxtFirmas
        '
        Me.TxtFirmas.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.TxtFirmas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFirmas.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFirmas.ForeColor = System.Drawing.Color.Black
        Me.TxtFirmas.Location = New System.Drawing.Point(879, 172)
        Me.TxtFirmas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtFirmas.Name = "TxtFirmas"
        Me.TxtFirmas.Size = New System.Drawing.Size(139, 28)
        Me.TxtFirmas.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(759, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 27)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Firmas "
        '
        'MskCedula
        '
        Me.MskCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.MskCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MskCedula.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCedula.ForeColor = System.Drawing.Color.Black
        Me.MskCedula.Location = New System.Drawing.Point(254, 125)
        Me.MskCedula.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MskCedula.Mask = "000-000000-0000?"
        Me.MskCedula.Name = "MskCedula"
        Me.MskCedula.Size = New System.Drawing.Size(139, 28)
        Me.MskCedula.TabIndex = 23
        '
        'ColCedula
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ColCedula.DefaultCellStyle = DataGridViewCellStyle1
        Me.ColCedula.HeaderText = "Cedula"
        Me.ColCedula.MinimumWidth = 6
        Me.ColCedula.Name = "ColCedula"
        Me.ColCedula.ReadOnly = True
        Me.ColCedula.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColCedula.Width = 85
        '
        'ColNombre
        '
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ColNombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColNombre.HeaderText = "Nombre y Apellido"
        Me.ColNombre.MinimumWidth = 6
        Me.ColNombre.Name = "ColNombre"
        Me.ColNombre.ReadOnly = True
        Me.ColNombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColNombre.Width = 153
        '
        'ColCargo
        '
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ColCargo.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColCargo.HeaderText = "Cargo "
        Me.ColCargo.MinimumWidth = 6
        Me.ColCargo.Name = "ColCargo"
        Me.ColCargo.ReadOnly = True
        Me.ColCargo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColCargo.Width = 83
        '
        'ColSalMen
        '
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.ColSalMen.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColSalMen.HeaderText = "Sal/Men"
        Me.ColSalMen.MinimumWidth = 6
        Me.ColSalMen.Name = "ColSalMen"
        Me.ColSalMen.ReadOnly = True
        Me.ColSalMen.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColSalMen.Width = 92
        '
        'ColSalDia
        '
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.ColSalDia.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColSalDia.HeaderText = "Sal/Dia"
        Me.ColSalDia.MinimumWidth = 6
        Me.ColSalDia.Name = "ColSalDia"
        Me.ColSalDia.ReadOnly = True
        Me.ColSalDia.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColSalDia.Width = 86
        '
        'ColTrab
        '
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ColTrab.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColTrab.HeaderText = "Dia Trab"
        Me.ColTrab.MinimumWidth = 6
        Me.ColTrab.Name = "ColTrab"
        Me.ColTrab.ReadOnly = True
        Me.ColTrab.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColTrab.Width = 89
        '
        'ColHExtra
        '
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.ColHExtra.DefaultCellStyle = DataGridViewCellStyle7
        Me.ColHExtra.HeaderText = "H. Extra "
        Me.ColHExtra.MinimumWidth = 6
        Me.ColHExtra.Name = "ColHExtra"
        Me.ColHExtra.ReadOnly = True
        Me.ColHExtra.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColHExtra.Width = 90
        '
        'ColSalBasic
        '
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle8.Format = "C2"
        Me.ColSalBasic.DefaultCellStyle = DataGridViewCellStyle8
        Me.ColSalBasic.HeaderText = "Salario Basico "
        Me.ColSalBasic.MinimumWidth = 6
        Me.ColSalBasic.Name = "ColSalBasic"
        Me.ColSalBasic.ReadOnly = True
        Me.ColSalBasic.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColSalBasic.Width = 128
        '
        'ColSubcidios
        '
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle9.Format = "C2"
        Me.ColSubcidios.DefaultCellStyle = DataGridViewCellStyle9
        Me.ColSubcidios.HeaderText = "Subsidios"
        Me.ColSubcidios.MinimumWidth = 6
        Me.ColSubcidios.Name = "ColSubcidios"
        Me.ColSubcidios.ReadOnly = True
        Me.ColSubcidios.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColSubcidios.Width = 104
        '
        'ColFeriados
        '
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle10.Format = "C2"
        Me.ColFeriados.DefaultCellStyle = DataGridViewCellStyle10
        Me.ColFeriados.HeaderText = "Feriados"
        Me.ColFeriados.MinimumWidth = 6
        Me.ColFeriados.Name = "ColFeriados"
        Me.ColFeriados.ReadOnly = True
        Me.ColFeriados.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColFeriados.Width = 97
        '
        'ColVac
        '
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle11.Format = "C2"
        Me.ColVac.DefaultCellStyle = DataGridViewCellStyle11
        Me.ColVac.HeaderText = "Vac"
        Me.ColVac.MinimumWidth = 6
        Me.ColVac.Name = "ColVac"
        Me.ColVac.ReadOnly = True
        Me.ColVac.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColVac.Width = 63
        '
        'ColReajuste
        '
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle12.Format = "C2"
        Me.ColReajuste.DefaultCellStyle = DataGridViewCellStyle12
        Me.ColReajuste.HeaderText = "Reajustes"
        Me.ColReajuste.MinimumWidth = 6
        Me.ColReajuste.Name = "ColReajuste"
        Me.ColReajuste.ReadOnly = True
        Me.ColReajuste.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColReajuste.Width = 105
        '
        'ColDevengado
        '
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle13.Format = "C2"
        Me.ColDevengado.DefaultCellStyle = DataGridViewCellStyle13
        Me.ColDevengado.HeaderText = "Devengado"
        Me.ColDevengado.MinimumWidth = 6
        Me.ColDevengado.Name = "ColDevengado"
        Me.ColDevengado.ReadOnly = True
        Me.ColDevengado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColDevengado.Width = 117
        '
        'ColINSSLab
        '
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle14.Format = "C2"
        Me.ColINSSLab.DefaultCellStyle = DataGridViewCellStyle14
        Me.ColINSSLab.HeaderText = "INNS Lab"
        Me.ColINSSLab.MinimumWidth = 6
        Me.ColINSSLab.Name = "ColINSSLab"
        Me.ColINSSLab.ReadOnly = True
        Me.ColINSSLab.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColINSSLab.Width = 92
        '
        'ColPrestamos
        '
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle15.Format = "C2"
        Me.ColPrestamos.DefaultCellStyle = DataGridViewCellStyle15
        Me.ColPrestamos.HeaderText = "Prestamos"
        Me.ColPrestamos.MinimumWidth = 6
        Me.ColPrestamos.Name = "ColPrestamos"
        Me.ColPrestamos.ReadOnly = True
        Me.ColPrestamos.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColPrestamos.Width = 113
        '
        'ColIR
        '
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle16.Format = "C2"
        Me.ColIR.DefaultCellStyle = DataGridViewCellStyle16
        Me.ColIR.HeaderText = "IR 10%"
        Me.ColIR.MinimumWidth = 6
        Me.ColIR.Name = "ColIR"
        Me.ColIR.ReadOnly = True
        Me.ColIR.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColIR.Width = 76
        '
        'ColTdeduccion
        '
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle17.Format = "C2"
        Me.ColTdeduccion.DefaultCellStyle = DataGridViewCellStyle17
        Me.ColTdeduccion.HeaderText = "T. Deduccion"
        Me.ColTdeduccion.MinimumWidth = 6
        Me.ColTdeduccion.Name = "ColTdeduccion"
        Me.ColTdeduccion.ReadOnly = True
        Me.ColTdeduccion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColTdeduccion.Width = 119
        '
        'ColApagar
        '
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle18.Format = "C2"
        Me.ColApagar.DefaultCellStyle = DataGridViewCellStyle18
        Me.ColApagar.HeaderText = "A Pagar"
        Me.ColApagar.MinimumWidth = 6
        Me.ColApagar.Name = "ColApagar"
        Me.ColApagar.ReadOnly = True
        Me.ColApagar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColApagar.Width = 86
        '
        'ColFirma
        '
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ColFirma.DefaultCellStyle = DataGridViewCellStyle19
        Me.ColFirma.HeaderText = "Firmas"
        Me.ColFirma.MinimumWidth = 6
        Me.ColFirma.Name = "ColFirma"
        Me.ColFirma.ReadOnly = True
        Me.ColFirma.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColFirma.Width = 85
        '
        'ColINNSPAT
        '
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle20.Format = "C2"
        Me.ColINNSPAT.DefaultCellStyle = DataGridViewCellStyle20
        Me.ColINNSPAT.HeaderText = "INNS Pat"
        Me.ColINNSPAT.MinimumWidth = 6
        Me.ColINNSPAT.Name = "ColINNSPAT"
        Me.ColINNSPAT.ReadOnly = True
        Me.ColINNSPAT.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColINNSPAT.Width = 91
        '
        'ColInatec
        '
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle21.Format = "C2"
        Me.ColInatec.DefaultCellStyle = DataGridViewCellStyle21
        Me.ColInatec.HeaderText = "Inatec"
        Me.ColInatec.MinimumWidth = 6
        Me.ColInatec.Name = "ColInatec"
        Me.ColInatec.ReadOnly = True
        Me.ColInatec.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColInatec.Width = 81
        '
        'ColVac2
        '
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle22.Format = "C2"
        Me.ColVac2.DefaultCellStyle = DataGridViewCellStyle22
        Me.ColVac2.HeaderText = "Vac"
        Me.ColVac2.MinimumWidth = 6
        Me.ColVac2.Name = "ColVac2"
        Me.ColVac2.ReadOnly = True
        Me.ColVac2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColVac2.Width = 63
        '
        'ColAguinaldo
        '
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle23.Format = "C2"
        Me.ColAguinaldo.DefaultCellStyle = DataGridViewCellStyle23
        Me.ColAguinaldo.HeaderText = "Aguinaldo "
        Me.ColAguinaldo.MinimumWidth = 6
        Me.ColAguinaldo.Name = "ColAguinaldo"
        Me.ColAguinaldo.ReadOnly = True
        Me.ColAguinaldo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColAguinaldo.Width = 113
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(1177, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 27)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Eliminar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(1177, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 27)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Agregar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(609, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 38)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Planilla"
        '
        'FrmPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1335, 641)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MskCedula)
        Me.Controls.Add(Me.TxtFirmas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtVacaciones1)
        Me.Controls.Add(Me.LblVac1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.TxtPrestamos)
        Me.Controls.Add(Me.LblPrestamos)
        Me.Controls.Add(Me.TxtFeriados)
        Me.Controls.Add(Me.LblFeriados)
        Me.Controls.Add(Me.TxtSubsidios)
        Me.Controls.Add(Me.LblSubsidios)
        Me.Controls.Add(Me.TxtDiasTrab)
        Me.Controls.Add(Me.LblDiaTrab)
        Me.Controls.Add(Me.TxtSalarioMensual)
        Me.Controls.Add(Me.LblSalMen)
        Me.Controls.Add(Me.TxtCargo)
        Me.Controls.Add(Me.LblCargo)
        Me.Controls.Add(Me.TxtNombres)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblCedula)
        Me.Controls.Add(Me.DtgPlanilla)
        Me.Font = New System.Drawing.Font("Montserrat ExtraBold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmPlanilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planilla"
        CType(Me.DtgPlanilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtgPlanilla As DataGridView
    Friend WithEvents LblCedula As Label
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents TxtCargo As TextBox
    Friend WithEvents LblCargo As Label
    Friend WithEvents TxtSalarioMensual As TextBox
    Friend WithEvents LblSalMen As Label
    Friend WithEvents TxtPrestamos As TextBox
    Friend WithEvents LblPrestamos As Label
    Friend WithEvents TxtFeriados As TextBox
    Friend WithEvents LblFeriados As Label
    Friend WithEvents TxtSubsidios As TextBox
    Friend WithEvents LblSubsidios As Label
    Friend WithEvents TxtDiasTrab As TextBox
    Friend WithEvents LblDiaTrab As Label
    Friend WithEvents TxtVacaciones1 As TextBox
    Friend WithEvents LblVac1 As Label
    Friend WithEvents TxtFirmas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MskCedula As MaskedTextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents ColCedula As DataGridViewTextBoxColumn
    Friend WithEvents ColNombre As DataGridViewTextBoxColumn
    Friend WithEvents ColCargo As DataGridViewTextBoxColumn
    Friend WithEvents ColSalMen As DataGridViewTextBoxColumn
    Friend WithEvents ColSalDia As DataGridViewTextBoxColumn
    Friend WithEvents ColTrab As DataGridViewTextBoxColumn
    Friend WithEvents ColHExtra As DataGridViewTextBoxColumn
    Friend WithEvents ColSalBasic As DataGridViewTextBoxColumn
    Friend WithEvents ColSubcidios As DataGridViewTextBoxColumn
    Friend WithEvents ColFeriados As DataGridViewTextBoxColumn
    Friend WithEvents ColVac As DataGridViewTextBoxColumn
    Friend WithEvents ColReajuste As DataGridViewTextBoxColumn
    Friend WithEvents ColDevengado As DataGridViewTextBoxColumn
    Friend WithEvents ColINSSLab As DataGridViewTextBoxColumn
    Friend WithEvents ColPrestamos As DataGridViewTextBoxColumn
    Friend WithEvents ColIR As DataGridViewTextBoxColumn
    Friend WithEvents ColTdeduccion As DataGridViewTextBoxColumn
    Friend WithEvents ColApagar As DataGridViewTextBoxColumn
    Friend WithEvents ColFirma As DataGridViewTextBoxColumn
    Friend WithEvents ColINNSPAT As DataGridViewTextBoxColumn
    Friend WithEvents ColInatec As DataGridViewTextBoxColumn
    Friend WithEvents ColVac2 As DataGridViewTextBoxColumn
    Friend WithEvents ColAguinaldo As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
