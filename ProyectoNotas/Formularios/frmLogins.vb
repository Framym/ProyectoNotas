Public Class frmLogins
    Private Sub PictureAlumno_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PictureAlumno.MouseDoubleClick
        With LoginAlumno
            Me.Hide()
            LoginAlumno.Show()
        End With
    End Sub

    Private Sub PictureEmpleado_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PictureEmpleado.MouseDoubleClick
        With LoginEmpleado
            Me.Hide()
            LoginEmpleado.Show()
        End With
    End Sub
End Class