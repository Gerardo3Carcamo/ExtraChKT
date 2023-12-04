Imports System.Data.SqlClient
Public Class Login
    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        conexion = New SqlConnection("server=localhost\SQLEXPRESS; database=Laboratorio; integrated security=true")
        conexion.Open()
        Dim consulta As String = "select * from usuarios where nombre = '" & txtNombreUsuario.Text & "' and Password = '" & txtPassword.Text & "'"
        comando = New SqlCommand(consulta, conexion)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        If lector.HasRows Then
            lector.Read()
            Dim rol As Integer = lector.GetInt32(3)
            Dim usuarioID As Integer = lector.GetInt32(0)
            If rol = 1 Then 'Usuario administrador
                Administrador.Show()
            ElseIf rol <> 1 Then 'Usuario empleado
                Administrador.Show()
            End If
            conexion.Close()
            conexion.Open()
            Dim sql As String = "Insert into IngresoSistema values(@Fecha, @UsuarioID)" 'Ingresando fecha y usuario que inicio sesion
            Using command As New SqlCommand(sql, conexion)
                command.Parameters.AddWithValue("@Fecha", Now)
                command.Parameters.AddWithValue("@UsuarioID", usuarioID)
                Try
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
            Me.Hide()
        Else 'No existe el registro en la base de datos
            MessageBox.Show("Credenciales incorrectas, intente de nuevo.")
        End If

    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Registro.Show()
    End Sub
End Class
