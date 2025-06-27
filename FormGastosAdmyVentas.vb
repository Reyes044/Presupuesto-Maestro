Imports System.IO

Public Class FormGastosAdmyVentas
    Dim toolTip1 As New ToolTip()
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        ' Obtener el concepto del ComboBox
        If CmbCambiodeconcepto.SelectedItem Is Nothing Then
            MessageBox.Show("Seleccione un concepto del combo box.")
            Exit Sub
        End If

        Dim concepto As String = CmbCambiodeconcepto.SelectedItem.ToString()
        Dim producto As String = txtProducto.Text.Trim()
        Dim cantidad As Decimal

        ' Validar campos
        If producto = "" OrElse Not Decimal.TryParse(txtcantidad.Text.Trim(), cantidad) Then
            MessageBox.Show("Debe ingresar un producto válido y una cantidad numérica.")
            Exit Sub
        End If

        ' Normaliza el nombre de la columna
        producto = producto.Replace(" ", "_")

        ' Verificar si la columna del producto ya existe
        If Not DtgGastoAdmyVentas.Columns.Contains(producto) Then
            'Busca el indice del total de la columna
            Dim indiceTotal As Integer = DtgGastoAdmyVentas.Columns("ColTotal").Index
            'Crea una nueva columna (objeto) en la variable
            Dim nuevaColumna As New DataGridViewTextBoxColumn()
            'Luego le asigna un nuevo nombre y texto fuera del producto nuevos
            nuevaColumna.Name = producto
            nuevaColumna.HeaderText = producto

            DtgGastoAdmyVentas.Columns.Insert(indiceTotal, nuevaColumna)
        End If

        ' Buscar fila con el mismo concepto
        Dim filaEncontrada As DataGridViewRow = Nothing
        For Each fila As DataGridViewRow In DtgGastoAdmyVentas.Rows
            If Not fila.IsNewRow AndAlso fila.Cells("ColConcepto").Value = concepto Then
                filaEncontrada = fila
                Exit For
            End If
        Next

        ' Si no existe la fila con ese concepto, agregarla
        If filaEncontrada Is Nothing Then
            Dim nuevaFilaIndex As Integer = DtgGastoAdmyVentas.Rows.Add()
            filaEncontrada = DtgGastoAdmyVentas.Rows(nuevaFilaIndex)
            filaEncontrada.Cells("ColConcepto").Value = concepto
        End If

        ' Agregar o acumular cantidad
        Dim cantidadExistente As Decimal = 0
        If IsNumeric(filaEncontrada.Cells(producto).Value) Then
            cantidadExistente = Convert.ToDecimal(filaEncontrada.Cells(producto).Value)
        End If
        filaEncontrada.Cells(producto).Value = cantidadExistente + cantidad

        ' Calcular el total
        Dim sumaTotal As Decimal = 0
        For Each columna As DataGridViewColumn In DtgGastoAdmyVentas.Columns
            If columna.Name <> "ColConcepto" And columna.Name <> "ColTotal" Then
                If IsNumeric(filaEncontrada.Cells(columna.Name).Value) Then
                    sumaTotal += Convert.ToDecimal(filaEncontrada.Cells(columna.Name).Value)
                End If
            End If
        Next
        filaEncontrada.Cells("ColTotal").Value = sumaTotal

        ' Limpiar campos
        txtProducto.Clear()
        txtcantidad.Clear()
        ActualizarTotalesPorColumna()

    End Sub

    Private Sub BtnAgregarconcepto_Click(sender As Object, e As EventArgs) Handles BtnAgregarconcepto.Click
        Dim nuevoConcepto As String = TxtConcepto.Text.Trim()

        If nuevoConcepto = "" Then
            MessageBox.Show("Ingrese un concepto válido.")
            Exit Sub
        End If

        ' Solo lo agrega si no existe ya
        If Not CmbCambiodeconcepto.Items.Contains(nuevoConcepto) Then
            CmbCambiodeconcepto.Items.Add(nuevoConcepto)
        End If

        TxtConcepto.Clear()
    End Sub


    Private Sub ActualizarTotalesPorColumna()
        ' Asegúrate de tener una fila reservada para totales al final
        Dim filaTotales As DataGridViewRow

        ' Verifica si la última fila es la de totales
        If DtgGastoAdmyVentas.Rows.Count = 0 OrElse DtgGastoAdmyVentas.Rows(DtgGastoAdmyVentas.Rows.Count - 1).IsNewRow Then
            'DtgGastoAdmyVentas.Rows.Add() ' Agrega fila si está vacía
        End If

        filaTotales = DtgGastoAdmyVentas.Rows(DtgGastoAdmyVentas.Rows.Count - 1)
        filaTotales.DefaultCellStyle.BackColor = Color.LightGray
        filaTotales.ReadOnly = True

        filaTotales.Cells("ColConcepto").Value = "TOTAL GENERAL"

        ' Sumar cada columna numérica (omitir fila de totales y nuevas)
        For Each columna As DataGridViewColumn In DtgGastoAdmyVentas.Columns
            If columna.Name <> "ColConcepto" AndAlso columna.Name <> "ColTotal" Then
                Dim suma As Decimal = 0
                For i As Integer = 0 To DtgGastoAdmyVentas.Rows.Count - 2 ' omitir fila de totales
                    Dim celda = DtgGastoAdmyVentas.Rows(i).Cells(columna.Index)
                    If IsNumeric(celda.Value) Then
                        suma += Convert.ToDecimal(celda.Value)
                    End If
                Next
                filaTotales.Cells(columna.Index).Value = suma
            End If
        Next

        ' Calcular total general también
        Dim totalGeneral As Decimal = 0
        For i As Integer = 0 To DtgGastoAdmyVentas.Rows.Count - 2
            Dim celda = DtgGastoAdmyVentas.Rows(i).Cells("ColTotal")
            If IsNumeric(celda.Value) Then
                totalGeneral += Convert.ToDecimal(celda.Value)
            End If
        Next
        filaTotales.Cells("ColTotal").Value = totalGeneral
    End Sub

    Private Sub FormGastosAdmyVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toolTip1.SetToolTip(Btnayuda1, "Nota:Para seguir agregando un producto, escribalo exactamente a como lo desea.")
        toolTip1.SetToolTip(Btnayuda, "Nota: Debe ingresar, un concepto al combo box, luego selecciona el que desee en ese combo box y llena estos 2 campos.")
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        'Dialogo para que el usuario guarde donde quiera su archivo
        Dim guardarDialogo As New SaveFileDialog()
        guardarDialogo.Filter = "Archivos de texto (*.txt)|*.txt" 'Filtrar que formato esta permitido
        guardarDialogo.Title = "Guardar datos del DataGridView" 'Texto que aparecerá en la barra de dialogo
        guardarDialogo.FileName = "Gastos_Adm_y_ventas.txt" 'Nombre del archivo   

        If guardarDialogo.ShowDialog() = DialogResult.OK Then 'Abre la ventana y el ok verefica si el usuario hizo click en guardar y no en cacelar
            Using writer As New StreamWriter(guardarDialogo.FileName)

                For Each columna As DataGridViewColumn In DtgGastoAdmyVentas.Columns
                    Dim valorescolumnas As New List(Of String)
                    For Each fila As DataGridViewRow In DtgGastoAdmyVentas.Rows 'Recorre filas del dtg
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