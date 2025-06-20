Imports System.ComponentModel

Public Class FrmPresupuestoVentas
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtNombreProducto.Text = "Ingrese el nombre del producto" Then
            TxtNombreProducto.Clear()
            TxtNombreProducto.Text.Trim()
        End If
        If String.IsNullOrWhiteSpace(TxtNombreProducto.Text) Then
            TxtNombreProducto.Clear()
            MsgBox("Escriba un nombre del producto")
            TxtNombreProducto.Focus()
        Else

        End If

        If String.IsNullOrWhiteSpace(txtPreciounitario.Text) Then
            txtPreciounitario.Clear()
            MsgBox("Escriba un precio unitario")
            txtPreciounitario.Focus()
        Else

        End If
        If Not IsNumeric(txtPreciounitario.Text) Then
            MsgBox("Escribe un valor numérico")
            txtPreciounitario.Clear()
            txtPreciounitario.Focus()

        End If
        'Guardamos los datos de los textbox en variables.
        Dim Producto As String = TxtNombreProducto.Text
        Dim Unidades As Integer = Integer.Parse(txtunidaesproyectadas.Text)
        Dim Preciounitario As Decimal = Decimal.Parse(txtPreciounitario.Text)
        Dim gastoventas As Decimal = Decimal.Parse(TxtGastoVentas.Text)
        Dim publicidadUnidad As Decimal = Decimal.Parse(txtPublicidadCsUnidad.Text)
        'Calculos de cada variable.
        Dim ingresosbrutos As Decimal = Unidades * Preciounitario
        Dim Devoluciones As Decimal = ingresosbrutos * 0.05D
        Dim ingresosNetos As Decimal = ingresosbrutos - Devoluciones
        Dim CostoVentas As Decimal = ingresosbrutos * 0.4D
        Dim gastoPublicidad As Decimal = Unidades * publicidadUnidad
        Dim utilidadbruta As Decimal = ingresosNetos - CostoVentas - gastoventas - gastoPublicidad

        'Agregar las variables en orden al datagriedview.
        DtgPresupuestodeventas.Rows.Add(Producto, Unidades, Preciounitario, ingresosbrutos, Devoluciones, ingresosNetos, CostoVentas, gastoventas, publicidadUnidad, gastoPublicidad, utilidadbruta)
        ActualizaTotales()


    End Sub

    Private Sub TxtNombreProducto_Enter(sender As Object, e As EventArgs) Handles TxtNombreProducto.Enter

        If TxtNombreProducto.Text = ("Ingrese el nombre del producto") Then
            TxtNombreProducto.Text = ("")
            TxtNombreProducto.ForeColor = Color.Black
            TxtNombreProducto.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            txtPreciounitario.Enabled = True
        End If
        If TxtNombreProducto.Text Is Nothing Then
            MsgBox("Escriba un nombre del producto")
        Else
        End If
    End Sub

    Private Sub txtPreciounitario_Enter(sender As Object, e As EventArgs) Handles txtPreciounitario.Enter

        If txtPreciounitario.Text = ("Ingrese el precio") Then
            txtPreciounitario.Text = ("")
            txtPreciounitario.ForeColor = Color.Black
            txtPreciounitario.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            If Not IsNumeric(txtPreciounitario.Text) Then
                txtPreciounitario.Clear()
                txtPreciounitario.Focus()
            End If

        End If
    End Sub

    Private Sub TxtNombreProducto_Validating(sender As Object, e As CancelEventArgs) Handles TxtNombreProducto.Validating
        If TxtNombreProducto.Text = ("") Then
            MsgBox("Por favor, escriba un nombre de producto")
            TxtNombreProducto.Clear()
            TxtNombreProducto.Focus()
        End If
    End Sub

    Private Sub txtPreciounitario_Validating(sender As Object, e As CancelEventArgs) Handles txtPreciounitario.Validating
        If txtPreciounitario.Text.Trim = "" Then
            MsgBox("No deje espacios en blanco")
            txtPreciounitario.Clear()
            txtPreciounitario.Focus()
        End If

        If Not IsNumeric(txtPreciounitario.Text) Then
            txtPreciounitario.Clear()
            txtPreciounitario.Focus()
            MsgBox("Escribe un valor numérico")

        End If
        If IsNumeric(txtPreciounitario.Text) Then
            If CDbl(txtPreciounitario.Text) <= 0 Then
                MsgBox("No se permiten numeros negativos o 0")
                txtPreciounitario.Clear()
                txtPreciounitario.Focus()
            End If
        End If



    End Sub

    Private Sub FrmPresupuestoVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtgPresupuestodeventas.AllowUserToAddRows = False

    End Sub

    Private Sub TxtGastoVentas_Validating(sender As Object, e As CancelEventArgs) Handles TxtGastoVentas.Validating
        If Not IsNumeric(TxtGastoVentas.Text) Then
            TxtGastoVentas.Clear()
            TxtGastoVentas.Focus()
            MsgBox("Por favor, introduzca un valor numerico valido para gasto de ventas.")

        End If
        If TxtGastoVentas.Text <= 0 Then
            MsgBox("No se permiten numeros negativos o 0")
            TxtGastoVentas.Clear()
            TxtGastoVentas.Focus()
        End If

    End Sub

    Private Sub TxtGastoVentas_Enter(sender As Object, e As EventArgs) Handles TxtGastoVentas.Enter
        If TxtGastoVentas.Text = ("Ingrese el gasto de ventas") Then
            TxtGastoVentas.Text = ("")
            TxtGastoVentas.ForeColor = Color.Black
            TxtGastoVentas.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            If Not IsNumeric(TxtGastoVentas.Text) Then
                TxtGastoVentas.Clear()
                TxtGastoVentas.Focus()
            End If

        End If
    End Sub

    Private Sub txtunidaesproyectadas_Validating(sender As Object, e As CancelEventArgs) Handles txtunidaesproyectadas.Validating
        If txtunidaesproyectadas.Text.Trim = "" Then
            MsgBox("No deje espacios en blanco")
            txtunidaesproyectadas.Clear()
            txtunidaesproyectadas.Focus()
        End If

        If Not IsNumeric(txtunidaesproyectadas.Text) Then
            txtunidaesproyectadas.Clear()
            txtunidaesproyectadas.Focus()
            MsgBox("Escribe un valor numérico")

        End If
        If IsNumeric(txtunidaesproyectadas.Text) Then
            If CDbl(txtunidaesproyectadas.Text) <= 0 Then

                MsgBox("No se permiten numeros negativos o 0")
                txtunidaesproyectadas.Clear()
                txtunidaesproyectadas.Focus()
            End If
        End If
    End Sub

    Private Sub BtnEliminarfila_Click(sender As Object, e As EventArgs) Handles BtnEliminarfila.Click
        If DtgPresupuestodeventas.SelectedRows.Count > 0 Then
            DtgPresupuestodeventas.Rows.Remove(DtgPresupuestodeventas.CurrentRow)
            ActualizaTotales()

        End If
    End Sub
    'Actualiza los totales en nuevas variables pa sumar o restar, no moverle
    Private Sub ActualizaTotales()
        Dim TotalUnidades As Integer = 0
        Dim Totalpreciounitario As Decimal = 0D
        Dim TotalIngresosBrutos As Decimal = 0D
        Dim TotalDevoluciones As Decimal = 0D
        Dim TotalIngresosNetos As Decimal = 0D
        Dim TotalCostoVentas As Decimal = 0D
        Dim totalGastoVentas As Decimal = 0D
        Dim totalPublicidadUnidad As Decimal = 0D
        Dim totalGastoPublicidad As Decimal = 0D
        Dim totalUtilidadBruta As Decimal = 0D
        'Este foreach recorre las filas del dtg 
        For Each fila As DataGridViewRow In DtgPresupuestodeventas.Rows
            'Verificamos q no sea la ultima fila vacia
            If Not fila.IsNewRow Then
                'Acumulamos los valores de cada columna
                TotalUnidades += CInt(fila.Cells("ColUnidadesProyectadas").Value)
                Totalpreciounitario += CDec(fila.Cells("ColPrecioUnitario").Value)
                TotalIngresosBrutos += CDec(fila.Cells("ColIngresosBrutos").Value)
                TotalDevoluciones += CDec(fila.Cells("ColDevoluciones").Value)
                TotalIngresosNetos += CDec(fila.Cells("ColIngresosnetos").Value)
                TotalCostoVentas += CDec(fila.Cells("ColCostoVentas").Value)
                totalGastoVentas += CDec(fila.Cells("ColGastoVentas").Value)
                totalPublicidadUnidad += CDec(fila.Cells("ColPublicidad").Value)
                totalGastoPublicidad += CDec(fila.Cells("ColGastopublicidad").Value)
                totalUtilidadBruta += CDec(fila.Cells("ColUtilidadBruta").Value)
            End If
        Next
        'Actualiza los textbox de totales
        txtunidadesproyectadastotal.Text = TotalUnidades.ToString()
        txttotalpreciounitario.Text = Totalpreciounitario.ToString()
        txtTotalingresosbrutos.Text = TotalIngresosBrutos.ToString()
        txtTotaldevoluciones.Text = TotalDevoluciones.ToString()
        txtTotalingresosNetos.Text = TotalIngresosNetos.ToString()
        txtTotalCostodeventas.Text = TotalCostoVentas.ToString()
        txtTotalgastoVentas.Text = totalGastoVentas.ToString()
        txtTotalPublicidad.Text = totalPublicidadUnidad.ToString()
        txtTotalgastoPublicidad.Text = totalGastoPublicidad.ToString()
        txtTotalUtilidadbruta.Text = totalUtilidadBruta.ToString()
    End Sub
End Class