Imports System.ComponentModel

Namespace UserControls

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class RenewalControl
        Inherits System.Windows.Forms.UserControl

        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then components.Dispose()
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        Private components As System.ComponentModel.IContainer

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
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
            Me.btnAddRenewal = New System.Windows.Forms.Button()
            Me.dgvRenewals = New System.Windows.Forms.DataGridView()

            Me.addRenewalPanel = New System.Windows.Forms.Panel()
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
            Me.lblMemberName = New System.Windows.Forms.Label()
            Me.txtMemberName = New System.Windows.Forms.TextBox()
            Me.lblReceiptType = New System.Windows.Forms.Label()
            Me.cmbReceiptType = New System.Windows.Forms.ComboBox()
            Me.lblReceiptNo = New System.Windows.Forms.Label()
            Me.txtReceiptNo = New System.Windows.Forms.TextBox()
            Me.lblReceiptDate = New System.Windows.Forms.Label()
            Me.dtpReceiptDate = New System.Windows.Forms.DateTimePicker()
            Me.lblAmount = New System.Windows.Forms.Label()
            Me.txtAmount = New System.Windows.Forms.TextBox()
            Me.btnSaveRenewal = New System.Windows.Forms.Button()
            Me.btnCancelRenewal = New System.Windows.Forms.Button()

            Me.mainPanel.SuspendLayout()
            Me.pnlFilters.SuspendLayout()
            CType(Me.dgvRenewals, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.addRenewalPanel.SuspendLayout()
            Me.pnlAddHeader.SuspendLayout()
            Me.pnlAddForm.SuspendLayout()
            Me.SuspendLayout()

            '========== MAIN PANEL ==========
            Me.mainPanel.BackColor = System.Drawing.Color.White
            Me.mainPanel.Controls.Add(Me.dgvRenewals)
            Me.mainPanel.Controls.Add(Me.pnlFilters)
            Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mainPanel.Name = "mainPanel"

            Me.pnlFilters.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
            Me.pnlFilters.Controls.Add(Me.lblState)
            Me.pnlFilters.Controls.Add(Me.cmbState)
            Me.pnlFilters.Controls.Add(Me.lblMemberType)
            Me.pnlFilters.Controls.Add(Me.cmbMemberType)
            Me.pnlFilters.Controls.Add(Me.lblSearch)
            Me.pnlFilters.Controls.Add(Me.txtSearch)
            Me.pnlFilters.Controls.Add(Me.btnSearch)
            Me.pnlFilters.Controls.Add(Me.btnRefresh)
            Me.pnlFilters.Controls.Add(Me.btnAddRenewal)
            Me.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlFilters.Height = 80

            Me.lblState.Text = "State:"
            Me.lblState.Location = New System.Drawing.Point(15, 15)
            Me.lblState.Size = New System.Drawing.Size(100, 20)
            Me.lblState.Font = New System.Drawing.Font("Segoe UI", 9.0!, FontStyle.Bold)

            Me.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbState.Location = New System.Drawing.Point(15, 38)
            Me.cmbState.Size = New System.Drawing.Size(180, 25)

            Me.lblMemberType.Text = "Member Type:"
            Me.lblMemberType.Location = New System.Drawing.Point(210, 15)
            Me.lblMemberType.Size = New System.Drawing.Size(100, 20)
            Me.lblMemberType.Font = New System.Drawing.Font("Segoe UI", 9.0!, FontStyle.Bold)

            Me.cmbMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbMemberType.Location = New System.Drawing.Point(210, 38)
            Me.cmbMemberType.Size = New System.Drawing.Size(180, 25)

            Me.lblSearch.Text = "Search:"
            Me.lblSearch.Location = New System.Drawing.Point(405, 15)
            Me.lblSearch.Size = New System.Drawing.Size(100, 20)
            Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, FontStyle.Bold)

            Me.txtSearch.Location = New System.Drawing.Point(405, 38)
            Me.txtSearch.Size = New System.Drawing.Size(220, 25)

            Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(52, 152, 219)
            Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSearch.ForeColor = System.Drawing.Color.White
            Me.btnSearch.Location = New System.Drawing.Point(635, 37)
            Me.btnSearch.Size = New System.Drawing.Size(80, 28)
            Me.btnSearch.Text = "Search"
            Me.btnSearch.UseVisualStyleBackColor = False

            Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(149, 165, 166)
            Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRefresh.ForeColor = System.Drawing.Color.White
            Me.btnRefresh.Location = New System.Drawing.Point(725, 37)
            Me.btnRefresh.Size = New System.Drawing.Size(80, 28)
            Me.btnRefresh.Text = "Refresh"
            Me.btnRefresh.UseVisualStyleBackColor = False

            Me.btnAddRenewal.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
            Me.btnAddRenewal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAddRenewal.Font = New System.Drawing.Font("Segoe UI", 9.0!, FontStyle.Bold)
            Me.btnAddRenewal.ForeColor = System.Drawing.Color.White
            Me.btnAddRenewal.Location = New System.Drawing.Point(815, 37)
            Me.btnAddRenewal.Size = New System.Drawing.Size(140, 28)
            Me.btnAddRenewal.Text = "+ Add Renewal"
            Me.btnAddRenewal.UseVisualStyleBackColor = False

            Me.dgvRenewals.AllowUserToAddRows = False
            Me.dgvRenewals.AllowUserToDeleteRows = False
            Me.dgvRenewals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvRenewals.BackgroundColor = System.Drawing.Color.White
            Me.dgvRenewals.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvRenewals.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94)
            Me.dgvRenewals.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
            Me.dgvRenewals.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, FontStyle.Bold)
            Me.dgvRenewals.ColumnHeadersHeight = 35
            Me.dgvRenewals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvRenewals.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvRenewals.EnableHeadersVisualStyles = False
            Me.dgvRenewals.MultiSelect = False
            Me.dgvRenewals.ReadOnly = True
            Me.dgvRenewals.RowHeadersVisible = False
            Me.dgvRenewals.RowTemplate.Height = 28
            Me.dgvRenewals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect

            '========== ADD PANEL ==========
            Me.addRenewalPanel.BackColor = System.Drawing.Color.White
            Me.addRenewalPanel.Controls.Add(Me.pnlAddForm)
            Me.addRenewalPanel.Controls.Add(Me.pnlAddHeader)
            Me.addRenewalPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.addRenewalPanel.Visible = False

            Me.pnlAddHeader.BackColor = System.Drawing.Color.FromArgb(52, 73, 94)
            Me.pnlAddHeader.Controls.Add(Me.lblAddTitle)
            Me.pnlAddHeader.Controls.Add(Me.btnBack)
            Me.pnlAddHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlAddHeader.Height = 50

            Me.lblAddTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, FontStyle.Bold)
            Me.lblAddTitle.ForeColor = System.Drawing.Color.White
            Me.lblAddTitle.Location = New System.Drawing.Point(75, 13)
            Me.lblAddTitle.Size = New System.Drawing.Size(400, 25)
            Me.lblAddTitle.Text = "Add New Renewal"

            Me.btnBack.BackColor = System.Drawing.Color.FromArgb(149, 165, 166)
            Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBack.ForeColor = System.Drawing.Color.White
            Me.btnBack.Location = New System.Drawing.Point(10, 12)
            Me.btnBack.Size = New System.Drawing.Size(60, 28)
            Me.btnBack.Text = "← Back"
            Me.btnBack.UseVisualStyleBackColor = False

            Me.pnlAddForm.AutoScroll = True
            Me.pnlAddForm.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlAddForm.Padding = New System.Windows.Forms.Padding(30)

            Dim col1X As Integer = 30, col2X As Integer = 450
            Dim labelW As Integer = 160, inputW As Integer = 240, rowH As Integer = 50
            Dim y As Integer = 20

            AddLabelAndCtrl(Me.lblAddState, "State *", col1X, y, Me.cmbAddState, col1X + labelW, y, inputW)
            AddLabelAndCtrl(Me.lblAddMemberType, "Member Type *", col2X, y, Me.cmbAddMemberType, col2X + labelW, y, inputW)
            y = y + rowH

            AddLabelAndCtrl(Me.lblMemberNumber, "Member No *", col1X, y, Me.txtMemberNumber, col1X + labelW, y, inputW)
            AddLabelAndCtrl(Me.lblMemberName, "Member Name", col2X, y, Me.txtMemberName, col2X + labelW, y, inputW)
            y = y + rowH

            AddLabelAndCtrl(Me.lblReceiptType, "Receipt Type", col1X, y, Me.cmbReceiptType, col1X + labelW, y, inputW)
            AddLabelAndCtrl(Me.lblReceiptNo, "Receipt No", col2X, y, Me.txtReceiptNo, col2X + labelW, y, inputW)
            y = y + rowH

            AddLabelAndCtrl(Me.lblReceiptDate, "Receipt Date", col1X, y, Me.dtpReceiptDate, col1X + labelW, y, inputW)
            AddLabelAndCtrl(Me.lblAmount, "Amount *", col2X, y, Me.txtAmount, col2X + labelW, y, inputW)
            y = y + rowH + 20

            Me.btnSaveRenewal.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
            Me.btnSaveRenewal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSaveRenewal.Font = New System.Drawing.Font("Segoe UI", 10.0!, FontStyle.Bold)
            Me.btnSaveRenewal.ForeColor = System.Drawing.Color.White
            Me.btnSaveRenewal.Location = New System.Drawing.Point(col1X + labelW, y)
            Me.btnSaveRenewal.Size = New System.Drawing.Size(120, 35)
            Me.btnSaveRenewal.Text = "Save"
            Me.btnSaveRenewal.UseVisualStyleBackColor = False
            Me.pnlAddForm.Controls.Add(Me.btnSaveRenewal)

            Me.btnCancelRenewal.BackColor = System.Drawing.Color.FromArgb(231, 76, 60)
            Me.btnCancelRenewal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancelRenewal.Font = New System.Drawing.Font("Segoe UI", 10.0!, FontStyle.Bold)
            Me.btnCancelRenewal.ForeColor = System.Drawing.Color.White
            Me.btnCancelRenewal.Location = New System.Drawing.Point(col1X + labelW + 135, y)
            Me.btnCancelRenewal.Size = New System.Drawing.Size(120, 35)
            Me.btnCancelRenewal.Text = "Cancel"
            Me.btnCancelRenewal.UseVisualStyleBackColor = False
            Me.pnlAddForm.Controls.Add(Me.btnCancelRenewal)

            Me.cmbAddState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbAddMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbReceiptType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.dtpReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Short

            Me.Controls.Add(Me.addRenewalPanel)
            Me.Controls.Add(Me.mainPanel)
            Me.Name = "RenewalControl"
            Me.Size = New System.Drawing.Size(1192, 609)

            Me.mainPanel.ResumeLayout(False)
            Me.pnlFilters.ResumeLayout(False)
            Me.pnlFilters.PerformLayout()
            CType(Me.dgvRenewals, System.ComponentModel.ISupportInitialize).EndInit()
            Me.addRenewalPanel.ResumeLayout(False)
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
        Friend WithEvents btnAddRenewal As System.Windows.Forms.Button
        Friend WithEvents dgvRenewals As System.Windows.Forms.DataGridView

        Friend WithEvents addRenewalPanel As System.Windows.Forms.Panel
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
        Friend WithEvents lblMemberName As System.Windows.Forms.Label
        Friend WithEvents txtMemberName As System.Windows.Forms.TextBox
        Friend WithEvents lblReceiptType As System.Windows.Forms.Label
        Friend WithEvents cmbReceiptType As System.Windows.Forms.ComboBox
        Friend WithEvents lblReceiptNo As System.Windows.Forms.Label
        Friend WithEvents txtReceiptNo As System.Windows.Forms.TextBox
        Friend WithEvents lblReceiptDate As System.Windows.Forms.Label
        Friend WithEvents dtpReceiptDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblAmount As System.Windows.Forms.Label
        Friend WithEvents txtAmount As System.Windows.Forms.TextBox
        Friend WithEvents btnSaveRenewal As System.Windows.Forms.Button
        Friend WithEvents btnCancelRenewal As System.Windows.Forms.Button

    End Class

End Namespace
