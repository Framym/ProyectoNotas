Imports System.Data.SqlClient
Module Bitacora
    Public ID_Bitacora As Integer
    Public Hora_Bitacora, TareaBitacora As String
    Public Fecha_Bitacora As Date


    Sub GenerarIdBitacora()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        cnn.Open()

        Try
            Dim buscar As New SqlCommand("sp_IdBitacora", cnn)
            buscar.CommandType = CommandType.StoredProcedure

            Dim DR As SqlDataReader
            DR = buscar.ExecuteReader

            If DR.Read = True Then
                If DR("Id") Is DBNull.Value Then
                    ID_Bitacora = 1
                Else
                    ID_Bitacora = DR("Id")
                End If
            End If

            cnn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Sub GuardarBitacora()

        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        Try
            Call GenerarIdBitacora()

            Fecha_Bitacora = Date.Now
            Hora_Bitacora = TimeOfDay

            cnn.Open()

            Using _CMD As New SqlCommand()
                With _CMD

                    .CommandText = "sp_NuevoBitacora"
                    .CommandType = CommandType.StoredProcedure

                    .Parameters.Add("@IdBitacora", SqlDbType.Int).Value = ID_Bitacora
                    .Parameters.Add("@FechaBitacora", SqlDbType.Date).Value = CDate(Fecha_Bitacora)
                    .Parameters.Add("@HoraBitacora", SqlDbType.NVarChar, 15).Value = Hora_Bitacora
                    .Parameters.Add("@Actividad", SqlDbType.NVarChar, 300).Value = TareaBitacora
                    .Parameters.Add("@IdUsuarioEmp", SqlDbType.Int).Value = Empleado

                    .Connection = cnn
                    .ExecuteNonQuery()

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Module
