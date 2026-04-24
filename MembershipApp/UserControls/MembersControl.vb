Imports System.Data
Imports System.Data.SqlClient
Imports MembershipApp.Data

Namespace UserControls

    Public Class MembersControl

        Private currentMemberId As Integer = 0
        Private isEditMode As Boolean = False

        Private Sub MembersControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Skip initialization in design mode
            If Me.DesignMode Then Return

            LoadStates(cmbState)
            LoadMemberTypes(cmbMemberType)
            LoadStates(cmbAddState)
            LoadMemberTypes(cmbAddMemberType)
            LoadGenders()
            LoadRegisteredThroughs()
            ShowMainPanel()
            LoadMembers()
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
                ' Populate an empty list safely
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

        Private Sub LoadGenders()
            cmbGender.Items.Clear()
            cmbGender.Items.AddRange(New String() {"Male", "Female", "Other"})
        End Sub

        Private Sub LoadRegisteredThroughs()
            cmbRegisteredThrough.Items.Clear()
            cmbRegisteredThrough.Items.AddRange(New String() {"Online", "Agent", "Branch Office", "Referral"})
        End Sub

        Private Sub ShowMainPanel()
            mainPanel.BringToFront()
            mainPanel.Visible = True
            addMemberPanel.Visible = False
        End Sub

        Private Sub ShowAddMemberPanel()
            addMemberPanel.BringToFront()
            addMemberPanel.Visible = True
            mainPanel.Visible = False
        End Sub

