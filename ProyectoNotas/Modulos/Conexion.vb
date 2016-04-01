Imports System.Data
Imports System.Data.SqlClient

Public Class Conexion
    Public cnn As New SqlConnection("Data Source=.;Initial Catalog=Notas;Integrated Security=True")
End Class
