Imports System.Data
Imports System.Data.SqlClient
Imports MembershipApp.Data

Namespace UserControls

    Public Class RenewalControl

        Private currentRenewalId As Integer = 0
        Private isEditMode As Boolean = False

        Private Sub RenewalControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadStates(cmbState)
            LoadMemberTypes(cmbMemberType)
            LoadStates(cmbAddState)
            LoadMemberTypes(cmbAddMemberType)
            LoadReceiptTypes()
            ShowMainPanel()
            LoadRenewals()
        End Sub

        Private Sub LoadStates(cmb As ComboBox)
            Try
                Dim dt As DataTable = DBHelper.ExecuteDataTable("sp_GetStates")
                Dim newRow As DataRow = dt.NewRow()
                newRow("StateId") = 0
                newRow("StateName") = "-- All States --"
                dt.Rows.InsertAt(newRow, 0)
                cmb.DataSource = dt
                cmb.DisplayMember = "StateName"
                cmb.ValueMember = "StateId"
                cmb.SelectedIndex = 0
            Catch ex As Exception
            End Try
        End Sub

        Private Sub LoadMemberTypes(cmb As ComboBox)
            Try
                Dim dt As DataTable = DBHelper.ExecuteDataTable("sp_GetMemberTypes")
                Dim newRow As DataRow = dt.NewRow()
                newRow("MemberTypeId") = 0
                newRow("MemberTypeName") = "-- All Types --"
                dt.Rows.InsertAt(newRow, 0)
                cmb.DataSource = dt
                cmb.DisplayMember = "MemberTypeName"
                cmb.ValueMember = "MemberTypeId"
                cmb.SelectedIndex = 0
            Catch ex As Exception
            End Try
        End Sub

        Private Sub LoadReceiptTypes()
            cmbReceiptType.Items.Clear()
            cmbReceiptType.Items.AddRange(New String() {"Cash", "Cheque", "Online Transfer", "Card", "UPI"})
        End Sub

        Private Sub ShowMainPanel()
            mainPanel.BringToFront()
            mainPanel.Visible = True
            addRenewalPanel.Visible = False
        End Sub

        Private Sub ShowAddPanel()
            addRenewalPanel.BringToFront()
            addRenewalPanel.Visible = True
            mainPanel.Visible = False
        End Sub

        Private Sub LoadRenewals()
            Try
                Dim stateId As Integer = GetComboBoxIntValue(cmbState, "StateId")
                Dim memberTypeId As Integer = GetComboBoxIntValue(cmbMemberType, "MemberTypeId")
                Dim search As String = txtSearch.Text.Trim()

                Dim dt As DataTable = DBHelper.ExecuteDataTable(
                    "sp_GetRenewals",
                    DBHelper.NewParam("@StateId", SqlDbType.Int, If(stateId = 0, DBNull.Value, CObj(stateId))),
                    DBHelper.NewParam("@MemberTypeId", SqlDbType.Int, If(memberTypeId = 0, DBNull.Value, CObj(memberTypeId))),
                    DBHelper.NewParam("@Search", SqlDbType.NVarChar, If(String.IsNullOrEmpty(search), DBNull.Value, CObj(search))))

                dgvRenewals.DataSource = dt
                FormatGrid()
            Catch ex As Exception
                MessageBox.Show("Error loading renewals: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub FormatGrid()
            If dgvRenewals.Columns.Count = 0 Then Return

            Dim headers As New Dictionary(Of String, String) From {
                {"StateName", "State Name"},
                {"MemberTypeName", "Member Type"},
                {"MemberNumber", "Member No"},
                {"MemberName", "Member Name"},
                {"ReceiptType", "Receipt Type"},
                {"ReceiptNo", "Receipt No"},
                {"ReceiptDate", "Receipt Date"},
                {"Amount", "Amount"}
            }

            For Each col As DataGridViewColumn In dgvRenewals.Columns
                If headers.ContainsKey(col.Name) Then col.HeaderText = headers(col.Name)
            Next

            If dgvRenewals.Columns.Contains("RenewalId") Then dgvRenewals.Columns("RenewalId").Visible = False
            If dgvRenewals.Columns.Contains("MemberId") Then dgvRenewals.Columns("MemberId").Visible = False
            If dgvRenewals.Columns.Contains("StateId") Then dgvRenewals.Columns("StateId").Visible = False
            If dgvRenewals.Columns.Contains("MemberTypeId") Then dgvRenewals.Columns("MemberTypeId").Visible = False

            If dgvRenewals.Columns.Contains("Amount") Then
                dgvRenewals.Columns("Amount").DefaultCellStyle.Format = "N2"
                dgvRenewals.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        End Sub

        Private Sub cmbState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbState.SelectedIndexChanged
            LoadRenewals()
        End Sub

        Private Sub cmbMemberType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMemberType.SelectedIndexChanged
            LoadRenewals()
        End Sub

        Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
            LoadRenewals()
        End Sub

        Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
            cmbState.SelectedIndex = 0
            cmbMemberType.SelectedIndex = 0
            txtSearch.Clear()
            LoadRenewals()
        End Sub

        Private Sub btnAddRenewal_Click(sender As Object, e As EventArgs) Handles btnAddRenewal.Click
            isEditMode = False
            currentRenewalId = 0
            ClearAddForm()
            lblAddTitle.Text = "Add New Renewal"
            ShowAddPanel()
        End Sub

        Private Sub dgvRenewals_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRenewals.CellDoubleClick
            If e.RowIndex < 0 Then Return
            isEditMode = True
            Dim row = dgvRenewals.Rows(e.RowIndex)
            PopulateAddForm(row)
            lblAddTitle.Text = "Edit Renewal"
            ShowAddPanel()
        End Sub

        Private Sub PopulateAddForm(row As DataGridViewRow)
            currentRenewalId = Convert.ToInt32(row.Cells("RenewalId").Value)

            If dgvRenewals.Columns.Contains("StateId") AndAlso row.Cells("StateId").Value IsNot DBNull.Value Then
                cmbAddState.SelectedValue = Convert.ToInt32(row.Cells("StateId").Value)
            End If
            If dgvRenewals.Columns.Contains("MemberTypeId") AndAlso row.Cells("MemberTypeId").Value IsNot DBNull.Value Then
                cmbAddMemberType.SelectedValue = Convert.ToInt32(row.Cells("MemberTypeId").Value)
            End If
            txtMemberNumber.Text = Cell(row, "MemberNumber")
            txtMemberName.Text = Cell(row, "MemberName")

            Dim rtype = Cell(row, "ReceiptType")
            If Not String.IsNullOrEmpty(rtype) AndAlso cmbReceiptType.Items.Contains(rtype) Then
                cmbReceiptType.SelectedItem = rtype
            End If

            txtReceiptNo.Text = Cell(row, "ReceiptNo")

            If row.Cells("ReceiptDate").Value IsNot DBNull.Value Then
                dtpReceiptDate.Value = Convert.ToDateTime(row.Cells("ReceiptDate").Value)
            End If
            If row.Cells("Amount").Value IsNot DBNull.Value Then
                txtAmount.Text = Convert.ToDecimal(row.Cells("Amount").Value).ToString("N2")
            End If
        End Sub

        Private Function Cell(row As DataGridViewRow, col As String) As String
            ' Check if the column exists in the parent grid
            If row.DataGridView Is Nothing OrElse Not row.DataGridView.Columns.Contains(col) Then
                Return ""
            End If

            ' Access the value once
            Dim val = row.Cells(col).Value

            ' Check for both Nothing (null) and DBNull.Value
            If val Is Nothing OrElse val Is DBNull.Value Then
                Return ""
            End If

            Return val.ToString().Trim()
        End Function


        Private Sub ClearAddForm()
            If cmbAddState.Items.Count > 0 Then cmbAddState.SelectedIndex = 0
            If cmbAddMemberType.Items.Count > 0 Then cmbAddMemberType.SelectedIndex = 0
            txtMemberNumber.Clear()
            txtMemberName.Clear()
            cmbReceiptType.SelectedIndex = -1
            txtReceiptNo.Clear()
            dtpReceiptDate.Value = DateTime.Today
            txtAmount.Clear()
        End Sub

        Private Sub btnSaveRenewal_Click(sender As Object, e As EventArgs) Handles btnSaveRenewal.Click
            If cmbAddState.SelectedIndex <= 0 Then
                MessageBox.Show("Please select a State.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If cmbAddMemberType.SelectedIndex <= 0 Then
                MessageBox.Show("Please select a Member Type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If String.IsNullOrWhiteSpace(txtMemberNumber.Text) Then
                MessageBox.Show("Member Number is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim amt As Decimal = 0D
            If Not Decimal.TryParse(txtAmount.Text, amt) Then
                MessageBox.Show("Invalid amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                DBHelper.ExecuteNonQuery(
                    "sp_SaveRenewal",
                    DBHelper.NewParam("@RenewalId", SqlDbType.Int, currentRenewalId),
                    DBHelper.NewParam("@StateId", SqlDbType.Int, Convert.ToInt32(cmbAddState.SelectedValue)),
                    DBHelper.NewParam("@MemberTypeId", SqlDbType.Int, Convert.ToInt32(cmbAddMemberType.SelectedValue)),
                    DBHelper.NewParam("@MemberNumber", SqlDbType.NVarChar, txtMemberNumber.Text.Trim()),
                    DBHelper.NewParam("@MemberName", SqlDbType.NVarChar, txtMemberName.Text.Trim()),
                    DBHelper.NewParam("@ReceiptType", SqlDbType.NVarChar, If(cmbReceiptType.SelectedItem?.ToString(), "")),
                    DBHelper.NewParam("@ReceiptNo", SqlDbType.NVarChar, txtReceiptNo.Text.Trim()),
                    DBHelper.NewParam("@ReceiptDate", SqlDbType.Date, dtpReceiptDate.Value),
                    DBHelper.NewParam("@Amount", SqlDbType.Decimal, amt))

                MessageBox.Show("Renewal saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadRenewals()
                ShowMainPanel()
            Catch ex As Exception
                MessageBox.Show("Error saving renewal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnCancelRenewal_Click(sender As Object, e As EventArgs) Handles btnCancelRenewal.Click
            ShowMainPanel()
        End Sub

        Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
            ShowMainPanel()
        End Sub

        Private Function GetComboBoxIntValue(cmb As ComboBox, columnName As String) As Integer
            If cmb.SelectedValue Is Nothing Then Return 0

            Dim value = cmb.SelectedValue
            If TypeOf value Is DataRowView Then
                Dim rowView = CType(value, DataRowView)
                Return If(rowView(columnName) IsNot Nothing AndAlso Not IsDBNull(rowView(columnName)), 
                         Convert.ToInt32(rowView(columnName)), 0)
            Else
                Return If(value IsNot Nothing, Convert.ToInt32(value), 0)
            End If
        End Function

    End Class

End Namespace
