<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmResumen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmResumen))
        Me.TxtTotalMontoR = New System.Windows.Forms.TextBox()
        Me.LblTotalMonto = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCUR = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTotalCTPR = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTotalGifR = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTotalMODR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTotalMPDR = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtTotalMontoR
        '
        Me.TxtTotalMontoR.Enabled = False
        Me.TxtTotalMontoR.Location = New System.Drawing.Point(119, 33)
        Me.TxtTotalMontoR.Name = "TxtTotalMontoR"
        Me.TxtTotalMontoR.ReadOnly = True
        Me.TxtTotalMontoR.Size = New System.Drawing.Size(100, 22)
        Me.TxtTotalMontoR.TabIndex = 0
        '
        'LblTotalMonto
        '
        Me.LblTotalMonto.AutoSize = True
        Me.LblTotalMonto.Location = New System.Drawing.Point(32, 49)
        Me.LblTotalMonto.Name = "LblTotalMonto"
        Me.LblTotalMonto.Size = New System.Drawing.Size(78, 16)
        Me.LblTotalMonto.TabIndex = 1
        Me.LblTotalMonto.Text = "Total Monto"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtTotalMontoR)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(889, 118)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total de Gastos Indirectos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtCUR)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtTotalCTPR)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtTotalGifR)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtTotalMODR)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtTotalMPDR)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(889, 288)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total de Gastos Indirectos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Total Costo Unitario"
        '
        'TxtCUR
        '
        Me.TxtCUR.Enabled = False
        Me.TxtCUR.Location = New System.Drawing.Point(222, 236)
        Me.TxtCUR.Name = "TxtCUR"
        Me.TxtCUR.ReadOnly = True
        Me.TxtCUR.Size = New System.Drawing.Size(100, 22)
        Me.TxtCUR.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Totak Costo de Produccion"
        '
        'TxtTotalCTPR
        '
        Me.TxtTotalCTPR.Enabled = False
        Me.TxtTotalCTPR.Location = New System.Drawing.Point(222, 193)
        Me.TxtTotalCTPR.Name = "TxtTotalCTPR"
        Me.TxtTotalCTPR.ReadOnly = True
        Me.TxtTotalCTPR.Size = New System.Drawing.Size(100, 22)
        Me.TxtTotalCTPR.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Total Gif Asignado"
        '
        'TxtTotalGifR
        '
        Me.TxtTotalGifR.Enabled = False
        Me.TxtTotalGifR.Location = New System.Drawing.Point(222, 147)
        Me.TxtTotalGifR.Name = "TxtTotalGifR"
        Me.TxtTotalGifR.ReadOnly = True
        Me.TxtTotalGifR.Size = New System.Drawing.Size(100, 22)
        Me.TxtTotalGifR.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Total MOD"
        '
        'TxtTotalMODR
        '
        Me.TxtTotalMODR.Enabled = False
        Me.TxtTotalMODR.Location = New System.Drawing.Point(222, 98)
        Me.TxtTotalMODR.Name = "TxtTotalMODR"
        Me.TxtTotalMODR.ReadOnly = True
        Me.TxtTotalMODR.Size = New System.Drawing.Size(100, 22)
        Me.TxtTotalMODR.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Total MPD"
        '
        'TxtTotalMPDR
        '
        Me.TxtTotalMPDR.Enabled = False
        Me.TxtTotalMPDR.Location = New System.Drawing.Point(222, 47)
        Me.TxtTotalMPDR.Name = "TxtTotalMPDR"
        Me.TxtTotalMPDR.ReadOnly = True
        Me.TxtTotalMPDR.Size = New System.Drawing.Size(100, 22)
        Me.TxtTotalMPDR.TabIndex = 12
        '
        'FrmResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(926, 485)
        Me.Controls.Add(Me.LblTotalMonto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmResumen"
        Me.Text = "FrmResumen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtTotalMontoR As TextBox
    Friend WithEvents LblTotalMonto As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtCUR As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTotalCTPR As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTotalGifR As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTotalMODR As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTotalMPDR As TextBox
End Class
