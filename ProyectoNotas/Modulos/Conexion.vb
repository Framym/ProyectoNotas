Imports System.Data
Imports System.Data.SqlClient
Module Conexion
    Public cnn As New SqlConnection("Data Source=.;Initial Catalog=Notas;Integrated Security=True")
End Module
