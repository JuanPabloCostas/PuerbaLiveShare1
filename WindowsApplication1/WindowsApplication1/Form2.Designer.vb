<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Consult
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRegresar1 = New System.Windows.Forms.Button()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.ptbBanc2 = New System.Windows.Forms.PictureBox()
        Me.ptbMoney2 = New System.Windows.Forms.PictureBox()
        Me.lblSigno = New System.Windows.Forms.Label()
        CType(Me.ptbBanc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbMoney2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(401, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(8, 8)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnRegresar1
        '
        Me.btnRegresar1.Location = New System.Drawing.Point(44, 423)
        Me.btnRegresar1.Name = "btnRegresar1"
        Me.btnRegresar1.Size = New System.Drawing.Size(136, 65)
        Me.btnRegresar1.TabIndex = 1
        Me.btnRegresar1.Text = "Regresar"
        Me.btnRegresar1.UseVisualStyleBackColor = True
        '
        'txtSaldo
        '
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(302, 242)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(321, 44)
        Me.txtSaldo.TabIndex = 3
        Me.txtSaldo.Text = "$"
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ptbBanc2
        '
        Me.ptbBanc2.Image = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_23_at_5_30_23_PM
        Me.ptbBanc2.Location = New System.Drawing.Point(191, 12)
        Me.ptbBanc2.Name = "ptbBanc2"
        Me.ptbBanc2.Size = New System.Drawing.Size(533, 140)
        Me.ptbBanc2.TabIndex = 5
        Me.ptbBanc2.TabStop = False
        '
        'ptbMoney2
        '
        Me.ptbMoney2.Image = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_23_at_5_30_23_PM__1_
        Me.ptbMoney2.Location = New System.Drawing.Point(12, 12)
        Me.ptbMoney2.Name = "ptbMoney2"
        Me.ptbMoney2.Size = New System.Drawing.Size(137, 140)
        Me.ptbMoney2.TabIndex = 4
        Me.ptbMoney2.TabStop = False
        '
        'lblSigno
        '
        Me.lblSigno.AutoSize = True
        Me.lblSigno.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSigno.Location = New System.Drawing.Point(304, 245)
        Me.lblSigno.Name = "lblSigno"
        Me.lblSigno.Size = New System.Drawing.Size(35, 37)
        Me.lblSigno.TabIndex = 6
        Me.lblSigno.Text = "$"
        '
        'frm_Consult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(894, 568)
        Me.Controls.Add(Me.lblSigno)
        Me.Controls.Add(Me.ptbBanc2)
        Me.Controls.Add(Me.ptbMoney2)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.btnRegresar1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frm_Consult"
        Me.Text = "Consultar Saldo"
        CType(Me.ptbBanc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbMoney2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnRegresar1 As System.Windows.Forms.Button
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents ptbMoney2 As System.Windows.Forms.PictureBox
    Friend WithEvents ptbBanc2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblSigno As System.Windows.Forms.Label
End Class
