Imports System.ComponentModel

Namespace UserControls

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class LoginControl
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
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
            Me.pnlLogin = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblUsername = New System.Windows.Forms.Label()
            Me.txtUsername = New System.Windows.Forms.TextBox()
            Me.lblPassword = New System.Windows.Forms.Label()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.btnLogin = New System.Windows.Forms.Button()
            Me.lblMessage = New System.Windows.Forms.Label()
            Me.pnlLogin.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlLogin
            '
            Me.pnlLogin.BackColor = System.Drawing.Color.White
            Me.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlLogin.Controls.Add(Me.lblTitle)
            Me.pnlLogin.Controls.Add(Me.lblUsername)
            Me.pnlLogin.Controls.Add(Me.txtUsername)
            Me.pnlLogin.Controls.Add(Me.lblPassword)
            Me.pnlLogin.Controls.Add(Me.txtPassword)
            Me.pnlLogin.Controls.Add(Me.btnLogin)
            Me.pnlLogin.Controls.Add(Me.lblMessage)
            Me.pnlLogin.Location = New System.Drawing.Point(400, 180)
            Me.pnlLogin.Name = "pnlLogin"
            Me.pnlLogin.Size = New System.Drawing.Size(400, 320)
            Me.pnlLogin.TabIndex = 0
            Me.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None
            '
            'lblTitle
            '
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(45, 62, 80)
            Me.lblTitle.Location = New System.Drawing.Point(60, 30)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(280, 40)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Member Portal Login"
            Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblUsername
            '
            Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.lblUsername.Location = New System.Drawing.Point(40, 90)
            Me.lblUsername.Name = "lblUsername"
            Me.lblUsername.Size = New System.Drawing.Size(120, 20)
            Me.lblUsername.TabIndex = 1
            Me.lblUsername.Text = "Username"
            '
            'txtUsername
            '
            Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtUsername.Location = New System.Drawing.Point(40, 112)
            Me.txtUsername.Name = "txtUsername"
            Me.txtUsername.Size = New System.Drawing.Size(316, 25)
            Me.txtUsername.TabIndex = 2
            '
            'lblPassword
            '
            Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.lblPassword.Location = New System.Drawing.Point(40, 150)
            Me.lblPassword.Name = "lblPassword"
            Me.lblPassword.Size = New System.Drawing.Size(120, 20)
            Me.lblPassword.TabIndex = 3
            Me.lblPassword.Text = "Password"
            '
            'txtPassword
            '
            Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtPassword.Location = New System.Drawing.Point(40, 172)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
            Me.txtPassword.Size = New System.Drawing.Size(316, 25)
            Me.txtPassword.TabIndex = 4
            '
            'btnLogin
            '
            Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(52, 152, 219)
            Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.btnLogin.ForeColor = System.Drawing.Color.White
            Me.btnLogin.Location = New System.Drawing.Point(40, 220)
            Me.btnLogin.Name = "btnLogin"
            Me.btnLogin.Size = New System.Drawing.Size(316, 40)
            Me.btnLogin.TabIndex = 5
            Me.btnLogin.Text = "LOGIN"
            Me.btnLogin.UseVisualStyleBackColor = False
            '
            'lblMessage
            '
            Me.lblMessage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.lblMessage.ForeColor = System.Drawing.Color.Red
            Me.lblMessage.Location = New System.Drawing.Point(40, 270)
            Me.lblMessage.Name = "lblMessage"
            Me.lblMessage.Size = New System.Drawing.Size(316, 30)
            Me.lblMessage.TabIndex = 6
            Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LoginControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(236, 240, 241)
            Me.Controls.Add(Me.pnlLogin)
            Me.Name = "LoginControl"
            Me.Size = New System.Drawing.Size(1200, 700)
            Me.pnlLogin.ResumeLayout(False)
            Me.pnlLogin.PerformLayout()
            Me.ResumeLayout(False)
        End Sub

        Friend WithEvents pnlLogin As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents lblUsername As System.Windows.Forms.Label
        Friend WithEvents txtUsername As System.Windows.Forms.TextBox
        Friend WithEvents lblPassword As System.Windows.Forms.Label
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents btnLogin As System.Windows.Forms.Button
        Friend WithEvents lblMessage As System.Windows.Forms.Label

    End Class

End Namespace
