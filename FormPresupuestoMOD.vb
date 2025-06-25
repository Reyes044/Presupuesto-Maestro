Public Class FormPresupuestoMOD
    Private Sub FormPresupuestoMOD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtgPresupuestoMOD.AllowUserToAddRows = False


        dtgPresupuestoMOD.MultiSelect = False

        dtgPresupuestoMOD.Columns(3).ReadOnly = True
        dtgPresupuestoMOD.Columns(5).ReadOnly = True


        For i = 0 To dtgPresupuestoMOD.ColumnCount - 1
            dtgPresupuestoMOD.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim index = dtgPresupuestoMOD.Rows.Add()
        For i = 1 To 2
            dtgPresupuestoMOD.Rows(index).Cells(i).ReadOnly = True
            dtgPresupuestoMOD.Rows(index).Cells(i).Style.BackColor = Color.LightGray
            dtgPresupuestoMOD.Rows(index).Cells(4).ReadOnly = True
            dtgPresupuestoMOD.Rows(index).Cells(4).Style.BackColor = Color.LightGray
        Next
    End Sub

    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        If dtgPresupuestoMOD.SelectedRows.Count > 0 Then
            dtgPresupuestoMOD.Rows.Remove(dtgPresupuestoMOD.CurrentRow)
        End If
    End Sub

    Private Sub dtgPresupuestoMOD_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPresupuestoMOD.CellEndEdit


        If e.ColumnIndex = 0 Then
            Dim celdaProducto = dtgPresupuestoMOD.Rows(e.RowIndex).Cells(0)
            Dim texto As String = ""

            If celdaProducto.Value IsNot Nothing Then
                texto = celdaProducto.Value.ToString().Trim()
            End If

            If texto <> "" Then
                For i = 1 To 2
                    dtgPresupuestoMOD.Rows(e.RowIndex).Cells(i).ReadOnly = False
                    dtgPresupuestoMOD.Rows(e.RowIndex).Cells(i).Style.BackColor = Color.White
                    dtgPresupuestoMOD.Rows(e.RowIndex).Cells(4).ReadOnly = False
                    dtgPresupuestoMOD.Rows(e.RowIndex).Cells(4).Style.BackColor = Color.White
                Next
            Else
                For i = 1 To 2
                    dtgPresupuestoMOD.Rows(e.RowIndex).Cells(i).Value = Nothing
                    dtgPresupuestoMOD.Rows(e.RowIndex).Cells(i).ReadOnly = True
                    dtgPresupuestoMOD.Rows(e.RowIndex).Cells(i).Style.BackColor = Color.LightGray
                    dtgPresupuestoMOD.Rows(e.RowIndex).Cells(4).Value = Nothing
                    dtgPresupuestoMOD.Rows(e.RowIndex).Cells(4).ReadOnly = True
                    dtgPresupuestoMOD.Rows(e.RowIndex).Cells(4).Style.BackColor = Color.LightGray
                Next
            End If
        End If



        LimpiarTXT()

        Dim columnasDecimal As String() = {"Unidades_a_Producir", "Horas_por_Unidad", "Total_de_Horas", "Costo_por_Horas", "Costo_Total_MOD"}

        Dim nombreColumna As String = dtgPresupuestoMOD.Columns(e.ColumnIndex).Name

        If columnasDecimal.Contains(nombreColumna) Then
            Dim celda = dtgPresupuestoMOD.Rows(e.RowIndex).Cells(e.ColumnIndex)
            Dim texto As String

            If celda.Value IsNot Nothing Then
                texto = celda.Value.ToString().Trim()
            Else
                texto = ""
            End If
            Dim valorDecimal As Decimal

            If Decimal.TryParse(texto, valorDecimal) And valorDecimal > 0 Then
                celda.Style.BackColor = Color.White
                celda.Value = valorDecimal
            Else
                MessageBox.Show("Solo se permiten valores numéricos en '" & nombreColumna & "'.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                celda.Style.BackColor = Color.Yellow
                celda.Value = Nothing

            End If
        End If

        'Calculos'
        dtgPresupuestoMOD.CurrentRow.Cells(3).Value = dtgPresupuestoMOD.CurrentRow.Cells(1).Value * dtgPresupuestoMOD.CurrentRow.Cells(2).Value
        dtgPresupuestoMOD.CurrentRow.Cells(5).Value = dtgPresupuestoMOD.CurrentRow.Cells(3).Value * dtgPresupuestoMOD.CurrentRow.Cells(4).Value

        CalcularTotal()
    End Sub

    Private Sub dtgPresupuestoMOD_SelectionChanged(sender As Object, e As EventArgs) Handles dtgPresupuestoMOD.SelectionChanged
        btnEliminarProducto.Enabled = (dtgPresupuestoMOD.SelectedRows.Count > 0)
    End Sub

    Private Sub CalcularTotal()
        Dim total As Decimal = 0

        For Each fila As DataGridViewRow In dtgPresupuestoMOD.Rows
            Dim valor = fila.Cells("Unidades_a_Producir").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                txtUnidadesProducir.Text = total.ToString("N2")
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoMOD.Rows
            Dim valor = fila.Cells("Total_de_Horas").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                txtTotalHoras.Text = total.ToString("N2")
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoMOD.Rows
            Dim valor = fila.Cells("Costo_Total_MOD").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                txtTotalMOD.Text = total
                txtTotalMOD.Text = FormatCurrency(total, 2)
            End If
        Next
        total = 0
    End Sub

    Private Sub dtgPresupuestoMOD_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dtgPresupuestoMOD.RowsRemoved
        LimpiarTXT()
        CalcularTotal()
    End Sub

    Private Sub LimpiarTXT()
        txtTotalHoras.Clear()
        txtTotalMOD.Clear()
        txtUnidadesProducir.Clear()
    End Sub

End Class