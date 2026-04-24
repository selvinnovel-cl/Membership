Imports System.Data
Imports System.Data.SqlClient
Imports MembershipApp.Data

Namespace UserControls

    Public Class LoginControl

        Public Event LoginSucceeded As EventHandler

        Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
            Dim username As String = txtUsername.Text.Trim()
            Dim password As String = txtPassword.Text

            If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
                lblMessage.Text = "Please enter username and password."
                Return
            End If

            Try
                Dim dt As DataTable = DBHelper.ExecuteDataTable(
                    "sp_AuthenticateUser",
                    DBHelper.NewParam("@Username", SqlDbType.NVarChar, username),
                    DBHelper.NewParam("@Password", SqlDbType.NVarChar, password))

                If dt.Rows.Count > 0 Then
                    SessionManager.UserId = Convert.ToInt32(dt.Rows(0)("UserId"))
                    SessionManager.UserName = dt.Rows(0)("Username").ToString()
                    SessionManager.Role = dt.Rows(0)("Role").ToString()
                    SessionManager.IsAuthenticated = True
                    RaiseEvent LoginSucceeded(Me, EventArgs.Empty)
                Else
                    lblMessage.Text = "Invalid username or password."
                End If
            Catch ex As Exception
                lblMessage.Text = "Login error: " & ex.Message
            End Try
        End Sub

        Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
            If e.KeyCode = Keys.Enter Then
                btnLogin.PerformClick()
                e.SuppressKeyPress = True
            End If
        End Sub

    End Class

End Namespace