#Region "Main Panel - Grid"

        Private Sub LoadMembers()
            Try
                Dim stateId As Integer = GetComboBoxIntValue(cmbState, "StateId")
                Dim memberTypeId As Integer = GetComboBoxIntValue(cmbMemberType, "MemberTypeId")
                Dim search As String = txtSearch.Text.Trim()

                Dim dt As DataTable = DBHelper.ExecuteDataTable(
                    "sp_GetMembers",
                    DBHelper.NewParam("@StateId", SqlDbType.Int, If(stateId = 0, DBNull.Value, CObj(stateId))),
                    DBHelper.NewParam("@MemberTypeId", SqlDbType.Int, If(memberTypeId = 0, DBNull.Value, CObj(memberTypeId))),
                    DBHelper.NewParam("@Search", SqlDbType.NVarChar, If(String.IsNullOrEmpty(search), DBNull.Value, CObj(search))))

                dgvMembers.DataSource = dt
                FormatMembersGrid()
            Catch ex As Exception
                MessageBox.Show("Error loading members: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub FormatMembersGrid()
            If dgvMembers.Columns.Count = 0 Then Return

            Dim headers As New Dictionary(Of String, String) From {
                {"StateName", "State Name"},
                {"MemberTypeName", "Member Type"},
                {"MemberNumber", "Member Number"},
                {"ApplicationNo", "Application No"},
                {"MemberName", "Member Name"},
                {"AddressLine1", "Address Line1"},
                {"AddressLine2", "Address Line2"},
                {"AddressLine3", "Address Line3"},
                {"Pincode", "Pincode"},
                {"MobileNo", "Mobile No"},
                {"AadharNumber", "Aadhar Number"},
                {"DOB", "DOB / Age"},
                {"Gender", "Gender"},
                {"Profession", "Profession"},
                {"RegisteredThrough", "Registered through"},
                {"RegisteredOn", "Registered On"}
            }

            For Each col As DataGridViewColumn In dgvMembers.Columns
                If headers.ContainsKey(col.Name) Then
                    col.HeaderText = headers(col.Name)
                End If
            Next

            If dgvMembers.Columns.Contains("MemberId") Then dgvMembers.Columns("MemberId").Visible = False
            If dgvMembers.Columns.Contains("StateId") Then dgvMembers.Columns("StateId").Visible = False
            If dgvMembers.Columns.Contains("MemberTypeId") Then dgvMembers.Columns("MemberTypeId").Visible = False
        End Sub

        Private Sub cmbState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbState.SelectedIndexChanged
            LoadMembers()
        End Sub

        Private Sub cmbMemberType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMemberType.SelectedIndexChanged
            LoadMembers()
        End Sub

        Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
            LoadMembers()
        End Sub

        Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
            cmbState.SelectedIndex = 0
            cmbMemberType.SelectedIndex = 0
            txtSearch.Clear()
            LoadMembers()
        End Sub

        Private Sub btnAddMember_Click(sender As Object, e As EventArgs) Handles btnAddMember.Click
            isEditMode = False
            currentMemberId = 0
            ClearAddForm()
            lblAddTitle.Text = "Add New Member"
            ShowAddMemberPanel()
        End Sub

        Private Sub dgvMembers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMembers.CellDoubleClick
            If e.RowIndex < 0 Then Return
            isEditMode = True
            Dim row As DataGridViewRow = dgvMembers.Rows(e.RowIndex)
            PopulateAddForm(row)
            lblAddTitle.Text = "Edit Member"
            ShowAddMemberPanel()
        End Sub

        Private Sub PopulateAddForm(row As DataGridViewRow)
            currentMemberId = Convert.ToInt32(row.Cells("MemberId").Value)

            If dgvMembers.Columns.Contains("StateId") AndAlso row.Cells("StateId").Value IsNot DBNull.Value Then
                cmbAddState.SelectedValue = Convert.ToInt32(row.Cells("StateId").Value)
            End If
            If dgvMembers.Columns.Contains("MemberTypeId") AndAlso row.Cells("MemberTypeId").Value IsNot DBNull.Value Then
                cmbAddMemberType.SelectedValue = Convert.ToInt32(row.Cells("MemberTypeId").Value)
            End If

            txtMemberNumber.Text = GetCellText(row, "MemberNumber")
            txtApplicationNo.Text = GetCellText(row, "ApplicationNo")
            txtMemberName.Text = GetCellText(row, "MemberName")
            txtAddress1.Text = GetCellText(row, "AddressLine1")
            txtAddress2.Text = GetCellText(row, "AddressLine2")
            txtAddress3.Text = GetCellText(row, "AddressLine3")
            txtPincode.Text = GetCellText(row, "Pincode")
            txtMobile.Text = GetCellText(row, "MobileNo")
            txtAadhar.Text = GetCellText(row, "AadharNumber")

            If row.Cells("DOB").Value IsNot DBNull.Value Then
                dtpDOB.Value = Convert.ToDateTime(row.Cells("DOB").Value)
            End If

            Dim gender As String = GetCellText(row, "Gender")
            If Not String.IsNullOrEmpty(gender) AndAlso cmbGender.Items.Contains(gender) Then
                cmbGender.SelectedItem = gender
            End If

            txtProfession.Text = GetCellText(row, "Profession")

            Dim regThrough As String = GetCellText(row, "RegisteredThrough")
            If Not String.IsNullOrEmpty(regThrough) AndAlso cmbRegisteredThrough.Items.Contains(regThrough) Then
                cmbRegisteredThrough.SelectedItem = regThrough
            End If

            If row.Cells("RegisteredOn").Value IsNot DBNull.Value Then
                dtpRegisteredOn.Value = Convert.ToDateTime(row.Cells("RegisteredOn").Value)
            End If
        End Sub

        Private Function GetCellText(row As DataGridViewRow, colName As String) As String
            ' Check if the column exists in the grid this row belongs to
            If Not row.DataGridView.Columns.Contains(colName) Then Return String.Empty

            ' Check for null or DBNull
            Dim cellValue = row.Cells(colName).Value
            If cellValue Is Nothing OrElse cellValue Is DBNull.Value Then
                Return String.Empty
            End If

            Return cellValue.ToString()
        End Function

#End Region

#Region "Add/Edit Panel"

        Private Sub ClearAddForm()
            If cmbAddState.Items.Count > 0 Then cmbAddState.SelectedIndex = 0
            If cmbAddMemberType.Items.Count > 0 Then cmbAddMemberType.SelectedIndex = 0
            txtMemberNumber.Clear()
            txtApplicationNo.Clear()
            txtMemberName.Clear()
            txtAddress1.Clear()
            txtAddress2.Clear()
            txtAddress3.Clear()
            txtPincode.Clear()
            txtMobile.Clear()
            txtAadhar.Clear()
            dtpDOB.Value = DateTime.Today.AddYears(-25)
            cmbGender.SelectedIndex = -1
            txtProfession.Clear()
            cmbRegisteredThrough.SelectedIndex = -1
            dtpRegisteredOn.Value = DateTime.Today
        End Sub

        Private Sub btnSaveMember_Click(sender As Object, e As EventArgs) Handles btnSaveMember.Click
            If Not ValidateAddForm() Then Return

            Try
                Dim stateId As Integer = GetComboBoxIntValue(cmbAddState, "StateId")
                Dim memberTypeId As Integer = GetComboBoxIntValue(cmbAddMemberType, "MemberTypeId")

                DBHelper.ExecuteNonQuery(
                    "sp_SaveMember",
                    DBHelper.NewParam("@MemberId", SqlDbType.Int, currentMemberId),
                    DBHelper.NewParam("@StateId", SqlDbType.Int, stateId),
                    DBHelper.NewParam("@MemberTypeId", SqlDbType.Int, memberTypeId),
                    DBHelper.NewParam("@MemberNumber", SqlDbType.NVarChar, txtMemberNumber.Text.Trim()),
                    DBHelper.NewParam("@ApplicationNo", SqlDbType.NVarChar, txtApplicationNo.Text.Trim()),
                    DBHelper.NewParam("@MemberName", SqlDbType.NVarChar, txtMemberName.Text.Trim()),
                    DBHelper.NewParam("@AddressLine1", SqlDbType.NVarChar, txtAddress1.Text.Trim()),
                    DBHelper.NewParam("@AddressLine2", SqlDbType.NVarChar, txtAddress2.Text.Trim()),
                    DBHelper.NewParam("@AddressLine3", SqlDbType.NVarChar, txtAddress3.Text.Trim()),
                    DBHelper.NewParam("@Pincode", SqlDbType.NVarChar, txtPincode.Text.Trim()),
                    DBHelper.NewParam("@MobileNo", SqlDbType.NVarChar, txtMobile.Text.Trim()),
                    DBHelper.NewParam("@AadharNumber", SqlDbType.NVarChar, txtAadhar.Text.Trim()),
                    DBHelper.NewParam("@DOB", SqlDbType.Date, dtpDOB.Value),
                    DBHelper.NewParam("@Gender", SqlDbType.NVarChar, If(cmbGender.SelectedItem?.ToString(), String.Empty)),
                    DBHelper.NewParam("@Profession", SqlDbType.NVarChar, txtProfession.Text.Trim()),
                    DBHelper.NewParam("@RegisteredThrough", SqlDbType.NVarChar, If(cmbRegisteredThrough.SelectedItem?.ToString(), String.Empty)),
                    DBHelper.NewParam("@RegisteredOn", SqlDbType.Date, dtpRegisteredOn.Value))

                MessageBox.Show("Member saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadMembers()
                ShowMainPanel()
            Catch ex As Exception
                MessageBox.Show("Error saving member: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Function ValidateAddForm() As Boolean
            If cmbAddState.SelectedIndex <= 0 Then
                MessageBox.Show("Please select a State.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            If cmbAddMemberType.SelectedIndex <= 0 Then
                MessageBox.Show("Please select a Member Type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            If String.IsNullOrWhiteSpace(txtMemberName.Text) Then
                MessageBox.Show("Member Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            Return True
        End Function

        Private Sub btnCancelMember_Click(sender As Object, e As EventArgs) Handles btnCancelMember.Click
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


#End Region

    End Class

End Namespace
