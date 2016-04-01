Imports System.Data
Imports System.Data.SqlClient
Public Class LoginAlumno
    Private Sub LoginAlumno_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmLogins.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Close()
        frmLogins.Show()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        LoginAlumno()
    End Sub

    Private Sub LoginAlumno()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Dim i As Integer

        Try
            cnn.Open()

            Dim buscar As New SqlCommand("sp_LoginAlumno", cnn)
            buscar.CommandType = CommandType.StoredProcedure

            buscar.Parameters.Add("@UserName", SqlDbType.NVarChar, 25).Value = Me.txtUsername.Text
            buscar.Parameters.Add("@Password", SqlDbType.NVarChar, 25).Value = Me.txtPassword.Text

            Dim DR As SqlDataReader
            DR = buscar.ExecuteReader

            If DR.Read = True Then
                i = DR("USERS")
            End If

            If i = 0 Then
                MessageBox.Show("Username/Contraseña Incorrectos o el usuario esta deshabilitado", "System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtPassword.Text = Nothing
                Me.txtUsername.Text = Nothing
                Me.txtUsername.Focus()
            ElseIf i = 1 Then
                Me.Hide()
                'Call Nivel_Usuario()
                Call NombreUsuarioAlumno()
                'Call ID_Usuario()
                'Call UsoDelUsuario()

                If UsoUsuario > 0 Then
                    FrmPrincipal.lblUsuario.Text = "Usuario: " & NombreDeUsuario
                    'FrmPrincipal.MenuStrip.Enabled = True

                    TareaBitacora = "El Usuario " & NombreDeUsuario & " Ingreso al sistema"
                    Call GuardarBitacora()

                ElseIf UsoUsuario <= 0 Then
                    Cpass = 1

                    TareaBitacora = "El Usuario " & NombreDeUsuario & " Ingreso por primera vez al sistema"
                    Call GuardarBitacora()

                    MessageBox.Show("Bienvenido a CR-System " & NombreDeUsuario & ". En su primer ingreso al Sistema tiene que cambiar su password", "CR-System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

                'If NivelUsuario = True Then
                'Call UsuarioAdministrador()
                'End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "CR_System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NombreUsuarioAlumno()
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If

        Try
            cnn.Open()

            Dim buscar As New SqlCommand("sp_NombreUsuarioAlumno", cnn)
            buscar.CommandType = CommandType.StoredProcedure

            buscar.Parameters.Add("@UserName", SqlDbType.NVarChar, 25).Value = Me.txtUsername.Text

            Dim DR As SqlDataReader
            DR = buscar.ExecuteReader

            If DR.Read = True Then
                NombreDeUsuario = DR("Username")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub LoginAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class