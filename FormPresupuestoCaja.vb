Public Class FormPresupuestoCaja
    Private Sub FormPresupuestoCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtgPresupuestoCaja.AllowUserToAddRows = False
        dtgPresupuestoCaja.Columns(5).ReadOnly = True

        For i = 0 To dtgPresupuestoCaja.ColumnCount - 1
            dtgPresupuestoCaja.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        For i = 1 To dtgPresupuestoCaja.ColumnCount - 1
            dtgPresupuestoCaja.Columns(i).ReadOnly = True
        Next

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim index = dtgPresupuestoCaja.Rows.Add()
        For i = 1 To 4
            dtgPresupuestoCaja.Rows(index).Cells(i).ReadOnly = True
            dtgPresupuestoCaja.Rows(index).Cells(i).Style.BackColor = Color.LightGray
            dtgPresupuestoCaja.Rows(index).Cells(5).Style.BackColor = Color.Gray
        Next
    End Sub

    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        If dtgPresupuestoCaja.SelectedRows.Count > 0 Then
            dtgPresupuestoCaja.Rows.Remove(dtgPresupuestoCaja.CurrentRow)
        End If
    End Sub

    Private Sub dtgPresupuestoCaja_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPresupuestoCaja.CellEndEdit

        LimpiarTxt()

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
                celda.Style.BackColor = Color.White
                celda.Value = valorDecimal
            Else
                MessageBox.Show("Solo se permiten valores numéricos en '" & nombreColumna & "'.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                celda.Style.BackColor = Color.Yellow
                celda.Value = Nothing
            End If
        End If

        'Calculos'
        dtgPresupuestoCaja.CurrentRow.Cells(5).Value = dtgPresupuestoCaja.CurrentRow.Cells(1).Value - dtgPresupuestoCaja.CurrentRow.Cells(2).Value - dtgPresupuestoCaja.CurrentRow.Cells(3).Value - dtgPresupuestoCaja.CurrentRow.Cells(4).Value
        CalcularTotal()

        If dtgPresupuestoCaja.CurrentRow.Cells(5).Value < 0 Then
            dtgPresupuestoCaja.CurrentRow.Cells(5).Style.BackColor = Color.FromArgb(200, 100, 100)

        Else
            dtgPresupuestoCaja.CurrentRow.Cells(5).Style.BackColor = Color.Gray
        End If

        'Para que no se repitan los meses
        Call No_Repeated_Meses(e)


        If e.ColumnIndex = 0 Then
            Dim celdaMes = dtgPresupuestoCaja.Rows(e.RowIndex).Cells(0)
            Dim texto As String = ""

            If celdaMes.Value IsNot Nothing Then
                texto = celdaMes.Value.ToString().Trim()
            End If

            If texto <> "" Then
                For i = 1 To 4
                    dtgPresupuestoCaja.Rows(e.RowIndex).Cells(i).ReadOnly = False
                    dtgPresupuestoCaja.Rows(e.RowIndex).Cells(i).Style.BackColor = Color.White
                Next
            Else
                For i = 1 To 4
                    dtgPresupuestoCaja.Rows(e.RowIndex).Cells(i).Value = Nothing
                    dtgPresupuestoCaja.Rows(e.RowIndex).Cells(i).ReadOnly = True
                    dtgPresupuestoCaja.Rows(e.RowIndex).Cells(i).Style.BackColor = Color.LightGray
                    dtgPresupuestoCaja.Rows(e.RowIndex).Cells(5).Value = Nothing

                    If dtgPresupuestoCaja.Rows(e.RowIndex).Cells(5).Value = Nothing Then
                        dtgPresupuestoCaja.Rows(e.RowIndex).Cells(5).Style.BackColor = Color.Gray
                    End If
                Next
            End If
        End If

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
                If total >= 0 Then
                    txtFNM.Text = total.ToString("C2")
                    txtFNM.BackColor = SystemColors.Window
                Else
                    txtFNM.Text = total.ToString("C2")
                    txtFNM.BackColor = Color.FromArgb(200, 100, 100)
                End If
            End If
        Next
        total = 0


        If txtFNM.Text = Nothing And txtFNM.BackColor = Color.FromArgb(200, 100, 100) Then
            txtFNM.BackColor = SystemColors.Window
        End If

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

    Private Sub No_Repeated_Meses(e)
        LimpiarTxt()
        CalcularTotal()

        If e.ColumnIndex = dtgPresupuestoCaja.Columns("Mes").Index Then

            If e.ColumnIndex = dtgPresupuestoCaja.Columns("Mes").Index = Nothing Then Exit Sub

            Dim mes_selected = dtgPresupuestoCaja.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            If mes_selected Is Nothing Then Exit Sub

            ' Verificar si el mes ya está usado en otra fila'
            For Each fila As DataGridViewRow In dtgPresupuestoCaja.Rows

                If Not fila.IsNewRow AndAlso fila.Index <> e.RowIndex Then
                    Dim valor = fila.Cells("Mes").Value

                    If valor = mes_selected Then
                        MsgBox("Ese mes ya fue seleccionado.", MsgBoxStyle.Exclamation, "Advertencia")
                        dtgPresupuestoCaja.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Nothing

                        Exit For
                    End If
                End If
            Next
        End If
    End Sub

End Class