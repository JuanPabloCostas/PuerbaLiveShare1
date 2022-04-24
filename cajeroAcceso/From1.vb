Public Class frmCajeroAcceso
    Public Shared salario As Double = Int((5000 * Rnd()) + 1) 'Genera un salario nuevo para cada usuario

    Public Shared idioma As Boolean 'Sí el valor es true entonces esta en español, false esta en inglés

    Private Sub btnMenuOpciones_Click(sender As Object, e As EventArgs) Handles btnMenuOpciones.Click
        frmCajeroOpciones.Show() 'Abre el siguiente form con las opciones del cajero
    End Sub

    Private Sub cbxIdiomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIdiomas.SelectedIndexChanged
        If cbxIdiomas.SelectedItem = "Inglés" Then 'Asigna los valores a la variable global de idioma
            idioma = False                          'dependiendo de la selección del usuario
        ElseIf cbxIdiomas.SelectedItem = "Español" Then
            idioma = True
        End If
    End Sub

End Class
