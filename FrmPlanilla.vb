Imports System.ComponentModel

Public Class FrmPlanilla
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim textboxes As TextBox() = {TxtNombres, TxtCargo, TxtSalarioMensual, TxtDiasTrab, TxtSubsidios, TxtFeriados, TxtVacaciones1, TxtPrestamos, TxtFirmas}
        Dim Cedula As String = MskCedula.Text.Trim()
        Dim Nombres As String = TxtNombres.Text.Trim()
        Dim Cargo As String = TxtCargo.Text.Trim()
        Dim SalarioMensual As Decimal = TxtSalarioMensual.Text.Trim()
        Dim SalarioDiario As Decimal = SalarioMensual / 30
        Dim DiasTrabajados As Integer = TxtDiasTrab.Text.Trim()
        Dim HorasExtras As Integer = (SalarioDiario / 8) * 2
        Dim SalarioBasico As Decimal = SalarioDiario * DiasTrabajados
        Dim Subsidios As Decimal = TxtSubsidios.Text.Trim()
        Dim Feriados As Decimal = TxtFeriados.Text.Trim()
        Dim Vacaciones As Decimal = TxtVacaciones1.Text.Trim()
        Dim reajustes As Decimal = 0
        Dim Devengados As Decimal = HorasExtras + SalarioBasico + Subsidios + Feriados + Vacaciones
        Dim INNDSLAB As Decimal = Devengados * 0.7D
        Dim Prestamos As Decimal = TxtPrestamos.Text.Trim()
        Dim IR As Decimal = Devengados * 0.1D
        Dim Tdeducciones As Decimal = INNDSLAB + Prestamos + IR
        Dim TotalAPagar As Decimal = Devengados - Prestamos - Tdeducciones
        Dim firmas As String = ("") & TxtFirmas.Text
        Dim INNSPatronal As Decimal = Devengados * 0.22D
        Dim INATEC As Decimal = Devengados * 0.02D
        Dim VacacionesPatronal As Decimal = SalarioBasico / 12
        Dim Aguinaldo As Decimal = SalarioBasico / 12

        DtgPlanilla.Rows.Add(Cedula, Nombres, Cargo, SalarioMensual, SalarioDiario, DiasTrabajados, HorasExtras, SalarioBasico, Subsidios, Feriados, Vacaciones, reajustes, Devengados, INNDSLAB, Prestamos, IR, Tdeducciones, TotalAPagar, firmas, INNSPatronal, INATEC, VacacionesPatronal, Aguinaldo)

        For Each tb As TextBox In textboxes
            tb.Clear()
        Next
        MskCedula.Clear()
        MskCedula.Focus()

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If DtgPlanilla.SelectedRows.Count > 0 Then
            DtgPlanilla.Rows.RemoveAt(DtgPlanilla.SelectedRows(0).Index)
        Else
            MsgBox("Seleccione una fila para eliminar.")
        End If

    End Sub

    Private Sub FrmPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtgPlanilla.AllowUserToAddRows = False
    End Sub
    'estas son las validaciones de los tekiste



    'CEDULA
    Private Sub TxtNombres_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtNombres.KeyUp
        If IsNumeric(TxtNombres.Text) Then
            MsgBox("Por favor, escriba un valor no numerico para la casilla Nombres y Apellidos")
            TxtNombres.Clear()
            TxtNombres.Focus()
        End If
    End Sub
    Private Sub TxtNombres_Validating(sender As Object, e As CancelEventArgs) Handles TxtNombres.Validating
        If TxtNombres.Text = ("") Then
            MsgBox("Por favor, no deje espacios")
            TxtNombres.Clear()
            TxtNombres.Focus()
        End If
    End Sub



    'CARGO
    Private Sub TxtCargo_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtCargo.KeyUp
        If IsNumeric(TxtCargo.Text) Then
            MsgBox("Por favor, escriba un valor no numerico para la casilla Cargo ")
            TxtCargo.Clear()
            TxtCargo.Focus()
        End If
    End Sub
    Private Sub TxtCargo_Validating(sender As Object, e As CancelEventArgs) Handles TxtCargo.Validating
        If TxtCargo.Text = ("") Then
            MsgBox("Por favor, no deje espacios")
            TxtCargo.Clear()
            TxtCargo.Focus()
        End If
    End Sub




    'SALARIO MENSUAL
    Private Sub TxtSalarioMensual_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtSalarioMensual.KeyUp
        If Not IsNumeric(TxtSalarioMensual.Text) Then
            MsgBox("Por favor, escriba un valor numérico para el Salario Mensual")
            TxtSalarioMensual.Clear()
            TxtSalarioMensual.Focus()
        End If
    End Sub
    Private Sub TxtSalarioMensual_Validating(sender As Object, e As CancelEventArgs) Handles TxtSalarioMensual.Validating
        If TxtSalarioMensual.Text = ("") Then
            MsgBox("Por favor, no deje espacios")
            TxtSalarioMensual.Clear()
            TxtSalarioMensual.Focus()
        End If
    End Sub




    'DIAS TRABAJADOS
    Private Sub TxtDiasTrab_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtDiasTrab.KeyUp
        If Not IsNumeric(TxtDiasTrab.Text) Then
            MsgBox("Por favor, escriba un valor numérico para los Días Trabajados")
            TxtDiasTrab.Clear()
            TxtDiasTrab.Focus()
        End If
    End Sub
    Private Sub TxtDiasTrab_Validating(sender As Object, e As CancelEventArgs) Handles TxtDiasTrab.Validating
        If TxtDiasTrab.Text = ("") Then
            MsgBox("Por favor, no deje espacios")
            TxtDiasTrab.Clear()
            TxtDiasTrab.Focus()
        End If
    End Sub




    'SUBSIDIOS
    Private Sub TxtSubsidios_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtSubsidios.KeyUp
        If Not IsNumeric(TxtSubsidios.Text) Then
            MsgBox("Por favor, escriba un valor numérico para los Subsidios")
            TxtSubsidios.Clear()
            TxtSubsidios.Focus()
        End If
    End Sub
    Private Sub TxtSubsidios_Validating(sender As Object, e As CancelEventArgs) Handles TxtSubsidios.Validating
        If TxtSubsidios.Text = ("") Then
            MsgBox("Por favor, no deje espacios")
            TxtSubsidios.Clear()
            TxtSubsidios.Focus()
        End If
    End Sub




    'FERIADOS
    Private Sub TxtFeriados_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtFeriados.KeyUp
        If Not IsNumeric(TxtFeriados.Text) Then
            MsgBox("Por favor, escriba un valor numérico para los Feriados")
            TxtFeriados.Clear()
            TxtFeriados.Focus()
        End If
    End Sub
    Private Sub TxtFeriados_Validating(sender As Object, e As CancelEventArgs) Handles TxtFeriados.Validating
        If TxtFeriados.Text = ("") Then
            MsgBox("Por favor, no deje espacios")
            TxtFeriados.Clear()
            TxtFeriados.Focus()
        End If
    End Sub




    'VACACIONES
    Private Sub TxtVacaciones1_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtVacaciones1.KeyUp
        If Not IsNumeric(TxtVacaciones1.Text) Then
            MsgBox("Por favor, escriba un valor numérico para las Vacaciones")
            TxtVacaciones1.Clear()
            TxtVacaciones1.Focus()
        End If
    End Sub
    Private Sub TxtVacaciones1_Validating(sender As Object, e As CancelEventArgs) Handles TxtVacaciones1.Validating
        If TxtVacaciones1.Text = ("") Then
            MsgBox("Por favor, no deje espacios")
            TxtVacaciones1.Clear()
            TxtVacaciones1.Focus()
        End If
    End Sub




    'PRESTAMOS
    Private Sub TxtPrestamos_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtPrestamos.KeyUp
        If Not IsNumeric(TxtPrestamos.Text) Then
            MsgBox("Por favor, escriba un valor numérico para los Préstamos")
            TxtPrestamos.Clear()
            TxtPrestamos.Focus()
        End If
    End Sub
    Private Sub TxtPrestamos_Validating(sender As Object, e As CancelEventArgs) Handles TxtPrestamos.Validating
        If TxtPrestamos.Text = ("") Then
            MsgBox("Por favor, no deje espacios")
            TxtPrestamos.Clear()
            TxtPrestamos.Focus()
        End If
    End Sub




    'FIRMAS
    Private Sub TxtFirmas_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtFirmas.KeyUp
        If IsNumeric(TxtFirmas.Text) Then
            MsgBox("Por favor, escriba un valor no numerico para la casilla Firmas")
            TxtFirmas.Clear()
            TxtFirmas.Focus()
        End If
    End Sub
    Private Sub TxtFirmas_Validating(sender As Object, e As CancelEventArgs) Handles TxtFirmas.Validating
        If TxtFirmas.Text = ("") Then
            MsgBox("Por favor, no deje espacios")
            TxtFirmas.Clear()
            TxtFirmas.Focus()
        End If
    End Sub

    Private Sub MskCedula_Validating(sender As Object, e As CancelEventArgs) Handles MskCedula.Validating
        If String.IsNullOrWhiteSpace(MskCedula.Text.Replace(" ", "").Replace("-", "")) Then
            MsgBox("Por favor, no deje la cédula vacía.")
            MskCedula.Clear()
            MskCedula.Focus()
            e.Cancel = True
        End If
    End Sub
End Class