Imports System.Windows.Forms.DataFormats

Public Class Form1
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Function ObtenerTotal() As Decimal
        Dim total As Decimal = 0
        For Each fila As DataGridViewRow In DataGridView1.Rows
            Dim precio As Decimal = CDec(fila.Cells("Precio").Value)
            Dim cantidad As Decimal = CDec(fila.Cells("Cantidad").Value)
            total += precio * cantidad
        Next
        Return total
    End Function


    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Crear una nueva fila en el GridView
        Dim nuevaFila As DataGridViewRow
        nuevaFila = New DataGridViewRow()

        'Agregar las celdas a la nueva fila
        Dim celdaCantidad As New DataGridViewTextBoxCell()
        Dim celdaProducto As New DataGridViewTextBoxCell()
        Dim celdaPrecio As New DataGridViewTextBoxCell()
        nuevaFila.Cells.Add(celdaCantidad)
        nuevaFila.Cells.Add(celdaProducto)
        nuevaFila.Cells.Add(celdaPrecio)

        'Agregar los valores de las TextBox a las celdas correspondientes en la nueva fila
        celdaCantidad.Value = TxtCantidad.Text
        celdaProducto.Value = TxtProducto.Text
        celdaPrecio.Value = TxtPrecio.Text

        'Limpiar las TextBox
        TxtCantidad.Clear()
        TxtProducto.Clear()
        TxtPrecio.Clear()

        ' Añadir la fila al control DataGridView.
        DataGridView1.Rows.Add(nuevaFila)
    End Sub

    Private Sub imprimirTicket(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
        'Definir la fuente y los colores para el ticket
        Dim fuente As New Font("Arial", 10)
        Dim brush As New SolidBrush(Color.Black)
        Dim xPos As Integer = 10
        Dim yPos As Integer = 10

        'Iterar sobre las filas del DataGridView y agregarlas al ticket
        For Each fila As DataGridViewRow In DataGridView1.Rows
            'Obtener los valores de las celdas correspondientes
            Dim cantidad As Single = 0
            Dim precio As Single = 0
            Dim producto As String = ""

            If fila.Cells(0).Value IsNot Nothing AndAlso Single.TryParse(fila.Cells(0).Value.ToString(), cantidad) AndAlso
               fila.Cells(1).Value IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(fila.Cells(1).Value.ToString()) AndAlso
               fila.Cells(2).Value IsNot Nothing AndAlso Single.TryParse(fila.Cells(2).Value.ToString(), precio) Then

                producto = fila.Cells(1).Value.ToString()

                'Agregar los valores al ticket
                e.Graphics.DrawString(cantidad.ToString(), fuente, brush, xPos, yPos)
                xPos += 100
                e.Graphics.DrawString(producto, fuente, brush, xPos, yPos)
                xPos += 200
                e.Graphics.DrawString(precio.ToString(), fuente, brush, xPos, yPos)
                yPos += 20
                xPos = 10
            End If
        Next


    End Sub

    Private Sub btnGenerarTicket_Click(sender As Object, e As EventArgs) Handles Imprimir.Click
        ' Crear una instancia de la Forma 2
        Dim miForma2 As New Form2()

        ' Inicializar el texto del ticket
        Dim ticket As String = ""
        ' Agregar la información de encabezado al ticket
        ticket &= "                            " & vbCrLf
        ticket &= "                            " & vbCrLf
        ticket &= "                            " & vbCrLf
        ticket &= "                            " & vbCrLf
        ticket &= "                            " & vbCrLf
        ticket &= "                            " & vbCrLf
        ticket &= "                            " & vbCrLf
        ticket &= "                            " & vbCrLf
        ticket &= "                            " & vbCrLf
        ticket &= "                            " & vbCrLf
        ticket &= "===== Ticket de compra =====" & vbCrLf
        ticket &= "Fecha: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") & vbCrLf
        ticket &= "============================" & vbCrLf
        ticket &= "Cantidad" & vbTab & "Producto" & vbTab & "Precio" & vbCrLf
        ticket &= "============================" & vbCrLf
        ' Iterar a través de las filas del DataGridView
        For Each fila As DataGridViewRow In DataGridView1.Rows
            If Not fila.IsNewRow Then ' Verificar si la fila no es nueva
                Dim cantidad As Integer = 0
                If Not IsDBNull(fila.Cells("Cantidad").Value) Then ' Verificar si la celda "Cantidad" no está vacía
                    cantidad = CInt(fila.Cells("Cantidad").Value)
                End If
                ' Repita el proceso para las otras celdas ("Producto" y "Precio")
                Dim producto As String = ""
                If Not IsDBNull(fila.Cells("Producto").Value) Then
                    producto = fila.Cells("Producto").Value.ToString()
                End If

                Dim precio As Integer = 0
                If Not IsDBNull(fila.Cells("Precio").Value) Then
                    precio = CInt(fila.Cells("Precio").Value)
                End If

                ' Agregar la información de la fila al ticket
                ticket &= cantidad.ToString() & vbTab & producto & vbTab & precio.ToString() & vbCrLf
            End If
        Next

        ' Agregar la información de totales al ticket
        ticket &= "============================" & vbCrLf
        ticket &= "Total: " & ObtenerTotal().ToString("C") & vbCrLf
        ticket &= "============================" & vbCrLf
        ' Mostrar el ticket en el RichTextBox en la Forma 2
        miForma2.RichTextBox1.Text = ticket

        ' Mostrar la Forma 2
        miForma2.Show()
    End Sub




    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        For Each fila As DataGridViewRow In DataGridView1.Rows
            'Obtener los valores de las celdas correspondientes
            If Not String.IsNullOrEmpty(fila.Cells(0).Value) AndAlso Not String.IsNullOrEmpty(fila.Cells(1).Value) AndAlso Not String.IsNullOrEmpty(fila.Cells(2).Value) Then
                Dim cantidad As String = fila.Cells(0).Value.ToString()
                Dim producto As String = fila.Cells(1).Value.ToString()
                Dim precio As String = fila.Cells(2).Value.ToString()


            End If
        Next

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
