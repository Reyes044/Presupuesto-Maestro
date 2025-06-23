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
        Me.TxtCedula = New System.Windows.Forms.TextBox()
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
        Me.ColCedula.Width = 125
        '
        'ColNombre
        '
        Me.ColNombre.HeaderText = "Nombre y Apellido"
        Me.ColNombre.MinimumWidth = 6
        Me.ColNombre.Name = "ColNombre"
        Me.ColNombre.Width = 125
        '
        'ColCargo
        '
        Me.ColCargo.HeaderText = "Cargo "
        Me.ColCargo.MinimumWidth = 6
        Me.ColCargo.Name = "ColCargo"
        Me.ColCargo.Width = 125
        '
        'ColSalMen
        '
        Me.ColSalMen.HeaderText = "Sal/Men"
        Me.ColSalMen.MinimumWidth = 6
        Me.ColSalMen.Name = "ColSalMen"
        Me.ColSalMen.Width = 125
        '
        'ColSalDia
        '
        Me.ColSalDia.HeaderText = "Sal/Dia"
        Me.ColSalDia.MinimumWidth = 6
        Me.ColSalDia.Name = "ColSalDia"
        Me.ColSalDia.Width = 125
        '
        'ColTrab
        '
        Me.ColTrab.HeaderText = "Dia Trab"
        Me.ColTrab.MinimumWidth = 6
        Me.ColTrab.Name = "ColTrab"
        Me.ColTrab.Width = 125
        '
        'ColHExtra
        '
        Me.ColHExtra.HeaderText = "H. Extra "
        Me.ColHExtra.MinimumWidth = 6
        Me.ColHExtra.Name = "ColHExtra"
        Me.ColHExtra.Width = 125
        '
        'ColSalBasic
        '
        Me.ColSalBasic.HeaderText = "Salario Basico "
        Me.ColSalBasic.MinimumWidth = 6
        Me.ColSalBasic.Name = "ColSalBasic"
        Me.ColSalBasic.Width = 125
        '
        'ColSubcidios
        '
        Me.ColSubcidios.HeaderText = "Subsidios"
        Me.ColSubcidios.MinimumWidth = 6
        Me.ColSubcidios.Name = "ColSubcidios"
        Me.ColSubcidios.Width = 125
        '
        'ColFeriados
        '
        Me.ColFeriados.HeaderText = "Feriados"
        Me.ColFeriados.MinimumWidth = 6
        Me.ColFeriados.Name = "ColFeriados"
        Me.ColFeriados.Width = 125
        '
        'ColVac
        '
        Me.ColVac.HeaderText = "Vac"
        Me.ColVac.MinimumWidth = 6
        Me.ColVac.Name = "ColVac"
        Me.ColVac.Width = 125
        '
        'ColReajuste
        '
        Me.ColReajuste.HeaderText = "Reajustes"
        Me.ColReajuste.MinimumWidth = 6
        Me.ColReajuste.Name = "ColReajuste"
        Me.ColReajuste.Width = 125
        '
        'ColDevengado
        '
        Me.ColDevengado.HeaderText = "Devengado"
        Me.ColDevengado.MinimumWidth = 6
        Me.ColDevengado.Name = "ColDevengado"
        Me.ColDevengado.Width = 125
        '
        'ColINSSLab
        '
        Me.ColINSSLab.HeaderText = "INNS Lab"
        Me.ColINSSLab.MinimumWidth = 6
        Me.ColINSSLab.Name = "ColINSSLab"
        Me.ColINSSLab.Width = 125
        '
        'ColPrestamos
        '
        Me.ColPrestamos.HeaderText = "Prestamos"
        Me.ColPrestamos.MinimumWidth = 6
        Me.ColPrestamos.Name = "ColPrestamos"
        Me.ColPrestamos.Width = 125
        '
        'ColIR
        '
        Me.ColIR.HeaderText = "IR 10%"
        Me.ColIR.MinimumWidth = 6
        Me.ColIR.Name = "ColIR"
        Me.ColIR.Width = 125
        '
        'ColTdeduccion
        '
        Me.ColTdeduccion.HeaderText = "T. Deduccion"
        Me.ColTdeduccion.MinimumWidth = 6
        Me.ColTdeduccion.Name = "ColTdeduccion"
        Me.ColTdeduccion.Width = 125
        '
        'ColApagar
        '
        Me.ColApagar.HeaderText = "A Pagar"
        Me.ColApagar.MinimumWidth = 6
        Me.ColApagar.Name = "ColApagar"
        Me.ColApagar.Width = 125
        '
        'ColFirma
        '
        Me.ColFirma.HeaderText = "Firmas"
        Me.ColFirma.MinimumWidth = 6
        Me.ColFirma.Name = "ColFirma"
        Me.ColFirma.Width = 125
        '
        'ColINNSPAT
        '
        Me.ColINNSPAT.HeaderText = "INNS Pat"
        Me.ColINNSPAT.MinimumWidth = 6
        Me.ColINNSPAT.Name = "ColINNSPAT"
        Me.ColINNSPAT.Width = 125
        '
        'ColInatec
        '
        Me.ColInatec.HeaderText = "Inatec"
        Me.ColInatec.MinimumWidth = 6
        Me.ColInatec.Name = "ColInatec"
        Me.ColInatec.Width = 125
        '
        'ColVac2
        '
        Me.ColVac2.HeaderText = "Vac"
        Me.ColVac2.MinimumWidth = 6
        Me.ColVac2.Name = "ColVac2"
        Me.ColVac2.Width = 125
        '
        'ColAguinaldo
        '
        Me.ColAguinaldo.HeaderText = "Aguinaldo "
        Me.ColAguinaldo.MinimumWidth = 6
        Me.ColAguinaldo.Name = "ColAguinaldo"
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
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(182, 45)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(100, 22)
        Me.TxtCedula.TabIndex = 2
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
        Me.TxtPrestamos.Location = New System.Drawing.Point(522, 158)
        Me.TxtPrestamos.Name = "TxtPrestamos"
        Me.TxtPrestamos.Size = New System.Drawing.Size(100, 22)
        Me.TxtPrestamos.TabIndex = 16
        '
        'LblPrestamos
        '
        Me.LblPrestamos.AutoSize = True
        Me.LblPrestamos.Location = New System.Drawing.Point(384, 164)
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
        'FrmPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1426, 647)
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
        Me.Controls.Add(Me.TxtCedula)
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
    Friend WithEvents LblCedula As Label
    Friend WithEvents TxtCedula As TextBox
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
End Class
