Imports System.Data.SqlClient
Public Class Bajas

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using conexion As New SqlConnection("server=localhost\SQLEXPRESS; database=Laboratorio; integrated security=true")
            Using comando As New SqlCommand("[dbo].[EliminarCliente]", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@IdCliente", txtId.Text)
                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    conexion.Close()
                    MessageBox.Show("Ok, el cliente se elimino correctamente")
                Catch ex As Exception

                End Try
            End Using
        End Using
    End Sub
End Class