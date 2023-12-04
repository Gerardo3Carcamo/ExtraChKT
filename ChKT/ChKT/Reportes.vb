Imports System.Data.SqlClient
Public Class Reportes
    Private Sub CargarDineroDevengadoPorCliente()
        Dim query As String = "SELECT c.IdCliente, c.Nombre AS NombreCliente, SUM(e.Precio) AS TotalDevengado " &
                          "FROM Cliente AS c " &
                          "INNER JOIN ClienteRealizaEstudio AS cre ON c.IdCliente = cre.IdCliente " &
                          "INNER JOIN Estudio AS e ON cre.IdEstudio = e.IdEstudio " &
                          "WHERE cre.FechaRealiza <= GETDATE() " &
                          "GROUP BY c.IdCliente, c.Nombre"

        Using conexion As New SqlConnection("server=localhost\SQLEXPRESS; database=Laboratorio; integrated security=true")
            Using adapter As New SqlDataAdapter(query, conexion)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvDinero.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub CargarEstudioMenosSolicitado()
        Dim query As String = "SELECT TOP 1 e.Nombre AS NombreEstudio, COUNT(*) AS NumeroDeVecesSolicitado " &
                          "FROM Estudio AS e " &
                          "INNER JOIN ClienteRealizaEstudio AS cre ON e.IdEstudio = cre.IdEstudio " &
                          "GROUP BY e.Nombre " &
                          "ORDER BY NumeroDeVecesSolicitado ASC"

        Using conexion As New SqlConnection("server=localhost\SQLEXPRESS; database=Laboratorio; integrated security=true")
            Using adapter As New SqlDataAdapter(query, conexion)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvEstudio.DataSource = table
            End Using
        End Using
    End Sub


    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDineroDevengadoPorCliente()
        CargarEstudioMenosSolicitado()
    End Sub
End Class