Imports System.Diagnostics.Eventing.Reader
Imports System.Security.Cryptography.X509Certificates

Public Class Login
    Public Usuario As New List(Of Users)
    Dim loginexitos As Boolean = False
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim newUser As New Users("Gaxel", "gaxel9009")
        Usuario.Add(newUser)

        newUser = New Users("BurroMax", "VIVASANDINO1895")
        Usuario.Add(newUser)

        newUser = New Users("Reyes04", "nose")
        Usuario.Add(newUser)

        newUser = New Users("111", "111")
        Usuario.Add(newUser)

    End Sub

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        If txtPassword.Text <> Nothing And txtUsuario.Text <> Nothing Then
            For Each registrado As Users In Usuario
                If registrado.UsuarioP = txtUsuario.Text And registrado.PasswordP = txtPassword.Text Then
                    loginexitos = True
                    Exit For

                End If
            Next

            If loginexitos = True Then
                MsgBox("Ingreso de sesión valido", MsgBoxStyle.Information)
                Me.Hide()
                SplashScreen.ShowDialog()
                Me.Close()
            Else
                MsgBox("Usuario o contraseña inválidos", MsgBoxStyle.Critical)
                txtPassword.Clear()
                txtUsuario.Clear()
                ErrorPassword.Clear()
                ErrorUser.Clear()
            End If

        Else
            MsgBox("Llene todos los campos", MsgBoxStyle.Exclamation)

            'Errores'
            If txtPassword.Text = Nothing And txtUsuario.Text = Nothing Then
                ErrorPassword.SetError(txtPassword, "Asegurese de llenar el campo")
                ErrorUser.SetError(txtUsuario, "Asegurese de llenar el campo")
            End If

            If txtPassword.Text = Nothing Then
                ErrorPassword.SetError(txtPassword, "Asegurese de llenar el campo")
            ElseIf txtUsuario.Text = Nothing Then
                ErrorUser.SetError(txtUsuario, "Asegurese de llenar el campo")
            End If

            If txtPassword.Text <> Nothing Then
                ErrorPassword.Clear()
            ElseIf txtUsuario.Text <> Nothing Then
                ErrorUser.Clear()
            End If

        End If



    End Sub


    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Btnlogin.PerformClick()
        End If
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub
End Class