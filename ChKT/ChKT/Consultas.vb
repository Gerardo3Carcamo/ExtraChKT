Imports System.Data.SqlClient
Public Class Consultas
    Dim adapterUsuarios As SqlDataAdapter

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = "server=localhost\SQLEXPRESS; database=Laboratorio; integrated security=true"
        Dim query As String = "SELECT cre.FechaRealiza, cre.FechaEntrega, c.Nombre AS ClienteNombre, e.Nombre AS EstudioNombre, e.Precio " &
                              "FROM ClienteRealizaEstudio AS cre " &
                              "INNER JOIN cliente AS c ON cre.IdCliente = c.IdCliente " &
                              "INNER JOIN Estudio AS e ON cre.IdEstudio = e.IdEstudio where cre.IdCliente = " & Integer.Parse(cboUsuarios.SelectedValue)

        Using conexion As New SqlConnection(connectionString)
            Try
                conexion.Open()

                Using adapter As New SqlDataAdapter(query, conexion)
                    Dim table As New DataTable()

                    adapter.Fill(table)

                    DataGridView1.DataSource = table

                    With DataGridView1
                        .Columns("FechaRealiza").HeaderText = "Fecha Realización"
                        .Columns("FechaEntrega").HeaderText = "Fecha de Entrega"
                        .Columns("ClienteNombre").HeaderText = "Nombre del Cliente"
                        .Columns("EstudioNombre").HeaderText = "Nombre del Estudio"
                        .Columns("Precio").HeaderText = "Precio"
                    End With
                End Using
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error al recuperar los datos: " & ex.Message)
            Finally
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
            End Try
        End Using
    End Sub

    Private Sub Consultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion = "server=localhost\SQLEXPRESS; database=Laboratorio; integrated security=true"
        Dim queryUsuarios As String = "Select * from cliente"
        adapterUsuarios = New System.Data.SqlClient.SqlDataAdapter(queryUsuarios, conexion)
        Dim dataUsuario = New DataSet
        adapterUsuarios.Fill(dataUsuario)
        cboUsuarios.DataSource = dataUsuario.Tables(0)
        cboUsuarios.DisplayMember = "Nombre"
        cboUsuarios.ValueMember = "IdCliente"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionString As String = "server=localhost\SQLEXPRESS; database=Laboratorio; integrated security=true"
        Dim query As String = "SELECT COUNT(cre.IdEstudio) AS Total, e.Nombre " &
                              "FROM ClienteRealizaEstudio AS cre " &
                              "INNER JOIN Estudio AS e ON cre.IdEstudio = e.IdEstudio " &
                              "GROUP BY cre.IdEstudio, e.Nombre"
        Using conexion As New SqlConnection(connectionString)
            Try
                conexion.Open()
                Using adapter As New SqlDataAdapter(query, conexion)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    dtgEstdiosMasRealizados.DataSource = table
                    With dtgEstdiosMasRealizados
                        .Columns("Total").HeaderText = "Total Realizados"
                        .Columns("Nombre").HeaderText = "Nombre del Estudio"
                    End With
                End Using
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error al recuperar los datos: " & ex.Message)
            Finally
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
            End Try
        End Using
    End Sub
End Class