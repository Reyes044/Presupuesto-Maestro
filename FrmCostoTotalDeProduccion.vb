Imports System.ComponentModel
Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports System.Text

Public Class FrmCostoTotalDeProduccion
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregarCtp.Click

        If TxtProducto.Text = ("") Then
            MsgBox("Escriba un nombre del producto")
            TxtProducto.Focus()
            Return
        ElseIf IsNumeric(TxtProducto.Text) Then
            MsgBox("Escriba un nombre no numerico del producto")
            TxtProducto.Clear()
            TxtProducto.Focus()
            Return
        End If


        If TxtMPD.Text = ("") Then
            MsgBox("Escriba un valor para Materia Prima Directa")
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
        Dim CostoUnitario As Decimal = Costo_Total_Produccion / Modulo_Totales.unidadesproyex
        DtgCostoTotalDeProduccion.Rows.Add(producto, Materia_Prima_Directa, Mano_de_Obra_Directa, Gif, Costo_Total_Produccion, CostoUnitario)
        CalcularTotal_GIF()
        CalcularTotal_MOD()
        CalcularTotal_MPD()
        CalcularTotal_CTP()
        Modulo_Totales.TotalMPD = TxtTotalMPD.Text
        Modulo_Totales.TotalMOD = TxtTotalMOD.Text
        Modulo_Totales.TotalGIF = TxtTotalGIF.Text
        Modulo_Totales.TotalCTP = TxtTotalCTP.Text
        TxtMPD.Clear()
        TxtMOD.Clear()
        TxtProducto.Clear()
        TxtGifAsignado.Clear()

    End Sub

    Private Sub FrmCostoTotalDeProduccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtgCostoTotalDeProduccion.AllowUserToAddRows = False
    End Sub


    Private Sub TxtProducto_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtProducto.KeyUp
        If TxtProducto.Text = ("") Then
            MsgBox("Por favor, no deje espacios")
            TxtProducto.Clear()
            TxtProducto.Focus()
        End If
        If IsNumeric(TxtProducto.Text) Then
            MsgBox("Por favor, escriba un valor no numerico para el Producto")
            TxtProducto.Clear()
            TxtProducto.Focus()
        End If
    End Sub

    Private Sub TxtMPD_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtMPD.KeyUp

        If Not IsNumeric(TxtMPD.Text) Then
            MsgBox("Por favor, escriba un valor numérico para Materia Prima Directa")
            TxtMPD.Clear()
            TxtMPD.Focus()
        End If
        If IsNumeric(TxtMPD.Text) Then
            If (TxtMPD.Text) <= 0 Then
                MsgBox("Por favor, escriba un valor positivo para Materia Prima Directa")
                TxtMPD.Clear()
                TxtMPD.Focus()
            End If
        End If
    End Sub

    Private Sub TxtGifAsignado_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtGifAsignado.KeyUp
        If Not IsNumeric(TxtGifAsignado.Text) Then
            MsgBox("Por favor, escriba un valor numérico para Materia Prima Directa")
            TxtGifAsignado.Clear()
            TxtGifAsignado.Focus()
        End If
        If IsNumeric(TxtGifAsignado.Text) Then
            If (TxtGifAsignado.Text) <= 0 Then
                MsgBox("Por favor, escriba un valor positivo para Materia Prima Directa")
                TxtGifAsignado.Clear()
                TxtGifAsignado.Focus()
            End If
        End If
    End Sub
    Private Sub TxtMOD_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtMOD.KeyUp
        If Not IsNumeric(TxtMOD.Text) Then
            MsgBox("Por favor, escriba un valor numérico para Materia Prima Directa")
            TxtMOD.Clear()
            TxtMOD.Focus()
        End If
        If IsNumeric(TxtMOD.Text) Then
            If (TxtMPD.Text) <= 0 Then
                MsgBox("Por favor, escriba un valor positivo para Materia Prima Directa")
                TxtMOD.Clear()
                TxtMOD.Focus()
            End If
        End If
    End Sub

    Private Sub CalcularTotal_GIF()
        Dim total As Decimal = 0

        For Each fila As DataGridViewRow In DtgCostoTotalDeProduccion.Rows
            Dim valor = fila.Cells("Col_GIF_Asignado").Value

            If IsNumeric(valor) Then
                total += (valor)
            End If
        Next
        TxtTotalGIF.Text = total

    End Sub

    Private Sub CalcularTotal_MPD()
        Dim total As Decimal = 0

        For Each fila As DataGridViewRow In DtgCostoTotalDeProduccion.Rows
            Dim valor = fila.Cells("ColMPD").Value

            If IsNumeric(valor) Then
                total += (valor)
            End If
        Next
        TxtTotalMPD.Text = total

    End Sub

    Private Sub CalcularTotal_MOD()
        Dim total As Decimal = 0

        For Each fila As DataGridViewRow In DtgCostoTotalDeProduccion.Rows
            Dim valor = fila.Cells("ColMOD").Value

            If IsNumeric(valor) Then
                total += (valor)
            End If
        Next
        TxtTotalMOD.Text = total
    End Sub

    Private Sub CalcularTotal_CTP()
        Dim total As Decimal = 0

        For Each fila As DataGridViewRow In DtgCostoTotalDeProduccion.Rows
            Dim valor = fila.Cells("ColCostoTotalDeProduccion").Value

            If IsNumeric(valor) Then
                total += (valor)
            End If
        Next
        TxtTotalCTP.Text = total
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If DtgCostoTotalDeProduccion.SelectedRows.Count > 0 Then
            DtgCostoTotalDeProduccion.Rows.RemoveAt(DtgCostoTotalDeProduccion.SelectedRows(0).Index)
            CalcularTotal_GIF()
            CalcularTotal_MOD()
            CalcularTotal_MPD()
            CalcularTotal_CTP()
        Else
            MsgBox("Seleccione una fila para eliminar.")
        End If
    End Sub


    Private Sub DtgCostoTotalDeProduccion_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DtgCostoTotalDeProduccion.RowsRemoved
        CalcularTotal_GIF()
        CalcularTotal_MOD()
        CalcularTotal_MPD()
        CalcularTotal_CTP()

    End Sub
    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        'Dialogo para que el usuario guarde donde quiera su archivo
        Dim guardarDialogo As New SaveFileDialog()
        guardarDialogo.Filter = "Archivos de texto (.txt)|.txt" 'Filtrar que formato esta permitido
        guardarDialogo.Title = "Guardar datos del DataGridView" 'Texto que aparecerá en la barra de dialogo
        guardarDialogo.FileName = "Costo_Total_de_Produccion.txt" 'Nombre del archivo

        If guardarDialogo.ShowDialog() = DialogResult.OK Then 'Abre la ventana y el ok verefica si el usuario hizo click en guardar y no en cacelar
            Using writer As New StreamWriter(guardarDialogo.FileName)

                For Each columna As DataGridViewColumn In DtgCostoTotalDeProduccion.Columns
                    Dim valorescolumnas As New List(Of String)
                    For Each fila As DataGridViewRow In DtgCostoTotalDeProduccion.Rows 'Recorre filas del dtg
                        If Not fila.IsNewRow Then   'Evitamos tomar fila vacia que tenemos al final (o no)
                            Dim Valor = fila.Cells(columna.Index).Value 'La lista guarda todos los valores de la fila
                            If Valor IsNot Nothing Then
                                valorescolumnas.Add(Valor.ToString)
                            End If

                        End If
                    Next

                    writer.WriteLine(columna.HeaderText & ":" & String.Join(" , ", valorescolumnas))

                Next

            End Using
            MessageBox.Show("Datos guardados correctamente.")
        End If
    End Sub
End Class