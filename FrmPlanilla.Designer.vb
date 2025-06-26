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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPlanilla))
        Me.DtgPlanilla = New System.Windows.Forms.DataGridView()
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
        CType(Me.DtgPlanilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtgPlanilla
        '
        Me.DtgPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgPlanilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColCedula, Me.ColNombre, Me.ColCargo, Me.ColSalMen, Me.ColSalDia, Me.ColTrab, Me.ColHExtra, Me.ColSalBasic, Me.ColSubcidios, Me.ColFeriados, Me.ColVac, Me.ColReajuste, Me.ColDevengado, Me.ColINSSLab, Me.ColPrestamos, Me.ColIR, Me.ColTdeduccion, Me.ColApagar, Me.ColFirma, Me.ColINNSPAT, Me.ColInatec, Me.ColVac2, Me.ColAguinaldo})
        Me.DtgPlanilla.Location = New System.Drawing.Point(12, 206)
        Me.DtgPlanilla.Name = "DtgPlanilla"
        Me.DtgPlanilla.RowHeadersWidth = 51
        Me.DtgPlanilla.RowTemplate.Height = 24
        Me.DtgPlanilla.Size = New System.Drawing.Size(1397, 242)
        Me.DtgPlanilla.TabIndex = 0
        '
        'ColCedula
        '
        Me.ColCedula.HeaderText = "Cedula"
        Me.ColCedula.MinimumWidth = 6
        Me.ColCedula.Name = "ColCedula"
        Me.ColCedula.ReadOnly = True
        Me.ColCedula.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColCedula.Width = 125
        '
        'ColNombre
        '
        Me.ColNombre.HeaderText = "Nombre y Apellido"
        Me.ColNombre.MinimumWidth = 6
        Me.ColNombre.Name = "ColNombre"
        Me.ColNombre.ReadOnly = True
        Me.ColNombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColNombre.Width = 125
        '
        'ColCargo
        '
        Me.ColCargo.HeaderText = "Cargo "
        Me.ColCargo.MinimumWidth = 6
        Me.ColCargo.Name = "ColCargo"
        Me.ColCargo.ReadOnly = True
        Me.ColCargo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColCargo.Width = 125
        '
        'ColSalMen
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.ColSalMen.DefaultCellStyle = DataGridViewCellStyle1
        Me.ColSalMen.HeaderText = "Sal/Men"
        Me.ColSalMen.MinimumWidth = 6
        Me.ColSalMen.Name = "ColSalMen"
        Me.ColSalMen.ReadOnly = True
        Me.ColSalMen.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColSalMen.Width = 125
        '
        'ColSalDia
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.ColSalDia.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColSalDia.HeaderText = "Sal/Dia"
        Me.ColSalDia.MinimumWidth = 6
        Me.ColSalDia.Name = "ColSalDia"
        Me.ColSalDia.ReadOnly = True
        Me.ColSalDia.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColSalDia.Width = 125
        '
        'ColTrab
        '
        Me.ColTrab.HeaderText = "Dia Trab"
        Me.ColTrab.MinimumWidth = 6
        Me.ColTrab.Name = "ColTrab"
        Me.ColTrab.ReadOnly = True
        Me.ColTrab.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColTrab.Width = 125
        '
        'ColHExtra
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ColHExtra.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColHExtra.HeaderText = "H. Extra "
        Me.ColHExtra.MinimumWidth = 6
        Me.ColHExtra.Name = "ColHExtra"
        Me.ColHExtra.ReadOnly = True
        Me.ColHExtra.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColHExtra.Width = 125
        '
        'ColSalBasic
        '
        DataGridViewCellStyle4.Format = "C2"
        Me.ColSalBasic.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColSalBasic.HeaderText = "Salario Basico "
        Me.ColSalBasic.MinimumWidth = 6
        Me.ColSalBasic.Name = "ColSalBasic"
        Me.ColSalBasic.ReadOnly = True
        Me.ColSalBasic.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColSalBasic.Width = 125
        '
        'ColSubcidios
        '
        DataGridViewCellStyle5.Format = "C2"
        Me.ColSubcidios.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColSubcidios.HeaderText = "Subsidios"
        Me.ColSubcidios.MinimumWidth = 6
        Me.ColSubcidios.Name = "ColSubcidios"
        Me.ColSubcidios.ReadOnly = True
        Me.ColSubcidios.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColSubcidios.Width = 125
        '
        'ColFeriados
        '
        DataGridViewCellStyle6.Format = "C2"
        Me.ColFeriados.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColFeriados.HeaderText = "Feriados"
        Me.ColFeriados.MinimumWidth = 6
        Me.ColFeriados.Name = "ColFeriados"
        Me.ColFeriados.ReadOnly = True
        Me.ColFeriados.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColFeriados.Width = 125
        '
        'ColVac
        '
        DataGridViewCellStyle7.Format = "C2"
        Me.ColVac.DefaultCellStyle = DataGridViewCellStyle7
        Me.ColVac.HeaderText = "Vac"
        Me.ColVac.MinimumWidth = 6
        Me.ColVac.Name = "ColVac"
        Me.ColVac.ReadOnly = True
        Me.ColVac.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColVac.Width = 125
        '
        'ColReajuste
        '
        DataGridViewCellStyle8.Format = "C2"
        Me.ColReajuste.DefaultCellStyle = DataGridViewCellStyle8
        Me.ColReajuste.HeaderText = "Reajustes"
        Me.ColReajuste.MinimumWidth = 6
        Me.ColReajuste.Name = "ColReajuste"
        Me.ColReajuste.ReadOnly = True
        Me.ColReajuste.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColReajuste.Width = 125
        '
        'ColDevengado
        '
        DataGridViewCellStyle9.Format = "C2"
        Me.ColDevengado.DefaultCellStyle = DataGridViewCellStyle9
        Me.ColDevengado.HeaderText = "Devengado"
        Me.ColDevengado.MinimumWidth = 6
        Me.ColDevengado.Name = "ColDevengado"
        Me.ColDevengado.ReadOnly = True
        Me.ColDevengado.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColDevengado.Width = 125
        '
        'ColINSSLab
        '
        DataGridViewCellStyle10.Format = "C2"
        Me.ColINSSLab.DefaultCellStyle = DataGridViewCellStyle10
        Me.ColINSSLab.HeaderText = "INNS Lab"
        Me.ColINSSLab.MinimumWidth = 6
        Me.ColINSSLab.Name = "ColINSSLab"
        Me.ColINSSLab.ReadOnly = True
        Me.ColINSSLab.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColINSSLab.Width = 125
        '
        'ColPrestamos
        '
        DataGridViewCellStyle11.Format = "C2"
        Me.ColPrestamos.DefaultCellStyle = DataGridViewCellStyle11
        Me.ColPrestamos.HeaderText = "Prestamos"
        Me.ColPrestamos.MinimumWidth = 6
        Me.ColPrestamos.Name = "ColPrestamos"
        Me.ColPrestamos.ReadOnly = True
        Me.ColPrestamos.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColPrestamos.Width = 125
        '
        'ColIR
        '
        DataGridViewCellStyle12.Format = "C2"
        Me.ColIR.DefaultCellStyle = DataGridViewCellStyle12
        Me.ColIR.HeaderText = "IR 10%"
        Me.ColIR.MinimumWidth = 6
        Me.ColIR.Name = "ColIR"
        Me.ColIR.ReadOnly = True
        Me.ColIR.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColIR.Width = 125
        '
        'ColTdeduccion
        '
        DataGridViewCellStyle13.Format = "C2"
        Me.ColTdeduccion.DefaultCellStyle = DataGridViewCellStyle13
        Me.ColTdeduccion.HeaderText = "T. Deduccion"
        Me.ColTdeduccion.MinimumWidth = 6
        Me.ColTdeduccion.Name = "ColTdeduccion"
        Me.ColTdeduccion.ReadOnly = True
        Me.ColTdeduccion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColTdeduccion.Width = 125
        '
        'ColApagar
        '
        DataGridViewCellStyle14.Format = "C2"
        Me.ColApagar.DefaultCellStyle = DataGridViewCellStyle14
        Me.ColApagar.HeaderText = "A Pagar"
        Me.ColApagar.MinimumWidth = 6
        Me.ColApagar.Name = "ColApagar"
        Me.ColApagar.ReadOnly = True
        Me.ColApagar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColApagar.Width = 125
        '
        'ColFirma
        '
        Me.ColFirma.HeaderText = "Firmas"
        Me.ColFirma.MinimumWidth = 6
        Me.ColFirma.Name = "ColFirma"
        Me.ColFirma.ReadOnly = True
        Me.ColFirma.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColFirma.Width = 125
        '
        'ColINNSPAT
        '
        DataGridViewCellStyle15.Format = "C2"
        Me.ColINNSPAT.DefaultCellStyle = DataGridViewCellStyle15
        Me.ColINNSPAT.HeaderText = "INNS Pat"
        Me.ColINNSPAT.MinimumWidth = 6
        Me.ColINNSPAT.Name = "ColINNSPAT"
        Me.ColINNSPAT.ReadOnly = True
        Me.ColINNSPAT.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColINNSPAT.Width = 125
        '
        'ColInatec
        '
        DataGridViewCellStyle16.Format = "C2"
        Me.ColInatec.DefaultCellStyle = DataGridViewCellStyle16
        Me.ColInatec.HeaderText = "Inatec"
        Me.ColInatec.MinimumWidth = 6
        Me.ColInatec.Name = "ColInatec"
        Me.ColInatec.ReadOnly = True
        Me.ColInatec.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColInatec.Width = 125
        '
        'ColVac2
        '
        DataGridViewCellStyle17.Format = "C2"
        Me.ColVac2.DefaultCellStyle = DataGridViewCellStyle17
        Me.ColVac2.HeaderText = "Vac"
        Me.ColVac2.MinimumWidth = 6
        Me.ColVac2.Name = "ColVac2"
        Me.ColVac2.ReadOnly = True
        Me.ColVac2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColVac2.Width = 125
        '
        'ColAguinaldo
        '
        DataGridViewCellStyle18.Format = "C2"
        Me.ColAguinaldo.DefaultCellStyle = DataGridViewCellStyle18
        Me.ColAguinaldo.HeaderText = "Aguinaldo "
        Me.ColAguinaldo.MinimumWidth = 6
        Me.ColAguinaldo.Name = "ColAguinaldo"
        Me.ColAguinaldo.ReadOnly = True
        Me.ColAguinaldo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColAguinaldo.Width = 125
        '
        'LblCedula
        '
        Me.LblCedula.AutoSize = True
        Me.LblCedula.Location = New System.Drawing.Point(38, 51)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(50, 16)
        Me.LblCedula.TabIndex = 1
        Me.LblCedula.Text = "Cedula"
        '
        'TxtNombres
        '
        Me.TxtNombres.Location = New System.Drawing.Point(182, 83)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(100, 22)
        Me.TxtNombres.TabIndex = 4
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(38, 89)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(135, 16)
        Me.LblNombre.TabIndex = 3
        Me.LblNombre.Text = "Nombres y apellidos "
        '
        'TxtCargo
        '
        Me.TxtCargo.Location = New System.Drawing.Point(182, 119)
        Me.TxtCargo.Name = "TxtCargo"
        Me.TxtCargo.Size = New System.Drawing.Size(100, 22)
        Me.TxtCargo.TabIndex = 6
        '
        'LblCargo
        '
        Me.LblCargo.AutoSize = True
        Me.LblCargo.Location = New System.Drawing.Point(38, 125)
        Me.LblCargo.Name = "LblCargo"
        Me.LblCargo.Size = New System.Drawing.Size(44, 16)
        Me.LblCargo.TabIndex = 5
        Me.LblCargo.Text = "Cargo"
        '
        'TxtSalarioMensual
        '
        Me.TxtSalarioMensual.Location = New System.Drawing.Point(182, 158)
        Me.TxtSalarioMensual.Name = "TxtSalarioMensual"
        Me.TxtSalarioMensual.Size = New System.Drawing.Size(100, 22)
        Me.TxtSalarioMensual.TabIndex = 8
        '
        'LblSalMen
        '
        Me.LblSalMen.AutoSize = True
        Me.LblSalMen.Location = New System.Drawing.Point(38, 164)
        Me.LblSalMen.Name = "LblSalMen"
        Me.LblSalMen.Size = New System.Drawing.Size(104, 16)
        Me.LblSalMen.TabIndex = 7
        Me.LblSalMen.Text = "Salario Mensual"
        '
        'TxtPrestamos
        '
        Me.TxtPrestamos.Location = New System.Drawing.Point(804, 45)
        Me.TxtPrestamos.Name = "TxtPrestamos"
        Me.TxtPrestamos.Size = New System.Drawing.Size(100, 22)
        Me.TxtPrestamos.TabIndex = 16
        '
        'LblPrestamos
        '
        Me.LblPrestamos.AutoSize = True
        Me.LblPrestamos.Location = New System.Drawing.Point(666, 51)
        Me.LblPrestamos.Name = "LblPrestamos"
        Me.LblPrestamos.Size = New System.Drawing.Size(75, 16)
        Me.LblPrestamos.TabIndex = 15
        Me.LblPrestamos.Text = "Prestamos "
        '
        'TxtFeriados
        '
        Me.TxtFeriados.Location = New System.Drawing.Point(522, 119)
        Me.TxtFeriados.Name = "TxtFeriados"
        Me.TxtFeriados.Size = New System.Drawing.Size(100, 22)
        Me.TxtFeriados.TabIndex = 14
        '
        'LblFeriados
        '
        Me.LblFeriados.AutoSize = True
        Me.LblFeriados.Location = New System.Drawing.Point(384, 125)
        Me.LblFeriados.Name = "LblFeriados"
        Me.LblFeriados.Size = New System.Drawing.Size(61, 16)
        Me.LblFeriados.TabIndex = 13
        Me.LblFeriados.Text = "Feriados"
        '
        'TxtSubsidios
        '
        Me.TxtSubsidios.Location = New System.Drawing.Point(522, 83)
        Me.TxtSubsidios.Name = "TxtSubsidios"
        Me.TxtSubsidios.Size = New System.Drawing.Size(100, 22)
        Me.TxtSubsidios.TabIndex = 12
        '
        'LblSubsidios
        '
        Me.LblSubsidios.AutoSize = True
        Me.LblSubsidios.Location = New System.Drawing.Point(384, 89)
        Me.LblSubsidios.Name = "LblSubsidios"
        Me.LblSubsidios.Size = New System.Drawing.Size(67, 16)
        Me.LblSubsidios.TabIndex = 11
        Me.LblSubsidios.Text = "Subcidios"
        '
        'TxtDiasTrab
        '
        Me.TxtDiasTrab.Location = New System.Drawing.Point(522, 45)
        Me.TxtDiasTrab.Name = "TxtDiasTrab"
        Me.TxtDiasTrab.Size = New System.Drawing.Size(100, 22)
        Me.TxtDiasTrab.TabIndex = 10
        '
        'LblDiaTrab
        '
        Me.LblDiaTrab.AutoSize = True
        Me.LblDiaTrab.Location = New System.Drawing.Point(384, 51)
        Me.LblDiaTrab.Name = "LblDiaTrab"
        Me.LblDiaTrab.Size = New System.Drawing.Size(109, 16)
        Me.LblDiaTrab.TabIndex = 9
        Me.LblDiaTrab.Text = "Dias Trabajados"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(1026, 42)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(106, 35)
        Me.BtnAgregar.TabIndex = 17
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(1026, 106)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(106, 35)
        Me.BtnEliminar.TabIndex = 18
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'TxtVacaciones1
        '
        Me.TxtVacaciones1.Location = New System.Drawing.Point(522, 158)
        Me.TxtVacaciones1.Name = "TxtVacaciones1"
        Me.TxtVacaciones1.Size = New System.Drawing.Size(100, 22)
        Me.TxtVacaciones1.TabIndex = 20
        '
        'LblVac1
        '
        Me.LblVac1.AutoSize = True
        Me.LblVac1.Location = New System.Drawing.Point(384, 164)
        Me.LblVac1.Name = "LblVac1"
        Me.LblVac1.Size = New System.Drawing.Size(79, 16)
        Me.LblVac1.TabIndex = 19
        Me.LblVac1.Text = "Vacaciones"
        '
        'TxtFirmas
        '
        Me.TxtFirmas.Location = New System.Drawing.Point(804, 80)
        Me.TxtFirmas.Name = "TxtFirmas"
        Me.TxtFirmas.Size = New System.Drawing.Size(100, 22)
        Me.TxtFirmas.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(666, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Firmas "
        '
        'MskCedula
        '
        Me.MskCedula.Location = New System.Drawing.Point(182, 51)
        Me.MskCedula.Mask = "000-000000-0000?"
        Me.MskCedula.Name = "MskCedula"
        Me.MskCedula.Size = New System.Drawing.Size(100, 22)
        Me.MskCedula.TabIndex = 23
        '
        'FrmPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1426, 647)
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
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPlanilla"
        Me.Text = "FrmPlanilla"
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
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TxtVacaciones1 As TextBox
    Friend WithEvents LblVac1 As Label
    Friend WithEvents TxtFirmas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MskCedula As MaskedTextBox
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
End Class
