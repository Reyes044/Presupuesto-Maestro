Public Class FormPresupuestomaestro

    Private Sub BtnPresupuestoVentas_Click(sender As Object, e As EventArgs) Handles BtnPresupuestoVentas.Click
        FrmPresupuestoVentas.ShowDialog()
    End Sub

    Private Sub BtnPresupuestoCompras_Click(sender As Object, e As EventArgs) Handles BtnPresupuestoCompras.Click
        FormPresupuestodecompras.ShowDialog()
    End Sub

    Private Sub BtnGastoAdmyVentas_Click(sender As Object, e As EventArgs) Handles BtnGastoAdmyVentas.Click
        FormGastosAdmyVentas.ShowDialog()
    End Sub
End Class
