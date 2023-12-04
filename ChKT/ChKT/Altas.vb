Imports System.Data.SqlClient
Public Class Altas
    Private Sub btnRegistrarCliente_Click(sender As Object, e As EventArgs) Handles btnRegistrarCliente.Click
        Using conexion As New SqlConnection("server=localhost\SQLEXPRESS; database=Laboratorio; integrated security=true")
            Using comando As New SqlCommand("[dbo].[IngresarCliente]", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                comando.Parameters.AddWithValue("@Edad", txtEdad.Text)
                comando.Parameters.AddWithValue("@Sexo", txtSexo.Text)
                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    conexion.Close()
                    MessageBox.Show("Ok, el cliente se ingresó correctamente")
                Catch ex As Exception

                End Try
            End Using
        End Using
    End Sub
End Class