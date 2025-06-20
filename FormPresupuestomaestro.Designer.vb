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
        Me.BtnPresupuestoVentas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnPresupuestoProduccion = New System.Windows.Forms.Button()
        Me.BtnCostoTotalProducción = New System.Windows.Forms.Button()
        Me.BtnPresupuestoCompras = New System.Windows.Forms.Button()
        Me.BtnPresupuestoMod = New System.Windows.Forms.Button()
        Me.BtnGastosindirectos = New System.Windows.Forms.Button()
        Me.BtnGastoAdmyVentas = New System.Windows.Forms.Button()
        Me.BtnPresupuestoCaja = New System.Windows.Forms.Button()
        Me.BtnResumen = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnPresupuestoVentas
        '
        Me.BtnPresupuestoVentas.Location = New System.Drawing.Point(104, 35)
        Me.BtnPresupuestoVentas.Name = "BtnPresupuestoVentas"
        Me.BtnPresupuestoVentas.Size = New System.Drawing.Size(174, 104)
        Me.BtnPresupuestoVentas.TabIndex = 1
        Me.BtnPresupuestoVentas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(525, 364)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 2
        '
        'BtnPresupuestoProduccion
        '
        Me.BtnPresupuestoProduccion.Location = New System.Drawing.Point(316, 35)
        Me.BtnPresupuestoProduccion.Name = "BtnPresupuestoProduccion"
        Me.BtnPresupuestoProduccion.Size = New System.Drawing.Size(174, 104)
        Me.BtnPresupuestoProduccion.TabIndex = 3
        Me.BtnPresupuestoProduccion.UseVisualStyleBackColor = True
        '
        'BtnCostoTotalProducción
        '
        Me.BtnCostoTotalProducción.Location = New System.Drawing.Point(530, 35)
        Me.BtnCostoTotalProducción.Name = "BtnCostoTotalProducción"
        Me.BtnCostoTotalProducción.Size = New System.Drawing.Size(174, 104)
        Me.BtnCostoTotalProducción.TabIndex = 4
        Me.BtnCostoTotalProducción.UseVisualStyleBackColor = True
        '
        'BtnPresupuestoCompras
        '
        Me.BtnPresupuestoCompras.Location = New System.Drawing.Point(742, 35)
        Me.BtnPresupuestoCompras.Name = "BtnPresupuestoCompras"
        Me.BtnPresupuestoCompras.Size = New System.Drawing.Size(174, 104)
        Me.BtnPresupuestoCompras.TabIndex = 5
        Me.BtnPresupuestoCompras.UseVisualStyleBackColor = True
        '
        'BtnPresupuestoMod
        '
        Me.BtnPresupuestoMod.Location = New System.Drawing.Point(104, 186)
        Me.BtnPresupuestoMod.Name = "BtnPresupuestoMod"
        Me.BtnPresupuestoMod.Size = New System.Drawing.Size(174, 104)
        Me.BtnPresupuestoMod.TabIndex = 6
        Me.BtnPresupuestoMod.UseVisualStyleBackColor = True
        '
        'BtnGastosindirectos
        '
        Me.BtnGastosindirectos.Location = New System.Drawing.Point(316, 186)
        Me.BtnGastosindirectos.Name = "BtnGastosindirectos"
        Me.BtnGastosindirectos.Size = New System.Drawing.Size(174, 104)
        Me.BtnGastosindirectos.TabIndex = 7
        Me.BtnGastosindirectos.UseVisualStyleBackColor = True
        '
        'BtnGastoAdmyVentas
        '
        Me.BtnGastoAdmyVentas.Location = New System.Drawing.Point(530, 186)
        Me.BtnGastoAdmyVentas.Name = "BtnGastoAdmyVentas"
        Me.BtnGastoAdmyVentas.Size = New System.Drawing.Size(174, 104)
        Me.BtnGastoAdmyVentas.TabIndex = 8
        Me.BtnGastoAdmyVentas.UseVisualStyleBackColor = True
        '
        'BtnPresupuestoCaja
        '
        Me.BtnPresupuestoCaja.Location = New System.Drawing.Point(742, 186)
        Me.BtnPresupuestoCaja.Name = "BtnPresupuestoCaja"
        Me.BtnPresupuestoCaja.Size = New System.Drawing.Size(174, 104)
        Me.BtnPresupuestoCaja.TabIndex = 9
        Me.BtnPresupuestoCaja.UseVisualStyleBackColor = True
        '
        'BtnResumen
        '
        Me.BtnResumen.Location = New System.Drawing.Point(104, 335)
        Me.BtnResumen.Name = "BtnResumen"
        Me.BtnResumen.Size = New System.Drawing.Size(174, 104)
        Me.BtnResumen.TabIndex = 10
        Me.BtnResumen.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 22)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Presupuesto de ventas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(323, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 22)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Presupuesto de producción" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(768, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 22)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Presupuesto de caja" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(557, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 22)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Gastos Adm. y ventas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(357, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 22)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Gastos indirectos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(139, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 22)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Presupuesto MOD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(756, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 22)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Presupuesto de compras" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(544, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 22)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Costo total de producción"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bodoni MT Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(160, 310)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 22)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Resumen"
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LblHora.Font = New System.Drawing.Font("Bodoni MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LblHora.Location = New System.Drawing.Point(1059, 160)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(43, 28)
        Me.LblHora.TabIndex = 21
        Me.LblHora.Text = "Hora"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Bodoni MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(1059, 189)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(43, 24)
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
        Me.Label11.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(975, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Hora:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(975, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 20)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Fecha:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(970, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'FormPresupuestomaestro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 482)
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
        Me.Controls.Add(Me.BtnResumen)
        Me.Controls.Add(Me.BtnPresupuestoCaja)
        Me.Controls.Add(Me.BtnGastoAdmyVentas)
        Me.Controls.Add(Me.BtnGastosindirectos)
        Me.Controls.Add(Me.BtnPresupuestoMod)
        Me.Controls.Add(Me.BtnPresupuestoCompras)
        Me.Controls.Add(Me.BtnCostoTotalProducción)
        Me.Controls.Add(Me.BtnPresupuestoProduccion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnPresupuestoVentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPresupuestomaestro"
        Me.Text = "Presupuesto maestro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnPresupuestoVentas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnPresupuestoProduccion As Button
    Friend WithEvents BtnCostoTotalProducción As Button
    Friend WithEvents BtnPresupuestoCompras As Button
    Friend WithEvents BtnPresupuestoMod As Button
    Friend WithEvents BtnGastosindirectos As Button
    Friend WithEvents BtnGastoAdmyVentas As Button
    Friend WithEvents BtnPresupuestoCaja As Button
    Friend WithEvents BtnResumen As Button
    Friend WithEvents Label2 As Label
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
End Class
