<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPresupuestomaestro
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPresupuestomaestro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.BtnPlanilla = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.BtnResumen = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.BtnGastosindirectos = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnCostoTotalProducción = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(700, 560)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(295, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 22)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Presupuesto de producción" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(874, 254)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 22)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Presupuesto de caja" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(592, 254)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 22)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Gastos Adm. y ventas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(306, 254)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 22)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Gastos indirectos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 254)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 22)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Presupuesto MOD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(879, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(197, 22)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Presupuesto de compras" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(592, 22)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(201, 22)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Costo total de producción"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 483)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 22)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Resumen"
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.LblHora.Font = New System.Drawing.Font("Montserrat Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.LblHora.Location = New System.Drawing.Point(1271, 252)
        Me.LblHora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(45, 22)
        Me.LblHora.TabIndex = 21
        Me.LblHora.Text = "Hora"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Montserrat Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(1264, 292)
        Me.LblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(56, 22)
        Me.LblFecha.TabIndex = 22
        Me.LblFecha.Text = "Fecha"
        '
        'Tiempo
        '
        Me.Tiempo.Enabled = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Montserrat Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1184, 252)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 22)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Hora:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Montserrat Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1184, 292)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 22)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Fecha:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(306, 483)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 22)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Planilla "
        '
        'Button10
        '
        Me.Button10.BackgroundImage = Global.Presupuesto_Maestro.My.Resources.Resources.sobresalir
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button10.Location = New System.Drawing.Point(311, 515)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(232, 160)
        Me.Button10.TabIndex = 27
        Me.Button10.UseVisualStyleBackColor = True
        '
        'BtnPlanilla
        '
        Me.BtnPlanilla.BackgroundImage = Global.Presupuesto_Maestro.My.Resources.Resources.sobresalir
        Me.BtnPlanilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnPlanilla.Location = New System.Drawing.Point(311, 515)
        Me.BtnPlanilla.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnPlanilla.Name = "BtnPlanilla"
        Me.BtnPlanilla.Size = New System.Drawing.Size(232, 160)
        Me.BtnPlanilla.TabIndex = 27
        Me.BtnPlanilla.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1163, 31)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 182)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Button9
        '
        Me.Button9.BackgroundImage = Global.Presupuesto_Maestro.My.Resources.Resources.resumen_de_compra
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button9.Location = New System.Drawing.Point(29, 515)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(232, 160)
        Me.Button9.TabIndex = 10
        Me.Button9.UseVisualStyleBackColor = True
        '
        'BtnResumen
        '
        Me.BtnResumen.BackgroundImage = Global.Presupuesto_Maestro.My.Resources.Resources.resumen_de_compra
        Me.BtnResumen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnResumen.Location = New System.Drawing.Point(29, 515)
        Me.BtnResumen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnResumen.Name = "BtnResumen"
        Me.BtnResumen.Size = New System.Drawing.Size(232, 160)
        Me.BtnResumen.TabIndex = 10
        Me.BtnResumen.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.Presupuesto_Maestro.My.Resources.Resources.costo__1_
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.Location = New System.Drawing.Point(311, 286)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(232, 160)
        Me.Button6.TabIndex = 7
        Me.Button6.UseVisualStyleBackColor = True
        '
        'BtnGastosindirectos
        '
        Me.BtnGastosindirectos.BackgroundImage = Global.Presupuesto_Maestro.My.Resources.Resources.costo__1_
        Me.BtnGastosindirectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnGastosindirectos.Location = New System.Drawing.Point(311, 286)
        Me.BtnGastosindirectos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnGastosindirectos.Name = "BtnGastosindirectos"
        Me.BtnGastosindirectos.Size = New System.Drawing.Size(232, 160)
        Me.BtnGastosindirectos.TabIndex = 7
        Me.BtnGastosindirectos.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Presupuesto_Maestro.My.Resources.Resources.costo
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(597, 54)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(232, 160)
        Me.Button3.TabIndex = 4
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnCostoTotalProducción
        '
        Me.BtnCostoTotalProducción.BackgroundImage = Global.Presupuesto_Maestro.My.Resources.Resources.costo
        Me.BtnCostoTotalProducción.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCostoTotalProducción.Location = New System.Drawing.Point(597, 54)
        Me.BtnCostoTotalProducción.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCostoTotalProducción.Name = "BtnCostoTotalProducción"
        Me.BtnCostoTotalProducción.Size = New System.Drawing.Size(232, 160)
        Me.BtnCostoTotalProducción.TabIndex = 4
        Me.BtnCostoTotalProducción.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 22)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Presupuesto de ventas"
        '
        'FormPresupuestomaestro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1444, 741)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.BtnPlanilla)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LblHora)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.BtnResumen)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.BtnGastosindirectos)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnCostoTotalProducción)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Montserrat", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormPresupuestomaestro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Presupuesto maestro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCostoTotalProducción As Button
    Friend WithEvents BtnGastosindirectos As Button
    Friend WithEvents BtnResumen As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblHora As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents Tiempo As Timer
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnPlanilla As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Label2 As Label
End Class
