Imports System.ComponentModel

Public Class FrmPresupuestoVentas
    Public Unidad1 As Integer = 0
    Public Preciounitario01 As Decimal = 0
    Public Gastoventas1 As Decimal = 0
    Public publicidadUnidad1 As Decimal = 0
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        If TxtNombreProducto.Text = ("Ingrese el nombre del producto") & ("") Then
            TxtNombreProducto.Text = ("")
            TxtNombreProducto.ForeColor = Color.Black
            TxtNombreProducto.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            txtPreciounitario.Enabled = True

        End If
        If TxtNombreProducto.Text Is Nothing Then
            TxtNombreProducto.Clear()
            MsgBox("Escriba un nombre del producto")
        Else
        End If

        If txtunidaesproyectadas.Text = ("Ingrese las unidades proyectadas") Then
            txtunidaesproyectadas.Text = ("")
            txtunidaesproyectadas.ForeColor = Color.Black
            txtunidaesproyectadas.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            If Not IsNumeric(txtunidaesproyectadas.Text) Then
                txtunidaesproyectadas.Clear()
                txtunidaesproyectadas.Focus()
            End If

        End If

        If txtPreciounitario.Text = ("Ingrese el precio") Then
            txtPreciounitario.Text = ("")
            txtPreciounitario.ForeColor = Color.Black
            txtPreciounitario.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            If Not IsNumeric(txtPreciounitario.Text) Then
                txtPreciounitario.Clear()
                txtPreciounitario.Focus()
            End If

        End If
        If TxtGastoVentas.Text = ("Ingrese el gasto de ventas") Then
            TxtGastoVentas.Text = ("")
            TxtGastoVentas.ForeColor = Color.Black
            TxtGastoVentas.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            If Not IsNumeric(TxtGastoVentas.Text) Then
                TxtGastoVentas.Clear()
                TxtGastoVentas.Focus()
            End If

        End If
        If txtPublicidadCsUnidad.Text = ("Ingrese publicidad/unidad") Then
            txtPublicidadCsUnidad.Text = ("")
            txtPublicidadCsUnidad.ForeColor = Color.Black
            txtPublicidadCsUnidad.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            If Not IsNumeric(txtPublicidadCsUnidad.Text) Then
                txtPublicidadCsUnidad.Clear()
                txtPublicidadCsUnidad.Focus()
            End If

        End If
        ''Validaciones para textbox

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
        If txtunidaesproyectadas.Text.Trim = "" Then
            MsgBox("No deje espacios en blanco")
            txtunidaesproyectadas.Clear()
            txtunidaesproyectadas.Focus()
        End If
        'Validando txt unidades proyectadas
        If txtunidaesproyectadas.Text = ("") Then
            MsgBox("No se permiten espacios en blanco, en unidades proyectadas")
            Return
        End If
        If Not IsNumeric(txtunidaesproyectadas.Text) Then
            txtunidaesproyectadas.Clear()
            txtunidaesproyectadas.Focus()
            MsgBox("Escribe un valor numérico, para unidades proyectadas")
            Return
        End If

        If IsNumeric(txtunidaesproyectadas.Text) Then

            If CDbl(txtunidaesproyectadas.Text) <= 0 Then

                MsgBox("No se permiten numeros negativos o 0, en unidades proyectadas")

                txtunidaesproyectadas.Clear()
                txtunidaesproyectadas.Focus()
                Return

            ElseIf Integer.TryParse(txtunidaesproyectadas.Text, Unidad1) Then

            Else
                MsgBox("No se permiten decimales")
                txtunidaesproyectadas.Clear()
                txtunidaesproyectadas.Focus()
                Return

            End If
            'validando gasto de ventas en el botón
            If TxtGastoVentas.Text.Trim = "" Then
                MsgBox("No deje espacios en blanco")
                TxtGastoVentas.Clear()
                TxtGastoVentas.Focus()
            End If
            If TxtGastoVentas.Text = ("") Then
                MsgBox("No se permiten espacios en blanco, en unidades proyectadas")
                Return
            End If
            If Not IsNumeric(TxtGastoVentas.Text) Then
                TxtGastoVentas.Clear()
                TxtGastoVentas.Focus()
                MsgBox("Escribe un valor numérico, para unidades proyectadas")
                Return
            End If
            If IsNumeric(TxtGastoVentas.Text) Then
                If CDbl(TxtGastoVentas.Text) <= 0 Then

                    MsgBox("No se permiten numeros negativos o 0, en gasto de ventas")

                    TxtGastoVentas.Clear()
                    TxtGastoVentas.Focus()
                Else
                    Gastoventas1 = Decimal.Parse(TxtGastoVentas.Text)
                End If
            End If


        End If
        'Validando txt preciounitario
        If txtPreciounitario.Text.Trim = "" Then
            MsgBox("No deje espacios en blanco")
            txtPreciounitario.Clear()
            txtPreciounitario.Clear()
        End If
        If txtPreciounitario.Text = ("") Then
            MsgBox("No se permiten espacios en blanco")
            Return
        End If
        If Not IsNumeric(txtPreciounitario.Text) Then
            txtPreciounitario.Clear()
            txtPreciounitario.Focus()
            MsgBox("Escribe un valor numérico, para Precio unitario")
            Return
        End If
        If IsNumeric(txtPreciounitario.Text) Then
            If CDbl(txtPreciounitario.Text) <= 0 Then

                MsgBox("No se permiten numeros negativos o 0, en precio unitario")

                txtPreciounitario.Clear()
                txtPreciounitario.Focus()
            Else
                Preciounitario01 = Decimal.Parse(txtPreciounitario.Text)
            End If
        End If
        'Validando txtPublicidadCsUnidad
        If txtPublicidadCsUnidad.Text.Trim = "" Then
            MsgBox("No deje espacios en blanco")
            txtPublicidadCsUnidad.Clear()
            txtPublicidadCsUnidad.Focus()
        End If
        If txtPublicidadCsUnidad.Text = ("") Then
            MsgBox("No se permiten espacios en blanco, en unidades proyectadas")
            Return
        End If
        If Not IsNumeric(txtPublicidadCsUnidad.Text) Then
            txtPublicidadCsUnidad.Clear()
            txtPublicidadCsUnidad.Focus()
            MsgBox("Escribe un valor numérico, en publicidad (C$/unidad)")
            Return
        End If
        If IsNumeric(txtPublicidadCsUnidad.Text) Then
            If CDbl(txtPublicidadCsUnidad.Text) <= 0 Then

                MsgBox("No se permiten numeros negativos o 0, en publicidad (C$/unidad)")

                txtPublicidadCsUnidad.Clear()
                txtPublicidadCsUnidad.Focus()
                Return
            Else
                publicidadUnidad1 = Decimal.Parse(txtPublicidadCsUnidad.Text)
            End If
        End If


        'Guardamos los datos 0e los textbox en variables.
        Dim Producto As String = TxtNombreProducto.Text
        Dim Unidades As Integer = Unidad1
        Dim Preciounitario As Decimal = Preciounitario01
        Dim gastoventas As Decimal = Gastoventas1
        Dim publicidadUnidad As Decimal = publicidadUnidad1
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
        'Limpiar textbox
        TxtNombreProducto.Clear()
        txtunidaesproyectadas.Clear()
        txtPreciounitario.Clear()
        TxtGastoVentas.Clear()
        txtPublicidadCsUnidad.Clear()

        'Cambiando fuentes pa resetear
        TxtNombreProducto.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
        txtunidaesproyectadas.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
        txtPreciounitario.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
        TxtGastoVentas.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
        txtPublicidadCsUnidad.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)





    End Sub

    Private Sub TxtNombreProducto_Enter(sender As Object, e As EventArgs) Handles TxtNombreProducto.Enter

        If TxtNombreProducto.Text = ("Ingrese el nombre del producto") & ("") Then
            TxtNombreProducto.Text = ("")
            TxtNombreProducto.ForeColor = Color.Black
            TxtNombreProducto.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            txtPreciounitario.Enabled = True

        End If
        If TxtNombreProducto.Text Is Nothing Then
            TxtNombreProducto.Clear()
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
        ValidarCampos()
    End Sub

    Private Sub TxtGastoVentas_Validating(sender As Object, e As CancelEventArgs) Handles TxtGastoVentas.Validating

        If Not IsNumeric(TxtGastoVentas.Text) Then
            TxtGastoVentas.Clear()
            TxtGastoVentas.Focus()
            MsgBox("Escribe un valor numérico")

        End If
        If IsNumeric(TxtGastoVentas.Text) Then
            If CDbl(TxtGastoVentas.Text) <= 0 Then

                MsgBox("No se permiten numeros negativos o 0")
                TxtGastoVentas.Clear()
                TxtGastoVentas.Focus()
            End If
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



    Private Sub txtPublicidadCsUnidad_Validating(sender As Object, e As CancelEventArgs) Handles txtPublicidadCsUnidad.Validating
        If txtPublicidadCsUnidad.Text.Trim = "" Then
            MsgBox("No deje espacios en blanco")
            txtPublicidadCsUnidad.Clear()
            txtPublicidadCsUnidad.Focus()
        End If

        If Not IsNumeric(txtPublicidadCsUnidad.Text) Then
            txtPublicidadCsUnidad.Clear()
            txtPublicidadCsUnidad.Focus()
            MsgBox("Escribe un valor numérico")

        End If
        If IsNumeric(txtPublicidadCsUnidad.Text) Then
            If CDbl(txtPublicidadCsUnidad.Text) <= 0 Then

                MsgBox("No se permiten numeros negativos o 0")
                txtPublicidadCsUnidad.Clear()
                txtPublicidadCsUnidad.Focus()
            End If
        End If
    End Sub

    Private Sub txtPublicidadCsUnidad_Enter(sender As Object, e As EventArgs) Handles txtPublicidadCsUnidad.Enter
        If txtPublicidadCsUnidad.Text = ("Ingrese publicidad/unidad") Then
            txtPublicidadCsUnidad.Text = ("")
            txtPublicidadCsUnidad.ForeColor = Color.Black
            txtPublicidadCsUnidad.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            If Not IsNumeric(txtPublicidadCsUnidad.Text) Then
                txtPublicidadCsUnidad.Clear()
                txtPublicidadCsUnidad.Focus()
            End If

        End If
    End Sub

    Private Sub txtunidaesproyectadas_Enter(sender As Object, e As EventArgs) Handles txtunidaesproyectadas.Enter
        If txtunidaesproyectadas.Text = ("Ingrese las unidades proyectadas") Then
            txtunidaesproyectadas.Text = ("")
            txtunidaesproyectadas.ForeColor = Color.Black
            txtunidaesproyectadas.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Regular)
            If Not IsNumeric(txtunidaesproyectadas.Text) Then
                txtunidaesproyectadas.Clear()
                txtunidaesproyectadas.Focus()
            End If

        End If
    End Sub
    Private Sub ValidarCampos()
        If TxtNombreProducto.Text <> "" And TxtNombreProducto.Text <> "Ingrese el nombre del producto" And
           txtunidaesproyectadas.Text <> "" And txtunidaesproyectadas.Text <> "las unidades proyectadas" And
           TxtGastoVentas.Text <> "" And TxtGastoVentas.Text <> "Ingrese el gasto de ventas" And
           txtPreciounitario.Text <> "" And txtPreciounitario.Text <> "Ingrese el precio" And
           txtPublicidadCsUnidad.Text <> "" And txtPublicidadCsUnidad.Text <> "Ingrese publicidad/unidad" Then

            BtnAgregar.Enabled = True
        Else
            BtnAgregar.Enabled = False
        End If
    End Sub
    Private Sub TextBoxes_TextChanged(sender As Object, e As EventArgs) _
    Handles TxtNombreProducto.TextChanged,
            txtunidaesproyectadas.TextChanged,
            TxtGastoVentas.TextChanged,
            txtPreciounitario.TextChanged,
            txtPublicidadCsUnidad.TextChanged

        ValidarCampos()
    End Sub
End Class