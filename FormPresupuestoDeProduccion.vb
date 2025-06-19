Public Class FormPresupuestoDeProduccion
    Dim TotalUnidadesVender As Decimal
    Dim UnidadesVenderDeleted As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'dgvDatos.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable 'Evita que el usuario pueda dar clic en la columna para ordenarla automáticamente

        For i = 0 To dtgPresupuestoProducción.ColumnCount - 1
            dtgPresupuestoProducción.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        dtgPresupuestoProducción.Columns(0).Width = 350

        dtgPresupuestoProducción.Columns(7).ReadOnly = True
        dtgPresupuestoProducción.Columns(8).ReadOnly = True
        dtgPresupuestoProducción.Columns(9).ReadOnly = True
        dtgPresupuestoProducción.Columns(10).ReadOnly = True
        dtgPresupuestoProducción.Columns(11).ReadOnly = True

        dtgPresupuestoProducción.AllowUserToAddRows = False
    End Sub

    Private Sub dtgPresupuestoProducción_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPresupuestoProducción.CellEndEdit
        'Hacer un arreglo con el nombre de cada columna decimal'
        Dim columnasDecimal As String() = {"Unidades_a_Vender", "Inventario_Final", "Inventario_Inicial", "Costo_Unitario", "MOD_Unidad", "CIF_Unidad", " Unidades_a_Producir", "Costo_Total_Producción", "Costo_Total_MOD", "Costo_Total_CIF", "Costo_Total_Planeado"}


        'Obtener el nombre de la columna editada/seleccionada"
        Dim nombreColumna As String = dtgPresupuestoProducción.Columns(e.ColumnIndex).Name

        'Si la columna seleccionada se encuentra en el arreglo de columnas entonces se valida el tipo de dato, si es decimal u string'
        If columnasDecimal.Contains(nombreColumna) Then
            Dim celda = dtgPresupuestoProducción.Rows(e.RowIndex).Cells(e.ColumnIndex)
            Dim texto As String


            If celda.Value IsNot Nothing Then 'Si celda.Value no es Nothing, usalo; si es Nothing, usá "" (texto vacío)'.
                texto = celda.Value.ToString().Trim() 'borra cualquier espacio en blanco al principio o al final de ese texto.'
            Else
                texto = ""
            End If
            Dim valorDecimal As Decimal

            If Decimal.TryParse(texto, valorDecimal) Then 'TryParse devuelve True si la conversión fue exitosa, y pone el valor convertido dentro de valorDecimal'
                celda.Value = valorDecimal ' Guarda como decimal
            Else
                MessageBox.Show("Solo se permiten valores numéricos en '" & nombreColumna & "'.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                celda.Value = Nothing ' Borra automáticamente si es inválido
            End If
        End If

        'Calculos'
        dtgPresupuestoProducción.CurrentRow.Cells(7).Value = dtgPresupuestoProducción.CurrentRow.Cells(1).Value + dtgPresupuestoProducción.CurrentRow.Cells(2).Value - dtgPresupuestoProducción.CurrentRow.Cells(3).Value

        dtgPresupuestoProducción.CurrentRow.Cells(8).Value = dtgPresupuestoProducción.CurrentRow.Cells(4).Value * dtgPresupuestoProducción.CurrentRow.Cells(7).Value

        dtgPresupuestoProducción.CurrentRow.Cells(9).Value = dtgPresupuestoProducción.CurrentRow.Cells(5).Value * dtgPresupuestoProducción.CurrentRow.Cells(7).Value

        dtgPresupuestoProducción.CurrentRow.Cells(10).Value = dtgPresupuestoProducción.CurrentRow.Cells(6).Value * dtgPresupuestoProducción.CurrentRow.Cells(7).Value

        dtgPresupuestoProducción.CurrentRow.Cells(11).Value = dtgPresupuestoProducción.CurrentRow.Cells(8).Value + dtgPresupuestoProducción.CurrentRow.Cells(9).Value + dtgPresupuestoProducción.CurrentRow.Cells(10).Value

        'TotalUnidadesVender = dtgPresupuestoProducción.CurrentRow.Cells(1).Value + TotalUnidadesVender - UnidadesVenderDeleted'

        'Totales'

        ''For Each fila As DataGridViewRow In dtgPresupuestoProducción.Rows
        'TotalUnidadesVender += Val(fila.Cells(1).Value)
        'Next
        'txtTotalUndVender.Text = TotalUnidadesVender

        CalcularTotal()

    End Sub

    Private Sub DTG_SelectionChanged(sender As Object, e As EventArgs) Handles dtgPresupuestoProducción.SelectionChanged
        btnEliminar.Enabled = (dtgPresupuestoProducción.SelectedRows.Count > 0)
    End Sub

    Private Sub btnAgregarColumn_Click(sender As Object, e As EventArgs) Handles btnAgregarColumn.Click
        dtgPresupuestoProducción.Rows.Add()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dtgPresupuestoProducción.SelectedRows.Count > 0 Then
            dtgPresupuestoProducción.Rows.Remove(dtgPresupuestoProducción.CurrentRow)
            'UnidadesVenderDeleted = dtgPresupuestoProducción.CurrentRow.Cells(1).Value'

        End If
    End Sub
    Private Sub CalcularTotal()
        Dim total As Decimal = 0


        For Each fila As DataGridViewRow In dtgPresupuestoProducción.Rows
            Dim valor = fila.Cells("Unidades_a_Vender").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                txtTotalUndVender.Text = total
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoProducción.Rows
            Dim valor = fila.Cells("Inventario_Final").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                txtInventarioFinal.Text = total
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoProducción.Rows
            Dim valor = fila.Cells("Inventario_Inicial").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                txtInventarioInicial.Text = total
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoProducción.Rows
            Dim valor = fila.Cells("Unidades_a_Producir").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                txtUnidadesProducir.Text = total
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoProducción.Rows
            Dim valor = fila.Cells("Costo_Total_Producción").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                txtCostoTotalProduccion.Text = total
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoProducción.Rows
            Dim valor = fila.Cells("Costo_Total_MOD").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                txtCostoTotalMOD.Text = total
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoProducción.Rows
            Dim valor = fila.Cells("Costo_Total_CIF").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                txtCostoTotalCIF.Text = total
                txtCostoTotalCIF.Text = FormatCurrency(total, 2)
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoProducción.Rows
            Dim valor = fila.Cells("Costo_Total_Planeado").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                txtCostoTotalPlaneado.Text = total
            End If
        Next
        total = 0









    End Sub
    Private Sub dtgPresupuestoProducción_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dtgPresupuestoProducción.RowsRemoved
        CalcularTotal()
    End Sub

End Class