Imports System.ComponentModel
Imports System.IO

Public Class FormPresupuestodecompras
    'Variables de ingreso del usuario-------
    Public UnidadesRequeridas01 As Integer = 0
    Public InventarioFinalD01 As Decimal = 0
    Public InventarioInicial01 As Decimal = 0
    Public CostoUnidad01 As Decimal = 0
    Public CostosAdicionales As Decimal = 0
    Public CostoUnitarioTotal As Decimal = 0

    'Validando txtMaterial--------------------------------------------------------
    Private Sub txtMaterial_Validating(sender As Object, e As CancelEventArgs) Handles txtMaterial.Validating
        If txtMaterial.Text = ("") Then
            MsgBox("Por favor, un tipo de material")
            txtMaterial.Clear()
            txtMaterial.Focus()
        End If
    End Sub

    Private Sub txtMaterial_Enter(sender As Object, e As EventArgs) Handles txtMaterial.Enter

        If txtMaterial.Text = ("Escriba el material") Then
            txtMaterial.Text = ("")
            txtMaterial.ForeColor = Color.Black
            txtMaterial.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            txtMaterial.Enabled = True

        End If
        If txtMaterial.Text Is Nothing Then
            txtMaterial.Clear()
            MsgBox("Escriba un nombre del producto")
        Else
        End If
    End Sub
    ''Validando txtunidadesNecesarias-------------------------------------------------
    Private Sub txtUnidadesNecesarias_Enter(sender As Object, e As EventArgs) Handles txtUnidadesNecesarias.Enter
        If txtUnidadesNecesarias.Text = ("Ingrese unidades necesarias") Then
            txtUnidadesNecesarias.Text = ("")
            txtUnidadesNecesarias.ForeColor = Color.Black
            txtUnidadesNecesarias.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            If Not IsNumeric(txtUnidadesNecesarias.Text) Then
                txtUnidadesNecesarias.Clear()
                txtUnidadesNecesarias.Focus()
            End If

        End If
    End Sub

    Private Sub txtUnidadesNecesarias_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUnidadesNecesarias.KeyUp
        If txtUnidadesNecesarias.Text.Trim = "" Then
            MsgBox("No deje espacios en blanco")
            txtUnidadesNecesarias.Clear()
            txtUnidadesNecesarias.Focus()
        End If

        If Not IsNumeric(txtUnidadesNecesarias.Text) Then
            txtUnidadesNecesarias.Clear()
            txtUnidadesNecesarias.Focus()
            MsgBox("Escribe un valor numérico")

        End If
        If IsNumeric(txtUnidadesNecesarias.Text) Then
            If CDbl(txtUnidadesNecesarias.Text) <= 0 Then
                MsgBox("No se permiten numeros negativos o 0")
                txtUnidadesNecesarias.Clear()
                txtUnidadesNecesarias.Focus()
            End If
        End If
    End Sub
    Private Sub txtUnidadesNecesarias_Validating(sender As Object, e As CancelEventArgs) Handles txtUnidadesNecesarias.Validating
        If txtUnidadesNecesarias.Text = ("") Then
            MsgBox("Por favor, escriba las unidades necesarias.")
            txtUnidadesNecesarias.Clear()
            txtUnidadesNecesarias.Focus()
        End If
    End Sub

    'Validando txtinventariofinaldeseado.--------------------------------------------------------
    Private Sub txtInventarioFinalDeseado_Enter(sender As Object, e As EventArgs) Handles txtInventarioFinalDeseado.Enter
        If txtInventarioFinalDeseado.Text = ("Ingrese inventario final") Then
            txtInventarioFinalDeseado.Text = ("")
            txtInventarioFinalDeseado.ForeColor = Color.Black
            txtInventarioFinalDeseado.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            If Not IsNumeric(txtInventarioFinalDeseado.Text) Then
                txtInventarioFinalDeseado.Clear()
                txtInventarioFinalDeseado.Focus()
            End If

        End If
    End Sub

    Private Sub txtInventarioFinalDeseado_KeyUp(sender As Object, e As KeyEventArgs) Handles txtInventarioFinalDeseado.KeyUp
        If txtInventarioFinalDeseado.Text.Trim = "" Then
            MsgBox("No deje espacios en blanco")
            txtInventarioFinalDeseado.Clear()
            txtInventarioFinalDeseado.Focus()
        End If

        If Not IsNumeric(txtInventarioFinalDeseado.Text) Then
            txtInventarioFinalDeseado.Clear()
            txtInventarioFinalDeseado.Focus()
            MsgBox("Escribe un valor numérico")

        End If
        If IsNumeric(txtInventarioFinalDeseado.Text) Then
            If CDbl(txtInventarioFinalDeseado.Text) <= 0 Then
                MsgBox("No se permiten numeros negativos o 0")
                txtInventarioFinalDeseado.Clear()
                txtInventarioFinalDeseado.Focus()
            End If
        End If
    End Sub
    Private Sub txtInventarioFinalDeseado_Validating(sender As Object, e As CancelEventArgs) Handles txtInventarioFinalDeseado.Validating
        If txtInventarioFinalDeseado.Text = ("") Then
            MsgBox("Por favor, escriba el inventario final deseado.")
            txtInventarioFinalDeseado.Clear()
            txtInventarioFinalDeseado.Focus()
        End If
    End Sub
    'Validando el txtInventario inicial------------------------------------------------
    Private Sub txtInventarioInicial_Enter(sender As Object, e As EventArgs) Handles txtInventarioInicial.Enter
        If txtInventarioInicial.Text = ("Ingrese inventario inicial") Then
            txtInventarioInicial.Text = ("")
            txtInventarioInicial.ForeColor = Color.Black
            txtInventarioInicial.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            If Not IsNumeric(txtInventarioInicial.Text) Then
                txtInventarioInicial.Clear()
                txtInventarioInicial.Focus()
            End If

        End If
    End Sub

    Private Sub txtInventarioInicial_KeyUp(sender As Object, e As KeyEventArgs) Handles txtInventarioInicial.KeyUp
        If txtInventarioInicial.Text.Trim = "" Then
            MsgBox("No deje espacios en blanco")
            txtInventarioInicial.Clear()
            txtInventarioInicial.Focus()
        End If

        If Not IsNumeric(txtInventarioInicial.Text) Then
            txtInventarioInicial.Clear()
            txtInventarioInicial.Focus()
            MsgBox("Escribe un valor numérico")

        End If
        If IsNumeric(txtInventarioInicial.Text) Then
            If CDbl(txtInventarioInicial.Text) <= 0 Then
                MsgBox("No se permiten numeros negativos o 0")
                txtInventarioInicial.Clear()
                txtInventarioInicial.Focus()
            End If
        End If
    End Sub
    Private Sub txtInventarioInicial_Validating(sender As Object, e As CancelEventArgs) Handles txtInventarioInicial.Validating
        If txtInventarioInicial.Text = ("") Then
            MsgBox("Por favor, escriba el inventario inicial deseado.")
            txtInventarioInicial.Clear()
            txtInventarioInicial.Focus()
        End If
    End Sub
    'Validando el txtCosto unidad
    Private Sub txtCostoUnidad_Enter(sender As Object, e As EventArgs) Handles txtCostoUnidad.Enter
        If txtCostoUnidad.Text = ("Ingrese costo por unidad") Then
            txtCostoUnidad.Text = ("")
            txtCostoUnidad.ForeColor = Color.Black
            txtCostoUnidad.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            If Not IsNumeric(txtCostoUnidad.Text) Then
                txtCostoUnidad.Clear()
                txtCostoUnidad.Focus()
            End If

        End If
    End Sub

    Private Sub txtCostoUnidad_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCostoUnidad.KeyUp
        If txtCostoUnidad.Text.Trim = "" Then
            MsgBox("No deje espacios en blanco")
            txtCostoUnidad.Clear()
            txtCostoUnidad.Focus()
        End If

        If Not IsNumeric(txtCostoUnidad.Text) Then
            txtCostoUnidad.Clear()
            txtCostoUnidad.Focus()
            MsgBox("Escribe un valor numérico")

        End If
        If IsNumeric(txtCostoUnidad.Text) Then
            If CDbl(txtCostoUnidad.Text) <= 0 Then
                MsgBox("No se permiten numeros negativos o 0")
                txtCostoUnidad.Clear()
                txtCostoUnidad.Focus()
            End If
        End If
    End Sub
    Private Sub txtCostoUnidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCostoUnidad.Validating
        If txtCostoUnidad.Text = ("") Then
            MsgBox("Por favor, escriba el costo por unidad.")
            txtCostoUnidad.Clear()
            txtCostoUnidad.Focus()
        End If
    End Sub
    'Validando txtCostos Adicionales >:p
    Private Sub txtCostosAdicionales_Enter(sender As Object, e As EventArgs) Handles txtCostosAdicionales.Enter
        If txtCostosAdicionales.Text = ("Ingrese los costos adicionales") Then
            txtCostosAdicionales.Text = ("")
            txtCostosAdicionales.ForeColor = Color.Black
            txtCostosAdicionales.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            If Not IsNumeric(txtCostosAdicionales.Text) Then
                txtCostosAdicionales.Clear()
                txtCostosAdicionales.Focus()
            End If

        End If
    End Sub

    Private Sub txtCostosAdicionales_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCostosAdicionales.KeyUp
        If txtCostosAdicionales.Text.Trim = "" Then
            MsgBox("No deje espacios en blanco")
            txtCostosAdicionales.Clear()
            txtCostosAdicionales.Focus()
        End If

        If Not IsNumeric(txtCostosAdicionales.Text) Then
            txtCostosAdicionales.Clear()
            txtCostosAdicionales.Focus()
            MsgBox("Escribe un valor numérico")

        End If
        If IsNumeric(txtCostosAdicionales.Text) Then
            If CDbl(txtCostosAdicionales.Text) <= 0 Then
                MsgBox("No se permiten numeros negativos o 0")
                txtCostosAdicionales.Clear()
                txtCostosAdicionales.Focus()
            End If
        End If
    End Sub
    Private Sub txtCostosAdicionales_Validating(sender As Object, e As CancelEventArgs) Handles txtCostosAdicionales.Validating
        If txtCostosAdicionales.Text = ("") Then
            MsgBox("Por favor, escriba los costos adicionales.")
            txtCostosAdicionales.Clear()
            txtCostosAdicionales.Focus()
        End If
    End Sub
    'Validando el txtpCosto unitario total

    Private Sub txtPagototal_Enter(sender As Object, e As EventArgs) Handles txtCostounitariototal.Enter
        If txtCostounitariototal.Text = ("Ingrese el costo unitario total") Then
            txtCostounitariototal.Text = ("")
            txtCostounitariototal.ForeColor = Color.Black
            txtCostounitariototal.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            If Not IsNumeric(txtCostounitariototal.Text) Then
                txtCostounitariototal.Clear()
                txtCostounitariototal.Focus()
            End If

        End If
    End Sub

    Private Sub txtPagototal_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCostounitariototal.KeyUp
        If txtCostounitariototal.Text.Trim = "" Then
            MsgBox("No deje espacios en blanco")
            txtCostounitariototal.Clear()
            txtCostounitariototal.Focus()
        End If

        If Not IsNumeric(txtCostounitariototal.Text) Then
            txtCostounitariototal.Clear()
            txtCostounitariototal.Focus()
            MsgBox("Escribe un valor numérico")

        End If
        If IsNumeric(txtCostounitariototal.Text) Then
            If CDbl(txtCostounitariototal.Text) <= 0 Then
                MsgBox("No se permiten numeros negativos o 0")
                txtCostounitariototal.Clear()
                txtCostounitariototal.Focus()
            End If
        End If
    End Sub
    Private Sub txtPagototal_Validating(sender As Object, e As CancelEventArgs) Handles txtCostounitariototal.Validating
        If txtCostounitariototal.Text = ("") Then
            MsgBox("Por favor, escriba el pago total.")
            txtCostounitariototal.Clear()
            txtCostounitariototal.Focus()
        End If
    End Sub

    Private Sub FormPresupuestodecompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtgPresupuestoCompras.AllowUserToAddRows = False
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregarC.Click

        'Validacion txt material
        If txtMaterial.Text = ("") Then
            MsgBox("Por favor, escriba el material")
            txtMaterial.Clear()
            txtMaterial.Focus()
        End If
        'Validación txt unidades necesarias----------------------------------------------------------------
        If txtUnidadesNecesarias.Text = ("") Then
            MsgBox("por favor, escriba las unidades necesarias")
            txtUnidadesNecesarias.Clear()
            txtUnidadesNecesarias.Focus()
        ElseIf Not IsNumeric(txtUnidadesNecesarias.Text) Then
            txtUnidadesNecesarias.Clear()
            txtUnidadesNecesarias.Focus()
            txtUnidadesNecesarias.ForeColor = Color.Black
            txtUnidadesNecesarias.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            MsgBox("Escriba un valor numérico")
        ElseIf IsNumeric(txtUnidadesNecesarias.Text) Then
            If (txtUnidadesNecesarias.Text) <= 0 Then
                MsgBox("No se permiten numeros negativos o 0")
                txtUnidadesNecesarias.Clear()
                txtUnidadesNecesarias.Focus()
            ElseIf Integer.TryParse(txtUnidadesNecesarias.Text, UnidadesRequeridas01) Then
            Else
                MsgBox("No se permiten decimales")
                txtUnidadesNecesarias.Clear()
                txtUnidadesNecesarias.Focus()
                Return
            End If
        End If
        'Validación txt inventario final deseado-------------------------------------------------------------
        If txtInventarioFinalDeseado.Text = ("") Then
            MsgBox("por favor, escriba el inventario final.")
            txtInventarioFinalDeseado.Clear()
            txtInventarioFinalDeseado.Focus()
        ElseIf Not IsNumeric(txtInventarioFinalDeseado.Text) Then
            txtInventarioFinalDeseado.Clear()
            txtInventarioFinalDeseado.Focus()
            txtInventarioFinalDeseado.ForeColor = Color.Black
            txtInventarioFinalDeseado.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            MsgBox("Escriba un valor numérico")
        ElseIf IsNumeric(txtInventarioFinalDeseado.Text) Then
            If (txtInventarioFinalDeseado.Text) <= 0 Then
                MsgBox("No se permiten numeros negativos o 0")
                txtInventarioFinalDeseado.Clear()
                txtInventarioFinalDeseado.Focus()
            Else
                InventarioFinalD01 = Decimal.Parse(txtInventarioFinalDeseado.Text)
            End If
        End If

        'Validación txt inventario inicial------------------------------------------------------------------
        If txtInventarioInicial.Text = ("") Then
            MsgBox("por favor, escriba el inventario inicial")
            txtInventarioInicial.Clear()
            txtInventarioInicial.Focus()
        ElseIf Not IsNumeric(txtInventarioInicial.Text) Then
            txtInventarioInicial.Clear()
            txtInventarioInicial.Focus()
            txtInventarioInicial.ForeColor = Color.Black
            txtInventarioInicial.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            MsgBox("Escriba un valor numérico")
        ElseIf IsNumeric(txtInventarioInicial.Text) Then
            If (txtInventarioInicial.Text) <= 0 Then
                MsgBox("No se permiten numeros negativos o 0")
                txtInventarioInicial.Clear()
                txtInventarioInicial.Focus()
            Else
                InventarioInicial01 = Decimal.Parse(txtInventarioInicial.Text)
            End If
        End If
        'Validación txt Costo por unidad-------------------------------------------------------------
        If txtCostoUnidad.Text = ("") Then
            MsgBox("por favor, escriba el costo por unidad")
            txtCostoUnidad.Clear()
            txtCostoUnidad.Focus()
        ElseIf Not IsNumeric(txtCostoUnidad.Text) Then
            txtCostoUnidad.Clear()
            txtCostoUnidad.Focus()
            txtCostoUnidad.ForeColor = Color.Black
            txtCostoUnidad.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            MsgBox("Escriba un valor numérico")
        ElseIf IsNumeric(txtCostoUnidad.Text) Then
            If (txtCostoUnidad.Text) <= 0 Then
                MsgBox("No se permiten numeros negativos o 0")
                txtCostoUnidad.Clear()
                txtCostoUnidad.Focus()
            Else
                CostoUnidad01 = Decimal.Parse(txtCostoUnidad.Text)
            End If
        End If
        'Validación txt costos adicionales-------------------------------------------------------------
        If txtCostosAdicionales.Text = ("") Then
            MsgBox("por favor, escriba los costos adicionales")
            txtCostosAdicionales.Clear()
            txtCostosAdicionales.Focus()
            Return
        ElseIf Not IsNumeric(txtCostosAdicionales.Text) Then
            txtCostosAdicionales.Clear()
            txtCostosAdicionales.Focus()
            txtCostosAdicionales.ForeColor = Color.Black
            txtCostosAdicionales.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            MsgBox("Escriba un valor numérico")
            Return
        ElseIf IsNumeric(txtCostosAdicionales.Text) Then
            If (txtCostosAdicionales.Text) <= 0 Then
                MsgBox("No se permiten numeros negativos o 0")
                txtCostosAdicionales.Clear()
                txtCostosAdicionales.Focus()
            Else
                CostosAdicionales = Decimal.Parse(txtCostosAdicionales.Text)
            End If
        End If
        'Validación txt costo unitario total-------------------------------------------------------------
        If txtCostounitariototal.Text = ("") Then
            MsgBox("por favor, escriba el costo unitario total")
            txtCostounitariototal.Clear()
            txtCostounitariototal.Focus()
            Return
        ElseIf Not IsNumeric(txtCostounitariototal.Text) Then
            txtCostounitariototal.Clear()
            txtCostounitariototal.Focus()
            txtCostounitariototal.ForeColor = Color.Black
            txtCostounitariototal.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            MsgBox("Escriba un valor numérico")
            Return
        ElseIf IsNumeric(txtCostounitariototal.Text) Then
            If (txtCostounitariototal.Text) <= 0 Then
                MsgBox("No se permiten numeros negativos o 0")
                txtCostounitariototal.Clear()
                txtCostounitariototal.Focus()
            Else
                CostoUnitarioTotal = Decimal.Parse(txtCostounitariototal.Text)
            End If
        End If

        'Calculos
        Dim Material As String = txtMaterial.Text
        Dim UnidadesComprar As Decimal = UnidadesRequeridas01 + InventarioFinalD01 - InventarioInicial01
        Dim CostoTotalCompra As Decimal = UnidadesComprar * CostoUnidad01
        Dim PagoTotal As Decimal = UnidadesComprar * CostoUnitarioTotal
        'Agregar al data griedview
        DtgPresupuestoCompras.Rows.Add(Material, UnidadesRequeridas01, InventarioFinalD01, InventarioInicial01, UnidadesComprar, CostoUnidad01, CostoTotalCompra, CostosAdicionales, CostoUnitarioTotal, PagoTotal)
        ActualizaTotales()

        txtMaterial.Clear()
        txtUnidadesNecesarias.Clear()
        txtInventarioFinalDeseado.Clear()
        txtInventarioInicial.Clear()
        txtCostoUnidad.Clear()
        txtCostosAdicionales.Clear()
        txtCostounitariototal.Clear()


    End Sub

    Private Sub BtnEliminarfila_Click(sender As Object, e As EventArgs) Handles BtnEliminarfila.Click
        If DtgPresupuestoCompras.SelectedRows.Count > 0 Then
            DtgPresupuestoCompras.Rows.Remove(DtgPresupuestoCompras.CurrentRow)
            ActualizaTotales()
        End If
    End Sub
    Private Sub ActualizaTotales()
        Dim TotalUnidadesNecesarias As Integer = 0
        Dim TotalInventarioFinal As Decimal = 0D
        Dim TotalInventarioInicial As Decimal = 0D
        Dim TotalunidadesComprar As Decimal = 0D
        Dim TotalCostoUnidad As Decimal = 0D
        Dim TotalCostoTotalCompra As Decimal = 0D
        Dim TotalCostosAdicionales As Decimal = 0D
        Dim totalCostoUnitarioTotal As Decimal = 0D
        Dim totalPagototal As Decimal = 0D
        Dim totalUtilidadBruta As Decimal = 0D
        'Este foreach recorre las filas del dtg 
        For Each fila As DataGridViewRow In DtgPresupuestoCompras.Rows
            'Verificamos q no sea la ultima fila vacia
            If Not fila.IsNewRow Then
                'Acumulamos los valores de cada columna
                TotalUnidadesNecesarias += CInt(fila.Cells("ColUnidadesnecesarias").Value)
                TotalInventarioFinal += CDec(fila.Cells("ColInventariofinaldeseado").Value)
                TotalInventarioInicial += CDec(fila.Cells("Colinventarioinicial").Value)
                TotalunidadesComprar += CDec(fila.Cells("ColUnidadescomprar").Value)
                TotalCostoUnidad += CDec(fila.Cells("ColCostoporunidad").Value)
                TotalCostoTotalCompra += CDec(fila.Cells("Colcostototaldecompra").Value)
                TotalCostosAdicionales += CDec(fila.Cells("ColCostoAdicionales").Value)
                totalCostoUnitarioTotal += CDec(fila.Cells("Colcostounitariototal").Value)
                totalPagototal += CDec(fila.Cells("ColPagototal").Value)

            End If
        Next
        'Actualiza los textbox de totales
        txtTotalunidadesNecesarias.Text = TotalUnidadesNecesarias.ToString()
        txtTotalInventariofinal.Text = TotalInventarioFinal.ToString()
        txtTotalInventarioinic.Text = TotalInventarioInicial.ToString()
        txtTotalUnidadesComprar.Text = TotalunidadesComprar.ToString()
        txtTotalCostounidad.Text = TotalCostoUnidad.ToString()
        txtTotalCostoTotalCompra.Text = TotalCostoTotalCompra.ToString()
        txtTotalCostoAdicionales.Text = TotalCostosAdicionales.ToString()
        txtTotalCostounitarioTotal.Text = totalCostoUnitarioTotal.ToString()
        txtTotaldepagoTotal.Text = totalPagototal.ToString()

    End Sub
    Private Sub ValidarCampos()
        If txtMaterial.Text <> "" And txtMaterial.Text <> "Escriba el material" And
           txtUnidadesNecesarias.Text <> "" And txtUnidadesNecesarias.Text <> "Ingrese unidades necesarias" And
           txtInventarioFinalDeseado.Text <> "" And txtInventarioFinalDeseado.Text <> "Ingrese inventario final" And
           txtInventarioInicial.Text <> "" And txtInventarioInicial.Text <> "Ingrese inventario inicial" And
           txtCostoUnidad.Text <> "" And txtCostoUnidad.Text <> "Ingrese costo por unidad" And
           txtCostosAdicionales.Text <> "" And txtCostosAdicionales.Text <> "Ingrese los costos adicionales" And
           txtCostounitariototal.Text <> "" And txtCostounitariototal.Text <> "Ingrese el costo unitario total" Then


            BtnAgregarC.Enabled = True
        Else
            BtnAgregarC.Enabled = False
        End If
    End Sub
    Private Sub TextBoxes_TextChanged(sender As Object, e As EventArgs) _
   Handles txtMaterial.TextChanged,
           txtUnidadesNecesarias.TextChanged,
           txtInventarioFinalDeseado.TextChanged,
           txtInventarioInicial.TextChanged,
           txtCostoUnidad.TextChanged,
           txtCostosAdicionales.TextChanged,
           txtCostounitariototal.TextChanged


        ValidarCampos()
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        'Dialogo para que el usuario guarde donde quiera su archivo
        Dim guardarDialogo As New SaveFileDialog()
        guardarDialogo.Filter = "Archivos de texto (*.txt)|*.txt" 'Filtrar que formato esta permitido
        guardarDialogo.Title = "Guardar datos del DataGridView" 'Texto que aparecerá en la barra de dialogo
        guardarDialogo.FileName = "Presupuesto_Compras.txt" 'Nombre del archivo   

        If guardarDialogo.ShowDialog() = DialogResult.OK Then 'Abre la ventana y el ok verefica si el usuario hizo click en guardar y no en cacelar
            Using writer As New StreamWriter(guardarDialogo.FileName)

                For Each columna As DataGridViewColumn In DtgPresupuestoCompras.Columns
                    Dim valorescolumnas As New List(Of String)
                    For Each fila As DataGridViewRow In DtgPresupuestoCompras.Rows 'Recorre filas del dtg
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