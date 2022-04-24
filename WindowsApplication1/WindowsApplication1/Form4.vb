Public Class frm_Transf2

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblDigitos.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTransf2.Click
        Dim can As Double
        can = Convert.ToDouble(txtCantida.Text)
        _variable.salario = _variable.salario - can
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCantida.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtDig.TextChanged

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCantida.Text = "0"
    End Sub
End Class