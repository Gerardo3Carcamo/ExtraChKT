Imports System.Data.SqlClient
Public Class Registro

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stored As String = "[dbo].[IngresarNuevoUsuario]"
        Using conexion As New SqlConnection("server=localhost\SQLEXPRESS; database=Laboratorio; integrated security=true")
            Using comando As New SqlCommand(stored, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                comando.Parameters.AddWithValue("@Password", txtPassword.Text)
                comando.Parameters.AddWithValue("@Rol", txtRol.Text)
                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    conexion.Close()
                    Dim rol As String
                    If txtRol.Text = "1" Then
                        rol = "Administrador"
                    Else
                        rol = "Usuario"
                    End If
                    MessageBox.Show("Ok, el Usuario: " & txtNombre.Text & " se ingreso correctamente con el rol " & rol)
                Catch ex As Exception

                End Try
            End Using
        End Using
    End Sub
End Class