Imports System.Data.SqlClient
Public Class ActualizarEstudio
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim storedProcedure As String = "[dbo].[ActualizarEstudio]"
        Using conexion As New SqlConnection("server=localhost\SQLEXPRESS; database=Laboratorio; integrated security=true")
            Using comando As New SqlCommand(storedProcedure, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@Id", Integer.Parse(txtId.Text))
                comando.Parameters.AddWithValue("@Resultado", txtResultado.Text)
                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Estudio actualizado")
                Catch ex As Exception
                Finally
                    conexion.Close()
                End Try
            End Using
        End Using
    End Sub
End Class