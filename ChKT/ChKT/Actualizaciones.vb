Imports System.Data.SqlClient
Public Class Actualizaciones
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Using conexion As New SqlConnection("server=localhost\SQLEXPRESS; database=Laboratorio; integrated security=true")
            Using comando As New SqlCommand("[dbo].[ActualizarCliente]", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@IdCliente", Integer.Parse(txtId.Text))
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                comando.Parameters.AddWithValue("@Edad", txtEdad.Text)
                comando.Parameters.AddWithValue("@Sexo", txtSexo.Text)
                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    conexion.Close()
                    MessageBox.Show("Ok, el usuario con el id: " & txtId.Text & " se actualizó correctamente")
                Catch ex As Exception

                End Try
            End Using
        End Using
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim query = "SELECT IdCliente, Nombre, Edad, Sexo FROM cliente WHERE IdCliente = @IdCliente"
        Using conexion As New SqlConnection("server=localhost\SQLEXPRESS; database=Laboratorio; integrated security=true")
            Using comando As New SqlCommand(query, conexion)
                comando.Parameters.AddWithValue("@IdCliente", Integer.Parse(txtId.Text))
                Try
                    conexion.Open()
                    Using reader As SqlDataReader = comando.ExecuteReader()
                        If reader.Read() Then
                            txtNombre.Text = reader("Nombre").ToString()
                            txtEdad.Text = reader("Edad").ToString()
                            txtSexo.Text = reader("Sexo").ToString()
                        Else
                            MessageBox.Show("No se encontró ningún cliente con el ID proporcionado.")
                        End If
                    End Using
                Catch ex As SqlException
                    MessageBox.Show("Ocurrió un error al recuperar los datos del cliente: " & ex.Message)
                Finally
                    conexion.Close()
                End Try
            End Using
        End Using
    End Sub

End Class