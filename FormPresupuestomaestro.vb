Public Class FormPresupuestomaestro
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnPresupuestoVentas_Click(sender As Object, e As EventArgs) Handles BtnPresupuestoVentas.Click
        FrmPresupuestoVentas.ShowDialog()
    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        LblHora.Text = DateTime.Now.ToLongTimeString()
        LblFecha.Text = DateTime.Now.ToShortDateString()

    End Sub

    Private Sub BtnPresupuestoProduccion_Click(sender As Object, e As EventArgs) Handles BtnPresupuestoProduccion.Click
        FormPresupuestoDeProduccion.ShowDialog()
    End Sub

    Private Sub BtnCostoTotalProducción_Click(sender As Object, e As EventArgs) Handles BtnCostoTotalProducción.Click
        FrmCostoTotalDeProduccion.ShowDialog()
    End Sub

    Private Sub BtnGastosindirectos_Click(sender As Object, e As EventArgs) Handles BtnGastosindirectos.Click
        FrmGastos_Indirectos.ShowDialog()
    End Sub
    Private Sub BtnResumen_Click(sender As Object, e As EventArgs) Handles BtnResumen.Click
        FrmResumen.ShowDialog()

    End Sub

    Private Sub BtnPlanilla_Click(sender As Object, e As EventArgs) Handles BtnPlanilla.Click
        FrmPlanilla.ShowDialog()
    End Sub
End Class
