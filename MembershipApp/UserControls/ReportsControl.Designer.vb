Imports System.ComponentModel

Namespace UserControls

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ReportsControl
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
            Me.pnlFilters = New System.Windows.Forms.Panel()
            Me.lblReportType = New System.Windows.Forms.Label()
            Me.cmbReportType = New System.Windows.Forms.ComboBox()
            Me.lblFrom = New System.Windows.Forms.Label()
            Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
            Me.lblTo = New System.Windows.Forms.Label()
            Me.dtpTo = New System.Windows.Forms.DateTimePicker()
            Me.btnGenerate = New System.Windows.Forms.Button()
            Me.btnExport = New System.Windows.Forms.Button()
            Me.pnlTitle = New System.Windows.Forms.Panel()
            Me.lblReportTitle = New System.Windows.Forms.Label()
            Me.lblRecordCount = New System.Windows.Forms.Label()
            Me.dgvReport = New System.Windows.Forms.DataGridView()

            Me.pnlFilters.SuspendLayout()
            Me.pnlTitle.SuspendLayout()
            CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()

            'pnlFilters
            Me.pnlFilters.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
            Me.pnlFilters.Controls.Add(Me.lblReportType)
            Me.pnlFilters.Controls.Add(Me.cmbReportType)
            Me.pnlFilters.Controls.Add(Me.lblFrom)
            Me.pnlFilters.Controls.Add(Me.dtpFrom)
            Me.pnlFilters.Controls.Add(Me.lblTo)
            Me.pnlFilters.Controls.Add(Me.dtpTo)
            Me.pnlFilters.Controls.Add(Me.btnGenerate)
            Me.pnlFilters.Controls.Add(Me.btnExport)
            Me.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlFilters.Height = 80

            Me.lblReportType.Text = "Report Type:"
            Me.lblReportType.Location = New System.Drawing.Point(15, 15)
            Me.lblReportType.Size = New System.Drawing.Size(100, 20)
            Me.lblReportType.Font = New System.Drawing.Font("Segoe UI", 9.0!, FontStyle.Bold)

            Me.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbReportType.Location = New System.Drawing.Point(15, 38)
            Me.cmbReportType.Size = New System.Drawing.Size(200, 25)
            Me.cmbReportType.Font = New System.Drawing.Font("Segoe UI", 9.0!)

            Me.lblFrom.Text = "From Date:"
            Me.lblFrom.Location = New System.Drawing.Point(230, 15)
            Me.lblFrom.Size = New System.Drawing.Size(100, 20)
            Me.lblFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!, FontStyle.Bold)

            Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short
            Me.dtpFrom.Location = New System.Drawing.Point(230, 38)
            Me.dtpFrom.Size = New System.Drawing.Size(140, 25)
            Me.dtpFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)

            Me.lblTo.Text = "To Date:"
            Me.lblTo.Location = New System.Drawing.Point(385, 15)
            Me.lblTo.Size = New System.Drawing.Size(100, 20)
            Me.lblTo.Font = New System.Drawing.Font("Segoe UI", 9.0!, FontStyle.Bold)

            Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short
            Me.dtpTo.Location = New System.Drawing.Point(385, 38)
            Me.dtpTo.Size = New System.Drawing.Size(140, 25)
            Me.dtpTo.Font = New System.Drawing.Font("Segoe UI", 9.0!)

            Me.btnGenerate.BackColor = System.Drawing.Color.FromArgb(52, 152, 219)
            Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGenerate.Font = New System.Drawing.Font("Segoe UI", 9.0!, FontStyle.Bold)
            Me.btnGenerate.ForeColor = System.Drawing.Color.White
            Me.btnGenerate.Location = New System.Drawing.Point(545, 37)
            Me.btnGenerate.Size = New System.Drawing.Size(120, 28)
            Me.btnGenerate.Text = "Generate"
            Me.btnGenerate.UseVisualStyleBackColor = False

            Me.btnExport.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
            Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExport.Font = New System.Drawing.Font("Segoe UI", 9.0!, FontStyle.Bold)
            Me.btnExport.ForeColor = System.Drawing.Color.White
            Me.btnExport.Location = New System.Drawing.Point(675, 37)
            Me.btnExport.Size = New System.Drawing.Size(140, 28)
            Me.btnExport.Text = "Export to CSV"
            Me.btnExport.UseVisualStyleBackColor = False

            'pnlTitle
            Me.pnlTitle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94)
            Me.pnlTitle.Controls.Add(Me.lblReportTitle)
            Me.pnlTitle.Controls.Add(Me.lblRecordCount)
            Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTitle.Height = 40

            Me.lblReportTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, FontStyle.Bold)
            Me.lblReportTitle.ForeColor = System.Drawing.Color.White
            Me.lblReportTitle.Location = New System.Drawing.Point(15, 10)
            Me.lblReportTitle.Size = New System.Drawing.Size(600, 20)
            Me.lblReportTitle.Text = "— No report generated —"

            Me.lblRecordCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblRecordCount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.lblRecordCount.ForeColor = System.Drawing.Color.White
            Me.lblRecordCount.Location = New System.Drawing.Point(800, 12)
            Me.lblRecordCount.Size = New System.Drawing.Size(380, 20)
            Me.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight

            'dgvReport
            Me.dgvReport.AllowUserToAddRows = False
            Me.dgvReport.AllowUserToDeleteRows = False
            Me.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
            Me.dgvReport.BackgroundColor = System.Drawing.Color.White
            Me.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvReport.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(149, 165, 166)
            Me.dgvReport.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
            Me.dgvReport.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, FontStyle.Bold)
            Me.dgvReport.ColumnHeadersHeight = 35
            Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvReport.EnableHeadersVisualStyles = False
            Me.dgvReport.MultiSelect = False
            Me.dgvReport.ReadOnly = True
            Me.dgvReport.RowHeadersVisible = False
            Me.dgvReport.RowTemplate.Height = 28
            Me.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect

            Me.Controls.Add(Me.dgvReport)
            Me.Controls.Add(Me.pnlTitle)
            Me.Controls.Add(Me.pnlFilters)
            Me.Name = "ReportsControl"
            Me.Size = New System.Drawing.Size(1192, 609)

            Me.pnlFilters.ResumeLayout(False)
            Me.pnlFilters.PerformLayout()
            Me.pnlTitle.ResumeLayout(False)
            CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Friend WithEvents pnlFilters As System.Windows.Forms.Panel
        Friend WithEvents lblReportType As System.Windows.Forms.Label
        Friend WithEvents cmbReportType As System.Windows.Forms.ComboBox
        Friend WithEvents lblFrom As System.Windows.Forms.Label
        Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblTo As System.Windows.Forms.Label
        Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnGenerate As System.Windows.Forms.Button
        Friend WithEvents btnExport As System.Windows.Forms.Button
        Friend WithEvents pnlTitle As System.Windows.Forms.Panel
        Friend WithEvents lblReportTitle As System.Windows.Forms.Label
        Friend WithEvents lblRecordCount As System.Windows.Forms.Label
        Friend WithEvents dgvReport As System.Windows.Forms.DataGridView

    End Class

End Namespace
