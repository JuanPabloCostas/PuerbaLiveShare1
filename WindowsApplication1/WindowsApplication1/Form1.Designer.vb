<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Menu
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
        Me.btnConsult = New System.Windows.Forms.Button()
        Me.btnTransf = New System.Windows.Forms.Button()
        Me.ptbBanc1 = New System.Windows.Forms.PictureBox()
        Me.ptbMoney1 = New System.Windows.Forms.PictureBox()
        CType(Me.ptbBanc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbMoney1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConsult
        '
        Me.btnConsult.Location = New System.Drawing.Point(12, 195)
        Me.btnConsult.Name = "btnConsult"
        Me.btnConsult.Size = New System.Drawing.Size(136, 65)
        Me.btnConsult.TabIndex = 0
        Me.btnConsult.Text = "Consultar Saldo "
        Me.btnConsult.UseVisualStyleBackColor = True
        '
        'btnTransf
        '
        Me.btnTransf.Location = New System.Drawing.Point(12, 387)
        Me.btnTransf.Name = "btnTransf"
        Me.btnTransf.Size = New System.Drawing.Size(136, 65)
        Me.btnTransf.TabIndex = 1
        Me.btnTransf.Text = "Transferir Dinero"
        Me.btnTransf.UseVisualStyleBackColor = True
        '
        'ptbBanc1
        '
        Me.ptbBanc1.Image = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_23_at_5_30_23_PM
        Me.ptbBanc1.Location = New System.Drawing.Point(178, 21)
        Me.ptbBanc1.Name = "ptbBanc1"
        Me.ptbBanc1.Size = New System.Drawing.Size(533, 140)
        Me.ptbBanc1.TabIndex = 7
        Me.ptbBanc1.TabStop = False
        '
        'ptbMoney1
        '
        Me.ptbMoney1.Image = Global.WindowsApplication1.My.Resources.Resources.WhatsApp_Image_2022_04_23_at_5_30_23_PM__1_
        Me.ptbMoney1.Location = New System.Drawing.Point(18, 21)
        Me.ptbMoney1.Name = "ptbMoney1"
        Me.ptbMoney1.Size = New System.Drawing.Size(137, 140)
        Me.ptbMoney1.TabIndex = 6
        Me.ptbMoney1.TabStop = False
        '
        'frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(894, 568)
        Me.Controls.Add(Me.ptbBanc1)
        Me.Controls.Add(Me.ptbMoney1)
        Me.Controls.Add(Me.btnTransf)
        Me.Controls.Add(Me.btnConsult)
        Me.Name = "frm_Menu"
        Me.Text = "Menu Principal "
        CType(Me.ptbBanc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbMoney1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConsult As System.Windows.Forms.Button
    Friend WithEvents btnTransf As System.Windows.Forms.Button
    Friend WithEvents ptbBanc1 As System.Windows.Forms.PictureBox
    Friend WithEvents ptbMoney1 As System.Windows.Forms.PictureBox

End Class
