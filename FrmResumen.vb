Public Class FrmResumen
    Private Sub FrmResumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtTotalMontoR.Text = Modulo_Totales.TotalMonto
        TxtTotalMPDR.Text = Modulo_Totales.TotalMPD
        TxtTotalMODR.Text = Modulo_Totales.TotalMOD
        TxtTotalGifR.Text = Modulo_Totales.TotalGIF
        TxtTotalCTPR.Text = Modulo_Totales.TotalCTP
    End Sub


End Class