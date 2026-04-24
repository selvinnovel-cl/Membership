Imports MembershipApp.UserControls

Public Class MainForm

    Private loginControl As LoginControl
    Private dashboardControl As DashboardControl

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Membership Management System"
        Me.WindowState = FormWindowState.Maximized
        ShowLogin()
    End Sub

    Private Sub ShowLogin()
        MainPanel.Controls.Clear()
        loginControl = New LoginControl()
        loginControl.Dock = DockStyle.Fill
        AddHandler loginControl.LoginSucceeded, AddressOf OnLoginSucceeded
        MainPanel.Controls.Add(loginControl)
    End Sub

    Private Sub OnLoginSucceeded(sender As Object, e As EventArgs)
        ShowDashboard()
    End Sub

    Private Sub ShowDashboard()
        MainPanel.Controls.Clear()
        dashboardControl = New DashboardControl()
        dashboardControl.Dock = DockStyle.Fill
        AddHandler dashboardControl.LogoutRequested, AddressOf OnLogoutRequested
        MainPanel.Controls.Add(dashboardControl)
    End Sub

    Private Sub OnLogoutRequested(sender As Object, e As EventArgs)
        Data.SessionManager.Clear()
        ShowLogin()
    End Sub

End Class
