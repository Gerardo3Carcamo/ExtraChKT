Public Class Estudio
    Public Property IdEstudio As Integer
    Public Property Nombre As String
    Public Property Precio As Decimal

    ' Sobreescribe el método ToString para que el CheckedListBox muestre el nombre
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
