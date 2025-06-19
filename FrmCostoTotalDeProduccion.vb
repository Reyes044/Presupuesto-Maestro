Imports System.Diagnostics.Eventing.Reader
Imports System.Text

Public Class FrmCostoTotalDeProduccion
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click, BtnAgregarCtp.Click

        If TxtProducto.Text = ("") Then
            MsgBox("Escriba un nombre del producto")
            TxtProducto.Focus()
            Return
        ElseIf IsNumeric(TxtProducto.Text) Then
            MsgBox("Escriba un nombre no numerico del producto")
            TxtProducto.Clear()
            TxtProducto.Focus()

        End If


        If TxtMPD.Text = ("") Then
            MsgBox("Escriba un valor para Materia Prima Directao")
            TxtMPD.Focus()
            Return
        ElseIf Not IsNumeric(TxtMPD.Text) Then
            MsgBox("Escriba un valor numérico para Materia Prima Directa")
            TxtMPD.Clear()
            TxtMPD.Focus()
            Return
        End If


        If TxtMOD.Text = ("") Then
            MsgBox("Escriba un valor para Mano de Obra Directa")
            TxtMOD.Focus()
            Return
        ElseIf Not IsNumeric(TxtMOD.Text) Then
            MsgBox("Escriba un valor numérico para Mano de Obra Directa")
            TxtMOD.Clear()
            TxtMOD.Focus()
            Return
        End If


        If TxtGifAsignado.Text = ("") Then
            MsgBox("Escriba un valor para Gasto Indirecto de Fabricacion")
            TxtGifAsignado.Focus()
            Return
        ElseIf Not IsNumeric(TxtGifAsignado.Text) Then
            MsgBox("Escriba un valor numérico para Gasto Indirecto de Fabricacion")
            TxtGifAsignado.Clear()
            TxtGifAsignado.Focus()
            Return
        End If



        Dim producto As String = TxtProducto.Text
        Dim Materia_Prima_Directa As Integer = TxtMPD.Text
        Dim Mano_de_Obra_Directa As Integer = TxtMOD.Text
        Dim Gif As Integer = TxtGifAsignado.Text

        Dim Costo_Total_Produccion As Integer = Materia_Prima_Directa + Mano_de_Obra_Directa + Gif

        DtgCostoTotalDeProduccion.Rows.Add(producto, Materia_Prima_Directa, Mano_de_Obra_Directa, Gif, Costo_Total_Produccion)

    End Sub

    Private Sub FrmCostoTotalDeProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtgCostoTotalDeProduccion.AllowUserToAddRows = False
    End Sub
End Class