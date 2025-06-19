Public Class FrmGastos_Indirectos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim concepto As String = TxtConcepto.Text
        Dim monto As Decimal = TxtMonto.Text

        DtgGastosIndirectos.Rows.Add(concepto, monto)

    End Sub
End Class