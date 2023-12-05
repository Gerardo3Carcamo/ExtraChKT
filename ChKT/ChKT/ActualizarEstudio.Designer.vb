<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizarEstudio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id estudio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Resultado del estudio"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(19, 41)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(358, 34)
        Me.txtId.TabIndex = 2
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(19, 110)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(662, 34)
        Me.txtResultado.TabIndex = 3
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(19, 150)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(662, 60)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Button1"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'ActualizarEstudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 220)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "ActualizarEstudio"
        Me.Text = "ActualizarEstudio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnGuardar As Button
End Class
