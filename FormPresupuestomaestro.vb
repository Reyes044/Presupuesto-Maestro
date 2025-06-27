Public Class FormPresupuestomaestro
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        LblHora.Text = DateTime.Now.ToLongTimeString()
        LblFecha.Text = DateTime.Now.ToShortDateString()

    End Sub

    Private Sub BtnPresupuestoProduccion_Click(sender As Object, e As EventArgs)
        FormPresupuestoDeProduccion.ShowDialog()
    End Sub

    Private Sub BtnCostoTotalProducción_Click(sender As Object, e As EventArgs) Handles BtnCostoTotalProducción.Click, Button3.Click
        FrmCostoTotalDeProduccion.ShowDialog()
    End Sub

    Private Sub BtnGastosindirectos_Click(sender As Object, e As EventArgs) Handles BtnGastosindirectos.Click
        FrmGastos_Indirectos.ShowDialog()
    End Sub
    Private Sub BtnResumen_Click(sender As Object, e As EventArgs) Handles BtnResumen.Click, Button9.Click
        FrmResumen.ShowDialog()

    End Sub

    Private Sub BtnPlanilla_Click(sender As Object, e As EventArgs) Handles BtnPlanilla.Click, Button10.Click
        FrmPlanilla.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormPresupuestoDeProduccion.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormPresupuestoCaja.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormPresupuestoMOD.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FrmPresupuestoVentas.ShowDialog()
    End Sub
End Class
