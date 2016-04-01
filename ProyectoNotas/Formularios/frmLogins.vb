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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Close()
    End Sub

    Private Sub LinkLabel1_MouseHover(sender As Object, e As EventArgs) Handles LinkLabel1.MouseHover
        LinkLabel1.BackColor = Color.Red
        LinkLabel1.LinkColor = Color.LightGray
    End Sub

    Private Sub LinkLabel1_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel1.MouseLeave
        LinkLabel1.BackColor = Color.DimGray
        LinkLabel1.LinkColor = Color.LightGray
    End Sub
End Class