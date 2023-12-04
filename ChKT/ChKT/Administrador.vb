Public Class Administrador
    Private Sub AltasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltasToolStripMenuItem.Click
        Altas.Show()
    End Sub

    Private Sub BajasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajasToolStripMenuItem.Click
        Bajas.Show()
    End Sub

    Private Sub ActualizacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizacionesToolStripMenuItem.Click
        Actualizaciones.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        EstudioNuevo.Show()
    End Sub

    Private Sub ConsultasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem1.Click
        Consultas.Show()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        Reportes.Show()
    End Sub
End Class