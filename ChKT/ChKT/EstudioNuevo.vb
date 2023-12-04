Imports System.Data.SqlClient
Public Class EstudioNuevo
    Dim adapterEstudios As SqlDataAdapter
    Dim adapterUsuarios As SqlDataAdapter
    Private Sub EstudioNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion = "server=localhost\SQLEXPRESS; database=Laboratorio; integrated security=true"
        Dim queryUsuarios As String = "Select * from cliente"
        adapterUsuarios = New System.Data.SqlClient.SqlDataAdapter(queryUsuarios, conexion)
        Dim dataUsuario = New DataSet
        adapterUsuarios.Fill(dataUsuario)
        cboUsuarios.DataSource = dataUsuario.Tables(0)
        cboUsuarios.DisplayMember = "Nombre"
        cboUsuarios.ValueMember = "IdCliente"

        Dim queryEstudios = "Select * from estudio"
        adapterEstudios = New System.Data.SqlClient.SqlDataAdapter(queryEstudios, conexion)
        Dim dataEstudios = New DataSet
        adapterEstudios.Fill(dataEstudios)
        CheckedListBox1.Items.Clear()
        For Each row As DataRow In dataEstudios.Tables(0).Rows
            Dim estudio As New Estudio With {
                .IdEstudio = Convert.ToInt32(row("IdEstudio")),
                .Nombre = row("Nombre").ToString(),
                .Precio = Convert.ToDecimal(row("Precio"))
            }
            CheckedListBox1.Items.Add(estudio)
        Next
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub cboUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUsuarios.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sumaPrecios As Decimal = 0
        Dim descuento As Decimal = 0

        ' Sumar los precios de los elementos seleccionados
        For Each itemChecked In CheckedListBox1.CheckedItems
            Dim estudio As Estudio = DirectCast(itemChecked, Estudio)
            sumaPrecios += estudio.Precio
        Next

        ' Determinar el descuento
        Select Case CheckedListBox1.CheckedItems.Count
            Case 2
                descuento = 0.05 ' 5% de descuento
            Case >= 3
                descuento = 0.1 ' 10% de descuento
        End Select

        ' Aplicar el descuento
        Dim totalConDescuento As Decimal = sumaPrecios - (sumaPrecios * descuento)
        lblPrecio.Text = "$" & totalConDescuento
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each itemChecked In CheckedListBox1.CheckedItems
            Dim stored = "[dbo].[IngresarAnalisis]"
            Dim Estudio As Estudio = DirectCast(itemChecked, Estudio)
            Dim id = Estudio.IdEstudio
            Using conexion As New SqlConnection("server=localhost\SQLEXPRESS; database=Laboratorio; integrated security=true")
                Using comando As New SqlCommand(stored, conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@FechaRealiza", Now)
                    comando.Parameters.AddWithValue("@FechaEntrega", DateTimePicker1.Value)
                    comando.Parameters.AddWithValue("@IdCliente", Convert.ToInt32(cboUsuarios.SelectedValue))
                    comando.Parameters.AddWithValue("@IdEstudio", id)
                    Try
                        conexion.Open()
                        comando.ExecuteNonQuery()
                        conexion.Close()
                        MessageBox.Show("Ok, el estudio: " & Estudio.Nombre & " se ingreso correctamente")
                    Catch ex As Exception

                    End Try
                End Using
            End Using
        Next
    End Sub
End Class