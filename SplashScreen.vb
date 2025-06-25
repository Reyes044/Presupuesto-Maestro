Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerCargando.Start()
        ProgressBarCargando.Value = 0

    End Sub

    Private Sub TimerCargando_Tick(sender As Object, e As EventArgs) Handles TimerCargando.Tick

        ProgressBarCargando.Increment(3)

        If ProgressBarCargando.Value >= 100 Then
            TimerCargando.Stop()
            Me.Hide()
            FormPresupuestomaestro.ShowDialog()
            Me.Close()

        End If
    End Sub
End Class