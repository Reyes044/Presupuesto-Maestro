Public Class FrmResumen
    Private Sub FrmResumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtTotalMonto.Text = Modulo_Totales.TotalMonto
    End Sub
End Class