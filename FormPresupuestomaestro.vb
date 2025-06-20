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

    Private Sub BtnPresupuestoMod_Click(sender As Object, e As EventArgs) Handles BtnPresupuestoMod.Click
        FormPresupuestoMOD.ShowDialog()
    End Sub

    Private Sub BtnPresupuestoCaja_Click(sender As Object, e As EventArgs) Handles BtnPresupuestoCaja.Click
        FormPresupuestoCaja.ShowDialog()
    End Sub
End Class
