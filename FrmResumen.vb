﻿Public Class FrmResumen
    Private Sub FrmResumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtTotalMontoR.Text = Modulo_Totales.TotalMonto


        TxtTotalMPDR.Text = Modulo_Totales.TotalMPD
        TxtTotalMODR.Text = Modulo_Totales.TotalMOD
        TxtTotalGifR.Text = Modulo_Totales.TotalGIF
        TxtTotalCTPR.Text = Modulo_Totales.TotalCTP
        TxtCUR.Text = Modulo_Totales.CostoUnitario


        TxtTotalUnidadesProyectadasR.Text = Modulo_Totales.TotalUnidades
        TxtTotalPrecioUnitarioR.Text = Modulo_Totales.TotalPrecioUnitario
        TxtTotalIngresosBrutosR.Text = Modulo_Totales.TotalIngresosBrutos
        TxtTotalDevolucionesR.Text = Modulo_Totales.TotalDevoluciones
        TxtTotalIngresosNetosR.Text = Modulo_Totales.TotalIngresosNetos
        TxtTotalCostoDVentasR.Text = Modulo_Totales.TotalCostoVentas
        TxtTotalGastoDVentasR.Text = Modulo_Totales.TotalGastoDVentas
        TxtTotalPublicidadR.Text = Modulo_Totales.TotalPublicidadCostoUni
        TxtTotalGastoPublicidaR.Text = Modulo_Totales.TotalGasoDPublicidad
        TxtTotalUtilidadBrutaR.Text = Modulo_Totales.TotalUtilidadBruta



        txtTotalUndVenderR.Text = Modulo_Totales.TotalUnidadesAVender
        txtUnidadesProducirR.Text = Modulo_Totales.TotalUnidadesAProducir
        txtCostoTotalPlaneadoR.Text = Modulo_Totales.TotalCostoTotalPlaneado
        txtCostoTotalCIFR.Text = Modulo_Totales.TotalCostoTotalCIF
        txtInventarioFinalR.Text = Modulo_Totales.TotalInventarioFinal
        txtCostoTotalProduccionR.Text = Modulo_Totales.TotalCostoTotalProduccion
        txtInventarioInicialR.Text = Modulo_Totales.TotalInventarioInicial
        txtCostoTotalMODR.Text = Modulo_Totales.TotalCostoTotalMOD




        txtTotalCostounidadR.Text = Modulo_Totales.Total_CostoTotalUnidad
        txtTotalCostoTotalCompraR.Text = Modulo_Totales.Total_CostoTotalCompras
        txtTotalCostoAdicionalesR.Text = Modulo_Totales.Total_CostoAdicionales
        txtTotalCostounitarioTotalR.Text = Modulo_Totales.Total_CostoTotalUnitario
        txtTotalunidadesNecesariasR.Text = Modulo_Totales.Total_UnidadesNecesarias
        txtTotalInventariofinalR.Text = Modulo_Totales.Total_InventarioFinal
        txtTotalInventarioinicR.Text = Modulo_Totales.Total_InventarioInicial
        txtTotalUnidadesComprarR.Text = Modulo_Totales.Total_UnidadesComprar
        TxtTotalPagoTotalR.Text = Modulo_Totales.Total_PagoTotal



        txtUnidadesProducir_R.Text = Modulo_Totales.TotalUnidadesAProducirPresupuestoMOD
        txtTotalMOD_R.Text = Modulo_Totales.TotalCostoTotalMODPresupuestoMOD
        txtTotalHoras_R.Text = Modulo_Totales.TotalCostoPorHoraMODPresupuestoMOD


        txtIngresosPorVentasTotal_R.Text = Modulo_Totales.IngresosPorVentasTotal_R
        txtPagoProvTotal_R.Text = Modulo_Totales.PagoAProveedoresTotal_R
        txtPagoSueldosTotal_R.Text = Modulo_Totales.PagoDeSueldosTotal_R
        txtOtrosPagosTotal_R.Text = Modulo_Totales.OtrosPagosTotal_R
        txtFNMTotal_R.Text = Modulo_Totales.FlujoNetoDelMesTotal_R

    End Sub

    Private Sub Lblunidadesnec_Click(sender As Object, e As EventArgs) Handles Lblunidadesnec.Click

    End Sub

    Private Sub LblTotalInventinicial_Click(sender As Object, e As EventArgs) Handles LblTotalInventinicial.Click

    End Sub

    Private Sub txtTotalInventarioinicR_TextChanged(sender As Object, e As EventArgs) Handles txtTotalInventarioinicR.TextChanged

    End Sub

    Private Sub LblUnidadescomprar_Click(sender As Object, e As EventArgs) Handles LblUnidadescomprar.Click

    End Sub

    Private Sub txtTotalUnidadesComprarR_TextChanged(sender As Object, e As EventArgs) Handles txtTotalUnidadesComprarR.TextChanged

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub TxtTotalPagoTotalR_TextChanged(sender As Object, e As EventArgs) Handles TxtTotalPagoTotalR.TextChanged

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub
End Class