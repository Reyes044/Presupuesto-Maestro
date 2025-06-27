Imports System.ComponentModel
Imports System.IO

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
        CalcularTotal()
        Modulo_Totales.TotalMonto = TxtTotal.Text
        TxtConcepto.Clear()
        TxtMonto.Clear()


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
            CalcularTotal()
            Modulo_Totales.TotalMonto = TxtTotal.Text
            TxtConcepto.Clear()
            TxtMonto.Clear()

        Else
            MsgBox("Seleccione una fila para eliminar.")
        End If

    End Sub

    Private Sub FrmGastos_Indirectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtgGastosIndirectos.AllowUserToAddRows = False
    End Sub

    Private Sub CalcularTotal()
        Dim total As Decimal = 0

        For Each fila As DataGridViewRow In DtgGastosIndirectos.Rows
            Dim valor = fila.Cells("ColMonto").Value

            If IsNumeric(valor) Then
                total += (valor)
            End If
        Next
        TxtTotal.Text = total

    End Sub




    Private Sub DtgGastosIndirectos_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DtgGastosIndirectos.RowsRemoved
        CalcularTotal()
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        'Dialogo para que el usuario guarde donde quiera su archivo
        Dim guardarDialogo As New SaveFileDialog()
        guardarDialogo.Filter = "Archivos de texto (.txt)|.txt" 'Filtrar que formato esta permitido
        guardarDialogo.Title = "Guardar datos del DataGridView" 'Texto que aparecerá en la barra de dialogo
        guardarDialogo.FileName = "Gastos_Indirectos.txt" 'Nombre del archivo

        If guardarDialogo.ShowDialog() = DialogResult.OK Then 'Abre la ventana y el ok verefica si el usuario hizo click en guardar y no en cacelar
            Using writer As New StreamWriter(guardarDialogo.FileName)

                For Each columna As DataGridViewColumn In DtgGastosIndirectos.Columns
                    Dim valorescolumnas As New List(Of String)
                    For Each fila As DataGridViewRow In DtgGastosIndirectos.Rows 'Recorre filas del dtg
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