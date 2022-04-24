Public Class frmCajeroOpciones : Inherits frmCajeroAcceso 'Agregar esto me marca error
    Dim conjuntoDeOperaciones() As String
    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close() 'Cierra el menu de opciones
        frmCajeroAcceso.Show() 'Reabre la ventana de acceso del cajero
    End Sub

End Class
