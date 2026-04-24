Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports MembershipApp.Data

Namespace UserControls

    Public Class ReportsControl

        Private Sub ReportsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            cmbReportType.Items.Clear()
            cmbReportType.Items.Add("Member List")
            cmbReportType.Items.Add("Renewal List")
            cmbReportType.SelectedIndex = 0
            dtpFrom.Value = DateTime.Today.AddMonths(-6)
            dtpTo.Value = DateTime.Today
        End Sub

        Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
            Try
                Dim reportName As String = cmbReportType.SelectedItem.ToString()

                Select Case reportName
                    Case "Member List"
                        GenerateMemberListReport()
                    Case "Renewal List"
                        GenerateRenewalListReport()
                End Select
            Catch ex As Exception
                MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub GenerateMemberListReport()
            Dim dt As DataTable = DBHelper.ExecuteDataTable(
                "sp_Report_MemberList",
                DBHelper.NewParam("@FromDate", SqlDbType.Date, dtpFrom.Value),
                DBHelper.NewParam("@ToDate", SqlDbType.Date, dtpTo.Value))

            dgvReport.DataSource = dt
            lblReportTitle.Text = $"Member List Report  ({dtpFrom.Value:dd-MMM-yyyy} to {dtpTo.Value:dd-MMM-yyyy})"
            lblRecordCount.Text = $"Total Records: {dt.Rows.Count}"
        End Sub

        Private Sub GenerateRenewalListReport()
            Dim dt As DataTable = DBHelper.ExecuteDataTable(
                "sp_Report_RenewalList",
                DBHelper.NewParam("@FromDate", SqlDbType.Date, dtpFrom.Value),
                DBHelper.NewParam("@ToDate", SqlDbType.Date, dtpTo.Value))

            dgvReport.DataSource = dt
            lblReportTitle.Text = $"Renewal List Report  ({dtpFrom.Value:dd-MMM-yyyy} to {dtpTo.Value:dd-MMM-yyyy})"

            Dim totalAmount As Decimal = 0D
            For Each r As DataRow In dt.Rows
                If r("Amount") IsNot DBNull.Value Then totalAmount += Convert.ToDecimal(r("Amount"))
            Next

            lblRecordCount.Text = $"Total Records: {dt.Rows.Count}    Total Amount: ₹ {totalAmount:N2}"
        End Sub

        Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
            If dgvReport.Rows.Count = 0 Then
                MessageBox.Show("No data to export. Please generate a report first.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Using sfd As New SaveFileDialog()
                sfd.Filter = "CSV Files (*.csv)|*.csv"
                sfd.FileName = $"{cmbReportType.SelectedItem}_{DateTime.Now:yyyyMMdd_HHmmss}.csv"

                If sfd.ShowDialog() = DialogResult.OK Then
                    ExportDataGridViewToCsv(dgvReport, sfd.FileName)
                    MessageBox.Show("Report exported successfully.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        End Sub

        Private Sub ExportDataGridViewToCsv(grid As DataGridView, filePath As String)
            Dim sb As New StringBuilder()

            ' headers
            Dim headers As New List(Of String)
            For Each col As DataGridViewColumn In grid.Columns
                If col.Visible Then headers.Add(EscapeCsv(col.HeaderText))
            Next
            sb.AppendLine(String.Join(",", headers))

            ' rows
            For Each row As DataGridViewRow In grid.Rows
                If row.IsNewRow Then Continue For
                Dim fields As New List(Of String)
                For Each col As DataGridViewColumn In grid.Columns
                    If Not col.Visible Then Continue For
                    Dim val As Object = row.Cells(col.Index).Value
                    fields.Add(EscapeCsv(If(val?.ToString(), String.Empty)))
                Next
                sb.AppendLine(String.Join(",", fields))
            Next

            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8)
        End Sub

        Private Function EscapeCsv(value As String) As String
            If String.IsNullOrEmpty(value) Then Return ""
            If value.Contains(",") OrElse value.Contains("""") OrElse value.Contains(vbLf) OrElse value.Contains(vbCr) Then
                Return """" & value.Replace("""", """""") & """"
            End If
            Return value
        End Function

    End Class

End Namespace
