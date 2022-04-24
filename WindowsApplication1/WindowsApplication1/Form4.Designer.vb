<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Transf2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCantida = New System.Windows.Forms.TextBox()
        Me.txtDig = New System.Windows.Forms.TextBox()
        Me.btnTransf2 = New System.Windows.Forms.Button()
        Me.lblDigitos = New System.Windows.Forms.Label()
        Me.lblCantida = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCantida
        '
        Me.txtCantida.Location = New System.Drawing.Point(15, 104)
        Me.txtCantida.Name = "txtCantida"
        Me.txtCantida.Size = New System.Drawing.Size(221, 20)
        Me.txtCantida.TabIndex = 0
        Me.txtCantida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDig
        '
        Me.txtDig.Location = New System.Drawing.Point(15, 35)
        Me.txtDig.MaxLength = 7
        Me.txtDig.Name = "txtDig"
        Me.txtDig.Size = New System.Drawing.Size(221, 20)
        Me.txtDig.TabIndex = 1
        Me.txtDig.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnTransf2
        '
        Me.btnTransf2.Location = New System.Drawing.Point(84, 164)
        Me.btnTransf2.Name = "btnTransf2"
        Me.btnTransf2.Size = New System.Drawing.Size(75, 23)
        Me.btnTransf2.TabIndex = 2
        Me.btnTransf2.Text = "Transferir"
        Me.btnTransf2.UseVisualStyleBackColor = True
        '
        'lblDigitos
        '
        Me.lblDigitos.AutoSize = True
        Me.lblDigitos.Location = New System.Drawing.Point(12, 9)
        Me.lblDigitos.Name = "lblDigitos"
        Me.lblDigitos.Size = New System.Drawing.Size(224, 13)
        Me.lblDigitos.TabIndex = 3
        Me.lblDigitos.Text = "INGRESE LOS 7 DIGITOS DE REFERENCIA"
        '
        'lblCantida
        '
        Me.lblCantida.AutoSize = True
        Me.lblCantida.Location = New System.Drawing.Point(57, 77)
        Me.lblCantida.Name = "lblCantida"
        Me.lblCantida.Size = New System.Drawing.Size(129, 13)
        Me.lblCantida.TabIndex = 4
        Me.lblCantida.Text = "INGRESE LA CANTIDAD"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(84, 213)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 5
        Me.btnRegresar.Text = "Regresar "
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'frm_Transf2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(248, 280)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lblCantida)
        Me.Controls.Add(Me.lblDigitos)
        Me.Controls.Add(Me.btnTransf2)
        Me.Controls.Add(Me.txtDig)
        Me.Controls.Add(Me.txtCantida)
        Me.Name = "frm_Transf2"
        Me.Text = "Transferencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCantida As System.Windows.Forms.TextBox
    Friend WithEvents txtDig As System.Windows.Forms.TextBox
    Friend WithEvents btnTransf2 As System.Windows.Forms.Button
    Friend WithEvents lblDigitos As System.Windows.Forms.Label
    Friend WithEvents lblCantida As System.Windows.Forms.Label
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
End Class
