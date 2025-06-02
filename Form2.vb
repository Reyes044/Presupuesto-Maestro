Imports System.ComponentModel

Public Class FrmPresupuestoVentas
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtNombreProducto.Text = "Ingrese el nombre del producto" Then
            TxtNombreProducto.Clear()
            TxtNombreProducto.Text.Trim()

        End If
        If String.IsNullOrWhiteSpace(TxtNombreProducto.Text) Then
            MsgBox("Escriba un nombre del producto")
            TxtNombreProducto.Focus()

        Else
            'DtgPresupuestodeventas.Rows.Add(TxtNombreProducto.Text.Trim())
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
        'Dim precioUnitario As Decimal = Convert.ToDecimal(txtPreciounitario.Text)
        'Dim Index As Integer = DtgPresupuestodeventas.Rows.Add()

        'DtgPresupuestodeventas.Rows(Index - 1).Cells(2).Value = txtPreciounitario.Text
        Dim Producto As String = TxtNombreProducto.Text
        Dim Unidades As Integer = Integer.Parse(txtunidaesproyectadas.Text)
        Dim Preciounitario As Decimal = Decimal.Parse(txtPreciounitario.Text)
        Dim gastoventas As Decimal = Decimal.Parse(TxtGastoVentas.Text)
        Dim publicidadUnidad As Decimal = Decimal.Parse(txtPublicidadCsUnidad.Text)

        Dim ingresosbrutos As Decimal = Unidades * Preciounitario
        Dim Devoluciones As Decimal = ingresosbrutos * 0.05D
        Dim ingresosNetos As Decimal = ingresosbrutos - Devoluciones
        Dim CostoVentas As Decimal = ingresosbrutos * 0.4D
        Dim gastoPublicidad As Decimal = Unidades * publicidadUnidad
        Dim utilidadbruta As Decimal = ingresosNetos - CostoVentas - gastoventas - gastoPublicidad


        DtgPresupuestodeventas.Rows.Add(Producto, Unidades, Preciounitario, ingresosbrutos, Devoluciones, ingresosNetos, CostoVentas, gastoventas, publicidadUnidad, gastoPublicidad, utilidadbruta)






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

        End If
    End Sub

    Private Sub txtPreciounitario_Validating(sender As Object, e As CancelEventArgs) Handles txtPreciounitario.Validating
        If Not IsNumeric(txtPreciounitario.Text) Then
            MsgBox("Escribe un valor numérico")
            txtPreciounitario.Clear()
            txtPreciounitario.Focus()

        End If
    End Sub

    Private Sub FrmPresupuestoVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtgPresupuestodeventas.AllowUserToAddRows = False

    End Sub
End Class