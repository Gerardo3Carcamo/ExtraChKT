Imports System.Data.SqlClient
Public Class Login
    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        conexion = New SqlConnection("server=NITRO-5\SQLEXPRESS; database=Laboratorio; integrated security=true")
        conexion.Open()
        Dim consulta As String = "select * from usuarios where nombre = '" & txtNombreUsuario.Text & "' and Password = '" & txtPassword.Text & "'"
        comando = New SqlCommand(consulta, conexion)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        If lector.HasRows Then
            lector.Read()
            Dim rol As Integer = lector.GetInt32(3)
            If rol = 1 Then
                Administrador.Show()
            ElseIf rol <> 1 Then
                Administrador.Show()
            End If
            Me.Hide()
            Else
                MessageBox.Show("Credenciales incorrectas, intente de nuevo.")
        End If
        conexion.Close()
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Registro.Show()
    End Sub
End Class
