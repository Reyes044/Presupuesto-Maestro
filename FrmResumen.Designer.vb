<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmResumen
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
        Me.TxtTotalMonto = New System.Windows.Forms.TextBox()
        Me.LblTotalMonto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtTotalMonto
        '
        Me.TxtTotalMonto.Enabled = False
        Me.TxtTotalMonto.Location = New System.Drawing.Point(131, 38)
        Me.TxtTotalMonto.Name = "TxtTotalMonto"
        Me.TxtTotalMonto.ReadOnly = True
        Me.TxtTotalMonto.Size = New System.Drawing.Size(100, 22)
        Me.TxtTotalMonto.TabIndex = 0
        '
        'LblTotalMonto
        '
        Me.LblTotalMonto.AutoSize = True
        Me.LblTotalMonto.Location = New System.Drawing.Point(47, 38)
        Me.LblTotalMonto.Name = "LblTotalMonto"
        Me.LblTotalMonto.Size = New System.Drawing.Size(78, 16)
        Me.LblTotalMonto.TabIndex = 1
        Me.LblTotalMonto.Text = "Total Monto"
        '
        'FrmResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblTotalMonto)
        Me.Controls.Add(Me.TxtTotalMonto)
        Me.Name = "FrmResumen"
        Me.Text = "FrmResumen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtTotalMonto As TextBox
    Friend WithEvents LblTotalMonto As Label
End Class
