Imports System.ComponentModel

Namespace UserControls

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class MembersControl
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
            '--- Main Panel ---
            Me.mainPanel = New System.Windows.Forms.Panel()
            Me.pnlFilters = New System.Windows.Forms.Panel()
            Me.lblState = New System.Windows.Forms.Label()
            Me.cmbState = New System.Windows.Forms.ComboBox()
            Me.lblMemberType = New System.Windows.Forms.Label()
            Me.cmbMemberType = New System.Windows.Forms.ComboBox()
            Me.lblSearch = New System.Windows.Forms.Label()
            Me.txtSearch = New System.Windows.Forms.TextBox()
            Me.btnSearch = New System.Windows.Forms.Button()
            Me.btnRefresh = New System.Windows.Forms.Button()
            Me.btnAddMember = New System.Windows.Forms.Button()
            Me.dgvMembers = New System.Windows.Forms.DataGridView()

            '--- Add Panel ---
            Me.addMemberPanel = New System.Windows.Forms.Panel()
            Me.pnlAddHeader = New System.Windows.Forms.Panel()
            Me.lblAddTitle = New System.Windows.Forms.Label()
            Me.btnBack = New System.Windows.Forms.Button()
            Me.pnlAddForm = New System.Windows.Forms.Panel()
            Me.lblAddState = New System.Windows.Forms.Label()
            Me.cmbAddState = New System.Windows.Forms.ComboBox()
            Me.lblAddMemberType = New System.Windows.Forms.Label()
            Me.cmbAddMemberType = New System.Windows.Forms.ComboBox()
            Me.lblMemberNumber = New System.Windows.Forms.Label()
            Me.txtMemberNumber = New System.Windows.Forms.TextBox()
            Me.lblApplicationNo = New System.Windows.Forms.Label()
            Me.txtApplicationNo = New System.Windows.Forms.TextBox()
            Me.lblMemberName = New System.Windows.Forms.Label()
            Me.txtMemberName = New System.Windows.Forms.TextBox()
            Me.lblAddress1 = New System.Windows.Forms.Label()
            Me.txtAddress1 = New System.Windows.Forms.TextBox()
            Me.lblAddress2 = New System.Windows.Forms.Label()
            Me.txtAddress2 = New System.Windows.Forms.TextBox()
            Me.lblAddress3 = New System.Windows.Forms.Label()
            Me.txtAddress3 = New System.Windows.Forms.TextBox()
            Me.lblPincode = New System.Windows.Forms.Label()
            Me.txtPincode = New System.Windows.Forms.TextBox()
            Me.lblMobile = New System.Windows.Forms.Label()
            Me.txtMobile = New System.Windows.Forms.TextBox()
            Me.lblAadhar = New System.Windows.Forms.Label()
            Me.txtAadhar = New System.Windows.Forms.TextBox()
            Me.lblDOB = New System.Windows.Forms.Label()
            Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
            Me.lblGender = New System.Windows.Forms.Label()
            Me.cmbGender = New System.Windows.Forms.ComboBox()
            Me.lblProfession = New System.Windows.Forms.Label()
            Me.txtProfession = New System.Windows.Forms.TextBox()
            Me.lblRegisteredThrough = New System.Windows.Forms.Label()
            Me.cmbRegisteredThrough = New System.Windows.Forms.ComboBox()
            Me.lblRegisteredOn = New System.Windows.Forms.Label()
            Me.dtpRegisteredOn = New System.Windows.Forms.DateTimePicker()
            Me.btnSaveMember = New System.Windows.Forms.Button()
            Me.btnCancelMember = New System.Windows.Forms.Button()

            Me.mainPanel.SuspendLayout()
            Me.pnlFilters.SuspendLayout()
            CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.addMemberPanel.SuspendLayout()
            Me.pnlAddHeader.SuspendLayout()
            Me.pnlAddForm.SuspendLayout()
            Me.SuspendLayout()

            '============ MAIN PANEL ============
            Me.mainPanel.BackColor = System.Drawing.Color.White
            Me.mainPanel.Controls.Add(Me.dgvMembers)
            Me.mainPanel.Controls.Add(Me.pnlFilters)
            Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mainPanel.Name = "mainPanel"

            'pnlFilters
            Me.pnlFilters.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
            Me.pnlFilters.Controls.Add(Me.lblState)
            Me.pnlFilters.Controls.Add(Me.cmbState)
            Me.pnlFilters.Controls.Add(Me.lblMemberType)
            Me.pnlFilters.Controls.Add(Me.cmbMemberType)
            Me.pnlFilters.Controls.Add(Me.lblSearch)
            Me.pnlFilters.Controls.Add(Me.txtSearch)
            Me.pnlFilters.Controls.Add(Me.btnSearch)
            Me.pnlFilters.Controls.Add(Me.btnRefresh)
            Me.pnlFilters.Controls.Add(Me.btnAddMember)
            Me.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlFilters.Height = 80
            Me.pnlFilters.Name = "pnlFilters"

            Me.lblState.Location = New System.Drawing.Point(15, 15)
            Me.lblState.Size = New System.Drawing.Size(100, 20)
            Me.lblState.Text = "State:"
            Me.lblState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)

            Me.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbState.Location = New System.Drawing.Point(15, 38)
            Me.cmbState.Name = "cmbState"
            Me.cmbState.Size = New System.Drawing.Size(180, 25)
            Me.cmbState.Font = New System.Drawing.Font("Segoe UI", 9.0!)

            Me.lblMemberType.Location = New System.Drawing.Point(210, 15)
            Me.lblMemberType.Size = New System.Drawing.Size(100, 20)
            Me.lblMemberType.Text = "Member Type:"
            Me.lblMemberType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)

            Me.cmbMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbMemberType.Location = New System.Drawing.Point(210, 38)
            Me.cmbMemberType.Name = "cmbMemberType"
            Me.cmbMemberType.Size = New System.Drawing.Size(180, 25)
            Me.cmbMemberType.Font = New System.Drawing.Font("Segoe UI", 9.0!)

            Me.lblSearch.Location = New System.Drawing.Point(405, 15)
            Me.lblSearch.Size = New System.Drawing.Size(100, 20)
            Me.lblSearch.Text = "Search:"
            Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)

            Me.txtSearch.Location = New System.Drawing.Point(405, 38)
            Me.txtSearch.Name = "txtSearch"
            Me.txtSearch.Size = New System.Drawing.Size(220, 25)
            Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)

            Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(52, 152, 219)
            Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSearch.ForeColor = System.Drawing.Color.White
            Me.btnSearch.Location = New System.Drawing.Point(635, 37)
            Me.btnSearch.Name = "btnSearch"
            Me.btnSearch.Size = New System.Drawing.Size(80, 28)
            Me.btnSearch.Text = "Search"
            Me.btnSearch.UseVisualStyleBackColor = False

            Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(149, 165, 166)
            Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRefresh.ForeColor = System.Drawing.Color.White
            Me.btnRefresh.Location = New System.Drawing.Point(725, 37)
            Me.btnRefresh.Name = "btnRefresh"
            Me.btnRefresh.Size = New System.Drawing.Size(80, 28)
            Me.btnRefresh.Text = "Refresh"
            Me.btnRefresh.UseVisualStyleBackColor = False

            Me.btnAddMember.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAddMember.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
            Me.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAddMember.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnAddMember.ForeColor = System.Drawing.Color.White
            Me.btnAddMember.Location = New System.Drawing.Point(1050, 37)
            Me.btnAddMember.Name = "btnAddMember"
            Me.btnAddMember.Size = New System.Drawing.Size(130, 28)
            Me.btnAddMember.Text = "+ Add Member"
            Me.btnAddMember.UseVisualStyleBackColor = False

            'dgvMembers
            Me.dgvMembers.AllowUserToAddRows = False
            Me.dgvMembers.AllowUserToDeleteRows = False
            Me.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
            Me.dgvMembers.BackgroundColor = System.Drawing.Color.White
            Me.dgvMembers.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvMembers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94)
            Me.dgvMembers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
            Me.dgvMembers.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.dgvMembers.ColumnHeadersHeight = 35
            Me.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvMembers.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvMembers.EnableHeadersVisualStyles = False
            Me.dgvMembers.Location = New System.Drawing.Point(0, 80)
            Me.dgvMembers.MultiSelect = False
            Me.dgvMembers.Name = "dgvMembers"
            Me.dgvMembers.ReadOnly = True
            Me.dgvMembers.RowHeadersVisible = False
            Me.dgvMembers.RowTemplate.Height = 28
            Me.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect

            '============ ADD MEMBER PANEL ============
            Me.addMemberPanel.BackColor = System.Drawing.Color.White
            Me.addMemberPanel.Controls.Add(Me.pnlAddForm)
            Me.addMemberPanel.Controls.Add(Me.pnlAddHeader)
            Me.addMemberPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.addMemberPanel.Name = "addMemberPanel"
            Me.addMemberPanel.Visible = False

            'pnlAddHeader
            Me.pnlAddHeader.BackColor = System.Drawing.Color.FromArgb(52, 73, 94)
            Me.pnlAddHeader.Controls.Add(Me.lblAddTitle)
            Me.pnlAddHeader.Controls.Add(Me.btnBack)
            Me.pnlAddHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlAddHeader.Height = 50

            Me.lblAddTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblAddTitle.ForeColor = System.Drawing.Color.White
            Me.lblAddTitle.Location = New System.Drawing.Point(75, 13)
            Me.lblAddTitle.Size = New System.Drawing.Size(400, 25)
            Me.lblAddTitle.Text = "Add New Member"

            Me.btnBack.BackColor = System.Drawing.Color.FromArgb(149, 165, 166)
            Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBack.ForeColor = System.Drawing.Color.White
            Me.btnBack.Location = New System.Drawing.Point(10, 12)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New System.Drawing.Size(60, 28)
            Me.btnBack.Text = "← Back"
            Me.btnBack.UseVisualStyleBackColor = False

            'pnlAddForm
            Me.pnlAddForm.AutoScroll = True
            Me.pnlAddForm.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlAddForm.Padding = New System.Windows.Forms.Padding(30)

            '--- form fields: two-column layout ---
            Dim col1X As Integer = 30
            Dim col2X As Integer = 450
            Dim labelW As Integer = 160
            Dim inputW As Integer = 240
            Dim rowH As Integer = 50
            Dim y As Integer = 20

            AddLabelAndCtrl(Me.lblAddState, "State *", col1X, y, Me.cmbAddState, col1X + labelW, y, inputW)
            AddLabelAndCtrl(Me.lblAddMemberType, "Member Type *", col2X, y, Me.cmbAddMemberType, col2X + labelW, y, inputW)
            y = y + rowH

            AddLabelAndCtrl(Me.lblMemberNumber, "Member Number", col1X, y, Me.txtMemberNumber, col1X + labelW, y, inputW)
            AddLabelAndCtrl(Me.lblApplicationNo, "Application No", col2X, y, Me.txtApplicationNo, col2X + labelW, y, inputW)
            y = y + rowH

            AddLabelAndCtrl(Me.lblMemberName, "Member Name *", col1X, y, Me.txtMemberName, col1X + labelW, y, inputW)
            AddLabelAndCtrl(Me.lblMobile, "Mobile No", col2X, y, Me.txtMobile, col2X + labelW, y, inputW)
            y = y + rowH

            AddLabelAndCtrl(Me.lblAddress1, "Address Line 1", col1X, y, Me.txtAddress1, col1X + labelW, y, inputW)
            AddLabelAndCtrl(Me.lblAadhar, "Aadhar Number", col2X, y, Me.txtAadhar, col2X + labelW, y, inputW)
            y = y + rowH

            AddLabelAndCtrl(Me.lblAddress2, "Address Line 2", col1X, y, Me.txtAddress2, col1X + labelW, y, inputW)
            AddLabelAndCtrl(Me.lblDOB, "DOB", col2X, y, Me.dtpDOB, col2X + labelW, y, inputW)
            y = y + rowH

            AddLabelAndCtrl(Me.lblAddress3, "Address Line 3", col1X, y, Me.txtAddress3, col1X + labelW, y, inputW)
            AddLabelAndCtrl(Me.lblGender, "Gender", col2X, y, Me.cmbGender, col2X + labelW, y, inputW)
            y = y + rowH

            AddLabelAndCtrl(Me.lblPincode, "Pincode", col1X, y, Me.txtPincode, col1X + labelW, y, inputW)
            AddLabelAndCtrl(Me.lblProfession, "Profession", col2X, y, Me.txtProfession, col2X + labelW, y, inputW)
            y = y + rowH

            AddLabelAndCtrl(Me.lblRegisteredThrough, "Registered Through", col1X, y, Me.cmbRegisteredThrough, col1X + labelW, y, inputW)
            AddLabelAndCtrl(Me.lblRegisteredOn, "Registered On", col2X, y, Me.dtpRegisteredOn, col2X + labelW, y, inputW)
            y = y + rowH + 20

            Me.btnSaveMember.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
            Me.btnSaveMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSaveMember.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnSaveMember.ForeColor = System.Drawing.Color.White
            Me.btnSaveMember.Location = New System.Drawing.Point(col1X + labelW, y)
            Me.btnSaveMember.Size = New System.Drawing.Size(120, 35)
            Me.btnSaveMember.Text = "Save"
            Me.btnSaveMember.UseVisualStyleBackColor = False
            Me.pnlAddForm.Controls.Add(Me.btnSaveMember)

            Me.btnCancelMember.BackColor = System.Drawing.Color.FromArgb(231, 76, 60)
            Me.btnCancelMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancelMember.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnCancelMember.ForeColor = System.Drawing.Color.White
            Me.btnCancelMember.Location = New System.Drawing.Point(col1X + labelW + 135, y)
            Me.btnCancelMember.Size = New System.Drawing.Size(120, 35)
            Me.btnCancelMember.Text = "Cancel"
            Me.btnCancelMember.UseVisualStyleBackColor = False
            Me.pnlAddForm.Controls.Add(Me.btnCancelMember)

            'cmbGender items
            Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbAddState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbAddMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbRegisteredThrough.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList

            Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short
            Me.dtpRegisteredOn.Format = System.Windows.Forms.DateTimePickerFormat.Short

            '============ UserControl ============
            Me.Controls.Add(Me.addMemberPanel)
            Me.Controls.Add(Me.mainPanel)
            Me.Name = "MembersControl"
            Me.Size = New System.Drawing.Size(1192, 609)

            Me.mainPanel.ResumeLayout(False)
            Me.pnlFilters.ResumeLayout(False)
            Me.pnlFilters.PerformLayout()
            CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).EndInit()
            Me.addMemberPanel.ResumeLayout(False)
            Me.pnlAddHeader.ResumeLayout(False)
            Me.pnlAddForm.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

        Private Sub AddLabelAndCtrl(lbl As Label, text As String, lblX As Integer, lblY As Integer,
                                    ctrl As Control, ctrlX As Integer, ctrlY As Integer, ctrlW As Integer)
            lbl.Text = text
            lbl.Location = New System.Drawing.Point(lblX, lblY + 6)
            lbl.Size = New System.Drawing.Size(150, 20)
            lbl.Font = New System.Drawing.Font("Segoe UI", 9.0!, FontStyle.Bold)
            Me.pnlAddForm.Controls.Add(lbl)

            ctrl.Location = New System.Drawing.Point(ctrlX, ctrlY)
            ctrl.Size = New System.Drawing.Size(ctrlW, 25)
            ctrl.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.pnlAddForm.Controls.Add(ctrl)
        End Sub

        '--- Main panel ---
        Friend WithEvents mainPanel As System.Windows.Forms.Panel
        Friend WithEvents pnlFilters As System.Windows.Forms.Panel
        Friend WithEvents lblState As System.Windows.Forms.Label
        Friend WithEvents cmbState As System.Windows.Forms.ComboBox
        Friend WithEvents lblMemberType As System.Windows.Forms.Label
        Friend WithEvents cmbMemberType As System.Windows.Forms.ComboBox
        Friend WithEvents lblSearch As System.Windows.Forms.Label
        Friend WithEvents txtSearch As System.Windows.Forms.TextBox
        Friend WithEvents btnSearch As System.Windows.Forms.Button
        Friend WithEvents btnRefresh As System.Windows.Forms.Button
        Friend WithEvents btnAddMember As System.Windows.Forms.Button
        Friend WithEvents dgvMembers As System.Windows.Forms.DataGridView

        '--- Add/Edit panel ---
        Friend WithEvents addMemberPanel As System.Windows.Forms.Panel
        Friend WithEvents pnlAddHeader As System.Windows.Forms.Panel
        Friend WithEvents lblAddTitle As System.Windows.Forms.Label
        Friend WithEvents btnBack As System.Windows.Forms.Button
        Friend WithEvents pnlAddForm As System.Windows.Forms.Panel
        Friend WithEvents lblAddState As System.Windows.Forms.Label
        Friend WithEvents cmbAddState As System.Windows.Forms.ComboBox
        Friend WithEvents lblAddMemberType As System.Windows.Forms.Label
        Friend WithEvents cmbAddMemberType As System.Windows.Forms.ComboBox
        Friend WithEvents lblMemberNumber As System.Windows.Forms.Label
        Friend WithEvents txtMemberNumber As System.Windows.Forms.TextBox
        Friend WithEvents lblApplicationNo As System.Windows.Forms.Label
        Friend WithEvents txtApplicationNo As System.Windows.Forms.TextBox
        Friend WithEvents lblMemberName As System.Windows.Forms.Label
        Friend WithEvents txtMemberName As System.Windows.Forms.TextBox
        Friend WithEvents lblAddress1 As System.Windows.Forms.Label
        Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
        Friend WithEvents lblAddress2 As System.Windows.Forms.Label
        Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
        Friend WithEvents lblAddress3 As System.Windows.Forms.Label
        Friend WithEvents txtAddress3 As System.Windows.Forms.TextBox
        Friend WithEvents lblPincode As System.Windows.Forms.Label
        Friend WithEvents txtPincode As System.Windows.Forms.TextBox
        Friend WithEvents lblMobile As System.Windows.Forms.Label
        Friend WithEvents txtMobile As System.Windows.Forms.TextBox
        Friend WithEvents lblAadhar As System.Windows.Forms.Label
        Friend WithEvents txtAadhar As System.Windows.Forms.TextBox
        Friend WithEvents lblDOB As System.Windows.Forms.Label
        Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblGender As System.Windows.Forms.Label
        Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
        Friend WithEvents lblProfession As System.Windows.Forms.Label
        Friend WithEvents txtProfession As System.Windows.Forms.TextBox
        Friend WithEvents lblRegisteredThrough As System.Windows.Forms.Label
        Friend WithEvents cmbRegisteredThrough As System.Windows.Forms.ComboBox
        Friend WithEvents lblRegisteredOn As System.Windows.Forms.Label
        Friend WithEvents dtpRegisteredOn As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnSaveMember As System.Windows.Forms.Button
        Friend WithEvents btnCancelMember As System.Windows.Forms.Button

    End Class

End Namespace
