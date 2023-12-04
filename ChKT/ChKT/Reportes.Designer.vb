<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        Me.dgvDinero = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEstudio = New System.Windows.Forms.Label()
        Me.dgvEstudio = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDinero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEstudio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDinero
        '
        Me.dgvDinero.AllowUserToAddRows = False
        Me.dgvDinero.AllowUserToDeleteRows = False
        Me.dgvDinero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDinero.Location = New System.Drawing.Point(21, 74)
        Me.dgvDinero.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.dgvDinero.Name = "dgvDinero"
        Me.dgvDinero.ReadOnly = True
        Me.dgvDinero.RowTemplate.Height = 24
        Me.dgvDinero.Size = New System.Drawing.Size(355, 296)
        Me.dgvDinero.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dinero obtenido por los clientes"
        '
        'lblEstudio
        '
        Me.lblEstudio.AutoSize = True
        Me.lblEstudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstudio.Location = New System.Drawing.Point(386, 16)
        Me.lblEstudio.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblEstudio.Name = "lblEstudio"
        Me.lblEstudio.Size = New System.Drawing.Size(346, 29)
        Me.lblEstudio.TabIndex = 2
        Me.lblEstudio.Text = "El estudio menos solicitado es:"
        '
        'dgvEstudio
        '
        Me.dgvEstudio.AllowUserToAddRows = False
        Me.dgvEstudio.AllowUserToDeleteRows = False
        Me.dgvEstudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstudio.Location = New System.Drawing.Point(395, 74)
        Me.dgvEstudio.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.dgvEstudio.Name = "dgvEstudio"
        Me.dgvEstudio.ReadOnly = True
        Me.dgvEstudio.RowTemplate.Height = 24
        Me.dgvEstudio.Size = New System.Drawing.Size(337, 296)
        Me.dgvEstudio.TabIndex = 3
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 384)
        Me.Controls.Add(Me.dgvEstudio)
        Me.Controls.Add(Me.lblEstudio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDinero)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        CType(Me.dgvDinero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEstudio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDinero As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEstudio As Label
    Friend WithEvents dgvEstudio As DataGridView
End Class
