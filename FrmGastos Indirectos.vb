Imports System.ComponentModel

Public Class FrmGastos_Indirectos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        If TxtConcepto.Text = ("") Then
            MsgBox("Escriba un nombre del Concepto")
            TxtConcepto.Clear()
            TxtConcepto.Focus()
            Return
        End If

        If TxtMonto.Text = ("") Then
            MsgBox("Escriba un nombre del Concepto")
            TxtMonto.Clear()
            TxtMonto.Focus()
            Return
        End If




        Dim concepto As String = TxtConcepto.Text
        Dim monto As Decimal = TxtMonto.Text

        DtgGastosIndirectos.Rows.Add(concepto, monto)

    End Sub
    Private Sub TxtConcepto_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtConcepto.KeyUp
        If IsNumeric(TxtConcepto.Text) Then
            MsgBox("Escriba un nombre no numerico del Concepto")
            TxtConcepto.Clear()
            TxtConcepto.Focus()
        End If
    End Sub
    Private Sub TxtMonto_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtMonto.KeyUp

        If Not IsNumeric(TxtMonto.Text) Then
            MsgBox("Escriba un valor numerico para el Monto que no sea negativo")
            TxtMonto.Clear()
            TxtMonto.Focus()
        End If

    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If DtgGastosIndirectos.SelectedRows.Count > 0 Then
            DtgGastosIndirectos.Rows.RemoveAt(DtgGastosIndirectos.SelectedRows(0).Index)
        Else
            MsgBox("Seleccione una fila para eliminar.")
        End If
    End Sub

    Private Sub FrmGastos_Indirectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtgGastosIndirectos.AllowUserToAddRows = False
    End Sub
End Class