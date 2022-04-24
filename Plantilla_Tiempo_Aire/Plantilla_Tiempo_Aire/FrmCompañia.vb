Public Class FrmCompania
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        FrmNumero.Dispose()
        FrmTiempoAire.Dispose()
        Me.Close()
        'frmCajeroAcceso.Show()
    End Sub

    Private Sub BtnWeex_Click(sender As Object, e As EventArgs) Handles BtnWeex.Click
        FrmTiempoAire.compania = "Weex"
        Me.Hide()
        FrmTiempoAire.ShowDialog()
    End Sub

    Private Sub BtnUnefon_Click(sender As Object, e As EventArgs) Handles BtnUnefon.Click
        FrmTiempoAire.compania = "Unefon"
        Me.Hide()
        FrmTiempoAire.ShowDialog()
    End Sub

    Private Sub BtnMovistar_Click(sender As Object, e As EventArgs) Handles BtnMovistar.Click
        FrmTiempoAire.compania = "Movistar"
        Me.Hide()
        FrmTiempoAire.ShowDialog()
    End Sub

    Private Sub BtnTelcel_Click(sender As Object, e As EventArgs) Handles BtnTelcel.Click
        FrmTiempoAire.compania = "Telcel"
        Me.Hide()
        FrmTiempoAire.ShowDialog()
    End Sub
End Class