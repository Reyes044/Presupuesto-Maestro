Imports System.Media

Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Intro, AudioPlayMode.Background)
        TimerCargando.Start()
        ProgressBarLoading.Value = 0

    End Sub

    Private Sub TimerCargando_Tick(sender As Object, e As EventArgs) Handles TimerCargando.Tick

        ProgressBarLoading.Increment(2)

        If ProgressBarLoading.Value >= 100 Then
            TimerCargando.Stop()
            Me.Hide()
            FormPresupuestomaestro.ShowDialog()
            Me.Close()

        End If
    End Sub


End Class