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
            Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
            mainPanel = New Panel()
            dgvMembers = New DataGridView()
            pnlFilters = New Panel()
            lblState = New Label()
            cmbState = New ComboBox()
            lblMemberType = New Label()
            cmbMemberType = New ComboBox()
            lblSearch = New Label()
            txtSearch = New TextBox()
            btnSearch = New Button()
            btnRefresh = New Button()
            btnAddMember = New Button()
            addMemberPanel = New Panel()
            pnlAddHeader = New Panel()
            lblAddTitle = New Label()
            btnBack = New Button()
            pnlAddForm = New Panel()
            btnSaveMember = New Button()
            btnCancelMember = New Button()
            lblAddState = New Label()
            cmbAddState = New ComboBox()
            lblAddMemberType = New Label()
            cmbAddMemberType = New ComboBox()
            lblMemberNumber = New Label()
            txtMemberNumber = New TextBox()
            lblApplicationNo = New Label()
            txtApplicationNo = New TextBox()
            lblMemberName = New Label()
            txtMemberName = New TextBox()
            lblAddress1 = New Label()
            txtAddress1 = New TextBox()
            lblAddress2 = New Label()
            txtAddress2 = New TextBox()
            lblAddress3 = New Label()
            txtAddress3 = New TextBox()
            lblPincode = New Label()
            txtPincode = New TextBox()
            lblMobile = New Label()
            txtMobile = New TextBox()
            lblAadhar = New Label()
            txtAadhar = New TextBox()
            lblDOB = New Label()
            dtpDOB = New DateTimePicker()
            lblGender = New Label()
            cmbGender = New ComboBox()
            lblProfession = New Label()
            txtProfession = New TextBox()
            lblRegisteredThrough = New Label()
            cmbRegisteredThrough = New ComboBox()
            lblRegisteredOn = New Label()
            dtpRegisteredOn = New DateTimePicker()
            mainPanel.SuspendLayout()
            CType(dgvMembers, ISupportInitialize).BeginInit()
            pnlFilters.SuspendLayout()
            addMemberPanel.SuspendLayout()
            pnlAddHeader.SuspendLayout()
            pnlAddForm.SuspendLayout()
            SuspendLayout()
            ' 
            ' mainPanel
            ' 
            mainPanel.BackColor = Color.White
            mainPanel.Controls.Add(dgvMembers)
            mainPanel.Controls.Add(pnlFilters)
            mainPanel.Dock = DockStyle.Fill
            mainPanel.Location = New Point(0, 0)
            mainPanel.Name = "mainPanel"
            mainPanel.Size = New Size(1192, 609)
            mainPanel.TabIndex = 1
            ' 
            ' dgvMembers
            ' 
            dgvMembers.AllowUserToAddRows = False
            dgvMembers.AllowUserToDeleteRows = False
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvMembers.BackgroundColor = Color.White
            dgvMembers.BorderStyle = BorderStyle.None
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
            DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            DataGridViewCellStyle1.ForeColor = Color.White
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
            dgvMembers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            dgvMembers.ColumnHeadersHeight = 35
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            dgvMembers.EnableHeadersVisualStyles = False
            dgvMembers.Location = New Point(0, 80)
            dgvMembers.MultiSelect = False
            dgvMembers.Name = "dgvMembers"
            dgvMembers.ReadOnly = True
            dgvMembers.RowHeadersVisible = False
            dgvMembers.RowHeadersWidth = 62
            dgvMembers.RowTemplate.Height = 28
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvMembers.Size = New Size(1192, 529)
            dgvMembers.TabIndex = 0
            ' 
            ' pnlFilters
            ' 
            pnlFilters.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
            pnlFilters.Controls.Add(lblState)
            pnlFilters.Controls.Add(cmbState)
            pnlFilters.Controls.Add(lblMemberType)
            pnlFilters.Controls.Add(cmbMemberType)
            pnlFilters.Controls.Add(lblSearch)
            pnlFilters.Controls.Add(txtSearch)
            pnlFilters.Controls.Add(btnSearch)
            pnlFilters.Controls.Add(btnRefresh)
            pnlFilters.Controls.Add(btnAddMember)
            pnlFilters.Dock = DockStyle.Fill
            pnlFilters.Location = New Point(0, 0)
            pnlFilters.Name = "pnlFilters"
            pnlFilters.Size = New Size(1192, 609)
            pnlFilters.TabIndex = 1
            ' 
            ' lblState
            ' 
            lblState.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            lblState.Location = New Point(15, 15)
            lblState.Name = "lblState"
            lblState.Size = New Size(100, 20)
            lblState.TabIndex = 0
            lblState.Text = "State:"
            ' 
            ' cmbState
            ' 
            cmbState.DropDownStyle = ComboBoxStyle.DropDownList
            cmbState.Font = New Font("Segoe UI", 9.0F)
            cmbState.Location = New Point(15, 38)
            cmbState.Name = "cmbState"
            cmbState.Size = New Size(180, 33)
            cmbState.TabIndex = 1
            ' 
            ' lblMemberType
            ' 
            lblMemberType.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            lblMemberType.Location = New Point(210, 15)
            lblMemberType.Name = "lblMemberType"
            lblMemberType.Size = New Size(100, 20)
            lblMemberType.TabIndex = 2
            lblMemberType.Text = "Member Type:"
            ' 
            ' cmbMemberType
            ' 
            cmbMemberType.DropDownStyle = ComboBoxStyle.DropDownList
            cmbMemberType.Font = New Font("Segoe UI", 9.0F)
            cmbMemberType.Location = New Point(210, 38)
            cmbMemberType.Name = "cmbMemberType"
            cmbMemberType.Size = New Size(180, 33)
            cmbMemberType.TabIndex = 3
            ' 
            ' lblSearch
            ' 
            lblSearch.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            lblSearch.Location = New Point(405, 15)
            lblSearch.Name = "lblSearch"
            lblSearch.Size = New Size(100, 20)
            lblSearch.TabIndex = 4
            lblSearch.Text = "Search:"
            ' 
            ' txtSearch
            ' 
            txtSearch.Font = New Font("Segoe UI", 9.0F)
            txtSearch.Location = New Point(405, 38)
            txtSearch.Name = "txtSearch"
            txtSearch.Size = New Size(220, 31)
            txtSearch.TabIndex = 5
            ' 
            ' btnSearch
            ' 
            btnSearch.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
            btnSearch.FlatStyle = FlatStyle.Flat
            btnSearch.ForeColor = Color.White
            btnSearch.Location = New Point(635, 37)
            btnSearch.Name = "btnSearch"
            btnSearch.Size = New Size(80, 28)
            btnSearch.TabIndex = 6
            btnSearch.Text = "Search"
            btnSearch.UseVisualStyleBackColor = False
            ' 
            ' btnRefresh
            ' 
            btnRefresh.BackColor = Color.FromArgb(CByte(149), CByte(165), CByte(166))
            btnRefresh.FlatStyle = FlatStyle.Flat
            btnRefresh.ForeColor = Color.White
            btnRefresh.Location = New Point(725, 37)
            btnRefresh.Name = "btnRefresh"
            btnRefresh.Size = New Size(80, 28)
            btnRefresh.TabIndex = 7
            btnRefresh.Text = "Refresh"
            btnRefresh.UseVisualStyleBackColor = False
            ' 
            ' btnAddMember
            ' 
            btnAddMember.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btnAddMember.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
            btnAddMember.FlatStyle = FlatStyle.Flat
            btnAddMember.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            btnAddMember.ForeColor = Color.White
            btnAddMember.Location = New Point(2042, 37)
            btnAddMember.Name = "btnAddMember"
            btnAddMember.Size = New Size(130, 28)
            btnAddMember.TabIndex = 8
            btnAddMember.Text = "+ Add Member"
            btnAddMember.UseVisualStyleBackColor = False
            ' 
            ' addMemberPanel
            ' 
            addMemberPanel.BackColor = Color.White
            addMemberPanel.Controls.Add(pnlAddHeader)
            addMemberPanel.Controls.Add(pnlAddForm)
            addMemberPanel.Location = New Point(0, 0)
            addMemberPanel.Name = "addMemberPanel"
            addMemberPanel.Size = New Size(1158, 609)
            addMemberPanel.TabIndex = 0
            addMemberPanel.Visible = False
            ' 
            ' pnlAddHeader
            ' 
            pnlAddHeader.BackColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
            pnlAddHeader.Controls.Add(lblAddTitle)
            pnlAddHeader.Controls.Add(btnBack)
            pnlAddHeader.Dock = DockStyle.Top
            pnlAddHeader.Location = New Point(0, 0)
            pnlAddHeader.Name = "pnlAddHeader"
            pnlAddHeader.Size = New Size(1158, 50)
            pnlAddHeader.TabIndex = 1
            ' 
            ' lblAddTitle
            ' 
            lblAddTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
            lblAddTitle.ForeColor = Color.White
            lblAddTitle.Location = New Point(75, 13)
            lblAddTitle.Name = "lblAddTitle"
            lblAddTitle.Size = New Size(400, 25)
            lblAddTitle.TabIndex = 0
            lblAddTitle.Text = "Add New Member"
            ' 
            ' btnBack
            ' 
            btnBack.BackColor = Color.FromArgb(CByte(149), CByte(165), CByte(166))
            btnBack.FlatStyle = FlatStyle.Flat
            btnBack.ForeColor = Color.White
            btnBack.Location = New Point(10, 12)
            btnBack.Name = "btnBack"
            btnBack.Size = New Size(60, 28)
            btnBack.TabIndex = 1
            btnBack.Text = "← Back"
            btnBack.UseVisualStyleBackColor = False
            ' 
            ' pnlAddForm
            ' 
            pnlAddForm.AutoScroll = True
            pnlAddForm.Controls.Add(btnSaveMember)
            pnlAddForm.Controls.Add(btnCancelMember)
            pnlAddForm.Location = New Point(0, 50)
            pnlAddForm.Name = "pnlAddForm"
            pnlAddForm.Padding = New Padding(30)
            pnlAddForm.Size = New Size(1155, 559)
            pnlAddForm.TabIndex = 0
            ' 
            ' btnSaveMember
            ' 
            btnSaveMember.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
            btnSaveMember.FlatStyle = FlatStyle.Flat
            btnSaveMember.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
            btnSaveMember.ForeColor = Color.White
            btnSaveMember.Location = New Point(30, 20)
            btnSaveMember.Name = "btnSaveMember"
            btnSaveMember.Size = New Size(120, 35)
            btnSaveMember.TabIndex = 0
            btnSaveMember.Text = "Save"
            btnSaveMember.UseVisualStyleBackColor = False
            ' 
            ' btnCancelMember
            ' 
            btnCancelMember.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
            btnCancelMember.FlatStyle = FlatStyle.Flat
            btnCancelMember.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
            btnCancelMember.ForeColor = Color.White
            btnCancelMember.Location = New Point(30, 20)
            btnCancelMember.Name = "btnCancelMember"
            btnCancelMember.Size = New Size(120, 35)
            btnCancelMember.TabIndex = 1
            btnCancelMember.Text = "Cancel"
            btnCancelMember.UseVisualStyleBackColor = False
            ' 
            ' lblAddState
            ' 
            lblAddState.Location = New Point(0, 0)
            lblAddState.Name = "lblAddState"
            lblAddState.Size = New Size(100, 23)
            lblAddState.TabIndex = 0
            ' 
            ' cmbAddState
            ' 
            cmbAddState.DropDownStyle = ComboBoxStyle.DropDownList
            cmbAddState.Location = New Point(0, 0)
            cmbAddState.Name = "cmbAddState"
            cmbAddState.Size = New Size(121, 33)
            cmbAddState.TabIndex = 0
            ' 
            ' lblAddMemberType
            ' 
            lblAddMemberType.Location = New Point(0, 0)
            lblAddMemberType.Name = "lblAddMemberType"
            lblAddMemberType.Size = New Size(100, 23)
            lblAddMemberType.TabIndex = 0
            ' 
            ' cmbAddMemberType
            ' 
            cmbAddMemberType.DropDownStyle = ComboBoxStyle.DropDownList
            cmbAddMemberType.Location = New Point(0, 0)
            cmbAddMemberType.Name = "cmbAddMemberType"
            cmbAddMemberType.Size = New Size(121, 33)
            cmbAddMemberType.TabIndex = 0
            ' 
            ' lblMemberNumber
            ' 
            lblMemberNumber.Location = New Point(0, 0)
            lblMemberNumber.Name = "lblMemberNumber"
            lblMemberNumber.Size = New Size(100, 23)
            lblMemberNumber.TabIndex = 0
            ' 
            ' txtMemberNumber
            ' 
            txtMemberNumber.Location = New Point(0, 0)
            txtMemberNumber.Name = "txtMemberNumber"
            txtMemberNumber.Size = New Size(100, 31)
            txtMemberNumber.TabIndex = 0
            ' 
            ' lblApplicationNo
            ' 
            lblApplicationNo.Location = New Point(0, 0)
            lblApplicationNo.Name = "lblApplicationNo"
            lblApplicationNo.Size = New Size(100, 23)
            lblApplicationNo.TabIndex = 0
            ' 
            ' txtApplicationNo
            ' 
            txtApplicationNo.Location = New Point(0, 0)
            txtApplicationNo.Name = "txtApplicationNo"
            txtApplicationNo.Size = New Size(100, 31)
            txtApplicationNo.TabIndex = 0
            ' 
            ' lblMemberName
            ' 
            lblMemberName.Location = New Point(0, 0)
            lblMemberName.Name = "lblMemberName"
            lblMemberName.Size = New Size(100, 23)
            lblMemberName.TabIndex = 0
            ' 
            ' txtMemberName
            ' 
            txtMemberName.Location = New Point(0, 0)
            txtMemberName.Name = "txtMemberName"
            txtMemberName.Size = New Size(100, 31)
            txtMemberName.TabIndex = 0
            ' 
            ' lblAddress1
            ' 
            lblAddress1.Location = New Point(0, 0)
            lblAddress1.Name = "lblAddress1"
            lblAddress1.Size = New Size(100, 23)
            lblAddress1.TabIndex = 0
            ' 
            ' txtAddress1
            ' 
            txtAddress1.Location = New Point(0, 0)
            txtAddress1.Name = "txtAddress1"
            txtAddress1.Size = New Size(100, 31)
            txtAddress1.TabIndex = 0
            ' 
            ' lblAddress2
            ' 
            lblAddress2.Location = New Point(0, 0)
            lblAddress2.Name = "lblAddress2"
            lblAddress2.Size = New Size(100, 23)
            lblAddress2.TabIndex = 0
            ' 
            ' txtAddress2
            ' 
            txtAddress2.Location = New Point(0, 0)
            txtAddress2.Name = "txtAddress2"
            txtAddress2.Size = New Size(100, 31)
            txtAddress2.TabIndex = 0
            ' 
            ' lblAddress3
            ' 
            lblAddress3.Location = New Point(0, 0)
            lblAddress3.Name = "lblAddress3"
            lblAddress3.Size = New Size(100, 23)
            lblAddress3.TabIndex = 0
            ' 
            ' txtAddress3
            ' 
            txtAddress3.Location = New Point(0, 0)
            txtAddress3.Name = "txtAddress3"
            txtAddress3.Size = New Size(100, 31)
            txtAddress3.TabIndex = 0
            ' 
            ' lblPincode
            ' 
            lblPincode.Location = New Point(0, 0)
            lblPincode.Name = "lblPincode"
            lblPincode.Size = New Size(100, 23)
            lblPincode.TabIndex = 0
            ' 
            ' txtPincode
            ' 
            txtPincode.Location = New Point(0, 0)
            txtPincode.Name = "txtPincode"
            txtPincode.Size = New Size(100, 31)
            txtPincode.TabIndex = 0
            ' 
            ' lblMobile
            ' 
            lblMobile.Location = New Point(0, 0)
            lblMobile.Name = "lblMobile"
            lblMobile.Size = New Size(100, 23)
            lblMobile.TabIndex = 0
            ' 
            ' txtMobile
            ' 
            txtMobile.Location = New Point(0, 0)
            txtMobile.Name = "txtMobile"
            txtMobile.Size = New Size(100, 31)
            txtMobile.TabIndex = 0
            ' 
            ' lblAadhar
            ' 
            lblAadhar.Location = New Point(0, 0)
            lblAadhar.Name = "lblAadhar"
            lblAadhar.Size = New Size(100, 23)
            lblAadhar.TabIndex = 0
            ' 
            ' txtAadhar
            ' 
            txtAadhar.Location = New Point(0, 0)
            txtAadhar.Name = "txtAadhar"
            txtAadhar.Size = New Size(100, 31)
            txtAadhar.TabIndex = 0
            ' 
            ' lblDOB
            ' 
            lblDOB.Location = New Point(0, 0)
            lblDOB.Name = "lblDOB"
            lblDOB.Size = New Size(100, 23)
            lblDOB.TabIndex = 0
            ' 
            ' dtpDOB
            ' 
            dtpDOB.Format = DateTimePickerFormat.Short
            dtpDOB.Location = New Point(0, 0)
            dtpDOB.Name = "dtpDOB"
            dtpDOB.Size = New Size(200, 31)
            dtpDOB.TabIndex = 0
            ' 
            ' lblGender
            ' 
            lblGender.Location = New Point(0, 0)
            lblGender.Name = "lblGender"
            lblGender.Size = New Size(100, 23)
            lblGender.TabIndex = 0
            ' 
            ' cmbGender
            ' 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList
            cmbGender.Location = New Point(0, 0)
            cmbGender.Name = "cmbGender"
            cmbGender.Size = New Size(121, 33)
            cmbGender.TabIndex = 0
            ' 
            ' lblProfession
            ' 
            lblProfession.Location = New Point(0, 0)
            lblProfession.Name = "lblProfession"
            lblProfession.Size = New Size(100, 23)
            lblProfession.TabIndex = 0
            ' 
            ' txtProfession
            ' 
            txtProfession.Location = New Point(0, 0)
            txtProfession.Name = "txtProfession"
            txtProfession.Size = New Size(100, 31)
            txtProfession.TabIndex = 0
            ' 
            ' lblRegisteredThrough
            ' 
            lblRegisteredThrough.Location = New Point(0, 0)
            lblRegisteredThrough.Name = "lblRegisteredThrough"
            lblRegisteredThrough.Size = New Size(100, 23)
            lblRegisteredThrough.TabIndex = 0
            ' 
            ' cmbRegisteredThrough
            ' 
            cmbRegisteredThrough.DropDownStyle = ComboBoxStyle.DropDownList
            cmbRegisteredThrough.Location = New Point(0, 0)
            cmbRegisteredThrough.Name = "cmbRegisteredThrough"
            cmbRegisteredThrough.Size = New Size(121, 33)
            cmbRegisteredThrough.TabIndex = 0
            ' 
            ' lblRegisteredOn
            ' 
            lblRegisteredOn.Location = New Point(0, 0)
            lblRegisteredOn.Name = "lblRegisteredOn"
            lblRegisteredOn.Size = New Size(100, 23)
            lblRegisteredOn.TabIndex = 0
            ' 
            ' dtpRegisteredOn
            ' 
            dtpRegisteredOn.Format = DateTimePickerFormat.Short
            dtpRegisteredOn.Location = New Point(0, 0)
            dtpRegisteredOn.Name = "dtpRegisteredOn"
            dtpRegisteredOn.Size = New Size(200, 31)
            dtpRegisteredOn.TabIndex = 0
            ' 
            ' MembersControl
            ' 
            Controls.Add(mainPanel)
            Controls.Add(addMemberPanel)
            Name = "MembersControl"
            Size = New Size(1192, 609)
            mainPanel.ResumeLayout(False)
            CType(dgvMembers, ISupportInitialize).EndInit()
            pnlFilters.ResumeLayout(False)
            pnlFilters.PerformLayout()
            addMemberPanel.ResumeLayout(False)
            pnlAddHeader.ResumeLayout(False)
            pnlAddForm.ResumeLayout(False)
            ResumeLayout(False)
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
