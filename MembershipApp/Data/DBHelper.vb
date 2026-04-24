Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Namespace Data

    ''' <summary>
    ''' Centralized ADO.NET data access helper.
    ''' All DB calls go through parameterized stored procedures to prevent SQL injection.
    ''' </summary>
    Public Class DBHelper

        Private Shared ReadOnly ConnectionString As String =
            ConfigurationManager.ConnectionStrings("MembershipDB").ConnectionString

        ''' <summary>
        ''' Execute a stored procedure and return a DataTable.
        ''' </summary>
        Public Shared Function ExecuteDataTable(spName As String, ParamArray params As SqlParameter()) As DataTable
            Dim dt As New DataTable()
            Using conn As New SqlConnection(ConnectionString)
                Using cmd As New SqlCommand(spName, conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    If params IsNot Nothing AndAlso params.Length > 0 Then
                        cmd.Parameters.AddRange(params)
                    End If
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
            Return dt
        End Function

        ''' <summary>
        ''' Execute a stored procedure that does not return rows. Returns affected rows.
        ''' </summary>
        Public Shared Function ExecuteNonQuery(spName As String, ParamArray params As SqlParameter()) As Integer
            Using conn As New SqlConnection(ConnectionString)
                Using cmd As New SqlCommand(spName, conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    If params IsNot Nothing AndAlso params.Length > 0 Then
                        cmd.Parameters.AddRange(params)
                    End If
                    conn.Open()
                    Return cmd.ExecuteNonQuery()
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Execute a stored procedure and return a single scalar value.
        ''' </summary>
        Public Shared Function ExecuteScalar(spName As String, ParamArray params As SqlParameter()) As Object
            Using conn As New SqlConnection(ConnectionString)
                Using cmd As New SqlCommand(spName, conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    If params IsNot Nothing AndAlso params.Length > 0 Then
                        cmd.Parameters.AddRange(params)
                    End If
                    conn.Open()
                    Return cmd.ExecuteScalar()
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Convenience factory for SqlParameter with DBNull handling.
        ''' </summary>
        Public Shared Function NewParam(name As String, dbType As SqlDbType, value As Object) As SqlParameter
            Dim p As New SqlParameter(name, dbType)
            p.Value = If(value, DBNull.Value)
            Return p
        End Function

    End Class

End Namespace
