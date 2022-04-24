Public Class frm_Consult
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegresar1.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSaldo.TextChanged
        txtSaldo.Text = _variable.salario
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
    End Sub
End Class