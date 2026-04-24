Imports MembershipApp.Data

Namespace UserControls

    Public Class DashboardControl

        Public Event LogoutRequested As EventHandler

        Private membersControl As MembersControl
        Private renewalControl As RenewalControl
        Private reportsControl As ReportsControl

        Private Sub DashboardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            lblUser.Text = $"Welcome, {SessionManager.UserName}  ({SessionManager.Role})"
            LoadTabs()
        End Sub

        Private Sub LoadTabs()
            ' Members tab
            membersControl = New MembersControl() With {.Dock = DockStyle.Fill}
            tpMembers.Controls.Add(membersControl)

            ' Renewal tab
            renewalControl = New RenewalControl() With {.Dock = DockStyle.Fill}
            tpRenewal.Controls.Add(renewalControl)

            ' Reports tab
            reportsControl = New ReportsControl() With {.Dock = DockStyle.Fill}
            tpReports.Controls.Add(reportsControl)
        End Sub

        Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
            RaiseEvent LogoutRequested(Me, EventArgs.Empty)
        End Sub

    End Class

End Namespace
