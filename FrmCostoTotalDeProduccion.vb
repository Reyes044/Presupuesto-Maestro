Public Class FrmCostoTotalDeProduccion
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim producto As String = TxtProducto.Text
        Dim Materia_Prima_Directa As Integer = TxtMPD.Text
        Dim Mano_de_Obra_Directa As Integer = TxtMOD.Text
        Dim Gif As Integer = TxtGifAsignado.Text

        Dim Costo_Total_Produccion As Integer = Materia_Prima_Directa + Mano_de_Obra_Directa + Gif

        DtgCostoTotalDeProduccion.Rows.Add(producto, Materia_Prima_Directa, Mano_de_Obra_Directa, Gif, Costo_Total_Produccion)

    End Sub

    Private Sub TxtMOD_TextChanged(sender As Object, e As EventArgs) Handles TxtMOD.TextChanged

    End Sub

    Private Sub LblMOD_Click(sender As Object, e As EventArgs) Handles LblMOD.Click

    End Sub
End Class