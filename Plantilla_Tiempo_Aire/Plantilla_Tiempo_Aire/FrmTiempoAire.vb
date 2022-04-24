Public Class FrmTiempoAire
    Public compania As String
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
        FrmCompania.Show()
    End Sub

    Private Sub tiempoAire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInstruccion.Text = "Seleccione la recarga que desea de la Compañia " + compania
    End Sub

    Private Sub Btn20_Click(sender As Object, e As EventArgs) Handles Btn20.Click
        Me.Hide()
        FrmNumero.valor = 20
        FrmNumero.ShowDialog()

    End Sub

    Private Sub Btn100_Click(sender As Object, e As EventArgs) Handles Btn100.Click
        Me.Hide()
        FrmNumero.valor = 100
        FrmNumero.ShowDialog()
    End Sub

    Private Sub Btn50_Click(sender As Object, e As EventArgs) Handles Btn50.Click
        Me.Hide()
        FrmNumero.valor = 50
        FrmNumero.ShowDialog()
    End Sub

    Private Sub Btn500_Click(sender As Object, e As EventArgs) Handles Btn500.Click
        Me.Hide()
        FrmNumero.valor = 500
        FrmNumero.ShowDialog()
    End Sub
End Class
