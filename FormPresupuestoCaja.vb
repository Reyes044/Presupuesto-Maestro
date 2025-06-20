Public Class FormPresupuestoCaja
    Private Sub FormPresupuestoCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtgPresupuestoCaja.AllowUserToAddRows = False
        dtgPresupuestoCaja.Columns(5).ReadOnly = True

        For i = 0 To dtgPresupuestoCaja.ColumnCount - 1
            dtgPresupuestoCaja.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next


    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        dtgPresupuestoCaja.Rows.Add()
    End Sub

    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        If dtgPresupuestoCaja.SelectedRows.Count > 0 Then
            dtgPresupuestoCaja.Rows.Remove(dtgPresupuestoCaja.CurrentRow)
        End If
    End Sub

    Private Sub dtgPresupuestoCaja_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPresupuestoCaja.CellEndEdit
        Dim columnasDecimal As String() = {"Ingresos_por_Ventas", "Pagos_Proveedores", "Pago_de_Sueldos", "Otros_Pagos", "Flujo_Mes"}

        Dim nombreColumna As String = dtgPresupuestoCaja.Columns(e.ColumnIndex).Name

        If columnasDecimal.Contains(nombreColumna) Then
            Dim celda = dtgPresupuestoCaja.Rows(e.RowIndex).Cells(e.ColumnIndex)
            Dim texto As String

            If celda.Value IsNot Nothing Then
                texto = celda.Value.ToString().Trim()
            Else
                texto = ""
            End If
            Dim valorDecimal As Decimal

            If Decimal.TryParse(texto, valorDecimal) And valorDecimal > 0 Then
                celda.Value = valorDecimal
            Else
                MessageBox.Show("Solo se permiten valores numéricos en '" & nombreColumna & "'.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                celda.Value = Nothing
            End If
        End If

        'Calculos'
        dtgPresupuestoCaja.CurrentRow.Cells(5).Value = dtgPresupuestoCaja.CurrentRow.Cells(1).Value - dtgPresupuestoCaja.CurrentRow.Cells(2).Value - dtgPresupuestoCaja.CurrentRow.Cells(3).Value - dtgPresupuestoCaja.CurrentRow.Cells(4).Value
        CalcularTotal()
    End Sub

    Private Sub dtgPresupuestoCaja_SelectionChanged(sender As Object, e As EventArgs) Handles dtgPresupuestoCaja.SelectionChanged
        btnEliminarProducto.Enabled = (dtgPresupuestoCaja.SelectedRows.Count > 0)
    End Sub


    Private Sub CalcularTotal()
        Dim total As Decimal = 0

        For Each fila As DataGridViewRow In dtgPresupuestoCaja.Rows
            Dim valor = fila.Cells("Ingresos_por_Ventas").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                txtIngresosPorVentas.Text = total.ToString("C2")
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoCaja.Rows
            Dim valor = fila.Cells("Pagos_Proveedores").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                txtPagoProv.Text = total.ToString("C2")
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoCaja.Rows
            Dim valor = fila.Cells("Pago_de_Sueldos").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                txtPagoSueldos.Text = total.ToString("C2")
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoCaja.Rows
            Dim valor = fila.Cells("Otros_Pagos").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                txtOtrosPagos.Text = total.ToString("C2")
            End If
        Next
        total = 0


        For Each fila As DataGridViewRow In dtgPresupuestoCaja.Rows
            Dim valor = fila.Cells("Flujo_Mes").Value

            If IsNumeric(valor) Then
                total += CDec(valor)
                txtFNM.Text = total.ToString("C2")
            End If
        Next
        total = 0
    End Sub

    Private Sub dtgPresupuestoCaja_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dtgPresupuestoCaja.RowsRemoved
        LimpiarTxt()
        CalcularTotal()
    End Sub

    Private Sub LimpiarTxt()
        txtIngresosPorVentas.Clear()
        txtFNM.Clear()
        txtOtrosPagos.Clear()
        txtPagoProv.Clear()
        txtPagoSueldos.Clear()
    End Sub

End Class