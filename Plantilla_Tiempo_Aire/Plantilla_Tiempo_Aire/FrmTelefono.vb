Public Class FrmNumero
    Public valor As Integer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        IngresarNumero(1)
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        IngresarNumero(2)
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        IngresarNumero(3)
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        IngresarNumero(4)
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        IngresarNumero(5)
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        IngresarNumero(6)
    End Sub
    Private Sub IngresarNumero(numero As Integer)
        If (TbxNumero.Text.Length < 10) Then
            TbxNumero.Text = TbxNumero.Text + numero.ToString
        End If
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        IngresarNumero(7)
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        IngresarNumero(8)
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        IngresarNumero(9)
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        IngresarNumero(0)
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        TbxNumero.Text = ""
        Me.Close()
        FrmTiempoAire.Show()
    End Sub

    Private Sub BtnContinuar_Click(sender As Object, e As EventArgs) Handles BtnContinuar.Click
        If (TbxNumero.Text = "" Or TbxNumero.Text.Count < 10) Then
            MsgBox("Ingrese un numero valido", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Aviso")
        Else
            MsgBox("Se realizo la recarga de la compañia " + FrmTiempoAire.compania + " de un valor de " + valor.ToString + " al numero de " + TbxNumero.Text, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Aviso")
            FrmCompania.Dispose()
            FrmTiempoAire.Dispose()
            Me.Close()
            'frmCajeroAcceso.Show()
        End If

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        TbxNumero.Text = TbxNumero.Text.Remove(TbxNumero.Text.Length - 1)
    End Sub
End Class