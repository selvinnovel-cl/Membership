Imports System.ComponentModel

Namespace UserControls

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class DashboardControl
        Inherits System.Windows.Forms.UserControl

        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        Private components As System.ComponentModel.IContainer

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.btnLogout = New System.Windows.Forms.Button()
            Me.tabMain = New System.Windows.Forms.TabControl()
            Me.tpMembers = New System.Windows.Forms.TabPage()
            Me.tpRenewal = New System.Windows.Forms.TabPage()
            Me.tpReports = New System.Windows.Forms.TabPage()
            Me.pnlHeader.SuspendLayout()
            Me.tabMain.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(44, 62, 80)
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Controls.Add(Me.lblUser)
            Me.pnlHeader.Controls.Add(Me.btnLogout)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(1200, 60)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.White
            Me.lblTitle.Location = New System.Drawing.Point(20, 15)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(400, 30)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Membership Management System"
            '
            'lblUser
            '
            Me.lblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 9.75!)
            Me.lblUser.ForeColor = System.Drawing.Color.White
            Me.lblUser.Location = New System.Drawing.Point(850, 20)
            Me.lblUser.Name = "lblUser"
            Me.lblUser.Size = New System.Drawing.Size(230, 20)
            Me.lblUser.TabIndex = 1
            Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnLogout
            '
            Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(231, 76, 60)
            Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnLogout.ForeColor = System.Drawing.Color.White
            Me.btnLogout.Location = New System.Drawing.Point(1090, 15)
            Me.btnLogout.Name = "btnLogout"
            Me.btnLogout.Size = New System.Drawing.Size(90, 30)
            Me.btnLogout.TabIndex = 2
            Me.btnLogout.Text = "Logout"
            Me.btnLogout.UseVisualStyleBackColor = False
            '
            'tabMain
            '
            Me.tabMain.Controls.Add(Me.tpMembers)
            Me.tabMain.Controls.Add(Me.tpRenewal)
            Me.tabMain.Controls.Add(Me.tpReports)
            Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabMain.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.tabMain.Location = New System.Drawing.Point(0, 60)
            Me.tabMain.Name = "tabMain"
            Me.tabMain.SelectedIndex = 0
            Me.tabMain.Size = New System.Drawing.Size(1200, 640)
            Me.tabMain.TabIndex = 1
            '
            'tpMembers
            '
            Me.tpMembers.BackColor = System.Drawing.Color.White
            Me.tpMembers.Location = New System.Drawing.Point(4, 27)
            Me.tpMembers.Name = "tpMembers"
            Me.tpMembers.Padding = New System.Windows.Forms.Padding(3)
            Me.tpMembers.Size = New System.Drawing.Size(1192, 609)
            Me.tpMembers.TabIndex = 0
            Me.tpMembers.Text = "  Members  "
            '
            'tpRenewal
            '
            Me.tpRenewal.BackColor = System.Drawing.Color.White
            Me.tpRenewal.Location = New System.Drawing.Point(4, 27)
            Me.tpRenewal.Name = "tpRenewal"
            Me.tpRenewal.Padding = New System.Windows.Forms.Padding(3)
            Me.tpRenewal.Size = New System.Drawing.Size(1192, 609)
            Me.tpRenewal.TabIndex = 1
            Me.tpRenewal.Text = "  Renewal  "
            '
            'tpReports
            '
            Me.tpReports.BackColor = System.Drawing.Color.White
            Me.tpReports.Location = New System.Drawing.Point(4, 27)
            Me.tpReports.Name = "tpReports"
            Me.tpReports.Padding = New System.Windows.Forms.Padding(3)
            Me.tpReports.Size = New System.Drawing.Size(1192, 609)
            Me.tpReports.TabIndex = 2
            Me.tpReports.Text = "  Reports  "
            '
            'DashboardControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tabMain)
            Me.Controls.Add(Me.pnlHeader)
            Me.Name = "DashboardControl"
            Me.Size = New System.Drawing.Size(1200, 700)
            Me.pnlHeader.ResumeLayout(False)
            Me.tabMain.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

        Friend WithEvents pnlHeader As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents lblUser As System.Windows.Forms.Label
        Friend WithEvents btnLogout As System.Windows.Forms.Button
        Friend WithEvents tabMain As System.Windows.Forms.TabControl
        Friend WithEvents tpMembers As System.Windows.Forms.TabPage
        Friend WithEvents tpRenewal As System.Windows.Forms.TabPage
        Friend WithEvents tpReports As System.Windows.Forms.TabPage

    End Class

End Namespace
