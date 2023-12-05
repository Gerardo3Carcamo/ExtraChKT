﻿Public Class Administrador

    Public flag As Boolean = False

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

    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AltaDeClientesToolStripMenuItem.Visible = flag
        ReportesToolStripMenuItem.Visible = flag
    End Sub

    Private Sub ActualizarEstudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarEstudioToolStripMenuItem.Click
        ActualizarEstudio.Show()
    End Sub
End Class