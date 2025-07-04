﻿Imports System.IO
Imports System.Security.Cryptography

Public Class FormPresupuestoDeProduccion
    Dim TotalUnidadesVender As Decimal
    Dim UnidadesVenderDeleted As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtgPresupuestoProducción.MultiSelect = False



        For i = 1 To dtgPresupuestoProducción.ColumnCount - 1
            dtgPresupuestoProducción.Columns(i).ReadOnly = True
        Next


        For i = 0 To dtgPresupuestoProducción.ColumnCount - 1
            dtgPresupuestoProducción.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        dtgPresupuestoProducción.Columns(0).Width = 300

        'dtgPresupuestoProducción.Columns(7).ReadOnly = True
        'dtgPresupuestoProducción.Columns(8).ReadOnly = True
        'dtgPresupuestoProducción.Columns(9).ReadOnly = True
        'dtgPresupuestoProducción.Columns(10).ReadOnly = True
        'dtgPresupuestoProducción.Columns(11).ReadOnly = True

        dtgPresupuestoProducción.AllowUserToAddRows = False
    End Sub

    Private Sub dtgPresupuestoProducción_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPresupuestoProducción.CellEndEdit

        'Para habilitar las demas columnas'

        If e.ColumnIndex = 0 Then
            Dim celdaProducto = dtgPresupuestoProducción.Rows(e.RowIndex).Cells(0)
            Dim texto As String = ""

            If celdaProducto.Value IsNot Nothing Then
                texto = celdaProducto.Value.ToString().Trim()
            End If

            If texto <> "" Then
                For i = 1 To 6
                    dtgPresupuestoProducción.Rows(e.RowIndex).Cells(i).ReadOnly = False
                    dtgPresupuestoProducción.Rows(e.RowIndex).Cells(i).Style.BackColor = Color.White
                Next
            Else
                For i = 1 To 6
                    dtgPresupuestoProducción.Rows(e.RowIndex).Cells(i).Value = Nothing
                    dtgPresupuestoProducción.Rows(e.RowIndex).Cells(i).ReadOnly = True
                    dtgPresupuestoProducción.Rows(e.RowIndex).Cells(i).Style.BackColor = Color.LightGray
                Next
            End If
        End If



        LimpiarTxts()

        'Hacer un arreglo con el nombre de cada columna decimal'
        Dim columnasDecimal As String() = {"Unidades_a_Vender", "Inventario_Final", "Inventario_Inicial", "Costo_Unitario", "MOD_Unidad", "CIF_Unidad", " Unidades_a_Producir", "Costo_Total_Producción", "Costo_Total_MOD", "Costo_Total_CIF", "Costo_Total_Planeado"}


        'Obtener el nombre de la columna editada/seleccionada"
        Dim nombreColumna As String = dtgPresupuestoProducción.Columns(e.ColumnIndex).Name

        'Si la columna seleccionada se encuentra en el arreglo de columnas entonces se valida el tipo de dato, si es decimal u string'
        If columnasDecimal.Contains(nombreColumna) Then
            Dim celda = dtgPresupuestoProducción.Rows(e.RowIndex).Cells(e.ColumnIndex)
            Dim texto As String

            If celda.Value IsNot Nothing Then  'Si celda.Value no es Nothing, usalo; si es Nothing, usá "" (texto vacío)'.
                texto = celda.Value.ToString().Trim() 'borra cualquier espacio en blanco al principio o al final de ese texto.'
            Else
                texto = ""
            End If
            Dim valorDecimal As Decimal

            If Decimal.TryParse(texto, valorDecimal) And valorDecimal > 0 Then 'TryParse devuelve True si la conversión fue exitosa, y pone el valor convertido dentro de valorDecimal'
                celda.Style.BackColor = Color.White
                celda.Value = valorDecimal ' Guarda como decimal
            Else
                MessageBox.Show("Solo se permiten valores numéricos positivos en '" & nombreColumna & "'.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                celda.Style.BackColor = Color.Yellow
                celda.Value = Nothing ' Borra automáticamente si es inválido
            End If
        End If


        'Calculos'
        dtgPresupuestoProducción.CurrentRow.Cells(7).Value = dtgPresupuestoProducción.CurrentRow.Cells(1).Value + dtgPresupuestoProducción.CurrentRow.Cells(2).Value - dtgPresupuestoProducción.CurrentRow.Cells(3).Value

        dtgPresupuestoProducción.CurrentRow.Cells(8).Value = dtgPresupuestoProducción.CurrentRow.Cells(4).Value * dtgPresupuestoProducción.CurrentRow.Cells(7).Value

        dtgPresupuestoProducción.CurrentRow.Cells(9).Value = dtgPresupuestoProducción.CurrentRow.Cells(5).Value * dtgPresupuestoProducción.CurrentRow.Cells(7).Value

        dtgPresupuestoProducción.CurrentRow.Cells(10).Value = dtgPresupuestoProducción.CurrentRow.Cells(6).Value * dtgPresupuestoProducción.CurrentRow.Cells(7).Value

        dtgPresupuestoProducción.CurrentRow.Cells(11).Value = dtgPresupuestoProducción.CurrentRow.Cells(8).Value + dtgPresupuestoProducción.CurrentRow.Cells(9).Value + dtgPresupuestoProducción.CurrentRow.Cells(10).Value

        CalcularTotal()

        'Validación Negativo´
        For i = 7 To dtgPresupuestoProducción.ColumnCount - 1
            If dtgPresupuestoProducción.CurrentRow.Cells(i).Value < 0 Then
                dtgPresupuestoProducción.CurrentRow.Cells(i).Style.BackColor = Color.FromArgb(200, 100, 100)

            Else
                dtgPresupuestoProducción.CurrentRow.Cells(i).Style.BackColor = Color.Gray
            End If
        Next

        'Modulo'
        Modulo_Totales.TotalUnidadesAVender = txtTotalUndVender.Text
        Modulo_Totales.TotalUnidadesAProducir = txtUnidadesProducir.Text
        Modulo_Totales.TotalCostoTotalPlaneado = txtCostoTotalPlaneado.Text
        Modulo_Totales.TotalCostoTotalCIF = txtCostoTotalCIF.Text
        Modulo_Totales.TotalInventarioFinal = txtInventarioFinal.Text
        Modulo_Totales.TotalCostoTotalProduccion = txtCostoTotalProduccion.Text
        Modulo_Totales.TotalInventarioInicial = txtInventarioInicial.Text
        Modulo_Totales.TotalCostoTotalMOD = txtCostoTotalMOD.Text

    End Sub

    Private Sub DTG_SelectionChanged(sender As Object, e As EventArgs) Handles dtgPresupuestoProducción.SelectionChanged
        btnEliminar.Visible = (dtgPresupuestoProducción.SelectedRows.Count > 0)
    End Sub

    Private Sub btnAgregarColumn_Click(sender As Object, e As EventArgs) Handles btnAgregarColumn.Click

        'Modulo_Totales.TotalUnidadesAVender = txtTotalUndVender.Text
        'Modulo_Totales.TotalUnidadesAProducir = txtUnidadesProducir.Text
        'Modulo_Totales.TotalCostoTotalPlaneado = txtCostoTotalPlaneado.Text
        'Modulo_Totales.TotalCostoTotalCIF = txtCostoTotalCIF.Text
        'Modulo_Totales.TotalInventarioFinal = txtInventarioFinal.Text
        'Modulo_Totales.TotalCostoTotalProduccion = txtCostoTotalProduccion.Text
        'Modulo_Totales.TotalInventarioInicial = txtInventarioInicial.Text
        'Modulo_Totales.TotalCostoTotalMOD = txtCostoTotalMOD.Text

        Dim index = dtgPresupuestoProducción.Rows.Add()
        For i = 1 To 6
            dtgPresupuestoProducción.Rows(index).Cells(i).ReadOnly = True
            dtgPresupuestoProducción.Rows(index).Cells(i).Style.BackColor = Color.LightGray
        Next




    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Modulo_Totales.TotalUnidadesAVender = txtTotalUndVender.Text
        Modulo_Totales.TotalUnidadesAProducir = txtUnidadesProducir.Text
        Modulo_Totales.TotalCostoTotalPlaneado = txtCostoTotalPlaneado.Text
        Modulo_Totales.TotalCostoTotalCIF = txtCostoTotalCIF.Text
        Modulo_Totales.TotalInventarioFinal = txtInventarioFinal.Text
        Modulo_Totales.TotalCostoTotalProduccion = txtCostoTotalProduccion.Text
        Modulo_Totales.TotalInventarioInicial = txtInventarioInicial.Text
        Modulo_Totales.TotalCostoTotalMOD = txtCostoTotalMOD.Text


        If dtgPresupuestoProducción.SelectedRows.Count > 0 Then
            dtgPresupuestoProducción.Rows.Remove(dtgPresupuestoProducción.CurrentRow)
        End If

    End Sub
    Private Sub CalcularTotal()
        Dim total As Decimal = 0
        'txtTotalUndVender.Text = CDec(0)
        'txtUnidadesProducir.Text = CDec(0)

        For Each fila As DataGridViewRow In dtgPresupuestoProducción.Rows
            Dim valor = fila.Cells("Unidades_a_Vender").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                txtTotalUndVender.Text = total.ToString("N2")
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoProducción.Rows
            Dim valor = fila.Cells("Inventario_Final").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                txtInventarioFinal.Text = total.ToString("N2")
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoProducción.Rows
            Dim valor = fila.Cells("Inventario_Inicial").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                txtInventarioInicial.Text = total.ToString("N2")
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoProducción.Rows
            Dim valor = fila.Cells("Unidades_a_Producir").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                If total >= 0 Then
                    txtUnidadesProducir.Text = total.ToString("C2")
                    txtUnidadesProducir.BackColor = Color.FromArgb(178, 236, 232)
                Else
                    txtUnidadesProducir.Text = total.ToString("C2")
                    txtUnidadesProducir.BackColor = Color.FromArgb(200, 100, 100)
                End If
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoProducción.Rows
            Dim valor = fila.Cells("Costo_Total_Producción").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                If total >= 0 Then
                    txtCostoTotalProduccion.Text = total.ToString("C2")
                    txtCostoTotalProduccion.BackColor = Color.FromArgb(178, 236, 232)
                Else
                    txtCostoTotalProduccion.Text = total.ToString("C2")
                    txtCostoTotalProduccion.BackColor = Color.FromArgb(200, 100, 100)
                End If
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoProducción.Rows
            Dim valor = fila.Cells("Costo_Total_MOD").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                If total >= 0 Then
                    txtCostoTotalMOD.Text = total.ToString("C2")
                    txtCostoTotalMOD.BackColor = Color.FromArgb(178, 236, 232)
                Else
                    txtCostoTotalMOD.Text = total.ToString("C2")
                    txtCostoTotalMOD.BackColor = Color.FromArgb(200, 100, 100)
                End If
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoProducción.Rows
            Dim valor = fila.Cells("Costo_Total_CIF").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                If total >= 0 Then
                    txtCostoTotalCIF.Text = total.ToString("C2")
                    txtCostoTotalCIF.BackColor = Color.FromArgb(178, 236, 232)
                Else
                    txtCostoTotalCIF.Text = total.ToString("C2")
                    txtCostoTotalCIF.BackColor = Color.FromArgb(200, 100, 100)
                End If
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoProducción.Rows
            Dim valor = fila.Cells("Costo_Total_Planeado").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                If total >= 0 Then
                    txtCostoTotalPlaneado.Text = total.ToString("C2")
                    txtCostoTotalPlaneado.BackColor = Color.FromArgb(178, 236, 232)
                Else
                    txtCostoTotalPlaneado.Text = total.ToString("C2")
                    txtCostoTotalPlaneado.BackColor = Color.FromArgb(200, 100, 100)
                End If
            End If
        Next
        total = 0

        'Solucion Bug'

        If txtUnidadesProducir.Text = Nothing And txtUnidadesProducir.BackColor = Color.FromArgb(200, 100, 100) Then
            txtUnidadesProducir.BackColor = Color.FromArgb(178, 236, 232)
        End If

        If txtCostoTotalProduccion.Text = Nothing And txtCostoTotalProduccion.BackColor = Color.FromArgb(200, 100, 100) Then
            txtCostoTotalProduccion.BackColor = Color.FromArgb(178, 236, 232)
        End If

        If txtCostoTotalMOD.Text = Nothing And txtCostoTotalMOD.BackColor = Color.FromArgb(200, 100, 100) Then
            txtCostoTotalMOD.BackColor = Color.FromArgb(178, 236, 232)
        End If

        If txtCostoTotalCIF.Text = Nothing And txtCostoTotalCIF.BackColor = Color.FromArgb(200, 100, 100) Then
            txtCostoTotalCIF.BackColor = Color.FromArgb(178, 236, 232)
        End If

        If txtCostoTotalPlaneado.Text = Nothing And txtCostoTotalPlaneado.BackColor = Color.FromArgb(200, 100, 100) Then
            txtCostoTotalPlaneado.BackColor = Color.FromArgb(178, 236, 232)
        End If

    End Sub
    Private Sub dtgPresupuestoProducción_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dtgPresupuestoProducción.RowsRemoved
        LimpiarTxts()
        CalcularTotal()
    End Sub

    Private Sub LimpiarTxts()
        txtTotalUndVender.Clear()
        txtCostoTotalMOD.Clear()
        txtCostoTotalCIF.Clear()
        txtCostoTotalPlaneado.Clear()
        txtCostoTotalProduccion.Clear()
        txtInventarioFinal.Clear()
        txtInventarioInicial.Clear()
        txtUnidadesProducir.Clear()


        Modulo_Totales.TotalUnidadesAVender = txtTotalUndVender.Text
        Modulo_Totales.TotalUnidadesAProducir = txtUnidadesProducir.Text
        Modulo_Totales.TotalCostoTotalPlaneado = txtCostoTotalPlaneado.Text
        Modulo_Totales.TotalCostoTotalCIF = txtCostoTotalCIF.Text
        Modulo_Totales.TotalInventarioFinal = txtInventarioFinal.Text
        Modulo_Totales.TotalCostoTotalProduccion = txtCostoTotalProduccion.Text
        Modulo_Totales.TotalInventarioInicial = txtInventarioInicial.Text
        Modulo_Totales.TotalCostoTotalMOD = txtCostoTotalMOD.Text
    End Sub



    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        'Dialogo para que el usuario guarde donde quiera su archivo
        Dim guardarDialogo As New SaveFileDialog()
        guardarDialogo.Filter = "Archivos de texto (.txt)|.txt" 'Filtrar que formato esta permitido
        guardarDialogo.Title = "Guardar datos del DataGridView" 'Texto que aparecerá en la barra de dialogo
        guardarDialogo.FileName = "Presupuesto_Producción.txt" 'Nombre del archivo

        If guardarDialogo.ShowDialog() = DialogResult.OK Then 'Abre la ventana y el ok verefica si el usuario hizo click en guardar y no en cacelar
            Using writer As New StreamWriter(guardarDialogo.FileName)


                For Each columna As DataGridViewColumn In dtgPresupuestoProducción.Columns
                    Dim valorescolumna As New List(Of String)

                    For Each fila As DataGridViewRow In dtgPresupuestoProducción.Rows 'Recorre filas del dtg
                        If Not fila.IsNewRow Then   'Evitamos tomar fila vacia que tenemos al final (o no)
                            Dim valor = fila.Cells(columna.Index).Value
                            If valor IsNot Nothing Then
                                valorescolumna.Add(valor.ToString())
                            End If
                        End If

                    Next

                    writer.WriteLine(columna.HeaderText & ": " & String.Join(" , ", valorescolumna))
                Next

            End Using
            MessageBox.Show("Datos guardados correctamente.")
        End If
    End Sub

End Class